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

namespace Colegio.Alumnos
{
    public partial class Alumno : Form
    {
        public bool ActionComplete = false;
        DataTable TableConfiguracion = new DataTable();
        internal DataTable CargarConfiguracion(int Id)
        {
            TableConfiguracion = Data.StoredProcedure("procAlumnoList", 2, Id, "null", "null", "null", "null").Tables[0];
            return TableConfiguracion;
        }

        internal void AsignarInformacion(DataTable Conf)
        {
            if (Conf.Rows.Count > 0)
            {
                IdAlumnoTextEdit.Text = Conf.Rows[0]["IdAlumno"].ToString();
                NombreTextEdit.Text = Conf.Rows[0]["Nombre"].ToString();
                ApellidosTextEdit.Text = Conf.Rows[0]["Apellidos"].ToString();
                FechaNacimientoDateEdit.DateTime = Convert.ToDateTime(Conf.Rows[0]["FechaNacimiento"].ToString());
                GeneroComboBox.Text = Conf.Rows[0]["Genero"].ToString();
                EstadoCheckEdit.Checked = Convert.ToBoolean(Conf.Rows[0]["Estado"]);
            }
        }

        private void Guardar()
        {
            Business.ShowWait();
            try
            {
                Data.StoredProcedure("procAlumno",
                                    IdAlumnoTextEdit.Text,
                                    NombreTextEdit.Text,
                                    ApellidosTextEdit.Text,
                                    GeneroComboBox.Text,
                                    FechaNacimientoDateEdit.DateTime.ToShortDateString(),
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

        public Alumno(int Id)
        {
            InitializeComponent();
            FechaNacimientoDateEdit.DateTime = DateTime.Now.AddYears(-18);
            IdAlumnoTextEdit.Text = Id.ToString();
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

        private void FechaNacimientoDateEdit_Enter(object sender, EventArgs e)
        {
            FechaNacimientoDateEdit.Select(0, 2);
        }
    }
}
