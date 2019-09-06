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
    /// SeferListele.xaml etkileşim mantığı
    /// </summary>
    public partial class SeferListele : UserControl
    {
        public SeferListele()
        {
            InitializeComponent();
            neredentxt.Text = Seferler.nereden;
            nereyetxt.Text = Seferler.nereye;
            seferTarihitxt.Text = Convert.ToString(Seferler.tarih);
        }
    }
}
