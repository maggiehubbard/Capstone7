using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BonusLab.Models
{
    public class DisplayProduct
    {
        public int productID { get; set; }
        public string productName { get; set; }
    

    public DisplayProduct(int productID, string productName)
    {
            this.productID = productID;
            this.productName = productName;
    }
    }
}