using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avot.service
{
    interface ICrud<T> where T : class
    {
        int Insert(T instance);
        int Update(T instance);
        int Delete(T instance);
        List<T> Select();
    }
}
