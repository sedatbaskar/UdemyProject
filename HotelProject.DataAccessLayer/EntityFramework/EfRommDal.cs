using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EfRommDal : GenericRepository<Room>, IRoomDal
    {
        public EfRommDal(Context context) : base(context)
        {

        }

    }
}
