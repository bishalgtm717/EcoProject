using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Microsoft.eShopWeb.Web.Controllers;
public class BankDetailsController : Controller
{
    // GET: BankDetailsController
    public ActionResult PayAmount()
    {
        return View();
    }

    // GET: BankDetailsController/Details/5
    public ActionResult Details(int id)
    {
        return View();
    }

    // GET: BankDetailsController/Create
    public ActionResult Create()
    {
        return View();
    }

    // POST: BankDetailsController/Create
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

    // GET: BankDetailsController/Edit/5
    public ActionResult Edit(int id)
    {
        return View();
    }

    // POST: BankDetailsController/Edit/5
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

    // GET: BankDetailsController/Delete/5
    public ActionResult Delete(int id)
    {
        return View();
    }

    // POST: BankDetailsController/Delete/5
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
