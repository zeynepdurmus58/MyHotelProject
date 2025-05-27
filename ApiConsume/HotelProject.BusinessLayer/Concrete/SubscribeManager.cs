using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete;

public class SubscribeManager : ISubscribeService
{
    private readonly ISubscribesDal _subscribesDal;

    public void TDelete(Subscribe t)
    {
        _subscribesDal.Delete(t);
    }

    public Subscribe TGetByID(int id)
    {
        return _subscribesDal.GetByID(id);
    }

    public List<Subscribe> TGetList()
    {
        return _subscribesDal.GetList();
    }

    public void TInsert(Subscribe t)
    {
        _subscribesDal.Insert(t);
    }

    public void TUpdate(Subscribe t)
    {
        _subscribesDal.Update(t);
    }
}
