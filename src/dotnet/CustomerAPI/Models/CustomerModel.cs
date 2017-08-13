using CustomerAPI.Data;

namespace CustomerAPI.Models
{

    public class CustomerModel
    {
        public int ID { get; internal set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public decimal MonthlyLimit { get; set; }

        public bool Deleted { get; set; }

        public CustomerModel()
        {
            
        }

        public CustomerModel(CustomerDto dto)
        {
            
            this.ID = dto.ID;
            this.FirstName = dto.FirstName;
            this.LastName = dto.LastName;
            this.MonthlyLimit = dto.MonthlyLimit;
            this.Deleted = dto.Deleted;
        }
    }
}