using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio13.Entrada
{
    public class EntradaController : IEntradaController
    {

        private IEntradaService entradaService;
        private IEntradaConverter entradaConverter;

        public EntradaController(IEntradaService _entradaService, IEntradaConverter _entradaConverter)
        {
            this.entradaService = _entradaService;
            this.entradaConverter = _entradaConverter;
        }


        public void Create(EntradaDTO entradaDTO)
        {
            Entrada entrada = entradaConverter.DTOToEntity(entradaDTO);
            entradaService.Create(entrada);
        }

        public void Delete(long id)
        {
            entradaService.Delete(id);
        }

        public IList<EntradaDTO> List()
        {
            IList<EntradaDTO> listaResultado = new List<EntradaDTO>();

            IList<Entrada> listaEntradas = entradaService.List();

            foreach (Entrada v in listaEntradas)
            {
                EntradaDTO entradaDTO = entradaConverter.EntityToDTO(v);
                listaResultado.Add(entradaDTO);
            }
            return listaResultado;

        }

        public EntradaDTO Read(long id)
        {
            Entrada entrada = entradaService.Read(id);
            EntradaDTO entradaDTO = entradaConverter.EntityToDTO(entrada);
            return entradaDTO;
        }

        public void Update(EntradaDTO entradaDTO)
        {
            Entrada entrada = entradaConverter.DTOToEntity(entradaDTO);
            entradaService.Update(entrada);
        }
    }
}
