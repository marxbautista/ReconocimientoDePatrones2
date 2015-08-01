using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReconocimientoDePatrones.Modelo
{
    public class Punto
    {
        private Int32[] x;

        public Int32[] X
        {
            get { return x; }
            set { x = value; }
        }
        private Double[] distancia;

        public Double[] Distancia
        {
            get { return distancia; }
            set { distancia = value; }
        }
       
        private String coordenada;

        public String Coordenada
        {
            get { return coordenada; }
            set { coordenada = value; }
        }

               
        public Punto(Int32 dimension, Int32 cantidad)
        {
            x = new Int32[dimension];
            distancia = new Double[cantidad];
        }
        public void set(Int32 pos, Int32 val)
        {
            this.x[pos] = val;
        }
        public Int32 get(Int32 pos)
        {
            return this.x[pos];
        }
        public void getCoordenada()
        {
            String salida = "("+this.x[0];
            for (int i = 1; i < this.x.Length-1; i++)
                salida += "," + this.x[i];
            if(this.x.Length==1)
                this.coordenada = salida + ")";
            else
            this.coordenada= salida +","+this.x[x.Length-1]+ ")";

        }
        public void ditanciaEuclidiana(List<Punto> lista)
        {
            for(int i=0; i< lista.Count;i++)
            {
                this.distancia[i] = this.calculaEuclidiana(lista[i]);
            }
        }
        public Double calculaEuclidiana(Punto A)
        {
            Double res = 0;
            for (int i = 0; i < x.Length; i++)
            {
                res += Math.Pow(A.X[i] - this.X[i], 2);
            }
            return Math.Sqrt(res);
        }
    }
}
