namespace ConAppMLDBRec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Load sample data
            var sampleData = new MLModel1.ModelInput()
            {
                Vendor_id = @"VTS",
                Rate_code = 1F,
                Passenger_count = 1F,
                Trip_time_in_secs = 120F,
                Trip_distance = 0.89F,
                Payment_type = @"CSH",
            };

            //Load model and predict output
            var result = MLModel1.Predict(sampleData);

            Console.WriteLine(result.Score);    
        }
    }
}