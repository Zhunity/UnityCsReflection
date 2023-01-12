using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RReflection.REmit
{
	/// <summary>
	/// System.Reflection.Emit.EventToken
	/// </summary>
    public partial class REventToken : RMember //
    {

		/// <summary>
		/// System.Int32 tokValue
		/// </summary>
		protected RSystem.RInt32 r_FtokValue;
		public virtual RSystem.RInt32 RFtokValue
		{
			get
			{
				if(r_FtokValue == null)
				{
					r_FtokValue = new(this, "tokValue");
					r_FtokValue.SetBelong(this.instance);
				}
				return r_FtokValue;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.EventToken Empty
		/// </summary>
		protected static RSystem.RReflection.REmit.REventToken r_FEmpty;
		public static RSystem.RReflection.REmit.REventToken RFEmpty
		{
			get
			{
				if(r_FEmpty == null)
				{
					r_FEmpty = new(typeof(System.Reflection.Emit.EventToken), "Empty");
					r_FEmpty.SetBelong(null);
				}
				return r_FEmpty;
			}
		}

		/// <summary>
		/// Int32 Token
		/// </summary>
		protected RSystem.RInt32 r_PToken;
		public virtual RSystem.RInt32 RPToken
		{
			get
			{
				if(r_PToken == null)
				{
					r_PToken = new(this, "Token", -1);
					r_PToken.SetBelong(this.instance);
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
					r_MEquals_Object.SetBelong(this.instance);
				}
				return r_MEquals_Object;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Reflection.Emit.EventToken)
		/// </summary>
		protected RMethod r_MEquals_EventToken;
		public virtual RMethod RMEquals_EventToken
		{
			get
			{
				if(r_MEquals_EventToken == null)
				{
					r_MEquals_EventToken = new(this, "Equals", 0, typeof(System.Reflection.Emit.EventToken));
					r_MEquals_EventToken.SetBelong(this.instance);
				}
				return r_MEquals_EventToken;
			}
		}

		/// <summary>
		/// Boolean op_Equality(System.Reflection.Emit.EventToken, System.Reflection.Emit.EventToken)
		/// </summary>
		protected static RMethod r_Mop_Equality_EventToken_EventToken;
		public static RMethod RMop_Equality_EventToken_EventToken
		{
			get
			{
				if(r_Mop_Equality_EventToken_EventToken == null)
				{
					r_Mop_Equality_EventToken_EventToken = new(typeof(System.Reflection.Emit.EventToken), "op_Equality", 0, typeof(System.Reflection.Emit.EventToken), typeof(System.Reflection.Emit.EventToken));
					r_Mop_Equality_EventToken_EventToken.SetBelong(null);
				}
				return r_Mop_Equality_EventToken_EventToken;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Reflection.Emit.EventToken, System.Reflection.Emit.EventToken)
		/// </summary>
		protected static RMethod r_Mop_Inequality_EventToken_EventToken;
		public static RMethod RMop_Inequality_EventToken_EventToken
		{
			get
			{
				if(r_Mop_Inequality_EventToken_EventToken == null)
				{
					r_Mop_Inequality_EventToken_EventToken = new(typeof(System.Reflection.Emit.EventToken), "op_Inequality", 0, typeof(System.Reflection.Emit.EventToken), typeof(System.Reflection.Emit.EventToken));
					r_Mop_Inequality_EventToken_EventToken.SetBelong(null);
				}
				return r_Mop_Inequality_EventToken_EventToken;
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
					r_MGetHashCode.SetBelong(this.instance);
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
					r_MToString.SetBelong(this.instance);
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
					r_MFinalize.SetBelong(this.instance);
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
					r_MGetType.SetBelong(this.instance);
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
					r_MMemberwiseClone.SetBelong(this.instance);
				}
				return r_MMemberwiseClone;
			}
		}


        public REventToken() : base("System.Reflection.Emit.EventToken")
        {
        }

        public REventToken(System.Object instance) : base("System.Reflection.Emit.EventToken")
		{
            SetInstance(instance);
		}

        public REventToken(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public REventToken(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Reflection.Emit.EventToken @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_EventToken.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(System.Reflection.Emit.EventToken @a, System.Reflection.Emit.EventToken @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMop_Equality_EventToken_EventToken.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.Reflection.Emit.EventToken @a, System.Reflection.Emit.EventToken @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMop_Inequality_EventToken_EventToken.Invoke(___genericsType, ___parameters);

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
