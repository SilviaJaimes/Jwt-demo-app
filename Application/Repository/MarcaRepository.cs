using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;

public class MarcaRepository : GenericRepository<Marca>, IMarca
{
    private readonly JwtAppContext _context;

    public MarcaRepository(JwtAppContext context) : base(context)
    {
        _context = context;
    }
}