using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LhPet.Models;
using System.ComponentModel;

namespace LhPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Cliente cliente = new Cliente(0, "Guilherme", "0123", "email@gmail.com", "sim");
        Cliente cliente1 = new Cliente(1, "Gui", "0123123", "email2@gmail.com", "nao");

        Fornecedor fornecedor = new Fornecedor(1, "for", "102321", "gmail.com");
        Fornecedor fornecedor2 = new Fornecedor(2, "for2", "02", "@@#gmail.com");

        List<Cliente> listaCliente = new List<Cliente>();
        listaCliente.Add(cliente);
        listaCliente.Add(cliente1);

        ViewBag.listaCliente = listaCliente;

        List<Fornecedor> listaFornecedor = new List<Fornecedor>();
        listaFornecedor.Add(fornecedor);
        listaFornecedor.Add(fornecedor2);

        ViewBag.listaFornecedor = listaFornecedor;

        return View();
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
