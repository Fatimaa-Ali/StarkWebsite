using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        // Prompt user to input Urdu phrase
        Console.WriteLine("Enter your Urdu phrase:");
        string userInput = Console.ReadLine();

        // Send request to ChatGPT API
        string explanation = await GetExplanationFromChatGPT(userInput);

        // Display explanation to the user
        Console.WriteLine("Explanation: " + explanation);
    }

    static async Task<string> GetExplanationFromChatGPT(string phrase)
    {
        // API endpoint for ChatGPT
        string apiUrl = "https://api.openai.com/v1/completions";

        // Your OpenAI API key
        string apiKey = "YOUR_API_KEY";

        // Prepare request payload
        var requestData = new
        {
            prompt = phrase,
            max_tokens = 50, // Adjust as needed
            model = "text-davinci-003" // Choose appropriate ChatGPT model
        };

        // Send POST request to ChatGPT API
        using (var client = new HttpClient())
        {
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + apiKey);
            var response = await client.PostAsJsonAsync(apiUrl, requestData);
            if (response.IsSuccessStatusCode)
            {
                // Parse and return the explanation from the response
                var responseData = await response.Content.ReadAsAsync<dynamic>();
                return responseData.choices[0].text.Trim();
            }
            else
            {
                // Handle error response
                return "Error: Unable to get explanation from ChatGPT API";
            }
        }
    }
}
