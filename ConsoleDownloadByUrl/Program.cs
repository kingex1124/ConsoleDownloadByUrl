
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDownloadByUrl
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pg = new Program();
            pg.DowloadData();

            Console.ReadLine();
        }

        public async void DowloadData()
        {
            try
            {
                using (WebClient wc = new WebClient())
                {
                    wc.DownloadProgressChanged += Wc_DownloadProgressChanged;

                    //wc.DownloadFile(new System.Uri("https://dl.ganttproject.biz/ganttproject-3.2.3240/ganttproject-3.2.3240.exe"), @"D:\011714\study\ganttproject-3.2.3240.exe");
                    await wc.DownloadFileTaskAsync(new System.Uri("https://dl.ganttproject.biz/ganttproject-3.2.3240/ganttproject-3.2.3240.exe"), @"D:\011714\study\ganttproject-3.2.3240.exe");
                   
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private static void Wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            Console.WriteLine(e.BytesReceived);
            
        }
    }
}
