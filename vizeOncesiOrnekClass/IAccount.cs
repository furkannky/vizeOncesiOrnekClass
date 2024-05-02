using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vizeOncesiOrnekClass
{
     public interface IAccount 
    {
        void Depozit(decimal amount);  // erişim belirleyici yazmıyoruz
                                       // metot gövdesi acılmaz sadece imza yer alır  
        bool Withdraw(decimal amount);
        void DisplayBalance();

    }
}
