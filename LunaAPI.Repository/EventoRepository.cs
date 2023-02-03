using LunaAPI.Domain.Entity;
using System.Data.SqlClient;

namespace LunaAPI.Repository
{
    public class EventoRepository : BaseRepository
    {
        public async Task<List<EventosEntity>> BuscarTodos()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(dbConnection))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(@"SELECT ID,
                                                             TemaEvento,
                                                             CidadeEvento,
                                                             UfEvento,
                                                             DataHoraEvento,
                                                             EventoFinalizado,
                                                             QuantidadePessoas,
                                                             LoteEvento,
                                                             ImagemEventoURL
                                                     FROM LUNA.Eventos", conn);
                    SqlDataReader reader = await cmd.ExecuteReaderAsync();
                    List<EventosEntity> list = new List<EventosEntity>();
                    while (await reader.ReadAsync())
                    {
                        var l = new EventosEntity()
                        {
                            ID = GetInt(reader, "ID"),
                            CidadeEvento = GetStringNullable(reader, "CidadeEvento"),
                            DataHoraEvento = Convert.ToDateTime(reader["DataHoraEvento"]),
                            EventoFinalizado = Convert.ToBoolean(reader["EventoFinalizado"]),
                            TemaEvento = GetStringNullable(reader,"TemaEvento"),
                            UfEvento = GetStringNullable(reader, "UfEvento"),
                            LoteEvento = GetStringNullable(reader, "LoteEvento"),
                            QuantidadePessoas = GetIntNullable(reader, "QuantidadePessoas"),
                            ImagemURL = GetStringNullable(reader,"ImagemEventoURL")
                        };
                        list.Add(l);
                    }
                    return list;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
