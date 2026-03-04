using System;

namespace Classwork
{
    public class Texts
    {

        public static string WelcomeMessage = "Welcome to the Cyber Security Chatbot!";
        public static string introductionMessage = "I am here to help you learn about cybersecurity. You can ask me questions about password security, phishing awareness, and safe browsing habits.";


        public static string[] confusedStatements =
        {
            "I'm not sure I understand. You can always ask me how i can help you!",
            "Could you please rephrase that? If you're not sure what to say, you can ask me how i am able to help you",
            "Sorry, I didn't catch that. if you're stuck, I am always open to share how i can help you"
        };

        public static string[] helpStatements =
        {
          "What can i Help you with today",
          "Anything you're curious about",
          "What burning questions do you have",
          "I'm sure i could answer anything you would like to ask"  
        };

        public static string GetRandomHelp()
        {
            return helpStatements[Random.Shared.Next(helpStatements.Length)];
        }

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

        public static string passwordSec = "Password security is essential for protecting your personal and professional information online. Use long, unique passwords that combine letters, numbers, and symbols, and avoid reusing them across different accounts. Enabling multi-factor authentication and using a trusted password manager can significantly reduce the risk of unauthorized access.";
        public static string phishingSec = "Phishing is a cyberattack where criminals impersonate trusted organizations—such as PayPal or Microsoft—to trick people into revealing sensitive information like passwords or credit card details. These scams often arrive via email, text, or fake websites that look legitimate. Always verify the sender, avoid clicking suspicious links, and enable security features like multi-factor authentication to stay protected.";
        public static string safeBrowseSec = "Safe browsing means using the internet in ways that protect your personal information and devices from threats. Stick to secure websites (look for HTTPS), avoid clicking suspicious links or pop-ups, and keep your browser and antivirus software updated. Practicing caution online helps reduce the risk of malware, scams, and data breaches.";
        public static string helpText = "I can help you with Phishing awareness, Safe browsing habits and password Security!";

    }
}