using System;
using System.Threading.Tasks;

namespace LeetCodeRepo
{
    class Program
    {
        public async Task Main(string[] args)
        {
            var leetCodeSnippet = new LeetCodeSnippet();
            var problemUrl = "https://leetcode.com/problems/two-sum/description/";
            var problemContent = await LeetCodeSnippet.GetProblemDetails(problemUrl); //let's think if we want this to be static
            
            var parser = new HtmlContentParser();
            var innerContent = parser.ParseInnerContent(problemContent);


            Console.WriteLine("innerContent"  + problemContent.ToString());


        }
    }
}