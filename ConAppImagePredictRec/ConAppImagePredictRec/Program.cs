namespace ConAppImagePredictRec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Load sample data
            var imageBytes = File.ReadAllBytes(@"C:\test\ML\data\flower.jpg");
            MLModel1.ModelInput sampleData = new MLModel1.ModelInput()
            {
                ImageSource = imageBytes,
            };

            //Load model and predict output
            var result = MLModel1.Predict(sampleData);
            Console.WriteLine(result.PredictedLabel);
        }
    }
}