using System;
using JogoDeRpg.src.Entities;
using static System.Console;


namespace JogoDeRpg
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero Knight = new Knight("Arus", 23, "Knigth");
           Wizard wizard = new Wizard("Jennica", 23, "White Wizard");
           
            WriteLine(Knight.Attack());
            WriteLine(wizard.Attack());
            
        }

        
    }

}
