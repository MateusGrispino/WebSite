using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSite_FormValidacao.Dados;
using WebSite_FormValidacao.Models;

namespace WebSite_FormValidacao.Controllers
{
    public class HomeController : Controller
    {
        //acoes
        AcQuestionario acQuestionario = new AcQuestionario();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Questionario()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Questionario(QuestionarioModel resposta)
        {
            try
            {
                acQuestionario.inserirOrcamento(resposta);
                return RedirectToAction("Obrigado");
            }
            catch { return View(); }
            
        }

        public ActionResult Obrigado()
        {
            return View();
        }

        public ActionResult Contato()
        {
            return View();
        }

    }
}