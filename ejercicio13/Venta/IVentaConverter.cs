using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio13
{
    public interface IVentaConverter
    {
        EntradaDTO EntityToDTO(Entrada venta);
        Entrada DTOToEntity(EntradaDTO ventaDTO);
    }
}
