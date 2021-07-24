using ApiChallenge.Context;
using ApiChallenge.DBModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ApiChallenge.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class charactersController : ControllerBase
	{

		[HttpGet]
		public IEnumerable<Personaje> GetPersonajes()
		{
			var context = new MVCContext();
			return context.Personaje.ToList();
		}

		[HttpGet("{id:int}")]
		public Personaje GetPersonajes(int id)
		{
			var context = new MVCContext();
			return context.Personaje.FirstOrDefault(x => x.IdPersonaje == id);
		}

		[HttpGet("{imagen}")]
		public Personaje GetPersonajes([FromBody] string imagen)
		{
			var context = new MVCContext();
			return context.Personaje.FirstOrDefault(x => x.Imagen == imagen);
		}

		[HttpPost]
		public Personaje PostPersonajes(Personaje personaje)
		{
			var context = new MVCContext();
			context.Personaje.Add(personaje);
			context.SaveChanges();
			return personaje;
		}

		[HttpPut]
		public Personaje PutPersonajes(Personaje personaje)
		{
			var context = new MVCContext();
			var personajeActualizar = context.Personaje.FirstOrDefault(x => x.IdPersonaje == personaje.IdPersonaje);
			personajeActualizar.Imagen = personaje.Imagen;
			personajeActualizar.Nombre = personaje.Nombre;
			personajeActualizar.Edad = personaje.Edad;
			personajeActualizar.Peso = personaje.Peso;
			personajeActualizar.Historia = personaje.Historia;			
			context.SaveChanges();
			return personaje;
		}
		[HttpDelete]
		public bool DeletePersonajes(int id)
		{
			var context = new MVCContext();
			var personajeEliminar = context.Personaje.FirstOrDefault(x => x.IdPersonaje == id);
			context.Personaje.Remove(personajeEliminar);
			context.SaveChanges();
			return true;
		}
		

	}
}
