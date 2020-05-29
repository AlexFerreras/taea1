using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using propietaria_tarea1.Models;

namespace propietaria_tarea1.Controllers
{
   
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;

        public List<Operation> operations = new List<Operation>();


        public double Operate(Operation model)
        {

            return model.OperationType switch
            {
                OperationType.Addition => model.Number1 + model.Number2,
                OperationType.Division => model.Number1 / model.Number2,
                OperationType.Multiplication => model.Number1 * model.Number2,
                OperationType.Subtraction => model.Number1 - model.Number2,
                _ => 0,
            };
        }
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


       
        public IActionResult Index()
        {
           return View();
        }
        
        


        [HttpPost]
        public IActionResult Index(Operation model)
        {
            model.Result = Operate(model);

            //operations.Add(model);
               
            return View(model);
        }
      
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
