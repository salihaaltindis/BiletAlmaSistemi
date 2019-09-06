using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfLoginApp.Classes;

namespace WpfLoginApp
{
    /// <summary>
    /// YolcuDüzeni.xaml etkileşim mantığı
    /// </summary>
    public partial class YolcuDüzeni : UserControl
    {
        public YolcuDüzeni()
        {
            InitializeComponent();
        }

        private void Button_1_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=localhost\SQLExpress;Initial Catalog=UserDB;
                                                     Integrated Security=True");
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                Button btn = sender as Button;

                string insertquery = "insert into dbo.Bilet(UserName,sefer_id,koltuk_no) values(@UserName,@sefer_id,@koltuk_no)";
                SqlCommand select_cmd = new SqlCommand(insertquery, sqlcon);
                select_cmd.CommandType = CommandType.Text;
                select_cmd.Parameters.AddWithValue("@UserName", LoginedUser.UserName);
                select_cmd.Parameters.AddWithValue("@sefer_id", Seferler.sefer_id);
                select_cmd.Parameters.AddWithValue("@koltuk_no", btn.Content);
                int count = select_cmd.ExecuteNonQuery();
               
                if (count == 1)
                {
                    string kontenjan_sayisi = "select kontenjan from dbo.Seferler where sefer_id=@sefer_id";
                    SqlCommand count_cmd = new SqlCommand(kontenjan_sayisi, sqlcon);
                    count_cmd.CommandType = CommandType.Text;
                    count_cmd.Parameters.AddWithValue("@sefer_id", Seferler.sefer_id);
                    Seferler.kontenjan = Convert.ToInt32(count_cmd.ExecuteScalar());

                    if (Seferler.kontenjan <= 10 && Seferler.kontenjan > 0)
                    {

                        string update = "update dbo.Seferler set kontenjan=@kontenjan where sefer_id=@sefer_id";
                        SqlCommand update_cmd = new SqlCommand(update, sqlcon);
                        update_cmd.CommandType = CommandType.Text;
                        update_cmd.Parameters.AddWithValue("@sefer_id", Seferler.sefer_id);
                        update_cmd.Parameters.AddWithValue("@kontenjan", (Seferler.kontenjan) - 1);

                        int updateexe = update_cmd.ExecuteNonQuery();
                        if (updateexe == 1)
                        {
                            
                            string koltuk_no = btn.Content.ToString();
                            if (koltuk_no.Equals("1"))
                            {
                                button_1.IsEnabled = true;
                                MessageBox.Show(koltuk_no+" numaralı koltuk alındı");
                                button_1.Background = Brushes.Red;
                            
                            }
                            else if (koltuk_no.Equals("2"))
                            {
                                button_2.IsEnabled = true;
                                MessageBox.Show(koltuk_no + " numaralı koltuk alındı");
                                button_2.Background = Brushes.Red;
                            }
                            else if (koltuk_no.Equals("3"))
                            {
                                button_3.IsEnabled = true;
                                MessageBox.Show(koltuk_no + " numaralı koltuk alındı");
                                button_3.Background = Brushes.Red;
                            }
                            else if (koltuk_no.Equals("4"))
                            {
                                button_4.IsEnabled = true;
                                MessageBox.Show(koltuk_no + " numaralı koltuk alındı");
                                button_4.Background = Brushes.Red;
                            }
                            else if (koltuk_no.Equals("5"))
                            {
                                button_5.IsEnabled = true;
                                MessageBox.Show(koltuk_no + " numaralı koltuk alındı");
                                button_5.Background = Brushes.Red;
                            }
                            else if (koltuk_no.Equals("6"))
                            {
                                button_6.IsEnabled = true;
                                MessageBox.Show(koltuk_no + " numaralı koltuk alındı");
                                button_6.Background = Brushes.Red;
                            }
                            else if (koltuk_no.Equals("7"))
                            {
                                button_7.IsEnabled = true;
                                MessageBox.Show(koltuk_no + " numaralı koltuk alındı");
                                button_7.Background = Brushes.Red;
                            }
                            else if (koltuk_no.Equals("8"))
                            {
                                button_8.IsEnabled = true;
                                MessageBox.Show(koltuk_no + " numaralı koltuk alındı");
                                button_8.Background = Brushes.Red;
                            }
                            else if (koltuk_no.Equals("9"))
                            {
                                button_9.IsEnabled = true;
                                MessageBox.Show(koltuk_no + " numaralı koltuk alındı");
                                button_9.Background = Brushes.Red;
                            }
                            else if (koltuk_no.Equals("10"))
                            {
                                button_10.IsEnabled = true;
                                MessageBox.Show(koltuk_no + " numaralı koltuk alındı");
                                button_10.Background = Brushes.Red;
                            } 
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=localhost\SQLExpress;Initial Catalog=UserDB;
                                                     Integrated Security=True");

            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                    if (Seferler.kontenjan == 0)
                    {
                        MessageBox.Show("Sefere ait bilet bulunmamaktadır.");
                    }
                    string query = "select koltuk_no from dbo.Bilet where sefer_id=@sefer_id";
                    SqlCommand update_cmd = new SqlCommand(query, sqlcon);
                    update_cmd.CommandType = CommandType.Text;
                    update_cmd.Parameters.AddWithValue("@sefer_id", Seferler.sefer_id);
                    SqlDataReader dr = update_cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        string koltuk_no = dr["koltuk_no"].ToString();
                        if (koltuk_no.Equals("1"))
                        {
                            button_1.IsEnabled = true;
                            button_1.Background = Brushes.Red;
                        }
                        else if (koltuk_no.Equals("2"))
                        {
                            button_2.IsEnabled = true;
                            button_2.Background = Brushes.Red;
                        }
                        else if (koltuk_no.Equals("3"))
                        {
                            button_3.IsEnabled = true;
                            button_3.Background = Brushes.Red;
                        }
                        else if (koltuk_no.Equals("4"))
                        {
                            button_4.IsEnabled = true;
                            button_4.Background = Brushes.Red;
                        }
                        else if (koltuk_no.Equals("5"))
                        {
                            button_5.IsEnabled = true;
                            button_5.Background = Brushes.Red;
                        }
                        else if (koltuk_no.Equals("6"))
                        {
                            button_6.IsEnabled = true;
                            button_6.Background = Brushes.Red;
                        }
                        else if (koltuk_no.Equals("7"))
                        {
                            button_7.IsEnabled = true;
                            button_7.Background = Brushes.Red;
                        }
                        else if (koltuk_no.Equals("8"))
                        {
                            button_8.IsEnabled = true;
                            button_8.Background = Brushes.Red;
                        }
                        else if (koltuk_no.Equals("9"))
                        {
                            button_9.IsEnabled = true;
                            button_9.Background = Brushes.Red;
                        }
                        else if (koltuk_no.Equals("10"))
                        {
                            button_10.IsEnabled = true;
                            button_10.Background = Brushes.Red;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}