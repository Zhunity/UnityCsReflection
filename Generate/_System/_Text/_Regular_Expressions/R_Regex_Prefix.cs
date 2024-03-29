
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Text.RegularExpressions.RegexPrefix
	/// </summary>
    public partial class RRegexPrefix : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("System.Text.RegularExpressions.RegexPrefix");
            }
        }

        public RRegexPrefix() : base("System.Text.RegularExpressions.RegexPrefix")
        {
        }

        public RRegexPrefix(System.Object instance) : base("System.Text.RegularExpressions.RegexPrefix")
		{
            SetInstance(instance);
		}

        public RRegexPrefix(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRegexPrefix(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Boolean <CaseInsensitive>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_F__0__CaseInsensitive__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RF__0__CaseInsensitive__1__k__BackingField
		{
			get
			{
				if(r_F__0__CaseInsensitive__1__k__BackingField == null)
				{
					r_F__0__CaseInsensitive__1__k__BackingField = new(this, "<CaseInsensitive>k__BackingField");
				}
				return r_F__0__CaseInsensitive__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.RegexPrefix <Empty>k__BackingField
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegexPrefix r_F__0__Empty__1__k__BackingField;
		public static Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegexPrefix RF__0__Empty__1__k__BackingField
		{
			get
			{
				if(r_F__0__Empty__1__k__BackingField == null)
				{
					r_F__0__Empty__1__k__BackingField = new(Type, "<Empty>k__BackingField");
				}
				return r_F__0__Empty__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.String <Prefix>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_F__0__Prefix__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RF__0__Prefix__1__k__BackingField
		{
			get
			{
				if(r_F__0__Prefix__1__k__BackingField == null)
				{
					r_F__0__Prefix__1__k__BackingField = new(this, "<Prefix>k__BackingField");
				}
				return r_F__0__Prefix__1__k__BackingField;
			}
		}

		/// <summary>
		/// Boolean CaseInsensitive
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PCaseInsensitive;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPCaseInsensitive
		{
			get
			{
				if(r_PCaseInsensitive == null)
				{
					r_PCaseInsensitive = new(this, "CaseInsensitive", -1);
				}
				return r_PCaseInsensitive;
			}
		}

		/// <summary>
		/// System.Text.RegularExpressions.RegexPrefix Empty
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegexPrefix r_PEmpty;
		public static Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegexPrefix RPEmpty
		{
			get
			{
				if(r_PEmpty == null)
				{
					r_PEmpty = new(Type, "Empty", -1);
				}
				return r_PEmpty;
			}
		}

		/// <summary>
		/// System.String Prefix
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PPrefix;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPPrefix
		{
			get
			{
				if(r_PPrefix == null)
				{
					r_PPrefix = new(this, "Prefix", -1);
				}
				return r_PPrefix;
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


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
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

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


    }
}
