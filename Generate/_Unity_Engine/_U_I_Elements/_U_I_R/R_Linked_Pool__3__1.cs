
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{
	/// <summary>
	/// UnityEngine.UIElements.UIR.LinkedPool`1
	/// </summary>
    public partial class RLinkedPool<T> : RMember //
    {

		/// <summary>
		/// System.Func`1[T] m_CreateFunc
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RFunc<Hvak.Editor.Refleaction.RField> r_Fm_CreateFunc;
		public virtual Hvak.Editor.Refleaction.RSystem.RFunc<Hvak.Editor.Refleaction.RField> RFm_CreateFunc
		{
			get
			{
				if(r_Fm_CreateFunc == null)
				{
					r_Fm_CreateFunc = new(this, "m_CreateFunc");
					r_Fm_CreateFunc.SetBelong(this.GetValue());
				}
				return r_Fm_CreateFunc;
			}
		}

		/// <summary>
		/// System.Action`1[T] m_ResetAction
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RField> r_Fm_ResetAction;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RField> RFm_ResetAction
		{
			get
			{
				if(r_Fm_ResetAction == null)
				{
					r_Fm_ResetAction = new(this, "m_ResetAction");
					r_Fm_ResetAction.SetBelong(this.GetValue());
				}
				return r_Fm_ResetAction;
			}
		}

		/// <summary>
		/// System.Int32 m_Limit
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_Limit;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_Limit
		{
			get
			{
				if(r_Fm_Limit == null)
				{
					r_Fm_Limit = new(this, "m_Limit");
					r_Fm_Limit.SetBelong(this.GetValue());
				}
				return r_Fm_Limit;
			}
		}

		/// <summary>
		/// T m_PoolFirst
		/// </summary>
		protected Hvak.Editor.Refleaction.RField r_Fm_PoolFirst;
		public virtual Hvak.Editor.Refleaction.RField RFm_PoolFirst
		{
			get
			{
				if(r_Fm_PoolFirst == null)
				{
					r_Fm_PoolFirst = new(this, "m_PoolFirst");
					r_Fm_PoolFirst.SetBelong(this.GetValue());
				}
				return r_Fm_PoolFirst;
			}
		}

		/// <summary>
		/// System.Int32 <Count>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F__0__Count__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF__0__Count__1__k__BackingField
		{
			get
			{
				if(r_F__0__Count__1__k__BackingField == null)
				{
					r_F__0__Count__1__k__BackingField = new(this, "<Count>k__BackingField");
					r_F__0__Count__1__k__BackingField.SetBelong(this.GetValue());
				}
				return r_F__0__Count__1__k__BackingField;
			}
		}

		/// <summary>
		/// Int32 Count
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPCount
		{
			get
			{
				if(r_PCount == null)
				{
					r_PCount = new(this, "Count", -1);
					r_PCount.SetBelong(this.GetValue());
				}
				return r_PCount;
			}
		}

		/// <summary>
		/// Void Clear()
		/// </summary>
		protected RMethod r_MClear;
		public virtual RMethod RMClear
		{
			get
			{
				if(r_MClear == null)
				{
					r_MClear = new(this, "Clear", 0);
					r_MClear.SetBelong(this.GetValue());
				}
				return r_MClear;
			}
		}

		/// <summary>
		/// T Get()
		/// </summary>
		protected RMethod r_MGet;
		public virtual RMethod RMGet
		{
			get
			{
				if(r_MGet == null)
				{
					r_MGet = new(this, "Get", 0);
					r_MGet.SetBelong(this.GetValue());
				}
				return r_MGet;
			}
		}

		/// <summary>
		/// Void Return(T)
		/// </summary>
		protected RMethod r_MReturn_T;
		public virtual RMethod RMReturn_T
		{
			get
			{
				if(r_MReturn_T == null)
				{
					r_MReturn_T = new(this, "Return", 0, Type.MakeGenericMethodParameter(0));
					r_MReturn_T.SetBelong(this.GetValue());
				}
				return r_MReturn_T;
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
            var ___result = RMClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RType Get()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGet.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RType(___result);
        }


        public virtual void Return(Hvak.Editor.Refleaction.RType @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item.Value};
            var ___result = RMReturn_T.Invoke(___genericsType, ___parameters);

            
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
