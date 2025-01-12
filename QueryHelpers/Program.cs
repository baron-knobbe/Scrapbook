using QueryHelpers;

Console.WriteLine("Query Helpers");

RunConverter();


static void RunConverter()
{
    var url = "https://api.example.com?$filter=contains(name, 'John') and age eq 30&$select=name, age, city&$orderby=name desc";
    var query = OdataToSqlConverter.Convert(url);

    Console.WriteLine(query);

    Console.WriteLine("Completed!");
}
