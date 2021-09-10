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
                foreach (var word in Regex.Split(line, @"\W"))
                {
                    yield return word; 
                } 
            }
        }

        public static IEnumerable<(int width, int height)> Resolution(string resolutions)
        {
            //(?<vertical>\d+)(?:x)(?<horizontal>\d+)
            foreach (var line in resolutions)
            {
                foreach (var word in Regex.Matches(line, @"(?<horizontal>\d+)(?:x)(?<vertical>\d+)"))
                {
                    Console.WriteLine(word);
                    yield return Int32.Parse(word);
                    //yield return word;
                } 
            }
        }

        public static IEnumerable<string> InnerText(string html, string tag)
        {
            throw new NotImplementedException();
        }
    }
}
