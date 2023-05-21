using BSBookingQuery.DAL.Entities;
using BSBookingQuery.DAL.GenericRepository;
using BSBookingQuery.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSBookingQuery.DAL.UnitOfWorks
{
    public class UnitOfWork : IDisposable
    {
        private HotelBookingDbContext context = new HotelBookingDbContext();
        private GenericRepository<Hotel> hotelRepository;
        private GenericRepository<Room> roomRepository;
        private GenericRepository<City> cityRepository;
        private GenericRepository<Booking> bookingRepository;
        private GenericRepository<BookingDetail> bookingDetailRepository;
        private GenericRepository<Country> countryRepository;
        private GenericRepository<Comment> commentRepository;
        private GenericRepository<Guest> guestRepository;
        private GenericRepository<Position> positionRepository;
        private GenericRepository<Rating> ratingRepository;
        private GenericRepository<RoomType> roomTypeRepository;
        private GenericRepository<Staff> staffRepository;
        public GenericRepository<Hotel> HotelRepository
        {
            get
            {
                if (this.hotelRepository == null)
                {
                    this.hotelRepository = new GenericRepository<Hotel>(context);
                }
                return hotelRepository;
            }
        }

        public GenericRepository<Room> RoomRepository
        {
            get
            {
                if (this.roomRepository == null)
                {
                    this.roomRepository = new GenericRepository<Room>(context);
                }
                return roomRepository;
            }
        }

        public GenericRepository<City> CityRepository
        {
            get
            {
                if (this.cityRepository == null)
                {
                    this.cityRepository = new GenericRepository<City>(context);
                }
                return cityRepository;
            }
        }

        public GenericRepository<Booking> BookingRepository
        {
            get
            {
                if (this.bookingRepository == null)
                {
                    this.bookingRepository = new GenericRepository<Booking>(context);
                }
                return bookingRepository;
            }
        }

        public GenericRepository<BookingDetail> BookingDetailRepository
        {
            get
            {
                if (this.bookingDetailRepository == null)
                {
                    this.bookingDetailRepository = new GenericRepository<BookingDetail>(context);
                }
                return bookingDetailRepository;
            }
        }

        public GenericRepository<Comment> CommentRepository
        {
            get
            {
                if (this.commentRepository == null)
                {
                    this.commentRepository = new GenericRepository<Comment>(context);
                }
                return commentRepository;
            }
        }

        public GenericRepository<Country> CountryRepository
        {
            get
            {
                if (this.countryRepository == null)
                {
                    this.countryRepository = new GenericRepository<Country>(context);
                }
                return countryRepository;
            }
        }

        public GenericRepository<Guest> GuestRepository
        {
            get
            {
                if (this.guestRepository == null)
                {
                    this.guestRepository= new GenericRepository<Guest>(context);
                }
                return guestRepository;
            }
        }

        public GenericRepository<Position> PositionRepository
        {
            get
            {
                if (this.positionRepository == null)
                {
                    this.positionRepository  = new GenericRepository<Position>(context);
                }
                return positionRepository;
            }
        }

        public GenericRepository<Rating> RatingRepository
        {
            get
            {
                if (this.ratingRepository == null)
                {
                    this.ratingRepository= new GenericRepository<Rating>(context);
                }
                return ratingRepository;
            }
        }

        public GenericRepository<RoomType> RoomTypeRepository
        {
            get
            {
                if (this.roomTypeRepository == null)
                {
                    this.roomTypeRepository = new GenericRepository<RoomType>(context);
                }
                return roomTypeRepository;
            }
        }

        public GenericRepository<Staff> StaffRepository
        {
            get
            {
                if (this.staffRepository == null)
                {
                    this.staffRepository = new GenericRepository<Staff>(context);
                }
                return staffRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
