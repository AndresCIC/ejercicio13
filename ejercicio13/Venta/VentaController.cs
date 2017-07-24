using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio13
{
    public class VentaController : IVentaController
    {
        private IVentaService ventaService;
        private IVentaConverter ventaConverter;

        public VentaController(IVentaService _ventaService, IVentaConverter _ventaConverter)
        {
            this.ventaService = _ventaService;
            this.ventaConverter = _ventaConverter;

        }

        public void Create(EntradaDTO ventaDTO)
        {
            Entrada venta = ventaConverter.DTOToEntity(ventaDTO);
            ventaService.Create(venta);
        }

        public void Delete(long id)
        {
            ventaService.Delete(id);
        }

        public IList<EntradaDTO> List()
        {
            IList<EntradaDTO> listaResultado = new List<EntradaDTO>();
            IList<Entrada> listaVenta = ventaService.List();

            foreach (Entrada v in listaVenta)
            {
                EntradaDTO ventaDTO = ventaConverter.EntityToDTO(v);
                listaResultado.Add(ventaDTO);
            }
            return listaResultado;

        }

        public EntradaDTO Read(long id)
        {
            Entrada venta = ventaService.Read(id);
            EntradaDTO ventaTDO = ventaConverter.EntityToDTO(venta);
            return ventaTDO;
        }

        public void Update(EntradaDTO ventaDTO)
        {
            Entrada venta = ventaConverter.DTOToEntity(ventaDTO);
            ventaService.Update(venta);
        }
    }
}
