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
using WPF_lez04_Contatti.Models;
using WPF_lez04_Contatti.Models.DAL;

namespace WPF_lez04_Contatti
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Contatto> elenco = new List<Contatto>();

        public MainWindow()
        {
            InitializeComponent();
            List<Contatto>  elenco = ContattoDAO.GetInstance().GetAll();
            dgContatti.ItemsSource = elenco;

        }

        private void btn_Salva_Click(object sender, RoutedEventArgs e)
        {
            string varNome = this.txt_Nome.Text;
            if (varNome.Trim().Equals("")) { 
                MessageBox.Show("Errore, nome vuoto"); 
                return; 
            }

            string varCogn = this.txt_Cogn.Text;
            if (varCogn.Trim().Equals(""))
            {
                MessageBox.Show("Errore, cognome vuoto");
                return;
            }

            string varEmai = this.txt_Emai.Text;
            if (varEmai.Trim().Equals(""))
            {
                MessageBox.Show("Errore, email vuota");
                return;
            }

            string varCodf = this.txt_Codf.Text;
            if (varCodf.Trim().Equals(""))
            {
                MessageBox.Show("Errore, codf vuoto");
                return;
            }

            Contatto con = new Contatto()
            {
                Nome = varNome,
                Cognome = varCogn,
                Email = varEmai,
                CodFis = varCodf
            };

            if(ContattoDAO.GetInstance().Insert(con))
            {
                MessageBox.Show("Inserimento effettuato con successo");
                this.txt_Nome.Text = "";
                this.txt_Cogn.Text = "";
                this.txt_Codf.Text = "";
                this.txt_Emai.Text = "";

                dgContatti.ItemsSource = ContattoDAO.GetInstance().GetAll();
            }
            else
            {
                MessageBox.Show("Errore di inserimento");
            }
        }
    }
}