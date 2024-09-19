using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GDIDrawer;
using System.Threading;

namespace ConsoleApp1
{
    internal class Program
    {
        public enum ClickState
        {
            idle,
            armed
        }

        static public CDrawer drawer = new CDrawer();
        static Point startPoint;
        static Point endPoint;
        static ClickState state = ClickState.idle;

        static void Main(string[] args)
        {

            int i = 0;
            
            while (i < 10000)
            {
                

                if (state == ClickState.idle)
                {
                    bool userClicked = drawer.GetLastMouseLeftClick(out startPoint);

                    if (userClicked)
                    {

                        Console.WriteLine("First click");

                        // We have clicked in the idle state, aka we have clicked once, let's change the state to look for our second click
                        state = ClickState.armed;
                    }
                }
                else
                {
                    bool userClicked = drawer.GetLastMouseLeftClick(out endPoint);

                    if (userClicked)
                    {
                        Console.WriteLine("Second click");

                        // Your code would go here to make a line{

                        //}

                        // We have clicked for the second time, reset
                        state = ClickState.idle;
                    }
                }

                Thread.Sleep(1000);
                i++;
            }
            

        }
    }
}
