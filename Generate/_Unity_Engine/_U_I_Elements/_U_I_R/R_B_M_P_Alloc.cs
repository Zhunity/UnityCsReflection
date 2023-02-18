
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{
	/// <summary>
	/// UnityEngine.UIElements.UIR.BMPAlloc
	/// </summary>
    public partial class RBMPAlloc : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.UIR.BMPAlloc Invalid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBMPAlloc r_FInvalid;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBMPAlloc RFInvalid
		{
			get
			{
				if(r_FInvalid == null)
				{
					r_FInvalid = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BMPAlloc"), "Invalid");
				}
				return r_FInvalid;
			}
		}

		/// <summary>
		/// System.Int32 page
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fpage;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFpage
		{
			get
			{
				if(r_Fpage == null)
				{
					r_Fpage = new(this, "page");
				}
				return r_Fpage;
			}
		}

		/// <summary>
		/// System.UInt16 pageLine
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt16 r_FpageLine;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt16 RFpageLine
		{
			get
			{
				if(r_FpageLine == null)
				{
					r_FpageLine = new(this, "pageLine");
				}
				return r_FpageLine;
			}
		}

		/// <summary>
		/// System.Byte bitIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RByte r_FbitIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RByte RFbitIndex
		{
			get
			{
				if(r_FbitIndex == null)
				{
					r_FbitIndex = new(this, "bitIndex");
				}
				return r_FbitIndex;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.OwnedState ownedState
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.ROwnedState r_FownedState;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.ROwnedState RFownedState
		{
			get
			{
				if(r_FownedState == null)
				{
					r_FownedState = new(this, "ownedState");
				}
				return r_FownedState;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.UIElements.UIR.BMPAlloc)
		/// </summary>
		protected RMethod r_MEquals_BMPAlloc;
		public virtual RMethod RMEquals_BMPAlloc
		{
			get
			{
				if(r_MEquals_BMPAlloc == null)
				{
					r_MEquals_BMPAlloc = new(this, "Equals", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BMPAlloc"));
				}
				return r_MEquals_BMPAlloc;
			}
		}

		/// <summary>
		/// Boolean IsValid()
		/// </summary>
		protected RMethod r_MIsValid;
		public virtual RMethod RMIsValid
		{
			get
			{
				if(r_MIsValid == null)
				{
					r_MIsValid = new(this, "IsValid", 0);
				}
				return r_MIsValid;
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

        public virtual System.Boolean Equals(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBMPAlloc @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other.Value};
            var ___result = RMEquals_BMPAlloc.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsValid()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsValid.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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
