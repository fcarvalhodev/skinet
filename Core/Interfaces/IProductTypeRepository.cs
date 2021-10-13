using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IProductTypeRepository
    {
          Task<IReadOnlyList<ProductType>> GetProductTypeAsync();
    }
}