using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using LottoApi;

namespace LotterRetrieval
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                const string path = "M:\\Users\\May\\Documents\\Visual Studio 2013\\Projects\\CaLottoApi\\LottoApi\\Content\\Results.txt";
                var webClient = new WebClient();
                webClient.DownloadFile("http://www.calottery.com/sitecore/content/Miscellaneous/download-numbers/?GameName=daily-3&Order=No", path);
            }
            catch (Exception e)
            {
                try
                {
                    var appLog = new EventLog { Source = "LotteryRetrieval" };
                    appLog.WriteEntry("message:" + e.Message,EventLogEntryType.Error);
                }
                catch (Exception)
                {
                    
                    throw;
                }
               
            }
            
           
           
        }
    }
}
