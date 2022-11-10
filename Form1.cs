 using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace TresEnRaya
{
    public partial class FORM : Form
    {
        int turno = 1;
        int[,] TresEnRaya;
        int PuntosAmd = 0;
        int PuntosIntel = 0;
        bool HaGanado;
        public FORM()
        {
            InitializeComponent();
            IniciarJuego();
        }

        public void IniciarJuego()
        {
            turno = 1;
            TresEnRaya = new int[3, 3];
            HaGanado = false;
            pbxGanador.Image = Properties.Resources.interrogacion;

            tablero.Controls.Clear();

            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    var FichaJuego = new PictureBox();
                    FichaJuego.Image = Properties.Resources.interrogacion;
                    FichaJuego.Name = string.Format("{0}", i + "_" + j);
                    FichaJuego.Dock = DockStyle.Fill;
                    FichaJuego.Cursor = Cursors.Hand;
                    FichaJuego.SizeMode = PictureBoxSizeMode.StretchImage;
                    FichaJuego.Click += Jugar;

                    tablero.Controls.Add(FichaJuego, j, i);
                    TresEnRaya[i, j] = 0;
                }
            }
        }

        private void Jugar(object sender, EventArgs e)
        {
            var FichaSeleccionada = (PictureBox)sender;
            FichaSeleccionada.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("f_" + turno);
            string[] Posicion = FichaSeleccionada.Name.Split("_".ToCharArray());
            int Fila = Convert.ToInt32(Posicion[0]);
            int Columna = Convert.ToInt32(Posicion[1]);
            TresEnRaya[Fila, Columna] = turno;
            Verificar(Fila, Columna);
            turno = (turno == 1) ? 2 : 1;
        }

        public void Verificar(int Fila, int Columna)
        {
            int GanoFilas = 0;
            int GanoColumnas = 0;
            int DiagonalPrincipal = 0;
            int DiagonalInversa = 0;
            int TamanioTER = 3;

            for (var i = 0; i < TamanioTER; i++)
            {
                for (var j = 0; j < TamanioTER; j++)
                {
                    if (i == Fila)
                    {
                        if (TresEnRaya[i, j] == turno)
                        {
                            GanoFilas++;
                        }
                    }

                    if (i == Columna)
                    {
                        if (TresEnRaya[i, j] == turno)
                        {
                            GanoColumnas++;
                        }
                    }

                    if (i == j)
                    {
                        if (TresEnRaya[i, j] == turno)
                        {
                            DiagonalPrincipal++;
                        }
                    }

                    if ((i + j) == (TamanioTER - 1))
                    {
                        if (TresEnRaya[i, j] == turno)
                        {
                            DiagonalInversa++;
                        }
                    }
                }
            }

            if ((GanoFilas == TamanioTER) || (GanoColumnas == TamanioTER) || (DiagonalInversa == TamanioTER) || (DiagonalPrincipal == TamanioTER))
            {
                HaGanado = true;
            }

            if (HaGanado)
            {
                MessageBox.Show("FELICIDADES JUGADOR " + turno + ", BIEN JUGADO");
                pbxGanador.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("f_" + turno);

                if (turno == 1)
                {
                    PuntosAmd++;
                    lblPuntosAmd.Text = PuntosAmd.ToString();
                }
                else
                {
                    PuntosIntel++;
                    lblpuntosIntel.Text = PuntosIntel.ToString();
                }
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            IniciarJuego();
        }
    }
}
