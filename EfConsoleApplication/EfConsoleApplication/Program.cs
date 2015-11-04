// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Mainul">
//   Copyright @ 2015
// </copyright>
// <summary>
//   The program.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace EfConsoleApplication
{
    using System;

    /// <summary>
    /// The program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        public static void Main(string[] args)
        {
            PerformDatabaseOperations();
            Console.Write("Person saved !");
            Console.ReadLine();
        }

        /// <summary>
        ///     The perform database operations.
        /// </summary>
        public static void PerformDatabaseOperations()
        {
            using (var db = new PersonDbContext())
            {
                var person = new Person { FirstName = "Nadege", LastName = "Deroussen", BirthDate = DateTime.Now };

                db.Persons.Add(person);
                db.SaveChanges();
            }
        }
    }
}