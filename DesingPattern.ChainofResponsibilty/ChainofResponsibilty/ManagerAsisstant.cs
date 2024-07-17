using DesingPattern.ChainofResponsibilty.DAL;
using DesingPattern.ChainofResponsibilty.Models;

namespace DesingPattern.ChainofResponsibilty.ChainofResponsibilty
{
	public class ManagerAsisstant : Employee
	{
		public override void ProcessRequest(CustomerProcessViewModel req)
		{
			Context context = new Context();
			CustomerProsses customerProsses = new CustomerProsses();
			if (req.Amount <= 150000)
			{
				customerProsses.Amount = req.Amount;
				customerProsses.Name = req.Name;
				customerProsses.EmployeeName = "Şube Müdür Yardımcısı - Ekim Altun";
				customerProsses.Description = "Para çekme işlemi onaylandı, müşteriye telep ettiği tutar ödendi";
				context.CustomerProsesses.Add(customerProsses);
				context.SaveChanges();
			}
			else if (NextApprover != null)
			{
				customerProsses.Amount = req.Amount;
				customerProsses.Name = req.Name;
				customerProsses.EmployeeName = "Şube Müdür Yardımcısı - Ekim Altun";
				customerProsses.Description = "Para çekme tutarı şube müdür yardımcısının günlük ödeyebileceği tutarı aştığı için işlem şube müdürüne önlendirilmiştir";
				context.CustomerProsesses.Add(customerProsses);
				context.SaveChanges();
				NextApprover.ProcessRequest(req);
			}
		}
	}
}
