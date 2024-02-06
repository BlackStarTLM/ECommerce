﻿using ECommerceSample.Filters;
using ECommerceSampleClassLibrary.Interfaces;
using ECommerceSampleClassLibrary.Models;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceSample.Controllers
{
    [ApiController]
    [Route("orders")]
    public class OrderController : Controller
    {
        private readonly IOrderService _orderRepository;
        public OrderController(IOrderService orderRepository)
        {
            _orderRepository = orderRepository;
        }

        [HttpPost("")]
        [InventoryFilter]
        public Guid AddOrder([FromBody] PostOrder postOrder)
        {
            return _orderRepository.AddOrder(postOrder);
        }

        [HttpDelete("/{id}")]
        public void DeleteOrder(Guid id)
        {
            _orderRepository.DeleteOrder(id);
        }
    }
}
