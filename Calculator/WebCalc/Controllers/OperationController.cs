using CalcDB.Models;
using CalcDB.Repositories;
using System.Web.Mvc;

namespace WebCalc.Controllers
{
    public class OperationController : Controller
    {
        // GET: Operation
        public ActionResult Index()
        {
            var operationRepository = new BaseRepository<Operation>();
            return View(operationRepository.GetAll());
        }
    }
}