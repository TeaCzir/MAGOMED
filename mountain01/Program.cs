//Если Магомед не идет к горе, то гора идет к Магомеду.
Console.Clear();
Console.Write("Ты Магомед? ");
string answer= Console.ReadLine();
if(answer.ToLower() =="да")
{
   Console.WriteLine("Магомед не идет к горе, а х#ярит от нее, что есть мочи.");
   Console.WriteLine("Это ОПОЛЗЕНЬ.");
}
if(answer.ToLower() =="нет")
{
   Console.WriteLine("Пи#дуй от туда.");
   Console.WriteLine("Это ОПОЛЗЕНЬ.");
}