using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor
{
	/// <summary>
	/// UnityEditor.LabelGUI
	/// </summary>
    public partial class RLabelGUI : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.HashSet`1[UnityEngine.Object] m_CurrentAssetsSet
		/// </summary>
		protected RSystem.RCollections.RGeneric.RHashSet<RUnityEngine.RObject> r_m_CurrentAssetsSet;
		public virtual RSystem.RCollections.RGeneric.RHashSet<RUnityEngine.RObject> Rm_CurrentAssetsSet
		{
			get
			{
				if(r_m_CurrentAssetsSet == null)
				{
					r_m_CurrentAssetsSet = new(this, "m_CurrentAssetsSet");
					r_m_CurrentAssetsSet.SetBelong(this.instance);
				}
				return r_m_CurrentAssetsSet;
			}
		}

		/// <summary>
		/// UnityEditor.PopupList+InputData m_AssetLabels
		/// </summary>
		protected RUnityEditor.RPopupList.RInputData r_m_AssetLabels;
		public virtual RUnityEditor.RPopupList.RInputData Rm_AssetLabels
		{
			get
			{
				if(r_m_AssetLabels == null)
				{
					r_m_AssetLabels = new(this, "m_AssetLabels");
					r_m_AssetLabels.SetBelong(this.instance);
				}
				return r_m_AssetLabels;
			}
		}

		/// <summary>
		/// System.String m_ChangedLabel
		/// </summary>
		protected RField r_m_ChangedLabel;
		public virtual RField Rm_ChangedLabel
		{
			get
			{
				if(r_m_ChangedLabel == null)
				{
					r_m_ChangedLabel = new(this, "m_ChangedLabel");
					r_m_ChangedLabel.SetBelong(this.instance);
				}
				return r_m_ChangedLabel;
			}
		}

		/// <summary>
		/// System.Boolean m_CurrentChanged
		/// </summary>
		protected RField r_m_CurrentChanged;
		public virtual RField Rm_CurrentChanged
		{
			get
			{
				if(r_m_CurrentChanged == null)
				{
					r_m_CurrentChanged = new(this, "m_CurrentChanged");
					r_m_CurrentChanged.SetBelong(this.instance);
				}
				return r_m_CurrentChanged;
			}
		}

		/// <summary>
		/// System.Boolean m_ChangeWasAdd
		/// </summary>
		protected RField r_m_ChangeWasAdd;
		public virtual RField Rm_ChangeWasAdd
		{
			get
			{
				if(r_m_ChangeWasAdd == null)
				{
					r_m_ChangeWasAdd = new(this, "m_ChangeWasAdd");
					r_m_ChangeWasAdd.SetBelong(this.instance);
				}
				return r_m_ChangeWasAdd;
			}
		}

		/// <summary>
		/// System.Boolean m_IgnoreNextAssetLabelsChangedCall
		/// </summary>
		protected RField r_m_IgnoreNextAssetLabelsChangedCall;
		public virtual RField Rm_IgnoreNextAssetLabelsChangedCall
		{
			get
			{
				if(r_m_IgnoreNextAssetLabelsChangedCall == null)
				{
					r_m_IgnoreNextAssetLabelsChangedCall = new(this, "m_IgnoreNextAssetLabelsChangedCall");
					r_m_IgnoreNextAssetLabelsChangedCall.SetBelong(this.instance);
				}
				return r_m_IgnoreNextAssetLabelsChangedCall;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEngine.Object] s_AssetLabelsForObjectChangedDelegates
		/// </summary>
		protected static RSystem.RAction<RUnityEngine.RObject> r_s_AssetLabelsForObjectChangedDelegates;
		public static RSystem.RAction<RUnityEngine.RObject> Rs_AssetLabelsForObjectChangedDelegates
		{
			get
			{
				if(r_s_AssetLabelsForObjectChangedDelegates == null)
				{
					r_s_AssetLabelsForObjectChangedDelegates = new( ReflectionUtils.GetType("UnityEditor.LabelGUI"), "s_AssetLabelsForObjectChangedDelegates");
					r_s_AssetLabelsForObjectChangedDelegates.SetBelong(null);
				}
				return r_s_AssetLabelsForObjectChangedDelegates;
			}
		}

		/// <summary>
		/// System.Int32 s_MaxShownLabels
		/// </summary>
		protected static RField r_s_MaxShownLabels;
		public static RField Rs_MaxShownLabels
		{
			get
			{
				if(r_s_MaxShownLabels == null)
				{
					r_s_MaxShownLabels = new( ReflectionUtils.GetType("UnityEditor.LabelGUI"), "s_MaxShownLabels");
					r_s_MaxShownLabels.SetBelong(null);
				}
				return r_s_MaxShownLabels;
			}
		}

		/// <summary>
		/// Void OnEnable()
		/// </summary>
		protected RMethod r_OnEnable;
		public virtual RMethod ROnEnable
		{
			get
			{
				if(r_OnEnable == null)
				{
					r_OnEnable = new(this, "OnEnable", 0);
					r_OnEnable.SetBelong(this.instance);
				}
				return r_OnEnable;
			}
		}

		/// <summary>
		/// Void OnDisable()
		/// </summary>
		protected RMethod r_OnDisable;
		public virtual RMethod ROnDisable
		{
			get
			{
				if(r_OnDisable == null)
				{
					r_OnDisable = new(this, "OnDisable", 0);
					r_OnDisable.SetBelong(this.instance);
				}
				return r_OnDisable;
			}
		}

		/// <summary>
		/// Void OnLostFocus()
		/// </summary>
		protected RMethod r_OnLostFocus;
		public virtual RMethod ROnLostFocus
		{
			get
			{
				if(r_OnLostFocus == null)
				{
					r_OnLostFocus = new(this, "OnLostFocus", 0);
					r_OnLostFocus.SetBelong(this.instance);
				}
				return r_OnLostFocus;
			}
		}

		/// <summary>
		/// Void InvalidateLabels()
		/// </summary>
		protected RMethod r_InvalidateLabels;
		public virtual RMethod RInvalidateLabels
		{
			get
			{
				if(r_InvalidateLabels == null)
				{
					r_InvalidateLabels = new(this, "InvalidateLabels", 0);
					r_InvalidateLabels.SetBelong(this.instance);
				}
				return r_InvalidateLabels;
			}
		}

		/// <summary>
		/// Void AssetLabelsChangedForObject(UnityEngine.Object)
		/// </summary>
		protected RMethod r_AssetLabelsChangedForObject_Object;
		public virtual RMethod RAssetLabelsChangedForObject_Object
		{
			get
			{
				if(r_AssetLabelsChangedForObject_Object == null)
				{
					r_AssetLabelsChangedForObject_Object = new(this, "AssetLabelsChangedForObject", 0, typeof(UnityEngine.Object));
					r_AssetLabelsChangedForObject_Object.SetBelong(this.instance);
				}
				return r_AssetLabelsChangedForObject_Object;
			}
		}

		/// <summary>
		/// Void SaveLabels()
		/// </summary>
		protected RMethod r_SaveLabels;
		public virtual RMethod RSaveLabels
		{
			get
			{
				if(r_SaveLabels == null)
				{
					r_SaveLabels = new(this, "SaveLabels", 0);
					r_SaveLabels.SetBelong(this.instance);
				}
				return r_SaveLabels;
			}
		}

		/// <summary>
		/// Void AssetLabelListCallback(ListElement)
		/// </summary>
		protected RMethod r_AssetLabelListCallback_ListElement;
		public virtual RMethod RAssetLabelListCallback_ListElement
		{
			get
			{
				if(r_AssetLabelListCallback_ListElement == null)
				{
					r_AssetLabelListCallback_ListElement = new(this, "AssetLabelListCallback", 0,  ReflectionUtils.GetType("UnityEditor.PopupList+ListElement"));
					r_AssetLabelListCallback_ListElement.SetBelong(this.instance);
				}
				return r_AssetLabelListCallback_ListElement;
			}
		}

		/// <summary>
		/// Void InitLabelCache(UnityEngine.Object[])
		/// </summary>
		protected RMethod r_InitLabelCache_ObjectArray;
		public virtual RMethod RInitLabelCache_ObjectArray
		{
			get
			{
				if(r_InitLabelCache_ObjectArray == null)
				{
					r_InitLabelCache_ObjectArray = new(this, "InitLabelCache", 0, typeof(UnityEngine.Object).MakeArrayType());
					r_InitLabelCache_ObjectArray.SetBelong(this.instance);
				}
				return r_InitLabelCache_ObjectArray;
			}
		}

		/// <summary>
		/// Void OnLabelGUI(UnityEngine.Object[])
		/// </summary>
		protected RMethod r_OnLabelGUI_ObjectArray;
		public virtual RMethod ROnLabelGUI_ObjectArray
		{
			get
			{
				if(r_OnLabelGUI_ObjectArray == null)
				{
					r_OnLabelGUI_ObjectArray = new(this, "OnLabelGUI", 0, typeof(UnityEngine.Object).MakeArrayType());
					r_OnLabelGUI_ObjectArray.SetBelong(this.instance);
				}
				return r_OnLabelGUI_ObjectArray;
			}
		}

		/// <summary>
		/// Void DrawLabelList(Boolean, Single)
		/// </summary>
		protected RMethod r_DrawLabelList_Boolean_Single;
		public virtual RMethod RDrawLabelList_Boolean_Single
		{
			get
			{
				if(r_DrawLabelList_Boolean_Single == null)
				{
					r_DrawLabelList_Boolean_Single = new(this, "DrawLabelList", 0, typeof(System.Boolean), typeof(System.Single));
					r_DrawLabelList_Boolean_Single.SetBelong(this.instance);
				}
				return r_DrawLabelList_Boolean_Single;
			}
		}

		/// <summary>
		/// Void GetLabelsForAssets(UnityEngine.Object[], System.Collections.Generic.List`1[System.String] ByRef, System.Collections.Generic.List`1[System.String] ByRef)
		/// </summary>
		protected RMethod r_GetLabelsForAssets_ObjectArray_Out_List_d_String_p__Out_List_d_String_p_;
		public virtual RMethod RGetLabelsForAssets_ObjectArray_Out_List_d_String_p__Out_List_d_String_p_
		{
			get
			{
				if(r_GetLabelsForAssets_ObjectArray_Out_List_d_String_p__Out_List_d_String_p_ == null)
				{
					r_GetLabelsForAssets_ObjectArray_Out_List_d_String_p__Out_List_d_String_p_ = new(this, "GetLabelsForAssets", 0, typeof(UnityEngine.Object).MakeArrayType(), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.String)).MakeByRefType(), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.String)).MakeByRefType());
					r_GetLabelsForAssets_ObjectArray_Out_List_d_String_p__Out_List_d_String_p_.SetBelong(this.instance);
				}
				return r_GetLabelsForAssets_ObjectArray_Out_List_d_String_p__Out_List_d_String_p_;
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


        public RLabelGUI() : base("UnityEditor.LabelGUI")
        {
        }

        public RLabelGUI(System.Object instance) : base("UnityEditor.LabelGUI")
		{
            SetInstance(instance);
		}

        public RLabelGUI(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RLabelGUI(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void OnEnable()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnEnable.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDisable()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnDisable.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnLostFocus()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnLostFocus.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InvalidateLabels()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInvalidateLabels.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AssetLabelsChangedForObject(UnityEngine.Object  @asset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@asset};
            var ___result = RAssetLabelsChangedForObject_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SaveLabels()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSaveLabels.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void InitLabelCache(UnityEngine.Object[]  @assets)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assets};
            var ___result = RInitLabelCache_ObjectArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnLabelGUI(UnityEngine.Object[]  @assets)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assets};
            var ___result = ROnLabelGUI_ObjectArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawLabelList(System.Boolean  @partiallySelected, System.Single  @xMax)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@partiallySelected, @xMax};
            var ___result = RDrawLabelList_Boolean_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetLabelsForAssets(UnityEngine.Object[]  @assets, out System.Collections.Generic.List<System.String>  @all, out System.Collections.Generic.List<System.String>  @partial)
        {
			all = default;
			partial = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assets, @all, @partial};
            var ___result = RGetLabelsForAssets_ObjectArray_Out_List_d_String_p__Out_List_d_String_p_.Invoke(___genericsType, ___parameters);
			all = (System.Collections.Generic.List<System.String>)___parameters[1];
			partial = (System.Collections.Generic.List<System.String>)___parameters[2];

            
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
