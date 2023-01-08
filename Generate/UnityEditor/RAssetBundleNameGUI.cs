using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor
{
	/// <summary>
	/// UnityEditor.AssetBundleNameGUI
	/// </summary>
    public partial class RAssetBundleNameGUI : RMember //
    {

		/// <summary>
		/// UnityEngine.GUIContent kAssetBundleName
		/// </summary>
		protected static RUnityEngine.RGUIContent r_kAssetBundleName;
		public static RUnityEngine.RGUIContent RkAssetBundleName
		{
			get
			{
				if(r_kAssetBundleName == null)
				{
					r_kAssetBundleName = new( ReflectionUtils.GetType("UnityEditor.AssetBundleNameGUI"), "kAssetBundleName");
					r_kAssetBundleName.SetBelong(null);
				}
				return r_kAssetBundleName;
			}
		}

		/// <summary>
		/// System.Int32 kAssetBundleNameFieldIdHash
		/// </summary>
		protected static RField r_kAssetBundleNameFieldIdHash;
		public static RField RkAssetBundleNameFieldIdHash
		{
			get
			{
				if(r_kAssetBundleNameFieldIdHash == null)
				{
					r_kAssetBundleNameFieldIdHash = new( ReflectionUtils.GetType("UnityEditor.AssetBundleNameGUI"), "kAssetBundleNameFieldIdHash");
					r_kAssetBundleNameFieldIdHash.SetBelong(null);
				}
				return r_kAssetBundleNameFieldIdHash;
			}
		}

		/// <summary>
		/// System.Int32 kAssetBundleVariantFieldIdHash
		/// </summary>
		protected static RField r_kAssetBundleVariantFieldIdHash;
		public static RField RkAssetBundleVariantFieldIdHash
		{
			get
			{
				if(r_kAssetBundleVariantFieldIdHash == null)
				{
					r_kAssetBundleVariantFieldIdHash = new( ReflectionUtils.GetType("UnityEditor.AssetBundleNameGUI"), "kAssetBundleVariantFieldIdHash");
					r_kAssetBundleVariantFieldIdHash.SetBelong(null);
				}
				return r_kAssetBundleVariantFieldIdHash;
			}
		}

		/// <summary>
		/// System.Boolean m_ShowAssetBundleNameTextField
		/// </summary>
		protected RField r_m_ShowAssetBundleNameTextField;
		public virtual RField Rm_ShowAssetBundleNameTextField
		{
			get
			{
				if(r_m_ShowAssetBundleNameTextField == null)
				{
					r_m_ShowAssetBundleNameTextField = new(this, "m_ShowAssetBundleNameTextField");
					r_m_ShowAssetBundleNameTextField.SetBelong(this.instance);
				}
				return r_m_ShowAssetBundleNameTextField;
			}
		}

		/// <summary>
		/// System.Boolean m_ShowAssetBundleVariantTextField
		/// </summary>
		protected RField r_m_ShowAssetBundleVariantTextField;
		public virtual RField Rm_ShowAssetBundleVariantTextField
		{
			get
			{
				if(r_m_ShowAssetBundleVariantTextField == null)
				{
					r_m_ShowAssetBundleVariantTextField = new(this, "m_ShowAssetBundleVariantTextField");
					r_m_ShowAssetBundleVariantTextField.SetBelong(this.instance);
				}
				return r_m_ShowAssetBundleVariantTextField;
			}
		}

		/// <summary>
		/// Void OnAssetBundleNameGUI(System.Collections.Generic.IEnumerable`1[UnityEngine.Object])
		/// </summary>
		protected RMethod r_OnAssetBundleNameGUI_IEnumerable_d_Object_p_;
		public virtual RMethod ROnAssetBundleNameGUI_IEnumerable_d_Object_p_
		{
			get
			{
				if(r_OnAssetBundleNameGUI_IEnumerable_d_Object_p_ == null)
				{
					r_OnAssetBundleNameGUI_IEnumerable_d_Object_p_ = new(this, "OnAssetBundleNameGUI", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(typeof(UnityEngine.Object)));
					r_OnAssetBundleNameGUI_IEnumerable_d_Object_p_.SetBelong(this.instance);
				}
				return r_OnAssetBundleNameGUI_IEnumerable_d_Object_p_;
			}
		}

		/// <summary>
		/// Void ShowNewAssetBundleField(Boolean)
		/// </summary>
		protected RMethod r_ShowNewAssetBundleField_Boolean;
		public virtual RMethod RShowNewAssetBundleField_Boolean
		{
			get
			{
				if(r_ShowNewAssetBundleField_Boolean == null)
				{
					r_ShowNewAssetBundleField_Boolean = new(this, "ShowNewAssetBundleField", 0, typeof(System.Boolean));
					r_ShowNewAssetBundleField_Boolean.SetBelong(this.instance);
				}
				return r_ShowNewAssetBundleField_Boolean;
			}
		}

		/// <summary>
		/// Void AssetBundleTextField(UnityEngine.Rect, Int32, System.Collections.Generic.IEnumerable`1[UnityEngine.Object], Boolean)
		/// </summary>
		protected RMethod r_AssetBundleTextField_Rect_Int32_IEnumerable_d_Object_p__Boolean;
		public virtual RMethod RAssetBundleTextField_Rect_Int32_IEnumerable_d_Object_p__Boolean
		{
			get
			{
				if(r_AssetBundleTextField_Rect_Int32_IEnumerable_d_Object_p__Boolean == null)
				{
					r_AssetBundleTextField_Rect_Int32_IEnumerable_d_Object_p__Boolean = new(this, "AssetBundleTextField", 0, typeof(UnityEngine.Rect), typeof(System.Int32), typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(typeof(UnityEngine.Object)), typeof(System.Boolean));
					r_AssetBundleTextField_Rect_Int32_IEnumerable_d_Object_p__Boolean.SetBelong(this.instance);
				}
				return r_AssetBundleTextField_Rect_Int32_IEnumerable_d_Object_p__Boolean;
			}
		}

		/// <summary>
		/// Void ShowAssetBundlePopup()
		/// </summary>
		protected RMethod r_ShowAssetBundlePopup;
		public virtual RMethod RShowAssetBundlePopup
		{
			get
			{
				if(r_ShowAssetBundlePopup == null)
				{
					r_ShowAssetBundlePopup = new(this, "ShowAssetBundlePopup", 0);
					r_ShowAssetBundlePopup.SetBelong(this.instance);
				}
				return r_ShowAssetBundlePopup;
			}
		}

		/// <summary>
		/// Void AssetBundlePopup(UnityEngine.Rect, Int32, System.Collections.Generic.IEnumerable`1[UnityEngine.Object], Boolean)
		/// </summary>
		protected RMethod r_AssetBundlePopup_Rect_Int32_IEnumerable_d_Object_p__Boolean;
		public virtual RMethod RAssetBundlePopup_Rect_Int32_IEnumerable_d_Object_p__Boolean
		{
			get
			{
				if(r_AssetBundlePopup_Rect_Int32_IEnumerable_d_Object_p__Boolean == null)
				{
					r_AssetBundlePopup_Rect_Int32_IEnumerable_d_Object_p__Boolean = new(this, "AssetBundlePopup", 0, typeof(UnityEngine.Rect), typeof(System.Int32), typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(typeof(UnityEngine.Object)), typeof(System.Boolean));
					r_AssetBundlePopup_Rect_Int32_IEnumerable_d_Object_p__Boolean.SetBelong(this.instance);
				}
				return r_AssetBundlePopup_Rect_Int32_IEnumerable_d_Object_p__Boolean;
			}
		}

		/// <summary>
		/// Void FilterSelected(System.Collections.Generic.IEnumerable`1[System.String])
		/// </summary>
		protected RMethod r_FilterSelected_IEnumerable_d_String_p_;
		public virtual RMethod RFilterSelected_IEnumerable_d_String_p_
		{
			get
			{
				if(r_FilterSelected_IEnumerable_d_String_p_ == null)
				{
					r_FilterSelected_IEnumerable_d_String_p_ = new(this, "FilterSelected", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(typeof(System.String)));
					r_FilterSelected_IEnumerable_d_String_p_.SetBelong(this.instance);
				}
				return r_FilterSelected_IEnumerable_d_String_p_;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.String] GetAssetBundlesFromAssets(System.Collections.Generic.IEnumerable`1[UnityEngine.Object], Boolean, Boolean ByRef)
		/// </summary>
		protected RMethod r_GetAssetBundlesFromAssets_IEnumerable_d_Object_p__Boolean_Out_Boolean;
		public virtual RMethod RGetAssetBundlesFromAssets_IEnumerable_d_Object_p__Boolean_Out_Boolean
		{
			get
			{
				if(r_GetAssetBundlesFromAssets_IEnumerable_d_Object_p__Boolean_Out_Boolean == null)
				{
					r_GetAssetBundlesFromAssets_IEnumerable_d_Object_p__Boolean_Out_Boolean = new(this, "GetAssetBundlesFromAssets", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(typeof(UnityEngine.Object)), typeof(System.Boolean), typeof(System.Boolean).MakeByRefType());
					r_GetAssetBundlesFromAssets_IEnumerable_d_Object_p__Boolean_Out_Boolean.SetBelong(this.instance);
				}
				return r_GetAssetBundlesFromAssets_IEnumerable_d_Object_p__Boolean_Out_Boolean;
			}
		}

		/// <summary>
		/// Void SetAssetBundleForAssets(System.Collections.Generic.IEnumerable`1[UnityEngine.Object], System.String, Boolean)
		/// </summary>
		protected RMethod r_SetAssetBundleForAssets_IEnumerable_d_Object_p__String_Boolean;
		public virtual RMethod RSetAssetBundleForAssets_IEnumerable_d_Object_p__String_Boolean
		{
			get
			{
				if(r_SetAssetBundleForAssets_IEnumerable_d_Object_p__String_Boolean == null)
				{
					r_SetAssetBundleForAssets_IEnumerable_d_Object_p__String_Boolean = new(this, "SetAssetBundleForAssets", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(typeof(UnityEngine.Object)), typeof(System.String), typeof(System.Boolean));
					r_SetAssetBundleForAssets_IEnumerable_d_Object_p__String_Boolean.SetBelong(this.instance);
				}
				return r_SetAssetBundleForAssets_IEnumerable_d_Object_p__String_Boolean;
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


        public RAssetBundleNameGUI() : base("UnityEditor.AssetBundleNameGUI")
        {
        }

        public RAssetBundleNameGUI(System.Object instance) : base("UnityEditor.AssetBundleNameGUI")
		{
            SetInstance(instance);
		}

        public RAssetBundleNameGUI(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAssetBundleNameGUI(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void OnAssetBundleNameGUI(System.Collections.Generic.IEnumerable<UnityEngine.Object> @assets)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assets};
            var ___result = ROnAssetBundleNameGUI_IEnumerable_d_Object_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowNewAssetBundleField(System.Boolean @isVariant)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@isVariant};
            var ___result = RShowNewAssetBundleField_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AssetBundleTextField(UnityEngine.Rect @rect, System.Int32 @id, System.Collections.Generic.IEnumerable<UnityEngine.Object> @assets, System.Boolean @isVariant)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect, @id, @assets, @isVariant};
            var ___result = RAssetBundleTextField_Rect_Int32_IEnumerable_d_Object_p__Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowAssetBundlePopup()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RShowAssetBundlePopup.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AssetBundlePopup(UnityEngine.Rect @rect, System.Int32 @id, System.Collections.Generic.IEnumerable<UnityEngine.Object> @assets, System.Boolean @isVariant)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect, @id, @assets, @isVariant};
            var ___result = RAssetBundlePopup_Rect_Int32_IEnumerable_d_Object_p__Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FilterSelected(System.Collections.Generic.IEnumerable<System.String> @assetBundleNames)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assetBundleNames};
            var ___result = RFilterSelected_IEnumerable_d_String_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.Generic.IEnumerable<System.String> GetAssetBundlesFromAssets(System.Collections.Generic.IEnumerable<UnityEngine.Object> @assets, System.Boolean @isVariant, out System.Boolean @isMixed)
        {
			@isMixed = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assets, @isVariant, @isMixed};
            var ___result = RGetAssetBundlesFromAssets_IEnumerable_d_Object_p__Boolean_Out_Boolean.Invoke(___genericsType, ___parameters);
			@isMixed = (System.Boolean)___parameters[2];

            return (System.Collections.Generic.IEnumerable<System.String>)___result;
        }


        public virtual void SetAssetBundleForAssets(System.Collections.Generic.IEnumerable<UnityEngine.Object> @assets, System.String @name, System.Boolean @isVariant)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assets, @name, @isVariant};
            var ___result = RSetAssetBundleForAssets_IEnumerable_d_Object_p__String_Boolean.Invoke(___genericsType, ___parameters);

            
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
