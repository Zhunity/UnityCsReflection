using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor
{
	/// <summary>
	/// UnityEditor.IDropArea
	/// </summary>
    public partial class RIDropArea : RMember //
    {

		/// <summary>
		/// UnityEditor.DropInfo DragOver(UnityEditor.EditorWindow, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_DragOver_EditorWindow_Vector2;
		public virtual RMethod RDragOver_EditorWindow_Vector2
		{
			get
			{
				if(r_DragOver_EditorWindow_Vector2 == null)
				{
					r_DragOver_EditorWindow_Vector2 = new(this, "DragOver", 0, typeof(UnityEditor.EditorWindow), typeof(UnityEngine.Vector2));
					r_DragOver_EditorWindow_Vector2.SetBelong(this.instance);
				}
				return r_DragOver_EditorWindow_Vector2;
			}
		}

		/// <summary>
		/// Boolean PerformDrop(UnityEditor.EditorWindow, UnityEditor.DropInfo, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_PerformDrop_EditorWindow_DropInfo_Vector2;
		public virtual RMethod RPerformDrop_EditorWindow_DropInfo_Vector2
		{
			get
			{
				if(r_PerformDrop_EditorWindow_DropInfo_Vector2 == null)
				{
					r_PerformDrop_EditorWindow_DropInfo_Vector2 = new(this, "PerformDrop", 0, typeof(UnityEditor.EditorWindow),  ReflectionUtils.GetType("UnityEditor.DropInfo"), typeof(UnityEngine.Vector2));
					r_PerformDrop_EditorWindow_DropInfo_Vector2.SetBelong(this.instance);
				}
				return r_PerformDrop_EditorWindow_DropInfo_Vector2;
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

        public virtual RUnityEditor.RDropInfo DragOver(UnityEditor.EditorWindow @w, UnityEngine.Vector2 @screenPos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@w, @screenPos};
            var ___result = RDragOver_EditorWindow_Vector2.Invoke(___genericsType, ___parameters);

            return new RUnityEditor.RDropInfo(___result);
        }


        public virtual System.Boolean PerformDrop(UnityEditor.EditorWindow @w, RUnityEditor.RDropInfo @dropInfo, UnityEngine.Vector2 @screenPos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@w, @dropInfo.Value, @screenPos};
            var ___result = RPerformDrop_EditorWindow_DropInfo_Vector2.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


    }
}
