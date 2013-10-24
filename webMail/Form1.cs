using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;

namespace webMail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      public  struct websites
        {
            public string[] web;
        }


        string[] emails = new string[0];
        int z = 0;
        string[] web = new string[0];
        int x = 0;
        int depth = 0;
        public void DownloadWebPage(string Url,ref websites newWeb)
        {
            // Open a connection
            HttpWebRequest WebRequestObject = (HttpWebRequest)HttpWebRequest.Create(Url);
            
            // You can also specify additional header values like 
            // the user agent or the referer:
            WebRequestObject.UserAgent = ".NET Framework/2.0";
            WebRequestObject.Referer = "http://www.example.com/";

            // Request response:
            WebResponse Response = WebRequestObject.GetResponse();

            // Open data stream:
            Stream WebStream = Response.GetResponseStream();

            // Create reader object:
            StreamReader Reader = new StreamReader(WebStream);

            // Read the entire stream content:
            
            while (!Reader.EndOfStream)
            {
                string c = Reader.ReadLine();
               string s= getMail(c);
               if (s != "")
               {
                   Array.Resize<string>(ref emails, emails.Length + 1);
                   emails[x] = s;
                   x++;
                  // MessageBox.Show(s);
               }
                string ss = getWeb(c);
                if (ss != "")
                {
                    Array.Resize<string>(ref newWeb.web, newWeb.web.Length + 1);
                    newWeb.web[z] = "http://" + ss;
                   z++;
                   // MessageBox.Show(ss);
                }

            }

            // Cleanup
            Reader.Close();
            WebStream.Close();
            Response.Close();

          
        }

        public string getMail(string input)
        {
            Regex mail = new Regex(@"([a-zA-Z0-9]+@[a-zA-Z0-9]+)(\.[a-zA-Z0-9]*)+", RegexOptions.Compiled);
            Match m = mail.Match(input);          
            return  m.Groups[0].Value;
        }

        public string getWeb(string input)
        {
            Regex web = new Regex(@"http\://([a-zA-Z0-9\./\?\&=]*)", RegexOptions.Compiled);
            Match m = web.Match(input);
            return m.Groups[1].Value;
        }
        
        private void reset()
        {
             emails = new string[0];
            z = 0;
             web = new string[0];
            x = 0;
             depth = 0;
        }

        private void goBtn_Click(object sender, EventArgs e)
        {
            reset();
            depth = Convert.ToInt32(depthBox.Text);
          websites[] toscan = new websites[depth+1];
          for (int i = 0; i < toscan.Length; i++)
          {
              toscan[i].web = new string[1];
          }
              toscan[0].web = new string[1];
               toscan[0].web[0]= urlBox.Text;
            for (int i = 0; i <= depth; i++)
            {
                z = 0;
                int v = toscan[i].web.Length;
                for (int j = 0; j < v; j++)
                {
                    try
                    { if(!(toscan[i].web[j].Contains(".exe"))&&!(toscan[i].web[j].Contains(".png"))&&!(toscan[i].web[j].Contains(".gif"))&&!(toscan[i].web[j].Contains(".flv"))&&!(toscan[i].web[j].Contains(".cab"))&&!(toscan[i].web[j].Contains(".swf")))
                        DownloadWebPage(toscan[i].web[j], ref toscan[i+1]); }
                    catch (Exception ex)
                    { ; }
                }
            }
            int webCount = 0;
            string domain = urlBox.Text.Substring(7);
            StreamWriter file = new StreamWriter(domain+"-webisites.txt");
            for (int i = 0; i < toscan.Length; i++)
            {
                for (int j = 0; j < toscan[i].web.Length; j++)
                {
                    file.WriteLine(toscan[i].web[j]);
                    webCount++;
                }
            }
            file.Close();
            int emailCount = 0;
            StreamWriter file2 = new StreamWriter(domain+"-emails.txt");
            if(emails.Length>0)
            file2.Write(emails[0]);
            for (int i = 1; i < emails.Length; i++)
            {
                file2.Write("," + emails[i]);
                emailCount++;
            }
            file2.Close();
            MessageBox.Show("Done! Scanned " + webCount.ToString() + " websites; got " + emailCount.ToString() + " emails");
        }
    }
}
