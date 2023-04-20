using GestãoDeProjeto.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestãoDeProjeto.Controllers
{
    public class ProjetoController : Controller
    {
        private static IList<Projeto> projetos =
           new List<Projeto>()
           {
                new Projeto()
                {
                    nome = "Projeto 01/2023",
                    dataInicio = "20/01/2005",
                    dataFim = "01/04/2008",
                    estimativaEmMeses = "22",
                    local = "SENAI",
                    valorProj = "130.000,00",
                    anoDeAprovacao = "2005",
                    numeroDoProj = "2345",
                    status = "Finalizado",

                },
                 new Projeto()
                {
                    nome = "Projeto 02/2023",
                    dataInicio = "20/05/2020",
                    dataFim = "01/04/2023",
                    estimativaEmMeses = "24",
                    local = "Escola Dev",
                    valorProj = "15.000,00",
                    anoDeAprovacao = "2019",
                    numeroDoProj = "2346",
                    status = "Aprovado",

                },
                  new Projeto()
                {
                    nome = "Projeto Sem numero",
                    dataInicio = "14/07/2023",
                    dataFim = "01/11/2024",
                    estimativaEmMeses = "13",
                    local = "SENAI",
                    valorProj = "3.000,00",
                    anoDeAprovacao = "00/00/0000",
                    numeroDoProj = "2389",
                    status = "Em análise",

                },
                   new Projeto()
                {
                    nome = "Projeto Robo",
                    dataInicio = "01/11/2023",
                    dataFim = "01/04/2025",
                    estimativaEmMeses = "24",
                    local = "Nao informado",
                    valorProj = "1.500,00",
                    anoDeAprovacao = "2022",
                    numeroDoProj = "2341",
                    status = "Cancelado",

                },
           };
        // GET: ProjetoController
        public ActionResult Index()
        {
            return View(projetos);
        }

        // GET: ProjetoController/Details/5
        public ActionResult Details(int id)
        {
            return View(projetos.Where(i => i.id == id).First());
        }

        // GET: ProjetoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProjetoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Projeto proj)
        {
            projetos.Add(proj);
            proj.id =
            projetos.Select(i => i.id).Max() + 1;
            return RedirectToAction("Index");
        }

        // GET: ProjetoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(projetos.Where(i => i.id == id).First());
        }

        // POST: ProjetoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Projeto proj)
        {
           projetos.Remove(projetos.Where(i => i.id == proj.id).First());
           projetos.Add(proj);
            return RedirectToAction("Index");
        }

        // GET: ProjetoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(projetos.Where(i => i.id == id).First());
        }

        // POST: ProjetoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Projeto proj)
        {
           projetos.Remove(projetos.Where(i => i.id == proj.id).First());
            return RedirectToAction("Index");
        }
    }
}
