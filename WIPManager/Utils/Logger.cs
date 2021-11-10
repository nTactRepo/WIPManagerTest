using System;
using System.Collections;
using System.Threading;
using System.IO;

namespace WIPManager.Utils
{
    public enum LogLevel
    {
				ALARM=0,
				ERROR,
				WARN,
				INFO,
				DEBUG,
				ANY
    }

	/// <summary>
	/// Log Message Structure.
	/// </summary>
    public struct LoggerMessage
	{
		public int level;
		public string level_desc;
		public string tag;
		public string message;
		public long time;
	}

	/// <summary>
	/// Event Handler for the Logger.
	/// </summary>
    public abstract class LoggerEventHandler
	{
		private bool alive = false;
		private Queue q = null;
		private Thread dispatch = null;
		protected string[] logLevelDescriptors = null;
        private string _sName;
        public DateTime PrevDate;
        public string FilePath;
        public string LogName;
        
       /// <summary>
       /// Name of logger and associated thread.
       /// </summary>
        public string Name
        {
            get { return _sName; }
            set
            {
                _sName = value;
                dispatch.Name = _sName;
            }
        }

		public LoggerEventHandler( )
		{
			q = Queue.Synchronized(new Queue(1000));
			start();
		}

		/// <summary>
		/// Start thread for logging messages to file.
		/// </summary>
        public void start()
		{
			if (alive) return;

			alive = true;
			dispatch = new Thread(new ThreadStart(dispatchMessages));
			dispatch.Start();
		}

		/// <summary>
		/// Shutdown logger and write all remaining queued messages.
		/// </summary>
        public void shutdown()
		{
			if (!alive) return;

			alive = false;
			Monitor.Enter(q);
			Monitor.PulseAll(q);
			Monitor.Exit(q);
		}

		/// <summary>
		/// Shutdown logger and discard all remaining queued messages.
		/// </summary>
        public void abort()
		{
			if (!alive) return;

			alive = false;
			dispatch.Abort();
		}

		/// <summary>
		/// Thread to queue and write messages.
		/// </summary>
        protected void dispatchMessages()
		{
			while (alive)
			{
				while((q.Count != 0) && alive)
				{
					log((LoggerMessage)q.Dequeue());
				}

				if ((alive) && (q.Count == 0))
				{
					Monitor.Enter(q);
					if (q.Count == 0) Monitor.Wait(q);
					Monitor.Exit(q);
				}
			}

			while (q.Count != 0)
			{
				log((LoggerMessage)q.Dequeue());
			}

			onShutdown();

            dispatch = null;
		}

		/// <summary>
		/// Send log message to logging que.
		/// </summary>
		/// <param name="tag"></param>
		/// <param name="level"></param>
		/// <param name="level_desc"></param>
		/// <param name="message"></param>
        public void log(string tag, int level, string level_desc, string message)
		{
			if (!alive) return;

			LoggerMessage lm = new LoggerMessage();
			lm.message = message;
			lm.tag = tag;
			lm.level = level;
			lm.level_desc = level_desc;
			lm.time = System.DateTime.Now.ToFileTime();

			q.Enqueue(lm);

			Monitor.Enter(q);
			Monitor.PulseAll(q);
			Monitor.Exit(q);
		}

		protected abstract void log(LoggerMessage message);

		protected abstract void onShutdown();
	}

	public class BasicFileLogEventHandler : LoggerEventHandler
	{
		StreamWriter stream = null;
		bool append = true;

        public BasicFileLogEventHandler(String filePath, String fileName, String sName)
		{
            this.FilePath = filePath;
            this.LogName = fileName;
            this.Name = sName;

			string logDir = Path.Combine(Directory.GetCurrentDirectory(), filePath);

			if (!Directory.Exists(logDir))
			{
				Directory.CreateDirectory(logDir);
			}

            string logFile = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString("00") + DateTime.Now.Day.ToString("00") + fileName + ".log";
            if (logFile != null)
			{
				FileMode fm;

				if (append)fm=FileMode.Append;
				else fm=FileMode.Create;

                FileStream fs = new FileStream(Path.Combine(filePath, logFile), fm, FileAccess.Write, FileShare.Read);
                this.PrevDate = DateTime.Now;
				stream = new StreamWriter(fs, System.Text.Encoding.UTF8, 4096);
                stream.AutoFlush = true;

			}
		}

        private void RollLog()
        {
            stream.Flush();
            stream.Close();

            //string logFile = DateTime.Now.ToShortDateString().Replace(@"/", @"-").Replace(@"\", @"-") + " " + this.LogName + ".log";
            string logFile = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString("00") + DateTime.Now.Day.ToString("00") + this.LogName + ".log";
            if (logFile != null)
            {
                FileMode fm;

                if (append) fm = FileMode.Append;
                else fm = FileMode.Create;

                FileStream fs = new FileStream(Path.Combine(this.FilePath, logFile), fm, FileAccess.Write, FileShare.Read);
                this.PrevDate = DateTime.Now;
                stream = new StreamWriter(fs, System.Text.Encoding.UTF8, 4096);
                stream.AutoFlush = true;
            }
        }

		override protected void log(LoggerMessage message)
		{
            DateTime curDate = DateTime.Now;
			if (stream == null) return;
			string time = System.DateTime.FromFileTime(message.time).ToString();
            if (!PrevDate.Date.Equals(curDate.Date))
            {
                RollLog();
            }
			string sMessage = time + " ["+ message.tag + "] " + message.message + "\r\n";
			stream.Write(sMessage);
		}

		protected override void onShutdown()
		{
			if (stream != null)
			{
				stream.Flush();
				stream.Close();
			}
		}

		public void setAppend(bool flag)
		{
			this.append = flag;
		}

		/// <summary>
		/// Get's append flag
		/// </summary>
		/// <returns></returns>
		public bool getAppend()
		{
			return append;
		}
	}

	/// <summary>
	/// Logger class.
	/// </summary>
    public class Logger
	{
		private static Logger logger;
		protected static string[] logLevelDesc = null;
        public string Name = "";

		protected LoggerEventHandler[][] leh;
		protected uint max = 0;
		protected uint levels = 0;
		protected LoggerEventHandler defaultHandler = null;
	
		public Logger(uint levels, LoggerEventHandler defaultHandler)
		{
			init(levels, defaultHandler);
		}

		/// <summary>
        /// Opens up a logger with the specified number of log levels.
		/// </summary>
		/// <param name="levels"></param>
		/// <param name="filename"></param>
		/// <param name="sName"></param>
        public Logger(uint levels, string filePath, string fileName, string sName)
		{
            this.Name = sName;
            init(levels, new BasicFileLogEventHandler(filePath, fileName, sName));
		}

		public Logger(uint levels)
		{
			init(levels, null);
		}

		public Logger promoteToStatic()
		{
			logger = this;
			return logger;
		}

		/// <summary>
		/// Create instance of logger.
		/// </summary>
		/// <param name="sName"></param>
		/// <returns></returns>
        public static Logger singleton(string sPath, string sLogName, string sThreadName)
		{
			if (logger == null)
			{
                logger = new Logger(6, sPath, sLogName, sThreadName);
				logLevelDesc = new string[6];
                logLevelDesc[0] = "ALARM";
				logLevelDesc[1] = "ERROR";
				logLevelDesc[2] = "WARN";
				logLevelDesc[3] = "INFO";
				logLevelDesc[4] = "DEBUG";
				logLevelDesc[5] = "ANY";
			}
			
			return logger;
		}

		private void init(uint levels, LoggerEventHandler defaultHandler)
		{
			this.levels = levels;
			this.defaultHandler = defaultHandler;
			this.max = levels - 1;

			leh = new LoggerEventHandler[levels][];

			LoggerEventHandler[] handler = new LoggerEventHandler[1];

			handler[0] = defaultHandler;

			for(int i =0; i < levels; i++)
			{
				leh[i] = handler;
			}
		}


		public void setMaximumLogLevel(uint max)
		{
			this.max = max;
		}

		public uint getMaximumLogLevel()
		{
			return max;
		}

		public LoggerEventHandler getDefaultLoggerEventHandler()
		{
			return this.defaultHandler;
		}

		public void addSpecialLoggerToAllLevels(LoggerEventHandler handler)
		{
			if (handler == null) return;

			for(int level = 0; level < this.levels; level++)
			{
				addSpecialLogger(level, handler);
			}
		}

		public void addSpecialLogger(int level, LoggerEventHandler handler)
		{
			if (level < levels)
			{
				if (leh[level] != null)
				{
					int size = leh[level].Length + 1;
					LoggerEventHandler[] temp = new LoggerEventHandler[size];

					for (int i = 0; i < leh[level].Length; i++)
					{
						temp[i] = leh[level][i];
					}

					temp[size-1] = handler;

					leh[level] = temp;
				}
				else
				{
					leh[level] = new LoggerEventHandler[1];
					leh[level][0] = handler;
				}
			}
		}

		public void addSpecialLogger(int level, string filePath, string fileName, string sName)
		{
            addSpecialLogger(level, new BasicFileLogEventHandler(filePath,fileName, sName));
		}

		public void log(LogLevel logLevel, string tag, string message)
		{
            int level = (int)logLevel;
			if ((level <= max) && (level < levels) && (leh[level] != null))
			{
				for(int i = 0; i < leh[level].Length; i++)
				{
					if (logLevelDesc == null)
					{
						if (leh[level][i] != null) leh[level][i].log(tag, level, "", message);
					}
					else
					{
						if (leh[level][i] != null) leh[level][i].log(tag, level, logLevelDesc[level], message);
					}
				}
			}
		}

		public void shutdown()
		{
			for (int level = 0; level < leh.Length; level++)
			{
				for(int i = 0; i < leh[level].Length; i++)
				{
					leh[level][i]?.shutdown();
				}
			}
		}

        /// <summary>
        /// Purge log files older than nDays. Returns true if successful, false if error occurs.
        /// </summary>
        /// <param name="nDays"></param>
        /// <returns></returns>
        public bool PurgeLogs(int nDays)
        {
            bool bReturn = true;

            try
            {
                DateTime dtOldestDay = DateTime.Now.Subtract(new TimeSpan(nDays, 0, 0, 0));
                dtOldestDay = dtOldestDay.Subtract(new TimeSpan(0, dtOldestDay.Hour, dtOldestDay.Minute, dtOldestDay.Second, dtOldestDay.Millisecond));
                DirectoryInfo di = new DirectoryInfo(this.defaultHandler.FilePath);
                FileInfo[] logFiles = di.GetFiles("*" + this.defaultHandler.LogName + ".log", SearchOption.TopDirectoryOnly);
                foreach (FileInfo curFile in logFiles)
                {
                    try
                    {
                        DateTime dtLogFileTime = curFile.CreationTime;
                        if (dtLogFileTime < dtOldestDay)
                        {
                            this.log(LogLevel.ERROR, "PURGE", String.Format("Deleting Log: {0}", curFile.Name));
                            curFile.Delete();
                        }
                    }
                    catch (Exception ex1)
                    {
                        bReturn = false;
                        this.log(LogLevel.ERROR, "PURGE", "Caught Execption while deleting log files : " + ex1.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                bReturn = false;
                this.log(LogLevel.ERROR, "PURGE", "Caught Execption while deleting log files : " + ex.Message);
            }

            return bReturn;
        }
    }
}
