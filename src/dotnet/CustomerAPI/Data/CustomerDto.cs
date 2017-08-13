
namespace CustomerAPI.Data
{
    public class CustomerDto
    {
         public int ID { get; internal set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public decimal MonthlyLimit { get; set; }

        public bool Deleted { get; set; }


        public CustomerDto()
        {

        }
        
    }
}