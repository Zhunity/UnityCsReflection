using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RSecurity.RCryptography
{
	/// <summary>
	/// System.Security.Cryptography.RSAParameters
	/// </summary>
    public partial class RRSAParameters : RMember //
    {

		/// <summary>
		/// System.Byte[] Exponent
		/// </summary>
		protected RFieldArray<RField> r_Exponent;
		public virtual RFieldArray<RField> RExponent
		{
			get
			{
				if(r_Exponent == null)
				{
					r_Exponent = new(this, "Exponent");
					r_Exponent.SetBelong(this.instance);
				}
				return r_Exponent;
			}
		}

		/// <summary>
		/// System.Byte[] Modulus
		/// </summary>
		protected RFieldArray<RField> r_Modulus;
		public virtual RFieldArray<RField> RModulus
		{
			get
			{
				if(r_Modulus == null)
				{
					r_Modulus = new(this, "Modulus");
					r_Modulus.SetBelong(this.instance);
				}
				return r_Modulus;
			}
		}

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
		/// System.Byte[] DP
		/// </summary>
		protected RFieldArray<RField> r_DP;
		public virtual RFieldArray<RField> RDP
		{
			get
			{
				if(r_DP == null)
				{
					r_DP = new(this, "DP");
					r_DP.SetBelong(this.instance);
				}
				return r_DP;
			}
		}

		/// <summary>
		/// System.Byte[] DQ
		/// </summary>
		protected RFieldArray<RField> r_DQ;
		public virtual RFieldArray<RField> RDQ
		{
			get
			{
				if(r_DQ == null)
				{
					r_DQ = new(this, "DQ");
					r_DQ.SetBelong(this.instance);
				}
				return r_DQ;
			}
		}

		/// <summary>
		/// System.Byte[] InverseQ
		/// </summary>
		protected RFieldArray<RField> r_InverseQ;
		public virtual RFieldArray<RField> RInverseQ
		{
			get
			{
				if(r_InverseQ == null)
				{
					r_InverseQ = new(this, "InverseQ");
					r_InverseQ.SetBelong(this.instance);
				}
				return r_InverseQ;
			}
		}

		/// <summary>
		/// System.Byte[] D
		/// </summary>
		protected RFieldArray<RField> r_D;
		public virtual RFieldArray<RField> RD
		{
			get
			{
				if(r_D == null)
				{
					r_D = new(this, "D");
					r_D.SetBelong(this.instance);
				}
				return r_D;
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


        public RRSAParameters() : base("System.Security.Cryptography.RSAParameters")
        {
        }

        public RRSAParameters(System.Object instance) : base("System.Security.Cryptography.RSAParameters")
		{
            SetInstance(instance);
		}

        public RRSAParameters(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRSAParameters(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
