using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RExperimental
{
	/// <summary>
	/// UnityEngine.UIElements.Experimental.ValueAnimation`1
	/// </summary>
    public partial class RValueAnimation<T> : RMember //
    {

		/// <summary>
		/// System.Int32 k_DefaultDurationMs
		/// </summary>
		protected static RField r_k_DefaultDurationMs;
		public static RField Rk_DefaultDurationMs
		{
			get
			{
				if(r_k_DefaultDurationMs == null)
				{
					r_k_DefaultDurationMs = new(typeof(UnityEngine.UIElements.Experimental.ValueAnimation<>), "k_DefaultDurationMs");
					r_k_DefaultDurationMs.SetBelong(null);
				}
				return r_k_DefaultDurationMs;
			}
		}

		/// <summary>
		/// System.Int32 k_DefaultMaxPoolSize
		/// </summary>
		protected static RField r_k_DefaultMaxPoolSize;
		public static RField Rk_DefaultMaxPoolSize
		{
			get
			{
				if(r_k_DefaultMaxPoolSize == null)
				{
					r_k_DefaultMaxPoolSize = new(typeof(UnityEngine.UIElements.Experimental.ValueAnimation<>), "k_DefaultMaxPoolSize");
					r_k_DefaultMaxPoolSize.SetBelong(null);
				}
				return r_k_DefaultMaxPoolSize;
			}
		}

		/// <summary>
		/// System.Int64 m_StartTimeMs
		/// </summary>
		protected RField r_m_StartTimeMs;
		public virtual RField Rm_StartTimeMs
		{
			get
			{
				if(r_m_StartTimeMs == null)
				{
					r_m_StartTimeMs = new(this, "m_StartTimeMs");
					r_m_StartTimeMs.SetBelong(this.instance);
				}
				return r_m_StartTimeMs;
			}
		}

		/// <summary>
		/// System.Int32 m_DurationMs
		/// </summary>
		protected RField r_m_DurationMs;
		public virtual RField Rm_DurationMs
		{
			get
			{
				if(r_m_DurationMs == null)
				{
					r_m_DurationMs = new(this, "m_DurationMs");
					r_m_DurationMs.SetBelong(this.instance);
				}
				return r_m_DurationMs;
			}
		}

		/// <summary>
		/// System.Func`2[System.Single,System.Single] <easingCurve>k__BackingField
		/// </summary>
		protected RSystem.RFunc<RField, RField> r___0__easingCurve__1__k__BackingField;
		public virtual RSystem.RFunc<RField, RField> R__0__easingCurve__1__k__BackingField
		{
			get
			{
				if(r___0__easingCurve__1__k__BackingField == null)
				{
					r___0__easingCurve__1__k__BackingField = new(this, "<easingCurve>k__BackingField");
					r___0__easingCurve__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__easingCurve__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean <isRunning>k__BackingField
		/// </summary>
		protected RField r___0__isRunning__1__k__BackingField;
		public virtual RField R__0__isRunning__1__k__BackingField
		{
			get
			{
				if(r___0__isRunning__1__k__BackingField == null)
				{
					r___0__isRunning__1__k__BackingField = new(this, "<isRunning>k__BackingField");
					r___0__isRunning__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__isRunning__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Action <onAnimationCompleted>k__BackingField
		/// </summary>
		protected RSystem.RAction r___0__onAnimationCompleted__1__k__BackingField;
		public virtual RSystem.RAction R__0__onAnimationCompleted__1__k__BackingField
		{
			get
			{
				if(r___0__onAnimationCompleted__1__k__BackingField == null)
				{
					r___0__onAnimationCompleted__1__k__BackingField = new(this, "<onAnimationCompleted>k__BackingField");
					r___0__onAnimationCompleted__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__onAnimationCompleted__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean <autoRecycle>k__BackingField
		/// </summary>
		protected RField r___0__autoRecycle__1__k__BackingField;
		public virtual RField R__0__autoRecycle__1__k__BackingField
		{
			get
			{
				if(r___0__autoRecycle__1__k__BackingField == null)
				{
					r___0__autoRecycle__1__k__BackingField = new(this, "<autoRecycle>k__BackingField");
					r___0__autoRecycle__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__autoRecycle__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean <recycled>k__BackingField
		/// </summary>
		protected RField r___0__recycled__1__k__BackingField;
		public virtual RField R__0__recycled__1__k__BackingField
		{
			get
			{
				if(r___0__recycled__1__k__BackingField == null)
				{
					r___0__recycled__1__k__BackingField = new(this, "<recycled>k__BackingField");
					r___0__recycled__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__recycled__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ObjectPool`1[UnityEngine.UIElements.Experimental.ValueAnimation`1[T]] sObjectPool
		/// </summary>
		protected static RUnityEngine.RUIElements.RObjectPool<RUnityEngine.RUIElements.RExperimental.RValueAnimation<RField>> r_sObjectPool;
		public static RUnityEngine.RUIElements.RObjectPool<RUnityEngine.RUIElements.RExperimental.RValueAnimation<RField>> RsObjectPool
		{
			get
			{
				if(r_sObjectPool == null)
				{
					r_sObjectPool = new(typeof(UnityEngine.UIElements.Experimental.ValueAnimation<>), "sObjectPool");
					r_sObjectPool.SetBelong(null);
				}
				return r_sObjectPool;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement <owner>k__BackingField
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r___0__owner__1__k__BackingField;
		public virtual RUnityEngine.RUIElements.RVisualElement R__0__owner__1__k__BackingField
		{
			get
			{
				if(r___0__owner__1__k__BackingField == null)
				{
					r___0__owner__1__k__BackingField = new(this, "<owner>k__BackingField");
					r___0__owner__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__owner__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Action`2[UnityEngine.UIElements.VisualElement,T] <valueUpdated>k__BackingField
		/// </summary>
		protected RSystem.RAction<RUnityEngine.RUIElements.RVisualElement, RField> r___0__valueUpdated__1__k__BackingField;
		public virtual RSystem.RAction<RUnityEngine.RUIElements.RVisualElement, RField> R__0__valueUpdated__1__k__BackingField
		{
			get
			{
				if(r___0__valueUpdated__1__k__BackingField == null)
				{
					r___0__valueUpdated__1__k__BackingField = new(this, "<valueUpdated>k__BackingField");
					r___0__valueUpdated__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__valueUpdated__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Func`2[UnityEngine.UIElements.VisualElement,T] <initialValue>k__BackingField
		/// </summary>
		protected RSystem.RFunc<RUnityEngine.RUIElements.RVisualElement, RField> r___0__initialValue__1__k__BackingField;
		public virtual RSystem.RFunc<RUnityEngine.RUIElements.RVisualElement, RField> R__0__initialValue__1__k__BackingField
		{
			get
			{
				if(r___0__initialValue__1__k__BackingField == null)
				{
					r___0__initialValue__1__k__BackingField = new(this, "<initialValue>k__BackingField");
					r___0__initialValue__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__initialValue__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Func`4[T,T,System.Single,T] <interpolator>k__BackingField
		/// </summary>
		protected RSystem.RFunc<RField, RField, RField, RField> r___0__interpolator__1__k__BackingField;
		public virtual RSystem.RFunc<RField, RField, RField, RField> R__0__interpolator__1__k__BackingField
		{
			get
			{
				if(r___0__interpolator__1__k__BackingField == null)
				{
					r___0__interpolator__1__k__BackingField = new(this, "<interpolator>k__BackingField");
					r___0__interpolator__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__interpolator__1__k__BackingField;
			}
		}

		/// <summary>
		/// T _from
		/// </summary>
		protected RField r__from;
		public virtual RField R_from
		{
			get
			{
				if(r__from == null)
				{
					r__from = new(this, "_from");
					r__from.SetBelong(this.instance);
				}
				return r__from;
			}
		}

		/// <summary>
		/// System.Boolean fromValueSet
		/// </summary>
		protected RField r_fromValueSet;
		public virtual RField RfromValueSet
		{
			get
			{
				if(r_fromValueSet == null)
				{
					r_fromValueSet = new(this, "fromValueSet");
					r_fromValueSet.SetBelong(this.instance);
				}
				return r_fromValueSet;
			}
		}

		/// <summary>
		/// T <to>k__BackingField
		/// </summary>
		protected RField r___0__to__1__k__BackingField;
		public virtual RField R__0__to__1__k__BackingField
		{
			get
			{
				if(r___0__to__1__k__BackingField == null)
				{
					r___0__to__1__k__BackingField = new(this, "<to>k__BackingField");
					r___0__to__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__to__1__k__BackingField;
			}
		}

		/// <summary>
		/// Int32 durationMs
		/// </summary>
		protected RProperty r_durationMs;
		public virtual RProperty RdurationMs
		{
			get
			{
				if(r_durationMs == null)
				{
					r_durationMs = new(this, "durationMs", -1);
					r_durationMs.SetBelong(this.instance);
				}
				return r_durationMs;
			}
		}

		/// <summary>
		/// System.Func`2[System.Single,System.Single] easingCurve
		/// </summary>
		protected RSystem.RFunc<RProperty, RProperty> r_easingCurve;
		public virtual RSystem.RFunc<RProperty, RProperty> ReasingCurve
		{
			get
			{
				if(r_easingCurve == null)
				{
					r_easingCurve = new(this, "easingCurve", -1);
					r_easingCurve.SetBelong(this.instance);
				}
				return r_easingCurve;
			}
		}

		/// <summary>
		/// Boolean isRunning
		/// </summary>
		protected RProperty r_isRunning;
		public virtual RProperty RisRunning
		{
			get
			{
				if(r_isRunning == null)
				{
					r_isRunning = new(this, "isRunning", -1);
					r_isRunning.SetBelong(this.instance);
				}
				return r_isRunning;
			}
		}

		/// <summary>
		/// System.Action onAnimationCompleted
		/// </summary>
		protected RSystem.RAction r_onAnimationCompleted;
		public virtual RSystem.RAction RonAnimationCompleted
		{
			get
			{
				if(r_onAnimationCompleted == null)
				{
					r_onAnimationCompleted = new(this, "onAnimationCompleted", -1);
					r_onAnimationCompleted.SetBelong(this.instance);
				}
				return r_onAnimationCompleted;
			}
		}

		/// <summary>
		/// Boolean autoRecycle
		/// </summary>
		protected RProperty r_autoRecycle;
		public virtual RProperty RautoRecycle
		{
			get
			{
				if(r_autoRecycle == null)
				{
					r_autoRecycle = new(this, "autoRecycle", -1);
					r_autoRecycle.SetBelong(this.instance);
				}
				return r_autoRecycle;
			}
		}

		/// <summary>
		/// Boolean recycled
		/// </summary>
		protected RProperty r_recycled;
		public virtual RProperty Rrecycled
		{
			get
			{
				if(r_recycled == null)
				{
					r_recycled = new(this, "recycled", -1);
					r_recycled.SetBelong(this.instance);
				}
				return r_recycled;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement owner
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_owner;
		public virtual RUnityEngine.RUIElements.RVisualElement Rowner
		{
			get
			{
				if(r_owner == null)
				{
					r_owner = new(this, "owner", -1);
					r_owner.SetBelong(this.instance);
				}
				return r_owner;
			}
		}

		/// <summary>
		/// System.Action`2[UnityEngine.UIElements.VisualElement,T] valueUpdated
		/// </summary>
		protected RSystem.RAction<RUnityEngine.RUIElements.RVisualElement, RProperty> r_valueUpdated;
		public virtual RSystem.RAction<RUnityEngine.RUIElements.RVisualElement, RProperty> RvalueUpdated
		{
			get
			{
				if(r_valueUpdated == null)
				{
					r_valueUpdated = new(this, "valueUpdated", -1);
					r_valueUpdated.SetBelong(this.instance);
				}
				return r_valueUpdated;
			}
		}

		/// <summary>
		/// System.Func`2[UnityEngine.UIElements.VisualElement,T] initialValue
		/// </summary>
		protected RSystem.RFunc<RUnityEngine.RUIElements.RVisualElement, RProperty> r_initialValue;
		public virtual RSystem.RFunc<RUnityEngine.RUIElements.RVisualElement, RProperty> RinitialValue
		{
			get
			{
				if(r_initialValue == null)
				{
					r_initialValue = new(this, "initialValue", -1);
					r_initialValue.SetBelong(this.instance);
				}
				return r_initialValue;
			}
		}

		/// <summary>
		/// System.Func`4[T,T,System.Single,T] interpolator
		/// </summary>
		protected RSystem.RFunc<RProperty, RProperty, RProperty, RProperty> r_interpolator;
		public virtual RSystem.RFunc<RProperty, RProperty, RProperty, RProperty> Rinterpolator
		{
			get
			{
				if(r_interpolator == null)
				{
					r_interpolator = new(this, "interpolator", -1);
					r_interpolator.SetBelong(this.instance);
				}
				return r_interpolator;
			}
		}

		/// <summary>
		/// T from
		/// </summary>
		protected RProperty r_from;
		public virtual RProperty Rfrom
		{
			get
			{
				if(r_from == null)
				{
					r_from = new(this, "from", -1);
					r_from.SetBelong(this.instance);
				}
				return r_from;
			}
		}

		/// <summary>
		/// T to
		/// </summary>
		protected RProperty r_to;
		public virtual RProperty Rto
		{
			get
			{
				if(r_to == null)
				{
					r_to = new(this, "to", -1);
					r_to.SetBelong(this.instance);
				}
				return r_to;
			}
		}

		/// <summary>
		/// Void Start()
		/// </summary>
		protected RMethod r_Start;
		public virtual RMethod RStart
		{
			get
			{
				if(r_Start == null)
				{
					r_Start = new(this, "Start", 0);
					r_Start.SetBelong(this.instance);
				}
				return r_Start;
			}
		}

		/// <summary>
		/// Void Stop()
		/// </summary>
		protected RMethod r_Stop;
		public virtual RMethod RStop
		{
			get
			{
				if(r_Stop == null)
				{
					r_Stop = new(this, "Stop", 0);
					r_Stop.SetBelong(this.instance);
				}
				return r_Stop;
			}
		}

		/// <summary>
		/// Void Recycle()
		/// </summary>
		protected RMethod r_Recycle;
		public virtual RMethod RRecycle
		{
			get
			{
				if(r_Recycle == null)
				{
					r_Recycle = new(this, "Recycle", 0);
					r_Recycle.SetBelong(this.instance);
				}
				return r_Recycle;
			}
		}

		/// <summary>
		/// Void UnityEngine.UIElements.Experimental.IValueAnimationUpdate.Tick(Int64)
		/// </summary>
		protected RMethod r_UnityEngine__2__UIElements__2__Experimental__2__IValueAnimationUpdate__2__Tick_Int64;
		public virtual RMethod RUnityEngine__2__UIElements__2__Experimental__2__IValueAnimationUpdate__2__Tick_Int64
		{
			get
			{
				if(r_UnityEngine__2__UIElements__2__Experimental__2__IValueAnimationUpdate__2__Tick_Int64 == null)
				{
					r_UnityEngine__2__UIElements__2__Experimental__2__IValueAnimationUpdate__2__Tick_Int64 = new(this, "UnityEngine.UIElements.Experimental.IValueAnimationUpdate.Tick", 0, typeof(System.Int64));
					r_UnityEngine__2__UIElements__2__Experimental__2__IValueAnimationUpdate__2__Tick_Int64.SetBelong(this.instance);
				}
				return r_UnityEngine__2__UIElements__2__Experimental__2__IValueAnimationUpdate__2__Tick_Int64;
			}
		}

		/// <summary>
		/// Void SetDefaultValues()
		/// </summary>
		protected RMethod r_SetDefaultValues;
		public virtual RMethod RSetDefaultValues
		{
			get
			{
				if(r_SetDefaultValues == null)
				{
					r_SetDefaultValues = new(this, "SetDefaultValues", 0);
					r_SetDefaultValues.SetBelong(this.instance);
				}
				return r_SetDefaultValues;
			}
		}

		/// <summary>
		/// Void Unregister()
		/// </summary>
		protected RMethod r_Unregister;
		public virtual RMethod RUnregister
		{
			get
			{
				if(r_Unregister == null)
				{
					r_Unregister = new(this, "Unregister", 0);
					r_Unregister.SetBelong(this.instance);
				}
				return r_Unregister;
			}
		}

		/// <summary>
		/// Void Register()
		/// </summary>
		protected RMethod r_Register;
		public virtual RMethod RRegister
		{
			get
			{
				if(r_Register == null)
				{
					r_Register = new(this, "Register", 0);
					r_Register.SetBelong(this.instance);
				}
				return r_Register;
			}
		}

		/// <summary>
		/// Void SetOwner(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_SetOwner_VisualElement;
		public virtual RMethod RSetOwner_VisualElement
		{
			get
			{
				if(r_SetOwner_VisualElement == null)
				{
					r_SetOwner_VisualElement = new(this, "SetOwner", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_SetOwner_VisualElement.SetBelong(this.instance);
				}
				return r_SetOwner_VisualElement;
			}
		}

		/// <summary>
		/// Void CheckNotRecycled()
		/// </summary>
		protected RMethod r_CheckNotRecycled;
		public virtual RMethod RCheckNotRecycled
		{
			get
			{
				if(r_CheckNotRecycled == null)
				{
					r_CheckNotRecycled = new(this, "CheckNotRecycled", 0);
					r_CheckNotRecycled.SetBelong(this.instance);
				}
				return r_CheckNotRecycled;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[T] Create(UnityEngine.UIElements.VisualElement, System.Func`4[T,T,System.Single,T])
		/// </summary>
		protected static RMethod r_Create_VisualElement_Func_d_T_T_Single_T_p_;
		public static RMethod RCreate_VisualElement_Func_d_T_T_Single_T_p_
		{
			get
			{
				if(r_Create_VisualElement_Func_d_T_T_Single_T_p_ == null)
				{
					r_Create_VisualElement_Func_d_T_T_Single_T_p_ = new(typeof(UnityEngine.UIElements.Experimental.ValueAnimation<>), "Create", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(System.Func<, , , >).MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(0), typeof(System.Single), Type.MakeGenericMethodParameter(0)));
					r_Create_VisualElement_Func_d_T_T_Single_T_p_.SetBelong(null);
				}
				return r_Create_VisualElement_Func_d_T_T_Single_T_p_;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[T] Ease(System.Func`2[System.Single,System.Single])
		/// </summary>
		protected RMethod r_Ease_Func_d_Single_Single_p_;
		public virtual RMethod REase_Func_d_Single_Single_p_
		{
			get
			{
				if(r_Ease_Func_d_Single_Single_p_ == null)
				{
					r_Ease_Func_d_Single_Single_p_ = new(this, "Ease", 0, typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
					r_Ease_Func_d_Single_Single_p_.SetBelong(this.instance);
				}
				return r_Ease_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[T] OnCompleted(System.Action)
		/// </summary>
		protected RMethod r_OnCompleted_Action;
		public virtual RMethod ROnCompleted_Action
		{
			get
			{
				if(r_OnCompleted_Action == null)
				{
					r_OnCompleted_Action = new(this, "OnCompleted", 0, typeof(System.Action));
					r_OnCompleted_Action.SetBelong(this.instance);
				}
				return r_OnCompleted_Action;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[T] KeepAlive()
		/// </summary>
		protected RMethod r_KeepAlive;
		public virtual RMethod RKeepAlive
		{
			get
			{
				if(r_KeepAlive == null)
				{
					r_KeepAlive = new(this, "KeepAlive", 0);
					r_KeepAlive.SetBelong(this.instance);
				}
				return r_KeepAlive;
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


        public RValueAnimation() : base("UnityEngine.UIElements.Experimental.ValueAnimation`1")
        {
        }

        public RValueAnimation(System.Object instance) : base("UnityEngine.UIElements.Experimental.ValueAnimation`1")
		{
            SetInstance(instance);
		}

        public RValueAnimation(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RValueAnimation(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Start()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RStart.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Stop()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RStop.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Recycle()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRecycle.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnityEngine__2__UIElements__2__Experimental__2__IValueAnimationUpdate__2__Tick(System.Int64  @currentTimeMs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@currentTimeMs};
            var ___result = RUnityEngine__2__UIElements__2__Experimental__2__IValueAnimationUpdate__2__Tick_Int64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetDefaultValues()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSetDefaultValues.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Unregister()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUnregister.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Register()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRegister.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetOwner(UnityEngine.UIElements.VisualElement  @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RSetOwner_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CheckNotRecycled()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCheckNotRecycled.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.UIElements.Experimental.ValueAnimation<T> Create(UnityEngine.UIElements.VisualElement  @e, System.Func<T, T, System.Single, T>  @interpolator)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e, @interpolator};
            var ___result = RCreate_VisualElement_Func_d_T_T_Single_T_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<T>)___result;
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<T> Ease(System.Func<System.Single, System.Single>  @easing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@easing};
            var ___result = REase_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<T>)___result;
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<T> OnCompleted(System.Action  @callback)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@callback};
            var ___result = ROnCompleted_Action.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<T>)___result;
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<T> KeepAlive()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RKeepAlive.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<T>)___result;
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
