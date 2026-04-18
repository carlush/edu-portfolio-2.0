//#1
//var numbers = new List<int> { 12, 5, 8, 19, 3 };
//Console.WriteLine("Исходный список: " + string.Join(" ", numbers));
//numbers.Sort();
//int min = numbers[0];
//int max = numbers[numbers.Count - 1];
//numbers.Reverse();
//#2
//var phoneBook = new Dictionary<string, string>();
//phoneBook.Add("Анна", "8921-123-45-67");
//phoneBook.Add("Иван", "8931-555-77-88");
//phoneBook.Add("Ольга", "8905-111-22-33");
//Console.WriteLine("Номер Анны: " + phoneBook["Анна"]);
//#3
//using System.Collections;
//var clients = new Queue<string>();
//clients.Enqueue("Анна");
//clients.Enqueue("Иван");
//clients.Enqueue("Мария");
//clients.Enqueue("Олег");
//Console.WriteLine($"Первый в очереди: {clients.Peek()}");
//while (clients.Count > 0)
//{
//    string person = clients.Dequeue();
//    Console.WriteLine($"{person} обслужен");
//}
//#4
//var actions = new Stack<string>();
//actions.Push("Открыт документ");
//actions.Push("Написан текст");
//actions.Push("Удалён абзац");
//string lastAction = actions.Peek();
//Console.WriteLine($"Самое последнее действие: {lastAction}");
//Console.WriteLine(actions.Pop());
//Console.WriteLine(actions.Pop());
//Console.WriteLine(actions.Pop());
//#5
var prices = new Dictionary<string, int>
{
    { "Кофе", 150 },
    { "Чай", 100 },
    { "Сэндвич", 250 }
};
var customers = new Queue<string>();
customers.Enqueue("Анна");
customers.Enqueue("Иван");
var orderItems = new List<string> { "Кофе", "Сэндвич" };
while (customers.Count > 0)
{
    string name = customers.Dequeue();
    int sum = prices["Кофе"] + prices["Сэндвич"];

    Console.WriteLine(name + " купил(а) еды на " + sum + " руб.");
}