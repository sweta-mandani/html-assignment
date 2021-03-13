using HMS.DAL.Repository.Interfaces;
using HMS.Models.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
namespace HMS.DAL.Repository.Classes
{
    public class RoomRepository : IRoomRepository
    {
        enum StatusOfBooking
        {
            Optional,
            Definitive,
            Cancelled,
            Deleted
        }
        private readonly Database.HotelEntities _dbContext;
        public RoomRepository()
        {
            _dbContext = new Database.HotelEntities();
        }

        public string bookRoom(Booking model)
        {
            try
            {
                if (model!=null)
                {
                    var bookingRecord = _dbContext.Bookings.Where(m => m.Room_id == model.Room_id && DbFunctions.TruncateTime(m.BookingDate) == model.BookingDate).FirstOrDefault();
                    if (bookingRecord == null)
                    {
                        Database.Booking booking = new Database.Booking();
                        booking.Room_id = model.Room_id;
                        booking.StatusOfBooking = StatusOfBooking.Optional.ToString();
                        booking.BookingDate = model.BookingDate;
                        _dbContext.Bookings.Add(booking);
                        _dbContext.SaveChanges();
                        return "Booking of room no " + model.Room_id + " has been confirmed on " + model.BookingDate + " with optional status";
                    }
                    else
                    {
                        return "Room is already booked on "+ model.BookingDate;
                    }
                }
                return "ID and date can are required";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public bool checkRoomAvailability(int id, DateTime date)
        {
            try
            {
                if (id != null && date != null)
                {
                    var bookingRecord=_dbContext.Bookings.Where(m => m.Room_id==id && DbFunctions.TruncateTime(m.BookingDate)==date).FirstOrDefault();
                    if (bookingRecord == null)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                return false;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public string createRoom(Room entity)
        {
            try
            {
                if (entity != null)
                {
                    Mapper.CreateMap<Room, Database.Room>();
                    Database.Room room = Mapper.Map<Database.Room>(entity);
                    _dbContext.Rooms.Add(room);
                    _dbContext.SaveChanges();

                    return "Room Successfully Added!!";
                }
                return "Model is null!!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Room> searchRoom(string city = null, decimal? pincode = null, int? price = null, string category = null)
        {
            
            var entities = _dbContext.Rooms.ToList();
            List<Room> list = new List<Room>();
            if (entities != null)
            {
                foreach (var item in entities)
                {
                    Mapper.CreateMap<Database.Room,Room>();
                    Room room = Mapper.Map<Room>(item);
                    list.Add(room);
                }
            }
            return list;
            /*try
            {
                var bookingRecord = _dbContext.Bookings.Where(m => m.city == city || DbFunctions.TruncateTime(m.BookingDate) == date).FirstOrDefault();
                if (bookingRecord == null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }*/
        }

    }
}
