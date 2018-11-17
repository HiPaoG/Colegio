using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraSplashScreen;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraBars.ToastNotifications;

namespace Colegio.Class
{
    public class Business
    {
        public static DataTable SystemConfiguration = null;

        public static ToastNotificationsManager Notifications;
        
        public static void ShowWait()
        {
            SplashScreenManager.ShowDefaultWaitForm("Espere", "Cargando...");
        }

        public static void CloseWait(int miliseconds)
        {
            Thread.Sleep(miliseconds);
            SplashScreenManager.CloseForm();
        }

        public static void CloseWait()
        {
            SplashScreenManager.CloseForm();
        }

        public static void ShowNotification(string Header, string Body, string Body2)
        {
            Notifications.Notifications[0].Header = Header;
            Notifications.Notifications[0].Body = Body;
            Notifications.Notifications[0].Body2 = Body2;
            Notifications.ShowNotification(Notifications.Notifications[0]);
        }

        public static void ShowNotification(string Body, string Body2)
        {
            Notifications.Notifications[0].Header = "Acción completada";
            Notifications.Notifications[0].Body = Body;
            Notifications.Notifications[0].Body2 = Body2;
            Notifications.ShowNotification(Notifications.Notifications[0]);
        }

        public static void ShowNotification(string Body)
        {
            Notifications.Notifications[0].Header = "Acción completada";
            Notifications.Notifications[0].Body = Body;
            Notifications.Notifications[0].Body2 = "Viaro App";
            Notifications.ShowNotification(Notifications.Notifications[0]);
        }

        public static void MdiShow(Form formHijo, Form formPrincipal)
        {
            formHijo.MdiParent = formPrincipal;
            formHijo.WindowState = FormWindowState.Maximized;
            formHijo.ShowInTaskbar = false;
            formHijo.Show();
            formHijo.Update();
        }
    }
}
