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
    public class HotelRepository : IHotelRepository
    {
<<<<<<< HEAD
        private readonly Database.HotelEntities _dbContext;
        public HotelRepository()
        {
            _dbContext = new Database.HotelEntities();
=======
        private readonly Database.WebDBEntities _dbContext;
        public HotelRepository()
        {
            _dbContext = new Database.WebDBEntities();
>>>>>>> 629a58571175ef9707ce094f74f8f06f26139812
        }
        public string createHotel(Hotel entity)
        {
            try
            {
                if (entity != null)
                {
<<<<<<< HEAD
                    Mapper.CreateMap<Hotel, Database.HotelM>();
                    Database.HotelM hotel = Mapper.Map<Database.HotelM>(entity);
                    _dbContext.HotelMs.Add(hotel);
=======
                    Mapper.CreateMap<Hotel, Database.Hotel_Details>();
                    Database.Hotel_Details hotel = Mapper.Map<Database.Hotel_Details>(entity);
                    _dbContext.Hotel_Details.Add(hotel);
>>>>>>> 629a58571175ef9707ce094f74f8f06f26139812
                    _dbContext.SaveChanges();

                    return "Successfully Added!!";
                }
                return "Model is null!!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Hotel> getAllHolels()
        {
<<<<<<< HEAD
            var entities = _dbContext.HotelMs.OrderBy(c => c.HotelName).ToList();
=======
            var entities = _dbContext.Hotel_Details.OrderBy(c => c.HotelName).ToList();
>>>>>>> 629a58571175ef9707ce094f74f8f06f26139812
            List<Hotel> list = new List<Hotel>();
            if (entities != null)
            {
                foreach (var item in entities)
                {
<<<<<<< HEAD
                    Mapper.CreateMap<Database.HotelM, Hotel>();
=======
                    Mapper.CreateMap<Database.Hotel_Details,Hotel>();
>>>>>>> 629a58571175ef9707ce094f74f8f06f26139812
                    Hotel hotel = Mapper.Map<Hotel>(item);
                    list.Add(hotel);
                }
            }
            return list;
        }

<<<<<<< HEAD
        
        public Hotel getHotel(int id)
        {
            var entity = _dbContext.HotelMs.Where(c=>c.HotelId == id).FirstOrDefault();
            Hotel hotel = new Hotel();
            if (entity != null)
            {
                Mapper.CreateMap<Database.HotelM, Hotel>();
                hotel = Mapper.Map<Hotel>(entity);
            }
           
=======

        public Hotel getHotel(int id)
        {
            var entity = _dbContext.Hotel_Details.Where(c=>c.HotelId == id).FirstOrDefault();
            Hotel hotel = new Hotel();
            if (entity != null)
            {
                Mapper.CreateMap<Database.Hotel_Details, Hotel>();
                hotel = Mapper.Map<Hotel>(entity);
            }
            
>>>>>>> 629a58571175ef9707ce094f74f8f06f26139812
            return hotel;
        }
    }
}
