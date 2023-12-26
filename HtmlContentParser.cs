namespace LeetCodeRepo;
using  HtmlAgilityPack;
    

public class HtmlContentParser
{
    
    public string ParseInnerContent(string htmlContent)
    {
        var doc = new HtmlDocument();
        doc.LoadHtml(htmlContent);
        
        var bodyNode = doc.DocumentNode.SelectSingleNode("//body");
        return bodyNode?.InnerText ?? string.Empty;
    }
    
    
}