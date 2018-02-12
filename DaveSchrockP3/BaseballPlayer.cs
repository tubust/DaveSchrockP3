using System;
using System.Collections.Generic;
using System.Text;

namespace DaveSchrockP3
{
    public sealed class BaseballPlayer : Player
    {
        // Instance Varibles
        private int timesAtBat;
        private int numberOfHits;

        // Accessors
        public BaseballPlayer()
        {
            setTimesAtBat();
            setNumberOfHits();
        }
        public BaseballPlayer(int i, string n, double s, double c, int t, int nu)
            : base(i, n, s, c)
        {
            timesAtBat = t;
            numberOfHits = nu;
        }
        public BaseballPlayer(int i, string n)
            : base(i, n)
        {
            setSalary();
            setCommission();
            setTimesAtBat();
            setNumberOfHits();
        }


        // Mutators
        public void setTimesAtBat(int t)
        { timesAtBat = t; }
        public void setTimesAtBat()
        {
            bool getGoing = false;
            Console.Write("Please enter the number of times the player has been to bat: ");
            while (getGoing == false)
            {
                try
                {
                    timesAtBat = Int32.Parse(Console.ReadLine());
                    getGoing = true;
                }
                catch (FormatException)
                {
                    Console.Write("Error! Please enter the correct times at bat: ");
                }
            }
        }
        public void setNumberOfHits(int nu)
        {
            numberOfHits = nu;
        }
        public void setNumberOfHits()
        {
            bool getGoing = false;
            Console.Write("Please enter the number of hits: ");
            while (getGoing == false)
            {
                try
                {
                    numberOfHits = Int32.Parse(Console.ReadLine());
                    getGoing = true;
                }
                catch (FormatException)
                {
                    Console.Write("Error! Please enter the correct number of hits: ");
                }
            }
        }

        // Accessors
        public int getTimesAtBat()
        { return timesAtBat; }
        public int getNumberOfHits()
        { return numberOfHits; }

        // Effectors
        public override double calculateStats()
        {
            double average;
            average = (double)numberOfHits / timesAtBat;
            return average;
        }
        public override bool bankability()
        {
            double average;
            average = (double)numberOfHits / timesAtBat;
            if (average > .250)
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
