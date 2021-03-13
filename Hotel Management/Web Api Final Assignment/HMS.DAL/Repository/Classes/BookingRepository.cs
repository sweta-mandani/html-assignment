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
        enum StatusOfBooking
        {
            Optional,
            Definitive,
            Cancelled,
            Deleted
        }
        private readonly Database.HotelEntities _dbContext;
        public BookingRepository()
        {
            _dbContext = new Database.HotelEntities();
        }

        public string deleteBooking(Booking model)
        {
            try
            {
                if (model.BookingId != null)
                {
                    Database.Booking booking = _dbContext.Bookings.Find(model.BookingId);
                    if (booking != null)
                    {
                        booking.StatusOfBooking = StatusOfBooking.Deleted.ToString();
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
            var entities = _dbContext.Bookings.ToList();
            List<Booking> list = new List<Booking>();
            if (entities != null)
            {
                foreach (var item in entities)
                {
                    Mapper.CreateMap<Database.Booking, Booking>();
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
