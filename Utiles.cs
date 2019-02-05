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
	/// Descripci�n breve de Utiles.
	/// </summary>
	public class Utiles
	{
		public static bool ResolucionCorrecta(int ancho, int alto)
		{
			bool correcto = false;
			System.Drawing.Rectangle pantalla = Screen.PrimaryScreen.Bounds;
			if (pantalla.Width >= ancho && pantalla.Height >= alto)
				correcto = true;
			return correcto;
		}
	}
}
