﻿using GerenciadorLixoEletronico.NH.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GerenciadorLixoEletronico.WebSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PostoDeColeta()
        {
            ViewBag.PostosDeColeta = ConfigDB.Instance.PostoDeColetaRepository.GetAll();
            return View();
        }

        public ActionResult SolicitaColeta()
        {
            return View();
        }
    }
}