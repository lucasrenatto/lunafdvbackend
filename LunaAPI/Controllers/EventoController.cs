using LunaAPI.Models;
using LunaAPI.Service;
using Microsoft.AspNetCore.Mvc;


namespace LunaAPI.Controllers
{
    public class EventoController : Controller
    {
        private EventoService _testeService;
        public EventoController()
        {
            _testeService = new EventoService();
        }
        public async Task<ActionResult> BuscarTodos()
        {
            try
            {
                var result = await _testeService.BuscarTodos();
                return Json(new ResultModel()
                {
                    //IsSuccess = true,
                    //Message = "Eventos Recuperados com Sucesso!",
                    Result = result
                });
            }
            catch (Exception ex)
            {
                return Json(new ResultModel()
                {
                    //IsSuccess = false,
                    Result = $"Erro Ao Tentar Recuperar os Dados | {ex.Message}"
                });
            }
        }
    }
}
