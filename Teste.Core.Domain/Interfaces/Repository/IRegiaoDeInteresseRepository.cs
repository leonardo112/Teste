using Teste.Core.Domain.Entity;
using Teste.Core.Domain.Model;

namespace Teste.Core.Domain.Interfaces.Repository
{
    public interface IRegiaoDeInteresseRepository
    {
        Task<bool> InsertAsync(List<RegiaoDeInteresseModel> input);
        Task<List<RegiaoDeInteresseEntity>> GetAll();

    }
}
