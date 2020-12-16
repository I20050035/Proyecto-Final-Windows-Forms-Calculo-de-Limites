using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_FinalCalulo_de_limites_Windows_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void lblCalcularResultadoFinal_Click(object sender, EventArgs e)
        {

            string resultadosF = Convert.ToString(numLimite.Value);
            txtX1.Text = resultadosF;
            double vX1 = Math.Pow(int.Parse(txtX1.Text), 2);
            double operacion = (vX1 * (int)(NumV1.Value));
             

            string resultadosF2 = Convert.ToString(numLimite.Value);
            txtX2.Text = resultadosF2;
            double vX2 = Math.Pow(int.Parse(txtX2.Text), 1);
            double operacion2 = (vX2 * (int)(NumV2.Value));
             
            if (cboOperacion1.Text=="+")
            {
                if (cboOperacion2.Text=="+")
                {
                    lblResultadoFinaltotal.Text = (operacion + operacion2+(int)NumV3.Value).ToString();
                }
                else
                {
                    lblResultadoFinaltotal.Text = (operacion + operacion2 - (int)NumV3.Value).ToString();
                }
           
            }
            else
            {
                if (cboOperacion2.Text == "+")
                {
                    lblResultadoFinaltotal.Text = (operacion - operacion2 + (int)NumV3.Value).ToString();
                }
                else
                {
                    lblResultadoFinaltotal.Text = (operacion - operacion2 - (int)NumV3.Value).ToString();
                }
            }
             
        }
         
        

     }

}
