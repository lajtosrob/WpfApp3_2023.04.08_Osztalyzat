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

namespace WpfApp3_2023._04._08_Osztályzat
{
    class Osztalyzas
    {
        string nev;
        string datum;
        string tantargy;
        int jegy;

        public Osztalyzas(string nev, string datum, string tantargy, int jegy)
        {
            this.nev = nev;
            this.datum = datum;
            this.tantargy = tantargy;
            this.jegy = jegy;
        }

        public string Nev { get => nev;  }
        public string Datum { get => datum;  }
        public string Tantargy { get => tantargy;  }
        public int Jegy { get => jegy;  }

        public bool Jegyellenorzes()
        {
            if (this.nev.Length == 0)
            {
                MessageBox.Show("Nem adtál meg nevet!");
                return false;
            }
            else if (datum.Length == 0)
            {
                MessageBox.Show("Nem adtál meg dátumot!");
                return false;
            }
            else if (tantargy.Length == 0)
            {
                MessageBox.Show("Nem adtál meg tantárgyat!");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
