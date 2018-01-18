using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class credenciamentoesController : Controller
    {
        private contexto db = new contexto();

        // GET: credenciamentoes
        public ActionResult Index()
        {
                   
            
            return View(db.credenciamentoes.ToList());
        }

        // GET: credenciamentoes/Details/5
        public ActionResult Details(int? ok)
        {
            if (ok == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            credenciamento credenciamento = db.credenciamentoes.Find(ok);
            if (credenciamento == null)
            {
                return HttpNotFound();
            }
            return View(credenciamento);
        }

        // GET: credenciamentoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: credenciamentoes/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "cpf,OK")] credenciamento credenciamento)
        {
            if (ModelState.IsValid)
            {
                db.credenciamentoes.Add(credenciamento);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(credenciamento);
        }

        // GET: credenciamentoes/Edit/5
        public ActionResult Edit(int? cpf)
        {
            if (cpf == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            credenciamento credenciamento = db.credenciamentoes.Find(cpf);
            if (credenciamento == null)
            {
                return HttpNotFound();
            }
            return View(credenciamento);
        }

        // POST: credenciamentoes/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "cpf,OK")] credenciamento credenciamento)
        {
            if (ModelState.IsValid)
            {
                db.Entry(credenciamento).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(credenciamento);
        }

        // GET: credenciamentoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            credenciamento credenciamento = db.credenciamentoes.Find(id);
            if (credenciamento == null)
            {
                return HttpNotFound();
            }
            return View(credenciamento);
        }

        // POST: credenciamentoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int cpf)
        {
            credenciamento credenciamento = db.credenciamentoes.Find(cpf);
            db.credenciamentoes.Remove(credenciamento);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
