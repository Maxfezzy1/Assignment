internal class Program
{
    private static void Main(string[] args)
    {
        //queue
       Queue<string> Names = new Queue<string>();
        Names.Enqueue("Victor");
        Names.Enqueue("Miracle");
        Names.Enqueue("Joy");
        Names.Enqueue("Mimi");
        Names.Enqueue("Ifenna");

        Console.WriteLine("There are {0} ready to play this Game", Names.Count());

        var Eliminate = Names.Dequeue();
        Console.WriteLine("{0} has been Eliminated from the Game",Eliminate);

        Console.WriteLine("There are {0} left in this Game", Names.Count());

        var Eliminate2 = Names.Dequeue();
        var Eliminate3 = Names.Dequeue();
        Console.WriteLine("{0} & {1} has also been eliminated from the game",Eliminate2, Eliminate3);

        Console.WriteLine("So Ladies and Gentlemen we have {0} left in this Game",Names.Count());

        var Eliminate4 = Names.Dequeue();
        var Eliminate5 = Names.Dequeue();

        Console.WriteLine("Sadly {0} has been eliminated & your WINNER is {1}", Eliminate4,Eliminate5);

        Console.WriteLine("THE STACK IS BELOW..................");

        //Stack
        Stack<int> Cash = new Stack<int>();
        Cash.Push(100);
        Cash.Push(200);
        Cash.Push(300);
        Cash.Push(400);
        Cash.Push(500);

        Console.WriteLine("There are {0} people keeping Cash with me",Cash.Count());

        while(Cash.Count() > 0)
        {
            Console.WriteLine(Cash.Pop());
        }
        Console.WriteLine("There are {0} people keeping Cash with me", Cash.Count());




    }
}

