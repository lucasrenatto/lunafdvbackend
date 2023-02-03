using System.Reflection;

namespace LunaAPI.Domain.Entity
{
    public class EventosEntity
    {
        public int ID { get; set; }
        public string? ImagemURL { get; set; }
        public string? TemaEvento { get; set; }
        public string? CidadeEvento { get; set; }
        public string? UfEvento { get; set; }
        public int? QuantidadePessoas { get; set; }
        public string? LoteEvento { get; set; }
        public DateTime? DataHoraEvento { get; set; }
        public bool? EventoFinalizado { get; set; }
    }
}
