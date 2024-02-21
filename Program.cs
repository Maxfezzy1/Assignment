internal class Program
{
    private static void Main(string[] args)
    {
        List<Teacher> teacherList = new List<Teacher>()
        {
            new Teacher{ID = 001, Name = "Chibuzor", Age = 23, colour = "Brown", LastJob = "Capenter"},
            new Teacher{ID = 002, Name = "Mary", Age = 33, colour = "Blue", LastJob = "Tailor"},
            new Teacher{ID = 003, Name = "John", Age = 20, colour = "Black", LastJob = "Farmer"},
            new Teacher{ID = 004, Name = "Joshua", Age = 15, colour = "Red", LastJob = "Driver"},
            new Teacher{ID = 005, Name = "Max", Age = 13, colour = "Green", LastJob = "Chef"},
        };

        var teachers = from t in teacherList
                       select new Teacher() { Name = t.Name, Age = t.Age };
        foreach (var teacher in teachers)
        {
            Console.WriteLine(teacher.Name + " " + teacher.Age);
        }

        //Console.WriteLine("Do you want to buy a coffe - Yes or No");
        //string UserDecision = Console.ReadLine();

        //switch(UserDecision.ToUpper())
        //{
        //    case "YES":
        //        Console.WriteLine("Thank you");
        //        break;

        //    case "NO":
        //        Console.WriteLine("No Problem");
        //        break;
        //        default: Console.WriteLine("this {0} is not a valid answer",UserDecision); break;

        //}



    }
}

public class Teacher
{ 
    public int ID {  get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string colour { get; set; }
    public string LastJob { get; set; }



}