using MenuItemListing.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MenuItemListing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuItemController : ControllerBase
    {
        [HttpGet]
        public List<MenuItem> Get()
        {
            List<MenuItem> MenuList = new List<MenuItem>()
            {
                new MenuItem() {Id=1, Name="Thaal", freeDelivery=false, Price=500, dateOfLaunch=new DateTime(2022,05,17),Active=true},
                new MenuItem() {Id=2, Name="GrandKitchen", freeDelivery=true, Price=350, dateOfLaunch=new DateTime(2022,05,22),Active=true}
            };
            return MenuList;
        }

        [HttpGet("{id}")]

        public MenuItem GetById(int id)
        {
            List<MenuItem> MenuList = new List<MenuItem>()
            {
                new MenuItem() { Id = 1, Name = "Thaal", freeDelivery = false, Price = 500, dateOfLaunch = new DateTime(2022, 05, 17), Active = true },
                new MenuItem() { Id = 2, Name = "GrandKitchen", freeDelivery = true, Price = 350, dateOfLaunch = new DateTime(2022, 05, 22), Active = true }
            };
            MenuItem obj = MenuList.SingleOrDefault(item => item.Id == id);
            return obj;
        }
    }
}
