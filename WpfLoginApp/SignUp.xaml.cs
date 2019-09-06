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
using System.Windows.Shapes;

namespace WpfLoginApp
{
    /// <summary>
    /// SignUp.xaml etkileşim mantığı
    /// </summary>
    public partial class SignUp : Window
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (txtusername.Text == "")
            {
                userNameValidate.Content = "Must filled";
            }
            if (txtname.Text == "")
            {
                nameValidate.Content = "Must filled";
            }
            if (txtpassword.Password == "")
            {
                passwordValidate.Content = "Must filled";
            }
            if (txtagainpassword.Password == "")
            {
                passwordAgainValidate.Content = "Must filled";
            }
            if (txtpassword.Password != txtagainpassword.Password)
            {
                passwordAgainValidate.Content = "Password must be equal";
            }
            else
            {
                SqlConnection sqlCon = new SqlConnection(@"Data Source = localhost\SQLExpress; Initial Catalog=UserDB; Integrated Security=True");
                try
                {
                    if (sqlCon.State == ConnectionState.Closed)
                    {
                        sqlCon.Open();
                        String query1 = "SELECT COUNT(*) FROM dbo.Users WHERE UserName=@UserName ";
                        SqlCommand sqlCmd1 = new SqlCommand(query1, sqlCon);

                        sqlCmd1.CommandType = CommandType.Text;
                        //AddWithValue ile sorgumuzdaki hangi parametreye hangi değerin ekleneceğini belirtir
                        sqlCmd1.Parameters.AddWithValue("@UserName", txtusername.Text);
                        int sonuc1 = Convert.ToInt32(sqlCmd1.ExecuteScalar());

                        if (sonuc1 == 0)
                        {
                            String query = "INSERT INTO dbo.Users VALUES (@UserName,@Name,@Password)";
                            //Bir sql sorgusu olusturuyoruz. Parametre olarak hangi sorguyu calıstıracagımız ve hangi bağlantı ile calıstıracagımızı gonderiyoruz.
                            SqlCommand sqlCmd = new SqlCommand(query, sqlCon);

                            sqlCmd.CommandType = CommandType.Text;
                            //AddWithValue ile sorgumuzdaki hangi parametreye hangi değerin ekleneceğini belirtir
                            sqlCmd.Parameters.AddWithValue("@UserName", txtusername.Text);
                            sqlCmd.Parameters.AddWithValue("@Name", txtname.Text);
                            sqlCmd.Parameters.AddWithValue("@Password", txtpassword.Password);
                            sqlCmd.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("Bu isimde kullanıcı var.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Baglantı kurulamadı.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                finally
                {
                    sqlCon.Close();
                }
            }
        }
        private void UserName_TextChanged(object sender, TextChangedEventArgs e)
        {
            userNameValidate.Content = "";
        }

        private void Name_TextChanged(object sender, TextChangedEventArgs e)
        {
            nameValidate.Content = "";
        }

        private void PasswordChanged(object sender, RoutedEventArgs e)
        {
            passwordValidate.Content = "";
        }

        private void PasswordAgainChanged(object sender, RoutedEventArgs e)
        {
            passwordAgainValidate.Content = "";
        }

    }
}
