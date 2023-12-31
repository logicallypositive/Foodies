
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Foods
{
    public class List
    {
        public class Query : IRequest<List<Food>> { }

        public class Handler : IRequestHandler<Query, List<Food>>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
               _context = context; 
            }
            public async Task<List<Food>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Foods.ToListAsync();
            }
        }
    }
}