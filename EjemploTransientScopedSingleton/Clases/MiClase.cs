using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjemploTransientScopedSingleton.Clases
{
    public interface ITransient { }

    public interface IScoped { }

    public interface ISingleton { }
    public class MiClase : ITransient, IScoped, ISingleton
    {
        public Guid Id { get; set; }

        public MiClase()
        {
            Id = Guid.NewGuid();
        }
    }
}
