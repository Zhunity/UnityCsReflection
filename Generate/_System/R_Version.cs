
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Version
	/// </summary>
    public partial class RVersion : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Version);
            }
        }

        public RVersion() : base("System.Version")
        {
        }

        public RVersion(System.Object instance) : base("System.Version")
		{
            SetInstance(instance);
		}

        public RVersion(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RVersion(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Int32 _Major
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F_Major;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF_Major
		{
			get
			{
				if(r_F_Major == null)
				{
					r_F_Major = new(this, "_Major");
				}
				return r_F_Major;
			}
		}

		/// <summary>
		/// System.Int32 _Minor
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F_Minor;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF_Minor
		{
			get
			{
				if(r_F_Minor == null)
				{
					r_F_Minor = new(this, "_Minor");
				}
				return r_F_Minor;
			}
		}

		/// <summary>
		/// System.Int32 _Build
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F_Build;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF_Build
		{
			get
			{
				if(r_F_Build == null)
				{
					r_F_Build = new(this, "_Build");
				}
				return r_F_Build;
			}
		}

		/// <summary>
		/// System.Int32 _Revision
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F_Revision;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF_Revision
		{
			get
			{
				if(r_F_Revision == null)
				{
					r_F_Revision = new(this, "_Revision");
				}
				return r_F_Revision;
			}
		}

		/// <summary>
		/// Int32 Major
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PMajor;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPMajor
		{
			get
			{
				if(r_PMajor == null)
				{
					r_PMajor = new(this, "Major", -1);
				}
				return r_PMajor;
			}
		}

		/// <summary>
		/// Int32 Minor
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PMinor;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPMinor
		{
			get
			{
				if(r_PMinor == null)
				{
					r_PMinor = new(this, "Minor", -1);
				}
				return r_PMinor;
			}
		}

		/// <summary>
		/// Int32 Build
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PBuild;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPBuild
		{
			get
			{
				if(r_PBuild == null)
				{
					r_PBuild = new(this, "Build", -1);
				}
				return r_PBuild;
			}
		}

		/// <summary>
		/// Int32 Revision
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PRevision;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPRevision
		{
			get
			{
				if(r_PRevision == null)
				{
					r_PRevision = new(this, "Revision", -1);
				}
				return r_PRevision;
			}
		}

		/// <summary>
		/// Int16 MajorRevision
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt16 r_PMajorRevision;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt16 RPMajorRevision
		{
			get
			{
				if(r_PMajorRevision == null)
				{
					r_PMajorRevision = new(this, "MajorRevision", -1);
				}
				return r_PMajorRevision;
			}
		}

		/// <summary>
		/// Int16 MinorRevision
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt16 r_PMinorRevision;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt16 RPMinorRevision
		{
			get
			{
				if(r_PMinorRevision == null)
				{
					r_PMinorRevision = new(this, "MinorRevision", -1);
				}
				return r_PMinorRevision;
			}
		}

		/// <summary>
		/// Int32 DefaultFormatFieldCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PDefaultFormatFieldCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPDefaultFormatFieldCount
		{
			get
			{
				if(r_PDefaultFormatFieldCount == null)
				{
					r_PDefaultFormatFieldCount = new(this, "DefaultFormatFieldCount", -1);
				}
				return r_PDefaultFormatFieldCount;
			}
		}

		/// <summary>
		/// System.Object Clone()
		/// </summary>
		protected RMethod r_MClone;
		public virtual RMethod RMClone
		{
			get
			{
				if(r_MClone == null)
				{
					r_MClone = new(this, "Clone", 0);
				}
				return r_MClone;
			}
		}

		/// <summary>
		/// Int32 CompareTo(System.Object)
		/// </summary>
		protected RMethod r_MCompareTo_Object;
		public virtual RMethod RMCompareTo_Object
		{
			get
			{
				if(r_MCompareTo_Object == null)
				{
					r_MCompareTo_Object = new(this, "CompareTo", 0, typeof(System.Object));
				}
				return r_MCompareTo_Object;
			}
		}

		/// <summary>
		/// Int32 CompareTo(System.Version)
		/// </summary>
		protected RMethod r_MCompareTo_Version;
		public virtual RMethod RMCompareTo_Version
		{
			get
			{
				if(r_MCompareTo_Version == null)
				{
					r_MCompareTo_Version = new(this, "CompareTo", 0, typeof(System.Version));
				}
				return r_MCompareTo_Version;
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
		/// Boolean Equals(System.Version)
		/// </summary>
		protected RMethod r_MEquals_Version;
		public virtual RMethod RMEquals_Version
		{
			get
			{
				if(r_MEquals_Version == null)
				{
					r_MEquals_Version = new(this, "Equals", 0, typeof(System.Version));
				}
				return r_MEquals_Version;
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
		/// System.String ToString(Int32)
		/// </summary>
		protected RMethod r_MToString_Int32;
		public virtual RMethod RMToString_Int32
		{
			get
			{
				if(r_MToString_Int32 == null)
				{
					r_MToString_Int32 = new(this, "ToString", 0, typeof(System.Int32));
				}
				return r_MToString_Int32;
			}
		}

		/// <summary>
		/// Boolean TryFormat(System.Span`1[System.Char], Int32 ByRef)
		/// </summary>
		protected RMethod r_MTryFormat_Span_d_Char_p__Out_Int32;
		public virtual RMethod RMTryFormat_Span_d_Char_p__Out_Int32
		{
			get
			{
				if(r_MTryFormat_Span_d_Char_p__Out_Int32 == null)
				{
					r_MTryFormat_Span_d_Char_p__Out_Int32 = new(this, "TryFormat", 0,  ReflectionUtils.GetType("System.Span`1").MakeGenericType(typeof(System.Char)), typeof(System.Int32).MakeByRefType());
				}
				return r_MTryFormat_Span_d_Char_p__Out_Int32;
			}
		}

		/// <summary>
		/// Boolean TryFormat(System.Span`1[System.Char], Int32, Int32 ByRef)
		/// </summary>
		protected RMethod r_MTryFormat_Span_d_Char_p__Int32_Out_Int32;
		public virtual RMethod RMTryFormat_Span_d_Char_p__Int32_Out_Int32
		{
			get
			{
				if(r_MTryFormat_Span_d_Char_p__Int32_Out_Int32 == null)
				{
					r_MTryFormat_Span_d_Char_p__Int32_Out_Int32 = new(this, "TryFormat", 0,  ReflectionUtils.GetType("System.Span`1").MakeGenericType(typeof(System.Char)), typeof(System.Int32), typeof(System.Int32).MakeByRefType());
				}
				return r_MTryFormat_Span_d_Char_p__Int32_Out_Int32;
			}
		}

		/// <summary>
		/// Boolean System.ISpanFormattable.TryFormat(System.Span`1[System.Char], Int32 ByRef, System.ReadOnlySpan`1[System.Char], System.IFormatProvider)
		/// </summary>
		protected RMethod r_MSystem__2__ISpanFormattable__2__TryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider;
		public virtual RMethod RMSystem__2__ISpanFormattable__2__TryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider
		{
			get
			{
				if(r_MSystem__2__ISpanFormattable__2__TryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider == null)
				{
					r_MSystem__2__ISpanFormattable__2__TryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider = new(this, "System.ISpanFormattable.TryFormat", 0,  ReflectionUtils.GetType("System.Span`1").MakeGenericType(typeof(System.Char)), typeof(System.Int32).MakeByRefType(),  ReflectionUtils.GetType("System.ReadOnlySpan`1").MakeGenericType(typeof(System.Char)), typeof(System.IFormatProvider));
				}
				return r_MSystem__2__ISpanFormattable__2__TryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder ToCachedStringBuilder(Int32)
		/// </summary>
		protected RMethod r_MToCachedStringBuilder_Int32;
		public virtual RMethod RMToCachedStringBuilder_Int32
		{
			get
			{
				if(r_MToCachedStringBuilder_Int32 == null)
				{
					r_MToCachedStringBuilder_Int32 = new(this, "ToCachedStringBuilder", 0, typeof(System.Int32));
				}
				return r_MToCachedStringBuilder_Int32;
			}
		}

		/// <summary>
		/// System.Version Parse(System.String)
		/// </summary>
		protected static RMethod r_MParse_String;
		public static RMethod RMParse_String
		{
			get
			{
				if(r_MParse_String == null)
				{
					r_MParse_String = new(Type, "Parse", 0, typeof(System.String));
				}
				return r_MParse_String;
			}
		}

		/// <summary>
		/// System.Version Parse(System.ReadOnlySpan`1[System.Char])
		/// </summary>
		protected static RMethod r_MParse_ReadOnlySpan_d_Char_p_;
		public static RMethod RMParse_ReadOnlySpan_d_Char_p_
		{
			get
			{
				if(r_MParse_ReadOnlySpan_d_Char_p_ == null)
				{
					r_MParse_ReadOnlySpan_d_Char_p_ = new(Type, "Parse", 0,  ReflectionUtils.GetType("System.ReadOnlySpan`1").MakeGenericType(typeof(System.Char)));
				}
				return r_MParse_ReadOnlySpan_d_Char_p_;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.String, System.Version ByRef)
		/// </summary>
		protected static RMethod r_MTryParse_String_Out_Version;
		public static RMethod RMTryParse_String_Out_Version
		{
			get
			{
				if(r_MTryParse_String_Out_Version == null)
				{
					r_MTryParse_String_Out_Version = new(Type, "TryParse", 0, typeof(System.String), typeof(System.Version).MakeByRefType());
				}
				return r_MTryParse_String_Out_Version;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.ReadOnlySpan`1[System.Char], System.Version ByRef)
		/// </summary>
		protected static RMethod r_MTryParse_ReadOnlySpan_d_Char_p__Out_Version;
		public static RMethod RMTryParse_ReadOnlySpan_d_Char_p__Out_Version
		{
			get
			{
				if(r_MTryParse_ReadOnlySpan_d_Char_p__Out_Version == null)
				{
					r_MTryParse_ReadOnlySpan_d_Char_p__Out_Version = new(Type, "TryParse", 0,  ReflectionUtils.GetType("System.ReadOnlySpan`1").MakeGenericType(typeof(System.Char)), typeof(System.Version).MakeByRefType());
				}
				return r_MTryParse_ReadOnlySpan_d_Char_p__Out_Version;
			}
		}

		/// <summary>
		/// System.Version ParseVersion(System.ReadOnlySpan`1[System.Char], Boolean)
		/// </summary>
		protected static RMethod r_MParseVersion_ReadOnlySpan_d_Char_p__Boolean;
		public static RMethod RMParseVersion_ReadOnlySpan_d_Char_p__Boolean
		{
			get
			{
				if(r_MParseVersion_ReadOnlySpan_d_Char_p__Boolean == null)
				{
					r_MParseVersion_ReadOnlySpan_d_Char_p__Boolean = new(Type, "ParseVersion", 0,  ReflectionUtils.GetType("System.ReadOnlySpan`1").MakeGenericType(typeof(System.Char)), typeof(System.Boolean));
				}
				return r_MParseVersion_ReadOnlySpan_d_Char_p__Boolean;
			}
		}

		/// <summary>
		/// Boolean TryParseComponent(System.ReadOnlySpan`1[System.Char], System.String, Boolean, Int32 ByRef)
		/// </summary>
		protected static RMethod r_MTryParseComponent_ReadOnlySpan_d_Char_p__String_Boolean_Out_Int32;
		public static RMethod RMTryParseComponent_ReadOnlySpan_d_Char_p__String_Boolean_Out_Int32
		{
			get
			{
				if(r_MTryParseComponent_ReadOnlySpan_d_Char_p__String_Boolean_Out_Int32 == null)
				{
					r_MTryParseComponent_ReadOnlySpan_d_Char_p__String_Boolean_Out_Int32 = new(Type, "TryParseComponent", 0,  ReflectionUtils.GetType("System.ReadOnlySpan`1").MakeGenericType(typeof(System.Char)), typeof(System.String), typeof(System.Boolean), typeof(System.Int32).MakeByRefType());
				}
				return r_MTryParseComponent_ReadOnlySpan_d_Char_p__String_Boolean_Out_Int32;
			}
		}

		/// <summary>
		/// Boolean op_Equality(System.Version, System.Version)
		/// </summary>
		protected static RMethod r_Mop_Equality_Version_Version;
		public static RMethod RMop_Equality_Version_Version
		{
			get
			{
				if(r_Mop_Equality_Version_Version == null)
				{
					r_Mop_Equality_Version_Version = new(Type, "op_Equality", 0, typeof(System.Version), typeof(System.Version));
				}
				return r_Mop_Equality_Version_Version;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Version, System.Version)
		/// </summary>
		protected static RMethod r_Mop_Inequality_Version_Version;
		public static RMethod RMop_Inequality_Version_Version
		{
			get
			{
				if(r_Mop_Inequality_Version_Version == null)
				{
					r_Mop_Inequality_Version_Version = new(Type, "op_Inequality", 0, typeof(System.Version), typeof(System.Version));
				}
				return r_Mop_Inequality_Version_Version;
			}
		}

		/// <summary>
		/// Boolean op_LessThan(System.Version, System.Version)
		/// </summary>
		protected static RMethod r_Mop_LessThan_Version_Version;
		public static RMethod RMop_LessThan_Version_Version
		{
			get
			{
				if(r_Mop_LessThan_Version_Version == null)
				{
					r_Mop_LessThan_Version_Version = new(Type, "op_LessThan", 0, typeof(System.Version), typeof(System.Version));
				}
				return r_Mop_LessThan_Version_Version;
			}
		}

		/// <summary>
		/// Boolean op_LessThanOrEqual(System.Version, System.Version)
		/// </summary>
		protected static RMethod r_Mop_LessThanOrEqual_Version_Version;
		public static RMethod RMop_LessThanOrEqual_Version_Version
		{
			get
			{
				if(r_Mop_LessThanOrEqual_Version_Version == null)
				{
					r_Mop_LessThanOrEqual_Version_Version = new(Type, "op_LessThanOrEqual", 0, typeof(System.Version), typeof(System.Version));
				}
				return r_Mop_LessThanOrEqual_Version_Version;
			}
		}

		/// <summary>
		/// Boolean op_GreaterThan(System.Version, System.Version)
		/// </summary>
		protected static RMethod r_Mop_GreaterThan_Version_Version;
		public static RMethod RMop_GreaterThan_Version_Version
		{
			get
			{
				if(r_Mop_GreaterThan_Version_Version == null)
				{
					r_Mop_GreaterThan_Version_Version = new(Type, "op_GreaterThan", 0, typeof(System.Version), typeof(System.Version));
				}
				return r_Mop_GreaterThan_Version_Version;
			}
		}

		/// <summary>
		/// Boolean op_GreaterThanOrEqual(System.Version, System.Version)
		/// </summary>
		protected static RMethod r_Mop_GreaterThanOrEqual_Version_Version;
		public static RMethod RMop_GreaterThanOrEqual_Version_Version
		{
			get
			{
				if(r_Mop_GreaterThanOrEqual_Version_Version == null)
				{
					r_Mop_GreaterThanOrEqual_Version_Version = new(Type, "op_GreaterThanOrEqual", 0, typeof(System.Version), typeof(System.Version));
				}
				return r_Mop_GreaterThanOrEqual_Version_Version;
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


        public virtual System.Object Clone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.Int32 CompareTo(System.Object @version)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@version};
            var ___result = RMCompareTo_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 CompareTo(System.Version @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMCompareTo_Version.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean Equals(System.Version @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Version.Invoke(___genericsType, ___parameters);

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


        public virtual System.String ToString(System.Int32 @fieldCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fieldCount};
            var ___result = RMToString_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Boolean TryFormat(Hvak.Editor.Refleaction.RSystem.RSpan<Hvak.Editor.Refleaction.RSystem.RChar> @destination, out System.Int32 @charsWritten)
        {
			@charsWritten = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destination.Value, @charsWritten};
            var ___result = RMTryFormat_Span_d_Char_p__Out_Int32.Invoke(___genericsType, ___parameters);
			@charsWritten = ReflectionUtils.Convert<System.Int32>(___parameters[1]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean TryFormat(Hvak.Editor.Refleaction.RSystem.RSpan<Hvak.Editor.Refleaction.RSystem.RChar> @destination, System.Int32 @fieldCount, out System.Int32 @charsWritten)
        {
			@charsWritten = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destination.Value, @fieldCount, @charsWritten};
            var ___result = RMTryFormat_Span_d_Char_p__Int32_Out_Int32.Invoke(___genericsType, ___parameters);
			@charsWritten = ReflectionUtils.Convert<System.Int32>(___parameters[2]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean System__2__ISpanFormattable__2__TryFormat(Hvak.Editor.Refleaction.RSystem.RSpan<Hvak.Editor.Refleaction.RSystem.RChar> @destination, out System.Int32 @charsWritten, Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @format, System.IFormatProvider @provider)
        {
			@charsWritten = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destination.Value, @charsWritten, @format.Value, @provider};
            var ___result = RMSystem__2__ISpanFormattable__2__TryFormat_Span_d_Char_p__Out_Int32_ReadOnlySpan_d_Char_p__IFormatProvider.Invoke(___genericsType, ___parameters);
			@charsWritten = ReflectionUtils.Convert<System.Int32>(___parameters[1]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Text.StringBuilder ToCachedStringBuilder(System.Int32 @fieldCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fieldCount};
            var ___result = RMToCachedStringBuilder_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Text.StringBuilder>(___result);
        }


        public static System.Version Parse(System.String @input)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input};
            var ___result = RMParse_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Version>(___result);
        }


        public static System.Version Parse(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @input)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input.Value};
            var ___result = RMParse_ReadOnlySpan_d_Char_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Version>(___result);
        }


        public static System.Boolean TryParse(System.String @input, out System.Version @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @result};
            var ___result = RMTryParse_String_Out_Version.Invoke(___genericsType, ___parameters);
			@result = ReflectionUtils.Convert<System.Version>(___parameters[1]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean TryParse(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @input, out System.Version @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input.Value, @result};
            var ___result = RMTryParse_ReadOnlySpan_d_Char_p__Out_Version.Invoke(___genericsType, ___parameters);
			@result = ReflectionUtils.Convert<System.Version>(___parameters[1]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Version ParseVersion(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @input, System.Boolean @throwOnFailure)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input.Value, @throwOnFailure};
            var ___result = RMParseVersion_ReadOnlySpan_d_Char_p__Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Version>(___result);
        }


        public static System.Boolean TryParseComponent(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @component, System.String @componentName, System.Boolean @throwOnFailure, out System.Int32 @parsedComponent)
        {
			@parsedComponent = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@component.Value, @componentName, @throwOnFailure, @parsedComponent};
            var ___result = RMTryParseComponent_ReadOnlySpan_d_Char_p__String_Boolean_Out_Int32.Invoke(___genericsType, ___parameters);
			@parsedComponent = ReflectionUtils.Convert<System.Int32>(___parameters[3]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean op_Equality(System.Version @v1, System.Version @v2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v1, @v2};
            var ___result = RMop_Equality_Version_Version.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean op_Inequality(System.Version @v1, System.Version @v2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v1, @v2};
            var ___result = RMop_Inequality_Version_Version.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean op_LessThan(System.Version @v1, System.Version @v2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v1, @v2};
            var ___result = RMop_LessThan_Version_Version.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean op_LessThanOrEqual(System.Version @v1, System.Version @v2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v1, @v2};
            var ___result = RMop_LessThanOrEqual_Version_Version.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean op_GreaterThan(System.Version @v1, System.Version @v2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v1, @v2};
            var ___result = RMop_GreaterThan_Version_Version.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean op_GreaterThanOrEqual(System.Version @v1, System.Version @v2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v1, @v2};
            var ___result = RMop_GreaterThanOrEqual_Version_Version.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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
