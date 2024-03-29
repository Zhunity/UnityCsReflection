
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEditor.GUISlideGroup
	/// </summary>
    public partial class RGUISlideGroup : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.GUISlideGroup");
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


		/// <summary>
		/// UnityEditor.GUISlideGroup current
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RGUISlideGroup r_Fcurrent;
		public static Hvak.Editor.Refleaction.RUnityEditor.RGUISlideGroup RFcurrent
		{
			get
			{
				if(r_Fcurrent == null)
				{
					r_Fcurrent = new(Type, "current");
				}
				return r_Fcurrent;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Int32,UnityEngine.Rect] animIDs
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RInt32, Hvak.Editor.Refleaction.RUnityEngine.RRect> r_FanimIDs;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RInt32, Hvak.Editor.Refleaction.RUnityEngine.RRect> RFanimIDs
		{
			get
			{
				if(r_FanimIDs == null)
				{
					r_FanimIDs = new(this, "animIDs");
				}
				return r_FanimIDs;
			}
		}

		/// <summary>
		/// System.Single kLerp
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSingle r_FkLerp;
		public static Hvak.Editor.Refleaction.RSystem.RSingle RFkLerp
		{
			get
			{
				if(r_FkLerp == null)
				{
					r_FkLerp = new(Type, "kLerp");
				}
				return r_FkLerp;
			}
		}

		/// <summary>
		/// System.Single kSnap
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSingle r_FkSnap;
		public static Hvak.Editor.Refleaction.RSystem.RSingle RFkSnap
		{
			get
			{
				if(r_FkSnap == null)
				{
					r_FkSnap = new(Type, "kSnap");
				}
				return r_FkSnap;
			}
		}

		/// <summary>
		/// Void Begin()
		/// </summary>
		protected RMethod r_MBegin;
		public virtual RMethod RMBegin
		{
			get
			{
				if(r_MBegin == null)
				{
					r_MBegin = new(this, "Begin", 0);
				}
				return r_MBegin;
			}
		}

		/// <summary>
		/// Void End()
		/// </summary>
		protected RMethod r_MEnd;
		public virtual RMethod RMEnd
		{
			get
			{
				if(r_MEnd == null)
				{
					r_MEnd = new(this, "End", 0);
				}
				return r_MEnd;
			}
		}

		/// <summary>
		/// Void Reset()
		/// </summary>
		protected RMethod r_MReset;
		public virtual RMethod RMReset
		{
			get
			{
				if(r_MReset == null)
				{
					r_MReset = new(this, "Reset", 0);
				}
				return r_MReset;
			}
		}

		/// <summary>
		/// UnityEngine.Rect BeginHorizontal(Int32, UnityEngine.GUILayoutOption[])
		/// </summary>
		protected RMethod r_MBeginHorizontal_Int32_GUILayoutOptionArray;
		public virtual RMethod RMBeginHorizontal_Int32_GUILayoutOptionArray
		{
			get
			{
				if(r_MBeginHorizontal_Int32_GUILayoutOptionArray == null)
				{
					r_MBeginHorizontal_Int32_GUILayoutOptionArray = new(this, "BeginHorizontal", 0, typeof(System.Int32), typeof(UnityEngine.GUILayoutOption).MakeArrayType());
				}
				return r_MBeginHorizontal_Int32_GUILayoutOptionArray;
			}
		}

		/// <summary>
		/// Void EndHorizontal()
		/// </summary>
		protected RMethod r_MEndHorizontal;
		public virtual RMethod RMEndHorizontal
		{
			get
			{
				if(r_MEndHorizontal == null)
				{
					r_MEndHorizontal = new(this, "EndHorizontal", 0);
				}
				return r_MEndHorizontal;
			}
		}

		/// <summary>
		/// UnityEngine.Rect GetRect(Int32, UnityEngine.Rect)
		/// </summary>
		protected RMethod r_MGetRect_Int32_Rect;
		public virtual RMethod RMGetRect_Int32_Rect
		{
			get
			{
				if(r_MGetRect_Int32_Rect == null)
				{
					r_MGetRect_Int32_Rect = new(this, "GetRect", 0, typeof(System.Int32), typeof(UnityEngine.Rect));
				}
				return r_MGetRect_Int32_Rect;
			}
		}

		/// <summary>
		/// UnityEngine.Rect GetRect(Int32, UnityEngine.Rect, Boolean ByRef)
		/// </summary>
		protected RMethod r_MGetRect_Int32_Rect_Out_Boolean;
		public virtual RMethod RMGetRect_Int32_Rect_Out_Boolean
		{
			get
			{
				if(r_MGetRect_Int32_Rect_Out_Boolean == null)
				{
					r_MGetRect_Int32_Rect_Out_Boolean = new(this, "GetRect", 0, typeof(System.Int32), typeof(UnityEngine.Rect), typeof(System.Boolean).MakeByRefType());
				}
				return r_MGetRect_Int32_Rect_Out_Boolean;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_MEquals_Object;
		public virtual RMethod RMEquals_Object
		{
			get
			{
				if(r_MEquals_Object == null)
				{
					r_MEquals_Object = new(this, "Equals", 0, typeof(System.Object));
				}
				return r_MEquals_Object;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_MFinalize;
		public virtual RMethod RMFinalize
		{
			get
			{
				if(r_MFinalize == null)
				{
					r_MFinalize = new(this, "Finalize", 0);
				}
				return r_MFinalize;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_MGetHashCode;
		public virtual RMethod RMGetHashCode
		{
			get
			{
				if(r_MGetHashCode == null)
				{
					r_MGetHashCode = new(this, "GetHashCode", 0);
				}
				return r_MGetHashCode;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_MGetType;
		public virtual RMethod RMGetType
		{
			get
			{
				if(r_MGetType == null)
				{
					r_MGetType = new(this, "GetType", 0);
				}
				return r_MGetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_MMemberwiseClone;
		public virtual RMethod RMMemberwiseClone
		{
			get
			{
				if(r_MMemberwiseClone == null)
				{
					r_MMemberwiseClone = new(this, "MemberwiseClone", 0);
				}
				return r_MMemberwiseClone;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_MToString;
		public virtual RMethod RMToString
		{
			get
			{
				if(r_MToString == null)
				{
					r_MToString = new(this, "ToString", 0);
				}
				return r_MToString;
			}
		}


        public virtual void Begin()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMBegin.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void End()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMEnd.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMReset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Rect BeginHorizontal(System.Int32 @id, UnityEngine.GUILayoutOption[] @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id, @options};
            var ___result = RMBeginHorizontal_Int32_GUILayoutOptionArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Rect>(___result);
        }


        public virtual void EndHorizontal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMEndHorizontal.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Rect GetRect(System.Int32 @id, UnityEngine.Rect @r)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id, @r};
            var ___result = RMGetRect_Int32_Rect.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Rect>(___result);
        }


        public virtual UnityEngine.Rect GetRect(System.Int32 @id, UnityEngine.Rect @r, out System.Boolean @changed)
        {
			@changed = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id, @r, @changed};
            var ___result = RMGetRect_Int32_Rect_Out_Boolean.Invoke(___genericsType, ___parameters);
			@changed = ReflectionUtils.Convert<System.Boolean>(___parameters[2]);

            return ReflectionUtils.Convert<UnityEngine.Rect>(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


    }
}
