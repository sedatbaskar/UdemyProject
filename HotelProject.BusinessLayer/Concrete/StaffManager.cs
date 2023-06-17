using HotelProject.BusinessLayer.Absract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class StaffManager : IStaffService
    {
        private readonly IStaffDal _stafDal;

        public StaffManager(IStaffDal stafDal)
        {
            _stafDal = stafDal;
        }

        public void TInsert(Staff t)
        {
            _stafDal.Insert(t);
        }

        public void TDelete(Staff t)
        {
            _stafDal.Delete(t);
        }

        public Staff TGetByID(int id)
        {
            return _stafDal.GetByID(id);
        }

        public List<Staff> TGetList()
        {
            return _stafDal.GetList();
        }

        public void TUpdate(Staff t)
        {
            _stafDal.Update(t);
        }
    }
}
