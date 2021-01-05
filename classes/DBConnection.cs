using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Informačný_systém_SOFI.classes;
using MySql.Data.MySqlClient;

namespace Informačný_systém_SOFI.classes
{
    class DBConnection
    {
        private string datasource = "eu-cdbr-west-03.cleardb.net";
        private string port = "3306";
        private static string username;
        private static string password;
        private string database = "heroku_db3c94d1d9b65dd";
        private string charset = "utf8mb4";
        private MySqlConnection databaseConnection;
      
        //  private string MySqlConnectionstring = "datasource=" + datasource + ";port=" + port + ";username=" + username + ";password=" + password + ";database=" + database;



        public int GetErrorNumber(MySqlException ex)
        {
            int number = ex.Number;
            if (ex != null)
            {

                //if the number is zero, try to get the number of the inner exception
                if (number == 0 && (ex = ex.InnerException as MySqlException) != null)
                {
                    number = ex.Number;
                }
            }
            return number;
        }




        public int Login(string username,string password)
        {
            DBConnection.username = username;
            DBConnection.password = password;
            string MySqlConnectionstring = "datasource=" + datasource + ";port=" + port + ";username=" + DBConnection.username + ";password=" + DBConnection.password + ";database=" + database + "; CharSet=" + charset;
            try
            {
                this.databaseConnection = new MySqlConnection(MySqlConnectionstring);
                this.databaseConnection.Open();
                this.databaseConnection.Close();
                
               
                return 1;
            }
            catch (MySqlException ex)
            {

                //When handling errors, you can your application's response based
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                int errnumber = GetErrorNumber(ex);
                return errnumber;
            }
        }




        public void Connect()
        {
            string MySqlConnectionstring = "datasource=" + datasource + ";port=" + port + ";username=" + username + ";password=" + password + ";database=" + database;
            try
            {
                this.databaseConnection = new MySqlConnection(MySqlConnectionstring);
                this.databaseConnection.Open();
            }
            catch (MySqlException ex)
            {

                //When handling errors, you can your application's response based
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                int errnumber = GetErrorNumber(ex);
                switch (errnumber)
                {
                    case 0:
                        {
                            MessageBox.Show("Cannot connect to server.  Contact administrator");
                        }
                        break;

                    case 1040:
                        {
                            MessageBox.Show("Too many connections to DB");
                        }
                        break;

                    case 1045:
                        {
                            MessageBox.Show("Invalid username/password, please try again");
                        }
                        break;

                    default:
                        MessageBox.Show(" MySQL-Exception number:" + Convert.ToString(ex.Number));
                        break;
                }
            }
           
        }

        public void Disconnect()
        {
            this.databaseConnection.Close();
        }

        public void InsertIntoDB (string table, string Values)
        {
            try
            {
                string query = "INSERT INTO heroku_db3c94d1d9b65dd." + table + " VALUES " + Values + ";";
               
                

                this.Connect();
                MySqlCommand cmd = new MySqlCommand(query, this.databaseConnection);
                cmd.ExecuteNonQuery();
                this.Disconnect();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable SelectFromDb(string table, string columms, string condition)
        {
            DataSet ds = new DataSet();
            string query;
            if (!string.IsNullOrEmpty(condition))
            {
                query = "SELECT " + columms + " FROM heroku_db3c94d1d9b65dd." + table + " WHERE " + condition +";";
            }
            else
            {
                query = "SELECT " + columms + " FROM heroku_db3c94d1d9b65dd." + table + ";";
            }
            try
            {              
                this.Connect();
                MySqlCommand cmd = new MySqlCommand(query, this.databaseConnection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(ds);
                this.Disconnect();
                return (ds.Tables[0]);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public  void FillDataGridView(string table, string columms, string condition, DataGridView DGV, string join = "", string join2 = "")
        {
            DataSet ds = new DataSet();
            string query;
            if (!string.IsNullOrEmpty(condition))
            {
                query = "SELECT " + columms + " FROM heroku_db3c94d1d9b65dd." + table + " WHERE " + condition + ";";
            }
            else
            {
                query = "SELECT " + columms + " FROM heroku_db3c94d1d9b65dd." + table + ";";
            }

            if (!string.IsNullOrEmpty(join))

            {
                query = "SELECT " + columms + "FROM heroku_db3c94d1d9b65dd." + table + " INNER JOIN heroku_db3c94d1d9b65dd." + join + ";";
            }

            if((!string.IsNullOrEmpty(join)) && (!string.IsNullOrEmpty(condition)))
            {
                query = "SELECT " + columms + "FROM heroku_db3c94d1d9b65dd." + table + " INNER JOIN " + join   + " WHERE " + condition + ";";
            }

            if ((!string.IsNullOrEmpty(join)) && (!string.IsNullOrEmpty(join2)) && (string.IsNullOrEmpty(condition)))
            {
                query = "SELECT " + columms + "FROM ((heroku_db3c94d1d9b65dd." + table + " INNER JOIN " + join + ") INNER JOIN " + join2 + ");";
            }

            if ((!string.IsNullOrEmpty(join)) && (!string.IsNullOrEmpty(join2)) && (!string.IsNullOrEmpty(condition)))
            {
                query = "SELECT " + columms + "FROM ((heroku_db3c94d1d9b65dd." + table + " INNER JOIN " + join + ") INNER JOIN " + join2 + ") WHERE " + condition + ";";
            }

            try
            {
                this.Connect();
                MySqlCommand cmd = new MySqlCommand(query, this.databaseConnection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(ds,table);
                this.Disconnect();
                DGV.DataSource = ds.Tables[table];
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        public void UpdateDB(string table, string Values, string condition)
        {
            try
            {
                string query = "UPDATE heroku_db3c94d1d9b65dd." + table + " SET " + Values + " WHERE " + condition +";";

                this.Connect();
                MySqlCommand cmd = new MySqlCommand(query, this.databaseConnection);
                cmd.ExecuteNonQuery();
                this.Disconnect();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void FillComboBox(string table, string column, ComboBox combobox)
        {
            DataSet DS = new DataSet();
            DataTable DT = new DataTable();

            string query = "SELECT DISTINCT " + column + " FROM " + table + "; ";
            try
            {
                this.Connect();
            MySqlCommand cmd = new MySqlCommand(query, this.databaseConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(DS);
            this.Disconnect();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            //kvôli CONCAT
            string lastWord = column.Split(' ').Last();

            DT = DS.Tables[0];


            DataRow row;
            row = DT.NewRow();
            DT.Rows.InsertAt(row, 0);


            combobox.DataSource = DT;
            combobox.DisplayMember = lastWord;
            combobox.ValueMember = lastWord;
            combobox.Enabled = true;
        }



    }
}
