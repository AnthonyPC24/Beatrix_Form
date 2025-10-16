using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beatrix_Formulario
{
    public partial class FormTareasTho1 : Form
    {
        public FormTareasTho1()
        {
            InitializeComponent();
        }

        private void comboBoxEstadosTarea_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxEstadosTarea.Text = "Estados";

            if (comboBoxEstadosTarea.Text == "Estados")
            {
                MessageBox.Show("Seleccione un estado");
                return;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxUsuarios.Text = "Usuarios";

            if (comboBoxUsuarios.Text == "Usuarios")
            {
                MessageBox.Show("Seleccione un usuario");
                return;
            }
        }

        private void comboBoxProyectos_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxProyectos.Text = "Proyectos";

        }

        private void comboBoxTareas_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTareas.Text = "Tareas";
 
        }
    }
}
