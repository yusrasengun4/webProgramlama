using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webProgramlama.Models
{
	public class Admin
	{
		[Key]
		public int AdminId
		{
			get; set;
		}

		public string AdminMail { get; set; }


		public string Sifre { get; set; }
		public string AdminRol { get; set; }
	}
}

