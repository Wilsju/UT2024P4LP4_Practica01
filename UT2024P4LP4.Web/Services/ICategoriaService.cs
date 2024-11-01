using UT2024P4LP4.Web.Data.Dtos;
using UT2024P4LP4.Web.Data.Entities;

namespace UT2024P4LP4.Web.Services
{
    public interface ICategoriaService
    {
        Task<Result> Create(CategoriaRequest categoria);
        Task<Result> Delete(int Id);
        Task<ResultList<CategoriaDto>> GetAll(string filtro = "");
        Task<Result> Update(CategoriaRequest categoria);
    }
}
