using System.Collections.Generic;
using System.Threading.Tasks;

namespace CustomerAPI.Data 
{
    // Customer repository
    public interface ICustomerRepository
    {
        // Gets all the customers
        Task<IList<CustomerDto>> GetAll();
    }

}