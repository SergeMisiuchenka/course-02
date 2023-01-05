using System;
//Создайте 2 интерфейса IPlayable и IRecodable. В каждом из интерфейсов создайте по 3 метода 
//void Play() / void Pause() / void Stop() и void Record() / void Pause() / void Stop() соответственно.
//Создайте производный класс Player от базовых интерфейсов IPlayable и IRecodable. 
//Написать программу, которая выполняет проигрывание и запись. 

namespace Task2
{

    interface IPlayable
    {
        void Play();    
        void Pause();
        void Stop();
    }
    interface IRecodable
    {
        void Record();
        void Pause();
        void Stop();
    }
    class Player : IPlayable, IRecodable
    {
        public void Play()
        {
            Console.WriteLine("Play play");
        }
        public void Pause()
        {
            Console.WriteLine("Play pause");
        }
        public void Stop()
        {
            Console.WriteLine("Play stop");
        }
        public void Record()
        {
            Console.WriteLine("Play record");
        }
    }
    class Program
    {
        
        static void Main()
        {
            IPlayable music = new Player();
            IRecodable music2 = new Player();

            music.Play();
            music.Pause();
            music.Stop();
            
            Console.WriteLine(new string('-', 55 ));

            music2.Record();
            music2.Pause();
            music2.Stop();
        }
    }
}
