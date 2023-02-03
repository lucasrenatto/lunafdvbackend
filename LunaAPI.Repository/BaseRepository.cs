

using System.Data.SqlClient;

namespace LunaAPI.Repository
{
    public class BaseRepository
    {

        public string dbConnection = "Data Source=DESKTOP-NNJK3IC\\SQLEXPRESS;Initial Catalog=LunaSQL;User ID=root;Password=987789sd";
        protected string GetString(SqlDataReader reader, string propriedade)
        {
            try
            {
                {
                    return reader[propriedade].ToString();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Falha ao recuperar valor string de {propriedade} | {ex}");
            }
        }
        protected string? GetStringNullable(SqlDataReader reader, string? propriedade)
        {
            try
            {
                {
                    if (reader[propriedade] != DBNull.Value)
                        return reader[propriedade].ToString();
                    else
                        return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Falha ao recuperar valor string de {propriedade} | {ex}");
            }
        }
        protected int GetInt(SqlDataReader reader, string propriedade)
        {
            try
            {
                {
                    return Convert.ToInt32(reader[propriedade].ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Falha ao recuperar valor string de {propriedade} | {ex}");
            }
        }
        protected int? GetIntNullable(SqlDataReader reader, string propriedade)
        {
            try
            {
                {
                    if (reader[propriedade] != DBNull.Value)
                        return Convert.ToInt32(reader[propriedade]);
                    else
                        return 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Falha ao recuperar valor string de {propriedade} | {ex}");
            }
        }
    }
}
