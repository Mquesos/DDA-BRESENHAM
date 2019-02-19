using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALGORITMOS
{
    public partial class Form1 : Form
    {
        List<ClaseCoordenada> listaCoordenadas;//Clase que se comporta como punto Point
        public Form1()
        {
            InitializeComponent();
            listaCoordenadas = new List<ClaseCoordenada>();// creando las listas en constructor

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void dibujarCoordenada(ClaseCoordenada coordenada)
        {
            Pen pen = new Pen(Color.Green, 3);
            float x, y;
            x = coordenada.getX() ;
            y = coordenada.getY() ;
            panel1.CreateGraphics().DrawEllipse(pen, x, y, 5, 5);
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            int coordenadaX, coordenadaY;

            coordenadaX = e.X;
            coordenadaY = e.Y;
            ClaseCoordenada coordenada = new ClaseCoordenada();

            coordenada.setX(coordenadaX);
            coordenada.setY(coordenadaY);
            listaCoordenadas.Add(coordenada);
            dibujarCoordenada(coordenada);
        }

        private void dda_Click(object sender, EventArgs e)
        {
            int xi, yi, xf, yf;
            xi = listaCoordenadas[0].getX();
            yi = listaCoordenadas[0].getY();
            xf = listaCoordenadas[1].getX();
            yf = listaCoordenadas[1].getY();

            float dx;
            float dy;       
            float m;
            float b;
            int kx = 0;
            int ky = 0;

            dx = xf - xi;
            dy = yf - yi;

            m = (dy / dx);
            b = (-xi * m) + yi;

            if(xi < xf | yf < xi )
            {
                if (xi < xf)
                {
                    int aux = xi;
                    xi = xf;
                    xf = aux;
                }
                else
                {
                    int auxy = yi;
                    yi = yf;
                    yf = auxy;
                }
            }

            if (dx == 0)
            {
                if (dy > 0)
                {
                    for (int k = yi; k <= yf; k++)
                    {
                        Pen pen = new Pen(Color.Green, 3);
                        panel1.CreateGraphics().DrawEllipse(pen, xi, k, 5, 5);
                    }
                }
            }
            else if (dy == 0)
            {
                if (dx > 0)
                {
                    for (int k = xi; k <= xf; k++)
                    {
                        Pen pen = new Pen(Color.Green, 3);
                        panel1.CreateGraphics().DrawEllipse(pen, xi, k, 5, 5);
                    }
                }
            }
            else
            {






            }
        }
        /*for (int i = 0; i < listaCoordenadas[1].getX(); i++)
        {
            ClaseCoordenada CoordenadasDDA = new ClaseCoordenada();


        }*/
    }
}
