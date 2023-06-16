
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RReflection.REmit
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// System.Reflection.Emit.MethodToken
	/// </summary>
    public partial class RMethodToken : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Reflection.Emit.MethodToken);
            }
        }

        public RMethodToken() : base("System.Reflection.Emit.MethodToken")
        {
        }

        public RMethodToken(System.Object instance) : base("System.Reflection.Emit.MethodToken")
		{
            SetInstance(instance);
		}

        public RMethodToken(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RMethodToken(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


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
		/// System.Reflection.Emit.MethodToken Empty
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RMethodToken r_FEmpty;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RMethodToken RFEmpty
		{
			get
			{
				if(r_FEmpty == null)
				{
					r_FEmpty = new(Type, "Empty");
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
		/// Boolean Equals(System.Reflection.Emit.MethodToken)
		/// </summary>
		protected RMethod r_MEquals_MethodToken;
		public virtual RMethod RMEquals_MethodToken
		{
			get
			{
				if(r_MEquals_MethodToken == null)
				{
					r_MEquals_MethodToken = new(this, "Equals", 0, typeof(System.Reflection.Emit.MethodToken));
				}
				return r_MEquals_MethodToken;
			}
		}

		/// <summary>
		/// Boolean op_Equality(System.Reflection.Emit.MethodToken, System.Reflection.Emit.MethodToken)
		/// </summary>
		protected static RMethod r_Mop_Equality_MethodToken_MethodToken;
		public static RMethod RMop_Equality_MethodToken_MethodToken
		{
			get
			{
				if(r_Mop_Equality_MethodToken_MethodToken == null)
				{
					r_Mop_Equality_MethodToken_MethodToken = new(Type, "op_Equality", 0, typeof(System.Reflection.Emit.MethodToken), typeof(System.Reflection.Emit.MethodToken));
				}
				return r_Mop_Equality_MethodToken_MethodToken;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Reflection.Emit.MethodToken, System.Reflection.Emit.MethodToken)
		/// </summary>
		protected static RMethod r_Mop_Inequality_MethodToken_MethodToken;
		public static RMethod RMop_Inequality_MethodToken_MethodToken
		{
			get
			{
				if(r_Mop_Inequality_MethodToken_MethodToken == null)
				{
					r_Mop_Inequality_MethodToken_MethodToken = new(Type, "op_Inequality", 0, typeof(System.Reflection.Emit.MethodToken), typeof(System.Reflection.Emit.MethodToken));
				}
				return r_Mop_Inequality_MethodToken_MethodToken;
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


        public virtual System.Boolean Equals(System.Reflection.Emit.MethodToken @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_MethodToken.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean op_Equality(System.Reflection.Emit.MethodToken @a, System.Reflection.Emit.MethodToken @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMop_Equality_MethodToken_MethodToken.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean op_Inequality(System.Reflection.Emit.MethodToken @a, System.Reflection.Emit.MethodToken @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMop_Inequality_MethodToken_MethodToken.Invoke(___genericsType, ___parameters);

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
