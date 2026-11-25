/*

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();

*/

Sistema nossoSistema = new Sistema();

Cliente c1 = new Cliente(1, "João", "joao@email.com", "senha123");
Console.WriteLine($"Cliente criado: {c1.NomeUtilizador}, Email: {c1.Email}, Palavra-passe: {c1.PalavraPasse}");
