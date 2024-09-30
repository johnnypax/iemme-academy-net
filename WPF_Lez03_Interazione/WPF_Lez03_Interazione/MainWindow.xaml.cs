using System.Windows;
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

namespace WPF_Lez03_Interazione
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

        private void btn_Salva_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            string varNome = this.txtNome.Text;
            string varCognome = this.txtCognome.Text;

            if(varNome.Trim().Equals("") || varCognome.Trim().Equals(""))
            {
                MessageBox.Show("errore di inserimento nome o cognome");
                return;
            }

            tb_risultato.Text = $"I valori inseriti sono: {varNome} {varCognome}";
        }
    }
}