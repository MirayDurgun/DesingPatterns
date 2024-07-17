using DesingPattern.ChainofResponsibilty.Models;

namespace DesingPattern.ChainofResponsibilty.ChainofResponsibilty
{
	public abstract class Employee
	{
		protected Employee NextApprover;
		public void SetNextApprover(Employee superVisor)
		{
			this.NextApprover = superVisor;
		}
		public abstract void ProcessRequest(CustomerProcessViewModel req);
	}
}
