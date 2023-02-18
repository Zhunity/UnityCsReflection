
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor
{
	/// <summary>
	/// UnityEditor.View
	/// </summary>
    public partial class RView : RMember //
    {

		/// <summary>
		/// UnityEditor.MonoReloadableIntPtr m_ViewPtr
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RMonoReloadableIntPtr r_Fm_ViewPtr;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RMonoReloadableIntPtr RFm_ViewPtr
		{
			get
			{
				if(r_Fm_ViewPtr == null)
				{
					r_Fm_ViewPtr = new(this, "m_ViewPtr");
					r_Fm_ViewPtr.SetBelong(this.GetValue());
				}
				return r_Fm_ViewPtr;
			}
		}

		/// <summary>
		/// UnityEditor.View[] m_Children
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEditor.RView> r_Fm_Children;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEditor.RView> RFm_Children
		{
			get
			{
				if(r_Fm_Children == null)
				{
					r_Fm_Children = new(this, "m_Children");
					r_Fm_Children.SetBelong(this.GetValue());
				}
				return r_Fm_Children;
			}
		}

		/// <summary>
		/// UnityEditor.View m_Parent
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RView r_Fm_Parent;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RView RFm_Parent
		{
			get
			{
				if(r_Fm_Parent == null)
				{
					r_Fm_Parent = new(this, "m_Parent");
					r_Fm_Parent.SetBelong(this.GetValue());
				}
				return r_Fm_Parent;
			}
		}

		/// <summary>
		/// UnityEditor.ContainerWindow m_Window
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RContainerWindow r_Fm_Window;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RContainerWindow RFm_Window
		{
			get
			{
				if(r_Fm_Window == null)
				{
					r_Fm_Window = new(this, "m_Window");
					r_Fm_Window.SetBelong(this.GetValue());
				}
				return r_Fm_Window;
			}
		}

		/// <summary>
		/// UnityEngine.Rect m_Position
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRect r_Fm_Position;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRect RFm_Position
		{
			get
			{
				if(r_Fm_Position == null)
				{
					r_Fm_Position = new(this, "m_Position");
					r_Fm_Position.SetBelong(this.GetValue());
				}
				return r_Fm_Position;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 m_MinSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_Fm_MinSize;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RFm_MinSize
		{
			get
			{
				if(r_Fm_MinSize == null)
				{
					r_Fm_MinSize = new(this, "m_MinSize");
					r_Fm_MinSize.SetBelong(this.GetValue());
				}
				return r_Fm_MinSize;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 m_MaxSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_Fm_MaxSize;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RFm_MaxSize
		{
			get
			{
				if(r_Fm_MaxSize == null)
				{
					r_Fm_MaxSize = new(this, "m_MaxSize");
					r_Fm_MaxSize.SetBelong(this.GetValue());
				}
				return r_Fm_MaxSize;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 minSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_PminSize;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RPminSize
		{
			get
			{
				if(r_PminSize == null)
				{
					r_PminSize = new(this, "minSize", -1);
					r_PminSize.SetBelong(this.GetValue());
				}
				return r_PminSize;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 maxSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_PmaxSize;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RPmaxSize
		{
			get
			{
				if(r_PmaxSize == null)
				{
					r_PmaxSize = new(this, "maxSize", -1);
					r_PmaxSize.SetBelong(this.GetValue());
				}
				return r_PmaxSize;
			}
		}

		/// <summary>
		/// UnityEditor.View[] allChildren
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEditor.RView> r_PallChildren;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEditor.RView> RPallChildren
		{
			get
			{
				if(r_PallChildren == null)
				{
					r_PallChildren = new(this, "allChildren", -1);
					r_PallChildren.SetBelong(this.GetValue());
				}
				return r_PallChildren;
			}
		}

		/// <summary>
		/// UnityEngine.Rect position
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRect r_Pposition;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRect RPposition
		{
			get
			{
				if(r_Pposition == null)
				{
					r_Pposition = new(this, "position", -1);
					r_Pposition.SetBelong(this.GetValue());
				}
				return r_Pposition;
			}
		}

		/// <summary>
		/// UnityEngine.Rect windowPosition
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRect r_PwindowPosition;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRect RPwindowPosition
		{
			get
			{
				if(r_PwindowPosition == null)
				{
					r_PwindowPosition = new(this, "windowPosition", -1);
					r_PwindowPosition.SetBelong(this.GetValue());
				}
				return r_PwindowPosition;
			}
		}

		/// <summary>
		/// UnityEngine.Rect screenPosition
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRect r_PscreenPosition;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRect RPscreenPosition
		{
			get
			{
				if(r_PscreenPosition == null)
				{
					r_PscreenPosition = new(this, "screenPosition", -1);
					r_PscreenPosition.SetBelong(this.GetValue());
				}
				return r_PscreenPosition;
			}
		}

		/// <summary>
		/// UnityEditor.ContainerWindow window
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RContainerWindow r_Pwindow;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RContainerWindow RPwindow
		{
			get
			{
				if(r_Pwindow == null)
				{
					r_Pwindow = new(this, "window", -1);
					r_Pwindow.SetBelong(this.GetValue());
				}
				return r_Pwindow;
			}
		}

		/// <summary>
		/// UnityEditor.View parent
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RView r_Pparent;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RView RPparent
		{
			get
			{
				if(r_Pparent == null)
				{
					r_Pparent = new(this, "parent", -1);
					r_Pparent.SetBelong(this.GetValue());
				}
				return r_Pparent;
			}
		}

		/// <summary>
		/// UnityEditor.View[] children
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEditor.RView> r_Pchildren;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEditor.RView> RPchildren
		{
			get
			{
				if(r_Pchildren == null)
				{
					r_Pchildren = new(this, "children", -1);
					r_Pchildren.SetBelong(this.GetValue());
				}
				return r_Pchildren;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Pname;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPname
		{
			get
			{
				if(r_Pname == null)
				{
					r_Pname = new(this, "name", -1);
					r_Pname.SetBelong(this.GetValue());
				}
				return r_Pname;
			}
		}

		/// <summary>
		/// UnityEngine.HideFlags hideFlags
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RHideFlags r_PhideFlags;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RHideFlags RPhideFlags
		{
			get
			{
				if(r_PhideFlags == null)
				{
					r_PhideFlags = new(this, "hideFlags", -1);
					r_PhideFlags.SetBelong(this.GetValue());
				}
				return r_PhideFlags;
			}
		}

		/// <summary>
		/// Void Reflow()
		/// </summary>
		protected RMethod r_MReflow;
		public virtual RMethod RMReflow
		{
			get
			{
				if(r_MReflow == null)
				{
					r_MReflow = new(this, "Reflow", 0);
					r_MReflow.SetBelong(this.GetValue());
				}
				return r_MReflow;
			}
		}

		/// <summary>
		/// System.String DebugHierarchy(Int32)
		/// </summary>
		protected RMethod r_MDebugHierarchy_Int32;
		public virtual RMethod RMDebugHierarchy_Int32
		{
			get
			{
				if(r_MDebugHierarchy_Int32 == null)
				{
					r_MDebugHierarchy_Int32 = new(this, "DebugHierarchy", 0, typeof(System.Int32));
					r_MDebugHierarchy_Int32.SetBelong(this.GetValue());
				}
				return r_MDebugHierarchy_Int32;
			}
		}

		/// <summary>
		/// Void Initialize(UnityEditor.ContainerWindow)
		/// </summary>
		protected RMethod r_MInitialize_ContainerWindow;
		public virtual RMethod RMInitialize_ContainerWindow
		{
			get
			{
				if(r_MInitialize_ContainerWindow == null)
				{
					r_MInitialize_ContainerWindow = new(this, "Initialize", 0,  ReflectionUtils.GetType("UnityEditor.ContainerWindow"));
					r_MInitialize_ContainerWindow.SetBelong(this.GetValue());
				}
				return r_MInitialize_ContainerWindow;
			}
		}

		/// <summary>
		/// Void SetMinMaxSizes(UnityEngine.Vector2, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MSetMinMaxSizes_Vector2_Vector2;
		public virtual RMethod RMSetMinMaxSizes_Vector2_Vector2
		{
			get
			{
				if(r_MSetMinMaxSizes_Vector2_Vector2 == null)
				{
					r_MSetMinMaxSizes_Vector2_Vector2 = new(this, "SetMinMaxSizes", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2));
					r_MSetMinMaxSizes_Vector2_Vector2.SetBelong(this.GetValue());
				}
				return r_MSetMinMaxSizes_Vector2_Vector2;
			}
		}

		/// <summary>
		/// Void ChildrenMinMaxChanged()
		/// </summary>
		protected RMethod r_MChildrenMinMaxChanged;
		public virtual RMethod RMChildrenMinMaxChanged
		{
			get
			{
				if(r_MChildrenMinMaxChanged == null)
				{
					r_MChildrenMinMaxChanged = new(this, "ChildrenMinMaxChanged", 0);
					r_MChildrenMinMaxChanged.SetBelong(this.GetValue());
				}
				return r_MChildrenMinMaxChanged;
			}
		}

		/// <summary>
		/// Void __internalAwake()
		/// </summary>
		protected RMethod r_M__internalAwake;
		public virtual RMethod RM__internalAwake
		{
			get
			{
				if(r_M__internalAwake == null)
				{
					r_M__internalAwake = new(this, "__internalAwake", 0);
					r_M__internalAwake.SetBelong(this.GetValue());
				}
				return r_M__internalAwake;
			}
		}

		/// <summary>
		/// Void SetPosition(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_MSetPosition_Rect;
		public virtual RMethod RMSetPosition_Rect
		{
			get
			{
				if(r_MSetPosition_Rect == null)
				{
					r_MSetPosition_Rect = new(this, "SetPosition", 0, typeof(UnityEngine.Rect));
					r_MSetPosition_Rect.SetBelong(this.GetValue());
				}
				return r_MSetPosition_Rect;
			}
		}

		/// <summary>
		/// Void SetPositionOnly(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_MSetPositionOnly_Rect;
		public virtual RMethod RMSetPositionOnly_Rect
		{
			get
			{
				if(r_MSetPositionOnly_Rect == null)
				{
					r_MSetPositionOnly_Rect = new(this, "SetPositionOnly", 0, typeof(UnityEngine.Rect));
					r_MSetPositionOnly_Rect.SetBelong(this.GetValue());
				}
				return r_MSetPositionOnly_Rect;
			}
		}

		/// <summary>
		/// Int32 IndexOfChild(UnityEditor.View)
		/// </summary>
		protected RMethod r_MIndexOfChild_View;
		public virtual RMethod RMIndexOfChild_View
		{
			get
			{
				if(r_MIndexOfChild_View == null)
				{
					r_MIndexOfChild_View = new(this, "IndexOfChild", 0,  ReflectionUtils.GetType("UnityEditor.View"));
					r_MIndexOfChild_View.SetBelong(this.GetValue());
				}
				return r_MIndexOfChild_View;
			}
		}

		/// <summary>
		/// Void OnDestroy()
		/// </summary>
		protected RMethod r_MOnDestroy;
		public virtual RMethod RMOnDestroy
		{
			get
			{
				if(r_MOnDestroy == null)
				{
					r_MOnDestroy = new(this, "OnDestroy", 0);
					r_MOnDestroy.SetBelong(this.GetValue());
				}
				return r_MOnDestroy;
			}
		}

		/// <summary>
		/// Void AddChild(UnityEditor.View)
		/// </summary>
		protected RMethod r_MAddChild_View;
		public virtual RMethod RMAddChild_View
		{
			get
			{
				if(r_MAddChild_View == null)
				{
					r_MAddChild_View = new(this, "AddChild", 0,  ReflectionUtils.GetType("UnityEditor.View"));
					r_MAddChild_View.SetBelong(this.GetValue());
				}
				return r_MAddChild_View;
			}
		}

		/// <summary>
		/// Void AddChild(UnityEditor.View, Int32)
		/// </summary>
		protected RMethod r_MAddChild_View_Int32;
		public virtual RMethod RMAddChild_View_Int32
		{
			get
			{
				if(r_MAddChild_View_Int32 == null)
				{
					r_MAddChild_View_Int32 = new(this, "AddChild", 0,  ReflectionUtils.GetType("UnityEditor.View"), typeof(System.Int32));
					r_MAddChild_View_Int32.SetBelong(this.GetValue());
				}
				return r_MAddChild_View_Int32;
			}
		}

		/// <summary>
		/// Void RemoveChild(UnityEditor.View)
		/// </summary>
		protected RMethod r_MRemoveChild_View;
		public virtual RMethod RMRemoveChild_View
		{
			get
			{
				if(r_MRemoveChild_View == null)
				{
					r_MRemoveChild_View = new(this, "RemoveChild", 0,  ReflectionUtils.GetType("UnityEditor.View"));
					r_MRemoveChild_View.SetBelong(this.GetValue());
				}
				return r_MRemoveChild_View;
			}
		}

		/// <summary>
		/// Void RemoveChild(Int32)
		/// </summary>
		protected RMethod r_MRemoveChild_Int32;
		public virtual RMethod RMRemoveChild_Int32
		{
			get
			{
				if(r_MRemoveChild_Int32 == null)
				{
					r_MRemoveChild_Int32 = new(this, "RemoveChild", 0, typeof(System.Int32));
					r_MRemoveChild_Int32.SetBelong(this.GetValue());
				}
				return r_MRemoveChild_Int32;
			}
		}

		/// <summary>
		/// Void SetWindow(UnityEditor.ContainerWindow)
		/// </summary>
		protected RMethod r_MSetWindow_ContainerWindow;
		public virtual RMethod RMSetWindow_ContainerWindow
		{
			get
			{
				if(r_MSetWindow_ContainerWindow == null)
				{
					r_MSetWindow_ContainerWindow = new(this, "SetWindow", 0,  ReflectionUtils.GetType("UnityEditor.ContainerWindow"));
					r_MSetWindow_ContainerWindow.SetBelong(this.GetValue());
				}
				return r_MSetWindow_ContainerWindow;
			}
		}

		/// <summary>
		/// Void SetWindowRecurse(UnityEditor.ContainerWindow)
		/// </summary>
		protected RMethod r_MSetWindowRecurse_ContainerWindow;
		public virtual RMethod RMSetWindowRecurse_ContainerWindow
		{
			get
			{
				if(r_MSetWindowRecurse_ContainerWindow == null)
				{
					r_MSetWindowRecurse_ContainerWindow = new(this, "SetWindowRecurse", 0,  ReflectionUtils.GetType("UnityEditor.ContainerWindow"));
					r_MSetWindowRecurse_ContainerWindow.SetBelong(this.GetValue());
				}
				return r_MSetWindowRecurse_ContainerWindow;
			}
		}

		/// <summary>
		/// Boolean OnFocus()
		/// </summary>
		protected RMethod r_MOnFocus;
		public virtual RMethod RMOnFocus
		{
			get
			{
				if(r_MOnFocus == null)
				{
					r_MOnFocus = new(this, "OnFocus", 0);
					r_MOnFocus.SetBelong(this.GetValue());
				}
				return r_MOnFocus;
			}
		}

		/// <summary>
		/// Void SetDirty()
		/// </summary>
		protected RMethod r_MSetDirty;
		public virtual RMethod RMSetDirty
		{
			get
			{
				if(r_MSetDirty == null)
				{
					r_MSetDirty = new(this, "SetDirty", 0);
					r_MSetDirty.SetBelong(this.GetValue());
				}
				return r_MSetDirty;
			}
		}

		/// <summary>
		/// Int32 GetInstanceID()
		/// </summary>
		protected RMethod r_MGetInstanceID;
		public virtual RMethod RMGetInstanceID
		{
			get
			{
				if(r_MGetInstanceID == null)
				{
					r_MGetInstanceID = new(this, "GetInstanceID", 0);
					r_MGetInstanceID.SetBelong(this.GetValue());
				}
				return r_MGetInstanceID;
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
					r_MGetHashCode.SetBelong(this.GetValue());
				}
				return r_MGetHashCode;
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
					r_MEquals_Object.SetBelong(this.GetValue());
				}
				return r_MEquals_Object;
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
					r_MToString.SetBelong(this.GetValue());
				}
				return r_MToString;
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
					r_MFinalize.SetBelong(this.GetValue());
				}
				return r_MFinalize;
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
					r_MGetType.SetBelong(this.GetValue());
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
					r_MMemberwiseClone.SetBelong(this.GetValue());
				}
				return r_MMemberwiseClone;
			}
		}


        public RView() : base("UnityEditor.View")
        {
        }

        public RView(System.Object instance) : base("UnityEditor.View")
		{
            SetInstance(instance);
		}

        public RView(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RView(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Reflow()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMReflow.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String DebugHierarchy(System.Int32 @level)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@level};
            var ___result = RMDebugHierarchy_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Initialize(Hvak.Editor.Refleaction.RUnityEditor.RContainerWindow @win)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@win.Value};
            var ___result = RMInitialize_ContainerWindow.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetMinMaxSizes(UnityEngine.Vector2 @min, UnityEngine.Vector2 @max)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@min, @max};
            var ___result = RMSetMinMaxSizes_Vector2_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ChildrenMinMaxChanged()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMChildrenMinMaxChanged.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __internalAwake()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RM__internalAwake.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPosition(UnityEngine.Rect @newPos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newPos};
            var ___result = RMSetPosition_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPositionOnly(UnityEngine.Rect @newPos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newPos};
            var ___result = RMSetPositionOnly_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 IndexOfChild(Hvak.Editor.Refleaction.RUnityEditor.RView @child)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@child.Value};
            var ___result = RMIndexOfChild_View.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void OnDestroy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnDestroy.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddChild(Hvak.Editor.Refleaction.RUnityEditor.RView @child)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@child.Value};
            var ___result = RMAddChild_View.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddChild(Hvak.Editor.Refleaction.RUnityEditor.RView @child, System.Int32 @idx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@child.Value, @idx};
            var ___result = RMAddChild_View_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveChild(Hvak.Editor.Refleaction.RUnityEditor.RView @child)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@child.Value};
            var ___result = RMRemoveChild_View.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveChild(System.Int32 @idx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idx};
            var ___result = RMRemoveChild_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetWindow(Hvak.Editor.Refleaction.RUnityEditor.RContainerWindow @win)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@win.Value};
            var ___result = RMSetWindow_ContainerWindow.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetWindowRecurse(Hvak.Editor.Refleaction.RUnityEditor.RContainerWindow @win)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@win.Value};
            var ___result = RMSetWindowRecurse_ContainerWindow.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean OnFocus()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnFocus.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetDirty()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSetDirty.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetInstanceID()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetInstanceID.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
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


    }
}
