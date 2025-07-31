using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_zaliczeniowy
{
    public interface IDDX<T>
    {
        T Get();
        void Set(T elem);
    }
}
