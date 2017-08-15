using System;

namespace marbles_dotnet
{
    class Program
    {
        public class MarbleBag
        {
            public int NumberOfGreenMarbles { get; set; } = 0;
            public int NumberOfBlueMarbles { get; set; } = 0;
            public int NumberOfRedMarbles { get; set; } = 0; 
        

            public MarbleBag(int greenMarbles, int redMarbles, int blueMarbles)
            {
                NumberOfGreenMarbles = greenMarbles;
                NumberOfBlueMarbles = blueMarbles;
                NumberOfRedMarbles= redMarbles;
            }

            public override string ToString()
            {
                return $"I have {NumberOfGreenMarbles} green marbles, {NumberOfBlueMarbles} blue marbles, and {NumberOfRedMarbles} red marbles.";
            }

        }
        static void Main(string[] args)
        {
            var marbles = new MarbleBag(5,6,7);
            Console.WriteLine(marbles);

        }
    }
}
