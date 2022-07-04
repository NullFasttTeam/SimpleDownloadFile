using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleDownloadFile
{
    public class Home
    {
        public static void DownloadFile(string link, string lugar, string name)
        {
            try {
                Uri myUri = new Uri(link);
            WebClient webClient = new WebClient();
           webClient.DownloadFileAsync(myUri, lugar, name);
            } catch {
                MessageBox.Show("Error al descargar el archivo", "SimpleDownloadFile");
            }
           
        }
        public static void DownloadString(string web)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadString(web);
        }
    }
}
