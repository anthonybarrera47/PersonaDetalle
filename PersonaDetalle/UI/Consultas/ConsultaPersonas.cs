using PersonaDetalle.BLL;
using PersonaDetalle.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonaDetalle.UI.Consultas
{
    public partial class ConsultaPersonas : Form
    {
        public ConsultaPersonas()
        {
            InitializeComponent();
            FiltroComboBox.SelectedIndex = 0;
        }

        private void ConsultaButton_Click(object sender, EventArgs e)
        {
            var listado = new List<Persona>();

            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {

                    case 0://Todo
                        listado = PersonaBLL.GetList(p => true);
                        break;
                    case 1://ID
                        int id = Convert.ToInt32(CriterioTextBox.Text);
                        listado = PersonaBLL.GetList(p => p.PersonaId == id);
                        break;

                    case 2://Nombre
                        listado = PersonaBLL.GetList(p => p.Nombre.Contains(CriterioTextBox.Text));
                        break;
                    case 3://Cedula
                        listado = PersonaBLL.GetList(p => p.Cedula.Contains(CriterioTextBox.Text));
                        break;
                    case 4://Direccion
                        listado = PersonaBLL.GetList(p => p.Direccion.Contains(CriterioTextBox.Text));
                        break;
                }

                listado = listado.Where(c => c.fechaNacimiento.Date >= DesdedateTimePicker.Value.Date && c.fechaNacimiento.Date <= HastadateTimePicker.Value.Date).ToList();
            }
            else
            {
                listado = PersonaBLL.GetList(p => true);
            }


            ConsultaPersonasDataGridView.DataSource = null;
            ConsultaPersonasDataGridView.DataSource = listado;
        }
    }
}
