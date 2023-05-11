using EasyCashIdentityProjectNetCoreSix.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProjectNetCoreSix.DataAccessLayer.Abstract
{
    public interface ICustomerAccountProcessDal: IGenericDal<CustomerAccountProcess>
    {
        // CustomerAccountProcess sınıfına özgü classlar eklemek istersen ona özel metodları buraya yaz.Ekle sil güncelle hepsinede zaten var.
    }
}
