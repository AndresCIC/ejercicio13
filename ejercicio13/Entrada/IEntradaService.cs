using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio13.Entrada
{
    public interface IEntradaService
    {
        void Create(Entrada entrada);
        Entrada Read(long id);
        IList<Entrada> List();
        void Update(Entrada entrada);

        void Delete(long id);

    }
}
