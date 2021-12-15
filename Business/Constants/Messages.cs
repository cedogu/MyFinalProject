using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        //static verince New yapmaya gerek yok, bir daha instance almayız.

        public static string ProductAdded = "Product added";
        public static string ProductNameInValid = "Invalid product";
        internal static string MaintenanceTime = "System is now in maintenance";
        internal static string ProductListed="products listed";
    }
}
