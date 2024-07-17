using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DesingPattern.ChainofResponsibilty.Models
{
	public class CustomerProcessViewModel
	{
		//ViewModel, View ve Model arasında bir arabulucu olarak çalışır, verileri bağlar, iş mantığını içerir ve kullanıcı arayüzünün dinamik ve tepki verebilir olmasını sağlar.
		public int CustomerProssesID { get; set; }
		public string Name { get; set; }
		public int Amount { get; set; }
		public string EmployeeName { get; set; }
		public string Description { get; set; }
	}
}
