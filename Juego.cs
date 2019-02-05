/*
 * EXERCISE............: Exercise 11.
 * NAME AND LASTNAME...: Tania L�pez Mart�n 
 * CURSE AND GROUP ....: 2� Interface Development 
 * TITLE ..............: Tetris
 * DEADLINE............: 05 Feb 2019
 */


using System;
using System.Windows.Forms;

namespace Tetris
{
	/// <summary>
	/// Descripci�n breve de Juego.
	/// </summary>
	public class Juego
	{
		public static void Main()
		{
			if ( !Utiles.ResolucionCorrecta(800, 600) )
			{
				MessageBox.Show("Para ejecutar el juego, debe tener como m�nimo una resoluci�n de 800 x 600");
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
