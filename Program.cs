using Newtonsoft.Json;
using System;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks.Sources;
using System.Transactions;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace Histogram_Lab1
{
    class Program
    {
        public static string GetSpeech()
        {
            string text = "I say to you today, my friends, so even though we face the difficulties of today and tomorrow, I still have a dream. It is a dream deeply rooted in the American dream. " +
            "I have a dream that one day this nation will rise up and live out the true meaning of its creed: We hold these truths to be self-evident: that all men are created equal. " +
            "I have a dream that one day on the red hills of Georgia the sons of former slaves and the sons of former slave owners will be able to sit down together at the table of brotherhood. " +
            "I have a dream that one day even the state of Mississippi, a state sweltering with the heat of injustice, sweltering with the heat of oppression, will be transformed into an oasis of freedom and justice. " +
            "I have a dream that my four little children will one day live in a nation where they will not be judged by the color of their skin but by the content of their character. " +
            "I have a dream today. I have a dream that one day, down in Alabama, with its vicious racists, with its governor having his lips dripping with the words of interposition and nullification; one day right there in Alabama, little black boys and black girls will be able to join hands with little white boys and white girls as sisters and brothers. " +
            "I have a dream today. I have a dream that one day every valley shall be exalted, every hill and mountain shall be made low, the rough places will be made plain, and the crooked places will be made straight, and the glory of the Lord shall be revealed, and all flesh shall see it together. " +
            "This is our hope. This is the faith that I go back to the South with. With this faith we will be able to hew out of the mountain of despair a stone of hope. With this faith we will be able to transform the jangling discords of our nation into a beautiful symphony of brotherhood. " +
            "With this faith we will be able to work together, to pray together, to struggle together, to go to jail together, to stand up for freedom together, knowing that we will be free one day. " +
            "This will be the day when all of God's children will be able to sing with a new meaning, My country, 'tis of thee, sweet land of liberty, of thee I sing. Land where my fathers died, land of the pilgrim's pride, from every mountainside, let freedom ring. " +
            "And if America is to be a great nation this must become true. So let freedom ring from the prodigious hilltops of New Hampshire. Let freedom ring from the mighty mountains of New York. Let freedom ring from the heightening Alleghenies of Pennsylvania! " +
            "Let freedom ring from the snowcapped Rockies of Colorado! Let freedom ring from the curvaceous slopes of California! But not only that; let freedom ring from Stone Mountain of Georgia! " +
            "Let freedom ring from Lookout Mountain of Tennessee! Let freedom ring from every hill and molehill of Mississippi. From every mountainside, let freedom ring. " +
            "And when this happens, when we allow freedom to ring, when we let it ring from every village and every hamlet, from every state and every city, we will be able to speed up" +
            " that day when all of God's children, black men and white men, Jews and Gentiles, Protestants and Catholics, will be able to join hands and sing in the words" +
            " of the old Negro spiritual, Free at last! free at last! thank God Almighty, we are free at last!";

           


            // to hold the count value




            // ContainsKey method
            // Te


            return text;
        }
        public static string GetSpeechFromFile()
        {

            string read = System.IO.File.ReadAllText(@"C:\Users\ladar\source\repos\Histogram_Lab1\speech.csv");


            return read;




        }
        //private static void getKey(Dictionary<string, int> mlkCount, string key)
        //{
        //    if(mlkCount.TryGetValue(key, out int value))
        //    {
        //        Console.WriteLine($"{key}, {value}");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Input is not found...");
        //    }
           

        //}

        //public static bool Contains(string source, string toCheck, StringComparison comp)
        //{
        //    return source != null && toCheck != null && source.IndexOf(toCheck, comp) >= 0;
        //}

        //private static void getThisToWork(Dictionary<string, int> mlkCount, string key)
        //{
           
            

        //    if (mlkCount.ContainsKey(key))
        //    {
        //        int value = mlkCount[key];
        //        Console.WriteLine($"{key}: {value}");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{ key}'s not in the dictionary");
                
        //    }
          
        //}

         
        // how to have functionality in the list functions 
        // 
       



        static void Main(string[] args)
        {

            // how to add a dictionaryp
            // how to get this program fuctionality


            //string fileReader = System.IO.File.ReadAllText(@"C:\Users\ladar\OneDrive\PG2\Labs\Data\Data\speechString.txt");
            //fileReader = Path.GetFullPath(@"speechString.txt");



            #region show car program functionality
            //string welcome = string.Empty; ReadString("What is the name of your Dealership?  ", ref welcome);
            string[] words = GetSpeechFromFile().Split(new char[] { '.', ',', '!', '?', ' ', '-', ';','"', }, StringSplitOptions.RemoveEmptyEntries);
            List<string> speech = words.ToList();
            Dictionary<string, int> mlk2 = new Dictionary<string, int>(StringComparer.InvariantCultureIgnoreCase);




            for (int i = 0; i < speech.Count; i++)
            {
                if (mlk2.ContainsKey(speech[i]))
                {
                    mlk2[speech[i]]++;
                }
                else
                {
                    mlk2.Add(speech[i], 1);
                }
            }



            //string[] mainMenu = new string[3] { "1. Add Car", "2. Show Cars", "3. Exit" };
            int menuChoice = 0;
            bool check = false;
            //while (!check)
            //{
             
            //    ReadChoice("Choice? ", mainMenu, out menuChoice);
            //    try
            //    {

            //        menuChoice = Convert.ToInt32(Console.ReadLine());

            //        if (menuChoice == 1)
            //        {
            //            check = true;
            //            Console.WriteLine();
            //        }
            //        else if (menuChoice == 2)
            //        {
            //            check = true;
            //            Console.ReadLine();
            //        }
            //        else if (menuChoice == 3)
            //        {
            //            check = false;
            //            Environment.Exit(0);
            //        }
            //        else
            //        {
            //            check = false;
            //        }
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("Enter an Option Selection");
            //    }
                
              

            //}
           
           

            //int year = ReadInteger(1908, 2021, prompt: "Year: ", error: "Year out of range....");


            //int passengers = ReadInteger(1, 10, prompt: "Number of passengers: ", error: "Passengers out of range");


            //string make = string.Empty; ReadString("Make: ", ref make);


            //string model = string.Empty;
            //ReadString("Model: ", ref model);
            //#endregion

           

            #region Histogram functionality
            int acceptence = 0;
            string[] menuLoop = new string[6] { "Option 1: Show Histogram ", "Option 2: Search for Word ", "Option 3: Save Histogram ", "Option 4: Load Histogram ", "Option 5: Remove Word ", "Option 6: Exit " };

           
           

               

            string search = string.Empty;     // search for word
            string sFile = string.Empty;   // save file 
            string fileLoad = string.Empty;   // load file 
            string remove = string.Empty; // remove word
           ;
            bool checks = false;
            while (!checks)
            {

                ReadChoice("Select An Option", menuLoop, out acceptence);
                acceptence = Int32.Parse(Console.ReadLine());

                if (acceptence == 1)
                {
                  
                    foreach (var num in mlk2)
                    {
                        Console.Write(num.Key + "\t");
                        for (int i = 0; i < num.Value; i++)
                        {
                            Console.CursorLeft = 0;
                            Console.BackgroundColor = ConsoleColor.Cyan;
                            
                            Console.Write(" ");
                        }
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(num.Value);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine();
                    }
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"{mlk2.Count}  words have been shown");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    

                }
                else if (acceptence== 2)
                   
                {
                    List<string> sentences = GetSpeechFromFile().Split(new char[] { '.', '!', '?', }, StringSplitOptions.RemoveEmptyEntries).ToList();
                    ReadString("What word would you like to search for? ", ref search);
                    if (mlk2.ContainsKey(search))
                    {
                       
                        Console.Write(search + "\t");
                        for (int i = 0; i < mlk2[search]; i++)
                        {
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.Write(" ");
                        }
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write($" {mlk2[search]}");
                        Console.WriteLine();
                        foreach (var item in sentences)
                        {
                            if (item.ToLower().Contains(search + " "))
                            {
                                Console.WriteLine(item);
                            }
                        }
                    }
                    else
                    {

                        Console.WriteLine(search + "  was not found in dictionary! Please try again");
                        Console.WriteLine("\n");
                    }
                    
                }
                else if (acceptence == 3)
                {
                   
                    ReadString("Name the the file you would like to save? ", ref sFile);
                     sFile = Path.ChangeExtension(sFile, ".json");

                    using (StreamWriter stream = File.CreateText(sFile))
                    {
                        //write  json
                        using (JsonTextWriter jsonWrite = new JsonTextWriter(stream))
                        {
                            jsonWrite.Formatting = Formatting.Indented;
                            //convert  to json 
                            JsonSerializer serial = new JsonSerializer();
                            serial.Serialize(jsonWrite, mlk2);//serialize the dictionary
                        }//close the json text writer
                    }//close the file
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"{mlk2.Count}   number of words saved to   {sFile} ");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;

                }
                else if (acceptence == 4)
                {
                    ReadString("What is the name of the file you would like to load? ", ref fileLoad);
                    fileLoad = Path.ChangeExtension(fileLoad, ".json");
                    if (File.Exists(fileLoad))
                    {
                        string jsonText = File.ReadAllText(fileLoad);
                        


                        try
                        {
                            
                            mlk2 = JsonConvert.DeserializeObject<Dictionary<string, int>>(jsonText);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"{mlk2.Count} number of words loaded to {fileLoad}");
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                        }


                        catch (Exception ex)
                        {
                            Console.WriteLine("Error reading from the json file.");
                            Console.WriteLine(ex.Message);
                        }
                    }

                }
                else if (acceptence == 5)
                {
                    ReadString("Please enter a word you would like to remove, ", ref remove);
                    if (mlk2.ContainsKey(remove))
                    {
                        mlk2.Remove(remove);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("you have removed " + remove + $" andthere are now { mlk2.Count}  words ");
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    }
                    else
                    {
                        // exception return
                        Console.WriteLine("That is not a word in the dictionary. . . Please try again! \n ");
                       
                    }

                }
                else if (acceptence == 6)
                {
                    
                    Environment.Exit(0);
                }
               


            }

            #endregion  historgram









            // show prompt, read input, return integer
            //create loop for invalid input
            // set max and min
            #region ReadInteger
            static int ReadInteger(int min, int max, string prompt = "", string error = "")
            {
                int number = 0;
                do
                {
                    Console.WriteLine(prompt + "Enter a year between " + min + " and " + max);
                    string numberString = Console.ReadLine();
                    try
                    {
                        number = int.Parse(numberString);
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Only Numbers Please");
                    }

                }
                while ((number < min) || (number > max));


                return number;


            }
            #endregion
            #region  ReadString
            static void ReadString(string prompt, ref string value)
            {
                Console.Write(prompt);
                string right = string.Empty;
                bool check = false;
                while (!check)
                {
                    right = Console.ReadLine();
                    try
                    {
                        if (right != "")
                        {

                            check = true;
                        }
                        else
                        {
                            Console.WriteLine("Enter Something. . . .");
                            check = false;
                        }

                    }
                    catch (Exception)
                    {
                        Console.WriteLine("strings!!! not an integer!");
                    }
                    value = right;
                }
            }


            #endregion
            #region  ReadChoice
            static void ReadChoice(string prompt, string[] options, out int selection)
            {
                //selection = ReadInteger(1,6, "Choose an option Choice", "Wrong choice");

                Console.WriteLine(prompt);
                for (int i = 0; i < options.Length; i++)
                {
                    
                    Console.WriteLine(options[i]);
                }
                selection = 0;
            }
            #endregion
            #endregion

        }
    }
}

