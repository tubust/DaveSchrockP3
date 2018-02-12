using System;
using System.Collections.Generic;
using System.Text;

namespace DaveSchrockP3
{
    public class FootballPlayer : Player
    {
        // Insance Varibles
        private int numYards;
        private int numRushes;

        // Constructors
        public FootballPlayer()
        {
            setYards();
            setRushes();
        }
        public FootballPlayer(int i, string n)
            : base(i, n)
        {
            setSalary();
            setCommission();
            setYards();
            setRushes();
        }
        public FootballPlayer(int i, string n, double s, double c, int ny, int nr)
            : base(i, n, s, c)
        {
            numYards = ny;
            numRushes = nr;
        }

        // Mutators
        public void setYards(int ny)
        { numYards = ny; }
        public void setYards()
        {
            bool getGoing = false;
            Console.Write("Please enter the number of yards for this player: ");
            while (getGoing == false)
            {
                try
                {
                    numYards = Int32.Parse(Console.ReadLine());
                    getGoing = true;
                }
                catch (FormatException)
                {
                    Console.Write("Please enter the correct yards for this player: ");
                }
            }
        }
        public void setRushes(int nr)
        { numRushes = nr; }
        public void setRushes()
        {
            bool getGoing = false;
            Console.Write("Please enter the number of rushes: ");
            while (getGoing == false)
            {
                try
                {
                    numRushes = Int32.Parse(Console.ReadLine());
                    getGoing = true;
                }
                catch (FormatException)
                {
                    Console.Write("Error! Please enter the number of rushes: ");
                }
            }
        }

        // Accessors
        public int getYards()
        { return numYards; }
        public int getRushes()
        { return numRushes; }

        // Effector
        public override double calculateStats()
        {
            double average;
            average = (double)numYards / numRushes;
            return average;
        }
        public override bool bankability()
        {
            double average;
            average = (double)numYards / numRushes;
            if (average > 3.5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
