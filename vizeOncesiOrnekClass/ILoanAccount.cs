using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vizeOncesiOrnekClass
{
     interface ILoanAccount
    {
        void CalculateInterest();        // erişim belirleyicisi yok metot gövdesi yok
        void MakePayment(decimal amount);
    }
}
