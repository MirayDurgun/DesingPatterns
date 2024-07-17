using DesingPattern.ChainofResponsibilty.DAL;
using DesingPattern.ChainofResponsibilty.Models;

namespace DesingPattern.ChainofResponsibilty.ChainofResponsibilty
{
	public class Treasurer : Employee
	{
		public override void ProcessRequest(CustomerProcessViewModel req)
		{
			Context context = new Context();
			CustomerProsses customerProsses = new CustomerProsses();
			if (req.Amount <= 100000)
			{
				customerProsses.Amount = req.Amount;
				customerProsses.Name = req.Name;
				customerProsses.EmployeeName = "Veznedar - Ayşe Çınar";
				customerProsses.Description = "Para çekme işlemi onaylandı, müşteriye telep ettiği tutar ödendi";
				context.CustomerProsesses.Add(customerProsses);
				context.SaveChanges();
			}
			else if (NextApprover != null)
			{
				customerProsses.Amount = req.Amount;
				customerProsses.Name = req.Name;
				customerProsses.EmployeeName = "Veznedar - Ayşe Çınar";
				customerProsses.Description = "Para çekme tutarı veznedarın günlük ödeyebileceği tutarı aştığı için işlem şube müdür yardımcısına yönlendirilmiştir";
				context.CustomerProsesses.Add(customerProsses);
				context.SaveChanges();
				NextApprover.ProcessRequest(req);
			}
		}
	}
}
