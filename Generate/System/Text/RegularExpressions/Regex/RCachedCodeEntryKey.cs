using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RText.RRegularExpressions
{public partial class RRegex
{
	
	/// <summary>
	/// System.Text.RegularExpressions.Regex+CachedCodeEntryKey
	/// </summary>
    public partial class RCachedCodeEntryKey : RMember //
    {

		/// <summary>
		/// System.Text.RegularExpressions.RegexOptions _options
		/// </summary>
		protected RField r__options;
		public virtual RField R_options
		{
			get
			{
				if(r__options == null)
				{
					r__options = new(this, "_options");
					r__options.SetBelong(this.instance);
				}
				return r__options;
			}
		}

		/// <summary>
		/// System.String _cultureKey
		/// </summary>
		protected RField r__cultureKey;
		public virtual RField R_cultureKey
		{
			get
			{
				if(r__cultureKey == null)
				{
					r__cultureKey = new(this, "_cultureKey");
					r__cultureKey.SetBelong(this.instance);
				}
				return r__cultureKey;
			}
		}

		/// <summary>
		/// System.String _pattern
		/// </summary>
		protected RField r__pattern;
		public virtual RField R_pattern
		{
			get
			{
				if(r__pattern == null)
				{
					r__pattern = new(this, "_pattern");
					r__pattern.SetBelong(this.instance);
				}
				return r__pattern;
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
		/// Boolean Equals(CachedCodeEntryKey)
		/// </summary>
		protected RMethod r_Equals_CachedCodeEntryKey;
		public virtual RMethod REquals_CachedCodeEntryKey
		{
			get
			{
				if(r_Equals_CachedCodeEntryKey == null)
				{
					r_Equals_CachedCodeEntryKey = new(this, "Equals", 0,  ReflectionUtils.GetType("System.Text.RegularExpressions.Regex+CachedCodeEntryKey"));
					r_Equals_CachedCodeEntryKey.SetBelong(this.instance);
				}
				return r_Equals_CachedCodeEntryKey;
			}
		}

		/// <summary>
		/// Boolean op_Equality(CachedCodeEntryKey, CachedCodeEntryKey)
		/// </summary>
		protected static RMethod r_op_Equality_CachedCodeEntryKey_CachedCodeEntryKey;
		public static RMethod Rop_Equality_CachedCodeEntryKey_CachedCodeEntryKey
		{
			get
			{
				if(r_op_Equality_CachedCodeEntryKey_CachedCodeEntryKey == null)
				{
					r_op_Equality_CachedCodeEntryKey_CachedCodeEntryKey = new( ReflectionUtils.GetType("System.Text.RegularExpressions.Regex+CachedCodeEntryKey"), "op_Equality", 0,  ReflectionUtils.GetType("System.Text.RegularExpressions.Regex+CachedCodeEntryKey"),  ReflectionUtils.GetType("System.Text.RegularExpressions.Regex+CachedCodeEntryKey"));
					r_op_Equality_CachedCodeEntryKey_CachedCodeEntryKey.SetBelong(null);
				}
				return r_op_Equality_CachedCodeEntryKey_CachedCodeEntryKey;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(CachedCodeEntryKey, CachedCodeEntryKey)
		/// </summary>
		protected static RMethod r_op_Inequality_CachedCodeEntryKey_CachedCodeEntryKey;
		public static RMethod Rop_Inequality_CachedCodeEntryKey_CachedCodeEntryKey
		{
			get
			{
				if(r_op_Inequality_CachedCodeEntryKey_CachedCodeEntryKey == null)
				{
					r_op_Inequality_CachedCodeEntryKey_CachedCodeEntryKey = new( ReflectionUtils.GetType("System.Text.RegularExpressions.Regex+CachedCodeEntryKey"), "op_Inequality", 0,  ReflectionUtils.GetType("System.Text.RegularExpressions.Regex+CachedCodeEntryKey"),  ReflectionUtils.GetType("System.Text.RegularExpressions.Regex+CachedCodeEntryKey"));
					r_op_Inequality_CachedCodeEntryKey_CachedCodeEntryKey.SetBelong(null);
				}
				return r_op_Inequality_CachedCodeEntryKey_CachedCodeEntryKey;
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

        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(RSystem.RText.RRegularExpressions.RRegex.RCachedCodeEntryKey  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other.Value};
            var ___result = REquals_CachedCodeEntryKey.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(RSystem.RText.RRegularExpressions.RRegex.RCachedCodeEntryKey  @left, RSystem.RText.RRegularExpressions.RRegex.RCachedCodeEntryKey  @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left.Value, @right.Value};
            var ___result = Rop_Equality_CachedCodeEntryKey_CachedCodeEntryKey.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(RSystem.RText.RRegularExpressions.RRegex.RCachedCodeEntryKey  @left, RSystem.RText.RRegularExpressions.RRegex.RCachedCodeEntryKey  @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left.Value, @right.Value};
            var ___result = Rop_Inequality_CachedCodeEntryKey_CachedCodeEntryKey.Invoke(___genericsType, ___parameters);

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