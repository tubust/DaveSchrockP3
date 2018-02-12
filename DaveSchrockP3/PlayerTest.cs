using System;
using System.Collections.Generic;
using System.Text;

namespace DaveSchrockP3
{
    class PlayerTest
    {
        static void Main(string[] args)
        {
            Player[] players = new Player[4];
            players[0] = new BaseballPlayer(11, "Babe Ruth", 100000, .10, 600, 200);
            players[1] = new BaseballPlayer(12, "Casey Attheba", 150000, .05, 50, 5);
            players[2] = new FootballPlayer();
            players[3] = new FootballPlayer(14, "Wrong Way Woods");

            Console.WriteLine("Dave Schrock's Client List");
            Console.WriteLine();
            Console.WriteLine(" {0,40} ", "Commission");
            Console.WriteLine();
            Console.WriteLine("{0,-2} {1,-15} {2,-16} {3,17} {4,-6} {5,-14} ", "ID", "NAME", "SALARY", "COMMISSION RATE", "STATISTICS", "STATUS");
            Console.WriteLine("================================================================================");
            Console.WriteLine();
            for (int v = 0; v < 4; v++)
            {
                Console.WriteLine("{0,-2} {1,-21} {2,11:C} {3,15:F2} {4,11:F3} {5,8} ", players[v].getId(), players[v].getName(), players[v].getSalary(), players[v].getCommission(), players[v].calculateStats(),displayStatus(players[v].bankability()));
            }
            Console.WriteLine();
            Console.WriteLine("Total number of players: {0}", Player.getCounter());
            Console.ReadLine();
        }
        public static string displayStatus(bool b)
        {
             if (b == true)
             {
                   return "Keep Player";
             }
             else
             {
                    return "Ditch Player";
             }
        }
    }
}

