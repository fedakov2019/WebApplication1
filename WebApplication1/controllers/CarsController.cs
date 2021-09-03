using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.data.inerfaces;
using WebApplication1.ViewModels;

namespace WebApplication1.controllers
{
    public class CarsController:Controller
    {
        private readonly IAllCars _iallCars;
        private readonly ICarsCategori _iallCarsCategoru;
        public CarsController(IAllCars IallCars, ICarsCategori IcarsCategori)
        {
            _iallCars = IallCars;
            _iallCarsCategoru = IcarsCategori;

        }
        public ViewResult List()
        {
            ViewBag.Title = "Страница с Автомобилями";
            CarsListViewModal obj = new CarsListViewModal();
            obj.getAllCars = _iallCars.Cars;
            obj.curCategori = "Автомобили";
            
            return View(obj);
        }
    }
   
}
