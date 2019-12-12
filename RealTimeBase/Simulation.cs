using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace RealTimeBase
{

    public enum AppState
    {
        
        Running,
        Help,
        Paused,
        Shop,
        Exiting
    }

    class Simulation : RealTimeComponent
    {
        //private bool appRunning = true;
        AppState appState = AppState.Running;
        Coins coins = new Coins(1);
        ItemManagement inventory = new ItemManagement();
        PetManagement petmanager = new PetManagement();

        Border border = new Border();

        public Simulation()
        {
             Welcome();
            petmanager.AddPet(new Pet(PetClass.Cat, "Jeramiah", 100, 50, 25));
            inventory.AddItem(new Food("banana", 50));//this hold be set from an item purchased
            inventory.AddItem(new Medicine("Super potion", 50));//this hold be set from an item purchased
            inventory.AddItem(new Toys("Ball", 50));//this hold be set from an item purchased
          
        }

        public void Run()
        {
            Initialise();

            do
            {
                
               
                    switch (appState)
                    {
                      
                        case AppState.Running:
                            Update();
                            Display();
                            break;
                        case AppState.Paused:
                            CheckKeyInput();
                            break;
                        case AppState.Help:
                            DisplayHelp();
                            break;
                        case AppState.Shop:
                            DisplayShop();
                            
                            break;
                        default:
                            break;
                    }                
                    
                Thread.Sleep(1000/10);
            } while (appState != AppState.Exiting);
        }

        public void DisplayHelp()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Console.WriteLine("Help");
            Console.WriteLine("\n\nPress Any key to Continue \nHopefully this is helpful");
            Console.ReadKey(true);
            appState = AppState.Running;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Clear();
        }

        public void DisplayShop()
        {
            Console.Clear();
            Console.WriteLine("What type of Item would you like to purchase?");
            Console.WriteLine("1) Food");
            Console.WriteLine("2) Medicine");
            Console.WriteLine("3) Toy");

            if (Console.KeyAvailable)
            {
                ConsoleKey keyPressed = Console.ReadKey(true).Key;

                if (keyPressed == ConsoleKey.D1)
                {
                this.inventory.AddItem(new Food("banana", 50));//this hold be set from an item purchased
                }
                if (keyPressed == ConsoleKey.D2)
                {
                this.inventory.AddItem(new Medicine("Super potion", 50));//this hold be set from an item purchased
                }
                 if (keyPressed == ConsoleKey.D3)
                {
                this.inventory.AddItem(new Toys("Ball", 50));//this hold be set from an item purchased
                }
            }
                       
            Console.ReadKey(true);
            Console.Clear();
            appState = AppState.Running;
        }

        public void Initialise()
        {
            Console.CursorVisible = false;
            Console.Clear();
            border.Initialise();
            coins.Initialise();
            petmanager.Pets[0].Initialise();
            
        }

        public void CheckKeyInput()
        {
            if (Console.KeyAvailable)
            {
               
                ConsoleKey keyPressed = Console.ReadKey(true).Key;

                if (keyPressed == ConsoleKey.Escape)
                {
                    appState = AppState.Exiting;
                }

                if (keyPressed == ConsoleKey.F)
                {
                    for(int i=0; i < inventory.Items.Count; i++)
                    {
                        if(inventory.Items[i].GetType() == typeof(Food))
                        {
                            petmanager.Pets[0].Feed(((Food)inventory.Items[i]).IncreaseFullness);
                            inventory.Items.RemoveAt(i);
                            break;
                        }

                    }
                    

                }

                if (keyPressed == ConsoleKey.S)
                {
                    appState = AppState.Shop;
                }


                 if (keyPressed == ConsoleKey.M)
                {
                    for(int i=0; i < inventory.Items.Count; i++)
                    {
                        if(inventory.Items[i].GetType() == typeof(Medicine))
                        {
                            petmanager.Pets[0].Heal(((Medicine)inventory.Items[i]).IncreaseHealth);
                            inventory.Items.RemoveAt(i);
                            break;
                        }

                    }
                    

                }


                 if (keyPressed == ConsoleKey.T)
                {
                    for(int i=0; i < inventory.Items.Count; i++)
                    {
                        if(inventory.Items[i].GetType() == typeof(Toys))
                        {
                            petmanager.Pets[0].MoodHappy(((Toys)inventory.Items[i]).IncreaseMood);
                            inventory.Items.RemoveAt(i);
                            break;
                        }

                    }
                    

                }

                if (keyPressed == ConsoleKey.R)
                {
                    coins.Initialise();
                }

                if (keyPressed == ConsoleKey.H)
                {
                    appState = AppState.Help;
                }

                if (keyPressed == ConsoleKey.P)
                {
                    if (appState != AppState.Paused)
                    {
                        appState = AppState.Paused;
                    }
                    else if (appState == AppState.Paused)
                    {
                        appState = AppState.Running;
                    }

                }
            }
        }

        public void Update()
        {
            CheckKeyInput();
            coins.Update();
            petmanager.Pets[0].Update();
            inventory.DisplayItems();
            
        }   

        public void Display()
        {
            
            border.Display();
            coins.Display();
            petmanager.Pets[0].Display();
            petmanager.Pets[0].DisplayDetail(0);
            inventory.DisplayItems();
           
        }

        public void Welcome()
        {


               
                Console.WriteLine("Hello, Welcome to your very own Tamogachi Play thing. Press Enter to Continue");
                
                ConsoleKey keyPressed = Console.ReadKey(true).Key;
                
              
        }

        
       
    }
}
