using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Projekt2020

{

    public static class Baza
    {
        public static SqlConnection konekcija()
        {
            return new SqlConnection(@"Data Source=DESKTOP-RQG3JK7\SQLEXPRESS;Initial Catalog=Projekt;Integrated Security=True");
        }
    }

}