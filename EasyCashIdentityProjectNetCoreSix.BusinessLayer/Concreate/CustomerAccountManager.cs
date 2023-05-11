using EasyCashIdentityProjectNetCoreSix.BusinessLayer.Abstract;
using EasyCashIdentityProjectNetCoreSix.DataAccessLayer.Abstract;
using EasyCashIdentityProjectNetCoreSix.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProjectNetCoreSix.BusinessLayer.Concreate
{
    public class CustomerAccountManager : ICustomerAccountService
    {
        // Depentcity Injection olmasaydı ne kaybederdim
        private readonly ICustomerAccountDal _customerAccountDal;

        public CustomerAccountManager(ICustomerAccountDal customerAccountDal)
        {
            _customerAccountDal = customerAccountDal;
        }

        public void TDelete(CustomerAccount t)
        {
            _customerAccountDal.Delete(t);
        }

        public CustomerAccount TgetByID(int id)
        {
            return _customerAccountDal.getByID(id);
        }

        public List<CustomerAccount> TGetList()
        {
            return _customerAccountDal.GetList();
        }

        public void TInsert(CustomerAccount t)
        {
            _customerAccountDal.Insert(t);
        }

        public void TUpdate(CustomerAccount t)
        {
            _customerAccountDal.Update(t);
        }
    }
}
