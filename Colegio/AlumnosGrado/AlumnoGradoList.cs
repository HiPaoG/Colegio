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
    public partial class AlumnoGradoList : Form
    {
        DataTable TableAlumnoGrado = new DataTable();

        private void Eliminar(int Id)
        {
            Business.ShowWait();
            try
            {
                Data.StoredProcedure("procAlumnoGrado",
                                    Id,
                                    "0",
                                    "0",
                                    "",
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

        internal DataTable CargarAlumnosGrados()
        {
            TableAlumnoGrado.Clear();
            TableAlumnoGrado = Data.StoredProcedure("procAlumnoGradoList", 3, "null", "null", "null", "null", "null").Tables[0];
            return TableAlumnoGrado;
        }

        internal void AsignarInformacion(DataTable Conf)
        {
            if (Conf.Rows.Count > 0)
            {
                AlumnoGradoGridControl.DataSource = Conf;
            }
        }
        public AlumnoGradoList()
        {
            InitializeComponent();
            AsignarInformacion(CargarAlumnosGrados());
        }

        private void AlumnoGradoGridView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                popMenu.ShowPopup(MousePosition);
        }

        private void NuevoButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AlumnoGrado tmp = new AlumnoGrado(0);
            tmp.ShowDialog();
            if (tmp.ActionComplete)
                AsignarInformacion(CargarAlumnosGrados());
            tmp.Dispose();
        }

        private void EditarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int IdTemp = Convert.ToInt32(AlumnoGradoGridView.GetFocusedRowCellValue(AlumnoGradoGridView.Columns["IdAlumnoGrado"]));
            if (AlumnoGradoGridView.RowCount > 0 && AlumnoGradoGridView.FocusedRowHandle >= 0)
            {
                AsignarInformacion(CargarAlumnosGrados());
                if ((IdTemp != Convert.ToInt32(AlumnoGradoGridView.GetFocusedRowCellValue(AlumnoGradoGridView.Columns["IdAlumnoGrado"])))
                    && Convert.ToInt32(AlumnoGradoGridView.GetFocusedRowCellValue(AlumnoGradoGridView.Columns["IdAlumnoGrado"])) != 0)
                    XtraMessageBox.Show("Este registro ya fue eliminado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    AlumnoGrado tmp = new AlumnoGrado(IdTemp);
                    tmp.ShowDialog();
                    if (tmp.ActionComplete)
                        AsignarInformacion(CargarAlumnosGrados());
                    tmp.Dispose();
                }
            }
        }

        private void EliminarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("¿Desea eliminar este registro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Eliminar(Convert.ToInt32(AlumnoGradoGridView.GetFocusedRowCellValue(AlumnoGradoGridView.Columns["IdAlumnoGrado"])));
                AsignarInformacion(CargarAlumnosGrados());
            }
        }

        private void ActualizarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Business.ShowWait();
            AsignarInformacion(CargarAlumnosGrados());
            Business.CloseWait(200);
        }
    }
}
