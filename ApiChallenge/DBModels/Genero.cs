using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiChallenge.DBModels
{
	public class Genero
	{
		[Key]
		public int IdGenero { get; set; }

		[StringLength(50)]
		[Required]
		public string Nombre { get; set; }

		[StringLength(20)]
		[Required]
		public string Imagen { get; set; }


	}
}
