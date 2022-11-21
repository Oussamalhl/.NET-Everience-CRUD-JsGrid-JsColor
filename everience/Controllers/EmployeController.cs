using Eve.Domain;
using Eve.Service;
using Microsoft.AspNetCore.Mvc;

namespace everience.Controllers
{
    public class EmployeController : Controller
    {
        IEmployeService employeService;

        public EmployeController(IEmployeService employeService) 
        {
            this.employeService = employeService;
        }

        public IActionResult Index()
        {
            return View(employeService.GetAll());
        }

        public IActionResult Details(int id)
        {
            if (id!=null)
              return View(employeService.GetById(id));
            
            return NotFound();
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Employe employe,IFormFile formFile) 
        {
            try
            {
                employeService.Add(employe);
                employeService.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
            
        }

        public  IActionResult Edit(int id)
        {
            if (id != null)
            {
                Employe employe=employeService.GetById(id);
                return View(employe);
            }
            return NotFound();
        }
	

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit (int id, Employe employe)
        {
            try
            {
                employe.empId= id;
                employeService.Update(employe);
                employeService.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public IActionResult Delete(int id)
        {
            if (id != null)
            {
                Employe employe = employeService.GetById(id);
                return View(employe);
            }
            return NotFound();
        }


            [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, Employe employe)
        {
            try
            {
                employe.empId= id;
                employeService.Delete(employe);
                employeService.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
