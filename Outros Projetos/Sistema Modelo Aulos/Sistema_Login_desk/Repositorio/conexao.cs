using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Login_desk.Repositorio
{
    public class conexao
    {
        SqlConnection con = new SqlConnection();

        public conexao()
        {
            con.ConnectionString = @"Data Source=localhost;Initial Catalog=SYSLOGIN;Integrated Security = True";

            //"User ID = sa; Initial Catalog = SYSLOGIN; Data Source =(local); Password = 1234567"
            //Data Source = wellnote; Initial Catalog = SYSLOGIN; Integrated Security = True
        }

        public SqlConnection Conectar()
        {
            if(con.State==System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public void desconectar()
        {
            if(con.State==System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
