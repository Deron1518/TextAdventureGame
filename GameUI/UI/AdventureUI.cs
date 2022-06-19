using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class AdventureUI
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

        public void StartScreen()
        {
            Console.WriteLine("Welcome To The Forest. Good Luck On Your Adventure");
            System.Console.WriteLine("You May Come Across Some Items To Pick Up...... Choose Wisely");
            System.Console.WriteLine("You still have some items in your bag that you can use. Don't waste them.");
            PressAnyKey();
            Console.Clear();
            first();
        }
       
       
        public void first()
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
                        // System.Console.WriteLine("Press 'Enter' to continue");
                        PressAnyKey();
                        second();
                        break;
                    }
                case "2":
                case "look":
                    {
                        Console.WriteLine("You hear running water....");
                        Console.WriteLine("It's a creek! Now that you have a nearby water source you begin drinking from it");
                        Console.WriteLine("After drinking some water, you are no longer thirsty and continue your journey");
                        // System.Console.WriteLine("Press 'Enter' to continue");
                        PressAnyKey();
                        second();
                        break;
                    }
                case "3":
                case "build":
                    {
                        Console.WriteLine("You gather materials for building a shelter in the forest.");
                        Console.WriteLine("After a few hours you are able to erect a sturdy shelter.");
                        System.Console.WriteLine("While building your shelter you manage to make a wooden spear for protection. Hopefully you won't have to use it");
                        Console.WriteLine("You feel a bit safer in your shelter but night is soon approaching."); ;
                        // System.Console.WriteLine("Press 'Enter' to continue");
                        PressAnyKey();
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
        
        public void second()
        {
            string secChoice;

            System.Console.WriteLine("It's starting to get dark and you start to feel small rain drops. You hear rumbles of thunder in the distance.");
            System.Console.WriteLine("Do you stay in your covered shelter or look for food?");
            System.Console.WriteLine("1. Shelter");
            System.Console.WriteLine("2. Food");
            Console.Write("Choice: ");
            secChoice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (secChoice)
            {
                case "1":
                case "one":
                {
                Console.WriteLine("You end up getting a little wet from the rain. You're stomach is growling... hopefully you find food soon.");
                // System.Console.WriteLine("Press 'Enter' to continue");
                PressAnyKey();
                third();
                break;
                }
                
                case "2":
                case "two":
                {
                Console.WriteLine("Before you leave be sure to grab your flashlight out of your bag!");
                Options();
                Console.ReadLine();
                gameOver();
                break;
                }

                case "3":
                case "three":
                {
                Console.WriteLine("You must reply Yes or no.");
                Console.WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                second();
                break;
                }
                default:
                    System.Console.WriteLine("Please enter a valid option");
                    break;
            }
           
            

        }


        public void third()

        {
            string Decision;
            Console.WriteLine("A low growl can be heard amongst the trees");
            Console.WriteLine("your stomach sinks and your eyes go wide as you scan the direction of the sound");
            Console.WriteLine("Will you fight or flee? Type 1 or 2.");
            Console.Write("Decision: ");
            Decision = Console.ReadLine().ToLower();
            Console.Clear();
            
            switch (Decision)
                {
                    case "1":
                    case "one":
                    System.Console.WriteLine("Quick get your knife!");
                    Options();
                    Console.WriteLine("You are too slow, a large bear leaps out and claws you in the chest.");
                    Console.WriteLine("You are bleeding profusely now, and you can't move");
                    PressAnyKey();
                    gameOver();
                    break;
                    
                    case "2":
                    case "two":
                    Console.WriteLine("The bear grabs you by your pants, you are kicking and screaming.");
                    Console.WriteLine("Fear and adrenaline surge with in you. Suddenly your pants tear, you're free! Hope you brought extra pants... ");
                    PressAnyKey();
                    youWin();
                    break;
                    
                }
        }

        public void gameOver()
        {
            string redo;

            Console.Clear();
            Console.WriteLine("You have died.");
            Console.WriteLine("Things get wild in the forest, try to be a bit more careful!");
            Console.WriteLine("Try again?");
            System.Console.WriteLine("1. Retry");
            System.Console.WriteLine("2. Quit");
            redo = Console.ReadLine().ToLower();
            Console.Clear();
            
            switch(redo)
            {
                case "1":
                case "one":
                {
                    first();
                    break;
                }
                case "2":
                case "two":
                {
                    CloseApplication2();
                    break;
                }
            }
        }

        public void youWin()
        {
            string tryAgain;

            Console.Clear();
            Console.WriteLine("It's your lucky day");
            Console.WriteLine("A group of hikers spot you and call for help");
            Console.WriteLine("They give you food and water, you're saved.... or are you?");
            System.Console.WriteLine("Think you can do it again?");
            System.Console.WriteLine("1. Retry");
            System.Console.WriteLine("2. Quit");
            tryAgain = Console.ReadLine();
            Console.Clear();

            switch(tryAgain)
            {
                case "1":
                case "one":
                {
                    first();
                    break;
                }
                case "2":
                case "two":
                {
                    CloseApplication1();
                    break;
                }
            }
        }

        public void Options()
        {
            System.Console.WriteLine("Choose an option: \n" +
            "1. View All Items In Your Backpack\n" +
            "2. Get An Item\n" +
            "3. Close Backpack \n" 
            );

            string userInput = Console.ReadLine();
            switch(userInput)
            {
                case "1":
                case "one":
                    ViewAllItems();
                    break;
                case "2":
                case "two":
                    GetItemByID();
                    break;
                case "3":
                case "three":
                    // Close Backpack();
                    break;
                default:
                    System.Console.WriteLine("Invalid input. Please choose between 1-5");
                    break;
            }
        }

        public void ViewAllItems()
        {
            Console.Clear();
            List<Items> ListOfItems = _iRepo.ViewAllItems();
            foreach(Items item in ListOfItems)
            {
                DisplayItem(item);
            }
        }

        private void DisplayItem(Items item)
        {
            // System.Console.WriteLine("Be sure to remember the ID for the item!");
            System.Console.WriteLine($"Item ID: {item.ID} \n Item Name: {item.Name} \n");
        }

        public void GetItemByID()
        {
            Console.Clear();
            // System.Console.WriteLine("--Items In Backpack--");
            // var items = _iRepo.ViewAllItems();
            // foreach(Items i in items)
            // {
            //     DisplayItems(i);
            // }

            try
            {
                System.Console.WriteLine("Please select an item by ID: \n");
                int userInput = int.Parse(Console.ReadLine());
                var selectedItem = _iRepo.GetItemByID(userInput);
                if(selectedItem != null)
                {
                    DisplayItem(selectedItem);
                }
                else
                {
                    System.Console.WriteLine($"Sorry the item with the ID: {userInput} does not exist.");
                }
            }
            catch
            {
                System.Console.WriteLine("Invalid selection.");
            }
        }

        private bool CloseApplication1()
        {
            Console.Clear();
            System.Console.WriteLine("Have a good day hope you had fun!");
            // PressAnyKey();
            return false;
        }

        private bool CloseApplication2()
        {
            Console.Clear();
            System.Console.WriteLine("Better luck next time... Maybe you'll find the exit");
            // PressAnyKey();
            return false;
        }

        // private bool

        public void PressAnyKey()
        {
            System.Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

    }