/*
 * EXERCISE............: Exercise 11.
 * NAME AND LASTNAME...: Tania López Martín 
 * CURSE AND GROUP ....: 2º Interface Development 
 * TITLE ..............: Tetris
 * DEADLINE............: 05 Feb 2019
 */


using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Db4objects.Db4o;
using System.Collections.Generic;
//using FormUtilities;

namespace Tetris
{
    /// <summary>
    /// Descripción breve de Form1.
    /// </summary>
    public class frmGUI : Form
    {
        private System.Windows.Forms.PictureBox pbPantallaJuego;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.IContainer components;
        private Tetris t;
        private bool haciaAbajo;
        private bool haciaDerecha;
        private bool rotaDerecha;
        private bool rotaIzquierda;
        private bool enPausa;
        private static int puntuacionLograda = 0;
        private Timer timer2;
        private Label lblNumLineas;
        private Label lblNivel;
        private Label lblNiv;
        private Label lblLinea;
        private MainMenu mainMenu1;
        private MenuItem menuItem1;
        private MenuItem mnuAyuda;
        private MenuItem menuItem3;
        private MenuItem menuItem4;
        private MenuItem mnuAcerca;
        private Label lblProxima;
        private bool started = false;
        private PictureBox pbPiezaSiguiente;
        private MenuItem menuItem6;
        private ToolTip toolTip1;
        private MenuItem mnuRanking;
        private MenuItem mnuVer;
        private Label lblPun;
        private Label lblPuntuacion;
        private bool haciaIzquierda;
        private static int height, width;
        private static Puntuacion[] maxPuntuaciones = new Puntuacion[5];
        private static List<Puntuacion> punts;

        public static int Height1 { get => height; set => height = value; }
        public static int Width1 { get => width; set => width = value; }
        internal static Puntuacion[] MaxPuntuaciones { get => maxPuntuaciones; set => maxPuntuaciones = value; }
        public static int PuntuacionLograda { get => puntuacionLograda; set => puntuacionLograda = value; }
        internal static List<Puntuacion> Punts { get => punts; set => punts = value; }

        public frmGUI()
        {
            //
            // Necesario para admitir el Diseñador de Windows Forms
            //
            InitializeComponent();
            punts = new List<Puntuacion>();
            //Options.CreateRegKey(@"SOFTWARE\P11", "Uses");

            //
            // TODO: agregar código de constructor después de llamar a InitializeComponent
            //
        }

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms
        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGUI));
            this.pbPantallaJuego = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblNumLineas = new System.Windows.Forms.Label();
            this.lblNivel = new System.Windows.Forms.Label();
            this.lblNiv = new System.Windows.Forms.Label();
            this.lblLinea = new System.Windows.Forms.Label();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.mnuRanking = new System.Windows.Forms.MenuItem();
            this.mnuVer = new System.Windows.Forms.MenuItem();
            this.mnuAyuda = new System.Windows.Forms.MenuItem();
            this.mnuAcerca = new System.Windows.Forms.MenuItem();
            this.pbPiezaSiguiente = new System.Windows.Forms.PictureBox();
            this.lblProxima = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblPuntuacion = new System.Windows.Forms.Label();
            this.lblPun = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPantallaJuego)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPiezaSiguiente)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPantallaJuego
            // 
            this.pbPantallaJuego.BackColor = System.Drawing.Color.Black;
            this.pbPantallaJuego.Location = new System.Drawing.Point(136, 24);
            this.pbPantallaJuego.Name = "pbPantallaJuego";
            this.pbPantallaJuego.Size = new System.Drawing.Size(260, 420);
            this.pbPantallaJuego.TabIndex = 0;
            this.pbPantallaJuego.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 800;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblNumLineas
            // 
            this.lblNumLineas.BackColor = System.Drawing.Color.Black;
            this.lblNumLineas.ForeColor = System.Drawing.Color.White;
            this.lblNumLineas.Location = new System.Drawing.Point(16, 152);
            this.lblNumLineas.Name = "lblNumLineas";
            this.lblNumLineas.Size = new System.Drawing.Size(100, 23);
            this.lblNumLineas.TabIndex = 1;
            this.lblNumLineas.Text = "0";
            this.lblNumLineas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNivel
            // 
            this.lblNivel.BackColor = System.Drawing.Color.Black;
            this.lblNivel.ForeColor = System.Drawing.Color.White;
            this.lblNivel.Location = new System.Drawing.Point(16, 208);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(100, 23);
            this.lblNivel.TabIndex = 2;
            this.lblNivel.Text = "1";
            this.lblNivel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.lblNivel, "Para mi Alumno ");
            // 
            // lblNiv
            // 
            this.lblNiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNiv.Location = new System.Drawing.Point(16, 192);
            this.lblNiv.Name = "lblNiv";
            this.lblNiv.Size = new System.Drawing.Size(40, 16);
            this.lblNiv.TabIndex = 4;
            this.lblNiv.Text = "Nivel:";
            // 
            // lblLinea
            // 
            this.lblLinea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinea.Location = new System.Drawing.Point(16, 136);
            this.lblLinea.Name = "lblLinea";
            this.lblLinea.Size = new System.Drawing.Size(52, 16);
            this.lblLinea.TabIndex = 5;
            this.lblLinea.Text = "Líneas:";
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.mnuRanking,
            this.mnuAyuda});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem3,
            this.menuItem6,
            this.menuItem4});
            this.menuItem1.Text = "Juego";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 0;
            this.menuItem3.Text = "Nuevo";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 1;
            this.menuItem6.Text = "Pausa";
            this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 2;
            this.menuItem4.Text = "Salir";
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // mnuRanking
            // 
            this.mnuRanking.Index = 1;
            this.mnuRanking.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuVer});
            this.mnuRanking.Text = "Ranking";
            // 
            // mnuVer
            // 
            this.mnuVer.Index = 0;
            this.mnuVer.Text = "Ver Ranking";
            this.mnuVer.Click += new System.EventHandler(this.mnuVer_Click);
            // 
            // mnuAyuda
            // 
            this.mnuAyuda.Index = 2;
            this.mnuAyuda.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuAcerca});
            this.mnuAyuda.Text = "Ayuda";
            // 
            // mnuAcerca
            // 
            this.mnuAcerca.Index = 0;
            this.mnuAcerca.Text = "Acerca de...";
            this.mnuAcerca.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // pbPiezaSiguiente
            // 
            this.pbPiezaSiguiente.BackColor = System.Drawing.Color.Black;
            this.pbPiezaSiguiente.Location = new System.Drawing.Point(16, 40);
            this.pbPiezaSiguiente.Name = "pbPiezaSiguiente";
            this.pbPiezaSiguiente.Size = new System.Drawing.Size(80, 80);
            this.pbPiezaSiguiente.TabIndex = 7;
            this.pbPiezaSiguiente.TabStop = false;
            this.pbPiezaSiguiente.Click += new System.EventHandler(this.pbPiezaSiguiente_Click);
            // 
            // lblProxima
            // 
            this.lblProxima.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProxima.Location = new System.Drawing.Point(16, 24);
            this.lblProxima.Name = "lblProxima";
            this.lblProxima.Size = new System.Drawing.Size(88, 16);
            this.lblProxima.TabIndex = 8;
            this.lblProxima.Text = "Próxima pieza:";
            // 
            // lblPuntuacion
            // 
            this.lblPuntuacion.BackColor = System.Drawing.Color.Black;
            this.lblPuntuacion.ForeColor = System.Drawing.Color.White;
            this.lblPuntuacion.Location = new System.Drawing.Point(16, 267);
            this.lblPuntuacion.Name = "lblPuntuacion";
            this.lblPuntuacion.Size = new System.Drawing.Size(100, 23);
            this.lblPuntuacion.TabIndex = 9;
            this.lblPuntuacion.Text = "0";
            this.lblPuntuacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.lblPuntuacion, "Para mi Alumno ");
            // 
            // lblPun
            // 
            this.lblPun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPun.Location = new System.Drawing.Point(16, 251);
            this.lblPun.Name = "lblPun";
            this.lblPun.Size = new System.Drawing.Size(80, 16);
            this.lblPun.TabIndex = 10;
            this.lblPun.Text = "Puntuación:";
            // 
            // frmGUI
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(416, 473);
            this.Controls.Add(this.lblPun);
            this.Controls.Add(this.lblPuntuacion);
            this.Controls.Add(this.lblProxima);
            this.Controls.Add(this.pbPiezaSiguiente);
            this.Controls.Add(this.lblLinea);
            this.Controls.Add(this.lblNiv);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.lblNumLineas);
            this.Controls.Add(this.pbPantallaJuego);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu1;
            this.Name = "frmGUI";
            this.Text = "eTetris";
            this.Load += new System.EventHandler(this.frmGUI_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGUI_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmGUI_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbPantallaJuego)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPiezaSiguiente)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        /// <summary>
        /// Punto de entrada principal de la aplicación.
        /// </summary>
        [STAThread]
        //static void Main() 
        //{
        //    Application.Run(new frmGUI());
        //}

        private void frmGUI_Load(object sender, System.EventArgs e)
        {
            t = new Tetris();
            using (IObjectContainer db = Db4oFactory.OpenFile("score.data"))
            {

                IObjectSet result = db.QueryByExample(new Puntuacion(null, 0));

                if(result.HasNext())
                {
                    while (result.HasNext())
                    {
                        Puntuacion puntActual = (Puntuacion)result.Next();
                        Console.WriteLine(puntActual.Nombre + " - " + puntActual.Puntos);
                        punts.Add(puntActual);                   
                    }
                }

                punts.Sort();
                punts.Reverse();
                db.Commit();
                db.Close();
            }
        }


		private void frmGUI_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			string strKeyPress = null;
			strKeyPress = e.KeyCode.ToString();
			if (!t.juegoTerminado)
			{
				switch(strKeyPress.ToUpper())
				{
					case "LEFT":
						haciaIzquierda = true;
						//t.muevePiezaIzquierda();
						//pintaPantalla(t.matrizPantalla);
						break;
					case "RIGHT":
						haciaDerecha = true;
						//t.muevePiezaDerecha();
						//pintaPantalla(t.matrizPantalla);
						break;
					case "UP":
						rotaDerecha = true;
						//t.rotaPiezaDerecha();
						//pintaPantalla(t.matrizPantalla);
						break;
					case "A":
						rotaIzquierda = true;
						//t.rotaPiezaIzquierda();
						//pintaPantalla(t.matrizPantalla);
						break;
					case "DOWN":
						haciaAbajo = true;
						//t.muevePiezaAbajo();
						//pintaPantalla(t.matrizPantalla);
						break;
					case "P":
						pausaJuego();
						break;
					default:
						//MessageBox.Show(strKeyPress.ToUpper());
						break;
				}
			}
			else
			{
				switch(strKeyPress.ToUpper())
				{
					case "ENTER":
						break;
					default:
						break;
				}
			}
		}

		private void frmGUI_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			string strKeyPress = null;
			strKeyPress = e.KeyCode.ToString();
			if (!t.juegoTerminado)
			{
				switch(strKeyPress.ToUpper())
				{
					case "LEFT":
						haciaIzquierda = false;
						break;
					case "RIGHT":
						haciaDerecha = false;
						break;
					case "DOWN":
						haciaAbajo = false;
						break;
					case "UP":
						rotaDerecha = false;
						break;
					case "A":
						rotaIzquierda = false;
						break;
					default:
						//MessageBox.Show(strKeyPress.ToUpper());
						break;
				}
			}
		}

		public void pintaPantalla(int [, ] matrizPantalla)
		{
			Bitmap B = new Bitmap(pbPantallaJuego.Width, pbPantallaJuego.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            //Bitmap B = new Bitmap(pbPiezaSiguiente.Width, pbPiezaSiguiente.Height, System.Drawing.Imaging.PixelFormat.Format16bppRgb555);
            Graphics G = Graphics.FromImage(B);
			G.Clear(Color.Black);
			for (int x = 0; x < Constantes.columnasPantalla; x++)
			{
				for (int y = 0; y < Constantes.filasPantalla; y++)
				{
					int elemento = matrizPantalla[y, x];
					if (elemento != 0)
					{
						dibujaCuadro(G, y, x, Constantes.COLORES(elemento - 1));
					}
				}
			}
			pbPantallaJuego.Image = B;
		}
		
		public void pintaPiezaSiguiente(Pieza p)
		{
            Bitmap B = new Bitmap(pbPiezaSiguiente.Width, pbPiezaSiguiente.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            //Bitmap B = new Bitmap(pbPiezaSiguiente.Width, pbPiezaSiguiente.Height, System.Drawing.Imaging.PixelFormat.Format16bppRgb555);
            Graphics G = Graphics.FromImage(B);
			G.Clear(Color.Black);
			for (int x = 0; x < Constantes.COLUMNAS_PIEZAS; x++)
			{
				for (int y = 0; y < Constantes.FILAS_PIEZAS; y++)
				{
					int elemento = t.piezaSiguiente[y, x];
					if (elemento != 0)
					{
						dibujaCuadro(G, y, x, Constantes.COLORES(t.piezaSiguiente.color - 1));
					}
				}
			}
			pbPiezaSiguiente.Image = B;
		}

		private void dibujaCuadro(Graphics G, int Y,int X, Color C)
		{
			int x = (X * Constantes.ANCHO_CELDA) + 1;
			int y = (Y * Constantes.ALTO_CELDA) + 1;
			SolidBrush Br = new SolidBrush(C);
			G.FillRectangle(Br, x, y, Constantes.ANCHO_CELDA - 2, Constantes.ALTO_CELDA - 2);
		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			if (t.numLineas < Constantes.NUM_LINEAS_POR_NIVEL)
			{
				lblNumLineas.Text = t.numLineas.ToString();
                lblPuntuacion.Text = t.puntuacion.ToString();
                puntuacionLograda = t.puntuacion;
                if (haciaAbajo)
					actualizaPantalla();
				else
				{
					haciaAbajo = true;
					actualizaPantalla();
					haciaAbajo = false;
				}
				pintaPiezaSiguiente(t.piezaSiguiente);
				if (t.juegoTerminado)
				{
					timer1.Stop();
					MessageBox.Show("Se terminó el juego");
                    Form form = new frmEnterName();
                    form.ShowDialog();
				}
			}
		}

		private void timer2_Tick(object sender, System.EventArgs e)
		{
			if (t.numLineas < Constantes.NUM_LINEAS_POR_NIVEL)
			{
				actualizaPantalla();
			}
			else
			{
				timer2.Stop();
				timer1.Stop();
				lblNumLineas.Text = t.numLineas.ToString();
				inicializaTeclas();
				t.nuevoNivel();
				MessageBox.Show("¡¡Enhorabuena!! Has pasado al nivel " + (t.nivel + 1));
				lblNivel.Text = ((int)t.nivel + 1).ToString();
				timer1.Interval = Constantes.NIVELES(t.nivel);
				timer2.Start();
				timer1.Start();		
			}
			if (t.juegoTerminado)
			{
                started = false;
				timer2.Stop();
			}
		}

		private void actualizaPantalla()
		{
			if (haciaAbajo)
			{
				t.muevePiezaAbajo();
			}
			if (haciaDerecha)
			{
				t.muevePiezaDerecha();
			}
			if (haciaIzquierda)
			{
				t.muevePiezaIzquierda();
			}
			if (rotaDerecha)
			{
				t.rotaPiezaDerecha();
				rotaDerecha = false;
			}	
			if (rotaIzquierda)
			{
				t.rotaPiezaIzquierda();
				rotaIzquierda = false;
			}
			pintaPantalla(t.matrizPantalla);		
		}

		private void inicializaTeclas()
		{
			haciaDerecha = false;
			haciaIzquierda = false;
			rotaDerecha = false;
			rotaIzquierda = false;
			haciaAbajo = false;
			enPausa = false;
		}

		private void nuevoJuego()
		{
            started = true;
            pbPantallaJuego.Size = new System.Drawing.Size(width, height);
            int w = width + 173;
            int h = height + 113;
            Size = new Size(w, h);
            inicializaTeclas();
			t.nuevoJuego();
			timer1.Interval = Constantes.NIVELES(t.nivel);
			pintaPantalla(t.matrizPantalla);
			timer1.Start();
			timer2.Start();
		}

		private void pausaJuego()
		{
			if (!enPausa)
			{
				timer1.Stop();
				timer2.Stop();
			}
			else
			{
				timer1.Start();
				timer2.Start();
			}
			enPausa = !enPausa;
		}

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
            Form form = new frmRowsColumns();
            form.ShowDialog();
			nuevoJuego();
		}

		private void menuItem5_Click(object sender, System.EventArgs e)
		{
            if (!t.juegoTerminado && !started)
            {
                enPausa = false;
                pausaJuego();
                Form a = new frmAbout();
                a.ShowDialog();
                a.Dispose();
               // enPausa = true;
                //pausaJuego();
            } else if(!t.juegoTerminado && started)
            {
                enPausa = false;
                pausaJuego();
                Form a = new frmAbout();
                a.ShowDialog();
                a.Dispose();
                enPausa = true;
                pausaJuego();
            }
            else if (t.juegoTerminado)
            {
                Form a = new frmAbout();
                a.ShowDialog();
            }
		}

		private void menuItem6_Click(object sender, System.EventArgs e)
		{
			pausaJuego();
		}

        private void mnuVer_Click(object sender, EventArgs e)
        {
            Form form = new frmRanking();            
            form.ShowDialog();
        }

        private void pbPiezaSiguiente_Click(object sender, EventArgs e)
        {

        }
	}
}
