using System;

namespace Classwork
{
    public class Texts
    {

        public static string WelcomeMessage = "Welcome to the Cyber Security Chatbot!";


        public static string[] confusedStatements =
        {
            "I'm not sure I understand. You can always ask me how i can help you!",
            "Could you please rephrase that? If you're not sure what to say, you can ask me how i am able to help you",
            "Sorry, I didn't catch that. if you're stuck, I am always open to share how i can help you"
        };

        public static string GetRandomFeeling()
        {
            return feelingStatements[Random.Shared.Next(feelingStatements.Length)];
        }

        public static string GetRandomConfused()
        {
            return confusedStatements[Random.Shared.Next(confusedStatements.Length)];
        }

        public static string[] feelingStatements =
        {
          "I'm doing great! And Excited to help you learn!",
          "In a wonderful mood to help you understand cybersecurity better",
          "Feeling amazing and especially helpful",
          "Absolutely electric, and brimming with cybersecurity knowledge!"
        };
        public static int ranIndFeeling = Random.Shared.Next(feelingStatements.Length);

        public static string passwordSec = "TODO password content";
        public static string phishingSec = "TODO phishing content";
        public static string safeBrowseSec = "TODO browse content";
        public static string helpText = "I can help you with Phishing awareness, Safe browsing habits and password Security!";

    }
}