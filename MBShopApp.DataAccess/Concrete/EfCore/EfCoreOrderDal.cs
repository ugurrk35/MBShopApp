using MBShopApp.DataAccess.Abstract;
using MBShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBShopApp.DataAccess.Concrete.EfCore
{
    public class EfCoreOrderDal:EfCoreGenericRepository<Order,ShopContext>,IOrderDal
    {
    }
}
