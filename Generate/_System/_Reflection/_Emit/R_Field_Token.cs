
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RReflection.REmit
{
	/// <summary>
	/// System.Reflection.Emit.FieldToken
	/// </summary>
    public partial class RFieldToken : RMember //
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
					r_FtokValue.SetBelong(this.GetValue());
				}
				return r_FtokValue;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.FieldToken Empty
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RFieldToken r_FEmpty;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RFieldToken RFEmpty
		{
			get
			{
				if(r_FEmpty == null)
				{
					r_FEmpty = new(typeof(System.Reflection.Emit.FieldToken), "Empty");
					r_FEmpty.SetBelong(null);
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
					r_PToken.SetBelong(this.GetValue());
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
					r_MEquals_Object.SetBelong(this.GetValue());
				}
				return r_MEquals_Object;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Reflection.Emit.FieldToken)
		/// </summary>
		protected RMethod r_MEquals_FieldToken;
		public virtual RMethod RMEquals_FieldToken
		{
			get
			{
				if(r_MEquals_FieldToken == null)
				{
					r_MEquals_FieldToken = new(this, "Equals", 0, typeof(System.Reflection.Emit.FieldToken));
					r_MEquals_FieldToken.SetBelong(this.GetValue());
				}
				return r_MEquals_FieldToken;
			}
		}

		/// <summary>
		/// Boolean op_Equality(System.Reflection.Emit.FieldToken, System.Reflection.Emit.FieldToken)
		/// </summary>
		protected static RMethod r_Mop_Equality_FieldToken_FieldToken;
		public static RMethod RMop_Equality_FieldToken_FieldToken
		{
			get
			{
				if(r_Mop_Equality_FieldToken_FieldToken == null)
				{
					r_Mop_Equality_FieldToken_FieldToken = new(typeof(System.Reflection.Emit.FieldToken), "op_Equality", 0, typeof(System.Reflection.Emit.FieldToken), typeof(System.Reflection.Emit.FieldToken));
					r_Mop_Equality_FieldToken_FieldToken.SetBelong(null);
				}
				return r_Mop_Equality_FieldToken_FieldToken;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Reflection.Emit.FieldToken, System.Reflection.Emit.FieldToken)
		/// </summary>
		protected static RMethod r_Mop_Inequality_FieldToken_FieldToken;
		public static RMethod RMop_Inequality_FieldToken_FieldToken
		{
			get
			{
				if(r_Mop_Inequality_FieldToken_FieldToken == null)
				{
					r_Mop_Inequality_FieldToken_FieldToken = new(typeof(System.Reflection.Emit.FieldToken), "op_Inequality", 0, typeof(System.Reflection.Emit.FieldToken), typeof(System.Reflection.Emit.FieldToken));
					r_Mop_Inequality_FieldToken_FieldToken.SetBelong(null);
				}
				return r_Mop_Inequality_FieldToken_FieldToken;
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
					r_MGetHashCode.SetBelong(this.GetValue());
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
					r_MToString.SetBelong(this.GetValue());
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
					r_MFinalize.SetBelong(this.GetValue());
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
					r_MGetType.SetBelong(this.GetValue());
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
					r_MMemberwiseClone.SetBelong(this.GetValue());
				}
				return r_MMemberwiseClone;
			}
		}


        public RFieldToken() : base("System.Reflection.Emit.FieldToken")
        {
        }

        public RFieldToken(System.Object instance) : base("System.Reflection.Emit.FieldToken")
		{
            SetInstance(instance);
		}

        public RFieldToken(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RFieldToken(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Reflection.Emit.FieldToken @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_FieldToken.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(System.Reflection.Emit.FieldToken @a, System.Reflection.Emit.FieldToken @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMop_Equality_FieldToken_FieldToken.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.Reflection.Emit.FieldToken @a, System.Reflection.Emit.FieldToken @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMop_Inequality_FieldToken_FieldToken.Invoke(___genericsType, ___parameters);

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
