
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.ICustomStyle
	/// </summary>
    public partial class RICustomStyle : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.UIElements.ICustomStyle);
            }
        }

        public RICustomStyle() : base("UnityEngine.UIElements.ICustomStyle")
        {
        }

        public RICustomStyle(System.Object instance) : base("UnityEngine.UIElements.ICustomStyle")
		{
            SetInstance(instance);
		}

        public RICustomStyle(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RICustomStyle(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty`1[System.Single], Single ByRef)
		/// </summary>
		protected RMethod r_MTryGetValue_CustomStyleProperty_d_Single_p__Out_Single;
		public virtual RMethod RMTryGetValue_CustomStyleProperty_d_Single_p__Out_Single
		{
			get
			{
				if(r_MTryGetValue_CustomStyleProperty_d_Single_p__Out_Single == null)
				{
					r_MTryGetValue_CustomStyleProperty_d_Single_p__Out_Single = new(this, "TryGetValue", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.CustomStyleProperty`1").MakeGenericType(typeof(System.Single)), typeof(System.Single).MakeByRefType());
				}
				return r_MTryGetValue_CustomStyleProperty_d_Single_p__Out_Single;
			}
		}

		/// <summary>
		/// Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty`1[System.Int32], Int32 ByRef)
		/// </summary>
		protected RMethod r_MTryGetValue_CustomStyleProperty_d_Int32_p__Out_Int32;
		public virtual RMethod RMTryGetValue_CustomStyleProperty_d_Int32_p__Out_Int32
		{
			get
			{
				if(r_MTryGetValue_CustomStyleProperty_d_Int32_p__Out_Int32 == null)
				{
					r_MTryGetValue_CustomStyleProperty_d_Int32_p__Out_Int32 = new(this, "TryGetValue", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.CustomStyleProperty`1").MakeGenericType(typeof(System.Int32)), typeof(System.Int32).MakeByRefType());
				}
				return r_MTryGetValue_CustomStyleProperty_d_Int32_p__Out_Int32;
			}
		}

		/// <summary>
		/// Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty`1[System.Boolean], Boolean ByRef)
		/// </summary>
		protected RMethod r_MTryGetValue_CustomStyleProperty_d_Boolean_p__Out_Boolean;
		public virtual RMethod RMTryGetValue_CustomStyleProperty_d_Boolean_p__Out_Boolean
		{
			get
			{
				if(r_MTryGetValue_CustomStyleProperty_d_Boolean_p__Out_Boolean == null)
				{
					r_MTryGetValue_CustomStyleProperty_d_Boolean_p__Out_Boolean = new(this, "TryGetValue", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.CustomStyleProperty`1").MakeGenericType(typeof(System.Boolean)), typeof(System.Boolean).MakeByRefType());
				}
				return r_MTryGetValue_CustomStyleProperty_d_Boolean_p__Out_Boolean;
			}
		}

		/// <summary>
		/// Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty`1[UnityEngine.Color], UnityEngine.Color ByRef)
		/// </summary>
		protected RMethod r_MTryGetValue_CustomStyleProperty_d_Color_p__Out_Color;
		public virtual RMethod RMTryGetValue_CustomStyleProperty_d_Color_p__Out_Color
		{
			get
			{
				if(r_MTryGetValue_CustomStyleProperty_d_Color_p__Out_Color == null)
				{
					r_MTryGetValue_CustomStyleProperty_d_Color_p__Out_Color = new(this, "TryGetValue", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.CustomStyleProperty`1").MakeGenericType(typeof(UnityEngine.Color)), typeof(UnityEngine.Color).MakeByRefType());
				}
				return r_MTryGetValue_CustomStyleProperty_d_Color_p__Out_Color;
			}
		}

		/// <summary>
		/// Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty`1[UnityEngine.Texture2D], UnityEngine.Texture2D ByRef)
		/// </summary>
		protected RMethod r_MTryGetValue_CustomStyleProperty_d_Texture2D_p__Out_Texture2D;
		public virtual RMethod RMTryGetValue_CustomStyleProperty_d_Texture2D_p__Out_Texture2D
		{
			get
			{
				if(r_MTryGetValue_CustomStyleProperty_d_Texture2D_p__Out_Texture2D == null)
				{
					r_MTryGetValue_CustomStyleProperty_d_Texture2D_p__Out_Texture2D = new(this, "TryGetValue", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.CustomStyleProperty`1").MakeGenericType(typeof(UnityEngine.Texture2D)), typeof(UnityEngine.Texture2D).MakeByRefType());
				}
				return r_MTryGetValue_CustomStyleProperty_d_Texture2D_p__Out_Texture2D;
			}
		}

		/// <summary>
		/// Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty`1[UnityEngine.Sprite], UnityEngine.Sprite ByRef)
		/// </summary>
		protected RMethod r_MTryGetValue_CustomStyleProperty_d_Sprite_p__Out_Sprite;
		public virtual RMethod RMTryGetValue_CustomStyleProperty_d_Sprite_p__Out_Sprite
		{
			get
			{
				if(r_MTryGetValue_CustomStyleProperty_d_Sprite_p__Out_Sprite == null)
				{
					r_MTryGetValue_CustomStyleProperty_d_Sprite_p__Out_Sprite = new(this, "TryGetValue", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.CustomStyleProperty`1").MakeGenericType(typeof(UnityEngine.Sprite)), typeof(UnityEngine.Sprite).MakeByRefType());
				}
				return r_MTryGetValue_CustomStyleProperty_d_Sprite_p__Out_Sprite;
			}
		}

		/// <summary>
		/// Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty`1[UnityEngine.UIElements.VectorImage], UnityEngine.UIElements.VectorImage ByRef)
		/// </summary>
		protected RMethod r_MTryGetValue_CustomStyleProperty_d_VectorImage_p__Out_VectorImage;
		public virtual RMethod RMTryGetValue_CustomStyleProperty_d_VectorImage_p__Out_VectorImage
		{
			get
			{
				if(r_MTryGetValue_CustomStyleProperty_d_VectorImage_p__Out_VectorImage == null)
				{
					r_MTryGetValue_CustomStyleProperty_d_VectorImage_p__Out_VectorImage = new(this, "TryGetValue", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.CustomStyleProperty`1").MakeGenericType(typeof(UnityEngine.UIElements.VectorImage)), typeof(UnityEngine.UIElements.VectorImage).MakeByRefType());
				}
				return r_MTryGetValue_CustomStyleProperty_d_VectorImage_p__Out_VectorImage;
			}
		}

		/// <summary>
		/// Boolean TryGetValue[T](UnityEngine.UIElements.CustomStyleProperty`1[T], T ByRef)
		/// </summary>
		protected RMethod r_MTryGetValue_GT_CustomStyleProperty_d_T_p__Out_T;
		public virtual RMethod RMTryGetValue_GT_CustomStyleProperty_d_T_p__Out_T
		{
			get
			{
				if(r_MTryGetValue_GT_CustomStyleProperty_d_T_p__Out_T == null)
				{
					r_MTryGetValue_GT_CustomStyleProperty_d_T_p__Out_T = new(this, "TryGetValue", 1,  ReflectionUtils.GetType("UnityEngine.UIElements.CustomStyleProperty`1").MakeGenericType(Type.MakeGenericMethodParameter(0)), Type.MakeGenericMethodParameter(0).MakeByRefType());
				}
				return r_MTryGetValue_GT_CustomStyleProperty_d_T_p__Out_T;
			}
		}

		/// <summary>
		/// Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty`1[System.String], System.String ByRef)
		/// </summary>
		protected RMethod r_MTryGetValue_CustomStyleProperty_d_String_p__Out_String;
		public virtual RMethod RMTryGetValue_CustomStyleProperty_d_String_p__Out_String
		{
			get
			{
				if(r_MTryGetValue_CustomStyleProperty_d_String_p__Out_String == null)
				{
					r_MTryGetValue_CustomStyleProperty_d_String_p__Out_String = new(this, "TryGetValue", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.CustomStyleProperty`1").MakeGenericType(typeof(System.String)), typeof(System.String).MakeByRefType());
				}
				return r_MTryGetValue_CustomStyleProperty_d_String_p__Out_String;
			}
		}


        public virtual System.Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty<System.Single> @property, out System.Single @value)
        {
			@value = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@property, @value};
            var ___result = RMTryGetValue_CustomStyleProperty_d_Single_p__Out_Single.Invoke(___genericsType, ___parameters);
			@value = (System.Single)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty<System.Int32> @property, out System.Int32 @value)
        {
			@value = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@property, @value};
            var ___result = RMTryGetValue_CustomStyleProperty_d_Int32_p__Out_Int32.Invoke(___genericsType, ___parameters);
			@value = (System.Int32)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty<System.Boolean> @property, out System.Boolean @value)
        {
			@value = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@property, @value};
            var ___result = RMTryGetValue_CustomStyleProperty_d_Boolean_p__Out_Boolean.Invoke(___genericsType, ___parameters);
			@value = (System.Boolean)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Color> @property, out UnityEngine.Color @value)
        {
			@value = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@property, @value};
            var ___result = RMTryGetValue_CustomStyleProperty_d_Color_p__Out_Color.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.Color)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Texture2D> @property, out UnityEngine.Texture2D @value)
        {
			@value = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@property, @value};
            var ___result = RMTryGetValue_CustomStyleProperty_d_Texture2D_p__Out_Texture2D.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.Texture2D)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Sprite> @property, out UnityEngine.Sprite @value)
        {
			@value = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@property, @value};
            var ___result = RMTryGetValue_CustomStyleProperty_d_Sprite_p__Out_Sprite.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.Sprite)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.UIElements.VectorImage> @property, out UnityEngine.UIElements.VectorImage @value)
        {
			@value = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@property, @value};
            var ___result = RMTryGetValue_CustomStyleProperty_d_VectorImage_p__Out_VectorImage.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.UIElements.VectorImage)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryGetValue<T>(UnityEngine.UIElements.CustomStyleProperty<T> @property, out T @value) where T : UnityEngine.Object
        {
			@value = default;

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@property, @value};
            var ___result = RMTryGetValue_GT_CustomStyleProperty_d_T_p__Out_T.Invoke(___genericsType, ___parameters);
			@value = (T)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty<System.String> @property, out System.String @value)
        {
			@value = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@property, @value};
            var ___result = RMTryGetValue_CustomStyleProperty_d_String_p__Out_String.Invoke(___genericsType, ___parameters);
			@value = (System.String)___parameters[1];

            return (System.Boolean)___result;
        }


    }
}
