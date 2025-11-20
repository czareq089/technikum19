using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class UIHandler : StringOperations
    {
        public PeriodicTimer timer;
        public double width;
        public double height;
        public bool atMainScreen {  get; set; }
        private List<string> menuScheme { get;  set; }

        public UIHandler()
        {
            width = Console.WindowWidth;
            height = Console.WindowHeight;
            CheckResize(TimeSpan.FromMilliseconds(50));
        }
        public void SetScheme(List<string> scheme)
        {
            menuScheme = scheme;
        }

        public List<string> GetScheme()
        {
            return menuScheme;
        }
        
        public void setAtMainScreen(bool atMainScreen)
        {
            this.atMainScreen = atMainScreen;
        }

        public bool getAtMainScreen()
        {
            return atMainScreen;
        }
        async void CheckResize(TimeSpan time)
        {
            timer = new PeriodicTimer(time);
            double[] buffer = new double[2];
            while (await timer.WaitForNextTickAsync())
            {
                atMainScreen = getAtMainScreen();
                width = Console.WindowWidth;
                height = Console.WindowHeight;
                if (buffer[0] == 0 && buffer[1] == 0)
                {
                    buffer[0] = width;
                    buffer[1] = height;
                }
                else if (buffer[0] != width && atMainScreen)
                {
                    Console.Clear();
                    DrawUI();
                    buffer[0] = width;
                }
                else if (buffer[1] != height && atMainScreen)
                {
                    Console.Clear();
                    DrawUI();
                    buffer[1] = height;
                }
            }
        }

        public void DrawUI()
        {    
            FileHandler fileHandler = new FileHandler();
            menuScheme = GetScheme();
            var logLines = fileHandler.ReadFile();

            int maxLines = Math.Max(menuScheme.Count, logLines.Count);

            for (int i = 0; i < maxLines; i++)
            {
                string leftSide = i < menuScheme.Count ? menuScheme[i] : ""; 
                string rightSide = i < logLines.Count ? logLines[i] : "";

                double center = CalculateCenterAndOffset(width, leftSide);

                Console.WriteLine(leftSide + PrintXChars(center, ' ') + "|" + rightSide);
            }
            for(int i = maxLines; i < height - 4; i++)
            {
                double center = CalculateCenterAndOffset(width, "");
                Console.WriteLine(PrintXChars(center, ' ') + "|");
            }
        }
    }
}
