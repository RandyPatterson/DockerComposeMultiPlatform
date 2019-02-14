using System;
using System.Configuration;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace DockerComposeMulti.Controllers
{
    public class HomeController : Controller
    {
        [OutputCache(NoStore = true, Location = System.Web.UI.OutputCacheLocation.None)]
        public async Task<ActionResult> Index()
        {
            using (var client = new HttpClient())
            {
                //use the environment variable 'apihost' for the base url
                //if not available, use 'apihost' from web.config
                var baseUrl = Environment.GetEnvironmentVariable("apihost") ?? ConfigurationManager.AppSettings["apihost"];
                var url = $"http://{baseUrl}/api/hostname";

                ViewBag.url = url;
                ViewBag.ApiHostName = await client.GetStringAsync(url);
            }

            return View();
        }
    }
}