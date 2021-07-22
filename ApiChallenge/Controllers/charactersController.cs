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




			//foreach (JObject jsonOperaciones in resultadoPersonaje.Children<JObject>())
			//{
			//	//Aqui para poder identificar las propiedades y sus valores
			//	/*foreach (JProperty jsonOPropiedades in jsonOperaciones.Properties())
			//	{
			//		string propiedad = jsonOPropiedades.Name;
			//		if (propiedad.Equals("idgoOperacion"))
			//		{
			//			var idgoOperacion = Convert.ToInt32(jsonOPropiedades.Value);
			//		}
			//	}*/
			//	//Aqui puedes acceder al objeto y obtener sus valores
			//	var idgoOperacion = Convert.ToInt32(jsonOperaciones["idgoOperacion"]);



			//}
			//var resultadoPersonaje = context.Personaje.ToList();

			//resultadoPersonaje.

			//var returnPersonajes =new List<> {"imagen","nombre"};

			//foreach (var item in resultadoPersonaje)
			//{
			//	for (int i = 0; i < resultadoPersonaje.Count(); i++)
			//	{
					
			//		string valorImagen = resultadoPersonaje.ElementAt(i).Imagen.ToString()+","+ resultadoPersonaje.ElementAt(i).Nombre.ToString();
			//		//var valorNombre = resultadoPersonaje.ElementAt(i).Nombre.ToString();
			//		returnPersonajes.Add(valorImagen);

			//		//List<string> aPersonajes = new List<string>{ str1, str2 };

			//		//IEpersonaje = aPersonajes.AsEnumerable();
			//	}
			//}
			//return returnPersonajes;
			


		}
		[HttpGet("{id}")]
		public Personaje GetPersonajes(int id)
		{
			var context = new MVCContext();
			return context.Personaje.FirstOrDefault(x => x.IdPersonaje == id);
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
