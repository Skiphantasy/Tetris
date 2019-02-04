using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Tetris
{
	/// <summary>
	/// Descripción breve de Form1.
	/// </summary>
	public class frmGUI : System.Windows.Forms.Form
	{
		private System.Windows.Forms.PictureBox pbPantallaJuego;
		private System.Windows.Forms.Timer timer1;
		private System.ComponentModel.IContainer components;
		public static Tetris t;
		private bool haciaAbajo;
		private bool haciaDerecha;
		private bool rotaDerecha;
		private bool rotaIzquierda;
		private bool enPausa;
		private Timer timer2;
		private Label lblNumLineas;
		private Label lblNivel;
		private Label label2;
		private Label label1;
		private MainMenu mainMenu1;
		private MenuItem mnuJuego;
		private MenuItem mnuAyuda;
		private MenuItem mnuNuevo;
		private MenuItem mnuSalir;
		private MenuItem mnuAcerca;
		private Label label3;
		private PictureBox pbPiezaSiguiente;
		private MenuItem mnuPausa;
        private ToolTip toolTip1;
        private static int height, width;
        private MenuItem mnuRanking;
        private MenuItem mnuVerRanking;
        private MenuItem mnuOpciones;
        private MenuItem mnuFilasColumnas;
        private bool haciaIzquierda;
        private static PictureBox picbox;

        public static Tetris T { get => t; set => t = value; }
        public static int Height1 { get => height; set => height = value; }
        public static int Width1 { get => width; set => width = value; }
        public static PictureBox Picbox { get => picbox; set => picbox = value; }

        public frmGUI()
		{
            //
            // Necesario para admitir el Diseñador de Windows Forms
            //
            this.pbPantallaJuego = new PictureBox();
            picbox = pbPantallaJuego;
            width = Constantes.columnasPantalla * 20;
            height = Constantes.filasPantalla * 20; 
            InitializeComponent();
			//
			// TODO: agregar código de constructor después de llamar a InitializeComponent
			//
		}

		/// <summary>
		/// Limpiar los recursos que se estén utilizando.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Código generado por el Diseñador de Windows Forms
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new Container();
            this.timer1 = new Timer(this.components);
            this.timer2 = new Timer(this.components);
            this.lblNumLineas = new Label();
            this.lblNivel = new Label();
            this.label2 = new Label();
            this.label1 = new Label();
            this.mainMenu1 = new MainMenu(this.components);
            this.mnuJuego = new MenuItem();
            this.mnuNuevo = new MenuItem();
            this.mnuPausa = new MenuItem();
            this.mnuSalir = new MenuItem();
            this.mnuOpciones = new MenuItem();
            this.mnuFilasColumnas = new MenuItem();
            this.mnuRanking = new MenuItem();
            this.mnuVerRanking = new MenuItem();
            this.mnuAyuda = new MenuItem();
            this.mnuAcerca = new MenuItem();
            this.pbPiezaSiguiente = new PictureBox();
            this.label3 = new Label();
            this.toolTip1 = new ToolTip(this.components);
            ((ISupportInitialize)(picbox)).BeginInit();
            ((ISupportInitialize)(this.pbPiezaSiguiente)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPantallaJuego
            // 
            picbox.BackColor = System.Drawing.Color.Black;
            picbox.Location = new System.Drawing.Point(136, 24);
            picbox.Name = "pbPantallaJuego";
            picbox.Size = new System.Drawing.Size(width, height);
            picbox.TabIndex = 0;
            picbox.TabStop = false;
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
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nivel:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Lineas:";
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuJuego,
            this.mnuOpciones,
            this.mnuRanking,
            this.mnuAyuda});
            // 
            // mnuJuego
            // 
            this.mnuJuego.Index = 0;
            this.mnuJuego.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuNuevo,
            this.mnuPausa,
            this.mnuSalir});
            this.mnuJuego.Text = "Juego";
            // 
            // mnuNuevo
            // 
            this.mnuNuevo.Index = 0;
            this.mnuNuevo.Text = "Nuevo";
            this.mnuNuevo.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // mnuPausa
            // 
            this.mnuPausa.Index = 1;
            this.mnuPausa.Text = "Pausa";
            this.mnuPausa.Click += new System.EventHandler(this.menuItem6_Click);
            // 
            // mnuSalir
            // 
            this.mnuSalir.Index = 2;
            this.mnuSalir.Text = "Salir";
            this.mnuSalir.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // mnuOpciones
            // 
            this.mnuOpciones.Index = 1;
            this.mnuOpciones.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuFilasColumnas});
            this.mnuOpciones.Text = "Opciones";
            // 
            // mnuFilasColumnas
            // 
            this.mnuFilasColumnas.Index = 0;
            this.mnuFilasColumnas.Text = "Modificar Filas/Columnas";
            this.mnuFilasColumnas.Click += new System.EventHandler(this.mnuFilasColumnas_Click);
            // 
            // mnuRanking
            // 
            this.mnuRanking.Index = 2;
            this.mnuRanking.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuVerRanking});
            this.mnuRanking.Text = "Ranking";
            // 
            // mnuVerRanking
            // 
            this.mnuVerRanking.Index = 0;
            this.mnuVerRanking.Text = "Ver Ranking";
            // 
            // mnuAyuda
            // 
            this.mnuAyuda.Index = 3;
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
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Próxima pieza:";
            // 
            // frmGUI
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(416, 473);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbPiezaSiguiente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.lblNumLineas);
            this.Controls.Add(this.pbPantallaJuego);
            this.Menu = this.mainMenu1;
            this.Name = "frmGUI";
            this.Text = "eTetris";
            this.Load += new System.EventHandler(this.frmGUI_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGUI_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmGUI_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(picbox)).EndInit();
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
			nuevoJuego();
		}

		private void menuItem5_Click(object sender, System.EventArgs e)
		{
			enPausa = false;
			pausaJuego();
			AcerdaDe a = new AcerdaDe();
			a.ShowDialog();
			a.Dispose();
			enPausa = true;
			pausaJuego();
		}

		private void menuItem6_Click(object sender, System.EventArgs e)
		{
			pausaJuego();
		}

        private void mnuFilasColumnas_Click(object sender, EventArgs e)
        {
            Form form = new frmRowsColumns();
            form.ShowDialog();
        }
    }
}
