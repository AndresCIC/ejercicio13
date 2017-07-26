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

        public void Create(VentaDTO ventaDTO)
        {
            Venta venta = ventaConverter.DTOToEntity(ventaDTO);
            ventaService.Create(venta);
        }

        public void Delete(long id)
        {
            ventaService.Delete(id);
        }

        public IList<VentaDTO> List()
        {
            IList<VentaDTO> listaResultado = new List<VentaDTO>();
            IList<Venta> listaVenta = ventaService.List();

            foreach (Venta v in listaVenta)
            {
                VentaDTO ventaDTO = ventaConverter.EntityToDTO(v);
                listaResultado.Add(ventaDTO);
            }
            return listaResultado;

        }

        public VentaDTO Read(long id)
        {
            Venta venta = ventaService.Read(id);
            VentaDTO ventaTDO = ventaConverter.EntityToDTO(venta);
            return ventaTDO;
        }

        public void Update(VentaDTO ventaDTO)
        {
            Venta
                
                venta = ventaConverter.DTOToEntity(ventaDTO);
            ventaService.Update(venta);
        }
    }
}
