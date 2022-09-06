using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SEOClick
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //if (args.Length < 1)
                //return;

            frmBrowser FBrowser = new frmBrowser();            
            FBrowser.URL = args[0];
            FBrowser.Keyword = args[1];
            FBrowser.BrowseTimeout =int.Parse( args[2]);
            FBrowser.Title = "MyCuredComputer - Computer Repair Services";
            FBrowser.PostBrowseWait =int.Parse( args[3]);
            FBrowser.HomePageLoadTime = int.Parse(args[4]);
            FBrowser.MinRadomPagesToVisit = int.Parse(args[5]);
            FBrowser.PageWaitSecs = args[6];
            Application.Run(FBrowser);
        }
    }
}
