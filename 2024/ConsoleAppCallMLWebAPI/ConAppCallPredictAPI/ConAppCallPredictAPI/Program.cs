using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        var jsonPayload = "{\"passenger_count\": 1, \"trip_time_in_secs\": 1, \"trip_distance\": 45, \"payment_type\": \"CRD\", \"fare_amount\": 0}";

        using (var client = new HttpClient())
        {
            var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");
            var apiUrl = "https://localhost:49856/predict"; // Replace with your actual API URL

            var response = await client.PostAsync(apiUrl, content);
            
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                var thescore = ParseScoreValue(result);
                Console.WriteLine($"API response: {result}");
                Console.WriteLine("The score: {0}", thescore);
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode}");
            }
        }
    }

    public static double? ParseScoreValue(string response)
    {
        try
        {
            // Parse the response JSON
            JObject data = JObject.Parse(response);
            // Extract the score value
            double? score = data["score"]?.Value<double>();
            return score;
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error parsing response or score value not found: {e.Message}");
            return null;
        }
    }
}
