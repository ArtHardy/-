using CalcDB.Models;
using CalcDB.Repositories;
using System.Web.Mvc;
using System.Linq;
using WebCalc.Models;

namespace WebCalc.Controllers
{
    [Authorize]
    public class OperationController : Controller
    {
        // GET: Operation
        public ActionResult Index()
        {
            var operationRepository = new BaseRepository<Operation>();
            var dbOperations = operationRepository.GetAll();
            var operations = dbOperations.Select(o => new OperationViewModel()
            {
                Id = o.Id,
                Name = o.Name,
                OwnerId = o.OwnerId
            });

            return View(operations);
        }
    }
}