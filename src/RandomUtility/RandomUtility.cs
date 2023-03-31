using System;

namespace RandomUtility
{
    /// <summary>
    /// Provides methods to generate pseudo-random objects.
    /// </summary>
    public static class RandomUtility
    {
        /// <summary>
        /// Returns a non-negative random integer.
        /// </summary>
        /// <returns>
        /// A 32-bit signed integer that is greater than or equal to 0 and less than <see cref="System.Int32.MaxValue"/>.
        /// </returns>
        public static int GetInt()
        {
            var random = new Random();

            return random.Next();
        }
    }
}