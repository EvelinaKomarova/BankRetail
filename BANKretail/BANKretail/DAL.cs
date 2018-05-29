using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data.SqlClient;
using System.Data.Common;
using System.Globalization;
using System.IO;


namespace BANKretail
{
    class DAL
    {
        //строка соединения
        string connectionString = @"Data Source=EVELINA-ПК\SQLEXPRESS;Initial Catalog=BANK;Integrated Security=True;";

        public ArrayList GetAllDebitors()
        { 
            ArrayList allDebitors = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand("SELECT * FROM Debitors Order By Name", con);

                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();

                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr)
                            allDebitors.Add(result);
                }
                catch
                { 
                
                }
            }
            return allDebitors;
        }

        internal ArrayList SearchDebitors(string debName, string debPostNum, string debPhoneNum)
        {
            ArrayList searchedDebitors = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                SqlCommand com = new SqlCommand("SearchDebitor", con);
                com.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@debName";
                param.Value = debName;
                param.SqlDbType = System.Data.SqlDbType.NVarChar;
                param.Direction = System.Data.ParameterDirection.Input;
                com.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@debPostNum";
                param.Value = debPostNum;
                param.SqlDbType = System.Data.SqlDbType.NVarChar;
                param.Direction = System.Data.ParameterDirection.Input;
                com.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@debPhoneNum";
                param.Value = debPhoneNum;
                param.SqlDbType = System.Data.SqlDbType.NVarChar;
                param.Direction = System.Data.ParameterDirection.Input;
                com.Parameters.Add(param);

                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();

                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr)
                            searchedDebitors.Add(result);
                }
                catch
                {

                }
            }

            return searchedDebitors;
        }

        internal ArrayList GetAllCreditsForDebitor(string debitorID)
        {
            ArrayList allCredits = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = String.Format("SELECT * FROM Credits Where DebitorID='{0}' Order By OpenDate", debitorID);
                SqlCommand com = new SqlCommand(query, con);

                //SqlCommand com = new SqlCommand("GetAllCreditsByCurrentDebitor", con);
                //com.CommandType = System.Data.CommandType.StoredProcedure;

                //SqlParameter param = new SqlParameter();
                //param.ParameterName = "@DebitorID";
                //param.Value = new Guid(debitorID);
                //param.SqlDbType = System.Data.SqlDbType.UniqueIdentifier;
                //param.Direction = System.Data.ParameterDirection.Input;
                //com.Parameters.Add(param);

                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();

                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr)
                            allCredits.Add(result);
                }
                catch
                {

                }
            }

            return allCredits;
        }

        internal ArrayList GetAllPaymentsForCredit(string creditID)
        { 
            ArrayList allPayments = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = String.Format("SELECT * FROM Payments Where CreditsID='{0}' Order By PaymentDate", creditID);
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();

                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr)
                            allPayments.Add(result);
                }
                catch
                {

                }
            }

            return allPayments;
        }

        public bool SaveNewDebitor(string ID, string Name, 
            string PostNumber, string PhoneNumber)
        {
            bool flagResult = false;

            string query = string.Format("INSERT INTO Debitors "+
                "([ID], [Name], [PostNumber], [PhoneNumber]) " +
                "VALUES ('{0}', '{1}', '{2}', '{3}')", 
                ID, Name, PostNumber, (PhoneNumber != String.Empty) ? PhoneNumber : null);

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() == 1)
                        flagResult = true;
                }
                catch
                { 
                
                }
            }

            return flagResult;
        }

        public bool SaveNewCredit(Guid ID, Guid debitorID, int amount,
            int balance, DateTime openDate)
        {
            string query = String.Format("INSERT INTO Credits "+
                "(ID, DebitorID, Amount, Balance, OpenDate)"+
                "VALUES (@ID, @debitorID, @Amount, @Balance, @OpenDate)");

            bool flagResult = false;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);

                SqlParameter param = new SqlParameter("@ID", ID);
                param.SqlDbType = System.Data.SqlDbType.UniqueIdentifier;
                com.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@debitorID";
                param.Value = debitorID;
                param.SqlDbType = System.Data.SqlDbType.UniqueIdentifier;
                com.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@Amount";
                param.Value = amount;
                param.SqlDbType = System.Data.SqlDbType.Money;
                com.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@Balance";
                param.Value = balance;
                param.SqlDbType = System.Data.SqlDbType.Money;
                com.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@OpenDate";
                param.Value = openDate;
                param.SqlDbType = System.Data.SqlDbType.DateTime;
                com.Parameters.Add(param);

                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() == 1)
                        flagResult = true;
                }
                catch(Exception)
                {

                }
            }
            return flagResult;
        }

        internal bool SaveNewPayment(Guid ID, Guid creditID, 
            decimal paymentAmount, DateTime dateTime)
        {
            bool flag = true;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlTransaction sqlTransact = con.BeginTransaction();
                SqlCommand com = con.CreateCommand();
                com.Transaction = sqlTransact;

                try
                {
                    string payAmount = paymentAmount.ToString(CultureInfo.InvariantCulture.NumberFormat);
                    string query = string.Format("INSERT INTO Payments (ID, CreditsID, Amount, PaymentDate) VALUES " +
                        "('{0}', '{1}', '{2}', '{3}')", ID, creditID, payAmount, dateTime);
                    com.CommandText = query;
                    com.ExecuteNonQuery();

                    query = string.Format("UPDATE Credits SET Balance = (Balance - {0}) WHERE ID = '{1}'", 
                        payAmount, creditID);
                    com.CommandText = query;
                    com.ExecuteNonQuery();

                    sqlTransact.Commit();
                }
                catch(Exception)
                {
                    sqlTransact.Rollback();
                    flag = false;
                }
                finally
                {
                    if (con.State == System.Data.ConnectionState.Open)
                        con.Dispose();
                }
            }

            return flag;
        }

        internal bool SaveDBToLocalFile()
        {
            bool result = true;

            StreamWriter file;

            string query;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {            
                    file = new StreamWriter(new FileStream("Debitors.csv", FileMode.Create), Encoding.GetEncoding(1251));

                    query = "SELECT * FROM Debitors";
                    SqlCommand com = new SqlCommand(query, con);
                    con.Open();
                    SqlDataReader reader = com.ExecuteReader();

                    file.WriteLine("Start of file");
                    file.WriteLine(@"""ID"";""Name"";""PostNumber"";""PhoneNumber""");

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            file.WriteLine(@"""" + reader.GetValue(0).ToString() + @""";""" +
                                reader.GetString(1) + @""";""" +
                                reader[2].ToString() + @""";""" +
                                reader[3].ToString() + @"""", Encoding.ASCII);
                        }
                    }
                    else
                    {
                        file.WriteLine("No one row to save");
                    }

                    file.WriteLine("End of file");
                    result = true;
                    file.Dispose();

                }
                catch
                {
                    result = false;
                    return result;
                }
            }

            

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    file = new StreamWriter(new FileStream("Credits.csv", FileMode.Create), Encoding.GetEncoding(1251));
                    
                    query = "SELECT * FROM Credits";
                    SqlCommand com = new SqlCommand(query, con);
                    con.Open();
                    SqlDataReader reader = com.ExecuteReader();

                    file.WriteLine("Start of file");
                    file.WriteLine(@"""ID"";""DebitorID"";""Amount"";""Balance"";""OpenDate""");

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            file.WriteLine(@"""" + reader[0].ToString() + @""";""" +
                                reader[1].ToString() + @""";""" +
                                reader[2].ToString() + @""";""" +
                                reader[3].ToString() + @""";""" +
                                reader[4].ToString() + @"""", Encoding.ASCII);
                        }
                    }
                    else
                    {
                        file.WriteLine("No one row to save");
                    }

                    file.WriteLine("End of file");
                    result = true;
                    file.Dispose();

                }
                catch
                {
                    result = false;
                    return result;
                }
            }



            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {            
                    file = new StreamWriter(new FileStream("Payments.csv", FileMode.Create), Encoding.GetEncoding(1251));

                    query = "SELECT * FROM Payments";
                    SqlCommand com = new SqlCommand(query, con);
                    con.Open();
                    SqlDataReader reader = com.ExecuteReader();

                    file.WriteLine("Start of file");
                    file.WriteLine(@"""ID"";""CreditsID"";""Amount"";""PaymentDate""");

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            file.WriteLine(@"""" + reader[0].ToString() + @""";""" +
                                reader[1].ToString() + @""";""" +
                                reader[2].ToString() + @""";""" +
                                reader[3].ToString() + @"""", Encoding.ASCII);
                        }
                    }
                    else
                    {
                        file.WriteLine("No one row to save");
                    }

                    file.WriteLine("End of file");
                    result = true;
                    file.Dispose();

                }
                catch
                {
                    result = false;
                    return result;
                }
            }



            return result;
        }
    }
}
