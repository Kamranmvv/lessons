using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Product : Accounting
    {
       
        public string Barcode {
            get
            {
                return "";
            }
            set
            {
                 Barcode = value;
                NewItem(Barcode);

            }
        }
        public string Brand { get; set; }
        public string Model { get; set; }

    }
}
