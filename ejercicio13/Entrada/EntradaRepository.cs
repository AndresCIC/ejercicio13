using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio13.Entrada
{
    public class EntradaRepository : IEntradaRepository
    {
        private List<Entrada> ListaEntradas = new List<Entrada>();

        public void Create(Entrada entrada)
        {
            ListaEntradas.Add(entrada);
        }

        public void Delete(long id)
        {
            ListaEntradas.Remove(ListaEntradas.Find(x => x.Id == id));
        }

        public IList<Entrada> List()
        {
            return ListaEntradas;
        }

        public Entrada Read(long id)
        {
            return ListaEntradas.Find(x => x.Id == id);
        }

        public void Update(Entrada entrada)
        {
            Entrada entradaAnterior = ListaEntradas.Find(x => x.Id == entrada.Id);
            entradaAnterior.Id = entrada.Id;         
        }
    }
}
