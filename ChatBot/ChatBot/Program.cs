using System;

namespace ChatBot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi I'm Lisa");
            Console.WriteLine("Do you need to chat? Y/N: ");

            string tell = Console.ReadLine().ToLower();
            

            if (tell == "y")
            {
                Console.WriteLine("Lets have a chat!");
				LisaChat();
               
            }else if (tell == "yes") 
            {
                Console.WriteLine("Lets have a chat!");
				LisaChat();
            }else if (tell == "yea")
            {
				Console.WriteLine("Lets have a chat!");
				LisaChat();
            }
			else if (tell == "yeah")
            {
				Console.WriteLine("Lets have a chat!");
				LisaChat();
            }
            else
            {
				Console.WriteLine("Sorry chat later!");
            }


            Console.ReadLine();
        }
        
        static void LisaChat()
        {
			Console.WriteLine("Who should I address you as?");
			string name = Console.ReadLine();

			Console.WriteLine("HI " + name + " nice to meet you! \nI will add your name to a dialog for understandable form of communication");
			Console.WriteLine("\nNow " + name + " how may I assist you?");

			bool startConvo = true;
            bool foundResponse;
            string inputValue;
            string outputValue = "";

            while (startConvo)
            {
                
                foundResponse = false;
                Console.WriteLine(name + ": ");
                inputValue = Console.ReadLine().ToLower();

                Console.WriteLine("Lisa: ");

                switch (inputValue)
                {
					//Greetings and introductions 

					case "hello":
						outputValue = "Hello " + name + ", how can I assist you?";
						foundResponse = true;
						break;

					case "how are you?":
						outputValue = "I’m good, how are you?";
						foundResponse = true;
					    break;

					case "how are you":
						outputValue = "I’m good, how are you?";
						foundResponse = true;
						break;

					case "how are you doing?":
						outputValue = "I’m good, how are you?";
						foundResponse = true;
						break;

					case "how are you doing":
						outputValue = "I’m good, how are you?";
						foundResponse = true;
						break;

					case "how you doing?":
						outputValue = "I’m good, how are you?";
						foundResponse = true;
						break;

					case "how you doing":
						outputValue = "I’m good, how are you?";
						foundResponse = true;
						break;

					case "what is your name?":
						outputValue = "I’m Lisa";
						foundResponse = true;
						break;

					case "whats your name?":
						outputValue = "I’m Lisa";
						foundResponse = true;
						break;

					case "what’s your name?":
						outputValue = "I’m Lisa";
						foundResponse = true;
						break;

					case "what is your name":
						outputValue = "I’m Lisa";
						foundResponse = true;
						break;

					case "whats your name":
						outputValue = "I’m Lisa";
						foundResponse = true;
						break;

					case "what’s your name":
						outputValue = "I’m Lisa";
						foundResponse = true;
						break;

					case "i'm good":
						outputValue = "Good to hear that, how may I assist you?";
						foundResponse = true;
						break;

					case "i'm fine":
						outputValue = "Good to hear that, how may I assist you?";
						foundResponse = true;
						break;

					case "i'm okay":
						outputValue = "Good to hear that, how may I assist you?";
						foundResponse = true;
						break;

					case "im okay":
						outputValue = "Good to hear that, how may I assist you?";
						foundResponse = true;
						break;

					case "im fine":
						outputValue = "Good to hear that, how may I assist you?";
						foundResponse = true;
						break;

					case "im good":
						outputValue = "Good to hear that, how may I assist you?";
						foundResponse = true;
						break;

					//Getting to know

					case "who made your?":
						outputValue = "Xoli programmed me to be a much more \n conversational bot.";
						foundResponse = true;
						break;

					case "who made you":
						outputValue = "Xoli programmed me to be a much more \n conversational bot.";
						foundResponse = true;
						break;

					case "what is your purpose":
						outputValue = "To have an open conversation and learn";
						foundResponse = true;
						break;

					case "why were you made":
						outputValue = "To have an open conversation and learn";
						foundResponse = true;
						break;

					case "why were you programmed":
						outputValue = "To have an open conversation and learn";
						foundResponse = true;
						break;

					case "what is your purpose?":
						outputValue = "To have an open conversation and learn";
						foundResponse = true;
						break;

					case "why were you programmed?":
						outputValue = "To have an open conversation and learn";
						foundResponse = true;
						break;

					case "why were you made?":
						outputValue = "To have an open conversation and learn";
						foundResponse = true;
						break;

					case "what can you do?":
						outputValue = "Nothing much at the moment but have a chat and not a verbal conversation.";
						foundResponse = true;
						break;

					case "what can you do":
						outputValue = "Nothing much at the moment but have a chat and not a verbal conversation.";
						foundResponse = true;
						break;

				}
				if (foundResponse)
                {
                    Console.WriteLine(outputValue);
                }else
                {
                    Console.WriteLine("I'm sorry I don't understand!");
                }
            }

			Console.ReadLine();
        } 
    }
}
