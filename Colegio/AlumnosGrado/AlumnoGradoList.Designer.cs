namespace Colegio.AlumnosGrado
{
    partial class AlumnoGradoList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlumnoGradoList));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.AlumnoGradoGridControl = new DevExpress.XtraGrid.GridControl();
            this.AlumnoGradoGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdAlumnoGrado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Alumno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Grado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Seccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdAlumno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdGrado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.NuevoButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.EditarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.EliminarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ActualizarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.popMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlumnoGradoGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlumnoGradoGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.AlumnoGradoGridControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(791, 471);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // AlumnoGradoGridControl
            // 
            this.AlumnoGradoGridControl.Location = new System.Drawing.Point(12, 12);
            this.AlumnoGradoGridControl.MainView = this.AlumnoGradoGridView;
            this.AlumnoGradoGridControl.MenuManager = this.barManager;
            this.AlumnoGradoGridControl.Name = "AlumnoGradoGridControl";
            this.AlumnoGradoGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.AlumnoGradoGridControl.Size = new System.Drawing.Size(767, 447);
            this.AlumnoGradoGridControl.TabIndex = 6;
            this.AlumnoGradoGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.AlumnoGradoGridView});
            // 
            // AlumnoGradoGridView
            // 
            this.AlumnoGradoGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdAlumnoGrado,
            this.Alumno,
            this.Grado,
            this.Seccion,
            this.IdAlumno,
            this.IdGrado});
            this.AlumnoGradoGridView.GridControl = this.AlumnoGradoGridControl;
            this.AlumnoGradoGridView.GroupCount = 2;
            this.AlumnoGradoGridView.Name = "AlumnoGradoGridView";
            this.AlumnoGradoGridView.OptionsBehavior.AutoExpandAllGroups = true;
            this.AlumnoGradoGridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.AlumnoGradoGridView.OptionsView.EnableAppearanceEvenRow = true;
            this.AlumnoGradoGridView.OptionsView.ShowGroupPanel = false;
            this.AlumnoGradoGridView.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.AlumnoGradoGridView.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.AlumnoGradoGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.Grado, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.Seccion, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.Alumno, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.AlumnoGradoGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AlumnoGradoGridView_MouseDown);
            // 
            // IdAlumnoGrado
            // 
            this.IdAlumnoGrado.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.IdAlumnoGrado.AppearanceHeader.Options.UseFont = true;
            this.IdAlumnoGrado.AppearanceHeader.Options.UseTextOptions = true;
            this.IdAlumnoGrado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IdAlumnoGrado.Caption = "IdAlumnoGrado";
            this.IdAlumnoGrado.FieldName = "IdAlumnoGrado";
            this.IdAlumnoGrado.Name = "IdAlumnoGrado";
            this.IdAlumnoGrado.OptionsColumn.AllowEdit = false;
            this.IdAlumnoGrado.OptionsColumn.ReadOnly = true;
            this.IdAlumnoGrado.OptionsColumn.ShowInCustomizationForm = false;
            this.IdAlumnoGrado.OptionsColumn.ShowInExpressionEditor = false;
            // 
            // Alumno
            // 
            this.Alumno.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Alumno.AppearanceHeader.Options.UseFont = true;
            this.Alumno.AppearanceHeader.Options.UseTextOptions = true;
            this.Alumno.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Alumno.Caption = "ALUMNO";
            this.Alumno.FieldName = "Alumno";
            this.Alumno.Name = "Alumno";
            this.Alumno.OptionsColumn.AllowEdit = false;
            this.Alumno.OptionsColumn.ReadOnly = true;
            this.Alumno.OptionsColumn.ShowInCustomizationForm = false;
            this.Alumno.OptionsColumn.ShowInExpressionEditor = false;
            this.Alumno.Visible = true;
            this.Alumno.VisibleIndex = 0;
            // 
            // Grado
            // 
            this.Grado.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Grado.AppearanceHeader.Options.UseFont = true;
            this.Grado.AppearanceHeader.Options.UseTextOptions = true;
            this.Grado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Grado.Caption = "GRADO";
            this.Grado.FieldName = "Grado";
            this.Grado.Name = "Grado";
            this.Grado.OptionsColumn.AllowEdit = false;
            this.Grado.OptionsColumn.ReadOnly = true;
            this.Grado.OptionsColumn.ShowInCustomizationForm = false;
            this.Grado.OptionsColumn.ShowInExpressionEditor = false;
            this.Grado.Visible = true;
            this.Grado.VisibleIndex = 1;
            // 
            // Seccion
            // 
            this.Seccion.Caption = "SECCIÓN";
            this.Seccion.FieldName = "Seccion";
            this.Seccion.Name = "Seccion";
            this.Seccion.OptionsColumn.AllowEdit = false;
            this.Seccion.OptionsColumn.ReadOnly = true;
            this.Seccion.OptionsColumn.ShowInCustomizationForm = false;
            this.Seccion.OptionsColumn.ShowInExpressionEditor = false;
            this.Seccion.Visible = true;
            this.Seccion.VisibleIndex = 1;
            // 
            // IdAlumno
            // 
            this.IdAlumno.AppearanceCell.Options.UseTextOptions = true;
            this.IdAlumno.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IdAlumno.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.IdAlumno.AppearanceHeader.Options.UseFont = true;
            this.IdAlumno.AppearanceHeader.Options.UseTextOptions = true;
            this.IdAlumno.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IdAlumno.Caption = "IdAlumno";
            this.IdAlumno.FieldName = "IdAlumno";
            this.IdAlumno.Name = "IdAlumno";
            this.IdAlumno.OptionsColumn.AllowEdit = false;
            this.IdAlumno.OptionsColumn.ReadOnly = true;
            this.IdAlumno.OptionsColumn.ShowInCustomizationForm = false;
            this.IdAlumno.OptionsColumn.ShowInExpressionEditor = false;
            // 
            // IdGrado
            // 
            this.IdGrado.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.IdGrado.AppearanceHeader.Options.UseFont = true;
            this.IdGrado.AppearanceHeader.Options.UseTextOptions = true;
            this.IdGrado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IdGrado.Caption = "IdGrado";
            this.IdGrado.FieldName = "IdGrado";
            this.IdGrado.Name = "IdGrado";
            this.IdGrado.OptionsColumn.AllowEdit = false;
            this.IdGrado.OptionsColumn.ReadOnly = true;
            this.IdGrado.OptionsColumn.ShowInCustomizationForm = false;
            this.IdGrado.OptionsColumn.ShowInExpressionEditor = false;
            // 
            // barManager
            // 
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.NuevoButtonItem,
            this.EditarButtonItem,
            this.EliminarButtonItem,
            this.ActualizarButtonItem});
            this.barManager.MaxItemId = 4;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager;
            this.barDockControlTop.Size = new System.Drawing.Size(791, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 471);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(791, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 471);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(791, 0);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 471);
            // 
            // NuevoButtonItem
            // 
            this.NuevoButtonItem.Caption = "Nuevo";
            this.NuevoButtonItem.Id = 0;
            this.NuevoButtonItem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("NuevoButtonItem.ImageOptions.SvgImage")));
            this.NuevoButtonItem.Name = "NuevoButtonItem";
            this.NuevoButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.NuevoButtonItem_ItemClick);
            // 
            // EditarButtonItem
            // 
            this.EditarButtonItem.Caption = "Editar";
            this.EditarButtonItem.Id = 1;
            this.EditarButtonItem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("EditarButtonItem.ImageOptions.SvgImage")));
            this.EditarButtonItem.Name = "EditarButtonItem";
            this.EditarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.EditarButtonItem_ItemClick);
            // 
            // EliminarButtonItem
            // 
            this.EliminarButtonItem.Caption = "Eliminar";
            this.EliminarButtonItem.Id = 2;
            this.EliminarButtonItem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("EliminarButtonItem.ImageOptions.SvgImage")));
            this.EliminarButtonItem.Name = "EliminarButtonItem";
            this.EliminarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.EliminarButtonItem_ItemClick);
            // 
            // ActualizarButtonItem
            // 
            this.ActualizarButtonItem.Caption = "Actualizar";
            this.ActualizarButtonItem.Id = 3;
            this.ActualizarButtonItem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ActualizarButtonItem.ImageOptions.SvgImage")));
            this.ActualizarButtonItem.Name = "ActualizarButtonItem";
            this.ActualizarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ActualizarButtonItem_ItemClick);
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(791, 471);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.AlumnoGradoGridControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(771, 451);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // popMenu
            // 
            this.popMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.NuevoButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.EditarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.EliminarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.ActualizarButtonItem, true)});
            this.popMenu.Manager = this.barManager;
            this.popMenu.Name = "popMenu";
            // 
            // AlumnoGradoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 471);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlumnoGradoList";
            this.ShowIcon = false;
            this.Text = "Listado de Alumnos - Grados";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AlumnoGradoGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlumnoGradoGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl AlumnoGradoGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView AlumnoGradoGridView;
        private DevExpress.XtraGrid.Columns.GridColumn IdAlumnoGrado;
        private DevExpress.XtraGrid.Columns.GridColumn Alumno;
        private DevExpress.XtraGrid.Columns.GridColumn Grado;
        private DevExpress.XtraGrid.Columns.GridColumn IdAlumno;
        private DevExpress.XtraGrid.Columns.GridColumn IdGrado;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn Seccion;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem NuevoButtonItem;
        private DevExpress.XtraBars.BarButtonItem EditarButtonItem;
        private DevExpress.XtraBars.BarButtonItem EliminarButtonItem;
        private DevExpress.XtraBars.BarButtonItem ActualizarButtonItem;
        private DevExpress.XtraBars.PopupMenu popMenu;
    }
}