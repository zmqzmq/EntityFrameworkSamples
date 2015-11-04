// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PersonDbContext.cs" company="Mainul">
//   Copyright @ 2015
// </copyright>
// <summary>
//   The person db context.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace EfConsoleApplication
{
    using System.Data.Entity;

    /// <summary>
    ///     The person db context.
    /// </summary>
    public class PersonDbContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonDbContext"/> class.
        /// </summary>
        public PersonDbContext()
            : base("name=PersonContext")
        {
        }

        /// <summary>
        /// Gets or sets the persons.
        /// </summary>
        public DbSet<Person> Persons { get; set; }
    }
}