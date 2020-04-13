using System;

namespace interface234
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Player : IPlayable, IRecodable
    {
        

    }
    interface IPlayable
    {
        public void Play()
        {
            System.Console.WriteLine("Can you hear this? It is playing");
        }
        public void Pause ()
        {
            System.Console.WriteLine("Playing has been paused");
        }
        public void Stop ()
        {
            System.Console.WriteLine("Playing has been stopped");
        }

    }
    interface IRecodable
    {
        public void Record()
        {
            System.Console.WriteLine("It is recording");
        }
        public void Pause ()
        {
            System.Console.WriteLine("Recoding has been paused");
        }
        public void Stop ()
        {
            System.Console.WriteLine("Recording has been stopped");
        }
    }
}
