﻿namespace FunWithNullableValueTypes_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LocalNullableVariables();
            Console.WriteLine("***** Fun with Nullable Value Types *****\n");
            DatabaseReader dr = new DatabaseReader();

            int myData = dr.GetIntFromDatabase() ?? 100;
            Console.WriteLine("Value of myData: {0}", myData);
            Console.ReadLine();

            // Get int from "database".
            int? i = dr.GetIntFromDatabase();
            if (i.HasValue)
            {
                Console.WriteLine("Value of 'i' is: {0}", i.Value);
            }
            else
            {
                Console.WriteLine("Value of 'i' is undefined.");
            }
            // Get bool from "database".
            bool? b = dr.GetBoolFromDatabase();
            if (b != null)
            {
                Console.WriteLine("Value of 'b' is: {0}", b.Value);
            }
            else
            {
                Console.WriteLine("Value of 'b' is undefined.");
            }
            Console.ReadLine();
        }

        static void LocalNullableVariables()
        {
            // Define some local nullable variables.
            int? nullableInt = 10;
            double? nullableDouble = 3.14;
            bool? nullableBool = null;
            char? nullableChar = 'a';
            int?[] arrayOfNullableInts = new int?[10];
        }
    }
    class DatabaseReader
    {
        // Nullable data field.
        public int? numericValue = null;
        public bool? boolValue = true;
        // Note the nullable return type.
        public int? GetIntFromDatabase()
        { return numericValue; }
        // Note the nullable return type.
        public bool? GetBoolFromDatabase()
        { return boolValue; }
    }
}