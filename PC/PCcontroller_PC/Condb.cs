using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Net.Mail;
using MySql.Data.MySqlClient;

/// <summary>
/// Summary description for condb
/// </summary>
public class Condb
{
    private string connectionString = "server=107.180.47.59;  port=3306; database=PC_Controller; ";
    MySqlConnection con;
    public Condb()
    {
        con = new MySqlConnection(connectionString);
    }
    public void Connect()
    {
        con.Open();
    }
    public void Disconnect()
    {
        con.Close();
    }
    public object ExeScalar(string sql)
    {
        //trj3 qeme w7de (kol lanwa3)
        MySqlCommand com = new MySqlCommand(sql, con);
        return (com.ExecuteScalar());
    }
    public DataTable ExeTable(string sql)
    {
        MySqlDataAdapter ad = new MySqlDataAdapter(sql, con);
        DataTable dt = new DataTable();
        ad.Fill(dt);
        return dt;
    }
    public void ExeNonquerry(string sql)
    {
        MySqlCommand com = new MySqlCommand(sql, con);
        com.ExecuteNonQuery();

    }


}
