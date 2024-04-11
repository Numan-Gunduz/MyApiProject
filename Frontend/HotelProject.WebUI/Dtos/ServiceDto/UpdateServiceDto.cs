using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
	public class UpdateServiceDto
	{

		public int ServiceID { get; set; }
		[Required(ErrorMessage = "Hizmet ikon linki giriniz")]
		public string? ServiceIcon { get; set; }
		[Required(ErrorMessage = "Hizmet başlığı giriniz")]
		public string? Title { get; set; }
		public string? Description { get; set; }
	}
}
