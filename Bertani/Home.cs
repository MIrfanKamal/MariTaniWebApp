using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewsAPI;
using NewsAPI.Models;
using NewsAPI.Constants;

namespace Bertani
{
    public partial class Home : UserControl
    {
        PictureBox pbDisplay;
        LinkLabel lblJudul;
        Label lblAuthor;
        Label lblDescription;
        List<LinkLabel> listLblJudul = new List<LinkLabel>();
        List<string> listUrl = new List<string>();
        public Home()
        {
            InitializeComponent();
            GetNews();
        }
        private async Task GetNews()
        {
            btnReload.Enabled = false;
            int i = 0;
            var newsApiClient = new NewsApiClient("6ff022269669489cb600394f99d9d6b9");
            var articleResponse = await newsApiClient.GetEverythingAsync(new EverythingRequest
            {
                Q = "Pertanian",
                SortBy = SortBys.PublishedAt
            });
            if(articleResponse.Status == Statuses.Ok)
            {
                listLblJudul.Clear();
                listUrl.Clear();
                foreach(var article in articleResponse.Articles)
                {
                    if (i < 10)
                    {
                        pbDisplay = new PictureBox();
                        pbDisplay.Size = new Size(100, 100);
                        pbDisplay.Location = new Point(15, 15 + 110 * i);
                        pbDisplay.Load(article.UrlToImage);
                        pbDisplay.SizeMode = PictureBoxSizeMode.StretchImage;
                        pnNews.Controls.Add(pbDisplay);
                        lblJudul = new LinkLabel();
                        lblJudul.AutoSize = false;
                        lblJudul.Size = new Size(700, 30);
                        lblJudul.Location = new Point(120, 15 + 110 * i);
                        lblJudul.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                        lblJudul.Text = article.Title;
                        lblJudul.LinkClicked += LblJudul_LinkClicked;
                        lblJudul.Name = "lblJudul" + i.ToString();
                        listLblJudul.Add(lblJudul);
                        listUrl.Add(article.Url);
                        pnNews.Controls.Add(lblJudul);
                        lblAuthor = new Label();
                        lblAuthor.Location = new Point(120, 50 + 110 * i);
                        lblAuthor.AutoSize = true;
                        lblAuthor.Text = "Penulis : " + article.Author + " Tanggal : "+article.PublishedAt;
                        pnNews.Controls.Add(lblAuthor);
                        lblDescription = new Label();
                        lblDescription.AutoSize = false;
                        lblDescription.Size = new Size(700, 39);
                        lblDescription.Location = new Point(120, 75 + 110 * i);
                        lblDescription.Text = article.Description;
                        pnNews.Controls.Add(lblDescription);
                        i++;
                    }
                    else
                        break;
                }
            }
            btnReload.Enabled = true;
        }

        private void LblJudul_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            listLblJudul[listLblJudul.IndexOf((LinkLabel)sender)].LinkVisited = true;
            System.Diagnostics.Process.Start(listUrl[listLblJudul.IndexOf((LinkLabel)sender)]);
            //throw new NotImplementedException();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            pnNews.Controls.Clear();
            GetNews();
        }
    }
}
