
using System;
using System.Net.Http;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace LeetCodeRepo;
public class LeetCodeSnippet
{
    private static HttpClient _client;

    public LeetCodeSnippet()
    {
        _client = new HttpClient();
    }
    
    public static async Task<string> GetProblemDetails(string problemUrl)
    {
        var response = await _client.GetAsync(problemUrl);
        var pageContent= await response.Content.ReadAsStringAsync();
        return pageContent;
    }
    
}

