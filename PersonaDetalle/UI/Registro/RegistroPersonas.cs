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
    public partial class RegistroPersonas : Form
    {
        public List<TelefonoDetalle> Detalle { get; set; }
        public RegistroPersonas()
        {
            InitializeComponent();
            this.Detalle = new List<TelefonoDetalle>();
 
            LlenarComboBox();
         
        }

        private void Limpiar()
        {
            errorProvider.Clear();
            IDNumericUpDowm.Value = 0;
            NombreTextBox.Text = string.Empty;
            DireccionTextBox.Text = string.Empty;
            CedulaMasketTextBox.Text = string.Empty;
            FechaTimePicker.Value = DateTime.Now;
            
            this.Detalle = new List<TelefonoDetalle>();
            CargarGrid();
           
        }
        private void LlenarComboBox()
        {
            TipoComboBox.DataSource = TipoTelefonoBLL.GetList(x => true);
            TipoComboBox.ValueMember = "TipoId";
            TipoComboBox.DisplayMember = "TipoTelefonoR";
        }
        public Persona LlenaClase()
        {
            Persona persona = new Persona();
            persona.PersonaId = Convert.ToInt32(IDNumericUpDowm.Value);
            persona.Nombre = NombreTextBox.Text;
            persona.Direccion = DireccionTextBox.Text;
            persona.Cedula = CedulaMasketTextBox.Text;
            persona.fechaNacimiento = FechaTimePicker.Value;

            persona.telefonos = this.Detalle;
            return persona;
        }
        public void LlenaCampos(Persona persona)
        {
            IDNumericUpDowm.Value = persona.PersonaId;
            NombreTextBox.Text = persona.Nombre;
            DireccionTextBox.Text = persona.Direccion;
            CedulaMasketTextBox.Text = persona.Cedula;
            FechaTimePicker.Value = persona.fechaNacimiento;

            this.Detalle = persona.telefonos;
            CargarGrid();
        }


        private void CargarGrid()
        {
            detalleDataGridView.DataSource = null;
            detalleDataGridView.DataSource = this.Detalle;
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private bool ExisteEnLaBaseDeDatos()
        {
            Persona persona = PersonaBLL.Buscar((int)IDNumericUpDowm.Value);
            return (persona != null);
        }
        private bool Validar()
        {
            bool paso = true;
            errorProvider.Clear();

            if (string.IsNullOrWhiteSpace(NombreTextBox.Text))
            {
                errorProvider.SetError(NombreTextBox, "El campo Nombre no puede estar Vacio.");
                NombreTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(DireccionTextBox.Text))
            {
                errorProvider.SetError(DireccionTextBox, "El campo Direccion no puede estar Vacio.");
                DireccionTextBox.Focus();
                paso = false;
            }
            if(string.IsNullOrWhiteSpace(CedulaMasketTextBox.Text))
            {
                errorProvider.SetError(CedulaMasketTextBox, "El campo Cedula no puede estar Vacio.");
                CedulaMasketTextBox.Focus();
                paso = false;
            }
            if(this.Detalle.Count == 0)
            {
                errorProvider.SetError(TelefonoMasketTextBox, "Debe Agregar uno o mas telefonos");
                TelefonoMasketTextBox.Focus();
                paso = false;
            }
            return paso;
        }


        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id;
            Persona persona = new Persona();
            int.TryParse(IDNumericUpDowm.Text, out id);
            if (!ExisteEnLaBaseDeDatos())
                return;
            persona = PersonaBLL.Buscar(id);
            if (persona != null)
            {
                errorProvider.Clear();
                LlenaCampos(persona);
                MessageBox.Show("Persona Encontrada", "Exito!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Pesona No Encontrada", "Fallo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public bool ValidarRemover()
        {
            bool paso = true;
            if(detalleDataGridView.SelectedRows == null)
            {
                paso = false;
            }
            return paso;
        }
        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Persona persona;
            bool paso = false;
            if (!Validar())
                return;
            persona = LlenaClase();

            if (IDNumericUpDowm.Value == 0)
                paso = PersonaBLL.Guardar(persona);
            else
            {
                if(!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar una persona que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = PersonaBLL.Modificar(persona);
            }
            if (paso)
            {
                MessageBox.Show("Guardado", "Exito!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
                MessageBox.Show("No se pudo Guardar!!", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            int id;
            int.TryParse(IDNumericUpDowm.Text, out id);

            if(!ExisteEnLaBaseDeDatos())
            {
                errorProvider.SetError(IDNumericUpDowm, "No se puede eliminar una Persona Inexistente");
                return;
            }
            if(PersonaBLL.Eliminar(id))
            {
                Limpiar();
                MessageBox.Show("Eliminado!!!", "Exito!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public bool ValidarAgregarTelefono()
        {
            bool paso = true;
            if (String.IsNullOrWhiteSpace(TelefonoMasketTextBox.Text.Replace("-","")))
            {
                errorProvider.SetError(TelefonoMasketTextBox, "Debe Insertar un numero de telefono");
                TelefonoMasketTextBox.Focus();
                paso = false;
            }
            return paso;
        }
        private void AgregarTelefonoButton_Click(object sender, EventArgs e)
        {
            if (detalleDataGridView.DataSource != null)
                this.Detalle = (List<TelefonoDetalle>)detalleDataGridView.DataSource;
            //todo: validar campos del detalle
            if (!ValidarAgregarTelefono())
                return;
            //Agregar un nuevo detalle con los datos introducidos.
            this.Detalle.Add(
                new TelefonoDetalle(
                    Id: 0,
                    PersonaId: (int)IDNumericUpDowm.Value,
                    telefono: TelefonoMasketTextBox.Text,
                    tipoTelefono: Convert.ToString(TipoComboBox.Text)
                    )
               );
            errorProvider.Clear();
            CargarGrid();
        }
        private void RemoverFilaButton_Click(object sender, EventArgs e)
        {
            if (!ValidarRemover())
                return;
            if (detalleDataGridView.Rows.Count > 0 && detalleDataGridView.CurrentRow != null)
            {
                this.Detalle.RemoveAt(detalleDataGridView.CurrentRow.Index);
                CargarGrid();
            }
        }

        private void AgregarTipoButton_Click(object sender, EventArgs e)
        {
            RegistroTipoTelefono registroTipoTelefono = new RegistroTipoTelefono();
            registroTipoTelefono.ShowDialog();
        }
    }
}
