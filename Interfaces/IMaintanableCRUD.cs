using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem.Interfaces
{
    interface IMaintanableCRUD<T>
    {
        string Create();
        T Retrieve(string key);
        void Update(T obj);
        void Delete(string key);
    }
}
