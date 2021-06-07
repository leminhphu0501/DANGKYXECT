using System.Data.SqlClient;

namespace DAL_DangKyXeCT
{
    public class DBConnect
    {
        protected SqlConnection _conn = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=DANGKYXE;Integrated Security=True");
    }
}

