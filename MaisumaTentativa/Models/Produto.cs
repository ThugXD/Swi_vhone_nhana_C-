using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaisumaTentativa.Models
{
	[Table("Produto")]
	public class Produto
	{
		[Column("Id")]
		[Display(Name ="Codigo")]
		public int Id { get; set; }

		[Column("Nome")]
		[Display(Name = "Nome")]
		public string Nome { get; set; }

		[Column("Email")]
		[Display(Name = "Email")]
		public string Email { get; set; }
	}
}
