
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem
{public partial class RDecimal
{
	public partial class RDecCalc
{
	
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Decimal+DecCalc+Buf24
	/// </summary>
    public partial class RBuf24 : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("System.Decimal+DecCalc+Buf24");
            }
        }

        public RBuf24() : base("System.Decimal+DecCalc+Buf24")
        {
        }

        public RBuf24(System.Object instance) : base("System.Decimal+DecCalc+Buf24")
		{
            SetInstance(instance);
		}

        public RBuf24(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RBuf24(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.UInt32 U0
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_FU0;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFU0
		{
			get
			{
				if(r_FU0 == null)
				{
					r_FU0 = new(this, "U0");
				}
				return r_FU0;
			}
		}

		/// <summary>
		/// System.UInt32 U1
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_FU1;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFU1
		{
			get
			{
				if(r_FU1 == null)
				{
					r_FU1 = new(this, "U1");
				}
				return r_FU1;
			}
		}

		/// <summary>
		/// System.UInt32 U2
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_FU2;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFU2
		{
			get
			{
				if(r_FU2 == null)
				{
					r_FU2 = new(this, "U2");
				}
				return r_FU2;
			}
		}

		/// <summary>
		/// System.UInt32 U3
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_FU3;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFU3
		{
			get
			{
				if(r_FU3 == null)
				{
					r_FU3 = new(this, "U3");
				}
				return r_FU3;
			}
		}

		/// <summary>
		/// System.UInt32 U4
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_FU4;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFU4
		{
			get
			{
				if(r_FU4 == null)
				{
					r_FU4 = new(this, "U4");
				}
				return r_FU4;
			}
		}

		/// <summary>
		/// System.UInt32 U5
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_FU5;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFU5
		{
			get
			{
				if(r_FU5 == null)
				{
					r_FU5 = new(this, "U5");
				}
				return r_FU5;
			}
		}

		/// <summary>
		/// System.UInt64 ulo64LE
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt64 r_Fulo64LE;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt64 RFulo64LE
		{
			get
			{
				if(r_Fulo64LE == null)
				{
					r_Fulo64LE = new(this, "ulo64LE");
				}
				return r_Fulo64LE;
			}
		}

		/// <summary>
		/// System.UInt64 umid64LE
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt64 r_Fumid64LE;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt64 RFumid64LE
		{
			get
			{
				if(r_Fumid64LE == null)
				{
					r_Fumid64LE = new(this, "umid64LE");
				}
				return r_Fumid64LE;
			}
		}

		/// <summary>
		/// System.UInt64 uhigh64LE
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt64 r_Fuhigh64LE;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt64 RFuhigh64LE
		{
			get
			{
				if(r_Fuhigh64LE == null)
				{
					r_Fuhigh64LE = new(this, "uhigh64LE");
				}
				return r_Fuhigh64LE;
			}
		}

		/// <summary>
		/// UInt64 Low64
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt64 r_PLow64;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt64 RPLow64
		{
			get
			{
				if(r_PLow64 == null)
				{
					r_PLow64 = new(this, "Low64", -1);
				}
				return r_PLow64;
			}
		}

		/// <summary>
		/// UInt64 Mid64
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt64 r_PMid64;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt64 RPMid64
		{
			get
			{
				if(r_PMid64 == null)
				{
					r_PMid64 = new(this, "Mid64", -1);
				}
				return r_PMid64;
			}
		}

		/// <summary>
		/// UInt64 High64
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt64 r_PHigh64;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt64 RPHigh64
		{
			get
			{
				if(r_PHigh64 == null)
				{
					r_PHigh64 = new(this, "High64", -1);
				}
				return r_PHigh64;
			}
		}

		/// <summary>
		/// Int32 Length
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PLength;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPLength
		{
			get
			{
				if(r_PLength == null)
				{
					r_PLength = new(this, "Length", -1);
				}
				return r_PLength;
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
}}