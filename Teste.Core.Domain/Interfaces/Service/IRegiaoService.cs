using Teste.Core.Domain.Entity;
using Teste.Core.Domain.Model;

namespace Teste.Core.Domain.Interfaces.Service
{
    public interface IRegiaoService
    {
        Task<bool> Insert(List<RegiaoDeInteresseModel> input);
        Task<List<RegiaoDeInteresseEntity>> GetAll();

    }
}
