using BSBookingQuery.DAL.Entities;
using BSBookingQuery.DAL.UnitOfWorks;
using BSBookingQuery.Domain.Abastractions;
using BSBookingQuery.Domain.BusinessModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSBookingQuery.DAL.Repository
{
    public class CountryRepository : ICountryRepository
    {
        public UnitOfWork unitOfWork = new UnitOfWork();

        public async Task<IEnumerable<ViewCountry>> GetAll()
        {
            try
            {
                var result = unitOfWork.CountryRepository.Get();
                var countryList = result.Select(item => new ViewCountry
                {
                    CountryId = item.CountryId,
                    Name = item.Name,
                    IsActive = item.IsActive
                });
                return countryList;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<bool> Add(ViewCountry country)
        {
            try
            {
                unitOfWork.CountryRepository.Insert(new Country
                {
                    Name = country.Name,
                    IsActive = country.IsActive
                });
                unitOfWork.Save();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public async Task<bool> Update(ViewCountry country)
        {
            try
            {
                var model = new Country
                {
                    CountryId = country.CountryId,
                    Name = country.Name,
                    IsActive = country.IsActive
                };
                unitOfWork.CountryRepository.Update(model);
                unitOfWork.Save();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> Delete(int id)
        {
            try
            {

                unitOfWork.CountryRepository.Delete(id);
                unitOfWork.Save();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
