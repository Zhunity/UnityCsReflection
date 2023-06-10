
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.ReusableListViewItem
	/// </summary>
    public partial class RReusableListViewItem : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.ReusableListViewItem");
            }
        }

        public RReusableListViewItem() : base("UnityEngine.UIElements.ReusableListViewItem")
        {
        }

        public RReusableListViewItem(System.Object instance) : base("UnityEngine.UIElements.ReusableListViewItem")
		{
            SetInstance(instance);
		}

        public RReusableListViewItem(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RReusableListViewItem(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
		/// UnityEngine.UIElements.VisualElement m_Container
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_Fm_Container;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RFm_Container
		{
			get
			{
				if(r_Fm_Container == null)
				{
					r_Fm_Container = new(this, "m_Container");
				}
				return r_Fm_Container;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement m_DragHandle
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_Fm_DragHandle;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RFm_DragHandle
		{
			get
			{
				if(r_Fm_DragHandle == null)
				{
					r_Fm_DragHandle = new(this, "m_DragHandle");
				}
				return r_Fm_DragHandle;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement m_ItemContainer
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_Fm_ItemContainer;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RFm_ItemContainer
		{
			get
			{
				if(r_Fm_ItemContainer == null)
				{
					r_Fm_ItemContainer = new(this, "m_ItemContainer");
				}
				return r_Fm_ItemContainer;
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
		/// Void Init(UnityEngine.UIElements.VisualElement, Boolean)
		/// </summary>
		protected RMethod r_MInit_VisualElement_Boolean;
		public virtual RMethod RMInit_VisualElement_Boolean
		{
			get
			{
				if(r_MInit_VisualElement_Boolean == null)
				{
					r_MInit_VisualElement_Boolean = new(this, "Init", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(System.Boolean));
				}
				return r_MInit_VisualElement_Boolean;
			}
		}

		/// <summary>
		/// Void UpdateHierarchy(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.VisualElement, Boolean)
		/// </summary>
		protected RMethod r_MUpdateHierarchy_VisualElement_VisualElement_Boolean;
		public virtual RMethod RMUpdateHierarchy_VisualElement_VisualElement_Boolean
		{
			get
			{
				if(r_MUpdateHierarchy_VisualElement_VisualElement_Boolean == null)
				{
					r_MUpdateHierarchy_VisualElement_VisualElement_Boolean = new(this, "UpdateHierarchy", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.UIElements.VisualElement), typeof(System.Boolean));
				}
				return r_MUpdateHierarchy_VisualElement_VisualElement_Boolean;
			}
		}

		/// <summary>
		/// Void UpdateDragHandle(Boolean)
		/// </summary>
		protected RMethod r_MUpdateDragHandle_Boolean;
		public virtual RMethod RMUpdateDragHandle_Boolean
		{
			get
			{
				if(r_MUpdateDragHandle_Boolean == null)
				{
					r_MUpdateDragHandle_Boolean = new(this, "UpdateDragHandle", 0, typeof(System.Boolean));
				}
				return r_MUpdateDragHandle_Boolean;
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


        public virtual void Init(UnityEngine.UIElements.VisualElement @item, System.Boolean @usesAnimatedDragger)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item, @usesAnimatedDragger};
            var ___result = RMInit_VisualElement_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateHierarchy(UnityEngine.UIElements.VisualElement @root, UnityEngine.UIElements.VisualElement @item, System.Boolean @usesAnimatedDragger)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@root, @item, @usesAnimatedDragger};
            var ___result = RMUpdateHierarchy_VisualElement_VisualElement_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateDragHandle(System.Boolean @needsDragHandle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@needsDragHandle};
            var ___result = RMUpdateDragHandle_Boolean.Invoke(___genericsType, ___parameters);

            
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


        public virtual void Init(UnityEngine.UIElements.VisualElement @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item};
            var ___result = RMInit_VisualElement.Invoke(___genericsType, ___parameters);

            
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
