
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.TouchScreenKeyboard_InternalConstructorHelperArguments
	/// </summary>
    public partial class RTouchScreenKeyboard_InternalConstructorHelperArguments : RMember //
    {

		/// <summary>
		/// System.UInt32 keyboardType
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_FkeyboardType;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFkeyboardType
		{
			get
			{
				if(r_FkeyboardType == null)
				{
					r_FkeyboardType = new(this, "keyboardType");
					r_FkeyboardType.SetBelong(this.GetValue());
				}
				return r_FkeyboardType;
			}
		}

		/// <summary>
		/// System.UInt32 autocorrection
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_Fautocorrection;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFautocorrection
		{
			get
			{
				if(r_Fautocorrection == null)
				{
					r_Fautocorrection = new(this, "autocorrection");
					r_Fautocorrection.SetBelong(this.GetValue());
				}
				return r_Fautocorrection;
			}
		}

		/// <summary>
		/// System.UInt32 multiline
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_Fmultiline;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFmultiline
		{
			get
			{
				if(r_Fmultiline == null)
				{
					r_Fmultiline = new(this, "multiline");
					r_Fmultiline.SetBelong(this.GetValue());
				}
				return r_Fmultiline;
			}
		}

		/// <summary>
		/// System.UInt32 secure
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_Fsecure;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFsecure
		{
			get
			{
				if(r_Fsecure == null)
				{
					r_Fsecure = new(this, "secure");
					r_Fsecure.SetBelong(this.GetValue());
				}
				return r_Fsecure;
			}
		}

		/// <summary>
		/// System.UInt32 alert
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_Falert;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFalert
		{
			get
			{
				if(r_Falert == null)
				{
					r_Falert = new(this, "alert");
					r_Falert.SetBelong(this.GetValue());
				}
				return r_Falert;
			}
		}

		/// <summary>
		/// System.Int32 characterLimit
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FcharacterLimit;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFcharacterLimit
		{
			get
			{
				if(r_FcharacterLimit == null)
				{
					r_FcharacterLimit = new(this, "characterLimit");
					r_FcharacterLimit.SetBelong(this.GetValue());
				}
				return r_FcharacterLimit;
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


        public RTouchScreenKeyboard_InternalConstructorHelperArguments() : base("UnityEngine.TouchScreenKeyboard_InternalConstructorHelperArguments")
        {
        }

        public RTouchScreenKeyboard_InternalConstructorHelperArguments(System.Object instance) : base("UnityEngine.TouchScreenKeyboard_InternalConstructorHelperArguments")
		{
            SetInstance(instance);
		}

        public RTouchScreenKeyboard_InternalConstructorHelperArguments(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTouchScreenKeyboard_InternalConstructorHelperArguments(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
