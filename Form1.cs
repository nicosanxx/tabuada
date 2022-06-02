using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tabuada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TABUADA

            int tabuada = Convert.ToInt32(txt_box.Text);
            int conta;
            lbox_tabuada.Items.Clear();
            lbox_tabuada.Items.Add("TABUADA");

            for(int num = 1; num <= 10; num ++)
            {

                
 
                lbox_tabuada.Items.Add(tabuada + " X " + num + " = " + (num * tabuada));





            }
















        }
    }
}
