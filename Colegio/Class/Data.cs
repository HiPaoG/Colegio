using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;
using DevExpress.XtraEditors;

namespace Colegio.Class
{
    public class Data
    {
        public static SqlConnection myCon = null;

        public static Boolean SPok = false;

        public static SqlConnection GetConnection()
        {
            myCon = new SqlConnection(ConfigurationManager.ConnectionStrings["dbColegioViaro"].ToString());
            return myCon;
        }

        public static DataSet StoredProcedure(string ProcName, params object[] Parametros)
        {
            SPok = false;
            DataSet dataset = new DataSet();
            try
            {
                SqlConnection con = GetConnection();
                SqlCommand cmd = new SqlCommand(ProcName, con);
                SqlDataAdapter da;
                using (con)
                {
                    con.Open();
                    using (cmd)
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlCommandBuilder.DeriveParameters(cmd);
                        int i = 1;
                        foreach (object Param in Parametros)
                        {
                            cmd.Parameters[i].Value = Param;
                            i++;
                        }
                        da = new SqlDataAdapter(cmd);
                        da.Fill(dataset);
                    }
                    con.Close();
                }
                SPok = true;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Eror de base de datos. Error: " + ex.Message.ToString());
            }
            return dataset;
        }

        public static byte[] SaveImage(Image image)
        {
            // Stream usado como buffer
            MemoryStream ms = new MemoryStream();
            // Se guarda la imagen en el buffer
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            // Se extraen los bytes del buffer para asignarlos como valor para el parámetro.
            return ms.GetBuffer();
        }

        public static Image ReadImage(object DataObject)
        {
            // El campo productImage primero se almacena en un buffer
            byte[] imageBuffer = (byte[])DataObject;
            // Se crea un MemoryStream a partir de ese buffer
            MemoryStream ms = new MemoryStream(imageBuffer);
            // Se utiliza el MemoryStream para extraer la imagen
            return Image.FromStream(ms);
        }
    }
}
