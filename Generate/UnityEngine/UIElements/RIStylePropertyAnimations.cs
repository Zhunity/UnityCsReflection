using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.IStylePropertyAnimations
	/// </summary>
    public partial class RIStylePropertyAnimations : RMember //
    {

		/// <summary>
		/// Int32 runningAnimationCount
		/// </summary>
		protected RProperty r_runningAnimationCount;
		public virtual RProperty RrunningAnimationCount
		{
			get
			{
				if(r_runningAnimationCount == null)
				{
					r_runningAnimationCount = new(this, "runningAnimationCount", -1);
					r_runningAnimationCount.SetBelong(this.instance);
				}
				return r_runningAnimationCount;
			}
		}

		/// <summary>
		/// Int32 completedAnimationCount
		/// </summary>
		protected RProperty r_completedAnimationCount;
		public virtual RProperty RcompletedAnimationCount
		{
			get
			{
				if(r_completedAnimationCount == null)
				{
					r_completedAnimationCount = new(this, "completedAnimationCount", -1);
					r_completedAnimationCount.SetBelong(this.instance);
				}
				return r_completedAnimationCount;
			}
		}

		/// <summary>
		/// Boolean Start(UnityEngine.UIElements.StyleSheets.StylePropertyId, Single, Single, Int32, Int32, System.Func`2[System.Single,System.Single])
		/// </summary>
		protected RMethod r_Start_StylePropertyId_Single_Single_Int32_Int32_Func_d_Single_Single_p_;
		public virtual RMethod RStart_StylePropertyId_Single_Single_Int32_Int32_Func_d_Single_Single_p_
		{
			get
			{
				if(r_Start_StylePropertyId_Single_Single_Int32_Int32_Func_d_Single_Single_p_ == null)
				{
					r_Start_StylePropertyId_Single_Single_Int32_Int32_Func_d_Single_Single_p_ = new(this, "Start", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(System.Single), typeof(System.Single), typeof(System.Int32), typeof(System.Int32), typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
					r_Start_StylePropertyId_Single_Single_Int32_Int32_Func_d_Single_Single_p_.SetBelong(this.instance);
				}
				return r_Start_StylePropertyId_Single_Single_Int32_Int32_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// Boolean Start(UnityEngine.UIElements.StyleSheets.StylePropertyId, Int32, Int32, Int32, Int32, System.Func`2[System.Single,System.Single])
		/// </summary>
		protected RMethod r_Start_StylePropertyId_Int32_Int32_Int32_Int32_Func_d_Single_Single_p_;
		public virtual RMethod RStart_StylePropertyId_Int32_Int32_Int32_Int32_Func_d_Single_Single_p_
		{
			get
			{
				if(r_Start_StylePropertyId_Int32_Int32_Int32_Int32_Func_d_Single_Single_p_ == null)
				{
					r_Start_StylePropertyId_Int32_Int32_Int32_Int32_Func_d_Single_Single_p_ = new(this, "Start", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
					r_Start_StylePropertyId_Int32_Int32_Int32_Int32_Func_d_Single_Single_p_.SetBelong(this.instance);
				}
				return r_Start_StylePropertyId_Int32_Int32_Int32_Int32_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// Boolean Start(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.Length, UnityEngine.UIElements.Length, Int32, Int32, System.Func`2[System.Single,System.Single])
		/// </summary>
		protected RMethod r_Start_StylePropertyId_Length_Length_Int32_Int32_Func_d_Single_Single_p_;
		public virtual RMethod RStart_StylePropertyId_Length_Length_Int32_Int32_Func_d_Single_Single_p_
		{
			get
			{
				if(r_Start_StylePropertyId_Length_Length_Int32_Int32_Func_d_Single_Single_p_ == null)
				{
					r_Start_StylePropertyId_Length_Length_Int32_Int32_Func_d_Single_Single_p_ = new(this, "Start", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.Length), typeof(UnityEngine.UIElements.Length), typeof(System.Int32), typeof(System.Int32), typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
					r_Start_StylePropertyId_Length_Length_Int32_Int32_Func_d_Single_Single_p_.SetBelong(this.instance);
				}
				return r_Start_StylePropertyId_Length_Length_Int32_Int32_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// Boolean Start(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.Color, UnityEngine.Color, Int32, Int32, System.Func`2[System.Single,System.Single])
		/// </summary>
		protected RMethod r_Start_StylePropertyId_Color_Color_Int32_Int32_Func_d_Single_Single_p_;
		public virtual RMethod RStart_StylePropertyId_Color_Color_Int32_Int32_Func_d_Single_Single_p_
		{
			get
			{
				if(r_Start_StylePropertyId_Color_Color_Int32_Int32_Func_d_Single_Single_p_ == null)
				{
					r_Start_StylePropertyId_Color_Color_Int32_Int32_Func_d_Single_Single_p_ = new(this, "Start", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.Color), typeof(UnityEngine.Color), typeof(System.Int32), typeof(System.Int32), typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
					r_Start_StylePropertyId_Color_Color_Int32_Int32_Func_d_Single_Single_p_.SetBelong(this.instance);
				}
				return r_Start_StylePropertyId_Color_Color_Int32_Int32_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// Boolean StartEnum(UnityEngine.UIElements.StyleSheets.StylePropertyId, Int32, Int32, Int32, Int32, System.Func`2[System.Single,System.Single])
		/// </summary>
		protected RMethod r_StartEnum_StylePropertyId_Int32_Int32_Int32_Int32_Func_d_Single_Single_p_;
		public virtual RMethod RStartEnum_StylePropertyId_Int32_Int32_Int32_Int32_Func_d_Single_Single_p_
		{
			get
			{
				if(r_StartEnum_StylePropertyId_Int32_Int32_Int32_Int32_Func_d_Single_Single_p_ == null)
				{
					r_StartEnum_StylePropertyId_Int32_Int32_Int32_Int32_Func_d_Single_Single_p_ = new(this, "StartEnum", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
					r_StartEnum_StylePropertyId_Int32_Int32_Int32_Int32_Func_d_Single_Single_p_.SetBelong(this.instance);
				}
				return r_StartEnum_StylePropertyId_Int32_Int32_Int32_Int32_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// Boolean Start(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.Background, UnityEngine.UIElements.Background, Int32, Int32, System.Func`2[System.Single,System.Single])
		/// </summary>
		protected RMethod r_Start_StylePropertyId_Background_Background_Int32_Int32_Func_d_Single_Single_p_;
		public virtual RMethod RStart_StylePropertyId_Background_Background_Int32_Int32_Func_d_Single_Single_p_
		{
			get
			{
				if(r_Start_StylePropertyId_Background_Background_Int32_Int32_Func_d_Single_Single_p_ == null)
				{
					r_Start_StylePropertyId_Background_Background_Int32_Int32_Func_d_Single_Single_p_ = new(this, "Start", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.Background), typeof(UnityEngine.UIElements.Background), typeof(System.Int32), typeof(System.Int32), typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
					r_Start_StylePropertyId_Background_Background_Int32_Int32_Func_d_Single_Single_p_.SetBelong(this.instance);
				}
				return r_Start_StylePropertyId_Background_Background_Int32_Int32_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// Boolean Start(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.FontDefinition, UnityEngine.UIElements.FontDefinition, Int32, Int32, System.Func`2[System.Single,System.Single])
		/// </summary>
		protected RMethod r_Start_StylePropertyId_FontDefinition_FontDefinition_Int32_Int32_Func_d_Single_Single_p_;
		public virtual RMethod RStart_StylePropertyId_FontDefinition_FontDefinition_Int32_Int32_Func_d_Single_Single_p_
		{
			get
			{
				if(r_Start_StylePropertyId_FontDefinition_FontDefinition_Int32_Int32_Func_d_Single_Single_p_ == null)
				{
					r_Start_StylePropertyId_FontDefinition_FontDefinition_Int32_Int32_Func_d_Single_Single_p_ = new(this, "Start", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.FontDefinition), typeof(UnityEngine.UIElements.FontDefinition), typeof(System.Int32), typeof(System.Int32), typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
					r_Start_StylePropertyId_FontDefinition_FontDefinition_Int32_Int32_Func_d_Single_Single_p_.SetBelong(this.instance);
				}
				return r_Start_StylePropertyId_FontDefinition_FontDefinition_Int32_Int32_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// Boolean Start(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.Font, UnityEngine.Font, Int32, Int32, System.Func`2[System.Single,System.Single])
		/// </summary>
		protected RMethod r_Start_StylePropertyId_Font_Font_Int32_Int32_Func_d_Single_Single_p_;
		public virtual RMethod RStart_StylePropertyId_Font_Font_Int32_Int32_Func_d_Single_Single_p_
		{
			get
			{
				if(r_Start_StylePropertyId_Font_Font_Int32_Int32_Func_d_Single_Single_p_ == null)
				{
					r_Start_StylePropertyId_Font_Font_Int32_Int32_Func_d_Single_Single_p_ = new(this, "Start", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.Font), typeof(UnityEngine.Font), typeof(System.Int32), typeof(System.Int32), typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
					r_Start_StylePropertyId_Font_Font_Int32_Int32_Func_d_Single_Single_p_.SetBelong(this.instance);
				}
				return r_Start_StylePropertyId_Font_Font_Int32_Int32_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// Boolean Start(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.TextShadow, UnityEngine.UIElements.TextShadow, Int32, Int32, System.Func`2[System.Single,System.Single])
		/// </summary>
		protected RMethod r_Start_StylePropertyId_TextShadow_TextShadow_Int32_Int32_Func_d_Single_Single_p_;
		public virtual RMethod RStart_StylePropertyId_TextShadow_TextShadow_Int32_Int32_Func_d_Single_Single_p_
		{
			get
			{
				if(r_Start_StylePropertyId_TextShadow_TextShadow_Int32_Int32_Func_d_Single_Single_p_ == null)
				{
					r_Start_StylePropertyId_TextShadow_TextShadow_Int32_Int32_Func_d_Single_Single_p_ = new(this, "Start", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.TextShadow), typeof(UnityEngine.UIElements.TextShadow), typeof(System.Int32), typeof(System.Int32), typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
					r_Start_StylePropertyId_TextShadow_TextShadow_Int32_Int32_Func_d_Single_Single_p_.SetBelong(this.instance);
				}
				return r_Start_StylePropertyId_TextShadow_TextShadow_Int32_Int32_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// Boolean Start(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.Scale, UnityEngine.UIElements.Scale, Int32, Int32, System.Func`2[System.Single,System.Single])
		/// </summary>
		protected RMethod r_Start_StylePropertyId_Scale_Scale_Int32_Int32_Func_d_Single_Single_p_;
		public virtual RMethod RStart_StylePropertyId_Scale_Scale_Int32_Int32_Func_d_Single_Single_p_
		{
			get
			{
				if(r_Start_StylePropertyId_Scale_Scale_Int32_Int32_Func_d_Single_Single_p_ == null)
				{
					r_Start_StylePropertyId_Scale_Scale_Int32_Int32_Func_d_Single_Single_p_ = new(this, "Start", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.Scale), typeof(UnityEngine.UIElements.Scale), typeof(System.Int32), typeof(System.Int32), typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
					r_Start_StylePropertyId_Scale_Scale_Int32_Int32_Func_d_Single_Single_p_.SetBelong(this.instance);
				}
				return r_Start_StylePropertyId_Scale_Scale_Int32_Int32_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// Boolean Start(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.Translate, UnityEngine.UIElements.Translate, Int32, Int32, System.Func`2[System.Single,System.Single])
		/// </summary>
		protected RMethod r_Start_StylePropertyId_Translate_Translate_Int32_Int32_Func_d_Single_Single_p_;
		public virtual RMethod RStart_StylePropertyId_Translate_Translate_Int32_Int32_Func_d_Single_Single_p_
		{
			get
			{
				if(r_Start_StylePropertyId_Translate_Translate_Int32_Int32_Func_d_Single_Single_p_ == null)
				{
					r_Start_StylePropertyId_Translate_Translate_Int32_Int32_Func_d_Single_Single_p_ = new(this, "Start", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.Translate), typeof(UnityEngine.UIElements.Translate), typeof(System.Int32), typeof(System.Int32), typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
					r_Start_StylePropertyId_Translate_Translate_Int32_Int32_Func_d_Single_Single_p_.SetBelong(this.instance);
				}
				return r_Start_StylePropertyId_Translate_Translate_Int32_Int32_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// Boolean Start(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.Rotate, UnityEngine.UIElements.Rotate, Int32, Int32, System.Func`2[System.Single,System.Single])
		/// </summary>
		protected RMethod r_Start_StylePropertyId_Rotate_Rotate_Int32_Int32_Func_d_Single_Single_p_;
		public virtual RMethod RStart_StylePropertyId_Rotate_Rotate_Int32_Int32_Func_d_Single_Single_p_
		{
			get
			{
				if(r_Start_StylePropertyId_Rotate_Rotate_Int32_Int32_Func_d_Single_Single_p_ == null)
				{
					r_Start_StylePropertyId_Rotate_Rotate_Int32_Int32_Func_d_Single_Single_p_ = new(this, "Start", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.Rotate), typeof(UnityEngine.UIElements.Rotate), typeof(System.Int32), typeof(System.Int32), typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
					r_Start_StylePropertyId_Rotate_Rotate_Int32_Int32_Func_d_Single_Single_p_.SetBelong(this.instance);
				}
				return r_Start_StylePropertyId_Rotate_Rotate_Int32_Int32_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// Boolean Start(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.TransformOrigin, UnityEngine.UIElements.TransformOrigin, Int32, Int32, System.Func`2[System.Single,System.Single])
		/// </summary>
		protected RMethod r_Start_StylePropertyId_TransformOrigin_TransformOrigin_Int32_Int32_Func_d_Single_Single_p_;
		public virtual RMethod RStart_StylePropertyId_TransformOrigin_TransformOrigin_Int32_Int32_Func_d_Single_Single_p_
		{
			get
			{
				if(r_Start_StylePropertyId_TransformOrigin_TransformOrigin_Int32_Int32_Func_d_Single_Single_p_ == null)
				{
					r_Start_StylePropertyId_TransformOrigin_TransformOrigin_Int32_Int32_Func_d_Single_Single_p_ = new(this, "Start", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.TransformOrigin), typeof(UnityEngine.UIElements.TransformOrigin), typeof(System.Int32), typeof(System.Int32), typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
					r_Start_StylePropertyId_TransformOrigin_TransformOrigin_Int32_Int32_Func_d_Single_Single_p_.SetBelong(this.instance);
				}
				return r_Start_StylePropertyId_TransformOrigin_TransformOrigin_Int32_Int32_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// Boolean Start(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.BackgroundPosition, UnityEngine.UIElements.BackgroundPosition, Int32, Int32, System.Func`2[System.Single,System.Single])
		/// </summary>
		protected RMethod r_Start_StylePropertyId_BackgroundPosition_BackgroundPosition_Int32_Int32_Func_d_Single_Single_p_;
		public virtual RMethod RStart_StylePropertyId_BackgroundPosition_BackgroundPosition_Int32_Int32_Func_d_Single_Single_p_
		{
			get
			{
				if(r_Start_StylePropertyId_BackgroundPosition_BackgroundPosition_Int32_Int32_Func_d_Single_Single_p_ == null)
				{
					r_Start_StylePropertyId_BackgroundPosition_BackgroundPosition_Int32_Int32_Func_d_Single_Single_p_ = new(this, "Start", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.BackgroundPosition), typeof(UnityEngine.UIElements.BackgroundPosition), typeof(System.Int32), typeof(System.Int32), typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
					r_Start_StylePropertyId_BackgroundPosition_BackgroundPosition_Int32_Int32_Func_d_Single_Single_p_.SetBelong(this.instance);
				}
				return r_Start_StylePropertyId_BackgroundPosition_BackgroundPosition_Int32_Int32_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// Boolean Start(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.BackgroundRepeat, UnityEngine.UIElements.BackgroundRepeat, Int32, Int32, System.Func`2[System.Single,System.Single])
		/// </summary>
		protected RMethod r_Start_StylePropertyId_BackgroundRepeat_BackgroundRepeat_Int32_Int32_Func_d_Single_Single_p_;
		public virtual RMethod RStart_StylePropertyId_BackgroundRepeat_BackgroundRepeat_Int32_Int32_Func_d_Single_Single_p_
		{
			get
			{
				if(r_Start_StylePropertyId_BackgroundRepeat_BackgroundRepeat_Int32_Int32_Func_d_Single_Single_p_ == null)
				{
					r_Start_StylePropertyId_BackgroundRepeat_BackgroundRepeat_Int32_Int32_Func_d_Single_Single_p_ = new(this, "Start", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.BackgroundRepeat), typeof(UnityEngine.UIElements.BackgroundRepeat), typeof(System.Int32), typeof(System.Int32), typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
					r_Start_StylePropertyId_BackgroundRepeat_BackgroundRepeat_Int32_Int32_Func_d_Single_Single_p_.SetBelong(this.instance);
				}
				return r_Start_StylePropertyId_BackgroundRepeat_BackgroundRepeat_Int32_Int32_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// Boolean Start(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.BackgroundSize, UnityEngine.UIElements.BackgroundSize, Int32, Int32, System.Func`2[System.Single,System.Single])
		/// </summary>
		protected RMethod r_Start_StylePropertyId_BackgroundSize_BackgroundSize_Int32_Int32_Func_d_Single_Single_p_;
		public virtual RMethod RStart_StylePropertyId_BackgroundSize_BackgroundSize_Int32_Int32_Func_d_Single_Single_p_
		{
			get
			{
				if(r_Start_StylePropertyId_BackgroundSize_BackgroundSize_Int32_Int32_Func_d_Single_Single_p_ == null)
				{
					r_Start_StylePropertyId_BackgroundSize_BackgroundSize_Int32_Int32_Func_d_Single_Single_p_ = new(this, "Start", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.BackgroundSize), typeof(UnityEngine.UIElements.BackgroundSize), typeof(System.Int32), typeof(System.Int32), typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
					r_Start_StylePropertyId_BackgroundSize_BackgroundSize_Int32_Int32_Func_d_Single_Single_p_.SetBelong(this.instance);
				}
				return r_Start_StylePropertyId_BackgroundSize_BackgroundSize_Int32_Int32_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// Boolean HasRunningAnimation(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_HasRunningAnimation_StylePropertyId;
		public virtual RMethod RHasRunningAnimation_StylePropertyId
		{
			get
			{
				if(r_HasRunningAnimation_StylePropertyId == null)
				{
					r_HasRunningAnimation_StylePropertyId = new(this, "HasRunningAnimation", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
					r_HasRunningAnimation_StylePropertyId.SetBelong(this.instance);
				}
				return r_HasRunningAnimation_StylePropertyId;
			}
		}

		/// <summary>
		/// Void UpdateAnimation(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_UpdateAnimation_StylePropertyId;
		public virtual RMethod RUpdateAnimation_StylePropertyId
		{
			get
			{
				if(r_UpdateAnimation_StylePropertyId == null)
				{
					r_UpdateAnimation_StylePropertyId = new(this, "UpdateAnimation", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
					r_UpdateAnimation_StylePropertyId.SetBelong(this.instance);
				}
				return r_UpdateAnimation_StylePropertyId;
			}
		}

		/// <summary>
		/// Void GetAllAnimations(System.Collections.Generic.List`1[UnityEngine.UIElements.StyleSheets.StylePropertyId])
		/// </summary>
		protected RMethod r_GetAllAnimations_List_d_StylePropertyId_p_;
		public virtual RMethod RGetAllAnimations_List_d_StylePropertyId_p_
		{
			get
			{
				if(r_GetAllAnimations_List_d_StylePropertyId_p_ == null)
				{
					r_GetAllAnimations_List_d_StylePropertyId_p_ = new(this, "GetAllAnimations", 0, typeof(System.Collections.Generic.List<>).MakeGenericType( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId")));
					r_GetAllAnimations_List_d_StylePropertyId_p_.SetBelong(this.instance);
				}
				return r_GetAllAnimations_List_d_StylePropertyId_p_;
			}
		}

		/// <summary>
		/// Void CancelAnimation(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_CancelAnimation_StylePropertyId;
		public virtual RMethod RCancelAnimation_StylePropertyId
		{
			get
			{
				if(r_CancelAnimation_StylePropertyId == null)
				{
					r_CancelAnimation_StylePropertyId = new(this, "CancelAnimation", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
					r_CancelAnimation_StylePropertyId.SetBelong(this.instance);
				}
				return r_CancelAnimation_StylePropertyId;
			}
		}

		/// <summary>
		/// Void CancelAllAnimations()
		/// </summary>
		protected RMethod r_CancelAllAnimations;
		public virtual RMethod RCancelAllAnimations
		{
			get
			{
				if(r_CancelAllAnimations == null)
				{
					r_CancelAllAnimations = new(this, "CancelAllAnimations", 0);
					r_CancelAllAnimations.SetBelong(this.instance);
				}
				return r_CancelAllAnimations;
			}
		}


        public RIStylePropertyAnimations() : base("UnityEngine.UIElements.IStylePropertyAnimations")
        {
        }

        public RIStylePropertyAnimations(System.Object instance) : base("UnityEngine.UIElements.IStylePropertyAnimations")
		{
            SetInstance(instance);
		}

        public RIStylePropertyAnimations(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIStylePropertyAnimations(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Start(RType  @id, System.Single  @from, System.Single  @to, System.Int32  @durationMs, System.Int32  @delayMs, System.Func<System.Single, System.Single>  @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @from, @to, @durationMs, @delayMs, @easingCurve};
            var ___result = RStart_StylePropertyId_Single_Single_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Start(RType  @id, System.Int32  @from, System.Int32  @to, System.Int32  @durationMs, System.Int32  @delayMs, System.Func<System.Single, System.Single>  @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @from, @to, @durationMs, @delayMs, @easingCurve};
            var ___result = RStart_StylePropertyId_Int32_Int32_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Start(RType  @id, UnityEngine.UIElements.Length  @from, UnityEngine.UIElements.Length  @to, System.Int32  @durationMs, System.Int32  @delayMs, System.Func<System.Single, System.Single>  @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @from, @to, @durationMs, @delayMs, @easingCurve};
            var ___result = RStart_StylePropertyId_Length_Length_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Start(RType  @id, UnityEngine.Color  @from, UnityEngine.Color  @to, System.Int32  @durationMs, System.Int32  @delayMs, System.Func<System.Single, System.Single>  @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @from, @to, @durationMs, @delayMs, @easingCurve};
            var ___result = RStart_StylePropertyId_Color_Color_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean StartEnum(RType  @id, System.Int32  @from, System.Int32  @to, System.Int32  @durationMs, System.Int32  @delayMs, System.Func<System.Single, System.Single>  @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @from, @to, @durationMs, @delayMs, @easingCurve};
            var ___result = RStartEnum_StylePropertyId_Int32_Int32_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Start(RType  @id, UnityEngine.UIElements.Background  @from, UnityEngine.UIElements.Background  @to, System.Int32  @durationMs, System.Int32  @delayMs, System.Func<System.Single, System.Single>  @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @from, @to, @durationMs, @delayMs, @easingCurve};
            var ___result = RStart_StylePropertyId_Background_Background_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Start(RType  @id, UnityEngine.UIElements.FontDefinition  @from, UnityEngine.UIElements.FontDefinition  @to, System.Int32  @durationMs, System.Int32  @delayMs, System.Func<System.Single, System.Single>  @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @from, @to, @durationMs, @delayMs, @easingCurve};
            var ___result = RStart_StylePropertyId_FontDefinition_FontDefinition_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Start(RType  @id, UnityEngine.Font  @from, UnityEngine.Font  @to, System.Int32  @durationMs, System.Int32  @delayMs, System.Func<System.Single, System.Single>  @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @from, @to, @durationMs, @delayMs, @easingCurve};
            var ___result = RStart_StylePropertyId_Font_Font_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Start(RType  @id, UnityEngine.UIElements.TextShadow  @from, UnityEngine.UIElements.TextShadow  @to, System.Int32  @durationMs, System.Int32  @delayMs, System.Func<System.Single, System.Single>  @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @from, @to, @durationMs, @delayMs, @easingCurve};
            var ___result = RStart_StylePropertyId_TextShadow_TextShadow_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Start(RType  @id, UnityEngine.UIElements.Scale  @from, UnityEngine.UIElements.Scale  @to, System.Int32  @durationMs, System.Int32  @delayMs, System.Func<System.Single, System.Single>  @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @from, @to, @durationMs, @delayMs, @easingCurve};
            var ___result = RStart_StylePropertyId_Scale_Scale_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Start(RType  @id, UnityEngine.UIElements.Translate  @from, UnityEngine.UIElements.Translate  @to, System.Int32  @durationMs, System.Int32  @delayMs, System.Func<System.Single, System.Single>  @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @from, @to, @durationMs, @delayMs, @easingCurve};
            var ___result = RStart_StylePropertyId_Translate_Translate_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Start(RType  @id, UnityEngine.UIElements.Rotate  @from, UnityEngine.UIElements.Rotate  @to, System.Int32  @durationMs, System.Int32  @delayMs, System.Func<System.Single, System.Single>  @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @from, @to, @durationMs, @delayMs, @easingCurve};
            var ___result = RStart_StylePropertyId_Rotate_Rotate_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Start(RType  @id, UnityEngine.UIElements.TransformOrigin  @from, UnityEngine.UIElements.TransformOrigin  @to, System.Int32  @durationMs, System.Int32  @delayMs, System.Func<System.Single, System.Single>  @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @from, @to, @durationMs, @delayMs, @easingCurve};
            var ___result = RStart_StylePropertyId_TransformOrigin_TransformOrigin_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Start(RType  @id, UnityEngine.UIElements.BackgroundPosition  @from, UnityEngine.UIElements.BackgroundPosition  @to, System.Int32  @durationMs, System.Int32  @delayMs, System.Func<System.Single, System.Single>  @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @from, @to, @durationMs, @delayMs, @easingCurve};
            var ___result = RStart_StylePropertyId_BackgroundPosition_BackgroundPosition_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Start(RType  @id, UnityEngine.UIElements.BackgroundRepeat  @from, UnityEngine.UIElements.BackgroundRepeat  @to, System.Int32  @durationMs, System.Int32  @delayMs, System.Func<System.Single, System.Single>  @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @from, @to, @durationMs, @delayMs, @easingCurve};
            var ___result = RStart_StylePropertyId_BackgroundRepeat_BackgroundRepeat_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Start(RType  @id, UnityEngine.UIElements.BackgroundSize  @from, UnityEngine.UIElements.BackgroundSize  @to, System.Int32  @durationMs, System.Int32  @delayMs, System.Func<System.Single, System.Single>  @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @from, @to, @durationMs, @delayMs, @easingCurve};
            var ___result = RStart_StylePropertyId_BackgroundSize_BackgroundSize_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasRunningAnimation(RType  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value};
            var ___result = RHasRunningAnimation_StylePropertyId.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void UpdateAnimation(RType  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value};
            var ___result = RUpdateAnimation_StylePropertyId.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetAllAnimations(RSystem.RCollections.RGeneric.RList<RType>  @outPropertyIds)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@outPropertyIds.Value};
            var ___result = RGetAllAnimations_List_d_StylePropertyId_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CancelAnimation(RType  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value};
            var ___result = RCancelAnimation_StylePropertyId.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CancelAllAnimations()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCancelAllAnimations.Invoke(___genericsType, ___parameters);

            
        }


    }
}
