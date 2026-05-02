using System.Linq;
using System;
using System.Collections.Generic;
using Balta.ContentContext;
using Balta.SubscriptionContext;

namespace Balta
{
    class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Artigo Sobre OOP", "orientacao-objeto"));
            articles.Add(new Article("Artigo Sobre OOP2", "orientacao-objeto2"));
            articles.Add(new Article("Artigo Sobre OOP3", "orientacao-objeto3"));

            foreach (var article in articles)
            {
                Console.WriteLine(article.Id);
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Url);

            }

            var course = new Course("Fundamentos OOP", "oop-course");
            var course2 = new Course("Fundamentos OOP2", "oop-course2");
            var course3 = new Course("Fundamentos OOP3", "oop-course3");

            var courses = new List<Course>();
            courses.Add(course);
            courses.Add(course2);
            courses.Add(course3);

            var careers = new List<Career>();
            var career = new Career("Especialista dotnet", "especialista-dotnet");

            var carrerItem = new CareerItem(1, "Comece por Aqui", "", null);
            var carrerItem2 = new CareerItem(2, "Comece por Aqui2", "", course2);
            var carrerItem3 = new CareerItem(3, "Comece por Aqui3", "", course3);



            career.Items.Add(carrerItem);
            career.Items.Add(carrerItem2);
            career.Items.Add(carrerItem3);


            careers.Add(career);

            foreach (var c in careers)
            {
                Console.WriteLine(c.Title);

                foreach (var i in c.Items.OrderBy(x => x.Order))
                {
                    Console.WriteLine(i.Title);
                    Console.WriteLine(i.Course?.Title);
                }
            }

            foreach (var notification in carrerItem.Notifications)
            {
                Console.WriteLine(notification.Property);
                Console.WriteLine(notification.Message);

            }

            var payPalSubscription = new PayPalSubscription();
            var student = new Student();
            student.createSubscription(payPalSubscription);


        }
    }
}
