using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{
	/// <summary>
	/// UnityEngine.UIElements.UIR.LinkedPool`1
	/// </summary>
    public partial class RLinkedPool<T> : RMember //
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
		protected RField r___0__Count__1__k__BackingField;
		public virtual RField R__0__Count__1__k__BackingField
		{
			get
			{
				if(r___0__Count__1__k__BackingField == null)
				{
					r___0__Count__1__k__BackingField = new(this, "<Count>k__BackingField");
					r___0__Count__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__Count__1__k__BackingField;
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
		protected RMethod r_Clear;
		public virtual RMethod RClear
		{
			get
			{
				if(r_Clear == null)
				{
					r_Clear = new(this, "Clear", 0);
					r_Clear.SetBelong(this.instance);
				}
				return r_Clear;
			}
		}

		/// <summary>
		/// T Get()
		/// </summary>
		protected RMethod r_Get;
		public virtual RMethod RGet
		{
			get
			{
				if(r_Get == null)
				{
					r_Get = new(this, "Get", 0);
					r_Get.SetBelong(this.instance);
				}
				return r_Get;
			}
		}

		/// <summary>
		/// Void Return(T)
		/// </summary>
		protected RMethod r_Return_T;
		public virtual RMethod RReturn_T
		{
			get
			{
				if(r_Return_T == null)
				{
					r_Return_T = new(this, "Return", 0, Type.MakeGenericMethodParameter(0));
					r_Return_T.SetBelong(this.instance);
				}
				return r_Return_T;
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
