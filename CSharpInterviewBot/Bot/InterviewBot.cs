using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterviewBot.Bot
{
    public class InterviewBot
    {
        private InterviewQuestions interviewQuestions;
        private Introduction introduction
        private int currentTopicIndex;
        private int currentQuestionIndex;
        private List<string> currentTopicKeys;

        public InterviewBot()
        {
            interviewQuestions = new InterviewQuestions();
            introduction = new Introduction();
            currentTopicKeys = new List<string>(interviewQuestions.QuestionsByTopic.Keys);
            currentTopicIndex = 0;
            currentQuestionIndex = 0;
        }

        public async Task StartInterview()
        {
            introduction.SpeakIntroduction();
            Console.WriteLine("Let's start the interview!");
            await AskQuestion();
        }
    }
}
