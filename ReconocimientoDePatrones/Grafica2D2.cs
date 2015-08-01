using ReconocimientoDePatrones.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReconocimientoDePatrones
{
    public partial class Grafica2D2 : Form
    {
        private Graphics g;

        private Int32 unox;
        private Int32 unoy;
        private Int32 ancho;
        private Int32 alto;
        private Int32 inicioX;
        private Int32 inicioY;
        private Int32 x0;
        private Int32 y0;

         private List<Punto> lista;
        private List<Clase> listaDeClases;
        private Int32 k;
        private Int32 dimensiones;
        public Grafica2D2(List<Punto> lista,  List<Clase> listaDeClases, Int32 K, Int32 dim)
        {
            InitializeComponent();
            this.lista = lista;
            this.listaDeClases = listaDeClases;
            this.k = K;
            this.dimensiones = dim;
            this.llenaCombos();
        }
        private void llenaCombos()
        {
            int[] ejes1 = new int[this.dimensiones];
            int[] ejes2 = new int[this.dimensiones];
            for (int i = 1; i <= this.dimensiones; i++)
            {
                ejes1[i - 1] = i;
                ejes2[i - 1] = i;
            }
            cmbEje1.DataSource = ejes1;
            cmbEje2.DataSource = ejes2;
          
            
        }
       
        public void dibuja()
        {
            Bitmap b = new Bitmap(pic.Width, pic.Height);
            pic.Image = (Image)b;
            this.g = Graphics.FromImage(b);
            ancho = pic.Width-20;
            alto = pic.Height-20;
            inicioX = 15;
            inicioY = 15;
            this.unox = (this.ancho - inicioX) / 100;
            this.unoy = (this.alto - inicioY) / 100;
           
            

            for (int i = 0; i < 10; i++)
            {

                for (int j = 0; j < 10; j++)
                {
                   if(i==0)
                    this.dibujaTexto(Color.Blue, ""+(100-j*10), unox*10*i,unoy*10*j+15);
                   if (j == 9)
                       this.dibujaTexto(Color.Blue, "" + ((i + 1) * 10), unox * 10 * i+10*unox, unoy * 10 * j+10*unoy+15);
                    g.DrawRectangle(Pens.Black, inicioX + unox*10 * i, inicioY + unoy*10*j , unox* 10, unoy* 10);
                }
                
            }
            g.DrawRectangle(Pens.Blue, inicioX, inicioY, unox * 100, unoy * 100);

        }
        public void dibujaTexto( Color color, String texto, Int32 x, Int32 y) {
            
            Font drawFont = new Font("Verdana", 8);
            SolidBrush drawBrush = new SolidBrush(color);
            g.DrawString(texto, drawFont, drawBrush, x, y);
            drawFont.Dispose();
            drawBrush.Dispose();
           
        }
       


        private void graficaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.dibuja();
            this.pintaPuntos();
            this.pintaClases();
        }
        public void pintaPuntos()
        {
            Int32 x;
            Int32 y;
            foreach (Punto leido in lista)
            {
                x = leido.get((int)(cmbEje1.SelectedValue)-1);
                y = leido.get((int)(cmbEje2.SelectedValue)-1);
                this.dibujaPunto(x, y);

            }
        }
         public void pintaClases()
        {
            Int32 x;
            Int32 y;
            foreach(Clase leida in listaDeClases){
                Punto leido=leida.PuntoFocal;
                x = leido.get((int)(cmbEje1.SelectedValue) - 1);
                y = leido.get((int)(cmbEje2.SelectedValue) - 1);
                this.dibujaClase(x, y);

            }
        }

         public void dibujaClase(Int32 x, Int32 y)
         {
             Int32 nuevoX = x * unox + inicioX;
             Int32 nuevoY = unoy * 100 - y * unoy + inicioY;
             g.DrawEllipse(Pens.Indigo, nuevoX - unox*k/2, nuevoY - unoy*k/2, unox * k, unoy * k);
            

         }
         public void dibujaPunto(Int32 x, Int32 y)
         {
             Int32 nuevoX = x * unox + inicioX;
             Int32 nuevoY = unoy * 100 - y * unoy + inicioY;
             this.dibujaTexto(Color.Red, "(" + x + "," + y + ")", nuevoX, nuevoY);
             g.FillEllipse(new SolidBrush(Color.Blue), nuevoX - unox, nuevoY - unoy, unox * 2, unoy * 2);

         }
    }
}
