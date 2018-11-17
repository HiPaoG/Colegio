using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Colegio.Class;

namespace Colegio.Profesores
{
    public partial class Profesor : Form
    {
        public bool ActionComplete = false;
        DataTable TableConfiguracion = new DataTable();
        internal DataTable CargarConfiguracion(int Id)
        {
            TableConfiguracion = Data.StoredProcedure("procProfesorList", 2, Id, "null", "null", "null", "null").Tables[0];
            return TableConfiguracion;
        }

        internal void AsignarInformacion(DataTable Conf)
        {
            if (Conf.Rows.Count > 0)
            {
                IdProfesorTextEdit.Text = Conf.Rows[0]["IdProfesor"].ToString();
                NombreTextEdit.Text = Conf.Rows[0]["Nombre"].ToString();
                ApellidosTextEdit.Text = Conf.Rows[0]["Apellidos"].ToString();
                GeneroComboBox.Text = Conf.Rows[0]["Genero"].ToString();
                EstadoCheckEdit.Checked = Convert.ToBoolean(Conf.Rows[0]["Estado"]);
            }
        }

        private void Guardar()
        {
            Business.ShowWait();
            try
            {
                Data.StoredProcedure("procProfesor",
                                    IdProfesorTextEdit.Text,
                                    NombreTextEdit.Text,
                                    ApellidosTextEdit.Text,
                                    GeneroComboBox.Text,
                                    EstadoCheckEdit.Checked,
                                    false);
                if (Data.SPok)
                {
                    Business.ShowNotification("Datos guardados.");
                    ActionComplete = true;
                    this.Close();
                }
                else
                    Business.ShowNotification("Error", "Error al guardar los datos.", "");
            }
            catch (Exception ex)
            {
                Business.ShowNotification("Error al insertar los datos. Error: " + ex.Message.ToString());
            }
            Business.CloseWait(500);
        }

        public Profesor(int Id)
        {
            InitializeComponent();
            IdProfesorTextEdit.Text = Id.ToString();
            if (Id != 0)
                AsignarInformacion(CargarConfiguracion(Id));
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
