using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RThreading
{
	/// <summary>
	/// System.Threading.AsyncLocal`1
	/// </summary>
    public partial class RAsyncLocal<T> : RMember //
    {

		/// <summary>
		/// System.Action`1[System.Threading.AsyncLocalValueChangedArgs`1[T]] m_valueChangedHandler
		/// </summary>
		protected RSystem.RAction<RSystem.RThreading.RAsyncLocalValueChangedArgs<RField>> r_m_valueChangedHandler;
		public virtual RSystem.RAction<RSystem.RThreading.RAsyncLocalValueChangedArgs<RField>> Rm_valueChangedHandler
		{
			get
			{
				if(r_m_valueChangedHandler == null)
				{
					r_m_valueChangedHandler = new(this, "m_valueChangedHandler");
					r_m_valueChangedHandler.SetBelong(this.instance);
				}
				return r_m_valueChangedHandler;
			}
		}

		/// <summary>
		/// T Value
		/// </summary>
		protected RProperty r_Value;
		public virtual RProperty RValue
		{
			get
			{
				if(r_Value == null)
				{
					r_Value = new(this, "Value", -1);
					r_Value.SetBelong(this.instance);
				}
				return r_Value;
			}
		}

		/// <summary>
		/// Void System.Threading.IAsyncLocal.OnValueChanged(System.Object, System.Object, Boolean)
		/// </summary>
		protected RMethod r_System__2__Threading__2__IAsyncLocal__2__OnValueChanged_Object_Object_Boolean;
		public virtual RMethod RSystem__2__Threading__2__IAsyncLocal__2__OnValueChanged_Object_Object_Boolean
		{
			get
			{
				if(r_System__2__Threading__2__IAsyncLocal__2__OnValueChanged_Object_Object_Boolean == null)
				{
					r_System__2__Threading__2__IAsyncLocal__2__OnValueChanged_Object_Object_Boolean = new(this, "System.Threading.IAsyncLocal.OnValueChanged", 0, typeof(System.Object), typeof(System.Object), typeof(System.Boolean));
					r_System__2__Threading__2__IAsyncLocal__2__OnValueChanged_Object_Object_Boolean.SetBelong(this.instance);
				}
				return r_System__2__Threading__2__IAsyncLocal__2__OnValueChanged_Object_Object_Boolean;
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


        public RAsyncLocal() : base("System.Threading.AsyncLocal`1")
        {
        }

        public RAsyncLocal(System.Object instance) : base("System.Threading.AsyncLocal`1")
		{
            SetInstance(instance);
		}

        public RAsyncLocal(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAsyncLocal(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void System__2__Threading__2__IAsyncLocal__2__OnValueChanged(System.Object  @previousValueObj, System.Object  @currentValueObj, System.Boolean  @contextChanged)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@previousValueObj, @currentValueObj, @contextChanged};
            var ___result = RSystem__2__Threading__2__IAsyncLocal__2__OnValueChanged_Object_Object_Boolean.Invoke(___genericsType, ___parameters);

            
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
