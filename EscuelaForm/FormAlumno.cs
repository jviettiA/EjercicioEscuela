using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Escuela;

namespace EscuelaForm
{
    public partial class FormAlumno : Form
    {
        public FormAlumno()
        {
            InitializeComponent();
        }

        List<Alumno> alumnos = new List<Alumno>();

        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            AgregarAlumno(txtbNombre.Text, txtbApellido.Text, txtbDNI.Text, dateTimePicker1.Value, txtbMatric.Text);
            ActualizarVistas();
        }

        private void AgregarAlumno(string nombre, string apellido, string dni, DateTime fechanac, string matricula) {

            foreach (Alumno aux in alumnos) {
                if (aux.DNI == dni)
                {
                    MessageBox.Show("DNI ya ingresado. \nIngrese nuevamente.");
                    return;
                }
                else if (aux.Matricula == matricula) {

                    MessageBox.Show("Matricula ya ingresada. \nIngrese nuevamente.");
                    return;
                }
            }
            Alumno alum = new Alumno(nombre,apellido,dni,fechanac,matricula);
            alumnos.Add(alum);
        }

        private void ActualizarVistas()
        {
            gridAlumno.DataSource = null;
            gridAlumno.DataSource = alumnos;
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(BuscarAlumnos(txtbBuscarDNI.Text));
        }

        private string BuscarAlumnos(string dni) {
            foreach (Alumno alum in alumnos){
                if (alum.DNI == dni) {
                    return alum.Nombre + ", " + alum.Apellido;
                }
            }
            return "No se encontro";
        }

        private string BuscarAlumnosMatric(string matricula)
        {
            foreach (Alumno alum in alumnos)
            {
                if (alum.Matricula == matricula)
                {
                    return alum.Nombre + ", " + alum.Apellido;
                }
            }
            return "No se encontro";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(BuscarAlumnosMatric(textBox1.Text));
        }
    }
}
