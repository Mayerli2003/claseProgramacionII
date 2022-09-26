using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante
{
    struct Fecha
    {
        public int dia;
        public int mes;
        public int year;

    }
    struct Persona
    {
        public string nombre;
        public string apellido;
        public string genero;
        public string edad;
        public Fecha FechaDeVisita;

    }

    public partial class Form1 : Form
    {
        //Declaracion  del arreglo tipo estructura 1

        Persona[] Per = new Persona[100];

        //Declaracion  del arreglo tipo estructura 2

        Fecha[] fec = new Fecha[100];

        //variables de uso global
        int indice = 0, iModificar, indice1 = 0;
        public Form1()
        {  
            InitializeComponent();
        }

        //Metodo para limpiar  los campos de texto
        void LimpiarCampos()
        {
            textNombre.Text = "";
            textApellido.Text = "";
            comboGenero.Text = "";
            textEdad.Text = "";
            comboDia.Text = "";
            comboMes.Text = "";
            comboYear.Text = "";

            
        }

        

        void Registrar()
        {
            try
            {
                if (textNombre.Text != "" && textApellido.Text != "" && comboGenero.Text != "" && textEdad.Text != "")
                {
                    Per[indice].nombre = textNombre.Text;
                    Per[indice].apellido = textApellido.Text;
                    Per[indice].genero = Convert.ToString(comboGenero.SelectedItem);
                    Per[indice].edad = textEdad.Text;
                    Per[indice].FechaDeVisita.dia= Convert.ToInt32(comboDia.Text);
                    Per[indice].FechaDeVisita.mes = Convert.ToInt32(comboMes.Text);
                    Per[indice].FechaDeVisita.year = Convert.ToInt32(comboYear.Text);

                }
                else
                {

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al cargar el registro del libro", e.Message);

            }
           
        }



        //Metodo para mostrar los registros
        void MostrarRegistros()
        {
            try
            {
                string PersonaLista = "";
                for (int i = 0; i < indice; i++)
                {
                    PersonaLista = PersonaLista + i + " - " + Per[i].nombre + " " + Per[i].apellido + " " + Per[i].genero + " " + Per[i].edad +"" +Per[i].FechaDeVisita.dia+"" + Per[i].FechaDeVisita.mes+""+"\n";

                }
                rtbRegistros.Text = PersonaLista;
                
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un error al cargar los libros ", e.Message);

            }
        }
        void BuscarRegistro()
        {
            try
            {
                if (textBuscar.Text != "")
                {
                    for (int i = 0; i < indice; i++)
                    {
                        if (Per[i].nombre == textNombre.Text)
                        {
                            textNombre.Text = Per[i].nombre;
                            textApellido.Text = Per[i].apellido;
                            comboGenero.SelectedText = Per[i].genero;
                            textEdad.Text = Per[i].edad;
                            comboDia.SelectedText = Convert.ToString(Per[i].FechaDeVisita.dia);
                            comboMes.SelectedText = Convert.ToString(Per[i].FechaDeVisita.mes);
                            comboYear.SelectedText = Convert.ToString(Per[i].FechaDeVisita.year);
                            iModificar = i;
                        }

                    }

                }
                else
                {
                    MessageBox.Show("Campo de busqueda esta vacio ");
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un error en la busqueda de registros ", e.Message);
            }


        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            Registrar();
            MostrarRegistros();
            LimpiarCampos();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
            btnModificar.Enabled = false;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            btnModificar.Enabled = true;
            btnGuardar.Enabled = false;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarRegistro();

        }








    }
}
