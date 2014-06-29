using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Clony_Exemplo.Models;

namespace Clony_Exemplo.Controllers
{
    public class MembrosController : Controller
    {
        private MembroDBContext db = new MembroDBContext();

        //
        // GET: /Membros/

        public ActionResult Index()
        {
            return View(db.Membros.ToList());
        }

        [HttpPost]
        public ActionResult Index(string searchString)
        {
            var membros = from m in db.Membros
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                membros = membros.Where(s => s.Nome.Contains(searchString));
            }

            return View(membros);
        }


        //
        // GET: /Membros/Details/5

        public ActionResult Details(int id = 0)
        {
            Membro membro = db.Membros.Find(id);
            if (membro == null)
            {
                return HttpNotFound();
            }
            return View(membro);
        }

        //
        // GET: /Membros/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Membros/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Membro membro)
        {
            if (ModelState.IsValid)
            {
                db.Membros.Add(membro);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(membro);
        }

        //
        // GET: /Membros/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Membro membro = db.Membros.Find(id);
            if (membro == null)
            {
                return HttpNotFound();
            }
            return View(membro);
        }

        //
        // POST: /Membros/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Membro membro)
        {
            if (ModelState.IsValid)
            {
                db.Entry(membro).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(membro);
        }

        //
        // GET: /Membros/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Membro membro = db.Membros.Find(id);
            if (membro == null)
            {
                return HttpNotFound();
            }
            return View(membro);
        }

        //
        // POST: /Membros/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Membro membro = db.Membros.Find(id);
            db.Membros.Remove(membro);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}