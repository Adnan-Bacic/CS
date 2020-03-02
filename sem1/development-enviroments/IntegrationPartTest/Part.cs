using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntegrationPartTest
{
    public class Part
    {
        public int partno { get; set; }
        public string partname { get; set; }
        public decimal price { get; set; }
        public int instock { get; set; }

        public Part(int partno, string partname, decimal price, int instock)
        {
            this.partno = partno;
            this.partname = partname;
            this.price = price;
            this.instock = instock;
        }

        public override string ToString()
        {
            return "Part " + partno + " : " + partname + " costs " + price.ToString("F") + ". Number in stock : " + instock;
        }
    }
}