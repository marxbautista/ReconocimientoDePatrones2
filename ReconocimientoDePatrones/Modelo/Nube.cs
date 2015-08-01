using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReconocimientoDePatrones.Modelo
{
    public class Nube
    {
        private List<Punto> lista;

        public List<Punto> Lista
        {
            get { return lista; }
            //set { lista = value; }
        }
        private Int32 dimension;
        public Nube(Int32 dimension)
        {
            this.dimension = dimension;
            lista = new List<Punto>();

        }
        public void autogeneracion(Int32 cantidad)
        {
            Random aleatorio=new Random();
            for (int i = 0; i < cantidad; i++)
            {
                Punto nuevo = new Punto(this.dimension, cantidad);
                for(int j=0; j<this.dimension;j++)
                    nuevo.set(j,aleatorio.Next(100));
                nuevo.getCoordenada();
                lista.Add(nuevo);

            }
            foreach(Punto leido in lista)
            {
                leido.ditanciaEuclidiana(lista);
            }
            
        }
        
       

    }
}
