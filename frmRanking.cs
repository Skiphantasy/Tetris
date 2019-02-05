using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Tetris
{
    public partial class frmRanking : Form
    {
        public frmRanking()
        {
            InitializeComponent();
            Label[] nombres = { lblN1, lblN2, lblN3, lblN4, lblN5};
            Label[] puntuac = { lblP1, lblP2, lblP3, lblP4, lblP5};
            if( frmGUI.Punts != null)
            {
                for (int i = 0; i < frmGUI.Punts.Count; i++)
                {
                    if (i < 5)
                    {
                        nombres[i].Text = frmGUI.Punts[i].Nombre;
                        puntuac[i].Text = frmGUI.Punts[i].Puntos.ToString();
                    }
                }
            }
            /*if( frmGUI.Punts.Count >= 5)
            {
                lblN1.Text = frmGUI.Punts[0].Nombre;
                lblN2.Text = frmGUI.Punts[1].Nombre;
                lblN3.Text = frmGUI.Punts[2].Nombre;
                lblN4.Text = frmGUI.Punts[3].Nombre;
                lblN5.Text = frmGUI.Punts[4].Nombre;

                lblP1.Text = frmGUI.Punts[0].Puntos.ToString();
                lblP2.Text = frmGUI.Punts[1].Puntos.ToString();
                lblP3.Text = frmGUI.Punts[2].Puntos.ToString();
                lblP4.Text = frmGUI.Punts[3].Puntos.ToString();
                lblP5.Text = frmGUI.Punts[4].Puntos.ToString();
            }*/
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
