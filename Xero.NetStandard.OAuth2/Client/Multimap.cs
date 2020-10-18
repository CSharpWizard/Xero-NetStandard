/* 
 * Accounting API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2.3.6
 * Contact: api@xero.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Xero.NetStandard.OAuth2.Client
{
    /// <summary>
    /// A dictionary in which one key has many associated values.
    /// </summary>
    /// <typeparam name="T">The type of the key</typeparam>
    /// <typeparam name="TValue">The type of the value associated with the key.</typeparam>
    public class Multimap<T, TValue> : IDictionary<T, IList<TValue>>
    {
        #region Private Fields

        private readonly ConcurrentDictionary<T, IList<TValue>> _dictionary =
            new ConcurrentDictionary<T, IList<TValue>>();

        #endregion Private Fields

        #region Enumerators

        /// <summary>
        /// To get the enumerator.
        /// </summary>
        /// <returns>Enumerator</returns>
        public IEnumerator<KeyValuePair<T, IList<TValue>>> GetEnumerator()
        {
            return _dictionary.GetEnumerator();
        }

        /// <summary>
        /// To get the enumerator.
        /// </summary>
        /// <returns>Enumerator</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return _dictionary.GetEnumerator();
        }

        #endregion Enumerators

        #region Public Members
        /// <summary>
        /// Add values to Multimap
        /// </summary>
        /// <param name="item">Key value pair</param>
        public void Add(KeyValuePair<T, IList<TValue>> item)
        {
            if (!TryAdd(item.Key, item.Value))
                throw new InvalidOperationException("Could not add values to Multimap.");
        }

        /// <summary>
        /// Clear Multimap
        /// </summary>
        public void Clear()
        {
            _dictionary.Clear();
        }

        public bool Contains(KeyValuePair<T, IList<TValue>> item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(KeyValuePair<T, IList<TValue>>[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(KeyValuePair<T, IList<TValue>> item)
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get
            {
                return _dictionary.Count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public void Add(T key, IList<TValue> value)
        {
            if (value != null && value.Count > 0)
            {
                IList<TValue> list;
                if (_dictionary.TryGetValue(key, out list))
                {
                    foreach (var k in value) list.Add(k);
                }
                else
                {
                    list = new List<TValue>(value);
                    if (!TryAdd(key, list))
                        throw new InvalidOperationException("Could not add values to Multimap.");
                }
            }
        }

        public bool ContainsKey(T key)
        {
            return _dictionary.ContainsKey(key);
        }

        public bool Remove(T key)
        {
            IList<TValue> list;
            return TryRemove(key, out list);
        }

        public bool TryGetValue(T key, out IList<TValue> value)
        {
            return _dictionary.TryGetValue(key, out value);
        }

        public IList<TValue> this[T key]
        {
            get
            {
              return _dictionary[key];
            }
            set { _dictionary[key] = value; }
        }

        public ICollection<T> Keys
        {
            get
            {
                return _dictionary.Keys;
            }
        }

        public ICollection<IList<TValue>> Values
        {
            get
            {
                return _dictionary.Values;
            }
        }

        public void CopyTo(Array array, int index)
        {
            ((ICollection) _dictionary).CopyTo(array, index);
        }

        public void Add(T key, TValue value)
        {
            if (value != null)
            {
                IList<TValue> list;
                if (_dictionary.TryGetValue(key, out list))
                {
                    list.Add(value);
                }
                else
                {
                    list = new List<TValue>();
                    list.Add(value);
                    if (!TryAdd(key, list))
                        throw new InvalidOperationException("Could not add value to Multimap.");
                }
            }
        }

        #endregion Public Members

        #region Private Members

        /**
         * Helper method to encapsulate generator differences between dictioary types.
         */
        private bool TryRemove(T key, out IList<TValue> value)
        {
            return _dictionary.TryRemove(key, out value);
            
        }

        /**
         * Helper method to encapsulate generator differences between dictioary types.
         */
        private bool TryAdd(T key, IList<TValue> value)
        {
            return _dictionary.TryAdd(key, value);
        }
        #endregion Private Members
    }
}
