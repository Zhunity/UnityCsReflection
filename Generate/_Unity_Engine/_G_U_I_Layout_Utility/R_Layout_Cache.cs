
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine
{public partial class RGUILayoutUtility
{
	
	/// <summary>
	/// UnityEngine.GUILayoutUtility+LayoutCache
	/// </summary>
    public partial class RLayoutCache : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.GUILayoutUtility+LayoutCache");
            }
        }

        public RLayoutCache() : base("UnityEngine.GUILayoutUtility+LayoutCache")
        {
        }

        public RLayoutCache(System.Object instance) : base("UnityEngine.GUILayoutUtility+LayoutCache")
		{
            SetInstance(instance);
		}

        public RLayoutCache(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RLayoutCache(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Int32 <id>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F__0__id__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF__0__id__1__k__BackingField
		{
			get
			{
				if(r_F__0__id__1__k__BackingField == null)
				{
					r_F__0__id__1__k__BackingField = new(this, "<id>k__BackingField");
				}
				return r_F__0__id__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.GUILayoutGroup topLevel
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RGUILayoutGroup r_FtopLevel;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RGUILayoutGroup RFtopLevel
		{
			get
			{
				if(r_FtopLevel == null)
				{
					r_FtopLevel = new(this, "topLevel");
				}
				return r_FtopLevel;
			}
		}

		/// <summary>
		/// UnityEngineInternal.GenericStack layoutGroups
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngineInternal.RGenericStack r_FlayoutGroups;
		public virtual Hvak.Editor.Refleaction.RUnityEngineInternal.RGenericStack RFlayoutGroups
		{
			get
			{
				if(r_FlayoutGroups == null)
				{
					r_FlayoutGroups = new(this, "layoutGroups");
				}
				return r_FlayoutGroups;
			}
		}

		/// <summary>
		/// UnityEngine.GUILayoutGroup windows
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RGUILayoutGroup r_Fwindows;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RGUILayoutGroup RFwindows
		{
			get
			{
				if(r_Fwindows == null)
				{
					r_Fwindows = new(this, "windows");
				}
				return r_Fwindows;
			}
		}

		/// <summary>
		/// Int32 id
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Pid;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPid
		{
			get
			{
				if(r_Pid == null)
				{
					r_Pid = new(this, "id", -1);
				}
				return r_Pid;
			}
		}

		/// <summary>
		/// LayoutCacheState State
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RGUILayoutUtility.RLayoutCacheState r_PState;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RGUILayoutUtility.RLayoutCacheState RPState
		{
			get
			{
				if(r_PState == null)
				{
					r_PState = new(this, "State", -1);
				}
				return r_PState;
			}
		}

		/// <summary>
		/// Void CopyState(LayoutCacheState)
		/// </summary>
		protected RMethod r_MCopyState_LayoutCacheState;
		public virtual RMethod RMCopyState_LayoutCacheState
		{
			get
			{
				if(r_MCopyState_LayoutCacheState == null)
				{
					r_MCopyState_LayoutCacheState = new(this, "CopyState", 0,  ReflectionUtils.GetType("UnityEngine.GUILayoutUtility+LayoutCacheState"));
				}
				return r_MCopyState_LayoutCacheState;
			}
		}

		/// <summary>
		/// Void ResetCursor()
		/// </summary>
		protected RMethod r_MResetCursor;
		public virtual RMethod RMResetCursor
		{
			get
			{
				if(r_MResetCursor == null)
				{
					r_MResetCursor = new(this, "ResetCursor", 0);
				}
				return r_MResetCursor;
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


        public virtual void CopyState(Hvak.Editor.Refleaction.RUnityEngine.RGUILayoutUtility.RLayoutCacheState @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other.Value};
            var ___result = RMCopyState_LayoutCacheState.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResetCursor()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMResetCursor.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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

            return (System.Int32)___result;
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
}