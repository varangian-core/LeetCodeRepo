
using System;
using System.Net.Http;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace LeetCodeRepo;
public class LeetCodeSnippet
{
    private HttpClient _client;

    public LeetCodeSnippet()
    {
        _client = new HttpClient();
    }
    
    public async Task<string> GetProblemDetails(string problemUrl)
    {
        var response = await _client.GetAsync(problemUrl);
        var pageContent= await response.Content.ReadAsStringAsync();
        
        //ExtractProblemContent(pageContent);
        return pageContent;
    }
    
}

