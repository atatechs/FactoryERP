using STORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryERP_BAL
{
    public class Item : BusinessObject<Item>
    {
        public string ItemName { get { return GetFieldData("ItemName"); } set { SetFieldData("ItemName", value); } }
        public int Price { get { return GetFieldData("Price"); } set { SetFieldData("Price", value); } }
        public string Vendor { get { return GetFieldData("Vendor"); } set { SetFieldData("Vendor", value); } }

        public Item()
        {
        }

        public Item(string ItemName, int Price, string Vendor)
        {
            Dictionary<string, object> Collection = new Dictionary<string, object>();
            Collection.Add("ItemName", ItemName);
            Collection.Add("Price", Price);
            Collection.Add("Vendor", Vendor);
            InsertBO(Collection);
        }

        public static Item GetItemBy(string ItemName)
        {
            Dictionary<string, object> Collection = new Dictionary<string, object>();
            Collection.Add("ItemName", ItemName);
            return GetBOByKey(Collection);
        }

        public override Dictionary<string, object> UpdatedCollection()
        {
            Dictionary<string, object> Collection = new Dictionary<string, object>();
            Collection.Add("ItemName", ItemName);
            Collection.Add("Price", Price);
            Collection.Add("Vendor", Vendor);
            return Collection;
        }
    }

    public class Invoice : BusinessObject<Invoice>
    {
        public List<LineItem> LineItemList { get { return GetSubBOList(typeof(LineItem)); } set { SetSubBOList(value, typeof(LineItem)); } }

        public string InvoiceNo { get { return GetFieldData("InvoiceNo"); } set { SetFieldData("InvoiceNo", value); } }
        public DateTime InvoiceDate { get { return GetFieldData("InvoiceDate"); } set { SetFieldData("InvoiceDate", value); } }
        public int Amount { get { return GetFieldData("Amount"); } set { SetFieldData("Amount", value); } }
        public double Discount { get { return GetFieldData("Discount"); } set { SetFieldData("Discount", value); } }
        public bool Status { get { return GetFieldData("Status"); } set { SetFieldData("Status", value); } }

        public Invoice()
        {
        }

        public Invoice(string InvoiceNo, DateTime InvoiceDate, int Amount, double Discount, bool Status, List<LineItem> LineItemList)
        {
            Dictionary<string, object> Collection = new Dictionary<string, object>();
            Collection.Add("InvoiceNo", InvoiceNo);
            Collection.Add("InvoiceDate", InvoiceDate);
            Collection.Add("Amount", Amount);
            Collection.Add("Discount", Discount);
            Collection.Add("Status", Status);
            Collection.Add("LineItem", LineItemList);
            InsertBO(Collection);
        }

        public static Invoice GetInvoiceBy(string InvoiceNo)
        {
            Dictionary<string, object> Collection = new Dictionary<string, object>();
            Collection.Add("InvoiceNo", InvoiceNo);
            return GetBOByKey(Collection);
        }

        public static Invoice GetInvoiceBy(int Amount, DateTime InvoiceDate)
        {
            Dictionary<string, object> Collection = new Dictionary<string, object>();
            Collection.Add("Amount", Amount);
            Collection.Add("InvoiceDate", InvoiceDate);
            return GetBOByKey(Collection);
        }

        public override Dictionary<string, object> UpdatedCollection()
        {
            Dictionary<string, object> Collection = new Dictionary<string, object>();
            Collection.Add("InvoiceNo", InvoiceNo);
            Collection.Add("InvoiceDate", InvoiceDate);
            Collection.Add("Amount", Amount);
            Collection.Add("Discount", Discount);
            Collection.Add("Status", Status);
            Collection.Add("LineItem", LineItemList);
            return Collection;
        }
    }

    public class LineItem : SubBO<LineItem>
    {
        public Item Item { get { return GetFieldData("Item"); } set { SetFieldData("Item", value); } }
        public int Quantity { get { return GetFieldData("Quantity"); } set { SetFieldData("Quantity", value); } }

        public LineItem()
        {
        }

        public LineItem(Item Item, int Quantity)
        {
            this.Item = Item;
            this.Quantity = Quantity;
        }
    }
}
