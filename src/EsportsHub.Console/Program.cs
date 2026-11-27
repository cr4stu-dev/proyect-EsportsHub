using System;
using System.Collections.Generic;
using EsportsHub.Core.Models;
using EsportsHub.Console.Menus;

namespace EsportsHub.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MainMenu mainMenu = new MainMenu();
            mainMenu.Display();
        }
    }
}