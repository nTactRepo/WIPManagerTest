using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIPManager.Model
{
    internal class RowData
    {
        public Material Material;
        public SelectionData SelectionData;

        public RowData() { }

        public RowData(Material material, SelectionData selectionData)
        {
            Material = material;
            SelectionData = selectionData;
        }
    }

    internal class SelectionData
    {
        public int NumSelected = 0;
        public int TotalItems;
        public int TotalRemaining;
        public string RecordId;
        public LocationString Locations;

        public SelectionData(string locationsString, int totalItems, string recordId)
        {
            TotalItems = totalItems;
            TotalRemaining = TotalItems;
            RecordId = recordId;

            Locations = new LocationString(locationsString);
            TotalRemaining -= Locations.TotalCount;
            TotalRemaining = (TotalRemaining < 0) ? 0 : TotalRemaining;
        }

        public void Clear()
        {
            NumSelected = 0;
            TotalItems = 0;
            TotalRemaining = 0;
            RecordId = "";
            Locations.ClearAllLocations();
        }

        public void AddLocation(string locString, int numSelected)
        {
            Locations.AddLocation(locString, numSelected);
            TotalRemaining -= numSelected;
        }

    }

}
