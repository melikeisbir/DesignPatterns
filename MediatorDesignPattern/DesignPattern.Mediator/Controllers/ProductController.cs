﻿using DesignPattern.Mediator.MediatorPattern.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Mediator.Controllers
{
    public class ProductController : Controller
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _mediator.Send(new GetAllProductQuery()); //send bizden request(istek değeri) bekler. (IRequestin olduğu yerden)
            return View(values);
        }
    }
}
