using System;

namespace interface234
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    class Player : IPlayable, IRecodable
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
        public void Record()
        {
            System.Console.WriteLine("It is recording");
        }
        public void Stop2 ()
        {
            System.Console.WriteLine("Recording has been stopped");
        }

    }
    interface IPlayable
    {
        public void Play();
        public void Pause ();
        public void Stop ();

    }
    interface IRecodable
    {
        void Record();
        void Pause ();
        void Stop2 ();
    }
}
