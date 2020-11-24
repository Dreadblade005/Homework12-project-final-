/// Homework 12
/// File Name: 
/// @author: Dakota Durst
/// Date: November 23rd, 2020
///
/// Problem Statement: Create the Person class.
///Add at least 10 people to a list and create the following statements
///Find the people eligible for the kids menu. Those who are 12 or younger.
/// 
///
///
/// Overall Plan:
using System;
using System.Collections.Generic;

namespace part1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<person> mylist = new List<person>();
            person p1 = new person("Mark", 12, 6.2);
            person p2 = new person("Peter", 15, 5.1);
            person p3 = new person("Rose", 17, 5.10);
            person p4 = new person("June", 18, 5.9);
            person p5 = new person("Jim", 16, 6.3);
            person p6 = new person("Dakota", 20, 5.11);
            person p7 = new person("Jack", 11, 5.3);
            person p8 = new person("Peter", 13, 5.1);
            person p9 = new person("Maddie", 19, 5.8);
            person p10 = new person("Maleah", 25, 6.5);

            mylist.Add(p1);
            mylist.Add(p2);
            mylist.Add(p3);
            mylist.Add(p4);
            mylist.Add(p5);
            mylist.Add(p6);
            mylist.Add(p7);
            mylist.Add(p8);
            mylist.Add(p9);
            mylist.Add(p10);
            //1st requirment 
            //PersonGridView.DataSource = from a in mylist select a;
            //PersonGridView.DataSource = from a in mylist where a.Age <= 12 select a; 
            //PersonGridView.DataBind();

            //2nd requirement - average height
            //count 
            //int personCount = (from pa in mylist orderby pa.Name, pa.Height, pa.Age select pa).Count();
            int personCount = mylist.Count;
            double average = 0;
            double sum = 0;
            foreach (var pp in mylist)
            {
                sum += pp.Height;
            }
            average = sum / personCount;

            for (int i = 0; i < mylist.Count; i++)
            {
                if (average < mylist[i].getHeight())
                {
                    Console.WriteLine(mylist[i].returnPerson());
                }
            }
            for (int i = 0; i < mylist.Count; i++)
            {
                if (mylist[i].getAge() < 12)
                {
                    Console.WriteLine(mylist[i].youngPerson());
                }

            }
        }
        public class person
        {
            String name;
            int age;
            double height;
            public person(string name, int age, double height)
            {
                this.Name = name;
                this.Age = age;
                this.Height = height;
            }
            public double getHeight()
            {
                return height;
            }
            public int getAge()
            {
                return age;
            }
            public string returnPerson()
            {
                return "This person: " + name + " at age: " + age + " is taller then the average height, standing at: " + height;
            }
            public string youngPerson()
            {
                return "This person: " + name + " at age: " + age + " is elligible for the kids menu";
            }

            public string Name { get => name; set => name = value; }
            public int Age { get => age; set => age = value; }
            public double Height { get => height; set => height = value; }
        }
    }
}