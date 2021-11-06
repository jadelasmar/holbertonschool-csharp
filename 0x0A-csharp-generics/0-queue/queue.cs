using System;
    /// <summary>
    /// generic queue class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class Queue<T>
    {
        /// <summary>
        /// method to get type
        /// </summary>
        /// <returns></returns>
        public Type CheckType()
        {
            return typeof(T);
        }
    }