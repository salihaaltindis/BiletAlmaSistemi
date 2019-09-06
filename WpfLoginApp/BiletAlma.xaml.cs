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
    /// BiletAlma.xaml etkileşim mantığı
    /// </summary>
    public partial class BiletAlma : UserControl
    {
        public BiletAlma()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source = localhost\SQLExpress; Initial Catalog=UserDB; Integrated Security=True");
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }

                String neredenquery = "SELECT DISTINCT nereden FROM dbo.Seferler";
                //Bir sql sorgusu olusturuyoruz. Parametre olarak hangi sorguyu calıstıracagımız ve hangi bağlantı ile calıstıracagımızı gonderiyoruz.
                SqlCommand sqlCmd = new SqlCommand(neredenquery, sqlCon);
                sqlCmd.CommandType = CommandType.Text;
                SqlDataReader dr = sqlCmd.ExecuteReader();

                //veri okurken veritabanından 
                while (dr.Read())
                {
                    neredencmbx.Items.Add(dr["nereden"]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Neredencmbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source = localhost\SQLExpress; Initial Catalog=UserDB; Integrated Security=True");
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }

                String nereyequery = "SELECT DISTINCT nereye FROM dbo.Seferler WHERE nereden=@comboItem";
                //Bir sql sorgusu olusturuyoruz. Parametre olarak hangi sorguyu calıstıracagımız ve hangi bağlantı ile calıstıracagımızı gonderiyoruz.
                SqlCommand sqlCmd = new SqlCommand(nereyequery, sqlCon);

                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@comboItem",neredencmbx.SelectedItem.ToString());

                SqlDataReader dr = sqlCmd.ExecuteReader();
                nereyecmbx.Items.Clear();
                //veri okurken veritabanından 
                while (dr.Read())
                {
                    nereyecmbx.Items.Add(dr["nereye"]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //ne zaman ki seferleri listeleye basarsa grid e dolsun.
            SqlConnection sqlcon = new SqlConnection(@"Data Source=localhost\SQLExpress;Initial Catalog=UserDB;
                                                     Integrated Security=True");
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                string selectnamequery = "select *  from dbo.Seferler where nereden=@nereden and nereye=@nereye AND tarih=@tarih";
                SqlCommand select_cmd = new SqlCommand(selectnamequery, sqlcon);
                select_cmd.CommandType = CommandType.Text;
                select_cmd.Parameters.AddWithValue("@nereden", neredencmbx.SelectedItem);
                select_cmd.Parameters.AddWithValue("@nereye", nereyecmbx.SelectedItem);
                select_cmd.Parameters.AddWithValue("@tarih", seferTarihi.SelectedDate);
                //select_cmd.ExecuteNonQuery();
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(select_cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    adapter.Dispose();
                    seferListeleGrid.ItemsSource = dt.DefaultView;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
        }

        private void KoltukSec_Click(object sender, RoutedEventArgs e)
        {
            if (KoltukSecGrid.Children.Count > 0)
            {
                KoltukSecGrid.Children.Clear();
            }
            KoltukSecGrid.Children.Add(new YolcuDüzeni());

            SqlConnection sqlcon = new SqlConnection(@"Data Source=localhost\SQLExpress;Initial Catalog=UserDB;
                                                     Integrated Security=True");
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                        DataRowView dataRowView = (DataRowView)((Button)e.Source).DataContext;
                        Seferler.nereden = dataRowView[0].ToString();
                        Seferler.nereye = dataRowView[1].ToString();
                        //Seferler.tarih = Convert.ToDateTime(dataRowView[2].ToString());
                        Seferler.saat = dataRowView[3].ToString();
                        Seferler.kontenjan = Convert.ToInt32(dataRowView[4].ToString());
                        Seferler.fiyat = Convert.ToInt32(dataRowView[5]);
                        Seferler.sefer_id = Convert.ToInt32(dataRowView[6]);
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
