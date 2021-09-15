using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;

namespace Assignment1
{
    public static class RegExpr
    {
        public static IEnumerable<string> SplitLine(IEnumerable<string> lines)
        {
            foreach (var line in lines)
            {
                foreach (var word in Regex.Matches(line, @"\w+"))
                {
                    yield return word.ToString(); 
                } 
            }
        }

        public static IEnumerable<(int width, int height)> Resolution(IEnumerable<string> resolutions) 
        {
                foreach (var line in resolutions)
                { 
                    foreach (Match match in Regex.Matches(line, @"(?<horizontal>\d+)"+@"(?:x)"+@"(?<vertical>\d+)"))
                    {   
                        var width = Int32.Parse(match.Groups["horizontal"].Value);
                        var height = Int32.Parse(match.Groups["vertical"].Value); 
                        yield return (width, height);
                    } 
                }
        }

        public static IEnumerable<string> InnerText(string html, string tag)
        {
            var temp = "(?<tag>"+tag+")";   
            string pattern = @"(?:<"+temp+".*?)(?<=>)(?<text>.*?)(?=</\\k<tag>)";  
            foreach (Match match in Regex.Matches(html, pattern)) 
            {
                yield return Regex.Replace(match.Groups["text"].Value, @"(<.+?>)", "");
            }
        }
    
    }
}
