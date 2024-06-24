using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _BookingService;

        public BookingController(IBookingService bookingService)
        {
            _BookingService = bookingService;
        }

        [HttpGet]
        public IActionResult BookingList()
        {
            var values = _BookingService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddBooking(Booking booking)
        {
            _BookingService.TInsert(booking);
            return Ok();

        }

        // Silme işlemi,

        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(int id)
        {
            var values = _BookingService.TGetByID(id);
            _BookingService.TDelete(values);
            return Ok();

        }
        //Güncelleme
        [HttpPut("UpdateBooking")]
        public IActionResult UpdateBooking(Booking booking)
        {
            _BookingService.TUpdate(booking);
            return Ok();

        }
        // id ye göre getirme işlemi 


        [HttpGet("{id}")]
        public IActionResult GetBooking(int id)
        {
            var values = _BookingService.TGetByID(id);

            return Ok(values);

        }
        [HttpPut("aa")]
        public IActionResult aa(Booking booking)
        {
            _BookingService.TBookingStatusChangeApproved(booking);
            return Ok();
        }
        [HttpPut("bb")]
        public IActionResult bb(int id)
        {
            _BookingService.TBookingStatusChangeApproved2(id);
            return Ok();
        }
    }
}
