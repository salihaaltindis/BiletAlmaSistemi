using System;
using System.Collections.Generic;
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
using System.Data;
using System.Data.SqlClient;
using WpfLoginApp.Classes;


namespace WpfLoginApp
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source = localhost\SQLExpress; Initial Catalog=UserDB; Integrated Security=True");
                try
                {
                    if (sqlCon.State == ConnectionState.Closed)
                    {
                        sqlCon.Open();
                       // MessageBox.Show("Baglantı kuruldu");
                    }

                String query = "SELECT COUNT(*) FROM dbo.Users WHERE UserName=@UserName AND Password=@Password ";
                //Bir sql sorgusu olusturuyoruz. Parametre olarak hangi sorguyu calıstıracagımız ve hangi bağlantı ile calıstıracagımızı gonderiyoruz.
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);

                sqlCmd.CommandType = CommandType.Text;
                //AddWithValue ile sorgumuzdaki hangi parametreye hangi değerin ekleneceğini belirtir
                sqlCmd.Parameters.AddWithValue("@UserName", UserNameTxtbx.Text);
                sqlCmd.Parameters.AddWithValue("@Password", PasswordTxtbx.Password);

                //sql sorgusu calıstırma
                //ExecuteScalar fonks sql sorgunun tek bir değer dondurdugu için kullandık
                //Convert.ToInt32() ile bu degeri integera cevirdik.
                int count = Convert.ToInt32(sqlCmd.ExecuteScalar());

                if (count == 1)
                {
                    string selectNameQuery = "SELECT Name,UserName,Password FROM dbo.Users WHERE UserName=@UserName";
                    SqlCommand sqlNameCmd = new SqlCommand(selectNameQuery, sqlCon);
                    sqlNameCmd.CommandType = CommandType.Text;
                    sqlNameCmd.Parameters.AddWithValue("@UserName", UserNameTxtbx.Text);
                    SqlDataReader dr = sqlNameCmd.ExecuteReader();
                     
                    //veri okurken veritabanından 
                    while (dr.Read())
                    {
                        LoginedUser.Name = dr["Name"].ToString();
                        LoginedUser.UserName = UserNameTxtbx.Text.ToString();
                        LoginedUser.Password = dr["Password"].ToString();
                    }

                    //AfterLogin ekranı turunde bir obje olusturduk
                    AfterLogin newWindow = new AfterLogin();

                    //Bu ekranın gosterilmesini sagladık
                    newWindow.Show();

                    //İçinde bulundugumuz Login sayfasının kapatılmasını istedik.
                    this.Close();    
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı yada şifre hatalı");
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

        private void SignUp_Click(object sender, RoutedEventArgs e)
        {
            SignUp s1 = new SignUp();
            s1.Show();
            this.Close(); 
        }
    }
}

