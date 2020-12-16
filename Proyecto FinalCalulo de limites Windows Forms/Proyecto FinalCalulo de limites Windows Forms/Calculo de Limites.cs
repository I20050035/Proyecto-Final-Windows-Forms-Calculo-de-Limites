using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_FinalCalulo_de_limites_Windows_Forms
{
    class Calculo_de_Limites
    {

        private int limite;

        public int Limite
        {
            get 
            {
                return limite;
            }
            set
            {
                limite = value; 
            }
        }

        private int valor1;

        public int Valor1
        {
            get
            {
                return valor1;
            }
            set
            {
                valor1 = value;
            }
        }
        private int valorx1;

        public int Valorx1
        {
            get
            {
                return valorx1;
            }
            set
            {
                valorx1 = value;
            }
        }

        private int valor2;
        public int Valor2
        {
            get
            {
                return valor2;
            }
            set
            {
                valor2 = value;
            }
        }

        private int valorx2;

        public int Valorx2
        {
            get
            {
                return valorx2;
            }
            set
            {
                valorx2 = value;
            }

        }

        private int valor3;

        public int Valor3
        {
            get 
            {
                return valor3; 
            }
            set
            {
                valor3 = value; 
            }
        }

        public Calculo_de_Limites(int v1, int vx1,int v2,int vx2,int v3)
        {
            valor1 = v1;
            valorx1 = vx1;
            valor2 = v2;
            valorx2 = vx2;
            valor3 = v3;
        }


    }

    }
 

