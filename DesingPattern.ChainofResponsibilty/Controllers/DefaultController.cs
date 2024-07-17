using DesingPattern.ChainofResponsibilty.ChainofResponsibilty;
using DesingPattern.ChainofResponsibilty.Models;
using Microsoft.AspNetCore.Mvc;

namespace DesingPattern.ChainofResponsibilty.Controllers
{
	public class DefaultController : Controller
	{
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index(CustomerProcessViewModel model)
		{
			Employee treasurer = new Treasurer();
			Employee managerAsisstant = new ManagerAsisstant();
			Employee manager = new Manager();
			Employee areaDirector = new AreaDirector();

			//birbirlerini işaret edecekler
			//bu zincirde bir problem yaşanırsa kopmadan devam etmesini sağlar
			treasurer.SetNextApprover(managerAsisstant);
			managerAsisstant.SetNextApprover(manager);
			manager.SetNextApprover(areaDirector);

			//modelden gelen değer ile beraber isteği başlat
			treasurer.ProcessRequest(model);
			return View();
		}
	}
}
