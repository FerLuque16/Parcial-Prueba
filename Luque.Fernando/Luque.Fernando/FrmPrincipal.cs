using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Luque.Fernando
{
    public partial class FrmPrincipal : Form
    {
        public List<Alumno> listaAlumnos;
        public FrmPrincipal()
        {
            InitializeComponent();
            listaAlumnos = new List<Alumno>();
        }

        private void altaDeAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDatos altaDatos = new FrmDatos();
            FrmAltaAlumno altaAlumno = new FrmAltaAlumno();
            
            

            DialogResult resultado;

            resultado = altaAlumno.ShowDialog();

            if (resultado == DialogResult.OK)
            {

                MessageBox.Show("Se agregó al alumno correctamente");
                listaAlumnos.Add(altaAlumno.Alumno);
            }
            else
            {
                MessageBox.Show("No se agrego al alumno");
            }


        }


        public static void mensajeError()
        {
            MessageBox.Show("Datos invalidos. Revisar.", "ERROR", MessageBoxButtons.OK);
        }

        private void altaDeDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonal altaDocente = new FrmPersonal();         
            altaDocente.setDropDown = System.Windows.Forms.ComboBoxStyle.DropDown;
            altaDocente.SetDocente = "Docente";
            altaDocente.Habilitar = false;
            

            DialogResult resultado;

            resultado = altaDocente.ShowDialog();

            if (resultado == DialogResult.OK)
            {

                MessageBox.Show("Se agregó al docente");
                //listaAlumnos.Add(altaDocente.Docente);
            }
            else
            {
                MessageBox.Show("No se agrego al docente");
            }
            /* FrmPersonal altaDocente = new FrmPersonal();
             
             altaDocente.ShowDialog();*/

            /* foreach (Alumno alumno in listaAlumnos)
             {
                 MessageBox.Show(alumno.ToString());
             }
             */
        }

        private void altaNoDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonal altaNoDocente = new FrmPersonal();
            DialogResult resultado;

            resultado=altaNoDocente.ShowDialog();


            if (resultado == DialogResult.OK)
            {

                MessageBox.Show("Se agregó al empleado");
                //listaAlumnos.Add(altaDocente.Docente);
            }
            else
            {
                MessageBox.Show("No se agrego al empleado");
            }


        }
    }
}
