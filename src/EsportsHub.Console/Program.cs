using System;
using System.Collections.Generic;
using EsportsHub.Core.Models;

namespace EsportsHub.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Team team = new Team
            {
                Id = 1,
                Name = "Team Liquid"
            };
            System.Console.WriteLine($"Hello, {team.Name}!");
        }
    }
}