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
    public partial class FormProf : Form
    {
        public FormProf()
        {
            InitializeComponent();
        }

        List<Profesor> profesores;

        private void btnAgregarProf_Click(object sender, EventArgs e)
        {
            profesores = new List<Profesor>();
            CargaProfesores("Mario","Perez","Historia");
            CargaProfesores("Lucia", "Garcia", "Matematica");
            CargaProfesores("Mirta", "Lopez", "Historia");


            ActualizarVistas();
        }

        private void CargaProfesores(string nombre, string apellido, string especialidad) {


            Profesor profe = new Profesor(nombre, apellido, especialidad);
            profesores.Add(profe);
            
        }

        private void ActualizarVistas() {
            gridProfesor.DataSource = profesores;
            foreach (Profesor prof in profesores)
            {
                if (prof.Especialidad == "Historia") {
                    lstbProfesor.Items.Add(prof.Nombre+","+prof.Apellido);
                }
            }
        }
    }
}
