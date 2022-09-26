using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutoria1
{
    public partial class Form1 : Form
    {
       // string[] arrayEstudiantes = new string[5];
       //ArrayList ListaNombres = new ArrayList();
        string nombre = "";
        //poner tipo de dato
        // En la lista compras no se sobrescriben los datos ingresados solo se acumulan, pero asdasd va primero
        List<string> compras= new List<string>() { "asdasd", "asdash"};
        List<int> numeros = new List<int>() { 123, 456, 786, 987 };
        public Form1()
        {
            InitializeComponent();
            compras.Add("atun");
            compras.Add("Pan caja");
            compras.Add("salsa");
            //Formas de recorrer una lista
            //1-Recorrer lista con un foreach
            //foreach (var item in compras)
            //{
            //    lblista.Text += item + "\n";
            //}
            //2-Recorrer lista con list.ForEach
            compras.ForEach(i => lblista.Text += i + "\n");

            /* Lo de la clase pasada
             ListaNombres.Add("Sancho Panza");
            ListaNombres.Add(true);
            ListaNombres.Add(99);
            {

                renderList();

            }*/
        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //string nombre = textNombre.Text;
            //ListaNombres.Add(nombre);
            ////Console.Write(ListaNombres)
            //renderList();

        }
        public void renderList()    
        {
            //lblista.Text = "";
            //for (int i = 0; i < ListaNombres.Count; i++)
            //{
            //    lblista.Text += i + "-" + ListaNombres[i].ToString() + "\n";


            //}
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //string indice = textIndice.Text;
            //int posision = Int32.Parse(indice);
            //ListaNombres[posision] = textNombre.Text;
            //renderList();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //string indice = textIndice.Text;
            //int posicion=Int32.Parse(indice);
            //ListaNombres.RemoveAt(posicion);
            //renderList();
        }

        private void lblista_Click(object sender, EventArgs e)
        {

        }
    }

       
}
