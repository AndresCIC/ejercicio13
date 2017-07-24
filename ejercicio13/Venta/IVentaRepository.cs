using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio13
{
    public interface IVentaRepository
    {
        void Create(Venta venta);
        Venta Read(long id);
        IList<Venta> List();
        void Update(Venta venta);

        void Delete(long id);

    }
}
