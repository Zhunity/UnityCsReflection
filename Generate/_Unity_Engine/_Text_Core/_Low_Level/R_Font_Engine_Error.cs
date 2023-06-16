
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// UnityEngine.TextCore.LowLevel.FontEngineError
	/// </summary>
    public partial class RFontEngineError : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.TextCore.LowLevel.FontEngineError);
            }
        }

        public RFontEngineError() : base("UnityEngine.TextCore.LowLevel.FontEngineError")
        {
        }

        public RFontEngineError(System.Object instance) : base("UnityEngine.TextCore.LowLevel.FontEngineError")
		{
            SetInstance(instance);
		}

        public RFontEngineError(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RFontEngineError(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Int32 value__
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fvalue__;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFvalue__
		{
			get
			{
				if(r_Fvalue__ == null)
				{
					r_Fvalue__ = new(this, "value__");
				}
				return r_Fvalue__;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.FontEngineError Success
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RFontEngineError r_FSuccess;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RFontEngineError RFSuccess
		{
			get
			{
				if(r_FSuccess == null)
				{
					r_FSuccess = new(Type, "Success");
				}
				return r_FSuccess;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.FontEngineError Invalid_File_Path
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RFontEngineError r_FInvalid_File_Path;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RFontEngineError RFInvalid_File_Path
		{
			get
			{
				if(r_FInvalid_File_Path == null)
				{
					r_FInvalid_File_Path = new(Type, "Invalid_File_Path");
				}
				return r_FInvalid_File_Path;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.FontEngineError Invalid_File_Format
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RFontEngineError r_FInvalid_File_Format;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RFontEngineError RFInvalid_File_Format
		{
			get
			{
				if(r_FInvalid_File_Format == null)
				{
					r_FInvalid_File_Format = new(Type, "Invalid_File_Format");
				}
				return r_FInvalid_File_Format;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.FontEngineError Invalid_File_Structure
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RFontEngineError r_FInvalid_File_Structure;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RFontEngineError RFInvalid_File_Structure
		{
			get
			{
				if(r_FInvalid_File_Structure == null)
				{
					r_FInvalid_File_Structure = new(Type, "Invalid_File_Structure");
				}
				return r_FInvalid_File_Structure;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.FontEngineError Invalid_File
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RFontEngineError r_FInvalid_File;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RFontEngineError RFInvalid_File
		{
			get
			{
				if(r_FInvalid_File == null)
				{
					r_FInvalid_File = new(Type, "Invalid_File");
				}
				return r_FInvalid_File;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.FontEngineError Invalid_Table
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RFontEngineError r_FInvalid_Table;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RFontEngineError RFInvalid_Table
		{
			get
			{
				if(r_FInvalid_Table == null)
				{
					r_FInvalid_Table = new(Type, "Invalid_Table");
				}
				return r_FInvalid_Table;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.FontEngineError Invalid_Glyph_Index
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RFontEngineError r_FInvalid_Glyph_Index;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RFontEngineError RFInvalid_Glyph_Index
		{
			get
			{
				if(r_FInvalid_Glyph_Index == null)
				{
					r_FInvalid_Glyph_Index = new(Type, "Invalid_Glyph_Index");
				}
				return r_FInvalid_Glyph_Index;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.FontEngineError Invalid_Character_Code
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RFontEngineError r_FInvalid_Character_Code;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RFontEngineError RFInvalid_Character_Code
		{
			get
			{
				if(r_FInvalid_Character_Code == null)
				{
					r_FInvalid_Character_Code = new(Type, "Invalid_Character_Code");
				}
				return r_FInvalid_Character_Code;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.FontEngineError Invalid_Pixel_Size
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RFontEngineError r_FInvalid_Pixel_Size;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RFontEngineError RFInvalid_Pixel_Size
		{
			get
			{
				if(r_FInvalid_Pixel_Size == null)
				{
					r_FInvalid_Pixel_Size = new(Type, "Invalid_Pixel_Size");
				}
				return r_FInvalid_Pixel_Size;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.FontEngineError Invalid_Library
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RFontEngineError r_FInvalid_Library;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RFontEngineError RFInvalid_Library
		{
			get
			{
				if(r_FInvalid_Library == null)
				{
					r_FInvalid_Library = new(Type, "Invalid_Library");
				}
				return r_FInvalid_Library;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.FontEngineError Invalid_Face
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RFontEngineError r_FInvalid_Face;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RFontEngineError RFInvalid_Face
		{
			get
			{
				if(r_FInvalid_Face == null)
				{
					r_FInvalid_Face = new(Type, "Invalid_Face");
				}
				return r_FInvalid_Face;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.FontEngineError Invalid_Library_or_Face
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RFontEngineError r_FInvalid_Library_or_Face;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RFontEngineError RFInvalid_Library_or_Face
		{
			get
			{
				if(r_FInvalid_Library_or_Face == null)
				{
					r_FInvalid_Library_or_Face = new(Type, "Invalid_Library_or_Face");
				}
				return r_FInvalid_Library_or_Face;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.FontEngineError Atlas_Generation_Cancelled
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RFontEngineError r_FAtlas_Generation_Cancelled;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RFontEngineError RFAtlas_Generation_Cancelled
		{
			get
			{
				if(r_FAtlas_Generation_Cancelled == null)
				{
					r_FAtlas_Generation_Cancelled = new(Type, "Atlas_Generation_Cancelled");
				}
				return r_FAtlas_Generation_Cancelled;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.FontEngineError Invalid_SharedTextureData
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RFontEngineError r_FInvalid_SharedTextureData;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RFontEngineError RFInvalid_SharedTextureData
		{
			get
			{
				if(r_FInvalid_SharedTextureData == null)
				{
					r_FInvalid_SharedTextureData = new(Type, "Invalid_SharedTextureData");
				}
				return r_FInvalid_SharedTextureData;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.LowLevel.FontEngineError OpenTypeLayoutLookup_Mismatch
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RFontEngineError r_FOpenTypeLayoutLookup_Mismatch;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel.RFontEngineError RFOpenTypeLayoutLookup_Mismatch
		{
			get
			{
				if(r_FOpenTypeLayoutLookup_Mismatch == null)
				{
					r_FOpenTypeLayoutLookup_Mismatch = new(Type, "OpenTypeLayoutLookup_Mismatch");
				}
				return r_FOpenTypeLayoutLookup_Mismatch;
			}
		}

		/// <summary>
		/// System.Object GetValue()
		/// </summary>
		protected RMethod r_MGetValue;
		public virtual RMethod RMGetValue
		{
			get
			{
				if(r_MGetValue == null)
				{
					r_MGetValue = new(this, "GetValue", 0);
				}
				return r_MGetValue;
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
		/// System.String ToString(System.String, System.IFormatProvider)
		/// </summary>
		protected RMethod r_MToString_String_IFormatProvider;
		public virtual RMethod RMToString_String_IFormatProvider
		{
			get
			{
				if(r_MToString_String_IFormatProvider == null)
				{
					r_MToString_String_IFormatProvider = new(this, "ToString", 0, typeof(System.String), typeof(System.IFormatProvider));
				}
				return r_MToString_String_IFormatProvider;
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
		/// System.String ToString(System.String)
		/// </summary>
		protected RMethod r_MToString_String;
		public virtual RMethod RMToString_String
		{
			get
			{
				if(r_MToString_String == null)
				{
					r_MToString_String = new(this, "ToString", 0, typeof(System.String));
				}
				return r_MToString_String;
			}
		}

		/// <summary>
		/// System.String ToString(System.IFormatProvider)
		/// </summary>
		protected RMethod r_MToString_IFormatProvider;
		public virtual RMethod RMToString_IFormatProvider
		{
			get
			{
				if(r_MToString_IFormatProvider == null)
				{
					r_MToString_IFormatProvider = new(this, "ToString", 0, typeof(System.IFormatProvider));
				}
				return r_MToString_IFormatProvider;
			}
		}

		/// <summary>
		/// Boolean HasFlag(System.Enum)
		/// </summary>
		protected RMethod r_MHasFlag_Enum;
		public virtual RMethod RMHasFlag_Enum
		{
			get
			{
				if(r_MHasFlag_Enum == null)
				{
					r_MHasFlag_Enum = new(this, "HasFlag", 0, typeof(System.Enum));
				}
				return r_MHasFlag_Enum;
			}
		}

		/// <summary>
		/// System.TypeCode GetTypeCode()
		/// </summary>
		protected RMethod r_MGetTypeCode;
		public virtual RMethod RMGetTypeCode
		{
			get
			{
				if(r_MGetTypeCode == null)
				{
					r_MGetTypeCode = new(this, "GetTypeCode", 0);
				}
				return r_MGetTypeCode;
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


        public virtual System.Object GetValue()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetValue.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
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


        public virtual System.String ToString(System.String @format, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @provider};
            var ___result = RMToString_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Int32 CompareTo(System.Object @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RMCompareTo_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.String ToString(System.String @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RMToString_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.String ToString(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMToString_IFormatProvider.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Boolean HasFlag(System.Enum @flag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@flag};
            var ___result = RMHasFlag_Enum.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.TypeCode GetTypeCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetTypeCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.TypeCode>(___result);
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
