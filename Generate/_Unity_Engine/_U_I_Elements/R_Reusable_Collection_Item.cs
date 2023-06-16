
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.UIElements.ReusableCollectionItem
	/// </summary>
    public partial class RReusableCollectionItem : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.ReusableCollectionItem");
            }
        }

        public RReusableCollectionItem() : base("UnityEngine.UIElements.ReusableCollectionItem")
        {
        }

        public RReusableCollectionItem(System.Object instance) : base("UnityEngine.UIElements.ReusableCollectionItem")
		{
            SetInstance(instance);
		}

        public RReusableCollectionItem(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RReusableCollectionItem(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Action`1[UnityEngine.UIElements.ReusableCollectionItem] onGeometryChanged
		/// </summary>
		protected REvent r_EonGeometryChanged;
		public virtual REvent REonGeometryChanged
		{
			get
			{
				if(r_EonGeometryChanged == null)
				{
					r_EonGeometryChanged = new(this, "onGeometryChanged");
				}
				return r_EonGeometryChanged;
			}
		}

		/// <summary>
		/// System.Int32 UndefinedIndex
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FUndefinedIndex;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFUndefinedIndex
		{
			get
			{
				if(r_FUndefinedIndex == null)
				{
					r_FUndefinedIndex = new(Type, "UndefinedIndex");
				}
				return r_FUndefinedIndex;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement <bindableElement>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_F__0__bindableElement__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RF__0__bindableElement__1__k__BackingField
		{
			get
			{
				if(r_F__0__bindableElement__1__k__BackingField == null)
				{
					r_F__0__bindableElement__1__k__BackingField = new(this, "<bindableElement>k__BackingField");
				}
				return r_F__0__bindableElement__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[UnityEngine.UIElements.Experimental.StyleValues] <animator>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RExperimental.RValueAnimation<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RExperimental.RStyleValues> r_F__0__animator__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RExperimental.RValueAnimation<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RExperimental.RStyleValues> RF__0__animator__1__k__BackingField
		{
			get
			{
				if(r_F__0__animator__1__k__BackingField == null)
				{
					r_F__0__animator__1__k__BackingField = new(this, "<animator>k__BackingField");
				}
				return r_F__0__animator__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int32 <index>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F__0__index__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF__0__index__1__k__BackingField
		{
			get
			{
				if(r_F__0__index__1__k__BackingField == null)
				{
					r_F__0__index__1__k__BackingField = new(this, "<index>k__BackingField");
				}
				return r_F__0__index__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int32 <id>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F__0__id__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF__0__id__1__k__BackingField
		{
			get
			{
				if(r_F__0__id__1__k__BackingField == null)
				{
					r_F__0__id__1__k__BackingField = new(this, "<id>k__BackingField");
				}
				return r_F__0__id__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean <isDragGhost>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_F__0__isDragGhost__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RF__0__isDragGhost__1__k__BackingField
		{
			get
			{
				if(r_F__0__isDragGhost__1__k__BackingField == null)
				{
					r_F__0__isDragGhost__1__k__BackingField = new(this, "<isDragGhost>k__BackingField");
				}
				return r_F__0__isDragGhost__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEngine.UIElements.ReusableCollectionItem] onGeometryChanged
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RReusableCollectionItem> r_FonGeometryChanged;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RReusableCollectionItem> RFonGeometryChanged
		{
			get
			{
				if(r_FonGeometryChanged == null)
				{
					r_FonGeometryChanged = new(this, "onGeometryChanged");
				}
				return r_FonGeometryChanged;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EventCallback`1[UnityEngine.UIElements.GeometryChangedEvent] m_GeometryChangedEventCallback
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventCallback<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RGeometryChangedEvent> r_Fm_GeometryChangedEventCallback;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventCallback<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RGeometryChangedEvent> RFm_GeometryChangedEventCallback
		{
			get
			{
				if(r_Fm_GeometryChangedEventCallback == null)
				{
					r_Fm_GeometryChangedEventCallback = new(this, "m_GeometryChangedEventCallback");
				}
				return r_Fm_GeometryChangedEventCallback;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement rootElement
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_ProotElement;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RProotElement
		{
			get
			{
				if(r_ProotElement == null)
				{
					r_ProotElement = new(this, "rootElement", -1);
				}
				return r_ProotElement;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement bindableElement
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_PbindableElement;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RPbindableElement
		{
			get
			{
				if(r_PbindableElement == null)
				{
					r_PbindableElement = new(this, "bindableElement", -1);
				}
				return r_PbindableElement;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[UnityEngine.UIElements.Experimental.StyleValues] animator
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RExperimental.RValueAnimation<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RExperimental.RStyleValues> r_Panimator;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RExperimental.RValueAnimation<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RExperimental.RStyleValues> RPanimator
		{
			get
			{
				if(r_Panimator == null)
				{
					r_Panimator = new(this, "animator", -1);
				}
				return r_Panimator;
			}
		}

		/// <summary>
		/// Int32 index
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Pindex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPindex
		{
			get
			{
				if(r_Pindex == null)
				{
					r_Pindex = new(this, "index", -1);
				}
				return r_Pindex;
			}
		}

		/// <summary>
		/// Int32 id
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Pid;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPid
		{
			get
			{
				if(r_Pid == null)
				{
					r_Pid = new(this, "id", -1);
				}
				return r_Pid;
			}
		}

		/// <summary>
		/// Boolean isDragGhost
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisDragGhost;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisDragGhost
		{
			get
			{
				if(r_PisDragGhost == null)
				{
					r_PisDragGhost = new(this, "isDragGhost", -1);
				}
				return r_PisDragGhost;
			}
		}

		/// <summary>
		/// Void Init(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MInit_VisualElement;
		public virtual RMethod RMInit_VisualElement
		{
			get
			{
				if(r_MInit_VisualElement == null)
				{
					r_MInit_VisualElement = new(this, "Init", 0, typeof(UnityEngine.UIElements.VisualElement));
				}
				return r_MInit_VisualElement;
			}
		}

		/// <summary>
		/// Void PreAttachElement()
		/// </summary>
		protected RMethod r_MPreAttachElement;
		public virtual RMethod RMPreAttachElement
		{
			get
			{
				if(r_MPreAttachElement == null)
				{
					r_MPreAttachElement = new(this, "PreAttachElement", 0);
				}
				return r_MPreAttachElement;
			}
		}

		/// <summary>
		/// Void DetachElement()
		/// </summary>
		protected RMethod r_MDetachElement;
		public virtual RMethod RMDetachElement
		{
			get
			{
				if(r_MDetachElement == null)
				{
					r_MDetachElement = new(this, "DetachElement", 0);
				}
				return r_MDetachElement;
			}
		}

		/// <summary>
		/// Void SetSelected(Boolean)
		/// </summary>
		protected RMethod r_MSetSelected_Boolean;
		public virtual RMethod RMSetSelected_Boolean
		{
			get
			{
				if(r_MSetSelected_Boolean == null)
				{
					r_MSetSelected_Boolean = new(this, "SetSelected", 0, typeof(System.Boolean));
				}
				return r_MSetSelected_Boolean;
			}
		}

		/// <summary>
		/// Void OnGeometryChanged(UnityEngine.UIElements.GeometryChangedEvent)
		/// </summary>
		protected RMethod r_MOnGeometryChanged_GeometryChangedEvent;
		public virtual RMethod RMOnGeometryChanged_GeometryChangedEvent
		{
			get
			{
				if(r_MOnGeometryChanged_GeometryChangedEvent == null)
				{
					r_MOnGeometryChanged_GeometryChangedEvent = new(this, "OnGeometryChanged", 0, typeof(UnityEngine.UIElements.GeometryChangedEvent));
				}
				return r_MOnGeometryChanged_GeometryChangedEvent;
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


        public virtual void Init(UnityEngine.UIElements.VisualElement @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RMInit_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PreAttachElement()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMPreAttachElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DetachElement()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDetachElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetSelected(System.Boolean @selected)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@selected};
            var ___result = RMSetSelected_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnGeometryChanged(UnityEngine.UIElements.GeometryChangedEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMOnGeometryChanged_GeometryChangedEvent.Invoke(___genericsType, ___parameters);

            
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
