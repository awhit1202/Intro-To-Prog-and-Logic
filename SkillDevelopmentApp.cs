using System;

namespace SkillDevelopmentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
            Console.WriteLine("Welcome to the Skill Development Game!");
            Console.WriteLine("You'll face scenarios to improve your work habits in various skills like manners, time management, teamwork, and problem-solving.");
            Console.WriteLine("Answer the questions, and you'll get feedback based on your responses. Let's get started!");

            score += AskMannersScenario();

            score += AskTimeManagementScenario();

            score += AskTeamworkScenario();

            score += AskProblemSolvingScenario();

            Console.WriteLine("\nYour total score: " + score);
            ProvideFeedback(score);
        }

        static int AskMannersScenario()
        {
            Console.WriteLine("\nScenario 1: You receive a rude email from a colleague. How do you respond?");
            Console.WriteLine("1. Reply angrily and point out their mistakes.");
            Console.WriteLine("2. Reply politely and ask for clarification.");
            Console.WriteLine("3. Ignore the email and pretend it didn’t happen.");

            string answer = Console.ReadLine();

            if (answer == "2")
            {
                Console.WriteLine("Great job! Responding politely shows good manners.");
                return 10;
            }
            else
            {
                Console.WriteLine("That's not the best choice. It's better to maintain professionalism.");
                return 0;
            }
        }

        static int AskTimeManagementScenario()
        {
            Console.WriteLine("\nScenario 2: You have multiple tasks to complete with tight deadlines. What do you do?");
            Console.WriteLine("1. Start working on the most fun task first.");
            Console.WriteLine("2. Prioritize tasks by importance and urgency.");
            Console.WriteLine("3. Wait for someone to assign the order of tasks.");

            string answer = Console.ReadLine();

            if (answer == "2")
            {
                Console.WriteLine("Excellent choice! Prioritizing tasks is a key time management skill.");
                return 10;
            }
            else
            {
                Console.WriteLine("That could lead to missed deadlines. It's important to prioritize effectively.");
                return 0;
            }
        }

        static int AskTeamworkScenario()
        {
            Console.WriteLine("\nScenario 3: You’re working with a team, but one member isn’t contributing. What do you do?");
            Console.WriteLine("1. Complain to the manager about the team member.");
            Console.WriteLine("2. Offer to help the team member and encourage their participation.");
            Console.WriteLine("3. Do all the work yourself to avoid delays.");

            string answer = Console.ReadLine();

            if (answer == "2")
            {
                Console.WriteLine("Great choice! Teamwork is about helping each other and collaborating.");
                return 10;
            }
            else
            {
                Console.WriteLine("That’s not the best approach. Collaboration works better when everyone is involved.");
                return 0;
            }
        }

        static int AskProblemSolvingScenario()
        {
            Console.WriteLine("\nScenario 4: You face a complex problem with no obvious solution. What do you do?");
            Console.WriteLine("1. Panic and hope someone else solves it.");
            Console.WriteLine("2. Break the problem into smaller parts and analyze each.");
            Console.WriteLine("3. Do nothing and wait for the problem to resolve itself.");

            string answer = Console.ReadLine();

            if (answer == "2")
            {
                Console.WriteLine("Excellent! Breaking down complex problems is a great problem-solving technique.");
                return 10;
            }
            else
            {
                Console.WriteLine("That might lead to inaction. Analyzing the problem is key to finding a solution.");
                return 0;
            }
        }

        static void ProvideFeedback(int score)
        {
            if (score == 40)
            {
                Console.WriteLine("\nFantastic job! You're on your way to developing great work habits.");
            }
            else if (score >= 30)
            {
                Console.WriteLine("\nGood work! You're doing well, but there are areas to improve.");
            }
            else
            {
                Console.WriteLine("\nKeep practicing! There’s room for improvement in your skills.");
            }
        }
    }
}