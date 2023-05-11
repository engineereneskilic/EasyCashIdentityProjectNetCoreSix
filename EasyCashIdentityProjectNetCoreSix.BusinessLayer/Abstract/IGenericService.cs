using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProjectNetCoreSix.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void TInsert(T t);
        void TDelete(T t);
        void TUpdate(T t);

        T TgetByID(int id);

        List<T> TGetList();
    }
}
