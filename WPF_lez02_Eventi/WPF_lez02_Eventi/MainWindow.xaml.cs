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

namespace WPF_lez02_Eventi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            pnl_Principale.MouseUp += new MouseButtonEventHandler(pannelloCliccato);
        }

        private void btn_Cliccami_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Mi hai cliccato");
        }

        private void btn_Chiudi_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void pannelloCliccato(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show($"Cliccato sul pannello con le coordinate: {e.GetPosition(this)} ");
        }
    }
}