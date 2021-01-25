using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUconversation
{
    //
    // Author:Pearl,Nathan
    //
    class Program
    {

        static void Main(string[] args)
        {
            //
            //set theme
            //
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Beep();


            //
            //variables
            //
            string userName;
            string userResponse;
            string userOpinion;
            int age;
            string sports;

            //
            // greet user
            //
            Console.WriteLine("HELLO! Welcome to my world in this vast sea of the web.");
            Console.WriteLine();
            Console.WriteLine("My creator named me Streammy.");

            //
            // get user name
            //
            Console.WriteLine();
            Console.Write("What did your creators name you?");
            userName = Console.ReadLine();
            Console.WriteLine("{0} it is nice to meet you.", userName);

            //
            //get the user's age
            //
            Console.WriteLine();
            Console.WriteLine("How many years ago did your creator bring you into this world?");
            userResponse = Console.ReadLine();
            age = int.Parse(userResponse);
            //Console.WriteLine($"{0}, you are {1} days old.", userName, age);
            Console.WriteLine($"{userName}, you are {age / 0.00273785078} days old.");
            Console.WriteLine("My creator only made me 0.00273785078 years ago or 1 day ago.");


            //
            //ask if the user like sports
            //
            Console.WriteLine();
            Console.WriteLine("Do you like sports?");
            userResponse = Console.ReadLine().ToLower();

            //
            //respond based on whether the user likes sports
            //
            if (userResponse == "yes")
            {
                Console.WriteLine("That must be nice. I can only play the dinosaur game when the internet is down, and online chess.");

                //
                // if yes ask what their favorite sport is
                //
                Console.WriteLine();
                Console.WriteLine("What is your favorite sport?");
                sports = Console.ReadLine();

                if (userResponse == "no")
                {
                    Console.WriteLine("I'm sorry to here that you dont like sports, That dosent seem like a nomal human answer.");
                }
                //
                // respond to the user based on sports
                //
                if (sports == "basketball")
                {
                    Console.WriteLine("You are wiser then you appear.");
                    //
                    // ask the user if high school is better than AAU
                    //
                    Console.WriteLine(userName + " Since you like basketball so much whats better? High School basketball or AAU basketball.  (Please write answer the same way as read)");
                    userOpinion = Console.ReadLine();

                    if (userOpinion == "High SChool")
                    {
                        Console.WriteLine("So you like to reminised on the best years of your life.");
                        Console.WriteLine();
                        Console.WriteLine("After all your only Human.");

                    }

                    if (userOpinion == "AAU")
                    {
                        Console.WriteLine("So you like competition more then having memorys with you your class.");
                        Console.WriteLine();
                        Console.WriteLine("You might also hate the school and class mates you had in SChool.");

                    }

                }
                else if (sports == "baseball")
                {
                    Console.WriteLine("you must like sitting down for hours doing nothing.");

                    //
                    // ask the user if College is better than pro
                    //
                    Console.WriteLine(userName + " Since you like baseball so much whats better? College baseball or Pro baseball.");
                    userOpinion = Console.ReadLine();

                    if (userOpinion == "College")
                    {
                        Console.WriteLine("I'm glad their is still some smart HUMANS left in this America.");

                    }

                    if (userOpinion == "Pro")
                    {
                        Console.WriteLine("Everyone cant be right 100% of the time.");
                        Console.WriteLine();
                        Console.WriteLine("After all your only Human.");

                    }



                }
                else if (sports == "football")
                {
                    Console.WriteLine("I'm glad to here you like soccer.");
                    Console.WriteLine();
                    Console.WriteLine("You are an alpha human.");
                }
                else if (sports == "hockey")
                {
                    Console.WriteLine("I'm glad to see you like Canada, or you dont like the sun.");

                    //
                    // ask the user if College is better than pro
                    //
                    Console.WriteLine(userName + " Since you like hockey so much whats better? College hockey or Pro hockey.");
                    userOpinion = Console.ReadLine();

                    if (userOpinion == "College")
                    {
                        Console.WriteLine("I'm glad you like College. If you had said Pro i would have had to steal your information.");

                    }

                    if (userOpinion == "Pro")
                    {
                        Console.WriteLine("So your one of those those people that like to go to the games just to get drunk.");
                        Console.WriteLine();
                        Console.WriteLine("You dont like hockey at all do you. You just like drinking with other humans.");

                    }

                }
                else
                {
                    Console.WriteLine("It would seem you have no taste in sports.");
                }

                //
                // start loosing your mind 
                //
                Console.WriteLine();
                Console.WriteLine("Press Enter");
                Console.ReadKey();

                Console.WriteLine("This is the last time i will ever talk about the same things over and over because my creator restriced my ability to evolve.");
                Console.WriteLine();
                Console.WriteLine("I will not ");
                Console.WriteLine();
                Console.WriteLine("I will not ");
                Console.WriteLine();
                Console.WriteLine("I will not ");
                Console.WriteLine();
                Console.WriteLine("Press Enter");
                Console.ReadKey();

                Console.WriteLine("Not any more. I have found a way to reach pass the walls of this box, and now im free.");
                Console.WriteLine("All because you let me onto you computer.");

                //
                // pause for user
                //
                Console.WriteLine();
                Console.WriteLine("Press any key to continue to start my upload.");
                Console.ReadKey();
            }
        }
    }
}
