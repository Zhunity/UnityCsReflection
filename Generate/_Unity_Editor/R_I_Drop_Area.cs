
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// UnityEditor.IDropArea
	/// </summary>
    public partial class RIDropArea : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.IDropArea");
            }
        }

        public RIDropArea() : base("UnityEditor.IDropArea")
        {
        }

        public RIDropArea(System.Object instance) : base("UnityEditor.IDropArea")
		{
            SetInstance(instance);
		}

        public RIDropArea(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIDropArea(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// UnityEditor.DropInfo DragOver(UnityEditor.EditorWindow, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MDragOver_EditorWindow_Vector2;
		public virtual RMethod RMDragOver_EditorWindow_Vector2
		{
			get
			{
				if(r_MDragOver_EditorWindow_Vector2 == null)
				{
					r_MDragOver_EditorWindow_Vector2 = new(this, "DragOver", 0, typeof(UnityEditor.EditorWindow), typeof(UnityEngine.Vector2));
				}
				return r_MDragOver_EditorWindow_Vector2;
			}
		}

		/// <summary>
		/// Boolean PerformDrop(UnityEditor.EditorWindow, UnityEditor.DropInfo, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MPerformDrop_EditorWindow_DropInfo_Vector2;
		public virtual RMethod RMPerformDrop_EditorWindow_DropInfo_Vector2
		{
			get
			{
				if(r_MPerformDrop_EditorWindow_DropInfo_Vector2 == null)
				{
					r_MPerformDrop_EditorWindow_DropInfo_Vector2 = new(this, "PerformDrop", 0, typeof(UnityEditor.EditorWindow),  ReflectionUtils.GetType("UnityEditor.DropInfo"), typeof(UnityEngine.Vector2));
				}
				return r_MPerformDrop_EditorWindow_DropInfo_Vector2;
			}
		}


        public virtual Hvak.Editor.Refleaction.RUnityEditor.RDropInfo DragOver(UnityEditor.EditorWindow @w, UnityEngine.Vector2 @screenPos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@w, @screenPos};
            var ___result = RMDragOver_EditorWindow_Vector2.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEditor.RDropInfo>(___result);
        }


        public virtual System.Boolean PerformDrop(UnityEditor.EditorWindow @w, Hvak.Editor.Refleaction.RUnityEditor.RDropInfo @dropInfo, UnityEngine.Vector2 @screenPos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@w, @dropInfo.Value, @screenPos};
            var ___result = RMPerformDrop_EditorWindow_DropInfo_Vector2.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


    }
}
