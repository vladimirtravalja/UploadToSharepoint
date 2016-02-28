using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SharePoint.Client;
using Microsoft.SharePoint;
using System.Threading;

namespace SharepointUpload
{
    public partial class SharepointUpload : System.Windows.Forms.Form
    {
        public SharepointUpload()
        {
            InitializeComponent();
        }

        string path = "";
        string file = "";
        string fileName = "";

        private void pathBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = String.Empty;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = openFileDialog1.FileName;
                file = Path.GetFileName(openFileDialog1.FileName);
                fileName = Path.GetFileNameWithoutExtension(openFileDialog1.FileName);
                //path = fileName;
                pathTxt.Text = path;
            }
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
           
            System.Net.NetworkCredential credential = new System.Net.NetworkCredential(userTxt.Text, passTxt.Text, domainTxt.Text);
            ClientContext client = new ClientContext("https://sharepoint.domain.lan/path/to/service/");
            client.RequestTimeout = 3600000;
            client.ExecutingWebRequest += new EventHandler<WebRequestEventArgs>(client_ExecutingWebRequtest);
            client.Credentials = credential;
            MemoryStream stream;
            using (FileStream fs = new FileStream(pathTxt.Text, FileMode.Open))
            {
                byte[] buffer = new byte[16 * 1024];
                byte[] byteArr;

                using (MemoryStream ms = new MemoryStream())
                {
                    int read;
                    while ((read = fs.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        ms.Write(buffer, 0, read);
                    }
                    byteArr = ms.ToArray();
                }

                stream = new MemoryStream(byteArr);

                var fi = new FileInfo(pathTxt.Text);
				//Project Administration presents root folder
                var list = client.Web.Lists.GetByTitle("Project Administration");
                client.Load(list.RootFolder);
                client.ExecuteQuery();
                var fileUrl = list.RootFolder.ServerRelativeUrl + "/"+folderTxt.Text+"/" + fi.Name;
                client.RequestTimeout = Timeout.Infinite;
                try
                {
                    Microsoft.SharePoint.Client.File.SaveBinaryDirect(client, fileUrl, stream, true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong: "+ex.ToString(), "Error...!", MessageBoxButtons.OK);
                    return;
                }
            }
            MessageBox.Show("Upload has completed...", "Information...", MessageBoxButtons.OK);

        }

		//this event is to prevent form based authentication. It uses windows instead.
        static void client_ExecutingWebRequtest(object sender, WebRequestEventArgs e)
        {
            e.WebRequestExecutor.WebRequest.Headers.Add("X-FORMS_BASED_AUTH_ACCEPTED", "f");
        }

        private void SharepointUpload_Load(object sender, EventArgs e)
        {

        }
    }
}
