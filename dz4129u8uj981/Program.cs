using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

var firms = new List<Firm>
{
    new Firm { Name = "Food Master", FoundationDate = new DateTime(2020, 1, 1), BusinessProfile = "Маркетинг", DirectorName = "John White", EmployeeCount = 50, Address = "Лондон" },
    new Firm { Name = "Tech Soft", FoundationDate = new DateTime(2018, 5, 20), BusinessProfile = "IT", DirectorName = "Bill Gates", EmployeeCount = 150, Address = "Нью-Йорк" },
    new Firm { Name = "Marketing Pro", FoundationDate = new DateTime(2022, 3, 10), BusinessProfile = "Маркетинг", DirectorName = "Alice Smith", EmployeeCount = 20, Address = "Лондон" },
    new Firm { Name = "Super Food", FoundationDate = new DateTime(2015, 8, 15), BusinessProfile = "Харчова промисловість", DirectorName = "Bob Black", EmployeeCount = 350, Address = "Париж" },
    new Firm { Name = "White Solutions", FoundationDate = DateTime.Now.AddDays(-123), BusinessProfile = "IT", DirectorName = "James Black", EmployeeCount = 80, Address = "Берлін" },
    new Firm { Name = "Creative IT", FoundationDate = new DateTime(2010, 11, 2), BusinessProfile = "IT", DirectorName = "Sarah White", EmployeeCount = 250, Address = "Лондон" }
};

Console.WriteLine("Завдання 1");

var q1 = from f in firms select f;
Print(q1, "Всі фірми:");

var q2 = from f in firms where f.Name.Contains("Food") select f;
Print(q2, "Фірми зі словом Food:");

var q3 = from f in firms where f.BusinessProfile == "Маркетинг" select f;
Print(q3, "Маркетинг:");

var q4 = from f in firms where f.BusinessProfile == "Маркетинг" || f.BusinessProfile == "IT" select f;
Print(q4, "Маркетинг або IT:");

var q5 = from f in firms where f.EmployeeCount > 100 select f;
Print(q5, "Більше 100 співробітників:");

var q6 = from f in firms where f.EmployeeCount >= 100 && f.EmployeeCount <= 300 select f;
Print(q6, "Від 100 до 300 співробітників:");

var q7 = from f in firms where f.Address == "Лондон" select f;
Print(q7, "Лондон:");

var q8 = from f in firms where f.DirectorName.Contains("White") select f;
Print(q8, "Директор White:");

var q9 = from f in firms where (DateTime.Now - f.FoundationDate).TotalDays > 365 * 2 select f;
Print(q9, "Більше 2 років:");

var q10 = from f in firms where (DateTime.Now - f.FoundationDate).Days == 123 select f;
Print(q10, "123 дні з дати заснування:");

var q11 = from f in firms where f.DirectorName.Contains("Black") && f.Name.Contains("White") select f;
Print(q11, "Директор Black і назва White:");

Console.WriteLine();
Console.WriteLine("Завдання 2");

var m1 = firms.Select(f => f);
Print(m1, "Всі фірми:");

var m2 = firms.Where(f => f.Name.Contains("Food"));
Print(m2, "Фірми зі словом Food:");

var m3 = firms.Where(f => f.BusinessProfile == "Маркетинг");
Print(m3, "Маркетинг:");

var m4 = firms.Where(f => f.BusinessProfile == "Маркетинг" || f.BusinessProfile == "IT");
Print(m4, "Маркетинг або IT:");

var m5 = firms.Where(f => f.EmployeeCount > 100);
Print(m5, "Більше 100 співробітників:");

var m6 = firms.Where(f => f.EmployeeCount >= 100 && f.EmployeeCount <= 300);
Print(m6, "Від 100 до 300 співробітників:");

var m7 = firms.Where(f => f.Address == "Лондон");
Print(m7, "Лондон:");

var m8 = firms.Where(f => f.DirectorName.Contains("White"));
Print(m8, "Директор White:");

var m9 = firms.Where(f => (DateTime.Now - f.FoundationDate).TotalDays > 365 * 2);
Print(m9, "Більше 2 років:");

var m10 = firms.Where(f => (DateTime.Now - f.FoundationDate).Days == 123);
Print(m10, "123 дні з дати заснування:");

var m11 = firms.Where(f => f.DirectorName.Contains("Black") && f.Name.Contains("White"));
Print(m11, "Директор Black і назва White:");

void Print(IEnumerable<Firm> list, string naming)
{
    Console.WriteLine(naming);
    foreach (var item in list)
    {
        Console.WriteLine($"{item.Name} - {item.BusinessProfile} - {item.DirectorName}");
    }
    Console.WriteLine();
}

class Firm
{
    public string Name { get; set; }
    public DateTime FoundationDate { get; set; }
    public string BusinessProfile { get; set; }
    public string DirectorName { get; set; }
    public int EmployeeCount { get; set; }
    public string Address { get; set; }
}
