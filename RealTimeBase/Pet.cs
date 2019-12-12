using System;

namespace RealTimeBase
{
    public class Pet : RealTimeComponent
    {
        private readonly PetClass petClass;
        public int Health {get; set;}
        public string PetName {get; set;}
        public int Mood {get; set;}
        public int Hunger {get; set;}
        const int _mood=100;

        string[]  sprite = new string[6];
        private int _hunger=100;

        //const int

        public Pet( PetClass petClass, string petName, int health, int mood, int hunger )
        {
            this.petClass = petClass;
            PetName = petName;
            Health = health; 
            Mood = mood;
            Hunger = hunger;
        }
        public void DisplayDetail(int position)
        {
            Console.SetCursorPosition(3,13);
            switch(petClass)
            {
                case PetClass.Cat:
                    Console.Write($"{PetName} is a Shady {petClass}"); 
                    break;           
                case PetClass.Bird:
                    Console.Write($"{PetName} is a magestic {petClass}");
                    break; 
                case PetClass.Fish:
                    Console.Write($"{PetName} is a cool {petClass}");
                    break; 
                default: Console.Write($"{PetName} is not a recognized class");
                break; 
            } 
             Console.SetCursorPosition(3,14);
             Console.Write($"Health:{Health} | Mood:{Mood} | Hunger:{Hunger}");
            

        }

        
        public void Display()
        {
            

           Console.SetCursorPosition(40,7);
           Console.Write(sprite[0]);
           Console.SetCursorPosition(40,8);
           Console.Write(sprite[1]);
            Console.SetCursorPosition(40,9);
           Console.Write(sprite[2]);
           Console.SetCursorPosition(40,10);
           Console.Write(sprite[3]);
           Console.SetCursorPosition(40,11);
           Console.Write(sprite[4]);
            Console.SetCursorPosition(40,12);
           Console.Write(sprite[5]);
        }

        public void Initialise()
        {
           sprite[0] ="                  ;~~,__";
           sprite[1] ="   :-....,-------'`-'._.'";
           sprite[2] ="`-,,,  ,       ,'~~'";
           sprite[3] ="       ; ,'~.__; /";
           sprite[4] ="      :|      :|";
           sprite[5] ="       `-'     `-'";
        }


         public void Update()
        {
            Mood--;
            Hunger++;
            if(Mood == -1)
            {
                Mood++;
                //sad pet
            }
           
            

            if(Hunger>_hunger)
            {
               
                Hunger--;
                Health--;
                  if(Health ==-1)
                {
                    Console.SetCursorPosition( 7, 7);
                    Console.WriteLine("Help Me");
                    Health++;

                    
                    
                    
                }

               
            }

            
            
        }

        internal void Feed(int hungerModifier)
        {
            Hunger -= hungerModifier;
        }

        internal void Heal(int healthModifier)
        {
            Health += healthModifier;
        }

        internal void MoodHappy(int moodModifier)
        {
            Mood += moodModifier;
        }
    }
}