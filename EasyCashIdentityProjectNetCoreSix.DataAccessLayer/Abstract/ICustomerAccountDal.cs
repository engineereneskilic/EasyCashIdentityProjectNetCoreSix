using EasyCashIdentityProjectNetCoreSix.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProjectNetCoreSix.DataAccessLayer.Abstract
{
    public interface ICustomerAccountDal: IGenericDal<CustomerAccount>
    {
        // CustomerAccount sınıfına özgü classlar eklemek istersen ona özel metodları buraya yaz. Ekle sil güncelle hepsinede zaten var.
    }
}
