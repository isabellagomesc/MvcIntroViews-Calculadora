using Microsoft.AspNetCore.Mvc;

namespace MvcIntroViews.Controllers;

public class CalculadoraController : Controller
{
    public IActionResult Calculadora()
    {
        return View();
    }

    public IActionResult Operacao([FromForm] string operacao, [FromForm] double n1, [FromForm] double n2)
    {
        if(operacao == "Subtrair"){
            ViewBag.n1 = n1;
            ViewBag.n2 = n2;
            ViewBag.resultado = n1 - n2;
            ViewBag.operacao = operacao;
            ViewBag.sinal = "-";

            return View();
        }

        if(operacao == "Somar"){
            ViewBag.n1 = n1;
            ViewBag.n2 = n2;
            ViewBag.resultado = n1 + n2;
            ViewBag.operacao = operacao;
            ViewBag.sinal = "+";

            return View();
        }

        if(operacao == "Dividir"){
            ViewBag.n1 = n1;
            ViewBag.n2 = n2;
            ViewBag.resultado = n1 / n2;
            ViewBag.operacao = operacao;
            ViewBag.sinal = "/";

            return View();
        }

        if(operacao == "Multiplicar"){
            ViewBag.n1 = n1;
            ViewBag.n2 = n2;
            ViewBag.resultado = n1 * n2;
            ViewBag.operacao = operacao;
            ViewBag.sinal = "*";

            return View();
        }

        return View();
    }
}
