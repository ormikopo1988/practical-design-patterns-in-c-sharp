using DesignPatternsConsoleClient.HeadFirstDesignPatterns.Adapter;
using DesignPatternsConsoleClient.HeadFirstDesignPatterns.Command;
using DesignPatternsConsoleClient.HeadFirstDesignPatterns.Composite;
using DesignPatternsConsoleClient.HeadFirstDesignPatterns.CompoundPatternExamples.DuckReunion;
using DesignPatternsConsoleClient.HeadFirstDesignPatterns.Decorator;
using DesignPatternsConsoleClient.HeadFirstDesignPatterns.Facade;
using DesignPatternsConsoleClient.HeadFirstDesignPatterns.Factory.AbstractFactory;
using DesignPatternsConsoleClient.HeadFirstDesignPatterns.Factory.FactoryMethod;
using DesignPatternsConsoleClient.HeadFirstDesignPatterns.Iterator;
using DesignPatternsConsoleClient.HeadFirstDesignPatterns.Observer;
using DesignPatternsConsoleClient.HeadFirstDesignPatterns.Proxy.Virtual;
using DesignPatternsConsoleClient.HeadFirstDesignPatterns.Singleton;
using DesignPatternsConsoleClient.HeadFirstDesignPatterns.State;
using DesignPatternsConsoleClient.HeadFirstDesignPatterns.Strategy;
using DesignPatternsConsoleClient.HeadFirstDesignPatterns.TemplateMethod;
using System;

namespace DesignPatternsConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<< HEAD FIRST DESIGN PATTERNS >>");
            Console.WriteLine();

            Console.WriteLine("////////// STRATEGY PATTERN //////////");
            Console.WriteLine();

            MiniDuckSimulator.Start();

            Console.WriteLine();
            Console.WriteLine("////////// OBSERVER PATTERN //////////");
            Console.WriteLine();

            WheatherStationSimulator.Start();

            Console.WriteLine();
            Console.WriteLine("////////// DECORATOR PATTERN //////////");
            Console.WriteLine();

            StarbuzzCoffeeSimulator.Start();

            Console.WriteLine();
            Console.WriteLine("////////// FACTORY METHOD PATTERN //////////");
            Console.WriteLine();

            PizzaTestDriveSimulator.Start();

            Console.WriteLine();
            Console.WriteLine("////////// ABSTRACT FACTORY PATTERN //////////");
            Console.WriteLine();

            PizzaUsingAbstractFactorySimulator.Start();

            Console.WriteLine();
            Console.WriteLine("////////// SINGLETON PATTERN //////////");
            Console.WriteLine();

            ChocolateBoilerControllerSimulator.Start();

            Console.WriteLine();
            Console.WriteLine("////////// COMMAND PATTERN //////////");
            Console.WriteLine();

            RemoteControlSimulator.Start();

            Console.WriteLine();
            Console.WriteLine("////////// ADAPTER PATTERN //////////");
            Console.WriteLine();

            TurkeyAdapterSimulator.Start();

            Console.WriteLine();
            Console.WriteLine("////////// FACADE PATTERN //////////");
            Console.WriteLine();

            HomeTheaterSimulator.Start();

            Console.WriteLine();
            Console.WriteLine("////////// TEMPLATE METHOD PATTERN //////////");
            Console.WriteLine();

            CaffeineBeverageMakerSimulator.Start();

            Console.WriteLine();
            Console.WriteLine("////////// ITERATOR PATTERN //////////");
            Console.WriteLine();

            MenuSimulator.Start();

            Console.WriteLine();
            Console.WriteLine("////////// COMPOSITE PATTERN //////////");
            Console.WriteLine();

            MenuTestDriveSimulator.Start();

            Console.WriteLine();
            Console.WriteLine("////////// STATE PATTERN //////////");
            Console.WriteLine();

            GumballMachineSimulator.Start();

            Console.WriteLine();
            Console.WriteLine("////////// PROXY PATTERN (VIRTUAL) //////////");
            Console.WriteLine();

            ImageProxySimulator.Start();

            Console.WriteLine();
            Console.WriteLine("////////// COMPOUND PATTERNS (DUCKREUNION) //////////");
            Console.WriteLine();

            DuckSimulator.Start();

            Console.ReadLine();
        }
    }
}
