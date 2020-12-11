using ConAppDiamondML.Model;
using System;

namespace ConAppDiamond
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Add input data
            var input = new ModelInput();
            input.Carot = 1.01f;

            // Load model and predict output of sample data
            ModelOutput result = ConsumeModel.Predict(input);
            Console.WriteLine(result.Score);
        }
    }
}
