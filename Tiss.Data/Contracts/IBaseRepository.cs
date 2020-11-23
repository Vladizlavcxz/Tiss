using System;
using System.Collections.Generic;
using Tiss.Core;

namespace Tiss.Data.Contracts
{
    public interface IBaseRepository<T> : IDisposable
        where T : ApplicationEntity
    {
        IEnumerable<T> GetAll();
    }
}
