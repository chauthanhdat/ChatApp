using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ChatApp
{
    class Database
    {
        private MySqlConnection connection;
        private MySqlDataReader reader;
        private string server;
        private string database;
        private string uid;
        private string password;

        public Database()
        {
            Initialize();
        }
        private void Initialize()
        {
            server = "45.252.248.20";
            database = "bkroboti_chatapp";
            uid = "bkroboti_ctdat";
            password = "xQd.hYzw2Fzj";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException e)
            {
                switch (e.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server. Contact administrator");
                        return false;
                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        return false;
                }
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public bool Login(string a, string b)
        {
            string query = "SELECT * FROM account WHERE username='" + a + "' AND password='" + b + "'";

            if (this.OpenConnection())
            {
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand cmd = new MySqlCommand(query, connection);

                this.CloseConnection();

                adapter.SelectCommand = cmd;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Wrong Username/Password");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Wrong Username/Password");
                return false;

            }
        }

        public string Select(string a, string table, string c, string d)
        {
            string query = "SELECT " + a + " FROM " + table + " WHERE " + c + "='" + d + "'";

            string t = "None";
            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    t = reader.GetString(0);
                }
                reader.Close();
                this.CloseConnection();
                return t;
            }
            return t;
        }

        public void SelectTable(ref DataGridView dataGridView)
        {
            string query = "SELECT username, name FROM account";
            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
                mySqlDataAdapter.SelectCommand = cmd;
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                dataGridView.DataSource = dataTable;
                this.CloseConnection();
            }
        }

        public void Insert(string table, string values)
        {
            string query = "INSERT INTO " + table + " VALUES " + values;

            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void Update(string a, string b, string c, string d, string e)
        {
            string query = "UPDATE " + a + " SET " + b + "='" + c + "' WHERE " + d + "='" + e + "'";

            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }
    }
}
