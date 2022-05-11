using Bookmaster3000_Mironow_Volkov.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookmaster3000_Mironow_Volkov.AppData
{
    struct CountID
    {
        public static int ID { get; set; }
        public static string Create()
        {
            ID = int.Parse(HelpModel.GetContext().Customers.Max(c => c.Id).Trim('C'));
            ID += 1;
            return 'C' + ID.ToString();
        }
    }
}
