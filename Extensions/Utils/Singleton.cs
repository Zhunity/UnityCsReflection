using Hvak.Editor.Refleaction;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hvak.Editor.Extension
{

	/// <summary>
	/// 单例
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class Singleton<T> where T : new()
	{

		private static T _instance;

		public static T Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new T();
				}
				return _instance;
			}
		}
	}
}