using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio13.Entrada
{
    public interface IEntradaConverter
    {
        EntradaDTO EntityToDTO(Entrada entrada);
        Entrada DTOToEntity(EntradaDTO entradaDTO);
    }
}
