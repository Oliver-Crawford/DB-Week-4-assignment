using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DB_Week_4_Assignment
{
    public partial class Form1 : Form
    {
        //enter this when DB name available
        string dbName = "";
        public Form1()
        {
            InitializeComponent();
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InputID_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void InputLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnectionString = "server=localhost;uid=root;" + $"pwd=;database={dbName}";
                MySqlConnection connection = new MySqlConnection(myConnectionString);
                connection.Open();
                MySqlCommand command = new MySqlCommand("Select * from Contacts;", connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0].DefaultView;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnectionString = "server=localhost;uid=root;" + $"pwd=;database={dbName}";
                MySqlConnection connection = new MySqlConnection(myConnectionString);
                string query = $"insert into Contacts(ContactId, FirstName, LastName, DateOfBirth, AllowContactByPhone, createdDate) values({InputID.Text}, \'{inputFirstName.Text}\', \'{InputLastName.Text}\', \'{InputDOB.Text}\', {InputAcceptsCalls.Checked}, CURRENT_DATE());";
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read()) { }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnectionString = "server=localhost;uid=root;" + $"pwd=;database={dbName}";
                MySqlConnection connection = new MySqlConnection(myConnectionString);
                string query = $"Update Contacts set FirstName=/'{inputFirstName.Text}/', LastName=/'{InputLastName.Text}/', DateOfBirth=/'{InputDOB.Text}/', AllowContactByPhone={InputAcceptsCalls.Checked} where ContactId={InputID.Text};";
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read()) { }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnectionString = "server=localhost;uid=root;" + $"pwd=;database={dbName}";
                MySqlConnection connection = new MySqlConnection(myConnectionString);
                string query = $"delete from Contacts where ContactId={InputID.Text};";
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read()) { }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
