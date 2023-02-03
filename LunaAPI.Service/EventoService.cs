

using LunaAPI.Domain.Entity;
using LunaAPI.Repository;

namespace LunaAPI.Service
{
    public class EventoService
    {
        private readonly EventoRepository _testeRepository;
        public EventoService()
        {
            _testeRepository = new EventoRepository();
        }
        public async Task<List<EventosEntity>> BuscarTodos()
        {
            try
            {
                var allResult = await _testeRepository.BuscarTodos();
                return allResult;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
