using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReconocimientoDePatrones.Modelo
{
    public class Clase
    {
        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private Punto puntoFocal;

        public Punto PuntoFocal
        {
            get { return puntoFocal; }
            set { puntoFocal = value; }
        }
        private int K;
        private List<Punto> lista;

        public List<Punto> Lista
        {
            get { return lista; }
            set { lista = value; }
        }
        public String imprime()
        {
            String salida = Nombre + "\r\n";
            foreach (Punto leido in lista)
            {
                salida += leido.Coordenada + " ";
            }
            return salida ;

        }
    }
}
