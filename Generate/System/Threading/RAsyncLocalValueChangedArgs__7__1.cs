using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RThreading
{
	/// <summary>
	/// System.Threading.AsyncLocalValueChangedArgs`1
	/// </summary>
    public partial class RAsyncLocalValueChangedArgs<T> : RMember //
    {

		/// <summary>
		/// T <PreviousValue>k__BackingField
		/// </summary>
		protected RField r___1__PreviousValue__2__k__BackingField;
		public virtual RField R__1__PreviousValue__2__k__BackingField
		{
			get
			{
				if(r___1__PreviousValue__2__k__BackingField == null)
				{
					r___1__PreviousValue__2__k__BackingField = new(this, "<PreviousValue>k__BackingField");
					r___1__PreviousValue__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__PreviousValue__2__k__BackingField;
			}
		}

		/// <summary>
		/// T <CurrentValue>k__BackingField
		/// </summary>
		protected RField r___1__CurrentValue__2__k__BackingField;
		public virtual RField R__1__CurrentValue__2__k__BackingField
		{
			get
			{
				if(r___1__CurrentValue__2__k__BackingField == null)
				{
					r___1__CurrentValue__2__k__BackingField = new(this, "<CurrentValue>k__BackingField");
					r___1__CurrentValue__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__CurrentValue__2__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean <ThreadContextChanged>k__BackingField
		/// </summary>
		protected RField r___1__ThreadContextChanged__2__k__BackingField;
		public virtual RField R__1__ThreadContextChanged__2__k__BackingField
		{
			get
			{
				if(r___1__ThreadContextChanged__2__k__BackingField == null)
				{
					r___1__ThreadContextChanged__2__k__BackingField = new(this, "<ThreadContextChanged>k__BackingField");
					r___1__ThreadContextChanged__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__ThreadContextChanged__2__k__BackingField;
			}
		}

		/// <summary>
		/// T PreviousValue
		/// </summary>
		protected RProperty r_PreviousValue;
		public virtual RProperty RPreviousValue
		{
			get
			{
				if(r_PreviousValue == null)
				{
					r_PreviousValue = new(this, "PreviousValue", -1);
					r_PreviousValue.SetBelong(this.instance);
				}
				return r_PreviousValue;
			}
		}

		/// <summary>
		/// T CurrentValue
		/// </summary>
		protected RProperty r_CurrentValue;
		public virtual RProperty RCurrentValue
		{
			get
			{
				if(r_CurrentValue == null)
				{
					r_CurrentValue = new(this, "CurrentValue", -1);
					r_CurrentValue.SetBelong(this.instance);
				}
				return r_CurrentValue;
			}
		}

		/// <summary>
		/// Boolean ThreadContextChanged
		/// </summary>
		protected RProperty r_ThreadContextChanged;
		public virtual RProperty RThreadContextChanged
		{
			get
			{
				if(r_ThreadContextChanged == null)
				{
					r_ThreadContextChanged = new(this, "ThreadContextChanged", -1);
					r_ThreadContextChanged.SetBelong(this.instance);
				}
				return r_ThreadContextChanged;
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
