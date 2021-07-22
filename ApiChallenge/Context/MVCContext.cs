using ApiChallenge.DBModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiChallenge.Context
{
	public class MVCContext : DbContext
	{
		public DbSet<Personaje> Personaje { get; set; }
		public DbSet<Pelicula> Pelicula { get; set; }
		public DbSet<Genero> Genero { get; set; }
		public DbSet<PersonajePelicula> PersonajePelicula { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Data Source=NOTEBOOK-JERE\SQLEXPRESS;Initial Catalog=disneyDB;Integrated Security=True");
		}
	}
}
