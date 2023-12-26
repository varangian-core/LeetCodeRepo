using System;
using System.IO;
using System.Threading.Tasks;

namespace LeetCodeRepo
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            var leetCodeSnippet = new LeetCodeSnippet();
            var problemUrl = "https://leetcode.com/problems/two-sum/description/";
            var problemContent = await LeetCodeSnippet.GetProblemDetails(problemUrl); 
            
            var parser = new HtmlContentParser();
            var innerContent = parser.ParseInnerContent(problemContent);


            var uri = new Uri(problemUrl);
            var segments = uri.Segments;
            var problemName = segments.Length >= 3 ? segments[2].TrimEnd() : "unknown";
            
           var fileName = $"{problemName}.html"; 
            

            Console.WriteLine("innerContent"  + problemContent.ToString());
            
            var relativePath = @"../../buffers";
            var filePath= Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), relativePath));
            var buffersDir = Path.Combine(Directory.GetCurrentDirectory(), "buffers");
            if (!Directory.Exists(buffersDir))
            {
                Directory.CreateDirectory(buffersDir);
            }

            using (var writer = new StreamWriter(filePath, false))
            {
                await writer.WriteAsync(innerContent);
            } 

            Console.WriteLine($"Content saved to {filePath}");
        }
    }
}