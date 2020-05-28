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
            string adres;
            adres = (string)listaStron_ListBox.SelectedItem;
            if (listaStron_ListBox.SelectedIndex < listaStron_ListBox.Items.Count-1)
            {
                listaStron_ListBox.SelectedIndex = listaStron_ListBox.SelectedIndex + 1;
            }
            else
            {
                listaStron_ListBox.SelectedIndex = 0;
            }
            Async_RTB.Text += await Task.Run(() => WebRequesting(adres));
            Async_RTB.Text += "****************************************************************\n";
            Async_RTB.Text += "****************************************************************\n";
            Async_RTB.Text += "****************************************************************\n";
            Async_RTB.Text += "****************************************************************\n";
            Async_RTB.Text += "****************************************************************\n";
        }


        public async Task<string> WebRequesting(string Adres)
        {
            WebClient client = new WebClient();
            return await client.DownloadStringTaskAsync(new Uri(Adres));
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            Async_RTB.Clear();
            string adres;
            adres = URL_TB.Text;
            Async_RTB.Text += await Task.Run(() => WebRequesting(adres));
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            string adres = (string)listaStron_ListBox.SelectedItem;
            string tresc = await ShortHTML(adres);
            Async_RTB.Text += tresc.Substring(0, 100);
        }

        private async Task<string> ShortHTML(string adres)
        {
            return "\"" + await Task.Run(() => WebRequesting(adres)) + "\"";
            
        }
    }
}
