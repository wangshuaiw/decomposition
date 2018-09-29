using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace decomposition
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Cal_Click(object sender, RoutedEventArgs e)
        {
            double ds = 0;
            double ss = 0;
            double di = double.Parse(txt_Di.Text);
            double dems = double.Parse(txt_Dems.Text);
            double ks = double.Parse(txt_ks.Text);
            do
            {
                ds = ds + di;
                ss = ks * ds;
            } while (ds < dems);

            double dps = ds - dems;


        }

        //清空TextBox
        private void btn_Clear_Click(object sender, RoutedEventArgs e)
        {
            txt_An0.Text = "";
            txt_Anb.Text = "";
            txt_Au.Text = "";
            txt_Aw.Text = "";
            txt_Dems.Text = "";
            txt_Di.Text = "";
            txt_Dn.Text = "";
            txt_Ds.Text = "";
            txt_I0.Text = "";
            txt_K.Text = "";
            txt_ks.Text = "";
            txt_n.Text = "";
            txt_Sc.Text = "";
            txt_Sn.Text = "";
            txt_Ss.Text = "";
            txt_Tn.Text = "";
            txt_Wu.Text = "";
            txt_Ww.Text = "";
        }
    }
}
