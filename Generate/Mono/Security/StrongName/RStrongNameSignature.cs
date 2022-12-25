using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RMono.RSecurity
{public partial class RStrongName
{
	
	/// <summary>
	/// Mono.Security.StrongName+StrongNameSignature
	/// </summary>
    public partial class RStrongNameSignature : RMember //
    {

		/// <summary>
		/// System.Byte[] hash
		/// </summary>
		protected RFieldArray<RField> r_hash;
		public virtual RFieldArray<RField> Rhash
		{
			get
			{
				if(r_hash == null)
				{
					r_hash = new(this, "hash");
					r_hash.SetBelong(this.instance);
				}
				return r_hash;
			}
		}

		/// <summary>
		/// System.Byte[] signature
		/// </summary>
		protected RFieldArray<RField> r_signature;
		public virtual RFieldArray<RField> Rsignature
		{
			get
			{
				if(r_signature == null)
				{
					r_signature = new(this, "signature");
					r_signature.SetBelong(this.instance);
				}
				return r_signature;
			}
		}

		/// <summary>
		/// System.UInt32 signaturePosition
		/// </summary>
		protected RField r_signaturePosition;
		public virtual RField RsignaturePosition
		{
			get
			{
				if(r_signaturePosition == null)
				{
					r_signaturePosition = new(this, "signaturePosition");
					r_signaturePosition.SetBelong(this.instance);
				}
				return r_signaturePosition;
			}
		}

		/// <summary>
		/// System.UInt32 signatureLength
		/// </summary>
		protected RField r_signatureLength;
		public virtual RField RsignatureLength
		{
			get
			{
				if(r_signatureLength == null)
				{
					r_signatureLength = new(this, "signatureLength");
					r_signatureLength.SetBelong(this.instance);
				}
				return r_signatureLength;
			}
		}

		/// <summary>
		/// System.UInt32 metadataPosition
		/// </summary>
		protected RField r_metadataPosition;
		public virtual RField RmetadataPosition
		{
			get
			{
				if(r_metadataPosition == null)
				{
					r_metadataPosition = new(this, "metadataPosition");
					r_metadataPosition.SetBelong(this.instance);
				}
				return r_metadataPosition;
			}
		}

		/// <summary>
		/// System.UInt32 metadataLength
		/// </summary>
		protected RField r_metadataLength;
		public virtual RField RmetadataLength
		{
			get
			{
				if(r_metadataLength == null)
				{
					r_metadataLength = new(this, "metadataLength");
					r_metadataLength.SetBelong(this.instance);
				}
				return r_metadataLength;
			}
		}

		/// <summary>
		/// System.Byte cliFlag
		/// </summary>
		protected RField r_cliFlag;
		public virtual RField RcliFlag
		{
			get
			{
				if(r_cliFlag == null)
				{
					r_cliFlag = new(this, "cliFlag");
					r_cliFlag.SetBelong(this.instance);
				}
				return r_cliFlag;
			}
		}

		/// <summary>
		/// System.UInt32 cliFlagPosition
		/// </summary>
		protected RField r_cliFlagPosition;
		public virtual RField RcliFlagPosition
		{
			get
			{
				if(r_cliFlagPosition == null)
				{
					r_cliFlagPosition = new(this, "cliFlagPosition");
					r_cliFlagPosition.SetBelong(this.instance);
				}
				return r_cliFlagPosition;
			}
		}

		/// <summary>
		/// Byte[] Hash
		/// </summary>
		protected RPropertyArray<RProperty> r_Hash;
		public virtual RPropertyArray<RProperty> RHash
		{
			get
			{
				if(r_Hash == null)
				{
					r_Hash = new(this, "Hash", -1);
					r_Hash.SetBelong(this.instance);
				}
				return r_Hash;
			}
		}

		/// <summary>
		/// Byte[] Signature
		/// </summary>
		protected RPropertyArray<RProperty> r_Signature;
		public virtual RPropertyArray<RProperty> RSignature
		{
			get
			{
				if(r_Signature == null)
				{
					r_Signature = new(this, "Signature", -1);
					r_Signature.SetBelong(this.instance);
				}
				return r_Signature;
			}
		}

		/// <summary>
		/// UInt32 MetadataPosition
		/// </summary>
		protected RProperty r_MetadataPosition;
		public virtual RProperty RMetadataPosition
		{
			get
			{
				if(r_MetadataPosition == null)
				{
					r_MetadataPosition = new(this, "MetadataPosition", -1);
					r_MetadataPosition.SetBelong(this.instance);
				}
				return r_MetadataPosition;
			}
		}

		/// <summary>
		/// UInt32 MetadataLength
		/// </summary>
		protected RProperty r_MetadataLength;
		public virtual RProperty RMetadataLength
		{
			get
			{
				if(r_MetadataLength == null)
				{
					r_MetadataLength = new(this, "MetadataLength", -1);
					r_MetadataLength.SetBelong(this.instance);
				}
				return r_MetadataLength;
			}
		}

		/// <summary>
		/// UInt32 SignaturePosition
		/// </summary>
		protected RProperty r_SignaturePosition;
		public virtual RProperty RSignaturePosition
		{
			get
			{
				if(r_SignaturePosition == null)
				{
					r_SignaturePosition = new(this, "SignaturePosition", -1);
					r_SignaturePosition.SetBelong(this.instance);
				}
				return r_SignaturePosition;
			}
		}

		/// <summary>
		/// UInt32 SignatureLength
		/// </summary>
		protected RProperty r_SignatureLength;
		public virtual RProperty RSignatureLength
		{
			get
			{
				if(r_SignatureLength == null)
				{
					r_SignatureLength = new(this, "SignatureLength", -1);
					r_SignatureLength.SetBelong(this.instance);
				}
				return r_SignatureLength;
			}
		}

		/// <summary>
		/// Byte CliFlag
		/// </summary>
		protected RProperty r_CliFlag;
		public virtual RProperty RCliFlag
		{
			get
			{
				if(r_CliFlag == null)
				{
					r_CliFlag = new(this, "CliFlag", -1);
					r_CliFlag.SetBelong(this.instance);
				}
				return r_CliFlag;
			}
		}

		/// <summary>
		/// UInt32 CliFlagPosition
		/// </summary>
		protected RProperty r_CliFlagPosition;
		public virtual RProperty RCliFlagPosition
		{
			get
			{
				if(r_CliFlagPosition == null)
				{
					r_CliFlagPosition = new(this, "CliFlagPosition", -1);
					r_CliFlagPosition.SetBelong(this.instance);
				}
				return r_CliFlagPosition;
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


        public RStrongNameSignature() : base("Mono.Security.StrongName+StrongNameSignature")
        {
        }

        public RStrongNameSignature(System.Object instance) : base("Mono.Security.StrongName+StrongNameSignature")
		{
            SetInstance(instance);
		}

        public RStrongNameSignature(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RStrongNameSignature(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
}