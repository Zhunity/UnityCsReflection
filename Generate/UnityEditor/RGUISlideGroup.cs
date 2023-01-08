using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor
{
	/// <summary>
	/// UnityEditor.GUISlideGroup
	/// </summary>
    public partial class RGUISlideGroup : RMember //
    {

		/// <summary>
		/// UnityEditor.GUISlideGroup current
		/// </summary>
		protected static RUnityEditor.RGUISlideGroup r_current;
		public static RUnityEditor.RGUISlideGroup Rcurrent
		{
			get
			{
				if(r_current == null)
				{
					r_current = new( ReleactionUtils.GetType("UnityEditor.GUISlideGroup"), "current");
					r_current.SetBelong(null);
				}
				return r_current;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Int32,UnityEngine.Rect] animIDs
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEngine.RRect> r_animIDs;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEngine.RRect> RanimIDs
		{
			get
			{
				if(r_animIDs == null)
				{
					r_animIDs = new(this, "animIDs");
					r_animIDs.SetBelong(this.instance);
				}
				return r_animIDs;
			}
		}

		/// <summary>
		/// System.Single kLerp
		/// </summary>
		protected static RField r_kLerp;
		public static RField RkLerp
		{
			get
			{
				if(r_kLerp == null)
				{
					r_kLerp = new( ReleactionUtils.GetType("UnityEditor.GUISlideGroup"), "kLerp");
					r_kLerp.SetBelong(null);
				}
				return r_kLerp;
			}
		}

		/// <summary>
		/// System.Single kSnap
		/// </summary>
		protected static RField r_kSnap;
		public static RField RkSnap
		{
			get
			{
				if(r_kSnap == null)
				{
					r_kSnap = new( ReleactionUtils.GetType("UnityEditor.GUISlideGroup"), "kSnap");
					r_kSnap.SetBelong(null);
				}
				return r_kSnap;
			}
		}

		/// <summary>
		/// Void Begin()
		/// </summary>
		protected RMethod r_Begin;
		public virtual RMethod RBegin
		{
			get
			{
				if(r_Begin == null)
				{
					r_Begin = new(this, "Begin", 0);
					r_Begin.SetBelong(this.instance);
				}
				return r_Begin;
			}
		}

		/// <summary>
		/// Void End()
		/// </summary>
		protected RMethod r_End;
		public virtual RMethod REnd
		{
			get
			{
				if(r_End == null)
				{
					r_End = new(this, "End", 0);
					r_End.SetBelong(this.instance);
				}
				return r_End;
			}
		}

		/// <summary>
		/// Void Reset()
		/// </summary>
		protected RMethod r_Reset;
		public virtual RMethod RReset
		{
			get
			{
				if(r_Reset == null)
				{
					r_Reset = new(this, "Reset", 0);
					r_Reset.SetBelong(this.instance);
				}
				return r_Reset;
			}
		}

		/// <summary>
		/// UnityEngine.Rect BeginHorizontal(Int32, UnityEngine.GUILayoutOption[])
		/// </summary>
		protected RMethod r_BeginHorizontal_Int32_GUILayoutOptionArray;
		public virtual RMethod RBeginHorizontal_Int32_GUILayoutOptionArray
		{
			get
			{
				if(r_BeginHorizontal_Int32_GUILayoutOptionArray == null)
				{
					r_BeginHorizontal_Int32_GUILayoutOptionArray = new(this, "BeginHorizontal", 0, typeof(System.Int32), typeof(UnityEngine.GUILayoutOption).MakeArrayType());
					r_BeginHorizontal_Int32_GUILayoutOptionArray.SetBelong(this.instance);
				}
				return r_BeginHorizontal_Int32_GUILayoutOptionArray;
			}
		}

		/// <summary>
		/// Void EndHorizontal()
		/// </summary>
		protected RMethod r_EndHorizontal;
		public virtual RMethod REndHorizontal
		{
			get
			{
				if(r_EndHorizontal == null)
				{
					r_EndHorizontal = new(this, "EndHorizontal", 0);
					r_EndHorizontal.SetBelong(this.instance);
				}
				return r_EndHorizontal;
			}
		}

		/// <summary>
		/// UnityEngine.Rect GetRect(Int32, UnityEngine.Rect)
		/// </summary>
		protected RMethod r_GetRect_Int32_Rect;
		public virtual RMethod RGetRect_Int32_Rect
		{
			get
			{
				if(r_GetRect_Int32_Rect == null)
				{
					r_GetRect_Int32_Rect = new(this, "GetRect", 0, typeof(System.Int32), typeof(UnityEngine.Rect));
					r_GetRect_Int32_Rect.SetBelong(this.instance);
				}
				return r_GetRect_Int32_Rect;
			}
		}

		/// <summary>
		/// UnityEngine.Rect GetRect(Int32, UnityEngine.Rect, Boolean ByRef)
		/// </summary>
		protected RMethod r_GetRect_Int32_Rect_Out_Boolean;
		public virtual RMethod RGetRect_Int32_Rect_Out_Boolean
		{
			get
			{
				if(r_GetRect_Int32_Rect_Out_Boolean == null)
				{
					r_GetRect_Int32_Rect_Out_Boolean = new(this, "GetRect", 0, typeof(System.Int32), typeof(UnityEngine.Rect), typeof(System.Boolean).MakeByRefType());
					r_GetRect_Int32_Rect_Out_Boolean.SetBelong(this.instance);
				}
				return r_GetRect_Int32_Rect_Out_Boolean;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_Equals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_Equals_Object == null)
				{
					r_Equals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_Equals_Object.SetBelong(this.instance);
				}
				return r_Equals_Object;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_Finalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_Finalize == null)
				{
					r_Finalize = new(this, "Finalize", 0);
					r_Finalize.SetBelong(this.instance);
				}
				return r_Finalize;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_GetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_GetHashCode == null)
				{
					r_GetHashCode = new(this, "GetHashCode", 0);
					r_GetHashCode.SetBelong(this.instance);
				}
				return r_GetHashCode;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_GetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_GetType == null)
				{
					r_GetType = new(this, "GetType", 0);
					r_GetType.SetBelong(this.instance);
				}
				return r_GetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_MemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_MemberwiseClone == null)
				{
					r_MemberwiseClone = new(this, "MemberwiseClone", 0);
					r_MemberwiseClone.SetBelong(this.instance);
				}
				return r_MemberwiseClone;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_ToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_ToString == null)
				{
					r_ToString = new(this, "ToString", 0);
					r_ToString.SetBelong(this.instance);
				}
				return r_ToString;
			}
		}


        public RGUISlideGroup() : base("UnityEditor.GUISlideGroup")
        {
        }

        public RGUISlideGroup(System.Object instance) : base("UnityEditor.GUISlideGroup")
		{
            SetInstance(instance);
		}

        public RGUISlideGroup(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RGUISlideGroup(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Begin()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RBegin.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void End()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = REnd.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Rect BeginHorizontal(System.Int32  @id, UnityEngine.GUILayoutOption[]  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id, @options};
            var ___result = RBeginHorizontal_Int32_GUILayoutOptionArray.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }


        public virtual void EndHorizontal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = REndHorizontal.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Rect GetRect(System.Int32  @id, UnityEngine.Rect  @r)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id, @r};
            var ___result = RGetRect_Int32_Rect.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }


        public virtual UnityEngine.Rect GetRect(System.Int32  @id, UnityEngine.Rect  @r, out System.Boolean  @changed)
        {
			changed = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id, @r, @changed};
            var ___result = RGetRect_Int32_Rect_Out_Boolean.Invoke(___genericsType, ___parameters);
			changed = (System.Boolean)___parameters[2];

            return (UnityEngine.Rect)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMemberwiseClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
