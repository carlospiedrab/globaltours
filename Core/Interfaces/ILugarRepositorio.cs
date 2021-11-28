using Core.Entidades;

namespace Core.Interfaces
{
    public interface ILugarRepositorio
    {
        // firmas de Nuestros Metodos

        Task<Lugar> GetLugarAsync(int id);

        Task<IReadOnlyList<Lugar>> GetLugaresAsync();
        
    }
}