
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
	/// UnityEditor.PackageManager.UI.Internal.VisualElementCache
	/// </summary>
    public partial class RVisualElementCache : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,UnityEngine.UIElements.VisualElement] m_Cache
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement> r_Fm_Cache;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement> RFm_Cache
		{
			get
			{
				if(r_Fm_Cache == null)
				{
					r_Fm_Cache = new(this, "m_Cache");
					r_Fm_Cache.SetBelong(this.GetValue());
				}
				return r_Fm_Cache;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement m_Root
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_Fm_Root;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RFm_Root
		{
			get
			{
				if(r_Fm_Root == null)
				{
					r_Fm_Root = new(this, "m_Root");
					r_Fm_Root.SetBelong(this.GetValue());
				}
				return r_Fm_Root;
			}
		}

		/// <summary>
		/// T Create[T](System.String)
		/// </summary>
		protected RMethod r_MCreate_GT_String;
		public virtual RMethod RMCreate_GT_String
		{
			get
			{
				if(r_MCreate_GT_String == null)
				{
					r_MCreate_GT_String = new(this, "Create", 1, typeof(System.String));
					r_MCreate_GT_String.SetBelong(this.GetValue());
				}
				return r_MCreate_GT_String;
			}
		}

		/// <summary>
		/// T Get[T](System.String)
		/// </summary>
		protected RMethod r_MGet_GT_String;
		public virtual RMethod RMGet_GT_String
		{
			get
			{
				if(r_MGet_GT_String == null)
				{
					r_MGet_GT_String = new(this, "Get", 1, typeof(System.String));
					r_MGet_GT_String.SetBelong(this.GetValue());
				}
				return r_MGet_GT_String;
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
					r_MEquals_Object.SetBelong(this.GetValue());
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
					r_MFinalize.SetBelong(this.GetValue());
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
					r_MGetHashCode.SetBelong(this.GetValue());
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
					r_MGetType.SetBelong(this.GetValue());
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
					r_MMemberwiseClone.SetBelong(this.GetValue());
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
					r_MToString.SetBelong(this.GetValue());
				}
				return r_MToString;
			}
		}


        public RVisualElementCache() : base("UnityEditor.PackageManager.UI.Internal.VisualElementCache")
        {
        }

        public RVisualElementCache(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.VisualElementCache")
		{
            SetInstance(instance);
		}

        public RVisualElementCache(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RVisualElementCache(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual T Create<T>(System.String @query) where T : UnityEngine.UIElements.VisualElement
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@query};
            var ___result = RMCreate_GT_String.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual T Get<T>(System.String @query) where T : UnityEngine.UIElements.VisualElement
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@query};
            var ___result = RMGet_GT_String.Invoke(___genericsType, ___parameters);

            return (T)___result;
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
