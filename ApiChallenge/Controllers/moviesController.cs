using ApiChallenge.Context;
using ApiChallenge.DBModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiChallenge.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class moviesController : ControllerBase
	{
	
		[HttpGet]
		public IEnumerable<Pelicula> GetPeliculas()
		{
			var context = new MVCContext();
			return context.Pelicula.ToList();

		}
		[HttpGet("{id}")]
		public Pelicula GetPeliculas(int id)
		{
			var context = new MVCContext();
			return context.Pelicula.FirstOrDefault(x => x.IdPelicula == id);
		}

		[HttpPost]
		public Pelicula PostPeliculas(Pelicula pelicula)
		{
			var context = new MVCContext();
			context.Pelicula.Add(pelicula);
			context.SaveChanges();
			return pelicula;
		}

		[HttpPut]
		public Pelicula PutPeliculas(Pelicula pelicula)
		{
			var context = new MVCContext();
			var peliculaActualizar = context.Pelicula.FirstOrDefault(x => x.IdPelicula == pelicula.IdPelicula);
			peliculaActualizar.Imagen = pelicula.Imagen;
			peliculaActualizar.Titulo = pelicula.Titulo;
			peliculaActualizar.FechaCreacion = pelicula.FechaCreacion;
			peliculaActualizar.Calificacion = pelicula.Calificacion;
			peliculaActualizar.IdGenero = pelicula.IdGenero;
			context.SaveChanges();
			return pelicula;
		}
		[HttpDelete]
		public bool DeletePeliculas(int id)
		{
			var context = new MVCContext();
			var peliculaEliminar = context.Pelicula.FirstOrDefault(x => x.IdPelicula == id);
			context.Pelicula.Remove(peliculaEliminar);
			context.SaveChanges();
			return true;
		}
		
	}
}
