
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RMono.RSecurity
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
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RByte> r_Fhash;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RByte> RFhash
		{
			get
			{
				if(r_Fhash == null)
				{
					r_Fhash = new(this, "hash");
					r_Fhash.SetBelong(this.GetValue());
				}
				return r_Fhash;
			}
		}

		/// <summary>
		/// System.Byte[] signature
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RByte> r_Fsignature;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RByte> RFsignature
		{
			get
			{
				if(r_Fsignature == null)
				{
					r_Fsignature = new(this, "signature");
					r_Fsignature.SetBelong(this.GetValue());
				}
				return r_Fsignature;
			}
		}

		/// <summary>
		/// System.UInt32 signaturePosition
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_FsignaturePosition;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFsignaturePosition
		{
			get
			{
				if(r_FsignaturePosition == null)
				{
					r_FsignaturePosition = new(this, "signaturePosition");
					r_FsignaturePosition.SetBelong(this.GetValue());
				}
				return r_FsignaturePosition;
			}
		}

		/// <summary>
		/// System.UInt32 signatureLength
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_FsignatureLength;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFsignatureLength
		{
			get
			{
				if(r_FsignatureLength == null)
				{
					r_FsignatureLength = new(this, "signatureLength");
					r_FsignatureLength.SetBelong(this.GetValue());
				}
				return r_FsignatureLength;
			}
		}

		/// <summary>
		/// System.UInt32 metadataPosition
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_FmetadataPosition;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFmetadataPosition
		{
			get
			{
				if(r_FmetadataPosition == null)
				{
					r_FmetadataPosition = new(this, "metadataPosition");
					r_FmetadataPosition.SetBelong(this.GetValue());
				}
				return r_FmetadataPosition;
			}
		}

		/// <summary>
		/// System.UInt32 metadataLength
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_FmetadataLength;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFmetadataLength
		{
			get
			{
				if(r_FmetadataLength == null)
				{
					r_FmetadataLength = new(this, "metadataLength");
					r_FmetadataLength.SetBelong(this.GetValue());
				}
				return r_FmetadataLength;
			}
		}

		/// <summary>
		/// System.Byte cliFlag
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RByte r_FcliFlag;
		public virtual Hvak.Editor.Refleaction.RSystem.RByte RFcliFlag
		{
			get
			{
				if(r_FcliFlag == null)
				{
					r_FcliFlag = new(this, "cliFlag");
					r_FcliFlag.SetBelong(this.GetValue());
				}
				return r_FcliFlag;
			}
		}

		/// <summary>
		/// System.UInt32 cliFlagPosition
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_FcliFlagPosition;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFcliFlagPosition
		{
			get
			{
				if(r_FcliFlagPosition == null)
				{
					r_FcliFlagPosition = new(this, "cliFlagPosition");
					r_FcliFlagPosition.SetBelong(this.GetValue());
				}
				return r_FcliFlagPosition;
			}
		}

		/// <summary>
		/// Byte[] Hash
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RByte> r_PHash;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RByte> RPHash
		{
			get
			{
				if(r_PHash == null)
				{
					r_PHash = new(this, "Hash", -1);
					r_PHash.SetBelong(this.GetValue());
				}
				return r_PHash;
			}
		}

		/// <summary>
		/// Byte[] Signature
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RByte> r_PSignature;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RByte> RPSignature
		{
			get
			{
				if(r_PSignature == null)
				{
					r_PSignature = new(this, "Signature", -1);
					r_PSignature.SetBelong(this.GetValue());
				}
				return r_PSignature;
			}
		}

		/// <summary>
		/// UInt32 MetadataPosition
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_PMetadataPosition;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RPMetadataPosition
		{
			get
			{
				if(r_PMetadataPosition == null)
				{
					r_PMetadataPosition = new(this, "MetadataPosition", -1);
					r_PMetadataPosition.SetBelong(this.GetValue());
				}
				return r_PMetadataPosition;
			}
		}

		/// <summary>
		/// UInt32 MetadataLength
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_PMetadataLength;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RPMetadataLength
		{
			get
			{
				if(r_PMetadataLength == null)
				{
					r_PMetadataLength = new(this, "MetadataLength", -1);
					r_PMetadataLength.SetBelong(this.GetValue());
				}
				return r_PMetadataLength;
			}
		}

		/// <summary>
		/// UInt32 SignaturePosition
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_PSignaturePosition;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RPSignaturePosition
		{
			get
			{
				if(r_PSignaturePosition == null)
				{
					r_PSignaturePosition = new(this, "SignaturePosition", -1);
					r_PSignaturePosition.SetBelong(this.GetValue());
				}
				return r_PSignaturePosition;
			}
		}

		/// <summary>
		/// UInt32 SignatureLength
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_PSignatureLength;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RPSignatureLength
		{
			get
			{
				if(r_PSignatureLength == null)
				{
					r_PSignatureLength = new(this, "SignatureLength", -1);
					r_PSignatureLength.SetBelong(this.GetValue());
				}
				return r_PSignatureLength;
			}
		}

		/// <summary>
		/// Byte CliFlag
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RByte r_PCliFlag;
		public virtual Hvak.Editor.Refleaction.RSystem.RByte RPCliFlag
		{
			get
			{
				if(r_PCliFlag == null)
				{
					r_PCliFlag = new(this, "CliFlag", -1);
					r_PCliFlag.SetBelong(this.GetValue());
				}
				return r_PCliFlag;
			}
		}

		/// <summary>
		/// UInt32 CliFlagPosition
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_PCliFlagPosition;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RPCliFlagPosition
		{
			get
			{
				if(r_PCliFlagPosition == null)
				{
					r_PCliFlagPosition = new(this, "CliFlagPosition", -1);
					r_PCliFlagPosition.SetBelong(this.GetValue());
				}
				return r_PCliFlagPosition;
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

        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
}