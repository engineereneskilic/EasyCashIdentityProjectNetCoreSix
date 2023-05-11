using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProjectNetCoreSix.EntityLayer.Concrete
{
    public class CustomerAccount
    {
        public int CustomerAccountID { get; set; }
        
        public string CustomerAccountNumber { get; set; } // hesap numarası
        
        public string CustomerAccountCurrency { get; set; } // döviz türü (tl/dolar/euro)
        
        public decimal CustomerAccountBalance { get; set; } // miktar

        public string CustomerAccountBankBranch { get; set; } // banka şubesi

        public int AppUserID { get; set; }

        public AppUser AppUser { get; set; }  // bire çok ilişk için
    }
}
