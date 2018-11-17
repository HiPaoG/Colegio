namespace Colegio.Profesores
{
    partial class ProfesorList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfesorList));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.ProfesorGridControl = new DevExpress.XtraGrid.GridControl();
            this.ProfesorGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdProfesor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Apellidos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Genero = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.NuevoButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.EditarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.EliminarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ActualizarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.popMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfesorGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfesorGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.ProfesorGridControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(794, 443);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // ProfesorGridControl
            // 
            this.ProfesorGridControl.Location = new System.Drawing.Point(12, 12);
            this.ProfesorGridControl.MainView = this.ProfesorGridView;
            this.ProfesorGridControl.MenuManager = this.barManager;
            this.ProfesorGridControl.Name = "ProfesorGridControl";
            this.ProfesorGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.ProfesorGridControl.Size = new System.Drawing.Size(770, 419);
            this.ProfesorGridControl.TabIndex = 5;
            this.ProfesorGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ProfesorGridView});
            // 
            // ProfesorGridView
            // 
            this.ProfesorGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdProfesor,
            this.Nombre,
            this.Apellidos,
            this.Genero,
            this.Estado});
            this.ProfesorGridView.GridControl = this.ProfesorGridControl;
            this.ProfesorGridView.Name = "ProfesorGridView";
            this.ProfesorGridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.ProfesorGridView.OptionsView.EnableAppearanceEvenRow = true;
            this.ProfesorGridView.OptionsView.ShowGroupPanel = false;
            this.ProfesorGridView.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.ProfesorGridView.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.ProfesorGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.Nombre, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.Apellidos, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.ProfesorGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProfesorGridView_MouseDown);
            // 
            // IdProfesor
            // 
            this.IdProfesor.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.IdProfesor.AppearanceHeader.Options.UseFont = true;
            this.IdProfesor.AppearanceHeader.Options.UseTextOptions = true;
            this.IdProfesor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IdProfesor.Caption = "IdProfesor";
            this.IdProfesor.FieldName = "IdProfesor";
            this.IdProfesor.Name = "IdProfesor";
            this.IdProfesor.OptionsColumn.AllowEdit = false;
            this.IdProfesor.OptionsColumn.ReadOnly = true;
            this.IdProfesor.OptionsColumn.ShowInCustomizationForm = false;
            this.IdProfesor.OptionsColumn.ShowInExpressionEditor = false;
            // 
            // Nombre
            // 
            this.Nombre.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Nombre.AppearanceHeader.Options.UseFont = true;
            this.Nombre.AppearanceHeader.Options.UseTextOptions = true;
            this.Nombre.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Nombre.Caption = "NOMBRE";
            this.Nombre.FieldName = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.OptionsColumn.AllowEdit = false;
            this.Nombre.OptionsColumn.ReadOnly = true;
            this.Nombre.OptionsColumn.ShowInCustomizationForm = false;
            this.Nombre.OptionsColumn.ShowInExpressionEditor = false;
            this.Nombre.Visible = true;
            this.Nombre.VisibleIndex = 0;
            // 
            // Apellidos
            // 
            this.Apellidos.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Apellidos.AppearanceHeader.Options.UseFont = true;
            this.Apellidos.AppearanceHeader.Options.UseTextOptions = true;
            this.Apellidos.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Apellidos.Caption = "APELLIDOS";
            this.Apellidos.FieldName = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.OptionsColumn.AllowEdit = false;
            this.Apellidos.OptionsColumn.ReadOnly = true;
            this.Apellidos.OptionsColumn.ShowInCustomizationForm = false;
            this.Apellidos.OptionsColumn.ShowInExpressionEditor = false;
            this.Apellidos.Visible = true;
            this.Apellidos.VisibleIndex = 1;
            // 
            // Genero
            // 
            this.Genero.AppearanceCell.Options.UseTextOptions = true;
            this.Genero.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Genero.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Genero.AppearanceHeader.Options.UseFont = true;
            this.Genero.AppearanceHeader.Options.UseTextOptions = true;
            this.Genero.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Genero.Caption = "GÉNERO";
            this.Genero.FieldName = "Genero";
            this.Genero.Name = "Genero";
            this.Genero.OptionsColumn.AllowEdit = false;
            this.Genero.OptionsColumn.ReadOnly = true;
            this.Genero.OptionsColumn.ShowInCustomizationForm = false;
            this.Genero.OptionsColumn.ShowInExpressionEditor = false;
            this.Genero.Visible = true;
            this.Genero.VisibleIndex = 2;
            // 
            // Estado
            // 
            this.Estado.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Estado.AppearanceHeader.Options.UseFont = true;
            this.Estado.AppearanceHeader.Options.UseTextOptions = true;
            this.Estado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Estado.Caption = "ACTIVO";
            this.Estado.ColumnEdit = this.repositoryItemCheckEdit1;
            this.Estado.FieldName = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.OptionsColumn.AllowEdit = false;
            this.Estado.OptionsColumn.ReadOnly = true;
            this.Estado.OptionsColumn.ShowInCustomizationForm = false;
            this.Estado.OptionsColumn.ShowInExpressionEditor = false;
            this.Estado.Visible = true;
            this.Estado.VisibleIndex = 3;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
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
            this.barDockControlTop.Size = new System.Drawing.Size(794, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 443);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(794, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 443);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(794, 0);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 443);
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
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(794, 443);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.ProfesorGridControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(774, 423);
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
            // ProfesorList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 443);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProfesorList";
            this.ShowIcon = false;
            this.Text = "Listado de Profesores";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProfesorGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfesorGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl ProfesorGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView ProfesorGridView;
        private DevExpress.XtraGrid.Columns.GridColumn IdProfesor;
        private DevExpress.XtraGrid.Columns.GridColumn Nombre;
        private DevExpress.XtraGrid.Columns.GridColumn Apellidos;
        private DevExpress.XtraGrid.Columns.GridColumn Genero;
        private DevExpress.XtraGrid.Columns.GridColumn Estado;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
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