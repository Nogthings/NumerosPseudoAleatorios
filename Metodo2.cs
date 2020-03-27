using InputKey;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulación
{
    public partial class Metodo2 : Form
    {
        public Metodo2()
        {
            InitializeComponent();
            btnGenerar.Enabled = false;
        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 MenuPrincipal = new Form1();
            MenuPrincipal.Show();
        }

        private void txtBoxSemilla_TextChanged(object sender, EventArgs e)
        {
            if ((txtBoxSemilla.TextLength >= 3 && txtBoxSemilla2.TextLength >= 3 && int.Parse(txtBoxSemilla.Text) >= 111 && int.Parse(txtBoxSemilla2.Text) >= 111) && (txtBoxT.TextLength == 1 && (int.Parse(txtBoxT.Text) == 3 || int.Parse(txtBoxT.Text) == 4)) /*&& (txtBoxIteraciones.TextLength == 2 && (int.Parse(txtBoxIteraciones.Text) >= 10 && int.Parse(txtBoxIteraciones.Text) <= 30))*/)
            {
                btnGenerar.Enabled = true;
            }
            else { btnGenerar.Enabled = false; }
        }

        private void txtBoxSemilla_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtBoxSemilla2_TextChanged(object sender, EventArgs e)
        {
            if ((txtBoxSemilla.TextLength >= 3 && txtBoxSemilla2.TextLength >= 3 && int.Parse(txtBoxSemilla.Text) >= 111 && int.Parse(txtBoxSemilla2.Text) >= 111) && (txtBoxT.TextLength == 1 && (int.Parse(txtBoxT.Text) == 3 || int.Parse(txtBoxT.Text) == 4)) /*&& (txtBoxIteraciones.TextLength == 2 && (int.Parse(txtBoxIteraciones.Text) >= 10 && int.Parse(txtBoxIteraciones.Text) <= 30))*/)
            {
                btnGenerar.Enabled = true;
            }
            else { btnGenerar.Enabled = false; }
        }

        private void txtBoxSemilla2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtBoxT_TextChanged(object sender, EventArgs e)
        {
            if ((txtBoxSemilla.TextLength >= 3 && txtBoxSemilla2.TextLength >= 3 && int.Parse(txtBoxSemilla.Text) >= 111 && int.Parse(txtBoxSemilla2.Text) >= 111) && (txtBoxT.TextLength == 1 && (int.Parse(txtBoxT.Text) == 3 || int.Parse(txtBoxT.Text) == 4)) /*&& (txtBoxIteraciones.TextLength == 2 && (int.Parse(txtBoxIteraciones.Text) >= 10 && int.Parse(txtBoxIteraciones.Text) <= 30))*/)
            {
                btnGenerar.Enabled = true;
            }
            else { btnGenerar.Enabled = false; }
        }

        private void txtBoxT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '4') { e.Handled = false; }
            else if (e.KeyChar == '3') { e.Handled = false; }
            else if (Char.IsControl(e.KeyChar)) { e.Handled = false; }
            else { e.Handled = true; }
        }

        private void txtBoxIteraciones_TextChanged(object sender, EventArgs e)
        {
            if ((txtBoxSemilla.TextLength >= 3 && txtBoxSemilla2.TextLength >= 3 && int.Parse(txtBoxSemilla.Text) >= 111 && int.Parse(txtBoxSemilla2.Text) >= 111) && (txtBoxT.TextLength == 1 && (int.Parse(txtBoxT.Text) == 3 || int.Parse(txtBoxT.Text) == 4)) /*&& (txtBoxIteraciones.TextLength == 2 && (int.Parse(txtBoxIteraciones.Text) >= 10 && int.Parse(txtBoxIteraciones.Text) <= 30))*/)
            {
                btnGenerar.Enabled = true;
            }
            else { btnGenerar.Enabled = false; }
        }

        private void txtBoxIteraciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void Limpiar()
        {
            txtBoxSemilla.Clear();
            txtBoxT.Clear();
            txtBoxIteraciones.Clear();
            dtgvTabla.Rows.Clear();
            txtBoxSemilla2.Clear();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int intContador = 0;
            string strSemilla = txtBoxSemilla.Text;//Guardamos semilla 1
            string strSemilla2 = txtBoxSemilla2.Text;
            string strT = txtBoxT.Text;
            string strIteraciones = txtBoxIteraciones.Text;
            //try{}catch (Exception f){MessageBox.Show($"{f.ToString()} Exception caught.");}
            int intSemilla = 0;
            int intSemilla2 = 0;
            int intT = 0;
            int intIteraciones = 0;

            intSemilla = int.Parse(strSemilla);//Convertimos Semilla1
            intSemilla2 = int.Parse(strSemilla2);//Convertimos Semilla2
            intT = int.Parse(strT);
            intIteraciones = int.Parse(strIteraciones);
            //Algoritmo
            double TemporalSemillaMultiplicacion = 0;//Semillar temporal 1
            //MessageBox.Show(TemporalSemillaMultiplicacion.ToString());
            for (intContador = 1; intContador <= intIteraciones; intContador++)
            {
                TemporalSemillaMultiplicacion = intSemilla*intSemilla2;
                int intIndice = dtgvTabla.Rows.Add();//Agregamos una nueva fila y guardamos su indice
                dtgvTabla.Rows[intIndice].Cells[0].Value = intContador;
                dtgvTabla.Rows[intIndice].Cells[1].Value = intSemilla;
                dtgvTabla.Rows[intIndice].Cells[2].Value = intSemilla2;
                string strTemporalSemilla = "";

                if (intT == 3 && TemporalSemillaMultiplicacion.ToString().Length == 2)
                {
                    strTemporalSemilla = TemporalSemillaMultiplicacion.ToString();
                    strTemporalSemilla = '0' + strTemporalSemilla;

                    dtgvTabla.Rows[intIndice].Cells[3].Value = strTemporalSemilla;

                    strTemporalSemilla = TemporalSemillaMultiplicacion.ToString();

                    dtgvTabla.Rows[intIndice].Cells[4].Value = strTemporalSemilla;
                    dtgvTabla.Rows[intIndice].Cells[5].Value = strTemporalSemilla;
                    dtgvTabla.Rows[intIndice].Cells[6].Value = "0." + strTemporalSemilla;

                    intSemilla = intSemilla2;
                    intSemilla2 = int.Parse(strTemporalSemilla);
                }
                else if (intT == 3 && TemporalSemillaMultiplicacion.ToString().Length == 3)
                {
                    strTemporalSemilla = TemporalSemillaMultiplicacion.ToString();

                    dtgvTabla.Rows[intIndice].Cells[3].Value = strTemporalSemilla;

                    strTemporalSemilla = TemporalSemillaMultiplicacion.ToString();

                    dtgvTabla.Rows[intIndice].Cells[4].Value = strTemporalSemilla;
                    dtgvTabla.Rows[intIndice].Cells[5].Value = strTemporalSemilla;
                    dtgvTabla.Rows[intIndice].Cells[6].Value = "0." + strTemporalSemilla;

                    intSemilla = intSemilla2;
                    intSemilla2 = int.Parse(strTemporalSemilla);
                }
                else if (intT == 3 && TemporalSemillaMultiplicacion.ToString().Length == 4)
                {
                    strTemporalSemilla = TemporalSemillaMultiplicacion.ToString();
                    strTemporalSemilla = '0' + strTemporalSemilla;

                    dtgvTabla.Rows[intIndice].Cells[3].Value = strTemporalSemilla;

                    strTemporalSemilla = TemporalSemillaMultiplicacion.ToString();
                    strTemporalSemilla = strTemporalSemilla.Remove(0, 1);
                    strTemporalSemilla = strTemporalSemilla.Remove(2);//

                    dtgvTabla.Rows[intIndice].Cells[4].Value = strTemporalSemilla;
                    dtgvTabla.Rows[intIndice].Cells[5].Value = strTemporalSemilla;
                    dtgvTabla.Rows[intIndice].Cells[6].Value = "0." + strTemporalSemilla;

                    intSemilla = intSemilla2;
                    intSemilla2 = int.Parse(strTemporalSemilla);
                }
                else if (intT == 3 && TemporalSemillaMultiplicacion.ToString().Length == 5)
                {
                    strTemporalSemilla = TemporalSemillaMultiplicacion.ToString();

                    dtgvTabla.Rows[intIndice].Cells[3].Value = strTemporalSemilla;

                    strTemporalSemilla = TemporalSemillaMultiplicacion.ToString();
                    strTemporalSemilla = strTemporalSemilla.Remove(0, 1);
                    strTemporalSemilla = strTemporalSemilla.Remove(3);

                    dtgvTabla.Rows[intIndice].Cells[4].Value = strTemporalSemilla;
                    dtgvTabla.Rows[intIndice].Cells[5].Value = strTemporalSemilla;
                    dtgvTabla.Rows[intIndice].Cells[6].Value = "0." + strTemporalSemilla;

                    intSemilla = intSemilla2;
                    intSemilla2 = int.Parse(strTemporalSemilla);
                    //MessageBox.Show(strTemporalSemilla);
                }
                else if (intT == 3 && TemporalSemillaMultiplicacion.ToString().Length == 6)
                {
                    strTemporalSemilla = TemporalSemillaMultiplicacion.ToString();
                    strTemporalSemilla = '0' + strTemporalSemilla;

                    dtgvTabla.Rows[intIndice].Cells[3].Value = strTemporalSemilla;

                    strTemporalSemilla = TemporalSemillaMultiplicacion.ToString();
                    strTemporalSemilla = strTemporalSemilla.Remove(0, 1);
                    strTemporalSemilla = strTemporalSemilla.Remove(3);

                    dtgvTabla.Rows[intIndice].Cells[4].Value = strTemporalSemilla;
                    dtgvTabla.Rows[intIndice].Cells[5].Value = strTemporalSemilla;
                    dtgvTabla.Rows[intIndice].Cells[6].Value = "0." + strTemporalSemilla;

                    intSemilla = intSemilla2;
                    intSemilla2 = int.Parse(strTemporalSemilla);
                }
                else if (intT == 3 && TemporalSemillaMultiplicacion.ToString().Length == 7)
                {
                    strTemporalSemilla = TemporalSemillaMultiplicacion.ToString();

                    dtgvTabla.Rows[intIndice].Cells[3].Value = strTemporalSemilla;

                    strTemporalSemilla = TemporalSemillaMultiplicacion.ToString();
                    strTemporalSemilla = strTemporalSemilla.Remove(0, 2);
                    strTemporalSemilla = strTemporalSemilla.Remove(3);

                    dtgvTabla.Rows[intIndice].Cells[4].Value = strTemporalSemilla;
                    dtgvTabla.Rows[intIndice].Cells[5].Value = strTemporalSemilla;
                    dtgvTabla.Rows[intIndice].Cells[6].Value = "0." + strTemporalSemilla;

                    intSemilla = intSemilla2;
                    intSemilla2 = int.Parse(strTemporalSemilla);
                }
                else if (intT == 3 && TemporalSemillaMultiplicacion.ToString().Length == 8)
                {
                    strTemporalSemilla = TemporalSemillaMultiplicacion.ToString();
                    strTemporalSemilla = '0' + strTemporalSemilla;

                    dtgvTabla.Rows[intIndice].Cells[3].Value = strTemporalSemilla;

                    strTemporalSemilla = TemporalSemillaMultiplicacion.ToString();
                    strTemporalSemilla = strTemporalSemilla.Remove(0, 2);
                    strTemporalSemilla = strTemporalSemilla.Remove(3);

                    dtgvTabla.Rows[intIndice].Cells[4].Value = strTemporalSemilla;
                    dtgvTabla.Rows[intIndice].Cells[5].Value = strTemporalSemilla;
                    dtgvTabla.Rows[intIndice].Cells[6].Value = "0." + strTemporalSemilla;

                    intSemilla = intSemilla2;
                    intSemilla2 = int.Parse(strTemporalSemilla);
                }
                //Funcionando
                else if (intT == 4 && TemporalSemillaMultiplicacion.ToString().Length == 3) 
                {
                    strTemporalSemilla = TemporalSemillaMultiplicacion.ToString();
                    strTemporalSemilla = '0' + strTemporalSemilla;

                    dtgvTabla.Rows[intIndice].Cells[3].Value = strTemporalSemilla;

                    strTemporalSemilla = TemporalSemillaMultiplicacion.ToString();

                    dtgvTabla.Rows[intIndice].Cells[4].Value = strTemporalSemilla;
                    dtgvTabla.Rows[intIndice].Cells[5].Value = strTemporalSemilla;
                    dtgvTabla.Rows[intIndice].Cells[6].Value = "0." + strTemporalSemilla;

                    intSemilla = intSemilla2;
                    intSemilla2 = int.Parse(strTemporalSemilla);
                }
                else if (intT == 4 && TemporalSemillaMultiplicacion.ToString().Length == 4)
                {
                    strTemporalSemilla = TemporalSemillaMultiplicacion.ToString();

                    dtgvTabla.Rows[intIndice].Cells[3].Value = strTemporalSemilla;

                    strTemporalSemilla = TemporalSemillaMultiplicacion.ToString();

                    dtgvTabla.Rows[intIndice].Cells[4].Value = strTemporalSemilla;
                    dtgvTabla.Rows[intIndice].Cells[5].Value = strTemporalSemilla;
                    dtgvTabla.Rows[intIndice].Cells[6].Value = "0." + strTemporalSemilla;

                    intSemilla = intSemilla2;
                    intSemilla2 = int.Parse(strTemporalSemilla);
                }
                else if (intT == 4 && TemporalSemillaMultiplicacion.ToString().Length == 5)
                {
                    strTemporalSemilla = TemporalSemillaMultiplicacion.ToString();
                    strTemporalSemilla = '0' + strTemporalSemilla;

                    dtgvTabla.Rows[intIndice].Cells[3].Value = strTemporalSemilla;

                    strTemporalSemilla = TemporalSemillaMultiplicacion.ToString();
                    strTemporalSemilla = strTemporalSemilla.Remove(0, 0);
                    strTemporalSemilla = strTemporalSemilla.Remove(4);

                    dtgvTabla.Rows[intIndice].Cells[4].Value = strTemporalSemilla;
                    dtgvTabla.Rows[intIndice].Cells[5].Value = strTemporalSemilla;
                    dtgvTabla.Rows[intIndice].Cells[6].Value = "0." + strTemporalSemilla;

                    intSemilla = intSemilla2;
                    intSemilla2 = int.Parse(strTemporalSemilla);
                }
                else if (intT == 4 && TemporalSemillaMultiplicacion.ToString().Length == 6)
                {
                    strTemporalSemilla = TemporalSemillaMultiplicacion.ToString();

                    dtgvTabla.Rows[intIndice].Cells[3].Value = strTemporalSemilla;

                    strTemporalSemilla = TemporalSemillaMultiplicacion.ToString();
                    strTemporalSemilla = strTemporalSemilla.Remove(0, 1);//Pendiente
                    strTemporalSemilla = strTemporalSemilla.Remove(4);

                    dtgvTabla.Rows[intIndice].Cells[4].Value = strTemporalSemilla;
                    dtgvTabla.Rows[intIndice].Cells[5].Value = strTemporalSemilla;
                    dtgvTabla.Rows[intIndice].Cells[6].Value = "0." + strTemporalSemilla;

                    intSemilla = intSemilla2;
                    intSemilla2 = int.Parse(strTemporalSemilla);
                }
                else if (intT == 4 && TemporalSemillaMultiplicacion.ToString().Length == 7)
                {
                    strTemporalSemilla = TemporalSemillaMultiplicacion.ToString();
                    strTemporalSemilla = '0' + strTemporalSemilla;

                    dtgvTabla.Rows[intIndice].Cells[3].Value = strTemporalSemilla;

                    strTemporalSemilla = TemporalSemillaMultiplicacion.ToString();
                    strTemporalSemilla = strTemporalSemilla.Remove(0, 1);
                    strTemporalSemilla = strTemporalSemilla.Remove(4);

                    dtgvTabla.Rows[intIndice].Cells[4].Value = strTemporalSemilla;
                    dtgvTabla.Rows[intIndice].Cells[5].Value = strTemporalSemilla;
                    dtgvTabla.Rows[intIndice].Cells[6].Value = "0." + strTemporalSemilla;

                    intSemilla = intSemilla2;
                    intSemilla2 = int.Parse(strTemporalSemilla);
                }
                else if (intT == 4 && TemporalSemillaMultiplicacion.ToString().Length == 8)
                {
                    strTemporalSemilla = TemporalSemillaMultiplicacion.ToString();

                    dtgvTabla.Rows[intIndice].Cells[3].Value = strTemporalSemilla;

                    strTemporalSemilla = TemporalSemillaMultiplicacion.ToString();
                    strTemporalSemilla = strTemporalSemilla.Remove(0, 2);
                    strTemporalSemilla = strTemporalSemilla.Remove(4);

                    dtgvTabla.Rows[intIndice].Cells[4].Value = strTemporalSemilla;
                    dtgvTabla.Rows[intIndice].Cells[5].Value = strTemporalSemilla;
                    dtgvTabla.Rows[intIndice].Cells[6].Value = "0." + strTemporalSemilla;

                    intSemilla = intSemilla2;
                    intSemilla2 = int.Parse(strTemporalSemilla);
                }

                if ((intSemilla < 32 && intSemilla2 < 32) || (intSemilla == 0 || intSemilla2 == 0))
                {
                    MessageBox.Show("Lo sentimos, no podemos continuar, alguna semilla vale 0" +
                        " o no son lo suficientemente grandes para continuar...");
                    break;
                } 

                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Mensaje = "";
            int Indice = dtgvTabla.Rows.Count;
            Indice = Indice - 1;
            int Val1 = (int)dtgvTabla.Rows[Indice].Cells[1].Value, Val2 = (int)dtgvTabla.Rows[Indice].Cells[2].Value;
            string Val3 = (string)dtgvTabla.Rows[Indice].Cells[3].Value, Val4 = (string)dtgvTabla.Rows[Indice].Cells[4].Value; 
            string Val5 = (string)dtgvTabla.Rows[Indice].Cells[5].Value, Val6 = (string)dtgvTabla.Rows[Indice].Cells[6].Value;
            string strFila = $"{Val1}/{Val2}/{Val3}/{Val4}/{Val5}/{Val6}";
            
            do
            {
                Mensaje = InputDialog.mostrar("Agregue el nombre del archivo", "Nombre del archivo");
                if (File.Exists($@"C:\Users\sotoc\Desktop\{Mensaje}.txt")) 
                {
                    MessageBox.Show("Ese noombre ya existe, por favor elija otro nombre...");
                    Mensaje = "";
                }
            }
            while (Mensaje=="");
            
            File.WriteAllText($@"C:\Users\gcosc\Desktop\{Mensaje}.txt", "La ultima fila es: \n"+strFila);
            MessageBox.Show("El archivo ha sido guardado");

        }
    }
}
