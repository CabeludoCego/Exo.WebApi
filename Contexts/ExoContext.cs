using Exo.WebApi.Models;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Exo.WebApi.Contexts
{
	public class ExoContext : DbContext
	{
		public ExoContext() { }
		public ExoContext(DbContextOptions<ExoContext> options) : base(options) { }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{

				// SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(
				//                     "User Id=sa;Password=1234;" +
				//                     "Server=LAPTOP-A5LLEMOS;" +
				//                     "Database=vendas;" +
				//                     "Trusted_Connection=False;" );


				// Essa string de conexão depende da SUA máquina.
				optionsBuilder.UseSqlServer("Server=LAPTOP-A5LLEMOS;"
				+ "Database=ExoApi;Trusted_Connection=False;"
				+ "User Id=sa;Password=1234;");
			}
		}
		public DbSet<Usuario> Usuarios { get; set; }
		public DbSet<Projeto> Projetos { get; set; }
	}
}