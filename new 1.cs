//foreach (DataRow importRow in ImportData.Rows)
//{
//    /* string cmdText = "INSERT INTO nganh (name,level) VALUES (" + importRow[0].ToString() + "," + importRow[1].ToString() + ")";
//    / string cmdText = "INSERT INTO symboleod (symbol_id,date,open,high,low,close,volume) VALUES (@Ticker,@Date/Time,@Open,@High,@Low,@Close,@Volume)";
//    /*string cmdText = "INSERT INTO symboleod (symbol_id,date,open,high,low,close,volume) VALUES (" + importRow["Ticker"].ToString() + "," + importRow["Date/Time"].ToString() + ","
//      + importRow["Open"].ToString() + "," + importRow["High"].ToString() + "," + importRow["Low"].ToString() + "," + importRow["Close"].ToString() + "," + importRow["Volume"].ToString() + ")";*/


//    using (MySqlCommand cmd = new MySqlCommand(cmdText, connection))
//    {
//        connection.Open();
//        cmd.ExecuteNonQuery();
//        cmd.Dispose();
//        connection.Close();

//    }
//}
                

//using (MySqlCommand cmd = new MySqlCommand(cmdText, connection))
//{
//    cmd.Parameters.AddWithValue("symbol_id", importRow["Ticker"].ToString());
//    cmd.Parameters.AddWithValue("date", importRow["Date/Time"].ToString());
//    cmd.Parameters.AddWithValue("open", importRow["Open"].ToString());
//    cmd.Parameters.AddWithValue("high", importRow["High"].ToString());
//    cmd.Parameters.AddWithValue("low", importRow["Low"].ToString());
//    cmd.Parameters.AddWithValue("close", importRow["Close"].ToString());
//    cmd.Parameters.AddWithValue("volume", importRow["Volume"].ToString());


//    cmd.ExecuteNonQuery();
//    cmd.Dispose();
//}
//connection.Close();

/*
connection.Open();
string cmdText = "INSERT INTO field (name,level) VALUES (" + "@name, @level" + ")" ;

cmd.Parameters.AddWithValue("@name", importRow["Name"]);
cmd.Parameters.AddWithValue("@level", importRow["Level"]);

MySqlCommand cmd = new MySqlCommand(cmdText, connection);


cmd.ExecuteNonQuery();
connection.Close();
  */

//using (MySqlCommand cmd = new MySqlCommand("INSERT INTO field", connection))
//{
//    connection.Open();
//    MySqlDataReader reader = cmd.ExecuteReader();
//    while (reader.Read())
//    {
//        MessageBox.Show(reader.GetString(0));
//    }
//    connection.Close();
//}

//StreamReader sr = new StreamReader(ofd.FileName);
//while (line != null)
//{
//    line = sr.ReadLine();
//    MessageBox.Show(line);
//}
//sr.Close();
        

       

        //private void buttonConnectDB_Click(object sender, EventArgs e)
        //{
        //    //MessageBox.Show("ban da bam vao nut");
        //    //textBox1.Text = "ban da bam nut";

        //    //
        //    string connectionString = String.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4};", "127.0.0.1", "3306", "nhi", "root", "");

        //    //
        //    using (MySqlConnection connection = new MySqlConnection(connectionString))
        //    {
        //        using (MySqlCommand cmd = new MySqlCommand("select name from field", connection))
        //        {
        //            connection.Open();
        //            MySqlDataReader reader = cmd.ExecuteReader();
        //            while (reader.Read())
        //            {
        //                MessageBox.Show(reader.GetString(0));
        //            }

        //            connection.Close();
        //        }
        //    }
		
		
		


      //   using (MySqlConnection connection = new MySqlConnection(connectionString))
      //      {
      //          foreach (DataRow importRow in ImportData.Rows)
      //          {
      //              string cmdText = "SELECT id FROM `symbol` WHERE `symbolname` =  " + importRow[0].ToString();                    
      //              using (MySqlCommand cmd = new MySqlCommand(cmdText, connection))
      //              {
      //                  connection.Open();
      //                  MySqlDataReader reader = cmd.ExecuteReader();
      //                  while (reader.Read())
      //                  {
      //                      Console.Write(reader["id"].ToString());
      //                      using (MySqlConnection connection2 = new MySqlConnection(connectionString))
      //                      {
      //                          string cmdTextInsert = "INSERT INTO symboleod (symbol_id,symbolname, date,open,high,low,close,volume) VALUES (" +reader["id"].ToString()+ "," + importRow["Ticker"].ToString() + "," + importRow["Date/Time"].ToString() + ","
      //+ importRow["Open"].ToString() + "," + importRow["High"].ToString() + "," + importRow["Low"].ToString() + "," + importRow["Close"].ToString() + "," + importRow["Volume"].ToString() + ")";
      //                          using (MySqlCommand cmd2 = new MySqlCommand(cmdTextInsert, connection2))
      //                          {
      //                              connection2.Open();
      //                              cmd2.ExecuteNonQuery();
      //                              connection2.Close();
      //                          }
      //                      }
      //                      // MessageBox.Show(reader["id"]);
      //                  }
      //                  // cmd.ExecuteScalar();
      //                  connection.Close();
      //              }
      //          }
                
      //      }
	  
	  

                    /*
                    string cmdText = "SELECT id FROM `symbol` WHERE `symbolname` =  " + importRow[0].ToString();
                    // MessageBox.Show("test"); 
                    using (MySqlCommand cmd = new MySqlCommand(cmdText, connection))
                    {
                        // MessageBox.Show("test");
                        connection.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            Console.Write(reader[0].ToString());
                            using (MySqlConnection connection2 = new MySqlConnection(connectionString))
                            {
                                string cmdTextInsert = "INSERT INTO symboleod (symbol_id,symbolname, date,open,high,low,close,volume) VALUES (" + reader["id"].ToString() + "," + importRow["Ticker"].ToString() + "," + importRow["Date/Time"].ToString() + ","
      + importRow["Open"].ToString() + "," + importRow["High"].ToString() + "," + importRow["Low"].ToString() + "," + importRow["Close"].ToString() + "," + importRow["Volume"].ToString() + ")";
                                using (MySqlCommand cmd2 = new MySqlCommand(cmdTextInsert, connection2))
                                {
                                    connection2.Open();
                                    cmd2.ExecuteNonQuery();
                                    connection2.Close();
                                }
                            }
                            // MessageBox.Show(reader["id"]);
                     */
                        }
                        //cmd.ExecuteScalar();
						
						
INSERT INTO symboleod (symbol_id,symbolname, date,open,high,low,close,volume) VALUES (12345,"AAA","2020-06-19",10,11,9,9.5,250)

string cmdTesting = "SELECT COUNT(*) from symboleod where symbolname = "AAA" AND date = "2020-06-19"";
//
string year = Convert.ToDateTime(importRow["DateTime"]).Year.ToString();
                            string month = Convert.ToDateTime(importRow["DateTime"]).Month.ToString();
                            string day = Convert.ToDateTime(importRow["DateTime"]).Day.ToString();
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