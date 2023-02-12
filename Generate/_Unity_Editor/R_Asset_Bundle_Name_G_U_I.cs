
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
		protected static SMFrame.Editor.Refleaction.RUnityEngine.RGUIContent r_FkAssetBundleName;
		public static SMFrame.Editor.Refleaction.RUnityEngine.RGUIContent RFkAssetBundleName
		{
			get
			{
				if(r_FkAssetBundleName == null)
				{
					r_FkAssetBundleName = new( ReflectionUtils.GetType("UnityEditor.AssetBundleNameGUI"), "kAssetBundleName");
					r_FkAssetBundleName.SetBelong(null);
				}
				return r_FkAssetBundleName;
			}
		}

		/// <summary>
		/// System.Int32 kAssetBundleNameFieldIdHash
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RInt32 r_FkAssetBundleNameFieldIdHash;
		public static SMFrame.Editor.Refleaction.RSystem.RInt32 RFkAssetBundleNameFieldIdHash
		{
			get
			{
				if(r_FkAssetBundleNameFieldIdHash == null)
				{
					r_FkAssetBundleNameFieldIdHash = new( ReflectionUtils.GetType("UnityEditor.AssetBundleNameGUI"), "kAssetBundleNameFieldIdHash");
					r_FkAssetBundleNameFieldIdHash.SetBelong(null);
				}
				return r_FkAssetBundleNameFieldIdHash;
			}
		}

		/// <summary>
		/// System.Int32 kAssetBundleVariantFieldIdHash
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RInt32 r_FkAssetBundleVariantFieldIdHash;
		public static SMFrame.Editor.Refleaction.RSystem.RInt32 RFkAssetBundleVariantFieldIdHash
		{
			get
			{
				if(r_FkAssetBundleVariantFieldIdHash == null)
				{
					r_FkAssetBundleVariantFieldIdHash = new( ReflectionUtils.GetType("UnityEditor.AssetBundleNameGUI"), "kAssetBundleVariantFieldIdHash");
					r_FkAssetBundleVariantFieldIdHash.SetBelong(null);
				}
				return r_FkAssetBundleVariantFieldIdHash;
			}
		}

		/// <summary>
		/// System.Boolean m_ShowAssetBundleNameTextField
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_Fm_ShowAssetBundleNameTextField;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RFm_ShowAssetBundleNameTextField
		{
			get
			{
				if(r_Fm_ShowAssetBundleNameTextField == null)
				{
					r_Fm_ShowAssetBundleNameTextField = new(this, "m_ShowAssetBundleNameTextField");
					r_Fm_ShowAssetBundleNameTextField.SetBelong(this.instance);
				}
				return r_Fm_ShowAssetBundleNameTextField;
			}
		}

		/// <summary>
		/// System.Boolean m_ShowAssetBundleVariantTextField
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_Fm_ShowAssetBundleVariantTextField;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RFm_ShowAssetBundleVariantTextField
		{
			get
			{
				if(r_Fm_ShowAssetBundleVariantTextField == null)
				{
					r_Fm_ShowAssetBundleVariantTextField = new(this, "m_ShowAssetBundleVariantTextField");
					r_Fm_ShowAssetBundleVariantTextField.SetBelong(this.instance);
				}
				return r_Fm_ShowAssetBundleVariantTextField;
			}
		}

		/// <summary>
		/// Void OnAssetBundleNameGUI(System.Collections.Generic.IEnumerable`1[UnityEngine.Object])
		/// </summary>
		protected RMethod r_MOnAssetBundleNameGUI_IEnumerable_d_Object_p_;
		public virtual RMethod RMOnAssetBundleNameGUI_IEnumerable_d_Object_p_
		{
			get
			{
				if(r_MOnAssetBundleNameGUI_IEnumerable_d_Object_p_ == null)
				{
					r_MOnAssetBundleNameGUI_IEnumerable_d_Object_p_ = new(this, "OnAssetBundleNameGUI", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(typeof(UnityEngine.Object)));
					r_MOnAssetBundleNameGUI_IEnumerable_d_Object_p_.SetBelong(this.instance);
				}
				return r_MOnAssetBundleNameGUI_IEnumerable_d_Object_p_;
			}
		}

		/// <summary>
		/// Void ShowNewAssetBundleField(Boolean)
		/// </summary>
		protected RMethod r_MShowNewAssetBundleField_Boolean;
		public virtual RMethod RMShowNewAssetBundleField_Boolean
		{
			get
			{
				if(r_MShowNewAssetBundleField_Boolean == null)
				{
					r_MShowNewAssetBundleField_Boolean = new(this, "ShowNewAssetBundleField", 0, typeof(System.Boolean));
					r_MShowNewAssetBundleField_Boolean.SetBelong(this.instance);
				}
				return r_MShowNewAssetBundleField_Boolean;
			}
		}

		/// <summary>
		/// Void AssetBundleTextField(UnityEngine.Rect, Int32, System.Collections.Generic.IEnumerable`1[UnityEngine.Object], Boolean)
		/// </summary>
		protected RMethod r_MAssetBundleTextField_Rect_Int32_IEnumerable_d_Object_p__Boolean;
		public virtual RMethod RMAssetBundleTextField_Rect_Int32_IEnumerable_d_Object_p__Boolean
		{
			get
			{
				if(r_MAssetBundleTextField_Rect_Int32_IEnumerable_d_Object_p__Boolean == null)
				{
					r_MAssetBundleTextField_Rect_Int32_IEnumerable_d_Object_p__Boolean = new(this, "AssetBundleTextField", 0, typeof(UnityEngine.Rect), typeof(System.Int32), typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(typeof(UnityEngine.Object)), typeof(System.Boolean));
					r_MAssetBundleTextField_Rect_Int32_IEnumerable_d_Object_p__Boolean.SetBelong(this.instance);
				}
				return r_MAssetBundleTextField_Rect_Int32_IEnumerable_d_Object_p__Boolean;
			}
		}

		/// <summary>
		/// Void ShowAssetBundlePopup()
		/// </summary>
		protected RMethod r_MShowAssetBundlePopup;
		public virtual RMethod RMShowAssetBundlePopup
		{
			get
			{
				if(r_MShowAssetBundlePopup == null)
				{
					r_MShowAssetBundlePopup = new(this, "ShowAssetBundlePopup", 0);
					r_MShowAssetBundlePopup.SetBelong(this.instance);
				}
				return r_MShowAssetBundlePopup;
			}
		}

		/// <summary>
		/// Void AssetBundlePopup(UnityEngine.Rect, Int32, System.Collections.Generic.IEnumerable`1[UnityEngine.Object], Boolean)
		/// </summary>
		protected RMethod r_MAssetBundlePopup_Rect_Int32_IEnumerable_d_Object_p__Boolean;
		public virtual RMethod RMAssetBundlePopup_Rect_Int32_IEnumerable_d_Object_p__Boolean
		{
			get
			{
				if(r_MAssetBundlePopup_Rect_Int32_IEnumerable_d_Object_p__Boolean == null)
				{
					r_MAssetBundlePopup_Rect_Int32_IEnumerable_d_Object_p__Boolean = new(this, "AssetBundlePopup", 0, typeof(UnityEngine.Rect), typeof(System.Int32), typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(typeof(UnityEngine.Object)), typeof(System.Boolean));
					r_MAssetBundlePopup_Rect_Int32_IEnumerable_d_Object_p__Boolean.SetBelong(this.instance);
				}
				return r_MAssetBundlePopup_Rect_Int32_IEnumerable_d_Object_p__Boolean;
			}
		}

		/// <summary>
		/// Void FilterSelected(System.Collections.Generic.IEnumerable`1[System.String])
		/// </summary>
		protected RMethod r_MFilterSelected_IEnumerable_d_String_p_;
		public virtual RMethod RMFilterSelected_IEnumerable_d_String_p_
		{
			get
			{
				if(r_MFilterSelected_IEnumerable_d_String_p_ == null)
				{
					r_MFilterSelected_IEnumerable_d_String_p_ = new(this, "FilterSelected", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(typeof(System.String)));
					r_MFilterSelected_IEnumerable_d_String_p_.SetBelong(this.instance);
				}
				return r_MFilterSelected_IEnumerable_d_String_p_;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.String] GetAssetBundlesFromAssets(System.Collections.Generic.IEnumerable`1[UnityEngine.Object], Boolean, Boolean ByRef)
		/// </summary>
		protected RMethod r_MGetAssetBundlesFromAssets_IEnumerable_d_Object_p__Boolean_Out_Boolean;
		public virtual RMethod RMGetAssetBundlesFromAssets_IEnumerable_d_Object_p__Boolean_Out_Boolean
		{
			get
			{
				if(r_MGetAssetBundlesFromAssets_IEnumerable_d_Object_p__Boolean_Out_Boolean == null)
				{
					r_MGetAssetBundlesFromAssets_IEnumerable_d_Object_p__Boolean_Out_Boolean = new(this, "GetAssetBundlesFromAssets", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(typeof(UnityEngine.Object)), typeof(System.Boolean), typeof(System.Boolean).MakeByRefType());
					r_MGetAssetBundlesFromAssets_IEnumerable_d_Object_p__Boolean_Out_Boolean.SetBelong(this.instance);
				}
				return r_MGetAssetBundlesFromAssets_IEnumerable_d_Object_p__Boolean_Out_Boolean;
			}
		}

		/// <summary>
		/// Void SetAssetBundleForAssets(System.Collections.Generic.IEnumerable`1[UnityEngine.Object], System.String, Boolean)
		/// </summary>
		protected RMethod r_MSetAssetBundleForAssets_IEnumerable_d_Object_p__String_Boolean;
		public virtual RMethod RMSetAssetBundleForAssets_IEnumerable_d_Object_p__String_Boolean
		{
			get
			{
				if(r_MSetAssetBundleForAssets_IEnumerable_d_Object_p__String_Boolean == null)
				{
					r_MSetAssetBundleForAssets_IEnumerable_d_Object_p__String_Boolean = new(this, "SetAssetBundleForAssets", 0, typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(typeof(UnityEngine.Object)), typeof(System.String), typeof(System.Boolean));
					r_MSetAssetBundleForAssets_IEnumerable_d_Object_p__String_Boolean.SetBelong(this.instance);
				}
				return r_MSetAssetBundleForAssets_IEnumerable_d_Object_p__String_Boolean;
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
					r_MEquals_Object.SetBelong(this.instance);
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
					r_MFinalize.SetBelong(this.instance);
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
					r_MGetHashCode.SetBelong(this.instance);
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
					r_MGetType.SetBelong(this.instance);
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
					r_MMemberwiseClone.SetBelong(this.instance);
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
					r_MToString.SetBelong(this.instance);
				}
				return r_MToString;
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
            var ___result = RMOnAssetBundleNameGUI_IEnumerable_d_Object_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowNewAssetBundleField(System.Boolean @isVariant)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@isVariant};
            var ___result = RMShowNewAssetBundleField_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AssetBundleTextField(UnityEngine.Rect @rect, System.Int32 @id, System.Collections.Generic.IEnumerable<UnityEngine.Object> @assets, System.Boolean @isVariant)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect, @id, @assets, @isVariant};
            var ___result = RMAssetBundleTextField_Rect_Int32_IEnumerable_d_Object_p__Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowAssetBundlePopup()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMShowAssetBundlePopup.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AssetBundlePopup(UnityEngine.Rect @rect, System.Int32 @id, System.Collections.Generic.IEnumerable<UnityEngine.Object> @assets, System.Boolean @isVariant)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect, @id, @assets, @isVariant};
            var ___result = RMAssetBundlePopup_Rect_Int32_IEnumerable_d_Object_p__Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FilterSelected(System.Collections.Generic.IEnumerable<System.String> @assetBundleNames)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assetBundleNames};
            var ___result = RMFilterSelected_IEnumerable_d_String_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.Generic.IEnumerable<System.String> GetAssetBundlesFromAssets(System.Collections.Generic.IEnumerable<UnityEngine.Object> @assets, System.Boolean @isVariant, out System.Boolean @isMixed)
        {
			@isMixed = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assets, @isVariant, @isMixed};
            var ___result = RMGetAssetBundlesFromAssets_IEnumerable_d_Object_p__Boolean_Out_Boolean.Invoke(___genericsType, ___parameters);
			@isMixed = (System.Boolean)___parameters[2];

            return (System.Collections.Generic.IEnumerable<System.String>)___result;
        }


        public virtual void SetAssetBundleForAssets(System.Collections.Generic.IEnumerable<UnityEngine.Object> @assets, System.String @name, System.Boolean @isVariant)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assets, @name, @isVariant};
            var ___result = RMSetAssetBundleForAssets_IEnumerable_d_Object_p__String_Boolean.Invoke(___genericsType, ___parameters);

            
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
