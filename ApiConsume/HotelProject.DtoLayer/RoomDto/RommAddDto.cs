using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.RoomDto
{
	public class RommAddDto
	{
		[Required(ErrorMessage = "Lütfen oda numarasını yazınız.")]
		public string? RoomNumber { get; set; }
		public string? RoomCoverImage { get; set; }
		[Required(ErrorMessage = "Lütfen Fiyat bilgisi giriniz.")]

		public int Price { get; set; }
		[Required(ErrorMessage = "Lütfen Oda başlığı bilgisi giriniz")]

		public string? Title { get; set; }
		[Required(ErrorMessage = "Lütfen yatak sayısı giriniz")]

		public string? BedCount { get; set; }
		[Required(ErrorMessage = "Lütfen banyo sayısı giriniz")]

		public string? BathCount { get; set; }
		public string? Wifi { get; set; }
		public string? Description { get; set; }
	}
}
