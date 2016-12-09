using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;
using System.IO;

namespace VC__6._0ERRLookup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            //this.tbxResponce.ScrollBars = ScrollBars.Vertical;
        }

        private string InputString {
            get;
            set;
        }
        private string OriginalString {
            get;
            set;
        }

        private string FinalString {
            get;
            set;
        }
        private string RangeURlString {
            get;
            set;
        }

        private MatchCollection McURL {
            get;
            set;
        }
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            InputString = tbxInput.Text;
            Regex r = new Regex("C[0-9]{4}");
            if (!r.IsMatch(InputString))
            {
                MessageBox.Show("错误码格式应为C加四位数字！", "输入错误");
                return;
            }
            await SearchAsync();

        }
        private async Task SearchAsync()
        {
            await Task.Run(() =>
            {
                try
                {
                    //http://services.social.microsoft.com/searchapi/zh-CN/Msdn?query=C2086
                    HttpWebRequest hw = HttpWebRequest.CreateHttp($"http://services.social.microsoft.com/searchapi/zh-CN/Msdn?query={InputString}") as HttpWebRequest;
                    hw.Method = "Get";
                    Stream s = hw.GetResponse().GetResponseStream() as Stream;
                    StreamReader sr = new StreamReader(s);
                    OriginalString = sr.ReadToEnd() as string;
                }
                catch (Exception)
                {
                    MessageBox.Show("本工具需要联网使用！");
                }

            });

            Regex rOriginalList = new Regex("(?<=description.*\"url\":\").*?(?=\",\"display_url)");
            Match m = rOriginalList.Match(OriginalString);
            RangeURlString = m.ToString();
            lleLink.Text = RangeURlString;
            await GetList();
            await GetText();
            return;
        }
        private async Task GetText()
        {
            try
            {
                await Task.Run(() =>
                {
                    HttpWebRequest hw = HttpWebRequest.CreateHttp(RangeURlString) as HttpWebRequest;
                    hw.Method = "Get";
                    Stream s = hw.GetResponse().GetResponseStream() as Stream;
                    StreamReader sr = new StreamReader(s);
                    OriginalString = sr.ReadToEnd() as string;
                });
            }
            catch (Exception)
            {

                throw;
            }
            Regex r = new Regex("(?<=<sentencetext xmlns=\"http://www.w3.org/1999/xhtml\">).*?(?=<)", RegexOptions.IgnoreCase);
            MatchCollection mc = r.Matches(OriginalString);
            if (FinalString != null && FinalString.Length > 0)
            {
                FinalString = "";
            }
            foreach (var item in mc)
            {
                FinalString += (item + "\r\n");
            }
            tbxInfo.Clear();
            tbxInfo.Text = FinalString;
        }
        private async Task GetList()
        {
            await Task.Run(() =>
            {
                HttpWebRequest hw = HttpWebRequest.CreateHttp(RangeURlString) as HttpWebRequest;
                hw.Method = "Get";
                Stream s = hw.GetResponse().GetResponseStream() as Stream;
                StreamReader sr = new StreamReader(s);
                OriginalString = sr.ReadToEnd() as string;
            });
            Regex r = new Regex("(?<=toclevel \" data-toclevel=\"1\">\n<a href=\").*?(?=\")", RegexOptions.IgnoreCase);
            McURL = r.Matches(OriginalString);
            r = new Regex("(?<=data-toclevel=\"1\">).*?(?=</a>)", RegexOptions.Singleline);//(?<=data-toclevel="1">).*?(?=</a>)
            MatchCollection mcTitle = r.Matches(OriginalString);
            if (lbxResultList.Items.Count > 0)
            {
                lbxResultList.Items.Clear();
            }
            foreach (var item in mcTitle)
            {
                lbxResultList.Items.Add(item.ToString().Split('>')[1]);
            }
            lbxResultList.Visible = true;
        }

        private async void lbxResultList_DoubleClick(object sender, EventArgs e)
        {
            RangeURlString = McURL[lbxResultList.SelectedIndex].ToString();
            tbxInput.Clear();
            tbxInput.Text = lbxResultList.SelectedItem.ToString();
            await GetText();
            
            lleLink.Text = McURL[lbxResultList.SelectedIndex < lbxResultList.Items.Count ? lbxResultList.SelectedIndex : 0].ToString();
        }

        private void lleLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(lleLink.Text);
        }
    }
}
