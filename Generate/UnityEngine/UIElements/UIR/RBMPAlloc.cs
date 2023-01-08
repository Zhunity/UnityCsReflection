using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{
	/// <summary>
	/// UnityEngine.UIElements.UIR.BMPAlloc
	/// </summary>
    public partial class RBMPAlloc : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.UIR.BMPAlloc Invalid
		/// </summary>
		protected static RUnityEngine.RUIElements.RUIR.RBMPAlloc r_Invalid;
		public static RUnityEngine.RUIElements.RUIR.RBMPAlloc RInvalid
		{
			get
			{
				if(r_Invalid == null)
				{
					r_Invalid = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BMPAlloc"), "Invalid");
					r_Invalid.SetBelong(null);
				}
				return r_Invalid;
			}
		}

		/// <summary>
		/// System.Int32 page
		/// </summary>
		protected RField r_page;
		public virtual RField Rpage
		{
			get
			{
				if(r_page == null)
				{
					r_page = new(this, "page");
					r_page.SetBelong(this.instance);
				}
				return r_page;
			}
		}

		/// <summary>
		/// System.UInt16 pageLine
		/// </summary>
		protected RField r_pageLine;
		public virtual RField RpageLine
		{
			get
			{
				if(r_pageLine == null)
				{
					r_pageLine = new(this, "pageLine");
					r_pageLine.SetBelong(this.instance);
				}
				return r_pageLine;
			}
		}

		/// <summary>
		/// System.Byte bitIndex
		/// </summary>
		protected RField r_bitIndex;
		public virtual RField RbitIndex
		{
			get
			{
				if(r_bitIndex == null)
				{
					r_bitIndex = new(this, "bitIndex");
					r_bitIndex.SetBelong(this.instance);
				}
				return r_bitIndex;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.OwnedState ownedState
		/// </summary>
		protected RField r_ownedState;
		public virtual RField RownedState
		{
			get
			{
				if(r_ownedState == null)
				{
					r_ownedState = new(this, "ownedState");
					r_ownedState.SetBelong(this.instance);
				}
				return r_ownedState;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.UIElements.UIR.BMPAlloc)
		/// </summary>
		protected RMethod r_Equals_BMPAlloc;
		public virtual RMethod REquals_BMPAlloc
		{
			get
			{
				if(r_Equals_BMPAlloc == null)
				{
					r_Equals_BMPAlloc = new(this, "Equals", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BMPAlloc"));
					r_Equals_BMPAlloc.SetBelong(this.instance);
				}
				return r_Equals_BMPAlloc;
			}
		}

		/// <summary>
		/// Boolean IsValid()
		/// </summary>
		protected RMethod r_IsValid;
		public virtual RMethod RIsValid
		{
			get
			{
				if(r_IsValid == null)
				{
					r_IsValid = new(this, "IsValid", 0);
					r_IsValid.SetBelong(this.instance);
				}
				return r_IsValid;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_ToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_ToString == null)
				{
					r_ToString = new(this, "ToString", 0);
					r_ToString.SetBelong(this.instance);
				}
				return r_ToString;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_Equals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_Equals_Object == null)
				{
					r_Equals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_Equals_Object.SetBelong(this.instance);
				}
				return r_Equals_Object;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_GetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_GetHashCode == null)
				{
					r_GetHashCode = new(this, "GetHashCode", 0);
					r_GetHashCode.SetBelong(this.instance);
				}
				return r_GetHashCode;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_Finalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_Finalize == null)
				{
					r_Finalize = new(this, "Finalize", 0);
					r_Finalize.SetBelong(this.instance);
				}
				return r_Finalize;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_GetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_GetType == null)
				{
					r_GetType = new(this, "GetType", 0);
					r_GetType.SetBelong(this.instance);
				}
				return r_GetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_MemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_MemberwiseClone == null)
				{
					r_MemberwiseClone = new(this, "MemberwiseClone", 0);
					r_MemberwiseClone.SetBelong(this.instance);
				}
				return r_MemberwiseClone;
			}
		}


        public RBMPAlloc() : base("UnityEngine.UIElements.UIR.BMPAlloc")
        {
        }

        public RBMPAlloc(System.Object instance) : base("UnityEngine.UIElements.UIR.BMPAlloc")
		{
            SetInstance(instance);
		}

        public RBMPAlloc(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RBMPAlloc(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


        public virtual System.Boolean IsValid()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsValid.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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
