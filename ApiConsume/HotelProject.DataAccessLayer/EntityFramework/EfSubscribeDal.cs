using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.EntityFramework;

public class EfSubscribeDal : GenericRepository<Subscribe>, ISubscribesDal
{
    public EfSubscribeDal(Context context) : base(context)
    {

    }
}
