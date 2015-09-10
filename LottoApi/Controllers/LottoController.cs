using System.Net;
using System.Net.Http;
using System.Web.Http;
using LottoApi.Services;

namespace LottoApi.Controllers
{
    public class LottoController : ApiController
    {
       

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("GetTodaysNumbers")]
        public HttpResponseMessage GetTodaysNumbers()
        {
            var c = WebApiApplication.LottoPath;
           var lottoService = new LottoService();
           var results =  lottoService.GetTodaysNumbers(WebApiApplication.LottoPath);
            return Request.CreateResponse(HttpStatusCode.OK, results);


        }
    }
}