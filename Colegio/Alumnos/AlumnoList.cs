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

namespace Colegio.Alumnos
{
    public partial class AlumnoList : Form
    {
        DataTable TableAlumno = new DataTable();

        private void Eliminar(int Id)
        {
            Business.ShowWait();
            try
            {
                Data.StoredProcedure("procAlumno",
                                    Id,
                                    "",
                                    "",
                                    "",
                                    DateTime.Now.Date,
                                    true,
                                    true);
                if (Data.SPok)
                    Business.ShowNotification("Registro eliminado.");
                else
                    Business.ShowNotification("Error", "Error al guardar los datos.", "");
            }
            catch (Exception ex)
            {
                Business.ShowNotification("Error al insertar los datos. Error: " + ex.Message.ToString());
            }
            Business.CloseWait(500);
        }

        internal DataTable CargarAlumnos()
        {
            TableAlumno.Clear();
            TableAlumno = Data.StoredProcedure("procAlumnoList", 1, "null", "null", "null", "null", "null").Tables[0];
            return TableAlumno;
        }

        internal void AsignarInformacion(DataTable Conf)
        {
            if (Conf.Rows.Count > 0)
            {
                AlumnoGridControl.DataSource = Conf;
            }
        }
        public AlumnoList()
        {
            InitializeComponent();
            AsignarInformacion(CargarAlumnos());
        }

        private void AlumnoGridView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                popMenu.ShowPopup(MousePosition);
        }

        private void NuevoButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Alumno tmp = new Alumno(0);
            tmp.ShowDialog();
            if (tmp.ActionComplete)
                AsignarInformacion(CargarAlumnos());
            tmp.Dispose();
        }

        private void EditarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //int IdTemp = Convert.ToInt32(AlumnoGridView.GetFocusedRowCellValue(AlumnoGridView.Columns["IdAlumno"]));
            if (AlumnoGridView.RowCount > 0)
            {
                //AsignarInformacion(CargarAlumnos());
                //if (IdTemp != Convert.ToInt32(AlumnoGridView.GetFocusedRowCellValue(AlumnoGridView.Columns["IdAlumno"])))
                //    XtraMessageBox.Show("Este registro ya fue eliminado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //else
                //{
                Alumno tmp = new Alumno(Convert.ToInt32(AlumnoGridView.GetFocusedRowCellValue(AlumnoGridView.Columns["IdAlumno"])));
                tmp.ShowDialog();
                if (tmp.ActionComplete)
                    AsignarInformacion(CargarAlumnos());
                tmp.Dispose();
                //}
            }
        }

        private void EliminarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("¿Desea eliminar este registro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Eliminar(Convert.ToInt32(AlumnoGridView.GetFocusedRowCellValue(AlumnoGridView.Columns["IdAlumno"])));
                AsignarInformacion(CargarAlumnos());
            }
        }

        private void ActualizarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Business.ShowWait();
            AsignarInformacion(CargarAlumnos());
            Business.CloseWait(200);
        }

        private void Duplicados_Click(object sender, EventArgs e)
        {
            Business.ShowWait();
            DataSet dtemp = new DataSet();
            try
            {
                dtemp = Data.StoredProcedure("procAlumnoList",
                                    4,
                                    "",
                                    "",
                                    "",
                                    "",
                                    "");
                if (Data.SPok)
                {
                    Business.ShowNotification("Se encontraron " + dtemp.Tables[0].Rows[0]["Column1"].ToString() + " registros y se eliminaron.");
                    AsignarInformacion(CargarAlumnos());
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
    }
}
