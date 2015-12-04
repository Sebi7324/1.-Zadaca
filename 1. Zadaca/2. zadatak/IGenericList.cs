﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.zadatak
{
    interface IGenericList<X>
    {
        // Adds an item to the collection
        void Add(X item);

        // Removes the first occurrence of an item from the collection.
        // If the item was not found, method does nothing.
        bool Remove(X item);

        // Removes the item at the given index in the collection.
        bool RemoveAt(int index);

        // Returns the item at the given index in the collection.
        X GetElement(int index);

        // Returns the index of the item in the collection.
        // If item is not found in the collection, method returns -1.
        int IndexOf(X item);

        // Readonly property. Gets the number of items contained in the collection.
        int Count { get; }

        // Removes all items from the collection.
        void Clear();

        //Determines whether the collection contains a specific value.
        bool Contains(X item);

    }
}
