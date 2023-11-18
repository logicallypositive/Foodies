
using Api.Controllers;
using Application.Foods;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class FoodsController : BaseAPIController
    {
        private readonly IMediator _mediator;
        public FoodsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet] // api/foods
        public async Task<ActionResult<List<Food>>> GetFoods()
        {
            return await _mediator.Send(new List.Query());
        }

        [HttpGet("{id}")] // api/foods/id
        public async Task<ActionResult<Food>> GetFood(Guid id)
        {
            return Ok();
        }
    }
}
