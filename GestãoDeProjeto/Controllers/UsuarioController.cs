using GestãoDeProjeto.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace GestãoDeProjeto.Controllers
{
    public class UsuarioController : Controller
    {

        private static IList<Usuario> usuarios =
            new List<Usuario>()
            {
                new Usuario()
                {
                    id = 1,
                    nome = "Fulano Beltrano",
                    status = "Ativo",
                    dataNasc = "12/12/2000",
                    endereco ="Rua 1 lot500 nº21",
                    email="email@email.com",
                    cargo="Gerente",
                },
                new Usuario()
                {
                    id = 2,
                    nome = "Cicrano Jose",
                    status = "Ativo",
                    dataNasc = "12/12/1995",
                    endereco ="Rua 3 lot520 nº22",
                    email="email2@email.com",
                    cargo="Assistente",
                },
                new Usuario()
                {
                    id = 3,
                    nome = "Jumarque Filino",
                    status = "Ativo",
                    dataNasc = "01/02/1998",
                    endereco ="Rua Lagarto nº 56",
                    email="emaillegal@email.com",
                    cargo="Desenvolvedor",
                },
                new Usuario()
                {
                    id = 4,
                    nome = "Juberto Berto",
                    status = "Ativo",
                    dataNasc = "21/02/2003",
                    endereco ="Rua Siqueira nº11",
                    email="emailgenerico@email.com",
                    cargo="Assistente de Negocios",
                },
                new Usuario()
                {
                    id = 5,
                    nome = "Phoenix Baker",
                    status = "Ativo",
                    dataNasc = "22/05/1989",
                    endereco ="Rua Viseira  nº22",
                    email="phoenix@email.com",
                    cargo="Produtor",
                },
                new Usuario()
                {
                    id = 6,
                    nome = "Lana Steiner",
                    status = "Ativo",
                    dataNasc = "26/08/1999",
                    endereco ="Rua Cimero nº2112",
                    email="lanast@email.com",
                    cargo="UX Designer",
                },
                new Usuario()
                {
                    id = 7,
                    nome = "Candice Wu",
                    status = "Ativo",
                    dataNasc = "11/12/2002",
                    endereco ="Rua Jupte nº2231",
                    email="candicewu@email.com",
                    cargo="UX Copywriter",
                },
                new Usuario()
                {
                    id = 8,
                    nome = "Orlando Diggs",
                    status = "Ativo",
                    dataNasc = "21/06/1989",
                    endereco ="Rua Palmeira nº500",
                    email="orlando@email.com",
                    cargo="Product Designer",
                },
            };
        // GET: UsuarioController
        public ActionResult Index()
        {
            return View(usuarios);
        }

        // GET: UsuarioController/Details/5
        public ActionResult Details(int id)
        {
            return View(usuarios.Where(i => i.id == id).First());
        }

        // GET: UsuarioController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UsuarioController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Usuario user)
        {

                usuarios.Add(user);
                user.id =
                usuarios.Select(i=> i.id).Max() + 1;
                return RedirectToAction("Index");

        }

        // GET: UsuarioController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(usuarios.Where(i=> i.id == id).First());
        }

        // POST: UsuarioController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Usuario user)
        {
            usuarios.Remove(usuarios.Where(i => i.id == user.id).First());
            usuarios.Add(user);
            return RedirectToAction("Index");

        }

        // GET: UsuarioController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(usuarios.Where(i => i.id == id).First());
        }

        // POST: UsuarioController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Usuario user)
        {
            usuarios.Remove(usuarios.Where(i => i.id == user.id).First());
            return RedirectToAction("Index");
        }
    }
}
