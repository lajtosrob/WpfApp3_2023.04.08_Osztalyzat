using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfApp3_2023._04._08_Osztályzat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            datDatum.SelectedDate= DateTime.Now;
        }

        private void btnRogzit_Click(object sender, RoutedEventArgs e)
        {
            Osztalyzas osztalyzas = new Osztalyzas(txtNev.Text, datDatum.Text, cboTantargy.Text, Convert.ToInt32(sliJegy.Value));
            if (osztalyzas.Jegyellenorzes())
            {
            string csvSor = $"{txtNev.Text};{datDatum.Text};{cboTantargy.Text};{lblJegy.Content}";
            StreamWriter sr = new StreamWriter("jegyek.csv");
            sr.Write(csvSor);
            sr.Close();
            lbJegyek.Items.Add(csvSor);
            MessageBox.Show("A jegy rögzítésre került!");
            }
            else
            {
                txtNev.Focus();
            }


        }

        /* private bool Jegyellenorzes()
        {
            if(txtNev.Text.Length == 0) {
                MessageBox.Show("Nem adtál meg nevet!");
                txtNev.Focus();
                return false;
            }
            else if (datDatum.Text.Length == 0)
            {
                MessageBox.Show("Nem adtál meg dátumot!");
                datDatum.Focus();
                return false;
            }
            else if (cboTantargy.Text.Length == 0)
            {
                MessageBox.Show("Nem adtál meg tantárgyat!");
                cboTantargy.Focus();
                return false;
            }
            else
            {
                return true;
            }
        } */
    }
}
