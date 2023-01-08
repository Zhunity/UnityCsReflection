using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{public partial class RVisualElement
{
	
	/// <summary>
	/// UnityEngine.UIElements.VisualElement+CustomStyleAccess
	/// </summary>
    public partial class RCustomStyleAccess : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,UnityEngine.UIElements.StyleSheets.StylePropertyValue] m_CustomProperties
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue> r_m_CustomProperties;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue> Rm_CustomProperties
		{
			get
			{
				if(r_m_CustomProperties == null)
				{
					r_m_CustomProperties = new(this, "m_CustomProperties");
					r_m_CustomProperties.SetBelong(this.instance);
				}
				return r_m_CustomProperties;
			}
		}

		/// <summary>
		/// System.Single m_DpiScaling
		/// </summary>
		protected RField r_m_DpiScaling;
		public virtual RField Rm_DpiScaling
		{
			get
			{
				if(r_m_DpiScaling == null)
				{
					r_m_DpiScaling = new(this, "m_DpiScaling");
					r_m_DpiScaling.SetBelong(this.instance);
				}
				return r_m_DpiScaling;
			}
		}

		/// <summary>
		/// Void SetContext(System.Collections.Generic.Dictionary`2[System.String,UnityEngine.UIElements.StyleSheets.StylePropertyValue], Single)
		/// </summary>
		protected RMethod r_SetContext_Dictionary_d_String_StylePropertyValue_p__Single;
		public virtual RMethod RSetContext_Dictionary_d_String_StylePropertyValue_p__Single
		{
			get
			{
				if(r_SetContext_Dictionary_d_String_StylePropertyValue_p__Single == null)
				{
					r_SetContext_Dictionary_d_String_StylePropertyValue_p__Single = new(this, "SetContext", 0, typeof(System.Collections.Generic.Dictionary<, >).MakeGenericType(typeof(System.String),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue")), typeof(System.Single));
					r_SetContext_Dictionary_d_String_StylePropertyValue_p__Single.SetBelong(this.instance);
				}
				return r_SetContext_Dictionary_d_String_StylePropertyValue_p__Single;
			}
		}

		/// <summary>
		/// Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty`1[System.Single], Single ByRef)
		/// </summary>
		protected RMethod r_TryGetValue_CustomStyleProperty_d_Single_p__Out_Single;
		public virtual RMethod RTryGetValue_CustomStyleProperty_d_Single_p__Out_Single
		{
			get
			{
				if(r_TryGetValue_CustomStyleProperty_d_Single_p__Out_Single == null)
				{
					r_TryGetValue_CustomStyleProperty_d_Single_p__Out_Single = new(this, "TryGetValue", 0, typeof(UnityEngine.UIElements.CustomStyleProperty<>).MakeGenericType(typeof(System.Single)), typeof(System.Single).MakeByRefType());
					r_TryGetValue_CustomStyleProperty_d_Single_p__Out_Single.SetBelong(this.instance);
				}
				return r_TryGetValue_CustomStyleProperty_d_Single_p__Out_Single;
			}
		}

		/// <summary>
		/// Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty`1[System.Int32], Int32 ByRef)
		/// </summary>
		protected RMethod r_TryGetValue_CustomStyleProperty_d_Int32_p__Out_Int32;
		public virtual RMethod RTryGetValue_CustomStyleProperty_d_Int32_p__Out_Int32
		{
			get
			{
				if(r_TryGetValue_CustomStyleProperty_d_Int32_p__Out_Int32 == null)
				{
					r_TryGetValue_CustomStyleProperty_d_Int32_p__Out_Int32 = new(this, "TryGetValue", 0, typeof(UnityEngine.UIElements.CustomStyleProperty<>).MakeGenericType(typeof(System.Int32)), typeof(System.Int32).MakeByRefType());
					r_TryGetValue_CustomStyleProperty_d_Int32_p__Out_Int32.SetBelong(this.instance);
				}
				return r_TryGetValue_CustomStyleProperty_d_Int32_p__Out_Int32;
			}
		}

		/// <summary>
		/// Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty`1[System.Boolean], Boolean ByRef)
		/// </summary>
		protected RMethod r_TryGetValue_CustomStyleProperty_d_Boolean_p__Out_Boolean;
		public virtual RMethod RTryGetValue_CustomStyleProperty_d_Boolean_p__Out_Boolean
		{
			get
			{
				if(r_TryGetValue_CustomStyleProperty_d_Boolean_p__Out_Boolean == null)
				{
					r_TryGetValue_CustomStyleProperty_d_Boolean_p__Out_Boolean = new(this, "TryGetValue", 0, typeof(UnityEngine.UIElements.CustomStyleProperty<>).MakeGenericType(typeof(System.Boolean)), typeof(System.Boolean).MakeByRefType());
					r_TryGetValue_CustomStyleProperty_d_Boolean_p__Out_Boolean.SetBelong(this.instance);
				}
				return r_TryGetValue_CustomStyleProperty_d_Boolean_p__Out_Boolean;
			}
		}

		/// <summary>
		/// Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty`1[UnityEngine.Color], UnityEngine.Color ByRef)
		/// </summary>
		protected RMethod r_TryGetValue_CustomStyleProperty_d_Color_p__Out_Color;
		public virtual RMethod RTryGetValue_CustomStyleProperty_d_Color_p__Out_Color
		{
			get
			{
				if(r_TryGetValue_CustomStyleProperty_d_Color_p__Out_Color == null)
				{
					r_TryGetValue_CustomStyleProperty_d_Color_p__Out_Color = new(this, "TryGetValue", 0, typeof(UnityEngine.UIElements.CustomStyleProperty<>).MakeGenericType(typeof(UnityEngine.Color)), typeof(UnityEngine.Color).MakeByRefType());
					r_TryGetValue_CustomStyleProperty_d_Color_p__Out_Color.SetBelong(this.instance);
				}
				return r_TryGetValue_CustomStyleProperty_d_Color_p__Out_Color;
			}
		}

		/// <summary>
		/// Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty`1[UnityEngine.Texture2D], UnityEngine.Texture2D ByRef)
		/// </summary>
		protected RMethod r_TryGetValue_CustomStyleProperty_d_Texture2D_p__Out_Texture2D;
		public virtual RMethod RTryGetValue_CustomStyleProperty_d_Texture2D_p__Out_Texture2D
		{
			get
			{
				if(r_TryGetValue_CustomStyleProperty_d_Texture2D_p__Out_Texture2D == null)
				{
					r_TryGetValue_CustomStyleProperty_d_Texture2D_p__Out_Texture2D = new(this, "TryGetValue", 0, typeof(UnityEngine.UIElements.CustomStyleProperty<>).MakeGenericType(typeof(UnityEngine.Texture2D)), typeof(UnityEngine.Texture2D).MakeByRefType());
					r_TryGetValue_CustomStyleProperty_d_Texture2D_p__Out_Texture2D.SetBelong(this.instance);
				}
				return r_TryGetValue_CustomStyleProperty_d_Texture2D_p__Out_Texture2D;
			}
		}

		/// <summary>
		/// Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty`1[UnityEngine.Sprite], UnityEngine.Sprite ByRef)
		/// </summary>
		protected RMethod r_TryGetValue_CustomStyleProperty_d_Sprite_p__Out_Sprite;
		public virtual RMethod RTryGetValue_CustomStyleProperty_d_Sprite_p__Out_Sprite
		{
			get
			{
				if(r_TryGetValue_CustomStyleProperty_d_Sprite_p__Out_Sprite == null)
				{
					r_TryGetValue_CustomStyleProperty_d_Sprite_p__Out_Sprite = new(this, "TryGetValue", 0, typeof(UnityEngine.UIElements.CustomStyleProperty<>).MakeGenericType(typeof(UnityEngine.Sprite)), typeof(UnityEngine.Sprite).MakeByRefType());
					r_TryGetValue_CustomStyleProperty_d_Sprite_p__Out_Sprite.SetBelong(this.instance);
				}
				return r_TryGetValue_CustomStyleProperty_d_Sprite_p__Out_Sprite;
			}
		}

		/// <summary>
		/// Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty`1[UnityEngine.UIElements.VectorImage], UnityEngine.UIElements.VectorImage ByRef)
		/// </summary>
		protected RMethod r_TryGetValue_CustomStyleProperty_d_VectorImage_p__Out_VectorImage;
		public virtual RMethod RTryGetValue_CustomStyleProperty_d_VectorImage_p__Out_VectorImage
		{
			get
			{
				if(r_TryGetValue_CustomStyleProperty_d_VectorImage_p__Out_VectorImage == null)
				{
					r_TryGetValue_CustomStyleProperty_d_VectorImage_p__Out_VectorImage = new(this, "TryGetValue", 0, typeof(UnityEngine.UIElements.CustomStyleProperty<>).MakeGenericType(typeof(UnityEngine.UIElements.VectorImage)), typeof(UnityEngine.UIElements.VectorImage).MakeByRefType());
					r_TryGetValue_CustomStyleProperty_d_VectorImage_p__Out_VectorImage.SetBelong(this.instance);
				}
				return r_TryGetValue_CustomStyleProperty_d_VectorImage_p__Out_VectorImage;
			}
		}

		/// <summary>
		/// Boolean TryGetValue[T](UnityEngine.UIElements.CustomStyleProperty`1[T], T ByRef)
		/// </summary>
		protected RMethod r_TryGetValue_GT_CustomStyleProperty_d_T_p__Out_T;
		public virtual RMethod RTryGetValue_GT_CustomStyleProperty_d_T_p__Out_T
		{
			get
			{
				if(r_TryGetValue_GT_CustomStyleProperty_d_T_p__Out_T == null)
				{
					r_TryGetValue_GT_CustomStyleProperty_d_T_p__Out_T = new(this, "TryGetValue", 1, typeof(UnityEngine.UIElements.CustomStyleProperty<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), Type.MakeGenericMethodParameter(0).MakeByRefType());
					r_TryGetValue_GT_CustomStyleProperty_d_T_p__Out_T.SetBelong(this.instance);
				}
				return r_TryGetValue_GT_CustomStyleProperty_d_T_p__Out_T;
			}
		}

		/// <summary>
		/// Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty`1[System.String], System.String ByRef)
		/// </summary>
		protected RMethod r_TryGetValue_CustomStyleProperty_d_String_p__Out_String;
		public virtual RMethod RTryGetValue_CustomStyleProperty_d_String_p__Out_String
		{
			get
			{
				if(r_TryGetValue_CustomStyleProperty_d_String_p__Out_String == null)
				{
					r_TryGetValue_CustomStyleProperty_d_String_p__Out_String = new(this, "TryGetValue", 0, typeof(UnityEngine.UIElements.CustomStyleProperty<>).MakeGenericType(typeof(System.String)), typeof(System.String).MakeByRefType());
					r_TryGetValue_CustomStyleProperty_d_String_p__Out_String.SetBelong(this.instance);
				}
				return r_TryGetValue_CustomStyleProperty_d_String_p__Out_String;
			}
		}

		/// <summary>
		/// Boolean TryGetValue(System.String, UnityEngine.UIElements.StyleValueType, UnityEngine.UIElements.StyleSheets.StylePropertyValue ByRef)
		/// </summary>
		protected RMethod r_TryGetValue_String_StyleValueType_Out_StylePropertyValue;
		public virtual RMethod RTryGetValue_String_StyleValueType_Out_StylePropertyValue
		{
			get
			{
				if(r_TryGetValue_String_StyleValueType_Out_StylePropertyValue == null)
				{
					r_TryGetValue_String_StyleValueType_Out_StylePropertyValue = new(this, "TryGetValue", 0, typeof(System.String),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleValueType"),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue").MakeByRefType());
					r_TryGetValue_String_StyleValueType_Out_StylePropertyValue.SetBelong(this.instance);
				}
				return r_TryGetValue_String_StyleValueType_Out_StylePropertyValue;
			}
		}

		/// <summary>
		/// Void LogCustomPropertyWarning(System.String, UnityEngine.UIElements.StyleValueType, UnityEngine.UIElements.StyleSheets.StylePropertyValue)
		/// </summary>
		protected static RMethod r_LogCustomPropertyWarning_String_StyleValueType_StylePropertyValue;
		public static RMethod RLogCustomPropertyWarning_String_StyleValueType_StylePropertyValue
		{
			get
			{
				if(r_LogCustomPropertyWarning_String_StyleValueType_StylePropertyValue == null)
				{
					r_LogCustomPropertyWarning_String_StyleValueType_StylePropertyValue = new( ReflectionUtils.GetType("UnityEngine.UIElements.VisualElement+CustomStyleAccess"), "LogCustomPropertyWarning", 0, typeof(System.String),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleValueType"),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyValue"));
					r_LogCustomPropertyWarning_String_StyleValueType_StylePropertyValue.SetBelong(null);
				}
				return r_LogCustomPropertyWarning_String_StyleValueType_StylePropertyValue;
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


        public RCustomStyleAccess() : base("UnityEngine.UIElements.VisualElement+CustomStyleAccess")
        {
        }

        public RCustomStyleAccess(System.Object instance) : base("UnityEngine.UIElements.VisualElement+CustomStyleAccess")
		{
            SetInstance(instance);
		}

        public RCustomStyleAccess(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCustomStyleAccess(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void SetContext(RSystem.RCollections.RGeneric.RDictionary<RType, RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue> @customProperties, System.Single @dpiScaling)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@customProperties.Value, @dpiScaling};
            var ___result = RSetContext_Dictionary_d_String_StylePropertyValue_p__Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty<System.Single> @property, out System.Single @value)
        {
			@value = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@property, @value};
            var ___result = RTryGetValue_CustomStyleProperty_d_Single_p__Out_Single.Invoke(___genericsType, ___parameters);
			@value = (System.Single)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty<System.Int32> @property, out System.Int32 @value)
        {
			@value = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@property, @value};
            var ___result = RTryGetValue_CustomStyleProperty_d_Int32_p__Out_Int32.Invoke(___genericsType, ___parameters);
			@value = (System.Int32)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty<System.Boolean> @property, out System.Boolean @value)
        {
			@value = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@property, @value};
            var ___result = RTryGetValue_CustomStyleProperty_d_Boolean_p__Out_Boolean.Invoke(___genericsType, ___parameters);
			@value = (System.Boolean)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Color> @property, out UnityEngine.Color @value)
        {
			@value = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@property, @value};
            var ___result = RTryGetValue_CustomStyleProperty_d_Color_p__Out_Color.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.Color)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Texture2D> @property, out UnityEngine.Texture2D @value)
        {
			@value = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@property, @value};
            var ___result = RTryGetValue_CustomStyleProperty_d_Texture2D_p__Out_Texture2D.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.Texture2D)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Sprite> @property, out UnityEngine.Sprite @value)
        {
			@value = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@property, @value};
            var ___result = RTryGetValue_CustomStyleProperty_d_Sprite_p__Out_Sprite.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.Sprite)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.UIElements.VectorImage> @property, out UnityEngine.UIElements.VectorImage @value)
        {
			@value = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@property, @value};
            var ___result = RTryGetValue_CustomStyleProperty_d_VectorImage_p__Out_VectorImage.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.UIElements.VectorImage)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryGetValue<T>(UnityEngine.UIElements.CustomStyleProperty<T> @property, out T @value) where T : UnityEngine.Object
        {
			@value = default;

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@property, @value};
            var ___result = RTryGetValue_GT_CustomStyleProperty_d_T_p__Out_T.Invoke(___genericsType, ___parameters);
			@value = (T)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryGetValue(UnityEngine.UIElements.CustomStyleProperty<System.String> @property, out System.String @value)
        {
			@value = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@property, @value};
            var ___result = RTryGetValue_CustomStyleProperty_d_String_p__Out_String.Invoke(___genericsType, ___parameters);
			@value = (System.String)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryGetValue(System.String @propertyName, RType @valueType, out RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue @customProp)
        {
			@customProp = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyName, @valueType.Value, @customProp.Value};
            var ___result = RTryGetValue_String_StyleValueType_Out_StylePropertyValue.Invoke(___genericsType, ___parameters);
			@customProp = new RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue(___parameters[2]);

            return (System.Boolean)___result;
        }


        public static void LogCustomPropertyWarning(System.String @propertyName, RType @valueType, RUnityEngine.RUIElements.RStyleSheets.RStylePropertyValue @customProp)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyName, @valueType.Value, @customProp.Value};
            var ___result = RLogCustomPropertyWarning_String_StyleValueType_StylePropertyValue.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
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
}