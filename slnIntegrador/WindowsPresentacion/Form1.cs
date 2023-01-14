using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Entidades.Clinica;
using Negocio;

namespace WindowsPresentacion
{
    public partial class ClinicaApp : Form
    {
        public ClinicaApp()
        {
            InitializeComponent();
        }

        private void Mostrar(object sender, EventArgs e)
        {
            gridMedicos.DataSource = AdmMedico.Listar();
            gridPacientes.DataSource = AdmPaciente.Listar();
            
            foreach (var item in AdmMedico.Listar("Clinico"))
            {
                medicosClinicos.Items.Add(item.Nombre);
            }

            foreach (var item in AdmHabitacion.Listar())
            {
                habitaciones.Items.Add(item.InfoHabitacion());                            
            }
        }
    }
}
