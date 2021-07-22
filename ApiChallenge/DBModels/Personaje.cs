using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiChallenge.DBModels
{
	public class Personaje
	{
		[Key]
		public int IdPersonaje { get; set; }

		[Required]
		[StringLength(20)]
		public string Imagen { get; set; }

		[Required]
		[StringLength(50)]
		public string Nombre { get; set; }

		public int Edad { get; set; }

		[Required]
		public float Peso { get; set; }

		[Required]
		[StringLength(100)]
		public string Historia { get; set; }

	}
}
