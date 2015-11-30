using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace AgendaPersonal2
{
    public partial class RegistroPersona : Form
    {
        private Personas persona = new Personas();
        public RegistroPersona()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            NombrestextBox.Clear();
            ApellidostextBox.Clear();
            TelefonostextBox.Clear();
        }

        private void Limpiarbutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            persona.PersonaId = int.Parse(PersonaIdtextBox.Text);
            if (persona.Eliminar())
            {
                Limpiar();
                MessageBox.Show("Eliminado Correcto", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (persona.Buscar(int.Parse(PersonaIdtextBox.Text)))
            {
                NombrestextBox.Text = persona.Nombres;
                ApellidostextBox.Text = persona.Apellidos;
                EstadoCivilcomboBox.SelectedIndex = persona.EstadoCivil;
            }

        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            {
                persona.Nombres = NombrestextBox.Text;
                persona.Apellidos = ApellidostextBox.Text;
                persona.EstadoCivil = EstadoCivilcomboBox.SelectedIndex;

                int id;
                int.TryParse(PersonaIdtextBox.Text, out id);

                if (id == 0)
                {
                    if (persona.Insertar())
                    {
                        Limpiar();
                        MessageBox.Show("Guardado Correcto", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    else
                    {
                        MessageBox.Show("A surgido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (persona.Editar())
                    {
                        Limpiar();
                        MessageBox.Show("Modificado Correcto", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    else
                    {
                        MessageBox.Show("A surgido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            DetallesdataGridView.Rows.Add(TelefonostextBox.Text);

        }
    }
}