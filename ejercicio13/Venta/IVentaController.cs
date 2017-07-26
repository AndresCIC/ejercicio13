using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio13
{
    public interface IVentaController
    {
        void Create(VentaDTO ventaDTO);
        VentaDTO Read(long id);
        IList<VentaDTO> List();
        void Update(VentaDTO ventaDTO);

        void Delete(long id);

    }
}
    