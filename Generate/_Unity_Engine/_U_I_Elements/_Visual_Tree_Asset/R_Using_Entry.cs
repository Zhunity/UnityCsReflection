
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
		protected static SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RIComparer<SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeAsset.RUsingEntry> r_Fcomparer;
		public static SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RIComparer<SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeAsset.RUsingEntry> RFcomparer
		{
			get
			{
				if(r_Fcomparer == null)
				{
					r_Fcomparer = new( ReflectionUtils.GetType("UnityEngine.UIElements.VisualTreeAsset+UsingEntry"), "comparer");
					r_Fcomparer.SetBelong(null);
				}
				return r_Fcomparer;
			}
		}

		/// <summary>
		/// System.String alias
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_Falias;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RFalias
		{
			get
			{
				if(r_Falias == null)
				{
					r_Falias = new(this, "alias");
					r_Falias.SetBelong(this.instance);
				}
				return r_Falias;
			}
		}

		/// <summary>
		/// System.String path
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_Fpath;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RFpath
		{
			get
			{
				if(r_Fpath == null)
				{
					r_Fpath = new(this, "path");
					r_Fpath.SetBelong(this.instance);
				}
				return r_Fpath;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualTreeAsset asset
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeAsset r_Fasset;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeAsset RFasset
		{
			get
			{
				if(r_Fasset == null)
				{
					r_Fasset = new(this, "asset");
					r_Fasset.SetBelong(this.instance);
				}
				return r_Fasset;
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