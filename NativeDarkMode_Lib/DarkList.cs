using System;
using System.Collections.Generic;

namespace NativeDarkMode_Lib
{
    public class DarkList<T> : List<T>
    {
        // --- Events ---

        /// <summary>
        /// Fires just before an item is added to the list.
        /// The event handler receives the item that is about to be added.
        /// </summary>
        public event Action<T> BeforeAddItem;

        /// <summary>
        /// Fires just before an item is removed from the list.
        /// The event handler receives the item that is about to be removed.
        /// </summary>
        public event Action<T> BeforeRemoveItem;

        /// <summary>
        /// Fires just after an item is added to the list.
        /// The event handler receives the item that is about to be added.
        /// </summary>
        public event Action<T> AfterAddItem;

        /// <summary>
        /// Fires just after an item is removed from the list.
        /// The event handler receives the item that is about to be removed.
        /// </summary>
        public event Action<T> AfterRemoveItem;


        // --- Constructors ---
        public DarkList() : base() { }
        public DarkList(IEnumerable<T> collection) : base(collection) { }
        public DarkList(int capacity) : base(capacity) { }

        // --- New Add Method ---

        /// <summary>
        /// Hides the base List<T>.Add() method.
        /// This implementation fires the BeforeAddItem event before adding the item.
        /// </summary>
        /// <param name="item">The object to be added to the end of the list.</param>
        public new void Add(T item)
        {
            if (!this.Contains(item))
            {
                // 1. Fire the event BEFORE the operation
                OnBeforeAddItem(item);

                // 2. Perform the operation
                Console.WriteLine($"[Add Operation]: Adding item '{item}'.");
                base.Add(item);

                OnAfterAddItem(item);
            }
        }

        // --- New Remove Method ---

        /// <summary>
        /// Hides the base List<T>.Remove() method.
        /// This implementation fires the BeforeRemoveItem event before removing the item.
        /// </summary>
        /// <param name="item">The object to remove from the list.</param>
        /// <returns>true if item was successfully removed; otherwise, false.</returns>
        public new bool Remove(T item)
        {
            if (this.Contains(item))
            {
                // 1. Fire the event BEFORE the operation
                OnBeforeRemoveItem(item);

                // 2. Perform the operation
                Console.WriteLine($"[Remove Operation]: Attempting to remove item '{item}'.");
                bool result = base.Remove(item);
                OnAfterRemoveItem(item);

                if (!result)
                {
                    Console.WriteLine($"[Remove Operation]: Item '{item}' not found.");
                }

                return result;
            }

            return false;
        }

        // --- Protected virtual methods to raise events ---
        // These are the standard way to encapsulate event invocation.

        protected virtual void OnBeforeAddItem(T item)
        {
            // The ?.Invoke syntax is a thread-safe way to check if the event
            // has any subscribers before trying to fire it.
            BeforeAddItem?.Invoke(item);
        }

        protected virtual void OnBeforeRemoveItem(T item)
        {
            BeforeRemoveItem?.Invoke(item);
        }

        protected virtual void OnAfterAddItem(T item)
        {
            // The ?.Invoke syntax is a thread-safe way to check if the event
            // has any subscribers before trying to fire it.
            AfterAddItem?.Invoke(item);
        }

        protected virtual void OnAfterRemoveItem(T item)
        {
            AfterRemoveItem?.Invoke(item);
        }

        // --- Display Utility Method ---
        public void DisplayItems()
        {
            Console.WriteLine("\n--- Current List Items ---");
            if (this.Count == 0)
            {
                Console.WriteLine("(List is empty)");
                return;
            }
            foreach (var item in this)
            {
                Console.WriteLine($"- {item}");
            }
            Console.WriteLine("--------------------------");
        }
    }
}
