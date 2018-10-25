using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;


namespace Lab12_SebastianGalaz
{
    class Controlador
    {
        public Form1 form1;
        private ListaComida Comidas;
        private Comida comida;
        


        public Controlador()
        {
            Comidas = new ListaComida();
        }

       public void OnAgregarComida(string nombre, int Carbo, int Grasa, int prote)
        {
            Comida comida = new Comida(nombre, Carbo, prote, Grasa);
            Comidas.Agregar(comida);
            form1.AgregarComida(comida);
        }

        public void OnEliminarComida(string nombre, int Carbo, int Grasa, int prote)
        {
            Comida comida = new Comida(nombre, Carbo, prote, Grasa);
            Comidas.Eliminar(comida);
        }







    }
}
