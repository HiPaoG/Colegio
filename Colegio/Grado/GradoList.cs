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

namespace Colegio.Grado
{
    public partial class GradoList : Form
    {
        DataTable TableGrado = new DataTable();

        private void Eliminar(int Id)
        {
            Business.ShowWait();
            try
            {
                Data.StoredProcedure("procGrado",
                                    Id,
                                    "",
                                    "0",
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

        internal DataTable CargarGrados()
        {
            TableGrado.Clear();
            TableGrado = Data.StoredProcedure("procGradoList", 3, "null", "null", "null", "null", "null").Tables[0];
            return TableGrado;
        }

        internal void AsignarInformacion(DataTable Conf)
        {
            if (Conf.Rows.Count > 0)
            {
                GradoGridControl.DataSource = Conf;
            }
        }
        public GradoList()
        {
            InitializeComponent();
            AsignarInformacion(CargarGrados());
        }

        private void GradoGridView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                popMenu.ShowPopup(MousePosition);
        }

        private void NuevoButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Grado tmp = new Grado(0);
            tmp.ShowDialog();
            if (tmp.ActionComplete)
                AsignarInformacion(CargarGrados());
            tmp.Dispose();
        }

        private void EditarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int IdTemp = Convert.ToInt32(GradoGridView.GetFocusedRowCellValue(GradoGridView.Columns["IdGrado"]));
            if (GradoGridView.RowCount > 0)
            {
                AsignarInformacion(CargarGrados());
                if (IdTemp != Convert.ToInt32(GradoGridView.GetFocusedRowCellValue(GradoGridView.Columns["IdGrado"])))
                    XtraMessageBox.Show("Este registro ya fue eliminado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    Grado tmp = new Grado(Convert.ToInt32(GradoGridView.GetFocusedRowCellValue(GradoGridView.Columns["IdGrado"])));
                    tmp.ShowDialog();
                    if (tmp.ActionComplete)
                        AsignarInformacion(CargarGrados());
                    tmp.Dispose();
                }
            }
        }

        private void EliminarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("¿Desea eliminar este registro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Eliminar(Convert.ToInt32(GradoGridView.GetFocusedRowCellValue(GradoGridView.Columns["IdGrado"])));
                AsignarInformacion(CargarGrados());
            }
        }

        private void ActualizarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Business.ShowWait();
            AsignarInformacion(CargarGrados());
            Business.CloseWait(200);
        }
    }
}
