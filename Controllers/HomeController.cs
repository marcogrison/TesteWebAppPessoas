using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;
using WebApplication1.Servicos;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ServicoPessoa _servicoPessoa;

        public HomeController(ILogger<HomeController> logger, ServicoPessoa servicoPessoa)
        {
            _logger = logger;
            _servicoPessoa = servicoPessoa;
        }

        public IActionResult Index()
        {
            //Toda vez que é iniciado o programa ele cria as idades aleatoriamente e aqui trata para pegar apenas as com 30 anos ou mais
            var pessoas = _servicoPessoa.CriarPessoas().Where(p => p.Idade >= 30).ToList();
            return View(pessoas);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}