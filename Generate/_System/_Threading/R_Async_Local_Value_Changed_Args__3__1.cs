
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RThreading
{
	/// <summary>
	/// System.Threading.AsyncLocalValueChangedArgs`1
	/// </summary>
    public partial class RAsyncLocalValueChangedArgs<T> : RMember //
    {

		/// <summary>
		/// T <PreviousValue>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RField r_F__0__PreviousValue__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RField RF__0__PreviousValue__1__k__BackingField
		{
			get
			{
				if(r_F__0__PreviousValue__1__k__BackingField == null)
				{
					r_F__0__PreviousValue__1__k__BackingField = new(this, "<PreviousValue>k__BackingField");
					r_F__0__PreviousValue__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__PreviousValue__1__k__BackingField;
			}
		}

		/// <summary>
		/// T <CurrentValue>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RField r_F__0__CurrentValue__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RField RF__0__CurrentValue__1__k__BackingField
		{
			get
			{
				if(r_F__0__CurrentValue__1__k__BackingField == null)
				{
					r_F__0__CurrentValue__1__k__BackingField = new(this, "<CurrentValue>k__BackingField");
					r_F__0__CurrentValue__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__CurrentValue__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean <ThreadContextChanged>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_F__0__ThreadContextChanged__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RF__0__ThreadContextChanged__1__k__BackingField
		{
			get
			{
				if(r_F__0__ThreadContextChanged__1__k__BackingField == null)
				{
					r_F__0__ThreadContextChanged__1__k__BackingField = new(this, "<ThreadContextChanged>k__BackingField");
					r_F__0__ThreadContextChanged__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__ThreadContextChanged__1__k__BackingField;
			}
		}

		/// <summary>
		/// T PreviousValue
		/// </summary>
		protected Hvak.Editor.Refleaction.RProperty r_PPreviousValue;
		public virtual Hvak.Editor.Refleaction.RProperty RPPreviousValue
		{
			get
			{
				if(r_PPreviousValue == null)
				{
					r_PPreviousValue = new(this, "PreviousValue", -1);
					r_PPreviousValue.SetBelong(this.instance);
				}
				return r_PPreviousValue;
			}
		}

		/// <summary>
		/// T CurrentValue
		/// </summary>
		protected Hvak.Editor.Refleaction.RProperty r_PCurrentValue;
		public virtual Hvak.Editor.Refleaction.RProperty RPCurrentValue
		{
			get
			{
				if(r_PCurrentValue == null)
				{
					r_PCurrentValue = new(this, "CurrentValue", -1);
					r_PCurrentValue.SetBelong(this.instance);
				}
				return r_PCurrentValue;
			}
		}

		/// <summary>
		/// Boolean ThreadContextChanged
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PThreadContextChanged;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPThreadContextChanged
		{
			get
			{
				if(r_PThreadContextChanged == null)
				{
					r_PThreadContextChanged = new(this, "ThreadContextChanged", -1);
					r_PThreadContextChanged.SetBelong(this.instance);
				}
				return r_PThreadContextChanged;
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


        public RAsyncLocalValueChangedArgs() : base("System.Threading.AsyncLocalValueChangedArgs`1")
        {
        }

        public RAsyncLocalValueChangedArgs(System.Object instance) : base("System.Threading.AsyncLocalValueChangedArgs`1")
		{
            SetInstance(instance);
		}

        public RAsyncLocalValueChangedArgs(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAsyncLocalValueChangedArgs(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
