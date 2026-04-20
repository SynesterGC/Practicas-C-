using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using Biblioteca2nd;



public class User
    {
        public bool HaveMaterial{get; set;}
        public string Name {get; set;}
        public User(string Name)
        {
            this.Name = Name;
        }
        public bool RecibirMaterial (Material material)
            {
                if (!HaveMaterial)
                {
                    HaveMaterial=true;
                    Console.WriteLine($"El usuario {Name} ahora tiene el material {material}");
                    return true;
                }
                Console.WriteLine($"{Name} ya tiene un material y no puede recibir mas");
                return false;
            }
    }