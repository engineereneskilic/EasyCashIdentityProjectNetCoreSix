using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProjectNetCoreSix.DataAccessLayer.Abstract
{
    public interface IGenericDal <T> where T : class // MUTLAKA CLASS GELMEK ZROUNDA
    {
        void Insert(T t);
        void Delete(T t);
        void Update(T t);

        T getByID(int id);

        List<T> GetList();
    }
}
