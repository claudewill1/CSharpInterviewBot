using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterviewBot
{
    public class Introduction
    {
        private string introduction = "Welcome! Thank you for taking the time to join us today.We’re excited to get to know you and learn more about your skills and experiences. " +
    "This interview is designed to give us a well-rounded view of your understanding and expertise as a C# .NET Developer.\n\n" +
    "We’ll be covering a few core areas that are essential for success in this role, starting with the principles of Object-Oriented Programming, or OOP. " +
    "Here, we’ll explore topics like encapsulation, inheritance, and polymorphism—key concepts that help developers design scalable, maintainable applications.\n\n" +
    "Next, we’ll discuss the .NET Framework and C# language features. We’ll look into aspects of the .NET environment, from the Common Language Runtime (CLR) " +
    "to memory management and garbage collection, as well as some specific features of C# that make it a versatile and powerful language for application development.\n\n" +
    "Following that, we’ll touch on Microsoft SQL, focusing on your understanding of relational database concepts. We’ll dive into areas like querying, joins, " +
    "primary and foreign keys, and other database principles that are essential for data-driven applications.\n\n" +
    "Finally, we’ll cover REST and SOAP APIs, exploring your knowledge of designing and consuming APIs, understanding HTTP methods, status codes, " +
    "and other foundational concepts of web services that allow different systems to communicate seamlessly.\n\n" +
    "Throughout the interview, please feel free to share examples or experiences that illustrate your answers. " +
    "We want to hear not only your technical knowledge but also how you apply these concepts in real-world scenarios.\n\n" +
    "So, let’s get started! We’re looking forward to a great conversation and wish you the best of luck. Let's begin with our first topic!";
        public Introduction() {}

        public void SpeakIntroduction()
        {
            Console.WriteLine(this.introduction);
        }
    }
}
