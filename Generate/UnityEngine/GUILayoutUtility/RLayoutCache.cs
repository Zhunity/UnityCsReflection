using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{public partial class RGUILayoutUtility
{
	
	/// <summary>
	/// UnityEngine.GUILayoutUtility+LayoutCache
	/// </summary>
    public partial class RLayoutCache : RMember //
    {

		/// <summary>
		/// System.Int32 <id>k__BackingField
		/// </summary>
		protected RField r___0__id__1__k__BackingField;
		public virtual RField R__0__id__1__k__BackingField
		{
			get
			{
				if(r___0__id__1__k__BackingField == null)
				{
					r___0__id__1__k__BackingField = new(this, "<id>k__BackingField");
					r___0__id__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__id__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.GUILayoutGroup topLevel
		/// </summary>
		protected RUnityEngine.RGUILayoutGroup r_topLevel;
		public virtual RUnityEngine.RGUILayoutGroup RtopLevel
		{
			get
			{
				if(r_topLevel == null)
				{
					r_topLevel = new(this, "topLevel");
					r_topLevel.SetBelong(this.instance);
				}
				return r_topLevel;
			}
		}

		/// <summary>
		/// UnityEngineInternal.GenericStack layoutGroups
		/// </summary>
		protected RUnityEngineInternal.RGenericStack r_layoutGroups;
		public virtual RUnityEngineInternal.RGenericStack RlayoutGroups
		{
			get
			{
				if(r_layoutGroups == null)
				{
					r_layoutGroups = new(this, "layoutGroups");
					r_layoutGroups.SetBelong(this.instance);
				}
				return r_layoutGroups;
			}
		}

		/// <summary>
		/// UnityEngine.GUILayoutGroup windows
		/// </summary>
		protected RUnityEngine.RGUILayoutGroup r_windows;
		public virtual RUnityEngine.RGUILayoutGroup Rwindows
		{
			get
			{
				if(r_windows == null)
				{
					r_windows = new(this, "windows");
					r_windows.SetBelong(this.instance);
				}
				return r_windows;
			}
		}

		/// <summary>
		/// Int32 id
		/// </summary>
		protected RProperty r_id;
		public virtual RProperty Rid
		{
			get
			{
				if(r_id == null)
				{
					r_id = new(this, "id", -1);
					r_id.SetBelong(this.instance);
				}
				return r_id;
			}
		}

		/// <summary>
		/// LayoutCacheState State
		/// </summary>
		protected RUnityEngine.RGUILayoutUtility.RLayoutCacheState r_State;
		public virtual RUnityEngine.RGUILayoutUtility.RLayoutCacheState RState
		{
			get
			{
				if(r_State == null)
				{
					r_State = new(this, "State", -1);
					r_State.SetBelong(this.instance);
				}
				return r_State;
			}
		}

		/// <summary>
		/// Void CopyState(LayoutCacheState)
		/// </summary>
		protected RMethod r_CopyState_LayoutCacheState;
		public virtual RMethod RCopyState_LayoutCacheState
		{
			get
			{
				if(r_CopyState_LayoutCacheState == null)
				{
					r_CopyState_LayoutCacheState = new(this, "CopyState", 0,  ReflectionUtils.GetType("UnityEngine.GUILayoutUtility+LayoutCacheState"));
					r_CopyState_LayoutCacheState.SetBelong(this.instance);
				}
				return r_CopyState_LayoutCacheState;
			}
		}

		/// <summary>
		/// Void ResetCursor()
		/// </summary>
		protected RMethod r_ResetCursor;
		public virtual RMethod RResetCursor
		{
			get
			{
				if(r_ResetCursor == null)
				{
					r_ResetCursor = new(this, "ResetCursor", 0);
					r_ResetCursor.SetBelong(this.instance);
				}
				return r_ResetCursor;
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

        public virtual void CopyState(RUnityEngine.RGUILayoutUtility.RLayoutCacheState  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other.Value};
            var ___result = RCopyState_LayoutCacheState.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResetCursor()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RResetCursor.Invoke(___genericsType, ___parameters);

            
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
}