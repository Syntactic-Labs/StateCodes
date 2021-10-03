using System;
using System.Collections.Generic;

namespace StateCodes
{
    class Program
    {
        static void Main(string[] args)                           //public State(string code, string name)
        {

            var states = new List<State>()                              //List Practise
            {
                new State("OH", "Ohio"),
                new State("KY", "Kentucky"),
                new State("IN", "Indiana")
            };
            //Puts code and name into a variable then takes the variable and puts it in the var list states         
            var stateoh = new State("OH", "Ohio");
            states.Add(stateoh);
            var stateky = new State("KY", "Kentucky");
            states.Add(stateky);
            var statein = new State("IN", "Indiana");
            states.Add(statein);
            //inserts code and name without creating a variable
            states.Add(new State("OH", "Ohio"));
            states.Add(new State("KY", "Kentucky"));
            states.Add(new State("IN", "Indiana"));       
            // for each state inside of the list called states...
            foreach (var state in states)                 
            {
                Console.WriteLine($"Statecode: {state.Code} | The name is {state.Name} ");
            }
            //first value is your key second value is your data / dictinary practise
            var statecodes = new Dictionary<string, string>()
            {   //much faster way of entering keys and data most of the time
                ["oh"] = "ohio",
                ["in"] = "indiana",
                ["ky"] = "kentucky"                      
            };
            //objects placed in Dictionary idividually
            //statecodes.Add("oh", "ohio");
            //statecodes.Add("in", "indiana");
            //statecodes.Add("ky", "kentucky");
            // statecode is the name of the dictionary [this is the key]
            var oh = statecodes["oh"];              
            Console.WriteLine($"i live in {oh}!");





        }
    }
}

