using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Comida
    {
        string Nombre;
        int Carbohidratos;
        int Proteinas;
        int Grasas;

        public Comida(string nombre, int Carbohidratos, int Proteinas, int Grasas)
        {
            this.Nombre = nombre;
            this.Carbohidratos = Carbohidratos;
            this.Proteinas = Proteinas;
            this.Grasas = Grasas;
        }

        public int Calorias()
        {
            
            return 4*Carbohidratos + 4*Proteinas + 9* Grasas ;
        }

    }

}

    

