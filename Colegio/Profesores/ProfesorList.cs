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

namespace Colegio.Profesores
{
    public partial class ProfesorList : Form
    {
        DataTable TableProfesor = new DataTable();

        private void Eliminar(int Id)
        {
            Business.ShowWait();
            try
            {
                Data.StoredProcedure("procProfesor",
                                    Id,
                                    "",
                                    "",
                                    "",
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

        internal DataTable CargarProfesores()
        {
            TableProfesor.Clear();
            TableProfesor = Data.StoredProcedure("procProfesorList", 1, "null", "null", "null", "null", "null").Tables[0];
            return TableProfesor;
        }

        internal void AsignarInformacion(DataTable Conf)
        {
            if (Conf.Rows.Count > 0)
            {
                ProfesorGridControl.DataSource = Conf;
            }
        }
        public ProfesorList()
        {
            InitializeComponent();
            AsignarInformacion(CargarProfesores());
        }

        private void ProfesorGridView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                popMenu.ShowPopup(MousePosition);
        }

        private void NuevoButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Profesor tmp = new Profesor(0);
            tmp.ShowDialog();
            if (tmp.ActionComplete)
                AsignarInformacion(CargarProfesores());
            tmp.Dispose();
        }

        private void EditarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //int IdTemp = Convert.ToInt32(ProfesorGridView.GetFocusedRowCellValue(ProfesorGridView.Columns["IdProfesor"]));
            if (ProfesorGridView.RowCount > 0)
            {
            //    AsignarInformacion(CargarProfesores());
            //    if (IdTemp != Convert.ToInt32(ProfesorGridView.GetFocusedRowCellValue(ProfesorGridView.Columns["IdProfesor"])))
            //        XtraMessageBox.Show("Este registro ya fue eliminado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    else
            //    {
                    Profesor tmp = new Profesor(Convert.ToInt32(ProfesorGridView.GetFocusedRowCellValue(ProfesorGridView.Columns["IdProfesor"])));
                    tmp.ShowDialog();
                    if (tmp.ActionComplete)
                        AsignarInformacion(CargarProfesores());
                    tmp.Dispose();
                //}
            }
        }

        private void EliminarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("¿Desea eliminar este registro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Eliminar(Convert.ToInt32(ProfesorGridView.GetFocusedRowCellValue(ProfesorGridView.Columns["IdProfesor"])));
                AsignarInformacion(CargarProfesores());
            }
        }

        private void ActualizarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Business.ShowWait();
            AsignarInformacion(CargarProfesores());
            Business.CloseWait(200);
        }
    }
}
