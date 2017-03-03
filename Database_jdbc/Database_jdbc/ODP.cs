using System;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace Database_jdbc
{
    class ODP
    {
        public void connection1()
        {
            string oradb = "User Id=babel;Password=pisord;Data Source=localhost:1521";
            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Select * from DEPARTMENT";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();

            Console.WriteLine("DEPT_NAME, BUILDING, BUDGET");
            while (dr.Read())
            {
                Console.WriteLine(dr.GetValue(0) + ", " + dr.GetValue(1) + ", " + dr.GetValue(2));
            }
            conn.Close();
            conn.Dispose();
        }

        public void connection2()
        {
            string oradb = "User Id=babel;Password=pisord;Data Source=localhost:1521";
            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
        }

        public void connection3()
        {
            string table;
            Console.WriteLine("Please write the name of the table to look up");
            table = Console.ReadLine();


            string oradb = "User Id=babel;Password=pisord;Data Source=localhost:1521";
            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Select * from " + table;
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();

            long fieldCount = dr.FieldCount;

            string result = "";
            for (int i = 0; i < fieldCount; i++)
            {
                result += dr.GetName(i) + ", ";
            }
            result = result.Substring(0, result.Length - 2);
            Console.WriteLine(result);

            while (dr.Read())
            {
                result = "";
                for (int i = 0; i < fieldCount; i++)
                {
                    result += dr.GetValue(i) + ", ";
                }
                result = result.Substring(0, result.Length - 2);
                Console.WriteLine(result);
            }
            conn.Close();
            conn.Dispose();
        }
    }
}
