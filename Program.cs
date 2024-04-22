using System.IO.Pipes;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Client starting...");

        using(var clientStream=new AnonymousPipeClientStream(PipeDirection.In, args[0]))
        {
            using(var reader=new StreamReader(clientStream))
            {
                string? message;

                while((message=reader.ReadLine())!="")
                Console.WriteLine(message);
            }
        }
    }
}
