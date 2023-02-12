
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{public partial class RGUILayoutUtility
{
	
	/// <summary>
	/// UnityEngine.GUILayoutUtility+LayoutCacheState
	/// </summary>
    public partial class RLayoutCacheState : RMember //
    {

		/// <summary>
		/// System.Int32 id
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Fid;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFid
		{
			get
			{
				if(r_Fid == null)
				{
					r_Fid = new(this, "id");
					r_Fid.SetBelong(this.instance);
				}
				return r_Fid;
			}
		}

		/// <summary>
		/// UnityEngine.GUILayoutGroup topLevel
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RGUILayoutGroup r_FtopLevel;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RGUILayoutGroup RFtopLevel
		{
			get
			{
				if(r_FtopLevel == null)
				{
					r_FtopLevel = new(this, "topLevel");
					r_FtopLevel.SetBelong(this.instance);
				}
				return r_FtopLevel;
			}
		}

		/// <summary>
		/// UnityEngineInternal.GenericStack layoutGroups
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngineInternal.RGenericStack r_FlayoutGroups;
		public virtual SMFrame.Editor.Refleaction.RUnityEngineInternal.RGenericStack RFlayoutGroups
		{
			get
			{
				if(r_FlayoutGroups == null)
				{
					r_FlayoutGroups = new(this, "layoutGroups");
					r_FlayoutGroups.SetBelong(this.instance);
				}
				return r_FlayoutGroups;
			}
		}

		/// <summary>
		/// UnityEngine.GUILayoutGroup windows
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RGUILayoutGroup r_Fwindows;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RGUILayoutGroup RFwindows
		{
			get
			{
				if(r_Fwindows == null)
				{
					r_Fwindows = new(this, "windows");
					r_Fwindows.SetBelong(this.instance);
				}
				return r_Fwindows;
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
					r_MEquals_Object.SetBelong(this.instance);
				}
				return r_MEquals_Object;
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
					r_MGetHashCode.SetBelong(this.instance);
				}
				return r_MGetHashCode;
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
					r_MToString.SetBelong(this.instance);
				}
				return r_MToString;
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
					r_MFinalize.SetBelong(this.instance);
				}
				return r_MFinalize;
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
					r_MGetType.SetBelong(this.instance);
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
					r_MMemberwiseClone.SetBelong(this.instance);
				}
				return r_MMemberwiseClone;
			}
		}


        public RLayoutCacheState() : base("UnityEngine.GUILayoutUtility+LayoutCacheState")
        {
        }

        public RLayoutCacheState(System.Object instance) : base("UnityEngine.GUILayoutUtility+LayoutCacheState")
		{
            SetInstance(instance);
		}

        public RLayoutCacheState(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RLayoutCacheState(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
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


    }
}
}