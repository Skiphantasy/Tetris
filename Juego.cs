/*
 * EXERCISE............: Exercise 11.
 * NAME AND LASTNAME...: Tania López Martín 
 * CURSE AND GROUP ....: 2º Interface Development 
 * TITLE ..............: Tetris
 * DEADLINE............: 05 Feb 2019
 */


using System;
using System.Windows.Forms;

namespace Tetris
{
	/// <summary>
	/// Descripción breve de Juego.
	/// </summary>
	public class Juego
	{
		public static void Main()
		{
			if ( !Utiles.ResolucionCorrecta(800, 600) )
			{
				MessageBox.Show("Para ejecutar el juego, debe tener como mínimo una resolución de 800 x 600");
			}
			else
			{
                frmSplashScreen splash;
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                splash = new frmSplashScreen();

                if (splash.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new frmGUI());
                }
            }
		}
	}
}
