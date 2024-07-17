using DesingPattern.ChainofResponsibilty.Models;

namespace DesingPattern.ChainofResponsibilty.ChainofResponsibilty
{
	public abstract class Employee
	{
		//Responsibility" (sorumluluk), her bir bileşenin (Model, View, Controller) belirli görevlerden sorumlu olmasını ifade eder. 
		protected Employee NextApprover;
		public void SetNextApprover(Employee superVisor)
		{
			this.NextApprover = superVisor;
		}
		public abstract void ProcessRequest(CustomerProcessViewModel req);
	}
}
