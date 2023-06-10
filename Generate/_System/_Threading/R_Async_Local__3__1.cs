
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RThreading
{
	/// <summary>
	/// System.Threading.AsyncLocal`1
	/// </summary>
    public partial class RAsyncLocal<T> : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Threading.AsyncLocal<>).MakeGenericType(TypeToString.GetType(typeof(T)));
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


		/// <summary>
		/// System.Action`1[System.Threading.AsyncLocalValueChangedArgs`1[T]] m_valueChangedHandler
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RSystem.RThreading.RAsyncLocalValueChangedArgs<Hvak.Editor.Refleaction.RField>> r_Fm_valueChangedHandler;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RSystem.RThreading.RAsyncLocalValueChangedArgs<Hvak.Editor.Refleaction.RField>> RFm_valueChangedHandler
		{
			get
			{
				if(r_Fm_valueChangedHandler == null)
				{
					r_Fm_valueChangedHandler = new(this, "m_valueChangedHandler");
				}
				return r_Fm_valueChangedHandler;
			}
		}

		/// <summary>
		/// T Value
		/// </summary>
		protected Hvak.Editor.Refleaction.RProperty r_PValue;
		public virtual Hvak.Editor.Refleaction.RProperty RPValue
		{
			get
			{
				if(r_PValue == null)
				{
					r_PValue = new(this, "Value", -1);
				}
				return r_PValue;
			}
		}

		/// <summary>
		/// Void System.Threading.IAsyncLocal.OnValueChanged(System.Object, System.Object, Boolean)
		/// </summary>
		protected RMethod r_MSystem__2__Threading__2__IAsyncLocal__2__OnValueChanged_Object_Object_Boolean;
		public virtual RMethod RMSystem__2__Threading__2__IAsyncLocal__2__OnValueChanged_Object_Object_Boolean
		{
			get
			{
				if(r_MSystem__2__Threading__2__IAsyncLocal__2__OnValueChanged_Object_Object_Boolean == null)
				{
					r_MSystem__2__Threading__2__IAsyncLocal__2__OnValueChanged_Object_Object_Boolean = new(this, "System.Threading.IAsyncLocal.OnValueChanged", 0, typeof(System.Object), typeof(System.Object), typeof(System.Boolean));
				}
				return r_MSystem__2__Threading__2__IAsyncLocal__2__OnValueChanged_Object_Object_Boolean;
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


        public virtual void System__2__Threading__2__IAsyncLocal__2__OnValueChanged(System.Object @previousValueObj, System.Object @currentValueObj, System.Boolean @contextChanged)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@previousValueObj, @currentValueObj, @contextChanged};
            var ___result = RMSystem__2__Threading__2__IAsyncLocal__2__OnValueChanged_Object_Object_Boolean.Invoke(___genericsType, ___parameters);

            
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
