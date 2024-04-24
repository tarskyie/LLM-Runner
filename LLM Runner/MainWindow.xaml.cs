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
using LLama.Common;
using LLama;

namespace LLM_Runner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void hideall()
        {
            hf_wv.Visibility = Visibility.Collapsed;
            dl_wv.Visibility = Visibility.Collapsed;
            base_label.Visibility = Visibility.Collapsed;
        }

        private void hf_click(object sender, RoutedEventArgs e)
        {
            if(hf_wv.Visibility == Visibility.Visible)
            {
                hf_wv.Source = new Uri("https://huggingface.co");
            }
            else
            {
                hideall();
                hf_wv.Visibility = Visibility.Visible;
            }
        }

        private void dl_click(object sender, RoutedEventArgs e)
        {
            if (dl_wv.Visibility == Visibility.Visible)
            {
                dl_wv.Source = new Uri("edge://downloads/all");
            }
            else
            {
                hideall();
                dl_wv.Visibility = Visibility.Visible;
            }
        }

        private void base_click(object sender, RoutedEventArgs e)
        {
            if (base_label.Visibility == Visibility.Collapsed)
            {
                hideall();
                base_label.Visibility = Visibility.Visible;
            }
        }

        private void base_vischange(object sender, DependencyPropertyChangedEventArgs e)
        {
            base_tbox.Visibility = base_label.Visibility;
            base_genbutton.Visibility = base_label.Visibility;
            base_hislabel.Visibility = base_label.Visibility;
            base_history.Visibility = base_label.Visibility;
            base_sbutton.Visibility = base_label.Visibility;
        }

    }
}