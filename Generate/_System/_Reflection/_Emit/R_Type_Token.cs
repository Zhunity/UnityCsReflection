
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RReflection.REmit
{
	/// <summary>
	/// System.Reflection.Emit.TypeToken
	/// </summary>
    public partial class RTypeToken : RMember //
    {

		/// <summary>
		/// System.Int32 tokValue
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FtokValue;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFtokValue
		{
			get
			{
				if(r_FtokValue == null)
				{
					r_FtokValue = new(this, "tokValue");
				}
				return r_FtokValue;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TypeToken Empty
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RTypeToken r_FEmpty;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RTypeToken RFEmpty
		{
			get
			{
				if(r_FEmpty == null)
				{
					r_FEmpty = new(typeof(System.Reflection.Emit.TypeToken), "Empty");
				}
				return r_FEmpty;
			}
		}

		/// <summary>
		/// Int32 Token
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PToken;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPToken
		{
			get
			{
				if(r_PToken == null)
				{
					r_PToken = new(this, "Token", -1);
				}
				return r_PToken;
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
		/// Boolean Equals(System.Reflection.Emit.TypeToken)
		/// </summary>
		protected RMethod r_MEquals_TypeToken;
		public virtual RMethod RMEquals_TypeToken
		{
			get
			{
				if(r_MEquals_TypeToken == null)
				{
					r_MEquals_TypeToken = new(this, "Equals", 0, typeof(System.Reflection.Emit.TypeToken));
				}
				return r_MEquals_TypeToken;
			}
		}

		/// <summary>
		/// Boolean op_Equality(System.Reflection.Emit.TypeToken, System.Reflection.Emit.TypeToken)
		/// </summary>
		protected static RMethod r_Mop_Equality_TypeToken_TypeToken;
		public static RMethod RMop_Equality_TypeToken_TypeToken
		{
			get
			{
				if(r_Mop_Equality_TypeToken_TypeToken == null)
				{
					r_Mop_Equality_TypeToken_TypeToken = new(typeof(System.Reflection.Emit.TypeToken), "op_Equality", 0, typeof(System.Reflection.Emit.TypeToken), typeof(System.Reflection.Emit.TypeToken));
				}
				return r_Mop_Equality_TypeToken_TypeToken;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Reflection.Emit.TypeToken, System.Reflection.Emit.TypeToken)
		/// </summary>
		protected static RMethod r_Mop_Inequality_TypeToken_TypeToken;
		public static RMethod RMop_Inequality_TypeToken_TypeToken
		{
			get
			{
				if(r_Mop_Inequality_TypeToken_TypeToken == null)
				{
					r_Mop_Inequality_TypeToken_TypeToken = new(typeof(System.Reflection.Emit.TypeToken), "op_Inequality", 0, typeof(System.Reflection.Emit.TypeToken), typeof(System.Reflection.Emit.TypeToken));
				}
				return r_Mop_Inequality_TypeToken_TypeToken;
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


        public RTypeToken() : base("System.Reflection.Emit.TypeToken")
        {
        }

        public RTypeToken(System.Object instance) : base("System.Reflection.Emit.TypeToken")
		{
            SetInstance(instance);
		}

        public RTypeToken(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTypeToken(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Reflection.Emit.TypeToken @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_TypeToken.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(System.Reflection.Emit.TypeToken @a, System.Reflection.Emit.TypeToken @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMop_Equality_TypeToken_TypeToken.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.Reflection.Emit.TypeToken @a, System.Reflection.Emit.TypeToken @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMop_Inequality_TypeToken_TypeToken.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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
