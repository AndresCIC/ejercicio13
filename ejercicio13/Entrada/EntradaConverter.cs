using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio13.Entrada
{
    public class EntradaConverter : IEntradaConverter
    {
        public Entrada DTOToEntity(EntradaDTO entradaDTO)
        {
            Entrada resultado = new Entrada();
            resultado.Id = entradaDTO.Id;
            return resultado;          
        }

        public EntradaDTO EntityToDTO(Entrada entrada)
        {
            EntradaDTO resultado = new EntradaDTO();
            resultado.Id = entrada.Id;
            return resultado;
        }
    }
}
