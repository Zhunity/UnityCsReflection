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
		protected RFieldArray<RSystem.RByte> r_FExponent;
		public virtual RFieldArray<RSystem.RByte> RFExponent
		{
			get
			{
				if(r_FExponent == null)
				{
					r_FExponent = new(this, "Exponent");
					r_FExponent.SetBelong(this.instance);
				}
				return r_FExponent;
			}
		}

		/// <summary>
		/// System.Byte[] Modulus
		/// </summary>
		protected RFieldArray<RSystem.RByte> r_FModulus;
		public virtual RFieldArray<RSystem.RByte> RFModulus
		{
			get
			{
				if(r_FModulus == null)
				{
					r_FModulus = new(this, "Modulus");
					r_FModulus.SetBelong(this.instance);
				}
				return r_FModulus;
			}
		}

		/// <summary>
		/// System.Byte[] P
		/// </summary>
		protected RFieldArray<RSystem.RByte> r_FP;
		public virtual RFieldArray<RSystem.RByte> RFP
		{
			get
			{
				if(r_FP == null)
				{
					r_FP = new(this, "P");
					r_FP.SetBelong(this.instance);
				}
				return r_FP;
			}
		}

		/// <summary>
		/// System.Byte[] Q
		/// </summary>
		protected RFieldArray<RSystem.RByte> r_FQ;
		public virtual RFieldArray<RSystem.RByte> RFQ
		{
			get
			{
				if(r_FQ == null)
				{
					r_FQ = new(this, "Q");
					r_FQ.SetBelong(this.instance);
				}
				return r_FQ;
			}
		}

		/// <summary>
		/// System.Byte[] DP
		/// </summary>
		protected RFieldArray<RSystem.RByte> r_FDP;
		public virtual RFieldArray<RSystem.RByte> RFDP
		{
			get
			{
				if(r_FDP == null)
				{
					r_FDP = new(this, "DP");
					r_FDP.SetBelong(this.instance);
				}
				return r_FDP;
			}
		}

		/// <summary>
		/// System.Byte[] DQ
		/// </summary>
		protected RFieldArray<RSystem.RByte> r_FDQ;
		public virtual RFieldArray<RSystem.RByte> RFDQ
		{
			get
			{
				if(r_FDQ == null)
				{
					r_FDQ = new(this, "DQ");
					r_FDQ.SetBelong(this.instance);
				}
				return r_FDQ;
			}
		}

		/// <summary>
		/// System.Byte[] InverseQ
		/// </summary>
		protected RFieldArray<RSystem.RByte> r_FInverseQ;
		public virtual RFieldArray<RSystem.RByte> RFInverseQ
		{
			get
			{
				if(r_FInverseQ == null)
				{
					r_FInverseQ = new(this, "InverseQ");
					r_FInverseQ.SetBelong(this.instance);
				}
				return r_FInverseQ;
			}
		}

		/// <summary>
		/// System.Byte[] D
		/// </summary>
		protected RFieldArray<RSystem.RByte> r_FD;
		public virtual RFieldArray<RSystem.RByte> RFD
		{
			get
			{
				if(r_FD == null)
				{
					r_FD = new(this, "D");
					r_FD.SetBelong(this.instance);
				}
				return r_FD;
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

        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

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
