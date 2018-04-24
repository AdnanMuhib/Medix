using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class items
    {
        private string invoice_nmber;
        private string item_name;
        private string item_qty;
        private string item_price;
        private int item_total;

        public string Invoice_nmber
        {
            get
            {
                return invoice_nmber;
            }

            set
            {
                invoice_nmber = value;
            }
        }

        public string Item_name
        {
            get
            {
                return item_name;
            }

            set
            {
                item_name = value;
            }
        }

        public string Item_qty
        {
            get
            {
                return item_qty;
            }

            set
            {
                item_qty = value;
            }
        }

        public string Item_price
        {
            get
            {
                return item_price;
            }

            set
            {
                item_price = value;
            }
        }

        public int Item_total
        {
            get
            {
                return int.Parse(item_price) * int.Parse(Item_qty);
            }

        }
    }
}
