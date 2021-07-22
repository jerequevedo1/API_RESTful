using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiChallenge.DBModels
{
	public class Pelicula
	{
		[Key]
		public int IdPelicula { get; set; }

		[StringLength(20)]
		[Required]
		public string Imagen { get; set; }

		[StringLength(50)]
		[Required]
		public string Titulo { get; set; }

		public DateTime FechaCreacion { get; set; }

		public int Calificacion { get; set; }

		public int IdGenero{ get; set; }
		[ForeignKey("IdGenero")]
		public virtual Genero Genero { get; set; }
	}
}
