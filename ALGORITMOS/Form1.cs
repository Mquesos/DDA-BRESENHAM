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
        int r = 0;
        Pen pen = new Pen(Color.Green, 3);//DDA
        Pen penb = new Pen(Color.Red, 3);//BRESENHAM
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

            float d1;
            float d2;
            float d3;
        

            dx = xf - xi;
            dy = yf - yi;

            m = (dy / dx);
            b = (-xi * m) + yi;

            //Verificar si la recta es vertical
            if (dx == 0)
            {
                if (dy > 0)
                {
                    for (int k = yi; k <= yf; k++)
                    {
                        panel1.CreateGraphics().DrawEllipse(pen, xi, k, 5, 5);
                    }
                }
            }
            //Verificar si la recta es horizontal
            if (dy == 0)
            {
                if (dy > 0)
                {
                    for (int k = xi; k <= xf; k++)
                    {
                        panel1.CreateGraphics().DrawEllipse(pen, xi, k, 5, 5);
                    }
                }
            }
            //verificar el sentido de la recta

            if(dx < 0 & dy < 0 | dx > 0 & dy < 0) 
            {
                int inx = xi;
                int iny = yi;

                xi = xf;
                xf = inx;//casteo a int

                yi = yf;
                yf = iny;//casteo a int

                dx = xf - xi;
                dy = yf - yi;
                Console.WriteLine("------------- Sentido Coordenadas ------------------");
            }

            //Verificar si X es el eje independiente de la recta
            if(Math.Abs(dx) > Math.Abs(dy))
            {
                m = dy / dx;
                //Verificar si la pendiente es mayor o menor que cero
                if(m > 0)
                {
                    for (kx = 1; kx < dx; kx++)
                    {
                        d1 = m * kx - ky;
                        d2 = (ky + 1) - m * kx;
                        d3 = d1 - d2;

                        if (d3 > 0)
                            ky++;
                        panel1.CreateGraphics().DrawEllipse(pen, xi + kx, yi + ky, 5, 5);
                    }
                }
                //Verificar si la pendiente es menor que cero
                else
                {
                    for(kx = -1; kx > dx; kx--)
                    {
                        d1 = m * kx - ky;
                        d2 = (ky + 1) - m * kx;
                        d3 = d1 - d2;

                        if (d3 > 0)
                            ky++;
                        panel1.CreateGraphics().DrawEllipse(pen, xi + kx, yi + ky, 5, 5);
                    }
                }
            }
            else if(Math.Abs(dy) > Math.Abs(dx))
            {
                m = dx / dy;

                //Verifica si la pendiente es mayor que cero
                if(m > 0)
                {
                    for (ky = 1; ky < dy; ky++)
                    {
                        d1 = m * ky - kx;
                        d2 = (kx + 1) - m * ky;
                        d3 = d1 - d2;

                        if (d3 > 0)
                            kx++;
                        panel1.CreateGraphics().DrawEllipse(pen, xi + kx, yi + ky, 5, 5);
                    }
                }
                //Verifica si la pendiente es menor que cero
                if(m < 0)
                {
                    m = Math.Abs(m);

                    for(ky = 1; ky < dy; ky++)
                    {
                        d1 = m * ky - kx;
                        d2 = (kx + 1) - m * ky;
                        d3 = d1 - d2;


                        if (d3 > 0)
                            kx++;

                        panel1.CreateGraphics().DrawEllipse(pen, xi - kx, yi + ky, 5, 5);

                    }
                }
            }
        }

        void bresenhamX(int xi, int yi, int xf, int yf, int dx,int dy)
        {
            int i, j, k, aux;

            i = 2 * dy - dx;
            j = 2 * dy;
            k = 2 * (dy - dx);

            if(!(xi < xf))
            {
                aux = xi;
                xi = xf;
                xf = aux;

                aux = yi;
                yi = yf;
                yf = aux;
            }
            panel1.CreateGraphics().DrawEllipse(penb, xi, yi, 5, 5);

            while (yi < yf)
            {
                if(i < 0)
                {
                    i += j;
                }
                else
                {
                    if(xi < xf)
                    {
                        ++xi;
                    }
                    else
                    {
                        ++xi;
                    }
                    i += k;
                }
                ++yi;
             panel1.CreateGraphics().DrawEllipse(penb, xi, yi, 5, 5);
            }
        }
        void bresenhamY(int xi, int yi, int xf, int yf, int dx, int dy)
        {
            int i, j, k, aux;

            i = 2 * dx - dy;
            j = 2 * dx;
            k = 2 * (dx - dy);

            if (!(yi < yf))
            {
                aux = xf;
                xf = xi;
                xi = aux;

                aux = yi;
                yi = yf;
                yf = aux;
            }
            panel1.CreateGraphics().DrawEllipse(penb, xi, yi, 5, 5);

            while (xi < xf)
            {
                if (i < 0)
                {
                    i += j;
                }
                else
                {
                    if (yi < yf)
                    {
                        ++yi;
                    }
                    else
                    {
                        --yf;
                    }
                    i += k;
                }
                ++xi;
                panel1.CreateGraphics().DrawEllipse(penb, xi, yi, 5, 5);
            }
        }



        private void bresenham_Click(object sender, EventArgs e)
        {
            int xi, yi, xf, yf;
            xi = listaCoordenadas[0].getX();
            yi = listaCoordenadas[0].getY();
            xf = listaCoordenadas[1].getX();
            yf = listaCoordenadas[1].getY();

            int dx = Math.Abs(xf - xi);
            int dy = Math.Abs(yf - yi);

            if (dx >= dy)
            {
                bresenhamX(xi, yi, xf, yf, dx, dy);
            }
            else
            {
                bresenhamY(xi, yi, xf, yf, dx, dy);
            }
        }
    }
}
