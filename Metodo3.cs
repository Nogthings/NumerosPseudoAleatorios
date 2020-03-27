using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulación
{
    public partial class Metodo3 : Form
    {

        Random numeroGenerado = new Random();

        public Metodo3()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            calculos();
            btnLimpiar.Enabled = true;
           
        }

        private void calculos()
        {
            List<int> listaGenerados = new List<int>();
            Boolean salir = false;
            int contador = 0;
            int campoX = int.Parse(txbX0.Text);
            int campoA = int.Parse(txbA.Text);
            int campoC = int.Parse(txbC.Text);
            int campoM = int.Parse(txbM.Text);
            int funcion = primerFuncion(campoA, campoX, campoC);
            int funcion2 = segundaFuncion(funcion, campoM);
            double numero = numeroGuardar(campoX, campoM);
            dataGridView1.Rows.Add(contador, campoX, funcion, funcion2, numero);
            listaGenerados.Add(segundaFuncion(funcion, campoM));

            while (salir != true)
            {
                contador++;
                campoX = segundaFuncion(funcion, campoM);
                numero = numeroGuardar(campoX, campoM);
                funcion = primerFuncion(campoA, campoX, campoC);
                funcion2 = segundaFuncion(funcion, campoM);
                dataGridView1.Rows.Add(contador, campoX, funcion, funcion2, numero);
                foreach (int buscado in listaGenerados)
                {
                    if (buscado == funcion2)
                    {
                        salir = true;
                    }
                }
                listaGenerados.Add(funcion2);

            }

        }

        private Boolean esPrimo(int numero)
        {
            int divisor = 2;
            int resto = 0;

            while(divisor < numero)
            {
                resto = numero % divisor;
                if (resto == 0)
                {
                    return false;
                }
                divisor = divisor + 1;
            }
            return true;
        }

        private Boolean condicionA(int entrada)
        {
            if (entrada % 2 == 1 && entrada % 3 != 0 && entrada % 5 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private Boolean esImpar(int entrada)
        {
            if (entrada % 2 == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private int primerFuncion(int nuevaA, int nuevaX, int nuevaC)
        {
            return (nuevaA * nuevaX) + nuevaC;
        }

        private int segundaFuncion(int nuevaFuncion, int nuevaM)
        {
            return (nuevaFuncion % nuevaM);
        }

        private int numeroAleatorioX()
        {
            int numeroRetorno = numeroGenerado.Next(0, 9999);
            return numeroRetorno;
        }

        private int numeroAleatorioA()
        {
            int numeroRetorno = numeroGenerado.Next(0, 9999);
            return numeroRetorno;
        }

        private int numeroAleatorioM()
        {
            int numeroRetorno = numeroGenerado.Next(0, 9999);
            return numeroRetorno;
        }

        int generacionDeX()
        {
            int nuevoPrimo = numeroAleatorioX();
            if (esPrimo(nuevoPrimo) == true)
            {
                return nuevoPrimo;
            }
            else
            {
                return generacionDeX();
            }
        }

        int generacionDeA()
        {
            int nuevoA = numeroAleatorioA();
            if (esPrimo(nuevoA) == true && condicionA(nuevoA) == true)
            {
                return nuevoA;
            }
            else
            {
                return generacionDeA();
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            txbX0.Text = generacionDeX().ToString();
            txbA.Text = generacionDeA().ToString();
            txbC.Text = generacionDeC().ToString();
            txbM.Text = generacionDeM().ToString();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }


        int generacionDeC()
        {
            txbM.Text = generacionDeM().ToString();
            int Mi = int.Parse(txbM.Text);
            int nuevoC = 0;
            nuevoC = Mi;
            while(true)
            {
                if (nuevoC < Mi)
                {
                    if(esPrimo(nuevoC) == true && esImpar(nuevoC) == true)
                    {
                        return nuevoC;
                    }
                    else
                    {
                        nuevoC = nuevoC - 2;
                    }
                }
                else
                {
                    nuevoC = nuevoC - 2;
                }
            }
        }

        int generacionDeM()
        {
            int nuevoM = numeroAleatorioM();
            if (esPrimo(nuevoM) == true && nuevoM > int.Parse(txbX0.Text) && nuevoM > int.Parse(txbA.Text))
            {
                return nuevoM;
            }
            else
            {
                return generacionDeM();
            }
        }

        private void limpiar()
        {
            txbX0.Clear();
            txbA.Clear();
            txbC.Clear();
            txbM.Clear();
            dataGridView1.Rows.Clear();
            btnLimpiar.Enabled = false;
        }
      
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 MenuPrincipal = new Form1();
            MenuPrincipal.Show();
        }

        private double numeroGuardar(int equisCero, int modulo)
        {
            double nuevoX = Convert.ToDouble(equisCero);
            double nuevoM = Convert.ToDouble(modulo);
            double resul = (nuevoX / nuevoM);
            return resul;
        }
    }
}
