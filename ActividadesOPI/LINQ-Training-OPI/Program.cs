using LinqTraining.Data;
using LinqTraining.Models;

List <Product> products = SampleData.GetProducts(); 
List <Book> books = SampleData.GetBooks();
List<Order> orders = SampleData.GetOrders();
List<Employee> employees = SampleData.GetEmployees();

var employeesDictionary = employees.ToDictionary(e => e.Id);

Console.WriteLine($"Employee with ID 3: {employeesDictionary[3].Name}");

var monthOrder = orders.Where(o=> o.Date >= DateTime.Now.AddDays(-30)).GroupBy(o => o.Status);
foreach (var grupo_lastmonth in monthOrder)
{
    Console.WriteLine($"Estado: {grupo_lastmonth.Key}"); 
    
    foreach (var pedido in grupo_lastmonth)
    {
    Console.WriteLine($" - Pedido ID: {pedido.Id}");

    }
}
Console.WriteLine("-----------------------------");

var topBook = books.OrderByDescending(b => b.UnitsSold).ThenBy(b => b.Genre).Take(5);

foreach (var libro in topBook)
{
    Console.WriteLine($"Los 5 libros mas vendidos por genero son: {libro.Title} del genero {libro.Genre}");
}
Console.WriteLine("-----------------------------");

var topClients = orders.OrderByDescending(c => c.CustomerName).ThenBy(c => c.Status == "Completed").Take(3); 
foreach (var client in topClients)
{
    Console.WriteLine($"Los 3 clientes con mas compras son: {client.CustomerName}");
}
Console.WriteLine("-----------------------------");


var noPurchases = orders.OrderBy(c=> c.CustomerName).Where(c=> c.Status == "Cancelled");
foreach(var clientWithoutPurchases in noPurchases) 
{
    Console.WriteLine($"Estos son los clientes sin compras registradas: {clientWithoutPurchases.CustomerName}");
}
Console.WriteLine("-----------------------------");


Console.WriteLine("Por ultimo, ingresa el nombre del libro que deseas buscar");
string? busqueda = Console.ReadLine();

var resultados = books.Where(r => r.Title.Contains(busqueda, StringComparison.OrdinalIgnoreCase));

Console.WriteLine("Estos son los libros mas compatibles con tu busqueda: ");
foreach(var libro in resultados)
{
    Console.WriteLine(libro.Title);
}
 


