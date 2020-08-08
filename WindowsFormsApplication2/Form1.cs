using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        OpenFileDialog ofd = new OpenFileDialog();
        private void buttonChooseFile_Click(object sender, EventArgs e)
        {
            // ofd.ShowDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ofd.DefaultExt = ".csv";
                ofd.Filter = "Comma Separated (*.csv)|*.csv";
            }
        }
        private void buttonConnectDB_Click(object sender, EventArgs e)
        {
            DataTable importData = GetDataFromFile();

            if (importData != null)
                SaveImportDataToDatabase(importData);
        }

        private DataTable GetDataFromFile()
        {
            DataTable importedData = new DataTable();

            try
            {
                using (StreamReader sr = new StreamReader(ofd.FileName))
                {
                    string header = sr.ReadLine();
                    if (string.IsNullOrEmpty(header))
                    {
                       // MessageBox.Show("File is empty.");

                    }
                   // MessageBox.Show(header);

                    string[] headerColumns = header.Split(',');
                    foreach (string headerColumn in headerColumns)
                    {
                        importedData.Columns.Add(headerColumn);
                    }

                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        //MessageBox.Show(line);
                        if (string.IsNullOrEmpty(line)) continue;

                        string[] fields = line.Split(',');
                        DataRow importedRow = importedData.NewRow();
                        for (int i = 0; i < fields.Count(); i++)
                        {
                            importedRow[i] = fields[i];
                        }
                        importedData.Rows.Add(importedRow);
                    }
                }
            }
            catch (Exception a)
            {
                Console.WriteLine("The file could not be read.");
                Console.WriteLine(a.Message);
            }
            return importedData;
        }

        private void SaveImportDataToDatabase(DataTable ImportData)
        {
            string connectionString = String.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4};", "127.0.0.1", "3306", "nhi", "root", "");

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                foreach (DataRow importRow in ImportData.Rows)
                {
                    //MessageBox.Show(importRow["Ticker"].ToString());
                    string cmdText = "SELECT id FROM symbol WHERE symbolname = \"" + importRow["Ticker"].ToString() +"\"";
                    MySqlCommand cmd = new MySqlCommand(cmdText, connection);

                    connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        using (MySqlConnection connection2 = new MySqlConnection(connectionString))
                        {    
                            string year = Convert.ToDateTime(importRow["DateTime"]).Year.ToString();
                            string month = Convert.ToDateTime(importRow["DateTime"]).Month.ToString();
                            string day = Convert.ToDateTime(importRow["DateTime"]).Day.ToString();

                          
                            string cmdTesting = "SELECT COUNT(*) from symboleod where symbol_id = " + reader["id"].ToString() + " AND date = " + "\"" + year + "-" + month + "-" + day + "\"";
                            MySqlCommand cmd1 = new MySqlCommand(cmdTesting, connection2);
                            connection2.Open();
                            //int exist = (int)cmd1.ExecuteScalar();
                            int exist = Convert.ToInt32(cmd1.ExecuteScalar());
                            if (exist > 0) MessageBox.Show("Data already existed.");
                            else
                            {
                                using (MySqlConnection connection3 = new MySqlConnection(connectionString))
                                {
                                    
                                string cmdTextInsert = "INSERT INTO symboleod (symbol_id,symbolname, date,open,high,low,close,volume) VALUES (" + reader["id"].ToString() + ",\"" + importRow["Ticker"].ToString() + "\"," + "\"" + year + "-" + month + "-" + day + "\"" + ","
      + importRow["Open"].ToString() + "," + importRow["High"].ToString() + "," + importRow["Low"].ToString() + "," + importRow["Close"].ToString() + "," + importRow["Volume"].ToString() + ")";
                                MySqlCommand cmd2 = new MySqlCommand(cmdTextInsert, connection3);

                                connection3.Open();
                                cmd2.ExecuteNonQuery();
                                connection3.Close();
                                MessageBox.Show("Data Inserted.");

                                }
                            }
                            connection2.Close();
                        }
                    }

                    connection.Close();


                }
                

            }
        }
        
    }
}

        

    

