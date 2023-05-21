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

    public class HotelRepository : IHotelRepository

    {
        //public Task<bool> Add(ViewHotel hotel)
        //{
        //    throw new NotImplementedException();
        //}

        private UnitOfWork unitOfWork = new UnitOfWork();

        public async Task<IEnumerable<ViewHotel>> GetAll()
        {
            try
            {
                var result = unitOfWork.HotelRepository.Get();
                var hotelList = result.Select(item => new ViewHotel { 
                    HotelId = item.HotelId, 
                    HotelCode = item.HotelCode, 
                    Name = item.Name, 
                    Address = item.Address,
                    City = item.City, 
                    Phone = item.Phone,
                    Website = item.Website });
                return hotelList;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public async Task<IEnumerable<ViewHotel>> FilterHotels(string? name = null, int? city = null, int? rating = null)
        {
            try
            {
                var result = unitOfWork.HotelRepository.Get(filter: item => item.Name == name || item.City == city || item.RatingId == rating);
                var hotelList = result.Select(item => new ViewHotel { 
                    HotelId = item.HotelId, 
                    HotelCode = item.HotelCode,
                    Name = item.Name, 
                    Address = item.Address, 
                    City = item.City, 
                    Phone = item.Phone, 
                    Website = item.Website });
                return hotelList;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public async Task<bool> Add(ViewHotel hotel)
        {
            try
            {
                unitOfWork.HotelRepository.Insert(new Hotel { 
                    HotelCode = hotel.HotelCode, 
                    Name = hotel.Name, 
                    Address = hotel.Address, 
                    City = hotel.City, 
                    Phone = hotel.Phone,
                    Website = hotel.Website });
                unitOfWork.Save();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public async Task<bool> Update(ViewHotel hotel)
        {
            try
            {
                var model = new Hotel { 
                    HotelId = hotel.HotelId, 
                    HotelCode = hotel.HotelCode,
                    Name = hotel.Name,
                    Address = hotel.Address,
                    City = hotel.City, 
                    Phone = hotel.Phone, 
                    Website = hotel.Website };
                unitOfWork.HotelRepository.Update(model);
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

                unitOfWork.HotelRepository.Delete(id);
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
