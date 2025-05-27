﻿using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete;

public class RoomManager : IRoomService
{
    //dependency injection
    private readonly IRoomDal _roomDal;

    public RoomManager(IRoomDal roomDal)
    {
        _roomDal = roomDal;
    }

    public void TDelete(Room t)
    {
        _roomDal.Delete(t);
    }

    public Room TGetByID(int id)
    {
        return _roomDal.GetByID(id);
    }

    public List<Room> TGetList()
    {
        return _roomDal.GetList();
    }

    public void TInsert(Room t)
    {
        _roomDal.Insert(t);
    }

    public void TUpdate(Room t)
    {
        _roomDal.Update(t);
    }
}
