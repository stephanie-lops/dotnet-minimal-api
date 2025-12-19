using System.Reflection;
using System.Runtime.InteropServices;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MinimalApi.Dominio.Entidades;
using MinimalApi.Dominio.Servicos;
using MinimalApi.Infraestrutura.Db;

namespace Test.Domain.Entidades;

[TestClass]
public sealed class AdministradorServicoTest
{
    private DbContexto CriarContextoDeTeste()
    {
       
       var assemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
       var path = Path.GetFullPath(Path.Combine(assemblyPath ?? "", "..", "..", ".."));

        var builder = new ConfigurationBuilder()
            .SetBasePath(path ?? Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .AddEnvironmentVariables();

        var configuration = builder.Build();

        var context = new DbContexto(configuration);

        context.Database.EnsureCreated();

        return context;
    }

    [TestMethod]
    public void TestandoSalvarAdministrador()
    {
        // Arrange
        var context = CriarContextoDeTeste();

        var adm = new Administrador();
        context.Database.ExecuteSqlRaw("TRUNCATE TABLE administradores");

        //adm.Id = 1;
        adm.Email = "teste@teste.com";
        adm.Senha = "teste";
        adm.Perfil = "Adm";

        var administradorServico = new AdministradorServico(context);
    
        // Act
        administradorServico.Incluir(adm);

        // Assert
        //Assert.AreEqual(1, administradorServico.Todos(1).Count());
        Assert.IsTrue(adm.Id > 0);
    }

    [TestMethod]
    public void TestandoBuscaPorId()
    {
        // Arrange
        var context = CriarContextoDeTeste();

        var adm = new Administrador();
        context.Database.ExecuteSqlRaw("TRUNCATE TABLE administradores");

        //adm.Id = 1;
        adm.Email = "teste@teste.com";
        adm.Senha = "teste";
        adm.Perfil = "Adm";

        var administradorServico = new AdministradorServico(context);
    
        // Act
        administradorServico.Incluir(adm);
        var admDoBanco = administradorServico.BuscaPorId(adm.Id);


        // Assert
        Assert.IsNotNull(admDoBanco);
        Assert.AreEqual(1, admDoBanco.Id);

    }
}
