using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV.DAO
{
    class DataProvide
    {
        static private string strconn = "Data source=DESKTOP-8OSB8I3; Initial Catalog=DAMH_KHIEM_HUY;Integrated Security= true";
        protected SqlConnection conn=new SqlConnection(strconn);
    }
}
