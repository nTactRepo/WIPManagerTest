using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIPManager
{
    public class POInfo
    {
        public string ID;
        public string SUPPLIER_ID;
        public string NAME;
        public string ORDER_DATE;
        public string BUYER;
        public string DESIRED_RECV_DATE;
        public string ORDER_STATUS;
        public string LAST_RECEIVED_DATE;
        public string PROMISE_DATE;
        public Vendor SUPPLIER;
        public List<POLine> POLines = new List<POLine>();
    }

    public class POLine
    {
        public string RECORD_ID;
        public string PURCHASE_ID;
        public string LINE_NO;
        public string LINE_STATUS;
        public string PO_LINE_TYPE;
        public string PART_ID;
        public string ORDER_QTY;
        public string USER_ORDER_QTY;
        public string PURCHASE_UM;
        public string RECEIVED_QTY;
        public string USER_RECEIVED_QTY;
        public string PROMISE_DATE;
        public List<POLink> POLinks = new List<POLink>();
    }

    public class POLink
    {
        public string PURCHASE_ID;
        public string PURCHASE_LINE_NO;
        public string WORK_ID;
        public string LOT_ID;
        public string SPLIT_ID;
        public string SUB_ID;
        public string SEQ_NO;
        public string PIECE_NO;
        public string QTY;
        public string RECEIVED_QTY;
        public POInfo PO = new POInfo();
    }

    public class RFQInfo
    {
        public string ID;
        public RFQSupplier SUPPLIER_1;
        public RFQSupplier SUPPLIER_2;
        public RFQSupplier SUPPLIER_3;
        public string RFQ_DATE;
        public string DUE_DATE;
        public string BUYER;
        public string RFQ_STATUS;
        public List<RFQLine> RFQLines = new List<RFQLine>();
    }

    public class RFQSupplier
    {
        public string SUPPLIER_ID;
        public string QUOTE_REF;
        public string AS_OF_DATE;
        public string EXP_DATE;
        public bool QUOTE_RECVD;
    }
    public class RFQLine
    {
        public string RECORD_ID;
        public string RFQ_ID;
        public string LINE_NO;
        public string LINE_TYPE;
        public string LINE_STATUS;
        public string PART_ID;
        public string DESCRIPTION;
        public string PURCHASE_UM;
        public string DESIRECED_RECV_DATE;
        public List<RFQLink> RFQLinks = new List<RFQLink>();
    }
    public class RFQLink
    {
        public string RECORD_ID;
        public string RFQ_ID;
        public string LINE_NO;
        public string WORK_ID;
        public string LOT_ID;
        public string SPLIT_ID;
        public string SUB_ID;
        public string SEQ_NO;
        public string PIECE_NO;
        public string QTY;
        public RFQInfo RFQ = new RFQInfo();
    }
    //public class WorkOrder
    //{
    //    public string WorkID;
    //    public string LotID;
    //    public string SplitID;
    //    public string SubID;
    //    public string PartID;
    //    public string Description;
    //    public string EngID;
    //    public string Status;
    //    public DateTime ReleaseDate;
    //    public DateTime ClosedDate;
    //    public DateTime WantDate;
    //    public DateTime ScheduledStartDate;
    //    public DateTime ScheduledFinishDate;
    //    public DateTime PrintedDate;
    //    public Single ReqQty;
    //    public Single RcvdQty;
    //}

    public class Master
    {
        public string PartID;
        public string EngID;
        public string SubID;
        public string Description;
        public string GlobalRank;
        public Single DesiredQty;
        public string EngineeredBy;
        public DateTime EngineeredDate;
        public string DrawingFile;
        public string ProductCode;
        public string CommodityCode;
        public bool Inactive;
    }
    public class Operation
    {
        public string SeqNo;
        public string ResourceID;
        public string Description;
    }

    //public class Material
    //{
    //    public string RecordID;
    //    public string WorkID;
    //    public string LotID;
    //    public string SplitID;
    //    public string SubID;
    //    public string SeqNo;
    //    public string PieceNo;
    //    public string PartID;
    //    public string Description;
    //    public string Status;
    //    public string BuildState;
    //    public string WIPLocation;
    //    public string PickedBy;
    //    public Single ReqQty;
    //    public Single IssuedQty;
    //    public List<POLink> POLinks = new List<POLink>();
    //    public List<RFQLink> RFQLinks = new List<RFQLink>();
    //}

    public class MasterMaterial
    {
        public string RecordID;
        public string PartID;
        public string EngID;
        public string SubID;
        public string SeqNo;
        public string PieceNo;
        public string SubOrd_Sub_ID;
        public string SubOrd_Part_ID;
        public string SubOrd_Eng_ID;
        public string Description;
        public string Status;
        public Single ReqQty;
    }
    public class PartInfo
    {
        public string ID;
        public string DESCRIPTION;
        public string COMMODITY_CODE;
        public bool FABRICATED;
        public bool PURCHASED;
        public bool STOCKED;
        public string ENG_ID;
        public string STOCK_UM;
        public string USAGE_UM;
        public string PURCHASE_UM;
        public string SELLING_UM;
        public string PRIMARY_LOC_ID;
        public string DRAWING_FILE;
        public string LASTMODIFIED;
        public string MODIFIEDBY;
        public string MANUFACTURER;
        public string MFG_PART_NO;
        public bool AUTO_ISSUE;
        public string AUTO_ISSUE_LOC;
        public bool INACTIVE;
        public Single UNIT_MAT_COST;
        public Single UNIT_LAB_COST;
        public Single UNIT_BUR_COST;
        public Single UNIT_SER_COST;
        public Single FIXED_COST;
        public List<LocationInfo> LOCATIONS = new List<LocationInfo>();
        public List<POInfo> POs = new List<POInfo>();

        public Single UnitCost()
        {
            Single sRetVal = 0;
            if (PURCHASED && FABRICATED)
                sRetVal = UNIT_MAT_COST + UNIT_LAB_COST + UNIT_BUR_COST + UNIT_SER_COST + FIXED_COST;
            else if (FABRICATED)
                sRetVal = UNIT_MAT_COST + UNIT_LAB_COST + UNIT_BUR_COST + UNIT_SER_COST;
            else if (PURCHASED)
                sRetVal = UNIT_MAT_COST + FIXED_COST;
            return sRetVal;
        }
        public Single OnHand()
        {
            Single sRetVal = 0;
            if (LOCATIONS != null)
            {
                foreach (LocationInfo thisLocation in LOCATIONS)
                {
                    if (!thisLocation.INACTIVE)
                        sRetVal = sRetVal + thisLocation.QTY_ON_HAND;
                }
            }
            return sRetVal;
        }

        public string LocToString()
        {
            string retString = "";
            if (LOCATIONS != null)
            {
                foreach (LocationInfo thisLocation in LOCATIONS)
                {
                    if (!thisLocation.INACTIVE)
                    {
                        if (retString != "")
                            retString = retString + ",";
                        retString = retString + thisLocation.ToString();
                    }
                }
            }
            return retString;
        }
    }
    public class Vendor
    {
        public string NAME;
        public string CONTACT_NAME;
        public string CONTACT_PHONE;
        public string CONTACT_EMAIL;
        public string CONTACT_MOBILE;
    }

    public class FileResult
    {
        public string FileName;
        public string Folder;
        public DateTime DateModified;
    }

    public class User
    {
        public string UserID ="";
        public string UserName = "";
        public string FirstName = "";
        public string LastName = "";
        public bool IsAdmin = false;
        public bool IsProjectLead = false;
        public bool IsProjectEditor = false;
        public bool IsVisualEditor = false;
    }

    public class UoM
    {
        public string ID;
        public string DESCRIPTION;
    }

    public class UoM_Conversion
    {
        public string TO_UNIT_ID;
        public string FROM_UNIT_ID;
        //[VJS580].[dbo].[INVENTORY_UNITS_CONVERSION]
    }

    public class LocationInfo
    {
        public string LOC_ID;
        public Single QTY_ON_HAND;
        public bool INACTIVE;
        public override string ToString()
        {
            return LOC_ID + "(" + QTY_ON_HAND.ToString() + ")";
        }
    }

    public class Location
    {
        public string LOC_ID;
        public string DESCRIPTION;
        public bool INACTIVE;
    }
    public enum Role { ADMIN, VIEWONLY, ECN, ENGINEER, INVENTORY, MACHINIST, PURCHASER }

    public enum ItemType { WorkOrder, PartNumber, UoM }

    public enum OrderStatus { CANCELLED, CLOSED, FIRM, HOLD, RELEASED, UNRELEASED}

    public enum BrowsingType { WorkOrders, Projects, Parts}
}
