
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEditor.LabelGUI
	/// </summary>
    public partial class RLabelGUI : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.LabelGUI");
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


		/// <summary>
		/// System.Collections.Generic.HashSet`1[UnityEngine.Object] m_CurrentAssetsSet
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RHashSet<Hvak.Editor.Refleaction.RUnityEngine.RObject> r_Fm_CurrentAssetsSet;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RHashSet<Hvak.Editor.Refleaction.RUnityEngine.RObject> RFm_CurrentAssetsSet
		{
			get
			{
				if(r_Fm_CurrentAssetsSet == null)
				{
					r_Fm_CurrentAssetsSet = new(this, "m_CurrentAssetsSet");
				}
				return r_Fm_CurrentAssetsSet;
			}
		}

		/// <summary>
		/// UnityEditor.PopupList+InputData m_AssetLabels
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPopupList.RInputData r_Fm_AssetLabels;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPopupList.RInputData RFm_AssetLabels
		{
			get
			{
				if(r_Fm_AssetLabels == null)
				{
					r_Fm_AssetLabels = new(this, "m_AssetLabels");
				}
				return r_Fm_AssetLabels;
			}
		}

		/// <summary>
		/// System.String m_ChangedLabel
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_ChangedLabel;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_ChangedLabel
		{
			get
			{
				if(r_Fm_ChangedLabel == null)
				{
					r_Fm_ChangedLabel = new(this, "m_ChangedLabel");
				}
				return r_Fm_ChangedLabel;
			}
		}

		/// <summary>
		/// System.Boolean m_CurrentChanged
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_CurrentChanged;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_CurrentChanged
		{
			get
			{
				if(r_Fm_CurrentChanged == null)
				{
					r_Fm_CurrentChanged = new(this, "m_CurrentChanged");
				}
				return r_Fm_CurrentChanged;
			}
		}

		/// <summary>
		/// System.Boolean m_ChangeWasAdd
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_ChangeWasAdd;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_ChangeWasAdd
		{
			get
			{
				if(r_Fm_ChangeWasAdd == null)
				{
					r_Fm_ChangeWasAdd = new(this, "m_ChangeWasAdd");
				}
				return r_Fm_ChangeWasAdd;
			}
		}

		/// <summary>
		/// System.Boolean m_IgnoreNextAssetLabelsChangedCall
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_IgnoreNextAssetLabelsChangedCall;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_IgnoreNextAssetLabelsChangedCall
		{
			get
			{
				if(r_Fm_IgnoreNextAssetLabelsChangedCall == null)
				{
					r_Fm_IgnoreNextAssetLabelsChangedCall = new(this, "m_IgnoreNextAssetLabelsChangedCall");
				}
				return r_Fm_IgnoreNextAssetLabelsChangedCall;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEngine.Object] s_AssetLabelsForObjectChangedDelegates
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEngine.RObject> r_Fs_AssetLabelsForObjectChangedDelegates;
		public static Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEngine.RObject> RFs_AssetLabelsForObjectChangedDelegates
		{
			get
			{
				if(r_Fs_AssetLabelsForObjectChangedDelegates == null)
				{
					r_Fs_AssetLabelsForObjectChangedDelegates = new(Type, "s_AssetLabelsForObjectChangedDelegates");
				}
				return r_Fs_AssetLabelsForObjectChangedDelegates;
			}
		}

		/// <summary>
		/// System.Int32 s_MaxShownLabels
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_Fs_MaxShownLabels;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFs_MaxShownLabels
		{
			get
			{
				if(r_Fs_MaxShownLabels == null)
				{
					r_Fs_MaxShownLabels = new(Type, "s_MaxShownLabels");
				}
				return r_Fs_MaxShownLabels;
			}
		}

		/// <summary>
		/// Void OnEnable()
		/// </summary>
		protected RMethod r_MOnEnable;
		public virtual RMethod RMOnEnable
		{
			get
			{
				if(r_MOnEnable == null)
				{
					r_MOnEnable = new(this, "OnEnable", 0);
				}
				return r_MOnEnable;
			}
		}

		/// <summary>
		/// Void OnDisable()
		/// </summary>
		protected RMethod r_MOnDisable;
		public virtual RMethod RMOnDisable
		{
			get
			{
				if(r_MOnDisable == null)
				{
					r_MOnDisable = new(this, "OnDisable", 0);
				}
				return r_MOnDisable;
			}
		}

		/// <summary>
		/// Void OnLostFocus()
		/// </summary>
		protected RMethod r_MOnLostFocus;
		public virtual RMethod RMOnLostFocus
		{
			get
			{
				if(r_MOnLostFocus == null)
				{
					r_MOnLostFocus = new(this, "OnLostFocus", 0);
				}
				return r_MOnLostFocus;
			}
		}

		/// <summary>
		/// Void InvalidateLabels()
		/// </summary>
		protected RMethod r_MInvalidateLabels;
		public virtual RMethod RMInvalidateLabels
		{
			get
			{
				if(r_MInvalidateLabels == null)
				{
					r_MInvalidateLabels = new(this, "InvalidateLabels", 0);
				}
				return r_MInvalidateLabels;
			}
		}

		/// <summary>
		/// Void AssetLabelsChangedForObject(UnityEngine.Object)
		/// </summary>
		protected RMethod r_MAssetLabelsChangedForObject_Object;
		public virtual RMethod RMAssetLabelsChangedForObject_Object
		{
			get
			{
				if(r_MAssetLabelsChangedForObject_Object == null)
				{
					r_MAssetLabelsChangedForObject_Object = new(this, "AssetLabelsChangedForObject", 0, typeof(UnityEngine.Object));
				}
				return r_MAssetLabelsChangedForObject_Object;
			}
		}

		/// <summary>
		/// Void SaveLabels()
		/// </summary>
		protected RMethod r_MSaveLabels;
		public virtual RMethod RMSaveLabels
		{
			get
			{
				if(r_MSaveLabels == null)
				{
					r_MSaveLabels = new(this, "SaveLabels", 0);
				}
				return r_MSaveLabels;
			}
		}

		/// <summary>
		/// Void AssetLabelListCallback(ListElement)
		/// </summary>
		protected RMethod r_MAssetLabelListCallback_ListElement;
		public virtual RMethod RMAssetLabelListCallback_ListElement
		{
			get
			{
				if(r_MAssetLabelListCallback_ListElement == null)
				{
					r_MAssetLabelListCallback_ListElement = new(this, "AssetLabelListCallback", 0,  ReflectionUtils.GetType("UnityEditor.PopupList+ListElement"));
				}
				return r_MAssetLabelListCallback_ListElement;
			}
		}

		/// <summary>
		/// Void InitLabelCache(UnityEngine.Object[])
		/// </summary>
		protected RMethod r_MInitLabelCache_ObjectArray;
		public virtual RMethod RMInitLabelCache_ObjectArray
		{
			get
			{
				if(r_MInitLabelCache_ObjectArray == null)
				{
					r_MInitLabelCache_ObjectArray = new(this, "InitLabelCache", 0, typeof(UnityEngine.Object).MakeArrayType());
				}
				return r_MInitLabelCache_ObjectArray;
			}
		}

		/// <summary>
		/// Void OnLabelGUI(UnityEngine.Object[])
		/// </summary>
		protected RMethod r_MOnLabelGUI_ObjectArray;
		public virtual RMethod RMOnLabelGUI_ObjectArray
		{
			get
			{
				if(r_MOnLabelGUI_ObjectArray == null)
				{
					r_MOnLabelGUI_ObjectArray = new(this, "OnLabelGUI", 0, typeof(UnityEngine.Object).MakeArrayType());
				}
				return r_MOnLabelGUI_ObjectArray;
			}
		}

		/// <summary>
		/// Void DrawLabelList(Boolean, Single)
		/// </summary>
		protected RMethod r_MDrawLabelList_Boolean_Single;
		public virtual RMethod RMDrawLabelList_Boolean_Single
		{
			get
			{
				if(r_MDrawLabelList_Boolean_Single == null)
				{
					r_MDrawLabelList_Boolean_Single = new(this, "DrawLabelList", 0, typeof(System.Boolean), typeof(System.Single));
				}
				return r_MDrawLabelList_Boolean_Single;
			}
		}

		/// <summary>
		/// Void GetLabelsForAssets(UnityEngine.Object[], System.Collections.Generic.List`1[System.String] ByRef, System.Collections.Generic.List`1[System.String] ByRef)
		/// </summary>
		protected RMethod r_MGetLabelsForAssets_ObjectArray_Out_List_d_String_p__Out_List_d_String_p_;
		public virtual RMethod RMGetLabelsForAssets_ObjectArray_Out_List_d_String_p__Out_List_d_String_p_
		{
			get
			{
				if(r_MGetLabelsForAssets_ObjectArray_Out_List_d_String_p__Out_List_d_String_p_ == null)
				{
					r_MGetLabelsForAssets_ObjectArray_Out_List_d_String_p__Out_List_d_String_p_ = new(this, "GetLabelsForAssets", 0, typeof(UnityEngine.Object).MakeArrayType(),  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(System.String)).MakeByRefType(),  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(System.String)).MakeByRefType());
				}
				return r_MGetLabelsForAssets_ObjectArray_Out_List_d_String_p__Out_List_d_String_p_;
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


        public virtual void OnEnable()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnEnable.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDisable()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnDisable.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnLostFocus()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnLostFocus.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InvalidateLabels()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInvalidateLabels.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AssetLabelsChangedForObject(UnityEngine.Object @asset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@asset};
            var ___result = RMAssetLabelsChangedForObject_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SaveLabels()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSaveLabels.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AssetLabelListCallback(Hvak.Editor.Refleaction.RUnityEditor.RPopupList.RListElement @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element.Value};
            var ___result = RMAssetLabelListCallback_ListElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InitLabelCache(UnityEngine.Object[] @assets)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assets};
            var ___result = RMInitLabelCache_ObjectArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnLabelGUI(UnityEngine.Object[] @assets)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assets};
            var ___result = RMOnLabelGUI_ObjectArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawLabelList(System.Boolean @partiallySelected, System.Single @xMax)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@partiallySelected, @xMax};
            var ___result = RMDrawLabelList_Boolean_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetLabelsForAssets(UnityEngine.Object[] @assets, out System.Collections.Generic.List<System.String> @all, out System.Collections.Generic.List<System.String> @partial)
        {
			@all = default;
			@partial = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assets, @all, @partial};
            var ___result = RMGetLabelsForAssets_ObjectArray_Out_List_d_String_p__Out_List_d_String_p_.Invoke(___genericsType, ___parameters);
			@all = ReflectionUtils.Convert<System.Collections.Generic.List<System.String>>(___parameters[1]);
			@partial = ReflectionUtils.Convert<System.Collections.Generic.List<System.String>>(___parameters[2]);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


    }
}
