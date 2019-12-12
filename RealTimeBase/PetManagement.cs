using System;
using System.Collections.Generic;

namespace RealTimeBase
{
    public class PetManagement
    {
        public List<Pet> Pets = new List<Pet>();
        
        public void AddPet(Pet pet)
        {
            Pets.Add(pet);
        }

        public void DisplayPets()
        {
            int index = 2;
            foreach(Pet pet in Pets)
            {
                pet.DisplayDetail(index);
                index++;
            }
            
        } 
        
       
    }
}