using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{
	/// <summary>
	/// UnityEngine.UIElements.UIR.LinkedPool`1
	/// </summary>
    public partial class RLinkedPool<T> : RMember // where T : UnityEngine.UIElements.UIR.LinkedPoolItem<T>
    {

		/// <summary>
		/// System.Func`1[T] m_CreateFunc
		/// </summary>
		protected RSystem.RFunc<RField> r_m_CreateFunc;
		public virtual RSystem.RFunc<RField> Rm_CreateFunc
		{
			get
			{
				if(r_m_CreateFunc == null)
				{
					r_m_CreateFunc = new(this, "m_CreateFunc");
					r_m_CreateFunc.SetBelong(this.instance);
				}
				return r_m_CreateFunc;
			}
		}

		/// <summary>
		/// System.Action`1[T] m_ResetAction
		/// </summary>
		protected RSystem.RAction<RField> r_m_ResetAction;
		public virtual RSystem.RAction<RField> Rm_ResetAction
		{
			get
			{
				if(r_m_ResetAction == null)
				{
					r_m_ResetAction = new(this, "m_ResetAction");
					r_m_ResetAction.SetBelong(this.instance);
				}
				return r_m_ResetAction;
			}
		}

		/// <summary>
		/// System.Int32 m_Limit
		/// </summary>
		protected RField r_m_Limit;
		public virtual RField Rm_Limit
		{
			get
			{
				if(r_m_Limit == null)
				{
					r_m_Limit = new(this, "m_Limit");
					r_m_Limit.SetBelong(this.instance);
				}
				return r_m_Limit;
			}
		}

		/// <summary>
		/// T m_PoolFirst
		/// </summary>
		protected RField r_m_PoolFirst;
		public virtual RField Rm_PoolFirst
		{
			get
			{
				if(r_m_PoolFirst == null)
				{
					r_m_PoolFirst = new(this, "m_PoolFirst");
					r_m_PoolFirst.SetBelong(this.instance);
				}
				return r_m_PoolFirst;
			}
		}

		/// <summary>
		/// System.Int32 <Count>k__BackingField
		/// </summary>
		protected RField r___1__Count__2__k__BackingField;
		public virtual RField R__1__Count__2__k__BackingField
		{
			get
			{
				if(r___1__Count__2__k__BackingField == null)
				{
					r___1__Count__2__k__BackingField = new(this, "<Count>k__BackingField");
					r___1__Count__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__Count__2__k__BackingField;
			}
		}

		/// <summary>
		/// Int32 Count
		/// </summary>
		protected RProperty r_Count;
		public virtual RProperty RCount
		{
			get
			{
				if(r_Count == null)
				{
					r_Count = new(this, "Count", -1);
					r_Count.SetBelong(this.instance);
				}
				return r_Count;
			}
		}

		/// <summary>
		/// Void Clear()
		/// </summary>
		protected RMethod r_RClear;
		public virtual RMethod RClear
		{
			get
			{
				if(r_RClear == null)
				{
					r_RClear = new(this, "Clear", 0);
					r_RClear.SetBelong(this.instance);
				}
				return r_RClear;
			}
		}

		/// <summary>
		/// T Get()
		/// </summary>
		protected RMethod r_RGet;
		public virtual RMethod RGet
		{
			get
			{
				if(r_RGet == null)
				{
					r_RGet = new(this, "Get", 0);
					r_RGet.SetBelong(this.instance);
				}
				return r_RGet;
			}
		}

		/// <summary>
		/// Void Return(T)
		/// </summary>
		protected RMethod r_RReturn_T;
		public virtual RMethod RReturn_T
		{
			get
			{
				if(r_RReturn_T == null)
				{
					r_RReturn_T = new(this, "Return", 0, Type.MakeGenericMethodParameter(0));
					r_RReturn_T.SetBelong(this.instance);
				}
				return r_RReturn_T;
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


        public RLinkedPool() : base("UnityEngine.UIElements.UIR.LinkedPool`1")
        {
        }

        public RLinkedPool(System.Object instance) : base("UnityEngine.UIElements.UIR.LinkedPool`1")
		{
            SetInstance(instance);
		}

        public RLinkedPool(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RLinkedPool(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual T Get()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGet.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual void Return(T  @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RReturn_T.Invoke(___genericsType, ___parameters);

            
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
