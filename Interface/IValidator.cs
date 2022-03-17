using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpEvents.Interface
{
    interface IValidator<in T>
    {
        public bool Validate(T t);
    }
}
