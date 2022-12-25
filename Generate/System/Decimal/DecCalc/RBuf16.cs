using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem
{public partial class RDecimal
{
	public partial class RDecCalc
{
	
	/// <summary>
	/// System.Decimal+DecCalc+Buf16
	/// </summary>
    public partial class RBuf16 : RMember //
    {

		/// <summary>
		/// System.UInt32 U0
		/// </summary>
		protected RField r_U0;
		public virtual RField RU0
		{
			get
			{
				if(r_U0 == null)
				{
					r_U0 = new(this, "U0");
					r_U0.SetBelong(this.instance);
				}
				return r_U0;
			}
		}

		/// <summary>
		/// System.UInt32 U1
		/// </summary>
		protected RField r_U1;
		public virtual RField RU1
		{
			get
			{
				if(r_U1 == null)
				{
					r_U1 = new(this, "U1");
					r_U1.SetBelong(this.instance);
				}
				return r_U1;
			}
		}

		/// <summary>
		/// System.UInt32 U2
		/// </summary>
		protected RField r_U2;
		public virtual RField RU2
		{
			get
			{
				if(r_U2 == null)
				{
					r_U2 = new(this, "U2");
					r_U2.SetBelong(this.instance);
				}
				return r_U2;
			}
		}

		/// <summary>
		/// System.UInt32 U3
		/// </summary>
		protected RField r_U3;
		public virtual RField RU3
		{
			get
			{
				if(r_U3 == null)
				{
					r_U3 = new(this, "U3");
					r_U3.SetBelong(this.instance);
				}
				return r_U3;
			}
		}

		/// <summary>
		/// System.UInt64 ulo64LE
		/// </summary>
		protected RField r_ulo64LE;
		public virtual RField Rulo64LE
		{
			get
			{
				if(r_ulo64LE == null)
				{
					r_ulo64LE = new(this, "ulo64LE");
					r_ulo64LE.SetBelong(this.instance);
				}
				return r_ulo64LE;
			}
		}

		/// <summary>
		/// System.UInt64 uhigh64LE
		/// </summary>
		protected RField r_uhigh64LE;
		public virtual RField Ruhigh64LE
		{
			get
			{
				if(r_uhigh64LE == null)
				{
					r_uhigh64LE = new(this, "uhigh64LE");
					r_uhigh64LE.SetBelong(this.instance);
				}
				return r_uhigh64LE;
			}
		}

		/// <summary>
		/// UInt64 Low64
		/// </summary>
		protected RProperty r_Low64;
		public virtual RProperty RLow64
		{
			get
			{
				if(r_Low64 == null)
				{
					r_Low64 = new(this, "Low64", -1);
					r_Low64.SetBelong(this.instance);
				}
				return r_Low64;
			}
		}

		/// <summary>
		/// UInt64 High64
		/// </summary>
		protected RProperty r_High64;
		public virtual RProperty RHigh64
		{
			get
			{
				if(r_High64 == null)
				{
					r_High64 = new(this, "High64", -1);
					r_High64.SetBelong(this.instance);
				}
				return r_High64;
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


        public RBuf16() : base("System.Decimal+DecCalc+Buf16")
        {
        }

        public RBuf16(System.Object instance) : base("System.Decimal+DecCalc+Buf16")
		{
            SetInstance(instance);
		}

        public RBuf16(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RBuf16(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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
}}