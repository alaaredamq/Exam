using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Soap {
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1: IService1 {

        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString);

        public DataSet UsersWithNoAccounts() {
            SqlCommand cmd = new SqlCommand("dbo.NoAccounts", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            if (conn.State != ConnectionState.Closed) {
                conn.Close();
            }
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            conn.Close();
            return ds;
        }

    }
}
