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
using System.Windows.Shapes;
using WpfLoginApp.Classes;

namespace WpfLoginApp
{
    /// <summary>
    /// AfterLogin.xaml etkileşim mantığı
    /// </summary>
    public partial class AfterLogin : Window
    {
        public AfterLogin()
        {
            InitializeComponent();
           
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            WelcomeLabel.Content = "BiletAl Firmasının Bilet Sİstemine Hoşgeldiniz Sn: " + LoginedUser.Name;
        }
        //ilkel versiyon
        //private void Button_click(object sender, RoutedEventArgs e)
        //{
        //    UygulamaControl.AddUserControlToGrid(UserControlGrid, new HesapBilgileri()); 
        //}

        //private void HesapGoruntule_Click(object sender, RoutedEventArgs e)
        //{
        //    UygulamaControl.AddUserControlToGrid(UserControlGrid, new HesapGoruntule());
        //}

        private void ClosingButton_Click(object sender, RoutedEventArgs e)
        {
            //acık olan pencereyi kapatmaya yarar.
            this.Close();
        }

        private void MaximizingButton_Click(object sender, RoutedEventArgs e)
        {
            //eger ekranın boyutu normalse 
            if (this.WindowState == WindowState.Normal)
            {
                //ekranı tam ekran yap
                this.WindowState = WindowState.Maximized;
            }
            else
            {
                //ekran tam ekransa normale dondur.
                this.WindowState = WindowState.Normal;
            }
        }

        private void MinimizingButton_Click(object sender, RoutedEventArgs e)
        {
            //ekranı minimum yapmaya yarar.
            this.WindowState = WindowState.Minimized;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //hesap düzenle butonu
            //userControlGrid  in icerisinde herhangi bir eleman var mı
            if (UserControlGrid.Children.Count > 0)
            {
                //siliyoruz ki çakısmayı onluyoruz.
                UserControlGrid.Children.Clear();
            }
            //eger gridin içi bossa yada yukardaki if le temizlemisse 
            //gridin içerisine istediğimiz UserControlu eklemis olduk
            UserControlGrid.Children.Add(new HesapBilgileri());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //bilet al butonu
            if (UserControlGrid.Children.Count > 0)
            {
                UserControlGrid.Children.Clear();
            }
            UserControlGrid.Children.Add(new BiletAlma());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //bilet iptal et butonu
            if (UserControlGrid.Children.Count > 0)
            {
                UserControlGrid.Children.Clear();
            } 
            UserControlGrid.Children.Add(new BiletIptal());
        }
    }
}
