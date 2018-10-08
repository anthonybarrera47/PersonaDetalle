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

namespace PersonaDetalle.UI.Registro
{
    public partial class RegistroTipoTelefono : Form
    {
        public RegistroTipoTelefono()
        {
            InitializeComponent();
        }
        public void Limpiar()
        {
            idTelefonoNumericUpDown.Value = 0;
            tipoTelefonoTextBox.Text = string.Empty;
        }
        private void GuardarButton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            TipoTelefono telefono = new TipoTelefono()
            {
                TipoId = 0,
                TipoTelefonoR = tipoTelefonoTextBox.Text
            };
            if (idTelefonoNumericUpDown.Value == 0)
                paso = TipoTelefonoBLL.Guardar(telefono);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede Modificar un Tipo no existente", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = TipoTelefonoBLL.Modificar(telefono);
            }
            if (paso)
            {
                MessageBox.Show("Tipo Guardado!", "Exito!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
                MessageBox.Show("Tipo No guardado!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void Buscar_Click(object sender, EventArgs e)
        {
            var tipo = TipoTelefonoBLL.Buscar((int)idTelefonoNumericUpDown.Value);
            if (tipo != null)
            {
                idTelefonoNumericUpDown.Value = tipo.TipoId;
                tipoTelefonoTextBox.Text = tipo.TipoTelefonoR;
                MessageBox.Show("Encontrado", "Exito!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No Encontrado", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(idTelefonoNumericUpDown.Text, out id);
            if (!ExisteEnLaBaseDeDatos())
                return;
            if (TipoTelefonoBLL.Eliminar(id))
            {
                MessageBox.Show("Tipo de Telefono Eliminado!!", "Exito!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
                
            else
                MessageBox.Show("Tipo de Telefono No Eliminado!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        
        }
        private bool ExisteEnLaBaseDeDatos()
        {
            TipoTelefono telefono = TipoTelefonoBLL.Buscar((int)idTelefonoNumericUpDown.Value);
            return (telefono != null);
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
