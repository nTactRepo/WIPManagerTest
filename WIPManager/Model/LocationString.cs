using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIPManager
{
    class LocationString
    {
        #region Constants

        public static readonly char separator = ',';
        public static readonly string MFG = "MFG";

        #endregion

        #region Data Members

        private Dictionary<string, int> _locations = new Dictionary<string, int>();

        #endregion

        #region Properties

        public int TotalCount
        {
            get
            {
                int count = 0;

                foreach (var entry in _locations)
                {
                    count += entry.Value;
                }

                return count;
            }
        }

        public List<string> Locations
        {
            get
            {
                List<string> list = new List<string>();
                list.AddRange(_locations.Keys.ToList());

                if (OnMfgFloor)
                {
                    list.Add(MFG);
                }

                return _locations.Keys.ToList();
            }
        }

        public bool OnMfgFloor { get; set; } = false;

        #endregion

        #region Public Functions

        public LocationString(string locStr)
        {
            ParseString(locStr);
        }

        public override string ToString()
        {
            string ret = OnMfgFloor ? MFG : "";

            foreach (var entry in _locations)
            {
                if (ret.Length > 0)
                {
                    ret += separator;
                }

                ret += entry.Key + '(' + entry.Value + ')';
            }

            return ret;
        }

        public void AddLocation(string location, int number)
        {
            UpdateLocation(location, number);
        }

        public void ClearAllLocations()
        {
            _locations.Clear();
        }

        public int LocationCount(string locationName)
        {
            int count = 0;

            if (_locations.ContainsKey(locationName))
            {
                count = _locations[locationName];
            }

            return count;
        }

        #endregion

        #region Private Functions

        private void ParseString(string locString)
        {
            // Format:  "J1(2) J2(4) J3(1)"
            // Format:  "MFG_FLOOR WIP_E2(1)"

            if (!string.IsNullOrEmpty(locString))
            {
                char[] separators = new char[] { separator };
                var entries = locString.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                foreach (var entry in entries)
                {
                    ParseEntry(entry);
                }
            }
        }

        private void ParseEntry(string entry)
        {
            // Format:  "WIP_E3(15)"
            // Format:  "MFG_FLOOR"

            if (entry.Equals(MFG))
            {
                OnMfgFloor = true;
                return;
            }

            var first = entry.IndexOf('(');
            var last = entry.IndexOf(')');

            if (first == -1 || last == -1 || first >= last || first == 0)
            {
                return;
            }

            var location = entry.Substring(0, first);
            var amountStr = entry.Substring(first + 1, last - first - 1);
            int amount;

            if (!int.TryParse(amountStr, out amount))
            {
                return;
            }

            UpdateLocation(location, amount);
        }

        private void UpdateLocation(string location, int amount)
        {
            if (_locations.ContainsKey(location))
            {
                _locations[location] += amount;
            }
            else
            {
                _locations[location] = amount;
            }
        }

        #endregion
    }
}
