
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RExperimental
{
	/// <summary>
	/// UnityEngine.UIElements.Experimental.ITransitionAnimations
	/// </summary>
    public partial class RITransitionAnimations : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.UIElements.Experimental.ITransitionAnimations);
            }
        }

        public RITransitionAnimations() : base("UnityEngine.UIElements.Experimental.ITransitionAnimations")
        {
        }

        public RITransitionAnimations(System.Object instance) : base("UnityEngine.UIElements.Experimental.ITransitionAnimations")
		{
            SetInstance(instance);
		}

        public RITransitionAnimations(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RITransitionAnimations(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[System.Single] Start(Single, Single, Int32, System.Action`2[UnityEngine.UIElements.VisualElement,System.Single])
		/// </summary>
		protected RMethod r_MStart_Single_Single_Int32_Action_d_VisualElement_Single_p_;
		public virtual RMethod RMStart_Single_Single_Int32_Action_d_VisualElement_Single_p_
		{
			get
			{
				if(r_MStart_Single_Single_Int32_Action_d_VisualElement_Single_p_ == null)
				{
					r_MStart_Single_Single_Int32_Action_d_VisualElement_Single_p_ = new(this, "Start", 0, typeof(System.Single), typeof(System.Single), typeof(System.Int32), typeof(System.Action<, >).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(System.Single)));
				}
				return r_MStart_Single_Single_Int32_Action_d_VisualElement_Single_p_;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[UnityEngine.Rect] Start(UnityEngine.Rect, UnityEngine.Rect, Int32, System.Action`2[UnityEngine.UIElements.VisualElement,UnityEngine.Rect])
		/// </summary>
		protected RMethod r_MStart_Rect_Rect_Int32_Action_d_VisualElement_Rect_p_;
		public virtual RMethod RMStart_Rect_Rect_Int32_Action_d_VisualElement_Rect_p_
		{
			get
			{
				if(r_MStart_Rect_Rect_Int32_Action_d_VisualElement_Rect_p_ == null)
				{
					r_MStart_Rect_Rect_Int32_Action_d_VisualElement_Rect_p_ = new(this, "Start", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Rect), typeof(System.Int32), typeof(System.Action<, >).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Rect)));
				}
				return r_MStart_Rect_Rect_Int32_Action_d_VisualElement_Rect_p_;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[UnityEngine.Color] Start(UnityEngine.Color, UnityEngine.Color, Int32, System.Action`2[UnityEngine.UIElements.VisualElement,UnityEngine.Color])
		/// </summary>
		protected RMethod r_MStart_Color_Color_Int32_Action_d_VisualElement_Color_p_;
		public virtual RMethod RMStart_Color_Color_Int32_Action_d_VisualElement_Color_p_
		{
			get
			{
				if(r_MStart_Color_Color_Int32_Action_d_VisualElement_Color_p_ == null)
				{
					r_MStart_Color_Color_Int32_Action_d_VisualElement_Color_p_ = new(this, "Start", 0, typeof(UnityEngine.Color), typeof(UnityEngine.Color), typeof(System.Int32), typeof(System.Action<, >).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Color)));
				}
				return r_MStart_Color_Color_Int32_Action_d_VisualElement_Color_p_;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[UnityEngine.Vector3] Start(UnityEngine.Vector3, UnityEngine.Vector3, Int32, System.Action`2[UnityEngine.UIElements.VisualElement,UnityEngine.Vector3])
		/// </summary>
		protected RMethod r_MStart_Vector3_Vector3_Int32_Action_d_VisualElement_Vector3_p_;
		public virtual RMethod RMStart_Vector3_Vector3_Int32_Action_d_VisualElement_Vector3_p_
		{
			get
			{
				if(r_MStart_Vector3_Vector3_Int32_Action_d_VisualElement_Vector3_p_ == null)
				{
					r_MStart_Vector3_Vector3_Int32_Action_d_VisualElement_Vector3_p_ = new(this, "Start", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(System.Int32), typeof(System.Action<, >).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Vector3)));
				}
				return r_MStart_Vector3_Vector3_Int32_Action_d_VisualElement_Vector3_p_;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[UnityEngine.Vector2] Start(UnityEngine.Vector2, UnityEngine.Vector2, Int32, System.Action`2[UnityEngine.UIElements.VisualElement,UnityEngine.Vector2])
		/// </summary>
		protected RMethod r_MStart_Vector2_Vector2_Int32_Action_d_VisualElement_Vector2_p_;
		public virtual RMethod RMStart_Vector2_Vector2_Int32_Action_d_VisualElement_Vector2_p_
		{
			get
			{
				if(r_MStart_Vector2_Vector2_Int32_Action_d_VisualElement_Vector2_p_ == null)
				{
					r_MStart_Vector2_Vector2_Int32_Action_d_VisualElement_Vector2_p_ = new(this, "Start", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Int32), typeof(System.Action<, >).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Vector2)));
				}
				return r_MStart_Vector2_Vector2_Int32_Action_d_VisualElement_Vector2_p_;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[UnityEngine.Quaternion] Start(UnityEngine.Quaternion, UnityEngine.Quaternion, Int32, System.Action`2[UnityEngine.UIElements.VisualElement,UnityEngine.Quaternion])
		/// </summary>
		protected RMethod r_MStart_Quaternion_Quaternion_Int32_Action_d_VisualElement_Quaternion_p_;
		public virtual RMethod RMStart_Quaternion_Quaternion_Int32_Action_d_VisualElement_Quaternion_p_
		{
			get
			{
				if(r_MStart_Quaternion_Quaternion_Int32_Action_d_VisualElement_Quaternion_p_ == null)
				{
					r_MStart_Quaternion_Quaternion_Int32_Action_d_VisualElement_Quaternion_p_ = new(this, "Start", 0, typeof(UnityEngine.Quaternion), typeof(UnityEngine.Quaternion), typeof(System.Int32), typeof(System.Action<, >).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Quaternion)));
				}
				return r_MStart_Quaternion_Quaternion_Int32_Action_d_VisualElement_Quaternion_p_;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[UnityEngine.UIElements.Experimental.StyleValues] Start(UnityEngine.UIElements.Experimental.StyleValues, UnityEngine.UIElements.Experimental.StyleValues, Int32)
		/// </summary>
		protected RMethod r_MStart_StyleValues_StyleValues_Int32;
		public virtual RMethod RMStart_StyleValues_StyleValues_Int32
		{
			get
			{
				if(r_MStart_StyleValues_StyleValues_Int32 == null)
				{
					r_MStart_StyleValues_StyleValues_Int32 = new(this, "Start", 0, typeof(UnityEngine.UIElements.Experimental.StyleValues), typeof(UnityEngine.UIElements.Experimental.StyleValues), typeof(System.Int32));
				}
				return r_MStart_StyleValues_StyleValues_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[UnityEngine.UIElements.Experimental.StyleValues] Start(UnityEngine.UIElements.Experimental.StyleValues, Int32)
		/// </summary>
		protected RMethod r_MStart_StyleValues_Int32;
		public virtual RMethod RMStart_StyleValues_Int32
		{
			get
			{
				if(r_MStart_StyleValues_Int32 == null)
				{
					r_MStart_StyleValues_Int32 = new(this, "Start", 0, typeof(UnityEngine.UIElements.Experimental.StyleValues), typeof(System.Int32));
				}
				return r_MStart_StyleValues_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[System.Single] Start(System.Func`2[UnityEngine.UIElements.VisualElement,System.Single], Single, Int32, System.Action`2[UnityEngine.UIElements.VisualElement,System.Single])
		/// </summary>
		protected RMethod r_MStart_Func_d_VisualElement_Single_p__Single_Int32_Action_d_VisualElement_Single_p_;
		public virtual RMethod RMStart_Func_d_VisualElement_Single_p__Single_Int32_Action_d_VisualElement_Single_p_
		{
			get
			{
				if(r_MStart_Func_d_VisualElement_Single_p__Single_Int32_Action_d_VisualElement_Single_p_ == null)
				{
					r_MStart_Func_d_VisualElement_Single_p__Single_Int32_Action_d_VisualElement_Single_p_ = new(this, "Start", 0, typeof(System.Func<, >).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(System.Single)), typeof(System.Single), typeof(System.Int32), typeof(System.Action<, >).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(System.Single)));
				}
				return r_MStart_Func_d_VisualElement_Single_p__Single_Int32_Action_d_VisualElement_Single_p_;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[UnityEngine.Rect] Start(System.Func`2[UnityEngine.UIElements.VisualElement,UnityEngine.Rect], UnityEngine.Rect, Int32, System.Action`2[UnityEngine.UIElements.VisualElement,UnityEngine.Rect])
		/// </summary>
		protected RMethod r_MStart_Func_d_VisualElement_Rect_p__Rect_Int32_Action_d_VisualElement_Rect_p_;
		public virtual RMethod RMStart_Func_d_VisualElement_Rect_p__Rect_Int32_Action_d_VisualElement_Rect_p_
		{
			get
			{
				if(r_MStart_Func_d_VisualElement_Rect_p__Rect_Int32_Action_d_VisualElement_Rect_p_ == null)
				{
					r_MStart_Func_d_VisualElement_Rect_p__Rect_Int32_Action_d_VisualElement_Rect_p_ = new(this, "Start", 0, typeof(System.Func<, >).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Rect)), typeof(UnityEngine.Rect), typeof(System.Int32), typeof(System.Action<, >).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Rect)));
				}
				return r_MStart_Func_d_VisualElement_Rect_p__Rect_Int32_Action_d_VisualElement_Rect_p_;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[UnityEngine.Color] Start(System.Func`2[UnityEngine.UIElements.VisualElement,UnityEngine.Color], UnityEngine.Color, Int32, System.Action`2[UnityEngine.UIElements.VisualElement,UnityEngine.Color])
		/// </summary>
		protected RMethod r_MStart_Func_d_VisualElement_Color_p__Color_Int32_Action_d_VisualElement_Color_p_;
		public virtual RMethod RMStart_Func_d_VisualElement_Color_p__Color_Int32_Action_d_VisualElement_Color_p_
		{
			get
			{
				if(r_MStart_Func_d_VisualElement_Color_p__Color_Int32_Action_d_VisualElement_Color_p_ == null)
				{
					r_MStart_Func_d_VisualElement_Color_p__Color_Int32_Action_d_VisualElement_Color_p_ = new(this, "Start", 0, typeof(System.Func<, >).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Color)), typeof(UnityEngine.Color), typeof(System.Int32), typeof(System.Action<, >).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Color)));
				}
				return r_MStart_Func_d_VisualElement_Color_p__Color_Int32_Action_d_VisualElement_Color_p_;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[UnityEngine.Vector3] Start(System.Func`2[UnityEngine.UIElements.VisualElement,UnityEngine.Vector3], UnityEngine.Vector3, Int32, System.Action`2[UnityEngine.UIElements.VisualElement,UnityEngine.Vector3])
		/// </summary>
		protected RMethod r_MStart_Func_d_VisualElement_Vector3_p__Vector3_Int32_Action_d_VisualElement_Vector3_p_;
		public virtual RMethod RMStart_Func_d_VisualElement_Vector3_p__Vector3_Int32_Action_d_VisualElement_Vector3_p_
		{
			get
			{
				if(r_MStart_Func_d_VisualElement_Vector3_p__Vector3_Int32_Action_d_VisualElement_Vector3_p_ == null)
				{
					r_MStart_Func_d_VisualElement_Vector3_p__Vector3_Int32_Action_d_VisualElement_Vector3_p_ = new(this, "Start", 0, typeof(System.Func<, >).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Vector3)), typeof(UnityEngine.Vector3), typeof(System.Int32), typeof(System.Action<, >).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Vector3)));
				}
				return r_MStart_Func_d_VisualElement_Vector3_p__Vector3_Int32_Action_d_VisualElement_Vector3_p_;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[UnityEngine.Vector2] Start(System.Func`2[UnityEngine.UIElements.VisualElement,UnityEngine.Vector2], UnityEngine.Vector2, Int32, System.Action`2[UnityEngine.UIElements.VisualElement,UnityEngine.Vector2])
		/// </summary>
		protected RMethod r_MStart_Func_d_VisualElement_Vector2_p__Vector2_Int32_Action_d_VisualElement_Vector2_p_;
		public virtual RMethod RMStart_Func_d_VisualElement_Vector2_p__Vector2_Int32_Action_d_VisualElement_Vector2_p_
		{
			get
			{
				if(r_MStart_Func_d_VisualElement_Vector2_p__Vector2_Int32_Action_d_VisualElement_Vector2_p_ == null)
				{
					r_MStart_Func_d_VisualElement_Vector2_p__Vector2_Int32_Action_d_VisualElement_Vector2_p_ = new(this, "Start", 0, typeof(System.Func<, >).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Vector2)), typeof(UnityEngine.Vector2), typeof(System.Int32), typeof(System.Action<, >).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Vector2)));
				}
				return r_MStart_Func_d_VisualElement_Vector2_p__Vector2_Int32_Action_d_VisualElement_Vector2_p_;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[UnityEngine.Quaternion] Start(System.Func`2[UnityEngine.UIElements.VisualElement,UnityEngine.Quaternion], UnityEngine.Quaternion, Int32, System.Action`2[UnityEngine.UIElements.VisualElement,UnityEngine.Quaternion])
		/// </summary>
		protected RMethod r_MStart_Func_d_VisualElement_Quaternion_p__Quaternion_Int32_Action_d_VisualElement_Quaternion_p_;
		public virtual RMethod RMStart_Func_d_VisualElement_Quaternion_p__Quaternion_Int32_Action_d_VisualElement_Quaternion_p_
		{
			get
			{
				if(r_MStart_Func_d_VisualElement_Quaternion_p__Quaternion_Int32_Action_d_VisualElement_Quaternion_p_ == null)
				{
					r_MStart_Func_d_VisualElement_Quaternion_p__Quaternion_Int32_Action_d_VisualElement_Quaternion_p_ = new(this, "Start", 0, typeof(System.Func<, >).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Quaternion)), typeof(UnityEngine.Quaternion), typeof(System.Int32), typeof(System.Action<, >).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Quaternion)));
				}
				return r_MStart_Func_d_VisualElement_Quaternion_p__Quaternion_Int32_Action_d_VisualElement_Quaternion_p_;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[UnityEngine.Rect] Layout(UnityEngine.Rect, Int32)
		/// </summary>
		protected RMethod r_MLayout_Rect_Int32;
		public virtual RMethod RMLayout_Rect_Int32
		{
			get
			{
				if(r_MLayout_Rect_Int32 == null)
				{
					r_MLayout_Rect_Int32 = new(this, "Layout", 0, typeof(UnityEngine.Rect), typeof(System.Int32));
				}
				return r_MLayout_Rect_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[UnityEngine.Vector2] TopLeft(UnityEngine.Vector2, Int32)
		/// </summary>
		protected RMethod r_MTopLeft_Vector2_Int32;
		public virtual RMethod RMTopLeft_Vector2_Int32
		{
			get
			{
				if(r_MTopLeft_Vector2_Int32 == null)
				{
					r_MTopLeft_Vector2_Int32 = new(this, "TopLeft", 0, typeof(UnityEngine.Vector2), typeof(System.Int32));
				}
				return r_MTopLeft_Vector2_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[UnityEngine.Vector2] Size(UnityEngine.Vector2, Int32)
		/// </summary>
		protected RMethod r_MSize_Vector2_Int32;
		public virtual RMethod RMSize_Vector2_Int32
		{
			get
			{
				if(r_MSize_Vector2_Int32 == null)
				{
					r_MSize_Vector2_Int32 = new(this, "Size", 0, typeof(UnityEngine.Vector2), typeof(System.Int32));
				}
				return r_MSize_Vector2_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[System.Single] Scale(Single, Int32)
		/// </summary>
		protected RMethod r_MScale_Single_Int32;
		public virtual RMethod RMScale_Single_Int32
		{
			get
			{
				if(r_MScale_Single_Int32 == null)
				{
					r_MScale_Single_Int32 = new(this, "Scale", 0, typeof(System.Single), typeof(System.Int32));
				}
				return r_MScale_Single_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[UnityEngine.Vector3] Position(UnityEngine.Vector3, Int32)
		/// </summary>
		protected RMethod r_MPosition_Vector3_Int32;
		public virtual RMethod RMPosition_Vector3_Int32
		{
			get
			{
				if(r_MPosition_Vector3_Int32 == null)
				{
					r_MPosition_Vector3_Int32 = new(this, "Position", 0, typeof(UnityEngine.Vector3), typeof(System.Int32));
				}
				return r_MPosition_Vector3_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[UnityEngine.Quaternion] Rotation(UnityEngine.Quaternion, Int32)
		/// </summary>
		protected RMethod r_MRotation_Quaternion_Int32;
		public virtual RMethod RMRotation_Quaternion_Int32
		{
			get
			{
				if(r_MRotation_Quaternion_Int32 == null)
				{
					r_MRotation_Quaternion_Int32 = new(this, "Rotation", 0, typeof(UnityEngine.Quaternion), typeof(System.Int32));
				}
				return r_MRotation_Quaternion_Int32;
			}
		}


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<System.Single> Start(System.Single @from, System.Single @to, System.Int32 @durationMs, System.Action<UnityEngine.UIElements.VisualElement, System.Single> @onValueChanged)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to, @durationMs, @onValueChanged};
            var ___result = RMStart_Single_Single_Int32_Action_d_VisualElement_Single_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<System.Single>)___result;
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Rect> Start(UnityEngine.Rect @from, UnityEngine.Rect @to, System.Int32 @durationMs, System.Action<UnityEngine.UIElements.VisualElement, UnityEngine.Rect> @onValueChanged)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to, @durationMs, @onValueChanged};
            var ___result = RMStart_Rect_Rect_Int32_Action_d_VisualElement_Rect_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Rect>)___result;
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Color> Start(UnityEngine.Color @from, UnityEngine.Color @to, System.Int32 @durationMs, System.Action<UnityEngine.UIElements.VisualElement, UnityEngine.Color> @onValueChanged)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to, @durationMs, @onValueChanged};
            var ___result = RMStart_Color_Color_Int32_Action_d_VisualElement_Color_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Color>)___result;
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Vector3> Start(UnityEngine.Vector3 @from, UnityEngine.Vector3 @to, System.Int32 @durationMs, System.Action<UnityEngine.UIElements.VisualElement, UnityEngine.Vector3> @onValueChanged)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to, @durationMs, @onValueChanged};
            var ___result = RMStart_Vector3_Vector3_Int32_Action_d_VisualElement_Vector3_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Vector3>)___result;
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Vector2> Start(UnityEngine.Vector2 @from, UnityEngine.Vector2 @to, System.Int32 @durationMs, System.Action<UnityEngine.UIElements.VisualElement, UnityEngine.Vector2> @onValueChanged)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to, @durationMs, @onValueChanged};
            var ___result = RMStart_Vector2_Vector2_Int32_Action_d_VisualElement_Vector2_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Vector2>)___result;
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Quaternion> Start(UnityEngine.Quaternion @from, UnityEngine.Quaternion @to, System.Int32 @durationMs, System.Action<UnityEngine.UIElements.VisualElement, UnityEngine.Quaternion> @onValueChanged)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to, @durationMs, @onValueChanged};
            var ___result = RMStart_Quaternion_Quaternion_Int32_Action_d_VisualElement_Quaternion_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Quaternion>)___result;
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues> Start(UnityEngine.UIElements.Experimental.StyleValues @from, UnityEngine.UIElements.Experimental.StyleValues @to, System.Int32 @durationMs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to, @durationMs};
            var ___result = RMStart_StyleValues_StyleValues_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues>)___result;
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues> Start(UnityEngine.UIElements.Experimental.StyleValues @to, System.Int32 @durationMs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@to, @durationMs};
            var ___result = RMStart_StyleValues_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues>)___result;
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<System.Single> Start(System.Func<UnityEngine.UIElements.VisualElement, System.Single> @fromValueGetter, System.Single @to, System.Int32 @durationMs, System.Action<UnityEngine.UIElements.VisualElement, System.Single> @onValueChanged)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fromValueGetter, @to, @durationMs, @onValueChanged};
            var ___result = RMStart_Func_d_VisualElement_Single_p__Single_Int32_Action_d_VisualElement_Single_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<System.Single>)___result;
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Rect> Start(System.Func<UnityEngine.UIElements.VisualElement, UnityEngine.Rect> @fromValueGetter, UnityEngine.Rect @to, System.Int32 @durationMs, System.Action<UnityEngine.UIElements.VisualElement, UnityEngine.Rect> @onValueChanged)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fromValueGetter, @to, @durationMs, @onValueChanged};
            var ___result = RMStart_Func_d_VisualElement_Rect_p__Rect_Int32_Action_d_VisualElement_Rect_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Rect>)___result;
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Color> Start(System.Func<UnityEngine.UIElements.VisualElement, UnityEngine.Color> @fromValueGetter, UnityEngine.Color @to, System.Int32 @durationMs, System.Action<UnityEngine.UIElements.VisualElement, UnityEngine.Color> @onValueChanged)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fromValueGetter, @to, @durationMs, @onValueChanged};
            var ___result = RMStart_Func_d_VisualElement_Color_p__Color_Int32_Action_d_VisualElement_Color_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Color>)___result;
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Vector3> Start(System.Func<UnityEngine.UIElements.VisualElement, UnityEngine.Vector3> @fromValueGetter, UnityEngine.Vector3 @to, System.Int32 @durationMs, System.Action<UnityEngine.UIElements.VisualElement, UnityEngine.Vector3> @onValueChanged)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fromValueGetter, @to, @durationMs, @onValueChanged};
            var ___result = RMStart_Func_d_VisualElement_Vector3_p__Vector3_Int32_Action_d_VisualElement_Vector3_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Vector3>)___result;
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Vector2> Start(System.Func<UnityEngine.UIElements.VisualElement, UnityEngine.Vector2> @fromValueGetter, UnityEngine.Vector2 @to, System.Int32 @durationMs, System.Action<UnityEngine.UIElements.VisualElement, UnityEngine.Vector2> @onValueChanged)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fromValueGetter, @to, @durationMs, @onValueChanged};
            var ___result = RMStart_Func_d_VisualElement_Vector2_p__Vector2_Int32_Action_d_VisualElement_Vector2_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Vector2>)___result;
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Quaternion> Start(System.Func<UnityEngine.UIElements.VisualElement, UnityEngine.Quaternion> @fromValueGetter, UnityEngine.Quaternion @to, System.Int32 @durationMs, System.Action<UnityEngine.UIElements.VisualElement, UnityEngine.Quaternion> @onValueChanged)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fromValueGetter, @to, @durationMs, @onValueChanged};
            var ___result = RMStart_Func_d_VisualElement_Quaternion_p__Quaternion_Int32_Action_d_VisualElement_Quaternion_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Quaternion>)___result;
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Rect> Layout(UnityEngine.Rect @to, System.Int32 @durationMs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@to, @durationMs};
            var ___result = RMLayout_Rect_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Rect>)___result;
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Vector2> TopLeft(UnityEngine.Vector2 @to, System.Int32 @durationMs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@to, @durationMs};
            var ___result = RMTopLeft_Vector2_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Vector2>)___result;
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Vector2> Size(UnityEngine.Vector2 @to, System.Int32 @durationMs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@to, @durationMs};
            var ___result = RMSize_Vector2_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Vector2>)___result;
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<System.Single> Scale(System.Single @to, System.Int32 @duration)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@to, @duration};
            var ___result = RMScale_Single_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<System.Single>)___result;
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Vector3> Position(UnityEngine.Vector3 @to, System.Int32 @duration)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@to, @duration};
            var ___result = RMPosition_Vector3_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Vector3>)___result;
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Quaternion> Rotation(UnityEngine.Quaternion @to, System.Int32 @duration)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@to, @duration};
            var ___result = RMRotation_Quaternion_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Quaternion>)___result;
        }


    }
}
