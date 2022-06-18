using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

class AdventureUI
    {
        private readonly ItemRepo _iRepo = new ItemRepo();
        // static void Main(string[] args)
        // {
        //     gameTitle();
        //     first();

        // }


        public void Run()
        {
            SeedData();
            StartScreen();
        }

        private void SeedData()
        {
            Items flashlight = new Items("Flashlight");
            Items rope = new Items("Rope");
            Items firstAid = new Items("FirstAid");
            Items waterBottle = new Items("WaterBottle");
            Items pocketKnife = new Items("PocketKnife");

            _iRepo.AddItemToBackpack(flashlight);
            _iRepo.AddItemToBackpack(rope);
            _iRepo.AddItemToBackpack(firstAid);
            _iRepo.AddItemToBackpack(waterBottle);
            _iRepo.AddItemToBackpack(pocketKnife);

        }

        public static void StartScreen()
        {
            Console.WriteLine("Welcome To The Forest. Good Luck On Your Adventure");
            System.Console.WriteLine("You May Come Across Some Items To Pick Up...... Choose Wisely");
            System.Console.WriteLine("You still have some items in your bag that you can use. Don't waste them.");
            Console.WriteLine("Press 'Enter' to begin.");
            Console.ReadLine();
            Console.Clear();
            first();

        }
       
       
        public static void first()
        {
            string choice;

            Console.WriteLine("You are lost in a forest with no cellphone reception");
            Console.WriteLine("What do you do?");
            Console.WriteLine("1. seek out help");
            Console.WriteLine("2. look for water");
            Console.WriteLine("3. Build a Shelter");
            Console.Write("Choice: ");
            choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice)
            {
                case "1":
                case "seek":
                    {
                        Console.WriteLine("You walk down the forest path seeking out help.");
                        Console.WriteLine("You shout for help and your voice echoes through the area. Good chance no one hears you");
                        Console.WriteLine("There's no path to be seen and trees as far as the eye can see.");
                        Console.WriteLine("You hear sticks breaking behind you.... you turn around slowly");
                        Console.WriteLine("It's just a deer..... PHEW");
                        Console.ReadLine();
                        second();
                        break;
                    }
                case "2":
                case "look":
                    {
                        Console.WriteLine("You hear running water....");
                        Console.WriteLine("It's a creek! Now that you have a nearby water source you begin drinking from it");
                        Console.WriteLine("After drinking some water, you are no longer thirsty and continue your journey");
                        Console.ReadLine();
                        fourth();
                        break;
                    }
                case "3":
                case "build":
                    {
                        Console.WriteLine("You gather materials for building a shelter in the forest.");
                        Console.WriteLine("After a few hours you are able to erect a sturdy shelter.");
                        System.Console.WriteLine("While building your shelter you manage to make a wooden spear for protection. Hopefully you won't have to use it");
                        Console.WriteLine("You feel a bit safer in your shelter but night is soon approaching."); ;
                        Console.ReadLine();
                        second();
                        break;
                    }
                default:
                    {

                        Console.WriteLine("Please select a validd option");
                        Console.WriteLine("Press 'Enter' to restart.");
                        Console.ReadLine();
                        first();
                        break;
                    }
            }
        }
        /* this section will demonstrate using random number generator and also allowing player to enter text response */
        public static void second()
        {
            Random rnd = new Random();
            string[] secondOptions = { "It's starting to get dark and you start to feel small rain drops. You hear rumbles of thunder in the distance. Do you stay in your covered shelter or look for food? (1 for shelter 2 for food)"};
            int randomNumber = rnd.Next(0, 3);
            string secText = secondOptions[randomNumber];

            string secChoice;

            Console.WriteLine(secText);
            Console.WriteLine("option 1");
            Console.Write("Choice: ");
            secChoice = Console.ReadLine().ToLower();

            if (secChoice == "1" || secChoice == "y")
            {
                Console.WriteLine("You end up getting soaked from the rain. You'll need to dry your clothes soon.");
                Console.ReadLine();
                Console.Clear();
                third();

            }
            else if (secChoice == "2" || secChoice == "n")
            {
                Console.WriteLine("Before you leave be sure to grab your flashlight out of your bag!");
                GetItemsByID();
                Console.ReadLine();
                gameOver();

            }
            else
            {
                Console.WriteLine("You must reply Yes or no.");
                Console.WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                second();
            }

        }

        /* this section demonstrates the use of loops 7/16/2019 */

        public static void third()

        {
            int Decision;
            Console.WriteLine("A low growl can be heard amongst the trees");
            Console.WriteLine("your stomach sinks and your eyes go wide as you scan the direction of the sound");
            Console.WriteLine("Will you fight or flee? Type 1 or 2.");
            Console.Write("Decision: ");
            int.TryParse(Console.ReadLine(), out Decision);
            int loop = 0;
            bool dead = false;
            while (Decision != 1 && dead == false)
            {
                if (loop <= 0)
                {
                    Console.WriteLine("You are too slow, a large bear leaps out and claws you in the chest.");
                    Console.WriteLine("You are bleeding profusely now, will your flee or fight?");
                    Console.Write("Decision: ");
                    int.TryParse(Console.ReadLine(), out Decision);
                    loop ++ ;
                }
                else if (loop >= 1)
                {
                    Console.WriteLine("The bear grabs you by your pants, you are kicking and screaming.");
                    Console.WriteLine("Fear and adrenaline surge with in you. Fight or Flee? 1 or 2? ");
                    Console.Write("Decision: ");
                    int.TryParse(Console.ReadLine(), out Decision);
                    dead = true;
                }
               
            }
            if (dead == true )
                {
                Console.WriteLine("You feel a sharp claw swipe your back , and jagged teeth tear at your legs");
                Console.WriteLine("All is pain, followed by darkness.");
                Console.ReadLine();
                gameOver();
                }
            else 

                {
                Console.WriteLine("You fight with all your might, punching the bear in the nose and causing it to flee.");
                Console.ReadLine();
                youWin();
                }
        }


        public static void gameOver()
        {
            Console.Clear();
            Console.WriteLine("You have died.");
            Console.WriteLine("All is good in the multiverse and nature continues it's course.");
            Console.WriteLine("The End?");
            Console.ReadLine();
            Console.Clear();
            StartScreen();
        }

        public static void youWin()
        {
            Console.Clear();
            Console.WriteLine("You have survived.");
            Console.WriteLine("A group of rangers spot you.");
            Console.WriteLine("You are saved.");
            Console.ReadLine();
            Console.Clear();
            StartScreen();
        }

        private void DisplayItemsListing(Items item)
        {
            
        }

        private void GetItemsByID()
        {
            Console.Clear();
            System.Console.WriteLine("Backpack Items");
            var item = _iRepo.ViewAllItems();

            foreach(Items i in _iRepo)
            {
                DisplayItemsListing(i);
            }
        }


    }