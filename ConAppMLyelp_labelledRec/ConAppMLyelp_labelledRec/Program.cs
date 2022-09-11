namespace ConAppMLyelp_labelledRec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Load sample data
            var sampleData = new MLModel1.ModelInput()
            {
                Column1 = @"Wow... Loved this place.",
            };

            //Load model and predict output
            var result = MLModel1.Predict(sampleData);
            Console.WriteLine(result.Prediction);
        }
    }
}