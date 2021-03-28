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
<<<<<<< HEAD
        enum StatusOfBooking 
=======
        enum BookingsStatus
>>>>>>> 629a58571175ef9707ce094f74f8f06f26139812
        {
            Optional,
            Definitive,
            Cancelled,
            Deleted
        }
<<<<<<< HEAD
        private readonly Database.HotelEntities _dbContext;
        public RoomRepository()
        {
            _dbContext = new Database.HotelEntities();
=======
        private readonly Database.WebDBEntities _dbContext;
        public RoomRepository()
        {
            _dbContext = new Database.WebDBEntities();
>>>>>>> 629a58571175ef9707ce094f74f8f06f26139812
        }

        public string bookRoom(Booking model)
        {
            try
            {
                if (model!=null)
                {
<<<<<<< HEAD
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
=======
                    var bookingRecord = _dbContext.Booking_Detail.Where(m => m.RoomId == model.RoomId && DbFunctions.TruncateTime(m.BookingDate) == model.BookingDate).FirstOrDefault();
                    if (bookingRecord == null)
                    {
                        Database.Booking_Detail booking = new Database.Booking_Detail();
                        booking.RoomId = model.RoomId;
                        booking.BookingsStatus = BookingsStatus.Optional.ToString();
                        booking.BookingDate = model.BookingDate;
                        _dbContext.Booking_Detail.Add(booking);
                        _dbContext.SaveChanges();
                        return "Booking of room no " + model.RoomId + " has been confirmed on " + model.BookingDate + " with optional status";
>>>>>>> 629a58571175ef9707ce094f74f8f06f26139812
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
<<<<<<< HEAD
                    var bookingRecord=_dbContext.Bookings.Where(m => m.Room_id==id && DbFunctions.TruncateTime(m.BookingDate)==date).FirstOrDefault();
=======
                    var bookingRecord=_dbContext.Booking_Detail.Where(m => m.RoomId==id && DbFunctions.TruncateTime(m.BookingDate)==date).FirstOrDefault();
>>>>>>> 629a58571175ef9707ce094f74f8f06f26139812
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
<<<<<<< HEAD
                    Mapper.CreateMap<Room, Database.Room>();
                    Database.Room room = Mapper.Map<Database.Room>(entity);
                    _dbContext.Rooms.Add(room);
=======
                    Mapper.CreateMap<Room, Database.Room_Details>();
                    Database.Room_Details room = Mapper.Map<Database.Room_Details>(entity);
                    _dbContext.Room_Details.Add(room);
>>>>>>> 629a58571175ef9707ce094f74f8f06f26139812
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
            
<<<<<<< HEAD
            var entities = _dbContext.Rooms.ToList();
=======
            var entities = _dbContext.Room_Details.ToList();
>>>>>>> 629a58571175ef9707ce094f74f8f06f26139812
            List<Room> list = new List<Room>();
            if (entities != null)
            {
                foreach (var item in entities)
                {
<<<<<<< HEAD
                    Mapper.CreateMap<Database.Room,Room>();
=======
                    Mapper.CreateMap<Database.Room_Details,Room>();
>>>>>>> 629a58571175ef9707ce094f74f8f06f26139812
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
