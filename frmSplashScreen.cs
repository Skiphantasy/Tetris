/*
 * EXERCISE............: Exercise 11.
 * NAME AND LASTNAME...: Tania López Martín 
 * CURSE AND GROUP.....: 2º Interface Development 
 * PROJECT.............: Tetris
 * DATE................: 05 Feb 2019
 */


using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tetris
{
    public partial class frmSplashScreen : Form
    {
        #region attributes
        int time;
        #endregion
        #region constructor
        public frmSplashScreen()
        {            
            InitializeComponent();
            this.BackColor = Color.Black;
            this.TransparencyKey = Color.Black;
            time = 0;
            this.tmrBar.Start();
        }
        #endregion     
        #region event voids
        private void tmrBar_Tick(object sender, EventArgs e)
        {
            time++;

            if (time < 200)
            {
            }   
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
        #endregion
    }
}
