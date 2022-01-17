using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Microsoft.eShopWeb.Web.Controllers;
public class Proceed : Controller
{
    // GET: Proceed
    public ActionResult ProceedActions()
    {
        return View();
    }

    // GET: Proceed/Details/5
    public ActionResult Details(int id)
    {
        return View();
    }

    // GET: Proceed/Create
    public ActionResult Create()
    {
        return View();
    }

    // POST: Proceed/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create(IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }

    // GET: Proceed/Edit/5
    public ActionResult Edit(int id)
    {
        return View();
    }

    // POST: Proceed/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(int id, IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }

    // GET: Proceed/Delete/5
    public ActionResult Delete(int id)
    {
        return View();
    }

    // POST: Proceed/Delete/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Delete(int id, IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }
}
