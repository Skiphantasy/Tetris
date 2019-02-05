/*
 * EXERCISE............: Exercise 11.
 * NAME AND LASTNAME...: Tania López Martín 
 * CURSE AND GROUP ....: 2º Interface Development 
 * TITLE ..............: Tetris
 * DEADLINE............: 05 Feb 2019
 */


using System;

namespace Tetris
{
	/// <summary>
	/// Descripción breve de MatrizPantalla.
	/// </summary>
	public class MatrizPantalla
	{
		int [, ] m_matrizPantalla;
		
		public MatrizPantalla()
		{
			m_matrizPantalla = new int[Constantes.filasPantalla, Constantes.columnasPantalla];
		}

		public int [, ]matrizPantalla
		{
			get
			{
				return m_matrizPantalla;
			}
		}

		public int this [int y, int x]
		{
			get 
			{
				if (x < 0 || x > Constantes.columnasPantalla || y < 0 || y > Constantes.filasPantalla)
					throw new Exception("El intervalo está fuera del índice");
				else
					return m_matrizPantalla[y, x];
			}
			set 
			{
				if (!(x < 0 || x > Constantes.columnasPantalla || y < 0 || y > Constantes.filasPantalla))
					m_matrizPantalla[y, x] = value;
				else
					throw new Exception("El intervalo está fuera del índice");
			}
		}

		public void pintarPieza(Pieza p)
		{
			int ancho = p.ancho;
			int alto = p.alto;
			for (int x = 0; x < ancho; x++)
			{
				for (int y = 0; y < alto; y++)
				{
					if (p[y, x] == 1 && p.posY + y >= 0)
					{
						m_matrizPantalla[p.posY + y, p.posX + x] = p.color;
					}
				}
			}		
		}

		public bool puedeBajarPieza(Pieza p)
		{
			bool puede = true;
			int ancho = p.ancho;
			int alto = p.alto;
			if (p.posY + p.alto > Constantes.filasPantalla || hayColision(p))
			{
				puede = false;
			}
			return puede;
		}

		public bool hayColision(Pieza p)
		{
			bool hay = false;
			int ancho = p.ancho;
			int alto = p.alto;
			for (int x = 0; x < ancho; x++)
			{
				for (int y = 0; y < alto; y++)
				{
					if (p[y, x] == 1 && p.posY + y >= 0)
					{
						if (m_matrizPantalla[p.posY + y, p.posX + x] != 0)
						{
							hay = true;
						}
					}
				}
			}		
			return hay;		
		}

		public bool puedeMoverPieza(Pieza p)
		{
			bool puede = true;
			int ancho = p.ancho;
			int alto = p.alto;
			if (p.posX < 0 || p.posX + p.ancho > Constantes.columnasPantalla || hayColision(p))
			{
				puede = false;
			}
			return puede;
		}
		
		public void borrarPieza(Pieza p)
		{
			int ancho = p.ancho;
			int alto = p.alto;
			for (int x = 0; x < ancho; x++)
			{
				for (int y = 0; y < alto; y++)
				{
					if (p[y, x] == 1 && p.posY + y >= 0)
					{
						m_matrizPantalla[p.posY + y, p.posX + x] = 0;
					}
				}
			}
		}

		public void borrarPantalla()
		{
			m_matrizPantalla = new int[Constantes.filasPantalla, Constantes.columnasPantalla];
		}

		public int eliminaLineasCompletas()
		{
			bool filaCompleta = true;
			int numFilasCompletas = 0;
			int x;
			for (int y = 0; y < Constantes.filasPantalla; y++)
			{
				filaCompleta = true;
				x = 0;
				while (x < Constantes.columnasPantalla && filaCompleta)
				{
					if (m_matrizPantalla[y, x] == 0)
					{
						filaCompleta = false;
					}
					x++;
				}
				if (filaCompleta)
				{
					eliminaLinea(y);
					numFilasCompletas++;
				}
			}
			return numFilasCompletas;
		}

		private void eliminaLinea(int linea)
		{
			for (int y = linea; y > 0; y--)
			{
				for (int x = 0; x < Constantes.columnasPantalla; x++)
				{
					m_matrizPantalla[y, x] = m_matrizPantalla[y - 1, x];
				}
			}
		}
	}
}
