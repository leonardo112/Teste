using Teste.Core.Domain.Entity;
using Teste.Core.Domain.Interfaces.Repository;
using Teste.Core.Domain.Interfaces.Service;
using Teste.Core.Domain.Model;

namespace Teste.Core.Data.Service
{
    public class RegiaoService : IRegiaoService
    {
        private readonly IRegiaoDeInteresseRepository _regiaoRepository;

        public RegiaoService(IRegiaoDeInteresseRepository regiaoRepository)
        {
            _regiaoRepository = regiaoRepository;
        }

        public async Task<bool> Insert(List<RegiaoDeInteresseModel> input)
        {
            return await _regiaoRepository.InsertAsync(input);
        }

        public async Task<List<RegiaoDeInteresseEntity>> GetAll()
        {
            return await _regiaoRepository.GetAll();
        }

    }
}
