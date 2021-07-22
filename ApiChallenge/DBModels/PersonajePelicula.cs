using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiChallenge.DBModels
{
	public class PersonajePelicula
	{
		[Key]
		public int IdPersonajePelicula { get; set; }
		public int IdPersonaje { get; set; }
		[ForeignKey("IdPersonaje")]
		public virtual Personaje Personaje { get; set; }

		public int IdPelicula { get; set; }
		[ForeignKey("IdPelicula")]
		public virtual Pelicula Pelicula { get; set; }
	}
}
