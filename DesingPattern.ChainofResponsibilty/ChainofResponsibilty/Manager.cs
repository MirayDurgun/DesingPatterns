using DesingPattern.ChainofResponsibilty.DAL;
using DesingPattern.ChainofResponsibilty.Models;

namespace DesingPattern.ChainofResponsibilty.ChainofResponsibilty
{
	public class Manager : Employee
	{
		public override void ProcessRequest(CustomerProcessViewModel req)
		{
			Context context = new Context();
			CustomerProsses customerProsses = new CustomerProsses();
			if (req.Amount <= 250000)
			{
				customerProsses.Amount = req.Amount;
				customerProsses.Name = req.Name;
				customerProsses.EmployeeName = "Şube Müdürü - Yaren Çilek ";
				customerProsses.Description = "Para çekme işlemi onaylandı, müşteriye telep ettiği tutar ödendi";
				context.CustomerProsesses.Add(customerProsses);
				context.SaveChanges();
			}
			else if (NextApprover != null)
			{
				customerProsses.Amount = req.Amount;
				customerProsses.Name = req.Name;
				customerProsses.EmployeeName = "Şube Müdürü - Yaren Çilek";
				customerProsses.Description = "Para çekme tutarı şube müdürünün günlük ödeyebileceği tutarı aştığı için işlem bölge müdürüne yönlendirilmiştir";
				context.CustomerProsesses.Add(customerProsses);
				context.SaveChanges();
				NextApprover.ProcessRequest(req);
			}
		}
	}
}
