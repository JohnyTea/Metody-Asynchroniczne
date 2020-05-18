using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody_Asynchroniczne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listaStron_ListBox.Items.Add("https://pl.wikipedia.org/wiki/Uk%C5%82ad_chor%C4%85giewkowy");
            listaStron_ListBox.Items.Add("https://pl.wikipedia.org/wiki/Kra%C5%9Bnik_(obw%C3%B3d_iwanofrankiwski)");
            listaStron_ListBox.Items.Add("https://pl.wikipedia.org/wiki/Renardowice");
            listaStron_ListBox.Items.Add("https://pl.wikipedia.org/wiki/Geografia_rolnictwa");
            listaStron_ListBox.Items.Add("https://pl.wikipedia.org/wiki/Deira");
            listaStron_ListBox.Items.Add("https://pl.wikipedia.org/wiki/The_Ska_EP");
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string adres = (string) listaStron_ListBox.SelectedItem;
                Async_RTB.Text += await Task.Run(() => WebRequesting(adres));
        }


        public string WebRequesting(string Adres)
        {
            System.Threading.Thread.Sleep(10000);
            // Create a request for the URL. 		
            WebRequest request = WebRequest.Create(Adres);
            // If required by the server, set the credentials.
            request.Credentials = CredentialCache.DefaultCredentials;
            // Get the response.
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            // Cleanup the streams and the response.
            reader.Close();
            dataStream.Close();
            response.Close();
            return responseFromServer;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            Async_RTB.Clear();
            string adres;
            for (int i = listaStron_ListBox.SelectedIndex; i < listaStron_ListBox.Items.Count; i++)
            {
                listaStron_ListBox.SelectedIndex = i;
                adres = (string)listaStron_ListBox.SelectedItem;
                Async_RTB.Text += "\n**************\n" + adres + "\n******************\n";
                Async_RTB.Text += "\n**************\n" + adres + "\n******************\n";
                Async_RTB.Text += "\n**************\n" + adres + "\n******************\n";
                Async_RTB.Text += await Task.Run(() => WebRequesting(adres));
            }
            

        }

        private async void button3_Click(object sender, EventArgs e)
        {
            string adres = (string)listaStron_ListBox.SelectedItem;
            Async_RTB.Text += await Task.Run(() => ShortHtml(adres));
        }

        public string ShortHtml(string Adres)
        {
            System.Threading.Thread.Sleep(10000);
            // Create a request for the URL. 		
            WebRequest request = WebRequest.Create(Adres);
            // If required by the server, set the credentials.
            request.Credentials = CredentialCache.DefaultCredentials;
            // Get the response.
            request.ContentLength = 100;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            // Cleanup the streams and the response.
            reader.Close();
            dataStream.Close();
            response.Close();
            return responseFromServer;
        }
    }
}
