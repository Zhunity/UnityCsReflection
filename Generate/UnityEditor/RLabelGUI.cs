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
					r_s_AssetLabelsForObjectChangedDelegates = new( ReleactionUtils.GetType("UnityEditor.LabelGUI"), "s_AssetLabelsForObjectChangedDelegates");
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
					r_s_MaxShownLabels = new( ReleactionUtils.GetType("UnityEditor.LabelGUI"), "s_MaxShownLabels");
					r_s_MaxShownLabels.SetBelong(null);
				}
				return r_s_MaxShownLabels;
			}
		}

		/// <summary>
		/// Void OnEnable()
		/// </summary>
		protected RMethod r_ROnEnable;
		public virtual RMethod ROnEnable
		{
			get
			{
				if(r_ROnEnable == null)
				{
					r_ROnEnable = new(this, "OnEnable", 0);
					r_ROnEnable.SetBelong(this.instance);
				}
				return r_ROnEnable;
			}
		}

		/// <summary>
		/// Void OnDisable()
		/// </summary>
		protected RMethod r_ROnDisable;
		public virtual RMethod ROnDisable
		{
			get
			{
				if(r_ROnDisable == null)
				{
					r_ROnDisable = new(this, "OnDisable", 0);
					r_ROnDisable.SetBelong(this.instance);
				}
				return r_ROnDisable;
			}
		}

		/// <summary>
		/// Void OnLostFocus()
		/// </summary>
		protected RMethod r_ROnLostFocus;
		public virtual RMethod ROnLostFocus
		{
			get
			{
				if(r_ROnLostFocus == null)
				{
					r_ROnLostFocus = new(this, "OnLostFocus", 0);
					r_ROnLostFocus.SetBelong(this.instance);
				}
				return r_ROnLostFocus;
			}
		}

		/// <summary>
		/// Void InvalidateLabels()
		/// </summary>
		protected RMethod r_RInvalidateLabels;
		public virtual RMethod RInvalidateLabels
		{
			get
			{
				if(r_RInvalidateLabels == null)
				{
					r_RInvalidateLabels = new(this, "InvalidateLabels", 0);
					r_RInvalidateLabels.SetBelong(this.instance);
				}
				return r_RInvalidateLabels;
			}
		}

		/// <summary>
		/// Void AssetLabelsChangedForObject(UnityEngine.Object)
		/// </summary>
		protected RMethod r_RAssetLabelsChangedForObject_Object;
		public virtual RMethod RAssetLabelsChangedForObject_Object
		{
			get
			{
				if(r_RAssetLabelsChangedForObject_Object == null)
				{
					r_RAssetLabelsChangedForObject_Object = new(this, "AssetLabelsChangedForObject", 0, typeof(UnityEngine.Object));
					r_RAssetLabelsChangedForObject_Object.SetBelong(this.instance);
				}
				return r_RAssetLabelsChangedForObject_Object;
			}
		}

		/// <summary>
		/// Void SaveLabels()
		/// </summary>
		protected RMethod r_RSaveLabels;
		public virtual RMethod RSaveLabels
		{
			get
			{
				if(r_RSaveLabels == null)
				{
					r_RSaveLabels = new(this, "SaveLabels", 0);
					r_RSaveLabels.SetBelong(this.instance);
				}
				return r_RSaveLabels;
			}
		}

		/// <summary>
		/// Void AssetLabelListCallback(ListElement)
		/// </summary>
		protected RMethod r_RAssetLabelListCallback_ListElement;
		public virtual RMethod RAssetLabelListCallback_ListElement
		{
			get
			{
				if(r_RAssetLabelListCallback_ListElement == null)
				{
					r_RAssetLabelListCallback_ListElement = new(this, "AssetLabelListCallback", 0,  ReleactionUtils.GetType("UnityEditor.PopupList+ListElement"));
					r_RAssetLabelListCallback_ListElement.SetBelong(this.instance);
				}
				return r_RAssetLabelListCallback_ListElement;
			}
		}

		/// <summary>
		/// Void InitLabelCache(UnityEngine.Object[])
		/// </summary>
		protected RMethod r_RInitLabelCache_ObjectArray;
		public virtual RMethod RInitLabelCache_ObjectArray
		{
			get
			{
				if(r_RInitLabelCache_ObjectArray == null)
				{
					r_RInitLabelCache_ObjectArray = new(this, "InitLabelCache", 0, typeof(UnityEngine.Object).MakeArrayType());
					r_RInitLabelCache_ObjectArray.SetBelong(this.instance);
				}
				return r_RInitLabelCache_ObjectArray;
			}
		}

		/// <summary>
		/// Void OnLabelGUI(UnityEngine.Object[])
		/// </summary>
		protected RMethod r_ROnLabelGUI_ObjectArray;
		public virtual RMethod ROnLabelGUI_ObjectArray
		{
			get
			{
				if(r_ROnLabelGUI_ObjectArray == null)
				{
					r_ROnLabelGUI_ObjectArray = new(this, "OnLabelGUI", 0, typeof(UnityEngine.Object).MakeArrayType());
					r_ROnLabelGUI_ObjectArray.SetBelong(this.instance);
				}
				return r_ROnLabelGUI_ObjectArray;
			}
		}

		/// <summary>
		/// Void DrawLabelList(Boolean, Single)
		/// </summary>
		protected RMethod r_RDrawLabelList_Boolean_Single;
		public virtual RMethod RDrawLabelList_Boolean_Single
		{
			get
			{
				if(r_RDrawLabelList_Boolean_Single == null)
				{
					r_RDrawLabelList_Boolean_Single = new(this, "DrawLabelList", 0, typeof(System.Boolean), typeof(System.Single));
					r_RDrawLabelList_Boolean_Single.SetBelong(this.instance);
				}
				return r_RDrawLabelList_Boolean_Single;
			}
		}

		/// <summary>
		/// Void GetLabelsForAssets(UnityEngine.Object[], System.Collections.Generic.List`1[System.String] ByRef, System.Collections.Generic.List`1[System.String] ByRef)
		/// </summary>
		protected RMethod r_RGetLabelsForAssets_ObjectArray_Out_List_d_String_p__Out_List_d_String_p_;
		public virtual RMethod RGetLabelsForAssets_ObjectArray_Out_List_d_String_p__Out_List_d_String_p_
		{
			get
			{
				if(r_RGetLabelsForAssets_ObjectArray_Out_List_d_String_p__Out_List_d_String_p_ == null)
				{
					r_RGetLabelsForAssets_ObjectArray_Out_List_d_String_p__Out_List_d_String_p_ = new(this, "GetLabelsForAssets", 0, typeof(UnityEngine.Object).MakeArrayType(), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.String)).MakeByRefType(), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.String)).MakeByRefType());
					r_RGetLabelsForAssets_ObjectArray_Out_List_d_String_p__Out_List_d_String_p_.SetBelong(this.instance);
				}
				return r_RGetLabelsForAssets_ObjectArray_Out_List_d_String_p__Out_List_d_String_p_;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_REquals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_REquals_Object == null)
				{
					r_REquals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_REquals_Object.SetBelong(this.instance);
				}
				return r_REquals_Object;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_RFinalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_RFinalize == null)
				{
					r_RFinalize = new(this, "Finalize", 0);
					r_RFinalize.SetBelong(this.instance);
				}
				return r_RFinalize;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_RGetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_RGetHashCode == null)
				{
					r_RGetHashCode = new(this, "GetHashCode", 0);
					r_RGetHashCode.SetBelong(this.instance);
				}
				return r_RGetHashCode;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_RGetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_RGetType == null)
				{
					r_RGetType = new(this, "GetType", 0);
					r_RGetType.SetBelong(this.instance);
				}
				return r_RGetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_RMemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_RMemberwiseClone == null)
				{
					r_RMemberwiseClone = new(this, "MemberwiseClone", 0);
					r_RMemberwiseClone.SetBelong(this.instance);
				}
				return r_RMemberwiseClone;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_RToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_RToString == null)
				{
					r_RToString = new(this, "ToString", 0);
					r_RToString.SetBelong(this.instance);
				}
				return r_RToString;
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
