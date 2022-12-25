using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RRendering
{
	/// <summary>
	/// UnityEngine.Rendering.GlobalKeyword
	/// </summary>
    public partial class RGlobalKeyword : RMember //
    {

		/// <summary>
		/// System.String m_Name
		/// </summary>
		protected RField r_m_Name;
		public virtual RField Rm_Name
		{
			get
			{
				if(r_m_Name == null)
				{
					r_m_Name = new(this, "m_Name");
					r_m_Name.SetBelong(this.instance);
				}
				return r_m_Name;
			}
		}

		/// <summary>
		/// System.UInt32 m_Index
		/// </summary>
		protected RField r_m_Index;
		public virtual RField Rm_Index
		{
			get
			{
				if(r_m_Index == null)
				{
					r_m_Index = new(this, "m_Index");
					r_m_Index.SetBelong(this.instance);
				}
				return r_m_Index;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected RProperty r_name;
		public virtual RProperty Rname
		{
			get
			{
				if(r_name == null)
				{
					r_name = new(this, "name", -1);
					r_name.SetBelong(this.instance);
				}
				return r_name;
			}
		}

		/// <summary>
		/// UInt32 GetGlobalKeywordCount()
		/// </summary>
		protected static RMethod r_RGetGlobalKeywordCount;
		public static RMethod RGetGlobalKeywordCount
		{
			get
			{
				if(r_RGetGlobalKeywordCount == null)
				{
					r_RGetGlobalKeywordCount = new(typeof(UnityEngine.Rendering.GlobalKeyword), "GetGlobalKeywordCount", 0);
					r_RGetGlobalKeywordCount.SetBelong(null);
				}
				return r_RGetGlobalKeywordCount;
			}
		}

		/// <summary>
		/// UInt32 GetGlobalKeywordIndex(System.String)
		/// </summary>
		protected static RMethod r_RGetGlobalKeywordIndex_String;
		public static RMethod RGetGlobalKeywordIndex_String
		{
			get
			{
				if(r_RGetGlobalKeywordIndex_String == null)
				{
					r_RGetGlobalKeywordIndex_String = new(typeof(UnityEngine.Rendering.GlobalKeyword), "GetGlobalKeywordIndex", 0, typeof(System.String));
					r_RGetGlobalKeywordIndex_String.SetBelong(null);
				}
				return r_RGetGlobalKeywordIndex_String;
			}
		}

		/// <summary>
		/// Void CreateGlobalKeyword(System.String)
		/// </summary>
		protected static RMethod r_RCreateGlobalKeyword_String;
		public static RMethod RCreateGlobalKeyword_String
		{
			get
			{
				if(r_RCreateGlobalKeyword_String == null)
				{
					r_RCreateGlobalKeyword_String = new(typeof(UnityEngine.Rendering.GlobalKeyword), "CreateGlobalKeyword", 0, typeof(System.String));
					r_RCreateGlobalKeyword_String.SetBelong(null);
				}
				return r_RCreateGlobalKeyword_String;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.GlobalKeyword Create(System.String)
		/// </summary>
		protected static RMethod r_RCreate_String;
		public static RMethod RCreate_String
		{
			get
			{
				if(r_RCreate_String == null)
				{
					r_RCreate_String = new(typeof(UnityEngine.Rendering.GlobalKeyword), "Create", 0, typeof(System.String));
					r_RCreate_String.SetBelong(null);
				}
				return r_RCreate_String;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_RToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_RToString == null)
				{
					r_RToString = new(this, "ToString", 0);
					r_RToString.SetBelong(this.instance);
				}
				return r_RToString;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_REquals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_REquals_Object == null)
				{
					r_REquals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_REquals_Object.SetBelong(this.instance);
				}
				return r_REquals_Object;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_RGetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_RGetHashCode == null)
				{
					r_RGetHashCode = new(this, "GetHashCode", 0);
					r_RGetHashCode.SetBelong(this.instance);
				}
				return r_RGetHashCode;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_RFinalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_RFinalize == null)
				{
					r_RFinalize = new(this, "Finalize", 0);
					r_RFinalize.SetBelong(this.instance);
				}
				return r_RFinalize;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_RGetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_RGetType == null)
				{
					r_RGetType = new(this, "GetType", 0);
					r_RGetType.SetBelong(this.instance);
				}
				return r_RGetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_RMemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_RMemberwiseClone == null)
				{
					r_RMemberwiseClone = new(this, "MemberwiseClone", 0);
					r_RMemberwiseClone.SetBelong(this.instance);
				}
				return r_RMemberwiseClone;
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

        public static System.UInt32 GetGlobalKeywordCount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetGlobalKeywordCount.Invoke(___genericsType, ___parameters);

            return (System.UInt32)___result;
        }


        public static System.UInt32 GetGlobalKeywordIndex(System.String  @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = RGetGlobalKeywordIndex_String.Invoke(___genericsType, ___parameters);

            return (System.UInt32)___result;
        }


        public static void CreateGlobalKeyword(System.String  @keyword)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@keyword};
            var ___result = RCreateGlobalKeyword_String.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.Rendering.GlobalKeyword Create(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RCreate_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.GlobalKeyword)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
