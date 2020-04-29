using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Models;
using Service.Registration;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AalapCRUDAutomated.Controllers
{
    [Route("[controller]")]
    public class RegistrationController : Controller
    {

        private readonly IRegistrationService _iregistrationService;
      
        public RegistrationController(IRegistrationService iRegistrationService)
        {
            _iregistrationService = iRegistrationService;
        }
        // GET: Registration
        [HttpGet("[action]")]
        public async Task<ActionResult> Index()
        {
            IList<RegistrationModel> RegistrationList = new List<RegistrationModel>();
            RegistrationList = await _iregistrationService.GetAllRegistrations();
            return View(RegistrationList);
        }

        // GET: Registration/Details/5
        [HttpGet("[action]")]
        public async Task<ActionResult> Registration_Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            RegistrationModel Registration = await _iregistrationService.GetRegistrationData(id);

            if (Registration == null)
            {
                return NotFound();
            }
            return View(Registration);
        }

        // GET: Registration/Create
        [HttpGet("[action]")]
        public ActionResult Create_registration()
        {
            return View();
        }

        // POST: Registration/Create
        [ValidateAntiForgeryToken]
        [HttpPost("[action]")]
        public async Task<ActionResult> Create_registration([Bind] RegistrationModel Registration)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    await _iregistrationService.AddRegistration(Registration);
                    return RedirectToAction("Index", "Registration");
                }
                return View(_iregistrationService);
            }
            catch
            {
                return View();
            }
        }

        // GET: Registration/Edit/5
        [HttpGet("[action]")]
        public async Task<ActionResult> Edit_registration(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            RegistrationModel registration = await _iregistrationService.GetRegistrationData(id);

            if (registration == null)
            {
                return NotFound();
            }
            return View(registration);
        }

        // POST: Registration/Edit/5
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit_registration(int id, RegistrationModel Registration)
        {
            if (id != Registration.ID)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                await _iregistrationService.UpdateRegistration(Registration);
                return RedirectToAction("Index");
            }
            return View(_iregistrationService);

        }

        // GET: Registration/Delete/5
        [HttpGet("[action]")]
        public async Task<ActionResult> Delete_registration(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            RegistrationModel registration = await _iregistrationService.GetRegistrationData(id);

            if (registration == null)
            {
                return NotFound();
            }
            return View(registration);
        }

        // POST: Registration/Delete/5
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete_registration(int id, RegistrationModel Registration)
        {
            try
            {
                // TODO: Add delete logic here
                await _iregistrationService.DeleteRegistration(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}