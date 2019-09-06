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
    /// HesapBilgileri.xaml etkileşim mantığı
    /// </summary>
    public partial class HesapBilgileri : UserControl
    {
        public HesapBilgileri()
        {
            InitializeComponent();
            usernameTextBox.Text = LoginedUser.UserName;
            nameTextBox.Text = LoginedUser.Name;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source = localhost\SQLExpress; Initial Catalog=UserDB; Integrated Security=True");
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();   
                }
            }
            catch
            {
                MessageBox.Show("Baglantı kurulamadı");
            }
            String updatequery = "UPDATE dbo.Users SET UserName=@UserName, Name=@Name, Password=@Password WHERE UserName=@UserName ";
            SqlCommand sqlCmd = new SqlCommand(updatequery, sqlCon);
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.Parameters.AddWithValue("@UserName", usernameTextBox.Text);
            sqlCmd.Parameters.AddWithValue("@Name", nameTextBox.Text);

            bool executeQuery = true;

            if (oldPasswordBox.Password.Length !=  0)
            {//kullanıcının eski sifresini dogru girip girmediğini kontrol ediyoruz.
                if(oldPasswordBox.Password == LoginedUser.Password )
                {
                    sqlCmd.Parameters.AddWithValue("@Password", newPasswordBox.Password);
                }
                else
                {
                    executeQuery = false;
                }
            }
            else
            {
                sqlCmd.Parameters.AddWithValue("@Password",LoginedUser.Password);
            }
            if(executeQuery)
            {
                sqlCmd.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("şifre yanlıs girilmis");
            }
        }
    }
}
