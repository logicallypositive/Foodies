
using Api.Controllers;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class FoodsController : BaseAPIController
    {
        private readonly DataContext _context;
        public FoodsController(DataContext context)
        {
            _context = context;
            
        }
        [HttpGet] // api/foods
        public async Task<ActionResult<List<Food>>> GetFoods()
        {
            return await _context.Foods.ToListAsync();
        }
        [HttpGet("{id}")] // api/foods/id
        public async Task<ActionResult<Food>> GetFood(Guid id)
        {
            return await _context.Foods.FindAsync(id);
        }

    }
}
