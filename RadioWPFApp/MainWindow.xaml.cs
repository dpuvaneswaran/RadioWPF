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

namespace RadioWPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        Radio r;
        public MainWindow()
        {
            InitializeComponent();
            r = new Radio();
            r.Read();


        }

        private void Off_Click(object sender, RoutedEventArgs e)
        {
            r.TurnOff();
            OnOffTxt.Text = "Radio is off";
        }

        private void On_Click(object sender, RoutedEventArgs e)
        {
            r.Read();
            r.TurnOn();
            OnOffTxt.Text = $"{r.Play()}";
            VolumeTxt.Text = $"{r.Volume}";
        }

        private void Channel1_Click(object sender, RoutedEventArgs e)
        {
            r.Channel = 1;
            OnOffTxt.Text = $"{r.Play()}";

        }

        private void Channel2_Click(object sender, RoutedEventArgs e)
        {
            r.Channel = 2;
            OnOffTxt.Text = $"{r.Play()}";

        }

        private void Channel3_Click(object sender, RoutedEventArgs e)
        {
            r.Channel = 3;
            OnOffTxt.Text = $"{r.Play()}";

        }

        private void Channel4_Click(object sender, RoutedEventArgs e)
        {
            r.Channel = 4;
            OnOffTxt.Text = $"{r.Play()}";

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            r.Write();

        }


        private void VolUp_Click(object sender, RoutedEventArgs e)
        {
            r.Volume++;
            VolumeTxt.Text = $"Volume: {r.Volume++}";
        }

        private void VolDown_Click(object sender, RoutedEventArgs e)
        {
            r.Volume--;
            VolumeTxt.Text = $"Volume: {r.Volume--}";
        }
    }
}
