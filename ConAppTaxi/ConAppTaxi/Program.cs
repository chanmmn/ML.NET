using System;
using ConAppTaxiML.Model;

namespace ConAppTaxi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Add input data
            var input = new ModelInput();
            input.Passenger_count = 1;
            input.Trip_time_in_secs = 1271;
            input.Trip_distance = 3.8f;

            // Load model and predict output of sample data
            ModelOutput result = ConsumeModel.Predict(input);
            Console.WriteLine(result.Score);
        }
    }
}
