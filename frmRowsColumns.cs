using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Tetris
{
    public partial class frmRowsColumns : Form
    {
        public frmRowsColumns()
        {
            InitializeComponent();
            txtColumnas.Text = Constantes.columnasPantalla.ToString();
            CenterToParent();
            txtFilas.Text = Constantes.filasPantalla.ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Constantes.columnasPantalla = int.Parse(txtColumnas.Text);
            Constantes.filasPantalla = int.Parse(txtFilas.Text);
            MessageBox.Show("Se han guardado los cambios");
            frmGUI.Width1 = Constantes.columnasPantalla * 20;
            frmGUI.Height1 = Constantes.filasPantalla * 20;
            Close();
            /*frmGUI.T = new Tetris();
            frmGUI.Picbox.Size = new System.Drawing.Size(frmGUI.Width1, frmGUI.Height1);*/
        }

        private void btnCalcelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtFilas_Leave(object sender, EventArgs e)
        {
            int number;
            if(!int.TryParse(txtFilas.Text, out number))
            {
                txtFilas.Text = Constantes.filasPantalla.ToString();
                MessageBox.Show("Valor incorrecto. Se ha asignado el valor " + Constantes.filasPantalla
                    + " para filas");
            } else
            {
                if (int.Parse(txtFilas.Text) < 10 || int.Parse(txtFilas.Text) > 30)
                {
                    txtFilas.Text = Constantes.filasPantalla.ToString();
                    MessageBox.Show("Valor fuera de rango. Se ha asignado el valor " + Constantes.filasPantalla
                       + " para filas");
                }
            }
        }

        private void txtColumnas_Leave(object sender, EventArgs e)
        {
            int number;
            if (!int.TryParse(txtColumnas.Text, out number))
            {
                txtColumnas.Text = Constantes.columnasPantalla.ToString();
                MessageBox.Show("Valor incorrecto. Se ha asignado el valor " + Constantes.columnasPantalla
                   + " para columnas");
            } else
            {
                if(int.Parse(txtColumnas.Text) < 10 || int.Parse(txtColumnas.Text) > 30)
                {
                    txtColumnas.Text = Constantes.columnasPantalla.ToString();
                    MessageBox.Show("Valor fuera de rango. Se ha asignado el valor " + Constantes.columnasPantalla
                       + " para columnas");
                }
            }
        }
    }
}
