using BSBookingQuery.DAL.UnitOfWorks;
using BSBookingQuery.Domain.Abastractions;
using BSBookingQuery.Domain.BusinessModels;
using BSBookingQuery.DAL.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSBookingQuery.DAL.Repository
{
    public class BookingRepository : IBookingRepository
    {
        public UnitOfWork unitOfWork = new UnitOfWork();

        public async Task<IEnumerable<ViewBooking>> GetAll()
        {
            try
            {
                var result = unitOfWork.BookingRepository.Get();
                var bookingList = result.Select(item => new ViewBooking { 
                    BookingId = item.BookingId, 
                    HotelId = item.HotelId, 
                    GuestId = item.GuestId, 
                    IsActive = item.IsActive });
                return bookingList;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<bool> Add(ViewBooking booking)
        {
            try
            {
                var model = new Booking();
                var rooms = new List<Room>();
                model.GuestId = booking.GuestId;
                model.HotelId  = booking.HotelId;
                model.IsActive = booking.IsActive;
                foreach (var item in booking.BookingDetails)
                {
                    var detail = new BookingDetail
                    {
                        RoomId = item.RoomId,
                        DateFrom = item.DateFrom,
                        DateTo = item.DateTo,
                        IsActive= item.IsActive
                    };
                    model.BookingDetails.Add(detail);
                    var room = new Room { RoomId = item.RoomId ?? 0, RoomStatus = false };
                    rooms.Add(room);
                }
                unitOfWork.BookingRepository.Insert(model);
                foreach (var room in rooms)
                {
                    unitOfWork.RoomRepository.Update(room);
                }
                unitOfWork.Save();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> Update(ViewBooking booking)
        {
            try
            {
                var bookingDetails = new List<BookingDetail>();
                var model = new Booking { 
                    BookingId = booking.BookingId,
                    HotelId = booking.HotelId, 
                    GuestId = booking.GuestId, 
                    IsActive = booking.IsActive };
                foreach (var item in booking.BookingDetails)
                {
                    var detail = new BookingDetail
                    {
                        BookingDetailId = item.BookingDetailId,
                        BookingId = model.BookingId,
                        RoomId = item.RoomId,
                        DateFrom = item.DateFrom,
                        DateTo = item.DateTo,
                        IsActive = item.IsActive,
                        BookingStatusId = item.BookingStatusId
                    };
                    bookingDetails.Add(detail);
                }
                foreach(var item in bookingDetails)
                {
                    unitOfWork.BookingDetailRepository.Update(item);
                }
                
                unitOfWork.BookingRepository.Update(model);
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
                var bookingDetails = unitOfWork.BookingDetailRepository.Get(filter: item => item.BookingId == id);
                foreach (var detail in bookingDetails)
                {
                    unitOfWork.BookingDetailRepository.Delete(detail.BookingDetailId);
                }
                unitOfWork.BookingRepository.Delete(id);
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
