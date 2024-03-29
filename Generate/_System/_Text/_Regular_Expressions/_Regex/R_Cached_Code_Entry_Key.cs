
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions
{public partial class RRegex
{
	
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Text.RegularExpressions.Regex+CachedCodeEntryKey
	/// </summary>
    public partial class RCachedCodeEntryKey : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("System.Text.RegularExpressions.Regex+CachedCodeEntryKey");
            }
        }

        public RCachedCodeEntryKey() : base("System.Text.RegularExpressions.Regex+CachedCodeEntryKey")
        {
        }

        public RCachedCodeEntryKey(System.Object instance) : base("System.Text.RegularExpressions.Regex+CachedCodeEntryKey")
		{
            SetInstance(instance);
		}

        public RCachedCodeEntryKey(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCachedCodeEntryKey(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Text.RegularExpressions.RegexOptions _options
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegexOptions r_F_options;
		public virtual Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegexOptions RF_options
		{
			get
			{
				if(r_F_options == null)
				{
					r_F_options = new(this, "_options");
				}
				return r_F_options;
			}
		}

		/// <summary>
		/// System.String _cultureKey
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_F_cultureKey;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RF_cultureKey
		{
			get
			{
				if(r_F_cultureKey == null)
				{
					r_F_cultureKey = new(this, "_cultureKey");
				}
				return r_F_cultureKey;
			}
		}

		/// <summary>
		/// System.String _pattern
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_F_pattern;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RF_pattern
		{
			get
			{
				if(r_F_pattern == null)
				{
					r_F_pattern = new(this, "_pattern");
				}
				return r_F_pattern;
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
		/// Boolean Equals(CachedCodeEntryKey)
		/// </summary>
		protected RMethod r_MEquals_CachedCodeEntryKey;
		public virtual RMethod RMEquals_CachedCodeEntryKey
		{
			get
			{
				if(r_MEquals_CachedCodeEntryKey == null)
				{
					r_MEquals_CachedCodeEntryKey = new(this, "Equals", 0,  ReflectionUtils.GetType("System.Text.RegularExpressions.Regex+CachedCodeEntryKey"));
				}
				return r_MEquals_CachedCodeEntryKey;
			}
		}

		/// <summary>
		/// Boolean op_Equality(CachedCodeEntryKey, CachedCodeEntryKey)
		/// </summary>
		protected static RMethod r_Mop_Equality_CachedCodeEntryKey_CachedCodeEntryKey;
		public static RMethod RMop_Equality_CachedCodeEntryKey_CachedCodeEntryKey
		{
			get
			{
				if(r_Mop_Equality_CachedCodeEntryKey_CachedCodeEntryKey == null)
				{
					r_Mop_Equality_CachedCodeEntryKey_CachedCodeEntryKey = new(Type, "op_Equality", 0,  ReflectionUtils.GetType("System.Text.RegularExpressions.Regex+CachedCodeEntryKey"),  ReflectionUtils.GetType("System.Text.RegularExpressions.Regex+CachedCodeEntryKey"));
				}
				return r_Mop_Equality_CachedCodeEntryKey_CachedCodeEntryKey;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(CachedCodeEntryKey, CachedCodeEntryKey)
		/// </summary>
		protected static RMethod r_Mop_Inequality_CachedCodeEntryKey_CachedCodeEntryKey;
		public static RMethod RMop_Inequality_CachedCodeEntryKey_CachedCodeEntryKey
		{
			get
			{
				if(r_Mop_Inequality_CachedCodeEntryKey_CachedCodeEntryKey == null)
				{
					r_Mop_Inequality_CachedCodeEntryKey_CachedCodeEntryKey = new(Type, "op_Inequality", 0,  ReflectionUtils.GetType("System.Text.RegularExpressions.Regex+CachedCodeEntryKey"),  ReflectionUtils.GetType("System.Text.RegularExpressions.Regex+CachedCodeEntryKey"));
				}
				return r_Mop_Inequality_CachedCodeEntryKey_CachedCodeEntryKey;
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


        public virtual System.Boolean Equals(Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegex.RCachedCodeEntryKey @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other.Value};
            var ___result = RMEquals_CachedCodeEntryKey.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean op_Equality(Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegex.RCachedCodeEntryKey @left, Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegex.RCachedCodeEntryKey @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left.Value, @right.Value};
            var ___result = RMop_Equality_CachedCodeEntryKey_CachedCodeEntryKey.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean op_Inequality(Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegex.RCachedCodeEntryKey @left, Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegex.RCachedCodeEntryKey @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left.Value, @right.Value};
            var ___result = RMop_Inequality_CachedCodeEntryKey_CachedCodeEntryKey.Invoke(___genericsType, ___parameters);

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
}