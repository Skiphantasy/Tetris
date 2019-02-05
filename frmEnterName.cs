/*
 * EXERCISE............: Exercise 11.
 * NAME AND LASTNAME...: Tania López Martín 
 * CURSE AND GROUP ....: 2º Interface Development 
 * TITLE ..............: Tetris
 * DEADLINE............: 05 Feb 2019
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Db4objects.Db4o;

namespace Tetris
{
    public partial class frmEnterName : Form
    {
        public frmEnterName()
        {
            InitializeComponent();
            lblTotal.Text = frmGUI.PuntuacionLograda.ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            using (IObjectContainer db = Db4oFactory.OpenFile("score.data"))
            {
                IObjectSet result = db.QueryByExample(new Puntuacion(null, 0));

                if (result.HasNext())
                {
                    while(result.HasNext())
                    {
                        Puntuacion puntActual = (Puntuacion)result.Next();
                        //punts.Add(puntActual);
                        db.Delete(puntActual);
                    }
                }

                frmGUI.Punts.Add(new Puntuacion(txtEnter.Text, frmGUI.PuntuacionLograda));

                frmGUI.Punts.Sort();
                frmGUI.Punts.Reverse();

                for (int i = 0; i < frmGUI.Punts.Count; i++)
                {
                    //frmGUI.MaxPuntuaciones[i] = punts[i];
                    db.Store(frmGUI.Punts);
                }

                db.Commit();
                db.Close();
            }

            Close();
        }
    }
}
