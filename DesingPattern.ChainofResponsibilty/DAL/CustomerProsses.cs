using Microsoft.AspNetCore.Mvc;

namespace DesingPattern.ChainofResponsibilty.DAL
{
    public class CustomerProsses
    {

        public int CustomerProssesID { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public string EmployeeName { get; set; }
        public string Description { get; set; }
    }
}
