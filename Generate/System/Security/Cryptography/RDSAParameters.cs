using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RSecurity.RCryptography
{
	/// <summary>
	/// System.Security.Cryptography.DSAParameters
	/// </summary>
    public partial class RDSAParameters : RMember //
    {

		/// <summary>
		/// System.Byte[] P
		/// </summary>
		protected RFieldArray<RField> r_P;
		public virtual RFieldArray<RField> RP
		{
			get
			{
				if(r_P == null)
				{
					r_P = new(this, "P");
					r_P.SetBelong(this.instance);
				}
				return r_P;
			}
		}

		/// <summary>
		/// System.Byte[] Q
		/// </summary>
		protected RFieldArray<RField> r_Q;
		public virtual RFieldArray<RField> RQ
		{
			get
			{
				if(r_Q == null)
				{
					r_Q = new(this, "Q");
					r_Q.SetBelong(this.instance);
				}
				return r_Q;
			}
		}

		/// <summary>
		/// System.Byte[] G
		/// </summary>
		protected RFieldArray<RField> r_G;
		public virtual RFieldArray<RField> RG
		{
			get
			{
				if(r_G == null)
				{
					r_G = new(this, "G");
					r_G.SetBelong(this.instance);
				}
				return r_G;
			}
		}

		/// <summary>
		/// System.Byte[] Y
		/// </summary>
		protected RFieldArray<RField> r_Y;
		public virtual RFieldArray<RField> RY
		{
			get
			{
				if(r_Y == null)
				{
					r_Y = new(this, "Y");
					r_Y.SetBelong(this.instance);
				}
				return r_Y;
			}
		}

		/// <summary>
		/// System.Byte[] J
		/// </summary>
		protected RFieldArray<RField> r_J;
		public virtual RFieldArray<RField> RJ
		{
			get
			{
				if(r_J == null)
				{
					r_J = new(this, "J");
					r_J.SetBelong(this.instance);
				}
				return r_J;
			}
		}

		/// <summary>
		/// System.Byte[] X
		/// </summary>
		protected RFieldArray<RField> r_X;
		public virtual RFieldArray<RField> RX
		{
			get
			{
				if(r_X == null)
				{
					r_X = new(this, "X");
					r_X.SetBelong(this.instance);
				}
				return r_X;
			}
		}

		/// <summary>
		/// System.Byte[] Seed
		/// </summary>
		protected RFieldArray<RField> r_Seed;
		public virtual RFieldArray<RField> RSeed
		{
			get
			{
				if(r_Seed == null)
				{
					r_Seed = new(this, "Seed");
					r_Seed.SetBelong(this.instance);
				}
				return r_Seed;
			}
		}

		/// <summary>
		/// System.Int32 Counter
		/// </summary>
		protected RField r_Counter;
		public virtual RField RCounter
		{
			get
			{
				if(r_Counter == null)
				{
					r_Counter = new(this, "Counter");
					r_Counter.SetBelong(this.instance);
				}
				return r_Counter;
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


        public RDSAParameters() : base("System.Security.Cryptography.DSAParameters")
        {
        }

        public RDSAParameters(System.Object instance) : base("System.Security.Cryptography.DSAParameters")
		{
            SetInstance(instance);
		}

        public RDSAParameters(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RDSAParameters(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
