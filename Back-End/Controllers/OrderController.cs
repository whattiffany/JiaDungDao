using System.Collections.Generic;
using Back_End.Interface;
using Back_End.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace Back_End.Controllers {
    [Route ("api/[controller]/[action]")]
    [ApiController]
    public class OrderController : ControllerBase {
        private readonly IOrderService OrderService;
        public OrderController (IOrderService orderService) {
            this.OrderService = orderService;
        }

        [HttpPost]
        [Authorize]
        public IActionResult GetOrderInfo (LoginMemberInfo memberInfo) {
            var result = OrderService.GetOrderInfo (memberInfo.m_account);
            if (result != null) {
                return Ok (result);
            } else {
                return BadRequest ("尚未建立訂單");
            }
        }

        [HttpGet]
        [Authorize]
        public IActionResult GetOrderInfoByResId (int restaurantId) {
            var result = OrderService.GetOrderInfoByResId (restaurantId);
            if (result != null) {
                return Ok (result);
            } else {
                return BadRequest ("尚未收到訂單");
            }
        }

        [Authorize]
        [HttpPost]
        public IActionResult createOrder (OrderInfo orderInfo) {
            var result = OrderService.createOrder (orderInfo);
            if (result == "successed") {
                return Ok (result);
            } else {
                return BadRequest ("訂單建立失敗");
            }
        }
    }
}