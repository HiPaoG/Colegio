namespace Colegio
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnAlumnos = new DevExpress.XtraBars.BarButtonItem();
            this.btnProfesores = new DevExpress.XtraBars.BarButtonItem();
            this.btnAlumnoGrado = new DevExpress.XtraBars.BarButtonItem();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.btnGrados = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.MdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.toastNotifications = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MdiManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotifications)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnAlumnos,
            this.btnProfesores,
            this.btnAlumnoGrado,
            this.skinRibbonGalleryBarItem1,
            this.btnGrados});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 9;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(809, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnAlumnos
            // 
            this.btnAlumnos.Caption = "Alumnos";
            this.btnAlumnos.Id = 2;
            this.btnAlumnos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAlumnos.ImageOptions.Image")));
            this.btnAlumnos.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAlumnos.ImageOptions.LargeImage")));
            this.btnAlumnos.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAlumnos.ImageOptions.SvgImage")));
            this.btnAlumnos.Name = "btnAlumnos";
            this.btnAlumnos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAlumnos_ItemClick);
            // 
            // btnProfesores
            // 
            this.btnProfesores.Caption = "Profesores";
            this.btnProfesores.Id = 3;
            this.btnProfesores.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnProfesores.ImageOptions.Image")));
            this.btnProfesores.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnProfesores.ImageOptions.LargeImage")));
            this.btnProfesores.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnProfesores.ImageOptions.SvgImage")));
            this.btnProfesores.Name = "btnProfesores";
            this.btnProfesores.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProfesores_ItemClick);
            // 
            // btnAlumnoGrado
            // 
            this.btnAlumnoGrado.Caption = "Alumnos y Grados";
            this.btnAlumnoGrado.Id = 4;
            this.btnAlumnoGrado.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAlumnoGrado.ImageOptions.Image")));
            this.btnAlumnoGrado.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAlumnoGrado.ImageOptions.LargeImage")));
            this.btnAlumnoGrado.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAlumnoGrado.ImageOptions.SvgImage")));
            this.btnAlumnoGrado.Name = "btnAlumnoGrado";
            this.btnAlumnoGrado.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAlumnoGrado_ItemClick);
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.Id = 6;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // btnGrados
            // 
            this.btnGrados.Caption = "Grados";
            this.btnGrados.Id = 8;
            this.btnGrados.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGrados.ImageOptions.SvgImage")));
            this.btnGrados.Name = "btnGrados";
            this.btnGrados.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGrados_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Colegio";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAlumnos);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnProfesores);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnGrados);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAlumnoGrado);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Sistema";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 464);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(809, 31);
            // 
            // MdiManager
            // 
            this.MdiManager.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.MdiManager.MdiParent = this;
            this.MdiManager.UseFormIconAsPageImage = DevExpress.Utils.DefaultBoolean.False;
            // 
            // toastNotifications
            // 
            this.toastNotifications.ApplicationId = "7560b708-612f-41d4-a933-644b4d02455d";
            this.toastNotifications.ApplicationName = "Colegio";
            this.toastNotifications.CreateApplicationShortcut = DevExpress.Utils.DefaultBoolean.True;
            this.toastNotifications.Notifications.AddRange(new DevExpress.XtraBars.ToastNotifications.IToastNotificationProperties[] {
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("0c0d29bf-f953-42bc-b735-35f86b025c97", global::Colegio.Properties.Resources.Logo32x32, "Acción Completada", "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor i" +
                    "ncididunt ut labore et dolore magna aliqua.", "Viaro App", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText02)});
            // 
            // Main
            // 
            this.AllowMdiBar = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 495);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Viaro App";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MdiManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotifications)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnAlumnos;
        private DevExpress.XtraBars.BarButtonItem btnProfesores;
        private DevExpress.XtraBars.BarButtonItem btnAlumnoGrado;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager MdiManager;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.BarButtonItem btnGrados;
        internal DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager toastNotifications;
    }
}