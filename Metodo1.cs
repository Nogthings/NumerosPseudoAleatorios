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
    public partial class Metodo1 : Form
    {
        public Metodo1()
        {
            InitializeComponent();
            btnGenerar.Enabled = false;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if ((txtBoxSemilla.TextLength >= 3 && int.Parse(txtBoxSemilla.Text) >= 111) && (txtBoxT.TextLength == 1 && (int.Parse(txtBoxT.Text) == 3 || int.Parse(txtBoxT.Text) == 4)) && (txtBoxIteraciones.TextLength == 2 && (int.Parse(txtBoxIteraciones.Text) >= 10 && int.Parse(txtBoxIteraciones.Text) <= 30)))
            {
                btnGenerar.Enabled = true;
            }
            else { btnGenerar.Enabled = false; }
        }

        private void txtBoxT_TextChanged(object sender, EventArgs e)
        {
            if ((txtBoxSemilla.TextLength >= 3 && int.Parse(txtBoxSemilla.Text) >= 111) && (txtBoxT.TextLength == 1 && (int.Parse(txtBoxT.Text) == 3 || int.Parse(txtBoxT.Text) == 4)) && (txtBoxIteraciones.TextLength == 2 && (int.Parse(txtBoxIteraciones.Text) >= 10 && int.Parse(txtBoxIteraciones.Text) <= 30)))
            {
                btnGenerar.Enabled = true;
            }
            else { btnGenerar.Enabled = false; }
        }

        private void txtBoxIteraciones_TextChanged(object sender, EventArgs e)
        {
            if ((txtBoxSemilla.TextLength >= 3 && int.Parse(txtBoxSemilla.Text) >= 111) && (txtBoxT.TextLength == 1 && (int.Parse(txtBoxT.Text) == 3 || int.Parse(txtBoxT.Text) == 4)) && (txtBoxIteraciones.TextLength == 2 && (int.Parse(txtBoxIteraciones.Text) >= 10 && int.Parse(txtBoxIteraciones.Text) <= 30)))
            {
                btnGenerar.Enabled = true;
            }
            else { btnGenerar.Enabled = false; }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtBoxT_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (Char.IsDigit(e.KeyChar))
            //{
            //    e.Handled = false;
            //}
            //else if (Char.IsControl(e.KeyChar))
            //{
            //    e.Handled = false;
            //}
            //else if (Char.IsSeparator(e.KeyChar))
            //{
            //    e.Handled = false;
            //}
            //else if (Char.IsNumber(e.KeyChar)) 
            //{ 
            //    e.Handled = false; 
            //}
            //else
            //{
            //    e.Handled = true;//
            //}
            if (e.KeyChar == '4') {e.Handled = false;}
            else if (e.KeyChar == '3') {e.Handled = false;}
            else if (Char.IsControl(e.KeyChar)){e.Handled = false;}
            else { e.Handled = true;}
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
        }

        private void Metodo1_Load(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 90;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;
            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(this.txtBoxT, "Este campo se llena con el valor 3 o 4.");
            toolTip1.SetToolTip(this.txtBoxSemilla, "Este campo se llena con la semilla.");
            toolTip1.SetToolTip(this.txtBoxIteraciones, "La cantidad de números generados.");
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 MenuPrincipal = new Form1();
            MenuPrincipal.Show();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int intContador = 0;
            string strSemilla = txtBoxSemilla.Text;
            string strT = txtBoxT.Text;
            string strIteraciones = txtBoxIteraciones.Text;
            //try{}catch (Exception f){MessageBox.Show($"{f.ToString()} Exception caught.");}
            int intSemilla = 0;
            int intT = 0;
            int intIteraciones = 0;

            intSemilla = int.Parse(strSemilla);
            intT = int.Parse(strT);
            intIteraciones = int.Parse(strIteraciones);
            //Algoritmo
            double doblTemporalSemilla = 0;
            //MessageBox.Show(doblTemporalSemilla.ToString());
            for (intContador = 1; intContador <= intIteraciones; intContador++)
            {
                doblTemporalSemilla = intSemilla;
                int intIndice = dtgvTabla.Rows.Add();//Agregamos una nueva fila y guardamos su indice
                dtgvTabla.Rows[intIndice].Cells[0].Value = intContador;
                dtgvTabla.Rows[intIndice].Cells[1].Value = intSemilla;
                string strTemporalSemilla = "";

                if (intT == 3 && Math.Pow(intSemilla, 2).ToString().Length == 5)
                {
                    doblTemporalSemilla = Math.Pow(intSemilla, 2);
                    strTemporalSemilla = doblTemporalSemilla.ToString();

                    dtgvTabla.Rows[intIndice].Cells[2].Value = strTemporalSemilla;

                    strTemporalSemilla = doblTemporalSemilla.ToString();
                    strTemporalSemilla = strTemporalSemilla.Remove(0, 1);
                    strTemporalSemilla = strTemporalSemilla.Remove(3);

                    dtgvTabla.Rows[intIndice].Cells[3].Value = strTemporalSemilla;
                    dtgvTabla.Rows[intIndice].Cells[4].Value = strTemporalSemilla;
                    dtgvTabla.Rows[intIndice].Cells[5].Value = "0." + strTemporalSemilla;

                    intSemilla = int.Parse(strTemporalSemilla);
                    //MessageBox.Show(strTemporalSemilla);
                }
                else if (intT == 3 && Math.Pow(intSemilla, 2).ToString().Length == 6)
                {
                    doblTemporalSemilla = Math.Pow(intSemilla, 2);
                    strTemporalSemilla = doblTemporalSemilla.ToString();
                    strTemporalSemilla = '0' + strTemporalSemilla;

                    dtgvTabla.Rows[intIndice].Cells[2].Value = strTemporalSemilla;

                    strTemporalSemilla = doblTemporalSemilla.ToString();
                    strTemporalSemilla = strTemporalSemilla.Remove(0, 1);
                    strTemporalSemilla = strTemporalSemilla.Remove(3);

                    dtgvTabla.Rows[intIndice].Cells[3].Value = strTemporalSemilla;
                    dtgvTabla.Rows[intIndice].Cells[4].Value = strTemporalSemilla;
                    dtgvTabla.Rows[intIndice].Cells[5].Value = "0." + strTemporalSemilla;

                    intSemilla = int.Parse(strTemporalSemilla);
                }
                else if (intT == 3 && Math.Pow(intSemilla, 2).ToString().Length == 7)
                {
                    doblTemporalSemilla = Math.Pow(intSemilla, 2);
                    strTemporalSemilla = doblTemporalSemilla.ToString();

                    dtgvTabla.Rows[intIndice].Cells[2].Value = strTemporalSemilla;

                    strTemporalSemilla = doblTemporalSemilla.ToString();
                    strTemporalSemilla = strTemporalSemilla.Remove(0, 2);
                    strTemporalSemilla = strTemporalSemilla.Remove(3);

                    dtgvTabla.Rows[intIndice].Cells[3].Value = strTemporalSemilla;
                    dtgvTabla.Rows[intIndice].Cells[4].Value = strTemporalSemilla;
                    dtgvTabla.Rows[intIndice].Cells[5].Value = "0." + strTemporalSemilla;

                    intSemilla = int.Parse(strTemporalSemilla);
                }
                else if (intT == 3 && Math.Pow(intSemilla, 2).ToString().Length == 8)
                {
                    doblTemporalSemilla = Math.Pow(intSemilla, 2);
                    strTemporalSemilla = doblTemporalSemilla.ToString();
                    strTemporalSemilla = '0' + strTemporalSemilla;

                    dtgvTabla.Rows[intIndice].Cells[2].Value = strTemporalSemilla;

                    strTemporalSemilla = doblTemporalSemilla.ToString();
                    strTemporalSemilla = strTemporalSemilla.Remove(0, 2);
                    strTemporalSemilla = strTemporalSemilla.Remove(3);

                    dtgvTabla.Rows[intIndice].Cells[3].Value = strTemporalSemilla;
                    dtgvTabla.Rows[intIndice].Cells[4].Value = strTemporalSemilla;
                    dtgvTabla.Rows[intIndice].Cells[5].Value = "0." + strTemporalSemilla;

                    intSemilla = int.Parse(strTemporalSemilla);
                }
                //Funcionando
                else if (intT == 4 && Math.Pow(intSemilla, 2).ToString().Length == 5)
                {
                    doblTemporalSemilla = Math.Pow(intSemilla, 2);
                    strTemporalSemilla = doblTemporalSemilla.ToString();
                    strTemporalSemilla = '0' + strTemporalSemilla;

                    dtgvTabla.Rows[intIndice].Cells[2].Value = strTemporalSemilla;

                    strTemporalSemilla = doblTemporalSemilla.ToString();
                    strTemporalSemilla = strTemporalSemilla.Remove(0, 0);
                    strTemporalSemilla = strTemporalSemilla.Remove(4);

                    dtgvTabla.Rows[intIndice].Cells[3].Value = strTemporalSemilla;
                    dtgvTabla.Rows[intIndice].Cells[4].Value = strTemporalSemilla;
                    dtgvTabla.Rows[intIndice].Cells[5].Value = "0." + strTemporalSemilla;

                    intSemilla = int.Parse(strTemporalSemilla);
                }
                else if (intT == 4 && Math.Pow(intSemilla, 2).ToString().Length == 6)
                {
                    doblTemporalSemilla = Math.Pow(intSemilla, 2);
                    strTemporalSemilla = doblTemporalSemilla.ToString();

                    dtgvTabla.Rows[intIndice].Cells[2].Value = strTemporalSemilla;

                    strTemporalSemilla = doblTemporalSemilla.ToString();
                    strTemporalSemilla = strTemporalSemilla.Remove(0, 1);//Pendiente
                    strTemporalSemilla = strTemporalSemilla.Remove(4);

                    dtgvTabla.Rows[intIndice].Cells[3].Value = strTemporalSemilla;
                    dtgvTabla.Rows[intIndice].Cells[4].Value = strTemporalSemilla;
                    dtgvTabla.Rows[intIndice].Cells[5].Value = "0." + strTemporalSemilla;

                    intSemilla = int.Parse(strTemporalSemilla);
                }
                else if (intT == 4 && Math.Pow(intSemilla, 2).ToString().Length == 7)
                {
                    doblTemporalSemilla = Math.Pow(intSemilla, 2);
                    strTemporalSemilla = doblTemporalSemilla.ToString();
                    strTemporalSemilla = '0' + strTemporalSemilla;

                    dtgvTabla.Rows[intIndice].Cells[2].Value = strTemporalSemilla;

                    strTemporalSemilla = doblTemporalSemilla.ToString();
                    strTemporalSemilla = strTemporalSemilla.Remove(0, 1);
                    strTemporalSemilla = strTemporalSemilla.Remove(4);

                    dtgvTabla.Rows[intIndice].Cells[3].Value = strTemporalSemilla;
                    dtgvTabla.Rows[intIndice].Cells[4].Value = strTemporalSemilla;
                    dtgvTabla.Rows[intIndice].Cells[5].Value = "0." + strTemporalSemilla;

                    intSemilla = int.Parse(strTemporalSemilla);
                }
                else if (intT == 4 && Math.Pow(intSemilla, 2).ToString().Length == 8)
                {
                    doblTemporalSemilla = Math.Pow(intSemilla, 2);
                    strTemporalSemilla = doblTemporalSemilla.ToString();

                    dtgvTabla.Rows[intIndice].Cells[2].Value = strTemporalSemilla;

                    strTemporalSemilla = doblTemporalSemilla.ToString();
                    strTemporalSemilla = strTemporalSemilla.Remove(0, 2);
                    strTemporalSemilla = strTemporalSemilla.Remove(4);

                    dtgvTabla.Rows[intIndice].Cells[3].Value = strTemporalSemilla;
                    dtgvTabla.Rows[intIndice].Cells[4].Value = strTemporalSemilla;
                    dtgvTabla.Rows[intIndice].Cells[5].Value = "0." + strTemporalSemilla;

                    intSemilla = int.Parse(strTemporalSemilla);
                }

                if (intSemilla == 0 || intSemilla < 100) 
                {
                    MessageBox.Show("La semilla es 0 o no es lo suficientemente grande para " +
                        "generar un numero con la longitud minima...");
                    break;
                }
            
            }
        }
    }
}
