using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancePoint.Interface
{
    public interface Balance<in T1, out T2>
    {
        T2 Manage(T1 input);
    }
}
