using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{public partial class RVisualTreeAsset
{
	
	/// <summary>
	/// UnityEngine.UIElements.VisualTreeAsset+UsingEntry
	/// </summary>
    public partial class RUsingEntry : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.IComparer`1[UnityEngine.UIElements.VisualTreeAsset+UsingEntry] comparer
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RIComparer<RUnityEngine.RUIElements.RVisualTreeAsset.RUsingEntry> r_comparer;
		public static RSystem.RCollections.RGeneric.RIComparer<RUnityEngine.RUIElements.RVisualTreeAsset.RUsingEntry> Rcomparer
		{
			get
			{
				if(r_comparer == null)
				{
					r_comparer = new( ReleactionUtils.GetType("UnityEngine.UIElements.VisualTreeAsset+UsingEntry"), "comparer");
					r_comparer.SetBelong(null);
				}
				return r_comparer;
			}
		}

		/// <summary>
		/// System.String alias
		/// </summary>
		protected RField r_alias;
		public virtual RField Ralias
		{
			get
			{
				if(r_alias == null)
				{
					r_alias = new(this, "alias");
					r_alias.SetBelong(this.instance);
				}
				return r_alias;
			}
		}

		/// <summary>
		/// System.String path
		/// </summary>
		protected RField r_path;
		public virtual RField Rpath
		{
			get
			{
				if(r_path == null)
				{
					r_path = new(this, "path");
					r_path.SetBelong(this.instance);
				}
				return r_path;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualTreeAsset asset
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualTreeAsset r_asset;
		public virtual RUnityEngine.RUIElements.RVisualTreeAsset Rasset
		{
			get
			{
				if(r_asset == null)
				{
					r_asset = new(this, "asset");
					r_asset.SetBelong(this.instance);
				}
				return r_asset;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_REquals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_REquals_Object == null)
				{
					r_REquals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_REquals_Object.SetBelong(this.instance);
				}
				return r_REquals_Object;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_RGetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_RGetHashCode == null)
				{
					r_RGetHashCode = new(this, "GetHashCode", 0);
					r_RGetHashCode.SetBelong(this.instance);
				}
				return r_RGetHashCode;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_RToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_RToString == null)
				{
					r_RToString = new(this, "ToString", 0);
					r_RToString.SetBelong(this.instance);
				}
				return r_RToString;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_RFinalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_RFinalize == null)
				{
					r_RFinalize = new(this, "Finalize", 0);
					r_RFinalize.SetBelong(this.instance);
				}
				return r_RFinalize;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_RGetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_RGetType == null)
				{
					r_RGetType = new(this, "GetType", 0);
					r_RGetType.SetBelong(this.instance);
				}
				return r_RGetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_RMemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_RMemberwiseClone == null)
				{
					r_RMemberwiseClone = new(this, "MemberwiseClone", 0);
					r_RMemberwiseClone.SetBelong(this.instance);
				}
				return r_RMemberwiseClone;
			}
		}


        public RUsingEntry() : base("UnityEngine.UIElements.VisualTreeAsset+UsingEntry")
        {
        }

        public RUsingEntry(System.Object instance) : base("UnityEngine.UIElements.VisualTreeAsset+UsingEntry")
		{
            SetInstance(instance);
		}

        public RUsingEntry(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RUsingEntry(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
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


    }
}
}