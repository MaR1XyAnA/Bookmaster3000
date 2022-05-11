using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bookmaster3000_Mironow_Volkov.Model
{
    class HelpModel
    {
        private static BoockMaster3000MiRoNoV123Entities _context;
        public static BoockMaster3000MiRoNoV123Entities GetContext()
        {
            if (_context == null)
            {
                _context = new BoockMaster3000MiRoNoV123Entities();
            }
            return _context;
        }
    }
}
// metadata=res://*/Model.Model1.csdl|res://*/Model.Model1.ssdl|res://*/Model.Model1.msl;provider=System.Data.SqlClient;provider connection string="data source=SQL;initial catalog=BoockMaster3000MiRoNoV123;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"
// BoockMaster3000MiRoNoV123Entities