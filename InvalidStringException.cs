using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Author: Tom
/// Date: 11/10/23
/// 
/// This exception should be thrown whenever a String instance is unexpectedly empty (ie: "").
/// </summary>
namespace Fishy_Notes
{
    /// <summary>
    /// InvalidStringException class.
    /// This exception should be thrown whenever a String instance is unexpectedly empty (ie: "").
    /// </summary>
    public class InvalidStringException : Exception
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public InvalidStringException()
        {
        }

        /// <summary>
        /// Recommended constructor.
        /// </summary>
        /// <param name="message">String containing the message to the user</param>
        public InvalidStringException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Only use this constructor if other exceptions are likely to be queued.
        /// </summary>
        /// <param name="message">String containing the message to the user</param>
        /// <param name="inner">Reference to other Exceptions that have been raised</param>
        public InvalidStringException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}