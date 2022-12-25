using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RGlobalization
{
	/// <summary>
	/// System.Globalization.ISimpleCollator
	/// </summary>
    public partial class RISimpleCollator : RMember //
    {

		/// <summary>
		/// System.Globalization.SortKey GetSortKey(System.String, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_RGetSortKey_String_CompareOptions;
		public virtual RMethod RGetSortKey_String_CompareOptions
		{
			get
			{
				if(r_RGetSortKey_String_CompareOptions == null)
				{
					r_RGetSortKey_String_CompareOptions = new(this, "GetSortKey", 0, typeof(System.String), typeof(System.Globalization.CompareOptions));
					r_RGetSortKey_String_CompareOptions.SetBelong(this.instance);
				}
				return r_RGetSortKey_String_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 Compare(System.String, System.String)
		/// </summary>
		protected RMethod r_RCompare_String_String;
		public virtual RMethod RCompare_String_String
		{
			get
			{
				if(r_RCompare_String_String == null)
				{
					r_RCompare_String_String = new(this, "Compare", 0, typeof(System.String), typeof(System.String));
					r_RCompare_String_String.SetBelong(this.instance);
				}
				return r_RCompare_String_String;
			}
		}

		/// <summary>
		/// Int32 Compare(System.String, Int32, Int32, System.String, Int32, Int32, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_RCompare_String_Int32_Int32_String_Int32_Int32_CompareOptions;
		public virtual RMethod RCompare_String_Int32_Int32_String_Int32_Int32_CompareOptions
		{
			get
			{
				if(r_RCompare_String_Int32_Int32_String_Int32_Int32_CompareOptions == null)
				{
					r_RCompare_String_Int32_Int32_String_Int32_Int32_CompareOptions = new(this, "Compare", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Globalization.CompareOptions));
					r_RCompare_String_Int32_Int32_String_Int32_Int32_CompareOptions.SetBelong(this.instance);
				}
				return r_RCompare_String_Int32_Int32_String_Int32_Int32_CompareOptions;
			}
		}

		/// <summary>
		/// Boolean IsPrefix(System.String, System.String, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_RIsPrefix_String_String_CompareOptions;
		public virtual RMethod RIsPrefix_String_String_CompareOptions
		{
			get
			{
				if(r_RIsPrefix_String_String_CompareOptions == null)
				{
					r_RIsPrefix_String_String_CompareOptions = new(this, "IsPrefix", 0, typeof(System.String), typeof(System.String), typeof(System.Globalization.CompareOptions));
					r_RIsPrefix_String_String_CompareOptions.SetBelong(this.instance);
				}
				return r_RIsPrefix_String_String_CompareOptions;
			}
		}

		/// <summary>
		/// Boolean IsSuffix(System.String, System.String, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_RIsSuffix_String_String_CompareOptions;
		public virtual RMethod RIsSuffix_String_String_CompareOptions
		{
			get
			{
				if(r_RIsSuffix_String_String_CompareOptions == null)
				{
					r_RIsSuffix_String_String_CompareOptions = new(this, "IsSuffix", 0, typeof(System.String), typeof(System.String), typeof(System.Globalization.CompareOptions));
					r_RIsSuffix_String_String_CompareOptions.SetBelong(this.instance);
				}
				return r_RIsSuffix_String_String_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.String, System.String, Int32, Int32, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_RIndexOf_String_String_Int32_Int32_CompareOptions;
		public virtual RMethod RIndexOf_String_String_Int32_Int32_CompareOptions
		{
			get
			{
				if(r_RIndexOf_String_String_Int32_Int32_CompareOptions == null)
				{
					r_RIndexOf_String_String_Int32_Int32_CompareOptions = new(this, "IndexOf", 0, typeof(System.String), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Globalization.CompareOptions));
					r_RIndexOf_String_String_Int32_Int32_CompareOptions.SetBelong(this.instance);
				}
				return r_RIndexOf_String_String_Int32_Int32_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 IndexOf(System.String, Char, Int32, Int32, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_RIndexOf_String_Char_Int32_Int32_CompareOptions;
		public virtual RMethod RIndexOf_String_Char_Int32_Int32_CompareOptions
		{
			get
			{
				if(r_RIndexOf_String_Char_Int32_Int32_CompareOptions == null)
				{
					r_RIndexOf_String_Char_Int32_Int32_CompareOptions = new(this, "IndexOf", 0, typeof(System.String), typeof(System.Char), typeof(System.Int32), typeof(System.Int32), typeof(System.Globalization.CompareOptions));
					r_RIndexOf_String_Char_Int32_Int32_CompareOptions.SetBelong(this.instance);
				}
				return r_RIndexOf_String_Char_Int32_Int32_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(System.String, System.String, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_RLastIndexOf_String_String_CompareOptions;
		public virtual RMethod RLastIndexOf_String_String_CompareOptions
		{
			get
			{
				if(r_RLastIndexOf_String_String_CompareOptions == null)
				{
					r_RLastIndexOf_String_String_CompareOptions = new(this, "LastIndexOf", 0, typeof(System.String), typeof(System.String), typeof(System.Globalization.CompareOptions));
					r_RLastIndexOf_String_String_CompareOptions.SetBelong(this.instance);
				}
				return r_RLastIndexOf_String_String_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(System.String, System.String, Int32, Int32, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_RLastIndexOf_String_String_Int32_Int32_CompareOptions;
		public virtual RMethod RLastIndexOf_String_String_Int32_Int32_CompareOptions
		{
			get
			{
				if(r_RLastIndexOf_String_String_Int32_Int32_CompareOptions == null)
				{
					r_RLastIndexOf_String_String_Int32_Int32_CompareOptions = new(this, "LastIndexOf", 0, typeof(System.String), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Globalization.CompareOptions));
					r_RLastIndexOf_String_String_Int32_Int32_CompareOptions.SetBelong(this.instance);
				}
				return r_RLastIndexOf_String_String_Int32_Int32_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(System.String, Char, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_RLastIndexOf_String_Char_CompareOptions;
		public virtual RMethod RLastIndexOf_String_Char_CompareOptions
		{
			get
			{
				if(r_RLastIndexOf_String_Char_CompareOptions == null)
				{
					r_RLastIndexOf_String_Char_CompareOptions = new(this, "LastIndexOf", 0, typeof(System.String), typeof(System.Char), typeof(System.Globalization.CompareOptions));
					r_RLastIndexOf_String_Char_CompareOptions.SetBelong(this.instance);
				}
				return r_RLastIndexOf_String_Char_CompareOptions;
			}
		}

		/// <summary>
		/// Int32 LastIndexOf(System.String, Char, Int32, Int32, System.Globalization.CompareOptions)
		/// </summary>
		protected RMethod r_RLastIndexOf_String_Char_Int32_Int32_CompareOptions;
		public virtual RMethod RLastIndexOf_String_Char_Int32_Int32_CompareOptions
		{
			get
			{
				if(r_RLastIndexOf_String_Char_Int32_Int32_CompareOptions == null)
				{
					r_RLastIndexOf_String_Char_Int32_Int32_CompareOptions = new(this, "LastIndexOf", 0, typeof(System.String), typeof(System.Char), typeof(System.Int32), typeof(System.Int32), typeof(System.Globalization.CompareOptions));
					r_RLastIndexOf_String_Char_Int32_Int32_CompareOptions.SetBelong(this.instance);
				}
				return r_RLastIndexOf_String_Char_Int32_Int32_CompareOptions;
			}
		}


        public RISimpleCollator() : base("System.Globalization.ISimpleCollator")
        {
        }

        public RISimpleCollator(System.Object instance) : base("System.Globalization.ISimpleCollator")
		{
            SetInstance(instance);
		}

        public RISimpleCollator(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RISimpleCollator(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Globalization.SortKey GetSortKey(System.String  @source, System.Globalization.CompareOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @options};
            var ___result = RGetSortKey_String_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Globalization.SortKey)___result;
        }


        public virtual System.Int32 Compare(System.String  @s1, System.String  @s2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s1, @s2};
            var ___result = RCompare_String_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 Compare(System.String  @s1, System.Int32  @idx1, System.Int32  @len1, System.String  @s2, System.Int32  @idx2, System.Int32  @len2, System.Globalization.CompareOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s1, @idx1, @len1, @s2, @idx2, @len2, @options};
            var ___result = RCompare_String_Int32_Int32_String_Int32_Int32_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean IsPrefix(System.String  @src, System.String  @target, System.Globalization.CompareOptions  @opt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @target, @opt};
            var ___result = RIsPrefix_String_String_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsSuffix(System.String  @src, System.String  @target, System.Globalization.CompareOptions  @opt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @target, @opt};
            var ___result = RIsSuffix_String_String_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 IndexOf(System.String  @s, System.String  @target, System.Int32  @start, System.Int32  @length, System.Globalization.CompareOptions  @opt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @target, @start, @length, @opt};
            var ___result = RIndexOf_String_String_Int32_Int32_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IndexOf(System.String  @s, System.Char  @target, System.Int32  @start, System.Int32  @length, System.Globalization.CompareOptions  @opt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @target, @start, @length, @opt};
            var ___result = RIndexOf_String_Char_Int32_Int32_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOf(System.String  @s, System.String  @target, System.Globalization.CompareOptions  @opt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @target, @opt};
            var ___result = RLastIndexOf_String_String_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOf(System.String  @s, System.String  @target, System.Int32  @start, System.Int32  @length, System.Globalization.CompareOptions  @opt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @target, @start, @length, @opt};
            var ___result = RLastIndexOf_String_String_Int32_Int32_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOf(System.String  @s, System.Char  @target, System.Globalization.CompareOptions  @opt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @target, @opt};
            var ___result = RLastIndexOf_String_Char_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 LastIndexOf(System.String  @s, System.Char  @target, System.Int32  @start, System.Int32  @length, System.Globalization.CompareOptions  @opt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @target, @start, @length, @opt};
            var ___result = RLastIndexOf_String_Char_Int32_Int32_CompareOptions.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


    }
}
