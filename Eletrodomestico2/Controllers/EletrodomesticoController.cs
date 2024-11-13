
using Eletrodomestico2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Eletrodomestico2.Controllers
{
    public class EletrodomesticoController : Controller
    {
        public IActionResult Index()
        {
            List<Eletrodomestico> eletrodomesticos = new List<Eletrodomestico>
            {
                new Geladeira {Marca = "Samsung", Modelo = "Frost Free", ConsumoEnergetico = 30, CapacidadeLitros = 525, TemFreezer = true },
                new Geladeira {Marca = "Eletrolux", Modelo = "Multidor Frost Free", ConsumoEnergetico = 50, CapacidadeLitros = 590, TemFreezer = true },
                new Geladeira {Marca = "Consul", Modelo = "Frost Free Duplex", ConsumoEnergetico = 60, CapacidadeLitros = 400, TemFreezer = true },
                new Televisor {Marca = "AOC", Modelo = "Led Full HD", ConsumoEnergetico = 110, TamanhoTela = 62, EhSmart = true},
                new Televisor {Marca = "Sansung", Modelo = "Smart TV", ConsumoEnergetico = 72, TamanhoTela = 40, EhSmart = true},
                new Televisor {Marca = "LG", Modelo = "OLED CX 4K Gaming", ConsumoEnergetico = 150, TamanhoTela = 55, EhSmart = false},
            };
            return View(eletrodomesticos);
        }
    }
}
