using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using Service.Registration;
using System.Collections.Generic;
using System.Linq;

namespace AalapCRUDAutomated.Controllers
{
    [Route("[controller]")]
    public class RegistrationController : Controller
    {

        private IRegistrationService iregistrationService;

        public RegistrationController(IRegistrationService iRegistrationService)
        {
            iregistrationService = iRegistrationService;
        }
        // GET: Registration
        [HttpGet("[action]")]
        public ActionResult Index()
        {
            List<RegistrationModel> RegistrationList = new List<RegistrationModel>();
            RegistrationList = iregistrationService.GetAllRegistrations().ToList();
            return View(RegistrationList);
        }

        // GET: Registration/Details/5
        [HttpGet("[action]")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            RegistrationModel Registration = iregistrationService.GetRegistrationData(id);

            if (Registration == null)
            {
                return NotFound();
            }
            return View(Registration);
        }

        // GET: Registration/Create
        [HttpGet("[action]")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Registration/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [HttpGet("[action]")]
        public ActionResult Create([Bind] RegistrationModel Registration)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    iregistrationService.AddRegistration(Registration);
                    return RedirectToAction("Index", "Registration");
                }
                return View(iregistrationService);
            }
            catch
            {
                return View();
            }
        }

        // GET: Registration/Edit/5
        [HttpGet("[action]")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            RegistrationModel registration = iregistrationService.GetRegistrationData(id);

            if (registration == null)
            {
                return NotFound();
            }
            return View(registration);
        }

        // POST: Registration/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [HttpGet("[action]")]
        public ActionResult Edit(int id, RegistrationModel Registration)
        {
            if (id != Registration.ID)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                iregistrationService.UpdateRegistration(Registration);
                return RedirectToAction("Index");
            }
            return View(iregistrationService);

        }

        // GET: Registration/Delete/5
        [HttpGet("[action]")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            RegistrationModel registration = iregistrationService.GetRegistrationData(id);

            if (registration == null)
            {
                return NotFound();
            }
            return View(registration);
        }

        // POST: Registration/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [HttpGet("[action]")]
        public ActionResult Delete(int id, RegistrationModel Registration)
        {
            try
            {
                // TODO: Add delete logic here
                iregistrationService.DeleteRegistration(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}