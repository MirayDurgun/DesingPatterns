using DesingPattern.ChainofResponsibilty.DAL;
using DesingPattern.ChainofResponsibilty.Models;

namespace DesingPattern.ChainofResponsibilty.ChainofResponsibilty
{
	public class AreaDirector : Employee
	{
		public override void ProcessRequest(CustomerProcessViewModel req)
		{
			Context context = new Context();
			CustomerProsses customerProsses = new CustomerProsses();
			if (req.Amount <= 400000)
			{
				customerProsses.Amount = req.Amount;
				customerProsses.Name = req.Name;
				customerProsses.EmployeeName = "Bölge Direktörü - Melih Can Durgun ";
				customerProsses.Description = "Para çekme işlemi onaylandı, müşteriye telep ettiği tutar ödendi";
				context.CustomerProsesses.Add(customerProsses);
				context.SaveChanges();
			}
			else if (NextApprover != null)
			{
				customerProsses.Amount = req.Amount;
				customerProsses.Name = req.Name;
				customerProsses.EmployeeName = "Bölge Direktörü - Melih Can Durgun";
				customerProsses.Description = "Para çekme tutarı bölge direktörünün günlük ödeyebileceği tutarı aştığı için işlem gerçekleştirilemedi, müşterinin günlük maksimum çekebileceği tutar 400.000 TL olup daha fazlası için birden fazla gün şubeye gitmesi gerekmektedir.";
				context.CustomerProsesses.Add(customerProsses);
				context.SaveChanges();
			}
		}
	}
}