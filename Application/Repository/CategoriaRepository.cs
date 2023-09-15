using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;
public class CategoriaRepository : GenericRepository<Categoria>, ICategoria
{
    private readonly JwtAppContext _context;

    public CategoriaRepository(JwtAppContext context) : base(context)
    {
        _context = context;
    }
}