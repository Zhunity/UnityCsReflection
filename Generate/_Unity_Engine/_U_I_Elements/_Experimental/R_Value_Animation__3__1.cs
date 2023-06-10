
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RExperimental
{
	/// <summary>
	/// UnityEngine.UIElements.Experimental.ValueAnimation`1
	/// </summary>
    public partial class RValueAnimation<T> : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.UIElements.Experimental.ValueAnimation<>);
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


		/// <summary>
		/// System.Int32 k_DefaultDurationMs
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_Fk_DefaultDurationMs;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFk_DefaultDurationMs
		{
			get
			{
				if(r_Fk_DefaultDurationMs == null)
				{
					r_Fk_DefaultDurationMs = new(typeof(UnityEngine.UIElements.Experimental.ValueAnimation<>), "k_DefaultDurationMs");
				}
				return r_Fk_DefaultDurationMs;
			}
		}

		/// <summary>
		/// System.Int32 k_DefaultMaxPoolSize
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_Fk_DefaultMaxPoolSize;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFk_DefaultMaxPoolSize
		{
			get
			{
				if(r_Fk_DefaultMaxPoolSize == null)
				{
					r_Fk_DefaultMaxPoolSize = new(typeof(UnityEngine.UIElements.Experimental.ValueAnimation<>), "k_DefaultMaxPoolSize");
				}
				return r_Fk_DefaultMaxPoolSize;
			}
		}

		/// <summary>
		/// System.Int64 m_StartTimeMs
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt64 r_Fm_StartTimeMs;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt64 RFm_StartTimeMs
		{
			get
			{
				if(r_Fm_StartTimeMs == null)
				{
					r_Fm_StartTimeMs = new(this, "m_StartTimeMs");
				}
				return r_Fm_StartTimeMs;
			}
		}

		/// <summary>
		/// System.Int32 m_DurationMs
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_DurationMs;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_DurationMs
		{
			get
			{
				if(r_Fm_DurationMs == null)
				{
					r_Fm_DurationMs = new(this, "m_DurationMs");
				}
				return r_Fm_DurationMs;
			}
		}

		/// <summary>
		/// System.Func`2[System.Single,System.Single] <easingCurve>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RFunc<Hvak.Editor.Refleaction.RSystem.RSingle, Hvak.Editor.Refleaction.RSystem.RSingle> r_F__0__easingCurve__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RFunc<Hvak.Editor.Refleaction.RSystem.RSingle, Hvak.Editor.Refleaction.RSystem.RSingle> RF__0__easingCurve__1__k__BackingField
		{
			get
			{
				if(r_F__0__easingCurve__1__k__BackingField == null)
				{
					r_F__0__easingCurve__1__k__BackingField = new(this, "<easingCurve>k__BackingField");
				}
				return r_F__0__easingCurve__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean <isRunning>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_F__0__isRunning__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RF__0__isRunning__1__k__BackingField
		{
			get
			{
				if(r_F__0__isRunning__1__k__BackingField == null)
				{
					r_F__0__isRunning__1__k__BackingField = new(this, "<isRunning>k__BackingField");
				}
				return r_F__0__isRunning__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Action <onAnimationCompleted>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction r_F__0__onAnimationCompleted__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction RF__0__onAnimationCompleted__1__k__BackingField
		{
			get
			{
				if(r_F__0__onAnimationCompleted__1__k__BackingField == null)
				{
					r_F__0__onAnimationCompleted__1__k__BackingField = new(this, "<onAnimationCompleted>k__BackingField");
				}
				return r_F__0__onAnimationCompleted__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean <autoRecycle>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_F__0__autoRecycle__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RF__0__autoRecycle__1__k__BackingField
		{
			get
			{
				if(r_F__0__autoRecycle__1__k__BackingField == null)
				{
					r_F__0__autoRecycle__1__k__BackingField = new(this, "<autoRecycle>k__BackingField");
				}
				return r_F__0__autoRecycle__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean <recycled>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_F__0__recycled__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RF__0__recycled__1__k__BackingField
		{
			get
			{
				if(r_F__0__recycled__1__k__BackingField == null)
				{
					r_F__0__recycled__1__k__BackingField = new(this, "<recycled>k__BackingField");
				}
				return r_F__0__recycled__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ObjectPool`1[UnityEngine.UIElements.Experimental.ValueAnimation`1[T]] sObjectPool
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RObjectPool<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RExperimental.RValueAnimation<Hvak.Editor.Refleaction.RField>> r_FsObjectPool;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RObjectPool<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RExperimental.RValueAnimation<Hvak.Editor.Refleaction.RField>> RFsObjectPool
		{
			get
			{
				if(r_FsObjectPool == null)
				{
					r_FsObjectPool = new(typeof(UnityEngine.UIElements.Experimental.ValueAnimation<>), "sObjectPool");
				}
				return r_FsObjectPool;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement <owner>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_F__0__owner__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RF__0__owner__1__k__BackingField
		{
			get
			{
				if(r_F__0__owner__1__k__BackingField == null)
				{
					r_F__0__owner__1__k__BackingField = new(this, "<owner>k__BackingField");
				}
				return r_F__0__owner__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Action`2[UnityEngine.UIElements.VisualElement,T] <valueUpdated>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement, Hvak.Editor.Refleaction.RField> r_F__0__valueUpdated__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement, Hvak.Editor.Refleaction.RField> RF__0__valueUpdated__1__k__BackingField
		{
			get
			{
				if(r_F__0__valueUpdated__1__k__BackingField == null)
				{
					r_F__0__valueUpdated__1__k__BackingField = new(this, "<valueUpdated>k__BackingField");
				}
				return r_F__0__valueUpdated__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Func`2[UnityEngine.UIElements.VisualElement,T] <initialValue>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RFunc<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement, Hvak.Editor.Refleaction.RField> r_F__0__initialValue__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RFunc<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement, Hvak.Editor.Refleaction.RField> RF__0__initialValue__1__k__BackingField
		{
			get
			{
				if(r_F__0__initialValue__1__k__BackingField == null)
				{
					r_F__0__initialValue__1__k__BackingField = new(this, "<initialValue>k__BackingField");
				}
				return r_F__0__initialValue__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Func`4[T,T,System.Single,T] <interpolator>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RFunc<Hvak.Editor.Refleaction.RField, Hvak.Editor.Refleaction.RField, Hvak.Editor.Refleaction.RSystem.RSingle, Hvak.Editor.Refleaction.RField> r_F__0__interpolator__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RFunc<Hvak.Editor.Refleaction.RField, Hvak.Editor.Refleaction.RField, Hvak.Editor.Refleaction.RSystem.RSingle, Hvak.Editor.Refleaction.RField> RF__0__interpolator__1__k__BackingField
		{
			get
			{
				if(r_F__0__interpolator__1__k__BackingField == null)
				{
					r_F__0__interpolator__1__k__BackingField = new(this, "<interpolator>k__BackingField");
				}
				return r_F__0__interpolator__1__k__BackingField;
			}
		}

		/// <summary>
		/// T _from
		/// </summary>
		protected Hvak.Editor.Refleaction.RField r_F_from;
		public virtual Hvak.Editor.Refleaction.RField RF_from
		{
			get
			{
				if(r_F_from == null)
				{
					r_F_from = new(this, "_from");
				}
				return r_F_from;
			}
		}

		/// <summary>
		/// System.Boolean fromValueSet
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FfromValueSet;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFfromValueSet
		{
			get
			{
				if(r_FfromValueSet == null)
				{
					r_FfromValueSet = new(this, "fromValueSet");
				}
				return r_FfromValueSet;
			}
		}

		/// <summary>
		/// T <to>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RField r_F__0__to__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RField RF__0__to__1__k__BackingField
		{
			get
			{
				if(r_F__0__to__1__k__BackingField == null)
				{
					r_F__0__to__1__k__BackingField = new(this, "<to>k__BackingField");
				}
				return r_F__0__to__1__k__BackingField;
			}
		}

		/// <summary>
		/// Int32 durationMs
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PdurationMs;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPdurationMs
		{
			get
			{
				if(r_PdurationMs == null)
				{
					r_PdurationMs = new(this, "durationMs", -1);
				}
				return r_PdurationMs;
			}
		}

		/// <summary>
		/// System.Func`2[System.Single,System.Single] easingCurve
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RFunc<Hvak.Editor.Refleaction.RSystem.RSingle, Hvak.Editor.Refleaction.RSystem.RSingle> r_PeasingCurve;
		public virtual Hvak.Editor.Refleaction.RSystem.RFunc<Hvak.Editor.Refleaction.RSystem.RSingle, Hvak.Editor.Refleaction.RSystem.RSingle> RPeasingCurve
		{
			get
			{
				if(r_PeasingCurve == null)
				{
					r_PeasingCurve = new(this, "easingCurve", -1);
				}
				return r_PeasingCurve;
			}
		}

		/// <summary>
		/// Boolean isRunning
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisRunning;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisRunning
		{
			get
			{
				if(r_PisRunning == null)
				{
					r_PisRunning = new(this, "isRunning", -1);
				}
				return r_PisRunning;
			}
		}

		/// <summary>
		/// System.Action onAnimationCompleted
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction r_PonAnimationCompleted;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction RPonAnimationCompleted
		{
			get
			{
				if(r_PonAnimationCompleted == null)
				{
					r_PonAnimationCompleted = new(this, "onAnimationCompleted", -1);
				}
				return r_PonAnimationCompleted;
			}
		}

		/// <summary>
		/// Boolean autoRecycle
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PautoRecycle;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPautoRecycle
		{
			get
			{
				if(r_PautoRecycle == null)
				{
					r_PautoRecycle = new(this, "autoRecycle", -1);
				}
				return r_PautoRecycle;
			}
		}

		/// <summary>
		/// Boolean recycled
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Precycled;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPrecycled
		{
			get
			{
				if(r_Precycled == null)
				{
					r_Precycled = new(this, "recycled", -1);
				}
				return r_Precycled;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement owner
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_Powner;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RPowner
		{
			get
			{
				if(r_Powner == null)
				{
					r_Powner = new(this, "owner", -1);
				}
				return r_Powner;
			}
		}

		/// <summary>
		/// System.Action`2[UnityEngine.UIElements.VisualElement,T] valueUpdated
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement, Hvak.Editor.Refleaction.RProperty> r_PvalueUpdated;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement, Hvak.Editor.Refleaction.RProperty> RPvalueUpdated
		{
			get
			{
				if(r_PvalueUpdated == null)
				{
					r_PvalueUpdated = new(this, "valueUpdated", -1);
				}
				return r_PvalueUpdated;
			}
		}

		/// <summary>
		/// System.Func`2[UnityEngine.UIElements.VisualElement,T] initialValue
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RFunc<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement, Hvak.Editor.Refleaction.RProperty> r_PinitialValue;
		public virtual Hvak.Editor.Refleaction.RSystem.RFunc<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement, Hvak.Editor.Refleaction.RProperty> RPinitialValue
		{
			get
			{
				if(r_PinitialValue == null)
				{
					r_PinitialValue = new(this, "initialValue", -1);
				}
				return r_PinitialValue;
			}
		}

		/// <summary>
		/// System.Func`4[T,T,System.Single,T] interpolator
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RFunc<Hvak.Editor.Refleaction.RProperty, Hvak.Editor.Refleaction.RProperty, Hvak.Editor.Refleaction.RSystem.RSingle, Hvak.Editor.Refleaction.RProperty> r_Pinterpolator;
		public virtual Hvak.Editor.Refleaction.RSystem.RFunc<Hvak.Editor.Refleaction.RProperty, Hvak.Editor.Refleaction.RProperty, Hvak.Editor.Refleaction.RSystem.RSingle, Hvak.Editor.Refleaction.RProperty> RPinterpolator
		{
			get
			{
				if(r_Pinterpolator == null)
				{
					r_Pinterpolator = new(this, "interpolator", -1);
				}
				return r_Pinterpolator;
			}
		}

		/// <summary>
		/// T from
		/// </summary>
		protected Hvak.Editor.Refleaction.RProperty r_Pfrom;
		public virtual Hvak.Editor.Refleaction.RProperty RPfrom
		{
			get
			{
				if(r_Pfrom == null)
				{
					r_Pfrom = new(this, "from", -1);
				}
				return r_Pfrom;
			}
		}

		/// <summary>
		/// T to
		/// </summary>
		protected Hvak.Editor.Refleaction.RProperty r_Pto;
		public virtual Hvak.Editor.Refleaction.RProperty RPto
		{
			get
			{
				if(r_Pto == null)
				{
					r_Pto = new(this, "to", -1);
				}
				return r_Pto;
			}
		}

		/// <summary>
		/// Void Start()
		/// </summary>
		protected RMethod r_MStart;
		public virtual RMethod RMStart
		{
			get
			{
				if(r_MStart == null)
				{
					r_MStart = new(this, "Start", 0);
				}
				return r_MStart;
			}
		}

		/// <summary>
		/// Void Stop()
		/// </summary>
		protected RMethod r_MStop;
		public virtual RMethod RMStop
		{
			get
			{
				if(r_MStop == null)
				{
					r_MStop = new(this, "Stop", 0);
				}
				return r_MStop;
			}
		}

		/// <summary>
		/// Void Recycle()
		/// </summary>
		protected RMethod r_MRecycle;
		public virtual RMethod RMRecycle
		{
			get
			{
				if(r_MRecycle == null)
				{
					r_MRecycle = new(this, "Recycle", 0);
				}
				return r_MRecycle;
			}
		}

		/// <summary>
		/// Void UnityEngine.UIElements.Experimental.IValueAnimationUpdate.Tick(Int64)
		/// </summary>
		protected RMethod r_MUnityEngine__2__UIElements__2__Experimental__2__IValueAnimationUpdate__2__Tick_Int64;
		public virtual RMethod RMUnityEngine__2__UIElements__2__Experimental__2__IValueAnimationUpdate__2__Tick_Int64
		{
			get
			{
				if(r_MUnityEngine__2__UIElements__2__Experimental__2__IValueAnimationUpdate__2__Tick_Int64 == null)
				{
					r_MUnityEngine__2__UIElements__2__Experimental__2__IValueAnimationUpdate__2__Tick_Int64 = new(this, "UnityEngine.UIElements.Experimental.IValueAnimationUpdate.Tick", 0, typeof(System.Int64));
				}
				return r_MUnityEngine__2__UIElements__2__Experimental__2__IValueAnimationUpdate__2__Tick_Int64;
			}
		}

		/// <summary>
		/// Void SetDefaultValues()
		/// </summary>
		protected RMethod r_MSetDefaultValues;
		public virtual RMethod RMSetDefaultValues
		{
			get
			{
				if(r_MSetDefaultValues == null)
				{
					r_MSetDefaultValues = new(this, "SetDefaultValues", 0);
				}
				return r_MSetDefaultValues;
			}
		}

		/// <summary>
		/// Void Unregister()
		/// </summary>
		protected RMethod r_MUnregister;
		public virtual RMethod RMUnregister
		{
			get
			{
				if(r_MUnregister == null)
				{
					r_MUnregister = new(this, "Unregister", 0);
				}
				return r_MUnregister;
			}
		}

		/// <summary>
		/// Void Register()
		/// </summary>
		protected RMethod r_MRegister;
		public virtual RMethod RMRegister
		{
			get
			{
				if(r_MRegister == null)
				{
					r_MRegister = new(this, "Register", 0);
				}
				return r_MRegister;
			}
		}

		/// <summary>
		/// Void SetOwner(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MSetOwner_VisualElement;
		public virtual RMethod RMSetOwner_VisualElement
		{
			get
			{
				if(r_MSetOwner_VisualElement == null)
				{
					r_MSetOwner_VisualElement = new(this, "SetOwner", 0, typeof(UnityEngine.UIElements.VisualElement));
				}
				return r_MSetOwner_VisualElement;
			}
		}

		/// <summary>
		/// Void CheckNotRecycled()
		/// </summary>
		protected RMethod r_MCheckNotRecycled;
		public virtual RMethod RMCheckNotRecycled
		{
			get
			{
				if(r_MCheckNotRecycled == null)
				{
					r_MCheckNotRecycled = new(this, "CheckNotRecycled", 0);
				}
				return r_MCheckNotRecycled;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[T] Create(UnityEngine.UIElements.VisualElement, System.Func`4[T,T,System.Single,T])
		/// </summary>
		protected static RMethod r_MCreate_VisualElement_Func_d_T_T_Single_T_p_;
		public static RMethod RMCreate_VisualElement_Func_d_T_T_Single_T_p_
		{
			get
			{
				if(r_MCreate_VisualElement_Func_d_T_T_Single_T_p_ == null)
				{
					r_MCreate_VisualElement_Func_d_T_T_Single_T_p_ = new(typeof(UnityEngine.UIElements.Experimental.ValueAnimation<>), "Create", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(System.Func<, , , >).MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(0), typeof(System.Single), Type.MakeGenericMethodParameter(0)));
				}
				return r_MCreate_VisualElement_Func_d_T_T_Single_T_p_;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[T] Ease(System.Func`2[System.Single,System.Single])
		/// </summary>
		protected RMethod r_MEase_Func_d_Single_Single_p_;
		public virtual RMethod RMEase_Func_d_Single_Single_p_
		{
			get
			{
				if(r_MEase_Func_d_Single_Single_p_ == null)
				{
					r_MEase_Func_d_Single_Single_p_ = new(this, "Ease", 0, typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
				}
				return r_MEase_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[T] OnCompleted(System.Action)
		/// </summary>
		protected RMethod r_MOnCompleted_Action;
		public virtual RMethod RMOnCompleted_Action
		{
			get
			{
				if(r_MOnCompleted_Action == null)
				{
					r_MOnCompleted_Action = new(this, "OnCompleted", 0, typeof(System.Action));
				}
				return r_MOnCompleted_Action;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[T] KeepAlive()
		/// </summary>
		protected RMethod r_MKeepAlive;
		public virtual RMethod RMKeepAlive
		{
			get
			{
				if(r_MKeepAlive == null)
				{
					r_MKeepAlive = new(this, "KeepAlive", 0);
				}
				return r_MKeepAlive;
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


        public virtual void Start()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMStart.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Stop()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMStop.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Recycle()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRecycle.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnityEngine__2__UIElements__2__Experimental__2__IValueAnimationUpdate__2__Tick(System.Int64 @currentTimeMs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@currentTimeMs};
            var ___result = RMUnityEngine__2__UIElements__2__Experimental__2__IValueAnimationUpdate__2__Tick_Int64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetDefaultValues()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSetDefaultValues.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Unregister()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUnregister.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Register()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRegister.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetOwner(UnityEngine.UIElements.VisualElement @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RMSetOwner_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CheckNotRecycled()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCheckNotRecycled.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.UIElements.Experimental.ValueAnimation<T> Create(UnityEngine.UIElements.VisualElement @e, System.Func<T, T, System.Single, T> @interpolator)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e, @interpolator};
            var ___result = RMCreate_VisualElement_Func_d_T_T_Single_T_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<T>)___result;
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<T> Ease(System.Func<System.Single, System.Single> @easing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@easing};
            var ___result = RMEase_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<T>)___result;
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<T> OnCompleted(System.Action @callback)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@callback};
            var ___result = RMOnCompleted_Action.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<T>)___result;
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<T> KeepAlive()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMKeepAlive.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<T>)___result;
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
