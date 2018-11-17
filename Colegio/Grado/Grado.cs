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

namespace Colegio.Grado
{
    public partial class Grado : Form
    {
        public bool ActionComplete = false;
        DataTable TableConfiguracion = new DataTable();
        DataTable TableProfesores = new DataTable();

        internal DataTable CargarProfesores()
        {
            TableProfesores = Data.StoredProcedure("procProfesorList", 3, "null", "null", "null", "null", "null").Tables[0];
            return TableProfesores;
        }

        internal void AsignarLue(DataTable Profesores)
        {
            ProfesorLookUpEdit.Properties.DataSource = Profesores;
            ProfesorLookUpEdit.Properties.ForceInitialize();
        }

        internal DataTable CargarConfiguracion(int Id)
        {
            TableConfiguracion = Data.StoredProcedure("procGradoList", 2, Id, "null", "null", "null", "null").Tables[0];
            return TableConfiguracion;
        }

        internal void AsignarInformacion(DataTable Conf)
        {
            if (Conf.Rows.Count > 0)
            {
                IdGradoTextEdit.Text = Conf.Rows[0]["IdGrado"].ToString();
                NombreTextEdit.Text = Conf.Rows[0]["Nombre"].ToString();
                ProfesorLookUpEdit.EditValue = Conf.Rows[0]["IdProfesor"];
                EstadoCheckEdit.Checked = Convert.ToBoolean(Conf.Rows[0]["Estado"]);
            }
        }

        private void Guardar()
        {
            Business.ShowWait();
            try
            {
                Data.StoredProcedure("procGrado",
                                    IdGradoTextEdit.Text,
                                    NombreTextEdit.Text,
                                    ProfesorLookUpEdit.EditValue,
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
        public Grado(int Id)
        {
            InitializeComponent();
            IdGradoTextEdit.Text = Id.ToString();
            AsignarLue(CargarProfesores());
            if (Id != 0)
                AsignarInformacion(CargarConfiguracion(Id));
        }

        private void ProfesorLookUpEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if(e.Button.Index == 0)
            {
                Profesores.Profesor tmp = new Profesores.Profesor(0);
                tmp.ShowDialog();
                if (tmp.ActionComplete)
                {
                    AsignarLue(CargarProfesores());
                    ProfesorLookUpEdit.EditValue = null;
                }
                tmp.Dispose();
            }
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
