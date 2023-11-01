using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLiSV
{
    class KetNoi
    {
        public SqlConnection connect;
        public KetNoi()
        {
            connect = new SqlConnection("Data Soure=<A209PC33>; Intial Catalog= <Phong>; Ingerated Security = True");
        }
        public KetNoi(string strcn)
        {
            connect = new SqlConnection(strcn);
        }
    }
}
