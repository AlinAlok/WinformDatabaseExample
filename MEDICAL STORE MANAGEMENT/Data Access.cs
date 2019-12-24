using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MEDICAL_STORE_MANAGEMENT
{
    public class Data_Access
    {
        static string databaseName = "Medical Store database";
        static string myConnString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog="+databaseName+";Integrated Security=True";



        public Data_Access()
        {
            try
            {
                SqlConnection con = new SqlConnection(myConnString);
                con.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region Select Data from Database
        public DataTable Select()
        {
            SqlConnection con = new SqlConnection(myConnString);
            DataTable dTable = new DataTable();
            try
            {
                String sql = "SELECT * FORM Table_User";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                con.Open();
                adapter.Fill(dTable);


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();
            }
            return dTable;
        }

        internal bool Insert(Pro pro)
        {
            throw new NotImplementedException();
        }

        public DataTable _Select()
        {
            SqlConnection con = new SqlConnection(myConnString);
            DataTable dTable = new DataTable();
            try
            {
                String sqlP = "SELECT * FORM Table_Product";
                SqlCommand cmd = new SqlCommand(sqlP, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                con.Open();
                adapter.Fill(dTable);


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();
            }
            return dTable;
        }

        internal bool Insert(Reg reg)
        {
            throw new NotImplementedException();
        }

        internal bool Update(Pro pro)
        {
            throw new NotImplementedException();
        }


        #endregion
        #region Insert data into database
        public bool Insert(Reg Re, Product pro)
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(myConnString);
            try
            {
                String sql = "INSERT INTO Table_User(firstName,lastName,mail,password,contact,address) VALUES(@firstName,@lastName,@mail,@password,@contact,@address)";
                SqlCommand cmd = new SqlCommand(sql, con);
                

                cmd.Parameters.AddWithValue("@firstName", Re.firstName);
                cmd.Parameters.AddWithValue("@lastName", Re.lastName);
                cmd.Parameters.AddWithValue("@mail", Re.mail);
                cmd.Parameters.AddWithValue("@password", Re.password);
                cmd.Parameters.AddWithValue("@contact", Re.contact);
                cmd.Parameters.AddWithValue("@address", Re.address);
                con.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;

                }
                else { isSuccess = false; }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
            finally
            {
                con.Close();
            }
            try {
                String sql = "INSERT INTO Table_Product(proID,proName,proPrice,proQT) VALUES(@proID,@proName,@proPrice,@proQT)";
                SqlCommand cmd = new SqlCommand(sql, con);


                cmd.Parameters.AddWithValue("@proID", pro.proID);
                cmd.Parameters.AddWithValue("@proName", pro.proName);
                cmd.Parameters.AddWithValue("@proPrice", pro.proPrice);
                cmd.Parameters.AddWithValue("@proQT", pro.proQT);
                
                con.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;

                }
                else { isSuccess = false; }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
            finally {
                con.Close();

            }


            return isSuccess;

        }

        
        #endregion
      

    }
}

