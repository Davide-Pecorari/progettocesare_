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
            int chiave = int.Parse(txt.stringa2.Text);

            if (string.IsNullOrEmpty(stringa))
            {
                MessageBox.Show("ATTENZIONE! IL CARATTERE NON E' STATO INSERITO!");
                return;
            }

            else
            {
                char[] risultato = stringa.ToCharArray();
                for (int i = 0; i < stringa.Length; i++)
                {
                    char stringa = txt_stringa[i];

                    if (stringa >= 'A' && stringa <= 'Z')
                    {
                        char carattere = (char)(carattere + chiave);
                    }
                }
            }

            

           

                private void lbl_n8_Click(object sender, EventArgs e)
                {

                }
    }
}
