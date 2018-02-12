using System;
using System.Collections.Generic;
using System.Text;

namespace DaveSchrockP3
{
    public interface IBankable
    {
        double calculateStats();
        bool bankability();
    }
    abstract public class Player : IBankable
    {
        // class counter
        private static int counter;
        //  Instance Varibles
        private int id;
        private string name;
        private double salary;
        private double commissionRate;

        // Constructors
        public Player()
        {
            counter++;
            setId();
            setName();
            setSalary();
            setCommission();
        }
        public Player(int i, string n)
        {
            counter++;
            id = i;
            name = n;
        }
        public Player(int i, string n, double s, double c)
        {
            counter++;
            id = i;
            name = n;
            salary = s;
            commissionRate = c;
        }

        // Mutators
        public void setId(int i)
        { id = i; }
        public void setId()
        {
            bool getGoing = false;
            Console.Write("Enter the players ID: ");
            while (getGoing == false)
            {
                try
                {
                    id = Int32.Parse((Console.ReadLine()));
                    getGoing = true;
                }
                catch (FormatException)
                {
                    Console.Write("Error! Please enter the correct ID: ");
                }
            }
        }
        public void setName(string n)
        { name = n; }
        public void setName()
        {
            Console.Write("Enter the players name: ");
            name = Console.ReadLine();
        }
        public void setSalary(double s)
        { salary = s; }
        public void setSalary()
        {
            bool getGoing = false;
            Console.Write("Please enter {0}'s salary: ",name);
            while (getGoing == false)
            {
                try
                {
                    salary = double.Parse(Console.ReadLine());
                    getGoing = true;
                }
                catch (FormatException)
                {
                    Console.Write("Error! Please enter {0}'s salary: ",name);
                }
            }
        }
        public void setCommission(double c)
        {
            commissionRate = c;
        }

        public void setCommission()
        {
            bool getGoing = false;
            Console.Write("Enter the commission rate: ");
            while (getGoing == false)
            {
                try
                {
                    commissionRate = double.Parse(Console.ReadLine());
                    while (commissionRate > 1)
                    {
                        Console.WriteLine("Your commission cannot be greater than 100%");
                        Console.Write("Enter the commission rate: ");
                        commissionRate = double.Parse(Console.ReadLine());
                    }
                    getGoing = true;
                }
                catch (FormatException)
                {
                    Console.Write("Error! Please enter your commission rate: ");
                }
            }
        }

        // Accessors
        public int getId()
        { return id; }
        public string getName()
        { return name; }
        public double getSalary()
        { return salary; }
        public double getCommission()
        { return commissionRate; }
        public static int getCounter()
        { return counter; }


        // Effectors
        public double calculateCommission()
        {
            double pay;
            pay = salary * commissionRate;
            return pay;
        }
        abstract public double calculateStats();
        abstract public bool bankability();
    }
}
