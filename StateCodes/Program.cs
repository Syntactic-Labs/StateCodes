using System;
using System.Collections.Generic;

namespace StateCodes
{
    class Program
    {
        static void Main(string[] args)
        {

            var states = new List<State>()                              //List Practise
            {
                new State("OH", "Ohio"),
                new State("KY", "Ohio"),
                new State("IN", "Indiana")
            };
            var stateoh = new State("OH", "Ohio");
            states.Add(stateoh);
            var stateky = new State("KY", "Kentucky");
            states.Add(stateky);

            states.Add(new State("IN", "Indiana"));       //inserts key and data without creating a variable

            foreach (var state in states)                 //You need to work on your foreach!!!!!!!!!!!!!
            {
                Console.WriteLine($"Statecode: {state.Code} | The name is {state.Name} ");
            }
            
            
            
            //var statecodes = new Dictionary<string, string>()        //first value is your key second value is your data / Dictinary Practise
            //{
            //    ["OH"] = "Ohio",
            //    ["IN"] = "Indiana",
            //    ["KY"] = "Kentucky"             //much faster way of entering keys and data most of the time         
            //};

            //statecodes.Add("OH", "Ohio");
            //statecodes.Add("IN", "Indiana");
            //statecodes.Add("KY", "Kentucky");

            //var oh = statecodes["OH"];              // statecode is the name of the dictionary [this is the key]
            //Console.WriteLine($"I live in {oh}!");





        }
    }
}

