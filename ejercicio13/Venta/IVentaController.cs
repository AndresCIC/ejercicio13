using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio13
{
    public interface IVentaController
    {
        void Create(EntradaDTO ventaDTO);
        EntradaDTO Read(long id);
        IList<EntradaDTO> List();
        void Update(EntradaDTO ventaDTO);

        void Delete(long id);

    }
}
    