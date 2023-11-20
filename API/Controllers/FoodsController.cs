
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

        [HttpGet] // api/foods
        public async Task<ActionResult<List<Food>>> GetFoods()
        {
            return await Mediator.Send(new List.Query());
        }

        [HttpGet("{id}")] // api/foods/id
        public async Task<ActionResult<Food>> GetFood(Guid id)
        {
            return await Mediator.Send(new Details.Query{Id = id});
        }
    }
}
