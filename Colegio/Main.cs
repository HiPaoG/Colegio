using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using Colegio.Class;

namespace Colegio
{
    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Main()
        {
            InitializeComponent();
            Business.Notifications = toastNotifications;
        }

        private void btnAlumnos_ItemClick(object sender, ItemClickEventArgs e)
        {
            Alumnos.AlumnoList tmp = new Alumnos.AlumnoList();
            Business.MdiShow(tmp, this);
        }

        private void btnProfesores_ItemClick(object sender, ItemClickEventArgs e)
        {
            Profesores.ProfesorList tmp = new Profesores.ProfesorList();
            Business.MdiShow(tmp, this);
        }

        private void btnGrados_ItemClick(object sender, ItemClickEventArgs e)
        {
            Grado.GradoList tmp = new Grado.GradoList();
            Business.MdiShow(tmp, this);
        }

        private void btnAlumnoGrado_ItemClick(object sender, ItemClickEventArgs e)
        {
            AlumnosGrado.AlumnoGradoList tmp = new AlumnosGrado.AlumnoGradoList();
            Business.MdiShow(tmp, this);
        }
    }
}