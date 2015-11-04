// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Model.cs" company="Mainul">
//   Copyright @ 2015
// </copyright>
// <summary>
//   The person model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace EfConsoleApplication
{
    using System;

    /// <summary>
    ///     The person model.
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Gets or sets the person id.
        /// </summary>
        public int PersonId { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the birth date.
        /// </summary>
        public DateTime BirthDate { get; set; }
    }
}