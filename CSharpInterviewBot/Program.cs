using CSharpInterviewBot.Bot;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static async Task Main(string[] args)
    {
        
        InterviewBot bot = new InterviewBot();
        await bot.StartInterview();
    }
}