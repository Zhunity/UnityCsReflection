
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices
{
	/// <summary>
	/// System.Runtime.InteropServices.MarshalAsAttribute
	/// </summary>
    public partial class RMarshalAsAttribute : RMember //
    {

		/// <summary>
		/// System.String MarshalCookie
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_FMarshalCookie;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RFMarshalCookie
		{
			get
			{
				if(r_FMarshalCookie == null)
				{
					r_FMarshalCookie = new(this, "MarshalCookie");
					r_FMarshalCookie.SetBelong(this.instance);
				}
				return r_FMarshalCookie;
			}
		}

		/// <summary>
		/// System.String MarshalType
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_FMarshalType;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RFMarshalType
		{
			get
			{
				if(r_FMarshalType == null)
				{
					r_FMarshalType = new(this, "MarshalType");
					r_FMarshalType.SetBelong(this.instance);
				}
				return r_FMarshalType;
			}
		}

		/// <summary>
		/// System.Type MarshalTypeRef
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RType r_FMarshalTypeRef;
		public virtual SMFrame.Editor.Refleaction.RSystem.RType RFMarshalTypeRef
		{
			get
			{
				if(r_FMarshalTypeRef == null)
				{
					r_FMarshalTypeRef = new(this, "MarshalTypeRef");
					r_FMarshalTypeRef.SetBelong(this.instance);
				}
				return r_FMarshalTypeRef;
			}
		}

		/// <summary>
		/// System.Type SafeArrayUserDefinedSubType
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RType r_FSafeArrayUserDefinedSubType;
		public virtual SMFrame.Editor.Refleaction.RSystem.RType RFSafeArrayUserDefinedSubType
		{
			get
			{
				if(r_FSafeArrayUserDefinedSubType == null)
				{
					r_FSafeArrayUserDefinedSubType = new(this, "SafeArrayUserDefinedSubType");
					r_FSafeArrayUserDefinedSubType.SetBelong(this.instance);
				}
				return r_FSafeArrayUserDefinedSubType;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType utype
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_Futype;
		public virtual SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFutype
		{
			get
			{
				if(r_Futype == null)
				{
					r_Futype = new(this, "utype");
					r_Futype.SetBelong(this.instance);
				}
				return r_Futype;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType ArraySubType
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FArraySubType;
		public virtual SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFArraySubType
		{
			get
			{
				if(r_FArraySubType == null)
				{
					r_FArraySubType = new(this, "ArraySubType");
					r_FArraySubType.SetBelong(this.instance);
				}
				return r_FArraySubType;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.VarEnum SafeArraySubType
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum r_FSafeArraySubType;
		public virtual SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum RFSafeArraySubType
		{
			get
			{
				if(r_FSafeArraySubType == null)
				{
					r_FSafeArraySubType = new(this, "SafeArraySubType");
					r_FSafeArraySubType.SetBelong(this.instance);
				}
				return r_FSafeArraySubType;
			}
		}

		/// <summary>
		/// System.Int32 SizeConst
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_FSizeConst;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFSizeConst
		{
			get
			{
				if(r_FSizeConst == null)
				{
					r_FSizeConst = new(this, "SizeConst");
					r_FSizeConst.SetBelong(this.instance);
				}
				return r_FSizeConst;
			}
		}

		/// <summary>
		/// System.Int32 IidParameterIndex
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_FIidParameterIndex;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFIidParameterIndex
		{
			get
			{
				if(r_FIidParameterIndex == null)
				{
					r_FIidParameterIndex = new(this, "IidParameterIndex");
					r_FIidParameterIndex.SetBelong(this.instance);
				}
				return r_FIidParameterIndex;
			}
		}

		/// <summary>
		/// System.Int16 SizeParamIndex
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt16 r_FSizeParamIndex;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt16 RFSizeParamIndex
		{
			get
			{
				if(r_FSizeParamIndex == null)
				{
					r_FSizeParamIndex = new(this, "SizeParamIndex");
					r_FSizeParamIndex.SetBelong(this.instance);
				}
				return r_FSizeParamIndex;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType Value
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_PValue;
		public virtual SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RPValue
		{
			get
			{
				if(r_PValue == null)
				{
					r_PValue = new(this, "Value", -1);
					r_PValue.SetBelong(this.instance);
				}
				return r_PValue;
			}
		}

		/// <summary>
		/// System.Object TypeId
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RObject r_PTypeId;
		public virtual SMFrame.Editor.Refleaction.RSystem.RObject RPTypeId
		{
			get
			{
				if(r_PTypeId == null)
				{
					r_PTypeId = new(this, "TypeId", -1);
					r_PTypeId.SetBelong(this.instance);
				}
				return r_PTypeId;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.MarshalAsAttribute Copy()
		/// </summary>
		protected RMethod r_MCopy;
		public virtual RMethod RMCopy
		{
			get
			{
				if(r_MCopy == null)
				{
					r_MCopy = new(this, "Copy", 0);
					r_MCopy.SetBelong(this.instance);
				}
				return r_MCopy;
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
		/// Boolean Match(System.Object)
		/// </summary>
		protected RMethod r_MMatch_Object;
		public virtual RMethod RMMatch_Object
		{
			get
			{
				if(r_MMatch_Object == null)
				{
					r_MMatch_Object = new(this, "Match", 0, typeof(System.Object));
					r_MMatch_Object.SetBelong(this.instance);
				}
				return r_MMatch_Object;
			}
		}

		/// <summary>
		/// Boolean IsDefaultAttribute()
		/// </summary>
		protected RMethod r_MIsDefaultAttribute;
		public virtual RMethod RMIsDefaultAttribute
		{
			get
			{
				if(r_MIsDefaultAttribute == null)
				{
					r_MIsDefaultAttribute = new(this, "IsDefaultAttribute", 0);
					r_MIsDefaultAttribute.SetBelong(this.instance);
				}
				return r_MIsDefaultAttribute;
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


        public RMarshalAsAttribute() : base("System.Runtime.InteropServices.MarshalAsAttribute")
        {
        }

        public RMarshalAsAttribute(System.Object instance) : base("System.Runtime.InteropServices.MarshalAsAttribute")
		{
            SetInstance(instance);
		}

        public RMarshalAsAttribute(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RMarshalAsAttribute(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Runtime.InteropServices.MarshalAsAttribute Copy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCopy.Invoke(___genericsType, ___parameters);

            return (System.Runtime.InteropServices.MarshalAsAttribute)___result;
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


        public virtual System.Boolean Match(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMMatch_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsDefaultAttribute()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsDefaultAttribute.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
