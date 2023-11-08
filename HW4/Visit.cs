using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW4
{
    
    class Visit
    {
        static int UserID = 0;
        private string Browser { get; set; }
        private string OS { get; set; }
        private string UserLanguage { get; set; }
        public struct AspectRatio
        {
            public int Width { get; set; }
            public int Height { get; set; }
            public AspectRatio(int width, int height)  
            {
                Width = width;
                Height = height;
            }
        }
        public AspectRatio ARistance { get; }
        public Visit(string browser, string os, string userLang, int width, int height)
        {
            UserID++;
            Browser = browser;
            OS = os;
            UserLanguage = userLang;
            ARistance = new AspectRatio(width, height);
            
        }
        public void Print()
        {
            Console.WriteLine($"ID: {UserID}");
            Console.WriteLine($"Browser: {Browser}");
            Console.WriteLine($"OS: {OS}");
            Console.WriteLine($"User Language: {UserLanguage}");
            Console.WriteLine($"Aspect Ratio: {ARistance.Width} X {ARistance.Height}");
            Console.WriteLine(" ");
        }
    }
}
