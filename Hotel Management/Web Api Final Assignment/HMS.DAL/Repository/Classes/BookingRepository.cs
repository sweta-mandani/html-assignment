using HMS.DAL.Repository.Interfaces;
using HMS.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
namespace HMS.DAL.Repository.Classes
{
    public class BookingRepository : IBookingRepository
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
        public BookingRepository()
        {
            _dbContext = new Database.HotelEntities();
=======
        private readonly Database.WebDBEntities _dbContext;
        public BookingRepository()
        {
            _dbContext = new Database.WebDBEntities();
>>>>>>> 629a58571175ef9707ce094f74f8f06f26139812
        }

        public string deleteBooking(Booking model)
        {
            try
            {
                if (model.BookingId != null)
                {
<<<<<<< HEAD
                    Database.Booking booking = _dbContext.Bookings.Find(model.BookingId);
                    if (booking != null)
                    {
                        booking.StatusOfBooking = StatusOfBooking.Deleted.ToString();
=======
                    Database.Booking_Detail booking = _dbContext.Booking_Detail.Find(model.BookingId);
                    if (booking != null)
                    {
                        booking.BookingsStatus = BookingsStatus.Deleted.ToString();
>>>>>>> 629a58571175ef9707ce094f74f8f06f26139812
                        _dbContext.SaveChanges();
                        return "Status of Booking id " + model.BookingId + " has been changed to deleted";
                     }
                    else
                    {
                        return "Booking No "+ model.BookingId + " is not there nothing to delete";
                    }
                }
                return "Booking id is empty";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Booking> getAllBooking()
        {
<<<<<<< HEAD
            var entities = _dbContext.Bookings.ToList();
=======
            var entities = _dbContext.Booking_Detail.ToList();
>>>>>>> 629a58571175ef9707ce094f74f8f06f26139812
            List<Booking> list = new List<Booking>();
            if (entities != null)
            {
                foreach (var item in entities)
                {
<<<<<<< HEAD
                    Mapper.CreateMap<Database.Booking, Booking>();
=======
                    Mapper.CreateMap<Database.Booking_Detail, Booking>();
>>>>>>> 629a58571175ef9707ce094f74f8f06f26139812
                    Booking booking = Mapper.Map<Booking>(item);
                    list.Add(booking);
                }
            }
            return list;
        }

        public string updateBooking(Booking model)
        {
            try
            {
<<<<<<< HEAD
                if (model != null)
                {
                    var Record = _dbContext.Bookings.Where(m => m.Room_id == model.Room_id).FirstOrDefault();
                    if (Record != null)
                    {
                        if(Record.StatusOfBooking == StatusOfBooking.Optional.ToString() || Record.StatusOfBooking == StatusOfBooking.Definitive.ToString())
                        {
                            var oldBookingDate = Record.BookingDate;
                            Record.BookingDate = model.BookingDate;
                            _dbContext.SaveChanges();
                            return "Booking of room no " + model.Room_id + " has been changed from "+ oldBookingDate+" to " + model.BookingDate + " with optional status";
                        }
                        return "Booking of room no " + model.Room_id + " has been " + Record.StatusOfBooking + ". So the booking date cannot be modified";
                    }
                    else
                    {
                        return "Room no. "+model.Room_id + " is not booked! please book first to update your booking";
=======
                if (model!= null)
                {
                    var bookingRecord = _dbContext.Booking_Detail.Where(m => m.RoomId == model.RoomId).FirstOrDefault();
                    if (bookingRecord != null)
                    {
                        if(bookingRecord.BookingsStatus== BookingsStatus.Optional.ToString() || bookingRecord.BookingsStatus == BookingsStatus.Definitive.ToString())
                        {
                            var oldBookingDate = bookingRecord.BookingDate;
                            bookingRecord.BookingDate = model.BookingDate;
                            _dbContext.SaveChanges();
                            return "Booking of room no " + model.RoomId + " has been changed from "+ oldBookingDate+" to " + model.BookingDate + " with optional status";
                        }
                        return "Booking of room no " + model.RoomId + " has been " + bookingRecord.BookingsStatus + ". So the booking date cannot be modified";
                    }
                    else
                    {
                        return "Room no. "+model.RoomId+ " is not booked! please book first to update your booking";
>>>>>>> 629a58571175ef9707ce094f74f8f06f26139812
                    }
                }
                return "Model is empty";
            }catch(Exception ex)
            {
                return ex.Message;
            }
        }

        public string updateBookingStatus(Booking model)
        {
            try
            {
                if (model != null)
                {
<<<<<<< HEAD
                    var Record = _dbContext.Bookings.Where(m => m.BookingId == model.BookingId).FirstOrDefault();
                    if (Record != null)
                    {
                        if (Record.StatusOfBooking == StatusOfBooking.Optional.ToString() || Record.StatusOfBooking == StatusOfBooking.Definitive.ToString())
                        {
                            Record.StatusOfBooking = model.StatusOfBooking;
                            _dbContext.SaveChanges();
                            return "Status of Booking no " + model.BookingId + " has been changed to " + model.StatusOfBooking;
                        }
                        return "Booking of room no " + model.BookingId + " has been " + Record.StatusOfBooking + ". So the booking status cannot be modified";
=======
                    var bookingRecord = _dbContext.Booking_Detail.Where(m => m.BookingId == model.BookingId).FirstOrDefault();
                    if (bookingRecord != null)
                    {
                        if (bookingRecord.BookingsStatus == BookingsStatus.Optional.ToString() || bookingRecord.BookingsStatus == BookingsStatus.Definitive.ToString())
                        {
                            bookingRecord.BookingsStatus = model.BookingsStatus;
                            _dbContext.SaveChanges();
                            return "Status of Booking no " + model.BookingId + " has been changed to " + model.BookingsStatus;
                        }
                        return "Booking of room no " + model.BookingId + " has been " + bookingRecord.BookingsStatus + ". So the booking status cannot be modified";
>>>>>>> 629a58571175ef9707ce094f74f8f06f26139812
                    }
                    else
                    {
                        return "Booking no. " + model.BookingId + " is not there! please book first to update your booking";
                    }
                }
                return "Model is empty";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
