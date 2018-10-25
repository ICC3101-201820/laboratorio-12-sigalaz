using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class ListaComida
    {
        List<Comida> Comidas;
        
        public ListaComida()
        {
            Comidas = new List<Comida>();
        }

        public void Agregar(Comida comida)
        {
            Comidas.Add(comida);
        }

        public void Eliminar(Comida comida)
        {
            Comidas.Remove(comida);
        }

        
    }




}
