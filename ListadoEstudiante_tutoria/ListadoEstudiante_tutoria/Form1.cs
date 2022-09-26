using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListadoEstudiante_tutoria
{
    public partial class Form1 : Form
    {
        List<Estudiantes> listar= new List<Estudiantes> ();
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            if (validarNombre()== false)
            {
                return;

            }
            if (validarCarrera()==false)
            {
                return;
            }
            if (validarAño() == false)
            {
                return ;
            }
            //objeto para la clse lista
            Estudiantes dato = new Estudiantes();
            dato.Nombre = textNombre.Text;
            dato.Carrera = comboCarrera.SelectedItem.ToString();
            dato.año = int.Parse(textYear.Text);
            listar.Add(dato);
            datos.DataSource = null;
            datos.DataSource = listar;
        }



        //OBJETO para la clase Estudiantes
        private bool validarNombre()
        {
            if (string.IsNullOrEmpty(textNombre.Text))
            {
                error.SetError(textNombre, "El campo no puede ser vacio");
                return false;

            }
            else
            {
                error.SetError(textNombre, "");
                return true;
            }
        }
        private bool validarCarrera()
        {
            if (string.IsNullOrEmpty(comboCarrera.Text))
            {
                error.SetError(comboCarrera, "El campo no puede ser vacio");
                return false;

            }
            else
            {
                error.SetError(comboCarrera, "");
                return true;
            }
            


        }
        private bool validarAño()
        {
            int año;
            if (int.TryParse(textYear.Text, out año)|| textYear.Text=="")
            {
                error.SetError(textYear, "El campo no puede ser vacio");
                textYear.Clear();
                textYear.Focus();
                return false;

            }
            else
            {
                error.SetError(comboCarrera, "");
                return true;
            }
        }

        private void LimpiarCampos()
        {
            textNombre.Clear();
            
        }
    }

}
