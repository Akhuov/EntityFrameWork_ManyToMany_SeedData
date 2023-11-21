
using ManyToManyEF;
using Microsoft.EntityFrameworkCore;

DataContext dataContext = new DataContext();


//var staff=dataContext.Staffs.Include(u=>u.Users).FirstOrDefault(s=>s.Id==2);

//Console.WriteLine("Bulimi nomi: " +staff.Name);

//foreach(var user in staff.Users)
//{
//    Console.WriteLine("Ishchilar:"+user.Name);
//}


var user=dataContext.Users.FirstOrDefault(u=>u.Id==2);

var books = dataContext.Books.Where(b => b.Id <= 2).ToList();


user.Books=books;
dataContext.SaveChanges();





var Dilmurod=dataContext.Users.Include(b=>b.Books).FirstOrDefault(user=>user.Id==2);

Console.WriteLine($"Yozuvchining ismi:{Dilmurod.Name}");

Console.WriteLine("Uning yozgan kitoblari:");
foreach (var item in Dilmurod.Books)
{
    Console.WriteLine(item.Name);
}
{

}
