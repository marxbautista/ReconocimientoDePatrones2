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
    public partial class frmNube : Form
    {
        private Nube nube;

        public Nube Nube
        {
            get { return nube; }
            //set { nube = value; }
        }
        private Int32 dimension;
        private Int32 cantidad;

        
        public frmNube(Int32 dim, Int32 canti)
        {
            InitializeComponent();
            this.dimension = dim;
            this.cantidad = canti;
            this.llenaLista();
        }
        private void llenaLista()
        {
           nube=new Nube(this.dimension);
           datos.ColumnCount = cantidad+1;
           datos.RowCount = cantidad;
           datos.Columns[0].Name = "Distancia";
           datos.Columns[0].Frozen = true;
           nube.autogeneracion(cantidad);
           //datos.DataSource = nube.Lista;
           this.imprimeDitancias();
        }
        private void imprimeDitancias()
        {
            
            for (int i = 0; i < cantidad; i++)               
            {
                 Punto leido=this.nube.Lista[i];
                 datos.Columns[i+1].Name = leido.Coordenada;
                 this.datos.Rows[i].Cells[0].Value = leido.Coordenada;
                
                 for (int j = 0; j < cantidad; j++)
                     this.datos.Rows[i].Cells[j + 1].Value = Math.Round(leido.Distancia[j],3);
            }

        }

    }
}
