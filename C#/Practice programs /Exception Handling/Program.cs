using ConsoleApp1;

ExceptionHandling exceptionHandling = new(10,0,0,1);
//Console.WriteLine(exceptionHandling.Add());
Console.WriteLine(exceptionHandling.Add());
try
{
    Console.WriteLine(exceptionHandling.Div());
    exceptionHandling.CheckAge();
}
catch(Exception ex)
{
    Console.WriteLine($"{ex.Message}");
}