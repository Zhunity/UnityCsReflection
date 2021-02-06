using SMFrame.Editor.Extension;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SMFrame.Editor.Refleaction
{
	public class RUnityType : Class
	{
		public Property _name;
		private Method _FindTypeByPersistentTypeID;

		private static RUnityType _instance;
		public static RUnityType Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new RUnityType();
				}
				return _instance;
			}
		}

		public RUnityType() : base("UnityType")
		{
			_name = new Property(this, "name");
			_FindTypeByPersistentTypeID = new Method(this, "FindTypeByPersistentTypeID");
		}

		public static RUnityType FindTypeByPersistentTypeID(int classId)
		{
			var obj = Instance._FindTypeByPersistentTypeID.Invoke(classId);
			RUnityType t = new RUnityType();
			t.SetInstance(obj);
			return t;
		}
	}
}
