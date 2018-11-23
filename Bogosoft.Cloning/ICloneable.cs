using System;

namespace Bogosoft.Cloning
{
    /// <summary>
    /// Represents any type capable of making exact copies of itself.
    /// </summary>
    /// <typeparam name="T">The type of the object that can be cloned.</typeparam>
    public interface ICloneable<T> : ICloneable
    {
        /// <summary>
        /// Clone the current instance, creating an exact copy of itself.
        /// </summary>
        /// <returns>A new reference to an exact copy of the current object.</returns>
        new T Clone();
    }

    /// <summary>
    /// Extended functionality for the <see cref="ICloneable{T}"/> contract.
    /// </summary>
    public static class ICloneableExtensions
    {
        /// <summary>
        /// Clone the current instance and invoke a modifier action against the new copy before returning it.
        /// </summary>
        /// <typeparam name="T">The type of the object that can be cloned.</typeparam>
        /// <param name="self">The current <see cref="ICloneable{T}"/> instance.</param>
        /// <param name="modifier">
        /// A modifier action to invoke against the new copy before returning it.
        /// </param>
        /// <returns>
        /// A new reference to an exact copy of the current instance and modified by the given modifier action.
        /// </returns>
        public static T CloneAnd<T>(this ICloneable<T> self, Action<T> modifier)
        {
            var clone = self.Clone();

            modifier.Invoke(clone);

            return clone;
        }
    }
}