using ReconocimientoDePatrones.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReconocimientoDePatrones.Control
{
    public class Clasificador
    {
        private List<Punto> listaGeneral;
        private List<Punto> listaClases;
        private Int32 k;
        private List<Punto> clase;
        List<List<Punto>> listaDeClases;
        public Clasificador(int K, List<Punto> lista)
        {
            this.listaGeneral = lista;
            this.listaClases = lista;
            this.k = K;
            listaDeClases = new List<List<Punto>>();            
        }
        public Clasificador(int K, List<Punto> lista,List<Punto> listaClases)
        {
            this.listaGeneral = lista;
            this.listaClases = listaClases;
            this.k = K;
            listaDeClases = new List<List<Punto>>();
        }
        public void clasifica()
        {
            foreach (Punto leido in listaClases)
            {
               clase = new List<Punto>();
                foreach(Punto comparado in listaGeneral)                
                    if (leido.calculaEuclidiana(comparado) < k/2)                    
                        clase.Add(comparado);                   
                listaDeClases.Add(clase);
            }
        }
        public List<Clase> creaClases()
        {
            List<Clase> clases = new List<Clase>();
            for (int i = 0; i < listaDeClases.Count; i++)
            {
                Clase nueva = new Clase();
                nueva.Nombre = "Clase" + (i + 1);
                nueva.PuntoFocal = this.listaClases[i];
                nueva.Lista = this.listaDeClases[i];
                clases.Add(nueva);
            }
            return clases;
        }
    }
}
