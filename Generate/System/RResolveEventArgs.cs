using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.ResolveEventArgs
	/// </summary>
    public partial class RResolveEventArgs : RMember //
    {

		/// <summary>
		/// System.String <Name>k__BackingField
		/// </summary>
		protected RSystem.RString r_F__0__Name__1__k__BackingField;
		public virtual RSystem.RString RF__0__Name__1__k__BackingField
		{
			get
			{
				if(r_F__0__Name__1__k__BackingField == null)
				{
					r_F__0__Name__1__k__BackingField = new(this, "<Name>k__BackingField");
					r_F__0__Name__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__Name__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly <RequestingAssembly>k__BackingField
		/// </summary>
		protected RSystem.RReflection.RAssembly r_F__0__RequestingAssembly__1__k__BackingField;
		public virtual RSystem.RReflection.RAssembly RF__0__RequestingAssembly__1__k__BackingField
		{
			get
			{
				if(r_F__0__RequestingAssembly__1__k__BackingField == null)
				{
					r_F__0__RequestingAssembly__1__k__BackingField = new(this, "<RequestingAssembly>k__BackingField");
					r_F__0__RequestingAssembly__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__RequestingAssembly__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.String Name
		/// </summary>
		protected RSystem.RString r_PName;
		public virtual RSystem.RString RPName
		{
			get
			{
				if(r_PName == null)
				{
					r_PName = new(this, "Name", -1);
					r_PName.SetBelong(this.instance);
				}
				return r_PName;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly RequestingAssembly
		/// </summary>
		protected RSystem.RReflection.RAssembly r_PRequestingAssembly;
		public virtual RSystem.RReflection.RAssembly RPRequestingAssembly
		{
			get
			{
				if(r_PRequestingAssembly == null)
				{
					r_PRequestingAssembly = new(this, "RequestingAssembly", -1);
					r_PRequestingAssembly.SetBelong(this.instance);
				}
				return r_PRequestingAssembly;
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


        public RResolveEventArgs() : base("System.ResolveEventArgs")
        {
        }

        public RResolveEventArgs(System.Object instance) : base("System.ResolveEventArgs")
		{
            SetInstance(instance);
		}

        public RResolveEventArgs(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RResolveEventArgs(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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
