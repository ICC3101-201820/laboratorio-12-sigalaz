using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;

namespace Lab12_SebastianGalaz
{

    public delegate void AgregarComidaDelegate(string nombre, int carbo, int prote, int grasa);
    public delegate void EliminarComidaDelegate(string nombre, int carbo, int prote, int grasa);


    public partial class Form1 : Form



    {
        public event AgregarComidaDelegate OnAgregarComida;
        public event EliminarComidaDelegate OnEliminarComida;
        public Form1()
        {
            InitializeComponent();
        }

        private void Carbohidratos_label_Click(object sender, EventArgs e)
        {

        }

        private void Agregar_button1_Click(object sender, EventArgs e)
        {
            if(OnAgregarComida != null)
            {

                OnAgregarComida.Invoke(Nombre_textBox1.Text, Convert.ToInt32(Carbohidratos_textBox3.Text), Convert.ToInt32(Proteinas_textBox1.Text), Convert.ToInt32(Grasas_textBox2.Text));

            }

        }


        public void AgregarComida(Comida comida)
        {
            Listado_Comidas.Items.Add(comida);
                       
        }

    }
}
