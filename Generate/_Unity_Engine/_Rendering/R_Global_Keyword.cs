
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RRendering
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// UnityEngine.Rendering.GlobalKeyword
	/// </summary>
    public partial class RGlobalKeyword : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.Rendering.GlobalKeyword);
            }
        }

        public RGlobalKeyword() : base("UnityEngine.Rendering.GlobalKeyword")
        {
        }

        public RGlobalKeyword(System.Object instance) : base("UnityEngine.Rendering.GlobalKeyword")
		{
            SetInstance(instance);
		}

        public RGlobalKeyword(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RGlobalKeyword(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.String m_Name
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_Name;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_Name
		{
			get
			{
				if(r_Fm_Name == null)
				{
					r_Fm_Name = new(this, "m_Name");
				}
				return r_Fm_Name;
			}
		}

		/// <summary>
		/// System.UInt32 m_Index
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_Fm_Index;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFm_Index
		{
			get
			{
				if(r_Fm_Index == null)
				{
					r_Fm_Index = new(this, "m_Index");
				}
				return r_Fm_Index;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Pname;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPname
		{
			get
			{
				if(r_Pname == null)
				{
					r_Pname = new(this, "name", -1);
				}
				return r_Pname;
			}
		}

		/// <summary>
		/// UInt32 GetGlobalKeywordCount()
		/// </summary>
		protected static RMethod r_MGetGlobalKeywordCount;
		public static RMethod RMGetGlobalKeywordCount
		{
			get
			{
				if(r_MGetGlobalKeywordCount == null)
				{
					r_MGetGlobalKeywordCount = new(Type, "GetGlobalKeywordCount", 0);
				}
				return r_MGetGlobalKeywordCount;
			}
		}

		/// <summary>
		/// UInt32 GetGlobalKeywordIndex(System.String)
		/// </summary>
		protected static RMethod r_MGetGlobalKeywordIndex_String;
		public static RMethod RMGetGlobalKeywordIndex_String
		{
			get
			{
				if(r_MGetGlobalKeywordIndex_String == null)
				{
					r_MGetGlobalKeywordIndex_String = new(Type, "GetGlobalKeywordIndex", 0, typeof(System.String));
				}
				return r_MGetGlobalKeywordIndex_String;
			}
		}

		/// <summary>
		/// Void CreateGlobalKeyword(System.String)
		/// </summary>
		protected static RMethod r_MCreateGlobalKeyword_String;
		public static RMethod RMCreateGlobalKeyword_String
		{
			get
			{
				if(r_MCreateGlobalKeyword_String == null)
				{
					r_MCreateGlobalKeyword_String = new(Type, "CreateGlobalKeyword", 0, typeof(System.String));
				}
				return r_MCreateGlobalKeyword_String;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.GlobalKeyword Create(System.String)
		/// </summary>
		protected static RMethod r_MCreate_String;
		public static RMethod RMCreate_String
		{
			get
			{
				if(r_MCreate_String == null)
				{
					r_MCreate_String = new(Type, "Create", 0, typeof(System.String));
				}
				return r_MCreate_String;
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


        public static System.UInt32 GetGlobalKeywordCount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetGlobalKeywordCount.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.UInt32>(___result);
        }


        public static System.UInt32 GetGlobalKeywordIndex(System.String @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = RMGetGlobalKeywordIndex_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.UInt32>(___result);
        }


        public static void CreateGlobalKeyword(System.String @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = RMCreateGlobalKeyword_String.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.Rendering.GlobalKeyword Create(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMCreate_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Rendering.GlobalKeyword>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
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
