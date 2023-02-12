
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RResources
{
	/// <summary>
	/// System.Resources.Win32Resource
	/// </summary>
    public partial class RWin32Resource : RMember //
    {

		/// <summary>
		/// System.Resources.NameOrId type
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RResources.RNameOrId r_Ftype;
		public virtual SMFrame.Editor.Refleaction.RSystem.RResources.RNameOrId RFtype
		{
			get
			{
				if(r_Ftype == null)
				{
					r_Ftype = new(this, "type");
					r_Ftype.SetBelong(this.instance);
				}
				return r_Ftype;
			}
		}

		/// <summary>
		/// System.Resources.NameOrId name
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RResources.RNameOrId r_Fname;
		public virtual SMFrame.Editor.Refleaction.RSystem.RResources.RNameOrId RFname
		{
			get
			{
				if(r_Fname == null)
				{
					r_Fname = new(this, "name");
					r_Fname.SetBelong(this.instance);
				}
				return r_Fname;
			}
		}

		/// <summary>
		/// System.Int32 language
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Flanguage;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFlanguage
		{
			get
			{
				if(r_Flanguage == null)
				{
					r_Flanguage = new(this, "language");
					r_Flanguage.SetBelong(this.instance);
				}
				return r_Flanguage;
			}
		}

		/// <summary>
		/// System.Resources.Win32ResourceType ResourceType
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RResources.RWin32ResourceType r_PResourceType;
		public virtual SMFrame.Editor.Refleaction.RSystem.RResources.RWin32ResourceType RPResourceType
		{
			get
			{
				if(r_PResourceType == null)
				{
					r_PResourceType = new(this, "ResourceType", -1);
					r_PResourceType.SetBelong(this.instance);
				}
				return r_PResourceType;
			}
		}

		/// <summary>
		/// System.Resources.NameOrId Name
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RResources.RNameOrId r_PName;
		public virtual SMFrame.Editor.Refleaction.RSystem.RResources.RNameOrId RPName
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
		/// System.Resources.NameOrId Type
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RResources.RNameOrId r_PType;
		public virtual SMFrame.Editor.Refleaction.RSystem.RResources.RNameOrId RPType
		{
			get
			{
				if(r_PType == null)
				{
					r_PType = new(this, "Type", -1);
					r_PType.SetBelong(this.instance);
				}
				return r_PType;
			}
		}

		/// <summary>
		/// Int32 Language
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_PLanguage;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPLanguage
		{
			get
			{
				if(r_PLanguage == null)
				{
					r_PLanguage = new(this, "Language", -1);
					r_PLanguage.SetBelong(this.instance);
				}
				return r_PLanguage;
			}
		}

		/// <summary>
		/// Void WriteTo(System.IO.Stream)
		/// </summary>
		protected RMethod r_MWriteTo_Stream;
		public virtual RMethod RMWriteTo_Stream
		{
			get
			{
				if(r_MWriteTo_Stream == null)
				{
					r_MWriteTo_Stream = new(this, "WriteTo", 0, typeof(System.IO.Stream));
					r_MWriteTo_Stream.SetBelong(this.instance);
				}
				return r_MWriteTo_Stream;
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


        public RWin32Resource() : base("System.Resources.Win32Resource")
        {
        }

        public RWin32Resource(System.Object instance) : base("System.Resources.Win32Resource")
		{
            SetInstance(instance);
		}

        public RWin32Resource(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RWin32Resource(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void WriteTo(System.IO.Stream @s)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s};
            var ___result = RMWriteTo_Stream.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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


    }
}
