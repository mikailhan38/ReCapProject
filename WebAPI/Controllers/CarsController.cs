﻿using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result=_carService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getcardetails")]
        public IActionResult GetCarDetails() 
        {
            var result=_carService.GetCarDetails();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _carService.GetById(id);
            if (result.Success) 
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("betbybrandid")]
        public IActionResult GetByBrandId(int id)
        {
            var result = _carService.GetCarsByBrandId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(Car car) 
        {
            var result = _carService.Add(car);
            if (result.Success) 
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        //[HttpPost("delete")]
        //public IActionResult Delete(Car car)
        //{
        //    var result = _carService.Delete(car);
        //    if(result.Success) { return Ok(result); }
        //    return BadRequest(result);
        //}
        [HttpPost("delete")]
        public IActionResult Delete(int id,Car car) 
        {
            car.CarId = id;
            var result = _carService.Delete(car);
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(int id, Car car)
        {
            car.CarId = id;
            var result = _carService.Update(car);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
