using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Mvc.Hubs;
using Mvc.Models.Concrete;
using Mvc.Models.Context;
using Mvc.Models.Dtos.OrderDtos;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace Mvc.Controllers
{
    [Authorize]
    public class OrderController : BaseController
    {
        public static string sysFormat = CultureInfo.CurrentCulture.DateTimeFormat.FullDateTimePattern;
        private readonly IHubContext<OrderHub> _hubContext;
        public OrderController(UserManager<AppUser> userManager, Context context, IHubContext<OrderHub> hubContext) : base(userManager, context)
        {
            _hubContext = hubContext;
        }
        public async Task<IActionResult> Index()
        {
            List<SelectListItem> data1 = new List<SelectListItem>();
            List<SelectListItem> data = (from x in Context.WorkAreas.Where(x => x.AppUserId == LoggedInUser.Id)
                                         select new SelectListItem
                                         {
                                             Text = x.SubLine.AssemblyLine.Name + " " + x.SubLine.Name,
                                             Value = x.SubLineId.ToString()
                                         }).ToList();
            ViewBag.dropDownData = data;
            var workArea = await Context.WarehouseUsers.Where(x => x.AppUserId == LoggedInUser.Id).Include(x => x.WarehouseLocation).ToListAsync();
            foreach (var item in workArea)
            {
                data1.Add(new SelectListItem
                {
                    Text = item.WarehouseLocation.Name,
                    Value = item.WarehouseLocation.Id.ToString()
                });
            };
            ViewBag.LocationList = data1;
            return View();
        }
        public async Task<JsonResult> GetStationList(int Id)
        {
            var IstasyonList = await Context.Stations.Where(f => f.SubLineId == Id).ToListAsync();
            return Json(IstasyonList);
        }
        public async Task<IActionResult> AgvRequest()
        {
            List<SelectListItem> data = (from x in Context.WorkAreas.Where(x => x.AppUserId == LoggedInUser.Id)
                                         select new SelectListItem
                                         {
                                             Text = x.SubLine.AssemblyLine.Name + " " + x.SubLine.Name,
                                             Value = x.SubLineId.ToString()
                                         }).ToList();
            ViewBag.dropDownData = data;
            var workArea = await Context.WarehouseUsers.Where(x => x.AppUserId == LoggedInUser.Id).Include(x => x.WarehouseLocation).ToListAsync();
            List<SelectListItem> data1 = new List<SelectListItem>();
            foreach (var item in workArea)
            {
                data1.Add(new SelectListItem
                {
                    Text = item.WarehouseLocation.Name,
                    Value = item.WarehouseLocation.Id.ToString()
                });
            };
            ViewBag.LocationList = data1;
            return View();
        }
        [HttpPost]
        public async Task<JsonResult> AddOrder(OrderGeneralDto models)
        {
            Order tempOrder = new Order
            {
                MaterialCode = models.Orders.MaterialCode,
                MaterialDesc = models.Orders.MaterialDesc,
                Quantity = models.Orders.Quantity,
                AppUserId = LoggedInUser.Id,
                OperationId = LoggedInUser.Id,
                Status = "Bekleniyor",
                StationId = models.StationId,
                OrderDate = DateTime.Parse(DateTime.Now.ToString(sysFormat)),
                WarehouseLocationId = models.locationId,
            };
            Context.Orders.Add(tempOrder);
            Context.SaveChanges();
            await _hubContext.Clients.All.SendAsync("SendData", "success");
            return Json(models);
        }
        public async Task<JsonResult> CancelOrder(int Id)
        {
            var tempCanceled = Context.Orders.Find(Id);
            OrderLog tempOrder = new OrderLog
            {
                MaterialCode = tempCanceled.MaterialCode,
                MaterialDesc = tempCanceled.MaterialDesc,
                Quantity = tempCanceled.Quantity,
                AppUserId = tempCanceled.AppUserId,
                Status = "İptal Edildi!",
                Station = tempCanceled.Station,
                OperationId = LoggedInUser.Id,
                StationId = tempCanceled.StationId,
                TypeId = 2,
                OrderDate = tempCanceled.OrderDate,
                CancelDate = DateTime.Parse(DateTime.Now.ToString(sysFormat)),
                WarehouseLocationId = tempCanceled.WarehouseLocationId,
            };
            Context.OrderLogs.Add(tempOrder);
            Context.Orders.Remove(tempCanceled);
            Context.SaveChanges();
            await _hubContext.Clients.All.SendAsync("SendData", "success");
            return Json(true);
        }
        public async Task<JsonResult> CompleteOrder(int Id)
        {
            var tempCanceled = Context.Orders.Find(Id);
            OrderLog tempOrder = new OrderLog
            {
                MaterialCode = tempCanceled.MaterialCode,
                MaterialDesc = tempCanceled.MaterialDesc,
                Quantity = tempCanceled.Quantity,
                AppUserId = tempCanceled.AppUserId,
                Status = "Tamamlandı!",
                Station = tempCanceled.Station,
                OperationId = LoggedInUser.Id,
                StationId = tempCanceled.StationId,
                TypeId = 3,
                OrderDate = tempCanceled.OrderDate,
                AcceptDate = tempCanceled.AcceptDate,
                CompletedDate = DateTime.Parse(DateTime.Now.ToString(sysFormat)),
                WarehouseLocationId = tempCanceled.WarehouseLocationId,
            };
            Context.OrderLogs.Add(tempOrder);
            Context.Orders.Remove(tempCanceled);
            Context.SaveChanges();
            await _hubContext.Clients.All.SendAsync("SendData", "success");
            return Json(true);
        }
        public async Task<JsonResult> NoStockOrder(int Id)
        {
            var tempCanceled = Context.Orders.Find(Id);
            OrderLog tempOrder = new OrderLog
            {
                MaterialCode = tempCanceled.MaterialCode,
                MaterialDesc = tempCanceled.MaterialDesc,
                Quantity = tempCanceled.Quantity,
                AppUserId = tempCanceled.AppUserId,
                Status = "Stok Yok!",
                Station = tempCanceled.Station,
                OperationId = LoggedInUser.Id,
                StationId = tempCanceled.StationId,
                TypeId = 1,
                OrderDate = tempCanceled.OrderDate,
                NoStockDate = DateTime.Parse(DateTime.Now.ToString(sysFormat)),
                WarehouseLocationId = tempCanceled.WarehouseLocationId,
            };
            Context.OrderLogs.Add(tempOrder);
            Context.Orders.Remove(tempCanceled);
            Context.SaveChanges();
            await _hubContext.Clients.All.SendAsync("SendData", "success");
            return Json(true);
        }
        public async Task<JsonResult> AcceptOrder(int Id)
        {
            var tempNoStock = Context.Orders.Find(Id);
            tempNoStock.Status = "Yolda";
            tempNoStock.OperationId = LoggedInUser.Id;
            tempNoStock.AcceptDate = DateTime.Parse(DateTime.Now.ToString(sysFormat));
            Context.SaveChanges();
            await _hubContext.Clients.All.SendAsync("SendData", "success");
            return Json(true);
        }
        public async Task<IActionResult> OrderDetails(int Id)
        {
            var tempOrder = await Context.Orders.Where(x => x.Id == Id).Include(x => x.Station).FirstOrDefaultAsync();
            return View(tempOrder);
        }
        public async Task<IActionResult> OrderHistoryDetails(int Id)
        {
            var tempOrder = await Context.OrderLogs.Where(x => x.Id == Id).Include(x => x.Station).FirstOrDefaultAsync();
            return View(tempOrder);
        }
    }
}
