using System;
using System.Data;
using System.Data.OleDb;

namespace PaintSalesApp
{
    public class DatabaseHelper
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PaintSales.accdb;";

        public DataTable ExecuteQuery(string query)
        {
            DataTable dt = new DataTable();
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
                adapter.Fill(dt);
            }
            return dt;
        }

        public void ExecuteNonQuery(string query)
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
        }

        public object ExecuteScalar(string query)
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(query, conn);
                return cmd.ExecuteScalar();
            }
        }

        public void ExecuteNonQueryWithParams(string query, params object[] parameters)
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(query, conn);
                foreach (var param in parameters)
                {
                    cmd.Parameters.AddWithValue("?", param);
                }
                cmd.ExecuteNonQuery();
            }
        }
    }
}