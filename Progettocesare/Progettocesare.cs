using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progettocesare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string stringa = txt_stringa.Text;
            string risultato = "";
            int chiave = 0;
            chiave = chiave % 26;


            if (string.IsNullOrEmpty(stringa))
            {
                MessageBox.Show("ATTENZIONE! IL CARATTERE NON E' STATO INSERITO!");
                return;
            }

            else
            {
                for (int i = 0; i < stringa.Length; i++)
                {
                    char carattere = stringa[i];

                    if (carattere >= 'A' && carattere <= 'Z')
                    {
                        char carattereModificato = (char)(((carattere - 'A' + chiave) % 26) + 'A');
                        risultato += carattereModificato; ;
                    }
                    else if (carattere >= 'a' && carattere <= 'z')
                    {
                        char carattereModificato = (char)(((carattere - 'a' + chiave) % 26) + 'a');
                        risultato += carattereModificato;
                    }
                    else
                    {
                        risultato += carattere;
                    }
                }
            }
        }

            

           

                private void lbl_n8_Click(object sender, EventArgs e)
                {

                }
    }
}
