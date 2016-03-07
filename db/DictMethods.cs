﻿using System;
using System.Collections.Generic;

namespace Totem
{
	//helper class
	public static class DictMethods
	{
		//return sorted array of keys or values from dictionary
		public static int[] GetSortedList(Dictionary<int, int> dict, bool keys) {
			List<KeyValuePair<int, int>> tempList = new List<KeyValuePair<int, int>>(dict);

			tempList.Sort(delegate(KeyValuePair<int, int> firstPair, KeyValuePair<int, int> secondPair)
				{
					return firstPair.Value.CompareTo(secondPair.Value);
				}
			);

			Dictionary<int, int> mySortedDictionary = new Dictionary<int, int>();
			foreach(KeyValuePair<int, int> pair in tempList)
			{
				mySortedDictionary.Add(pair.Key, pair.Value);
			}

			//reverse order
			int[] foos = new int[dict.Count];
			if (keys) {
				mySortedDictionary.Keys.CopyTo (foos, 0);
			} else {
				mySortedDictionary.Values.CopyTo(foos, 0);
			}

			return foos;

		}

		//adds entry to dictionary if it doesn't exist
		//updates it if it does
		public static void AddOrUpdateDictionaryEntry(Dictionary<int, int> dict, int key)
		{
			if (dict.ContainsKey(key))
			{
				dict[key]++;
			}
			else
			{
				dict.Add(key, 1);
			}
		}
	}
}

