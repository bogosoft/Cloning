namespace Bogosoft.Cloning
{
    /// <summary>
    /// Represents any type capable of creating exact copies of objects of a specified type.
    /// </summary>
    /// <typeparam name="T">The type of the object that can be cloned.</typeparam>
    public interface IClone<T>
    {
        /// <summary>
        /// Clone a given object, creating an exact copy.
        /// </summary>
        /// <param name="obj">An object to be cloned.</param>
        /// <returns>A new reference to an exact copy of the given object.</returns>
        T Clone(T obj);
    }
}