﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace WindowsFormsApp2
{
    internal class conection
    {
        private static string stringConnection = @"Data Source=ANHTUAN\MSSVQLSERVER;Initial Catalog=QLHS;Integrated Security=True;Encrypt=False";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }

    }
}
