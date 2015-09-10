using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Channels;
using System.Web;

namespace CaLottoApi.Services
{
    public class LottoService
    {

        public void GetTodaysNumbers(string path)
        {
            var webClient = new WebClient();
            webClient.DownloadFile("http://www.calottery.com/sitecore/content/Miscellaneous/download-numbers/?GameName=daily-3&Order=No", path );






        }

            
    }
}