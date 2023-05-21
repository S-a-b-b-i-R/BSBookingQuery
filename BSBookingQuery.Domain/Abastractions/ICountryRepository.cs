using BSBookingQuery.Domain.BusinessModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSBookingQuery.Domain.Abastractions
{
    public interface ICountryRepository
    {
        Task<IEnumerable<ViewCountry>> GetAll();
        Task<bool> Add(ViewCountry country);
        Task<bool> Update(ViewCountry country);
        Task<bool> Delete(int id);
    }
}
