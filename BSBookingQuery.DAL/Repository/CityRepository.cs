using BSBookingQuery.DAL.Entities;
using BSBookingQuery.DAL.UnitOfWorks;
using BSBookingQuery.Domain.Abastractions;
using BSBookingQuery.Domain.BusinessModels;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSBookingQuery.DAL.Repository
{

    public class CityRepository : ICityRepository

    {
        //public Task<bool> Add(ViewHotel hotel)
        //{
        //    throw new NotImplementedException();
        //}

        private UnitOfWork unitOfWork = new UnitOfWork();

        public async Task<IEnumerable<ViewCity>> GetAll()
        {
            try
            {
                var result = unitOfWork.CityRepository.Get();
                var cityList = result.Select(item => new ViewCity
                {
                    CityId = item.CityId,
                    CountryId = item.CountryId,
                    Name = item.Name,
                    IsActive = item.IsActive
                });
                return cityList;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<bool> Add(ViewCity city)
        {
            try
            {
                unitOfWork.CityRepository.Insert(new City
                {
                    Name = city.Name,
                    CountryId = city.CountryId,
                    IsActive = city.IsActive
                });
                unitOfWork.Save();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> Update(ViewCity city)
        {
            try
            {
                var model = new City { 
                    CityId = city.CityId, 
                    CountryId = city.CountryId, 
                    Name = city.Name, 
                    IsActive = city.IsActive };
                unitOfWork.CityRepository.Update(model);
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

                unitOfWork.CityRepository.Delete(id);
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
