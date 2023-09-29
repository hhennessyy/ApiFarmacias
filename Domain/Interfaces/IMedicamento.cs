using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;


namespace Domain.Interfaces
{
    public interface IMedicamento : IGenericRepository<Medicamento>
    {
        Task<IEnumerable<Medicamento>> GetLessThan50 ();
        Task<IEnumerable<Medicamento>> GetMedicamentoProveedor();
        Task UpdateStock (int medicamentoId,int cantidadVendida);
    }
}