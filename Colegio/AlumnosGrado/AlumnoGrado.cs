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
using DevExpress.XtraEditors;

namespace Colegio.AlumnosGrado
{
    public partial class AlumnoGrado : Form
    {
        public bool ActionComplete = false;
        bool Validador = true;
        DataTable TableConfiguracion = new DataTable();
        DataTable TableGrados = new DataTable();
        DataTable TableAlumnos = new DataTable();

        internal void CargarGrados()
        {
            TableGrados = Data.StoredProcedure("procGradoList", 4, "null", "null", "null", "null", "null").Tables[0];

            GradoLookUpEdit.Properties.DataSource = TableGrados;
            GradoLookUpEdit.Properties.ForceInitialize();
        }

        internal void CargarAlumnos()
        {
            TableAlumnos = Data.StoredProcedure("procAlumnoList", 3, "null", "null", "null", "null", "null").Tables[0];

            AlumnoLookUpEdit.Properties.DataSource = TableAlumnos;
            AlumnoLookUpEdit.Properties.ForceInitialize();
        }

        internal DataTable CargarConfiguracion(int Id)
        {
            TableConfiguracion = Data.StoredProcedure("procAlumnoGradoList", 2, Id, "null", "null", "null", "null").Tables[0];
            return TableConfiguracion;
        }

        internal void AsignarInformacion(DataTable Conf)
        {
            if (Conf.Rows.Count > 0)
            {
                IdAlumnoGradoTextEdit.Text = Conf.Rows[0]["IdAlumnoGrado"].ToString();
                SeccionTextEdit.Text = Conf.Rows[0]["Seccion"].ToString();
                GradoLookUpEdit.EditValue = Conf.Rows[0]["IdGrado"];
                AlumnoLookUpEdit.EditValue = Conf.Rows[0]["IdAlumno"];
            }
        }

        private void Guardar(bool Cerrar)
        {
            //if (dxValidationProvider1.Validate())
            //{
                Business.ShowWait();
                try
                {
                    Data.StoredProcedure("procAlumnoGrado",
                                        IdAlumnoGradoTextEdit.Text,
                                        AlumnoLookUpEdit.EditValue,
                                        GradoLookUpEdit.EditValue,
                                        SeccionTextEdit.Text,
                                        false);
                    if (Data.SPok)
                    {
                        Business.ShowNotification("Datos guardados.");
                        ActionComplete = true;
                        if (Cerrar)
                            this.Close();
                        else
                        {
                            IdAlumnoGradoTextEdit.Text = "0";
                            AlumnoLookUpEdit.EditValue = null;
                            SeccionTextEdit.Text = "";
                        }
                    }
                    else
                        Business.ShowNotification("Error", "Error al guardar los datos.", "");
                }
                catch (Exception ex)
                {
                    Business.ShowNotification("Error al insertar los datos. Error: " + ex.Message.ToString());
                }
                Business.CloseWait(500);
            //}
        }

        private void Validar()
        {
            Validador = true;
            if (GradoLookUpEdit.EditValue == null)
                Validador = false;
            if (AlumnoLookUpEdit.EditValue == null)
                Validador = false;
            if (SeccionTextEdit.Text == null)
                Validador = false;
        }

        public AlumnoGrado(int Id)
        {
            InitializeComponent();
            IdAlumnoGradoTextEdit.Text = Id.ToString();
            CargarGrados();
            CargarAlumnos();
            if (Id != 0)
                AsignarInformacion(CargarConfiguracion(Id));
        }

        private void GradoLookUpEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 0)
            {
                Grado.Grado tmp = new Grado.Grado(0);
                tmp.ShowDialog();
                if (tmp.ActionComplete)
                {
                    CargarGrados();
                    GradoLookUpEdit.EditValue = null;
                }
                tmp.Dispose();
            }
        }

        private void AlumnoLookUpEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 0)
            {
                Alumnos.Alumno tmp = new Alumnos.Alumno(0);
                tmp.ShowDialog();
                if (tmp.ActionComplete)
                {
                    CargarAlumnos();
                    AlumnoLookUpEdit.EditValue = null;
                }
                tmp.Dispose();
            }
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Validar();
            if (Validador)
                Guardar(false);
            else
                XtraMessageBox.Show("Ingrese todos los campos requeridos.");
        }

        private void GuardarCerrarButton_Click(object sender, EventArgs e)
        {
            Validar();
            if (Validador)
                Guardar(true);
            else
                XtraMessageBox.Show("Ingrese todos los campos requeridos.");
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
