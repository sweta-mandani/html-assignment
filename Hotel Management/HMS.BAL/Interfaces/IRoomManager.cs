﻿using HMS.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.BAL.Interfaces
{
    public interface IRoomManager
    {
        List<Room> searchRoom(string city = null, decimal? pincode = null, int? price = null, string category = null);
        string createRoom(Room model);
        bool checkRoomAvailability(int id, DateTime date);
        string bookRoom(Booking model);
    }
}
