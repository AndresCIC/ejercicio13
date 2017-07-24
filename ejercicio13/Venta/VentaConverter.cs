using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio13
{
    public class VentaConverter : IVentaConverter
    {
        public Entrada DTOToEntity(EntradaDTO ventaDTO)
        {
            Entrada resultado = new Entrada();
            resultado.Id = ventaDTO.Id;
            return resultado;
        }

        public EntradaDTO EntityToDTO(Entrada venta)
        {
            EntradaDTO resultado = new EntradaDTO();
            resultado.Id = venta.Id;
            return resultado;
            
        }
    }
}
