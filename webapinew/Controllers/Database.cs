﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace webapinew.Controllers
{
    public class Database
    {

    public static DataTable Read_Table(string StoredProcedureName, Dictionary<string, object> dic_param = null)
        {
            string SQLconnectionString = ConfigurationManager.ConnectionStrings["Connectionstring"].ConnectionString; DataTable result = new DataTable("table1"); using (SqlConnection conn = new SqlConnection(SQLconnectionString))
            {
                conn.Open(); SqlCommand cmd = conn.CreateCommand(); cmd.Connection = conn; cmd.CommandText = StoredProcedureName; cmd.CommandType = CommandType.StoredProcedure; if (dic_param != null) { foreach (KeyValuePair<string, object> data in dic_param) { if (data.Value == null) { cmd.Parameters.AddWithValue("@" + data.Key, DBNull.Value); } else { cmd.Parameters.AddWithValue("@" + data.Key, data.Value); } } }
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(); da.SelectCommand = cmd; da.Fill(result);

                }
                catch (Exception ex)
                {

                }
            }
            return result;
        } 

    public static DataTable LayDSLoaiHoa()
        {
            DataTable tb = Read_Table("LayDsloaihoa");
            return tb;
        }


    }
}