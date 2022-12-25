using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor
{
	/// <summary>
	/// UnityEditor.View
	/// </summary>
    public partial class RView : RMember //
    {

		/// <summary>
		/// UnityEditor.MonoReloadableIntPtr m_ViewPtr
		/// </summary>
		protected RUnityEditor.RMonoReloadableIntPtr r_m_ViewPtr;
		public virtual RUnityEditor.RMonoReloadableIntPtr Rm_ViewPtr
		{
			get
			{
				if(r_m_ViewPtr == null)
				{
					r_m_ViewPtr = new(this, "m_ViewPtr");
					r_m_ViewPtr.SetBelong(this.instance);
				}
				return r_m_ViewPtr;
			}
		}

		/// <summary>
		/// UnityEditor.View[] m_Children
		/// </summary>
		protected RFieldArray<RUnityEditor.RView> r_m_Children;
		public virtual RFieldArray<RUnityEditor.RView> Rm_Children
		{
			get
			{
				if(r_m_Children == null)
				{
					r_m_Children = new(this, "m_Children");
					r_m_Children.SetBelong(this.instance);
				}
				return r_m_Children;
			}
		}

		/// <summary>
		/// UnityEditor.View m_Parent
		/// </summary>
		protected RUnityEditor.RView r_m_Parent;
		public virtual RUnityEditor.RView Rm_Parent
		{
			get
			{
				if(r_m_Parent == null)
				{
					r_m_Parent = new(this, "m_Parent");
					r_m_Parent.SetBelong(this.instance);
				}
				return r_m_Parent;
			}
		}

		/// <summary>
		/// UnityEditor.ContainerWindow m_Window
		/// </summary>
		protected RUnityEditor.RContainerWindow r_m_Window;
		public virtual RUnityEditor.RContainerWindow Rm_Window
		{
			get
			{
				if(r_m_Window == null)
				{
					r_m_Window = new(this, "m_Window");
					r_m_Window.SetBelong(this.instance);
				}
				return r_m_Window;
			}
		}

		/// <summary>
		/// UnityEngine.Rect m_Position
		/// </summary>
		protected RUnityEngine.RRect r_m_Position;
		public virtual RUnityEngine.RRect Rm_Position
		{
			get
			{
				if(r_m_Position == null)
				{
					r_m_Position = new(this, "m_Position");
					r_m_Position.SetBelong(this.instance);
				}
				return r_m_Position;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 m_MinSize
		/// </summary>
		protected RUnityEngine.RVector2 r_m_MinSize;
		public virtual RUnityEngine.RVector2 Rm_MinSize
		{
			get
			{
				if(r_m_MinSize == null)
				{
					r_m_MinSize = new(this, "m_MinSize");
					r_m_MinSize.SetBelong(this.instance);
				}
				return r_m_MinSize;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 m_MaxSize
		/// </summary>
		protected RUnityEngine.RVector2 r_m_MaxSize;
		public virtual RUnityEngine.RVector2 Rm_MaxSize
		{
			get
			{
				if(r_m_MaxSize == null)
				{
					r_m_MaxSize = new(this, "m_MaxSize");
					r_m_MaxSize.SetBelong(this.instance);
				}
				return r_m_MaxSize;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 minSize
		/// </summary>
		protected RUnityEngine.RVector2 r_minSize;
		public virtual RUnityEngine.RVector2 RminSize
		{
			get
			{
				if(r_minSize == null)
				{
					r_minSize = new(this, "minSize", -1);
					r_minSize.SetBelong(this.instance);
				}
				return r_minSize;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 maxSize
		/// </summary>
		protected RUnityEngine.RVector2 r_maxSize;
		public virtual RUnityEngine.RVector2 RmaxSize
		{
			get
			{
				if(r_maxSize == null)
				{
					r_maxSize = new(this, "maxSize", -1);
					r_maxSize.SetBelong(this.instance);
				}
				return r_maxSize;
			}
		}

		/// <summary>
		/// UnityEditor.View[] allChildren
		/// </summary>
		protected RPropertyArray<RUnityEditor.RView> r_allChildren;
		public virtual RPropertyArray<RUnityEditor.RView> RallChildren
		{
			get
			{
				if(r_allChildren == null)
				{
					r_allChildren = new(this, "allChildren", -1);
					r_allChildren.SetBelong(this.instance);
				}
				return r_allChildren;
			}
		}

		/// <summary>
		/// UnityEngine.Rect position
		/// </summary>
		protected RUnityEngine.RRect r_position;
		public virtual RUnityEngine.RRect Rposition
		{
			get
			{
				if(r_position == null)
				{
					r_position = new(this, "position", -1);
					r_position.SetBelong(this.instance);
				}
				return r_position;
			}
		}

		/// <summary>
		/// UnityEngine.Rect windowPosition
		/// </summary>
		protected RUnityEngine.RRect r_windowPosition;
		public virtual RUnityEngine.RRect RwindowPosition
		{
			get
			{
				if(r_windowPosition == null)
				{
					r_windowPosition = new(this, "windowPosition", -1);
					r_windowPosition.SetBelong(this.instance);
				}
				return r_windowPosition;
			}
		}

		/// <summary>
		/// UnityEngine.Rect screenPosition
		/// </summary>
		protected RUnityEngine.RRect r_screenPosition;
		public virtual RUnityEngine.RRect RscreenPosition
		{
			get
			{
				if(r_screenPosition == null)
				{
					r_screenPosition = new(this, "screenPosition", -1);
					r_screenPosition.SetBelong(this.instance);
				}
				return r_screenPosition;
			}
		}

		/// <summary>
		/// UnityEditor.ContainerWindow window
		/// </summary>
		protected RUnityEditor.RContainerWindow r_window;
		public virtual RUnityEditor.RContainerWindow Rwindow
		{
			get
			{
				if(r_window == null)
				{
					r_window = new(this, "window", -1);
					r_window.SetBelong(this.instance);
				}
				return r_window;
			}
		}

		/// <summary>
		/// UnityEditor.View parent
		/// </summary>
		protected RUnityEditor.RView r_parent;
		public virtual RUnityEditor.RView Rparent
		{
			get
			{
				if(r_parent == null)
				{
					r_parent = new(this, "parent", -1);
					r_parent.SetBelong(this.instance);
				}
				return r_parent;
			}
		}

		/// <summary>
		/// UnityEditor.View[] children
		/// </summary>
		protected RPropertyArray<RUnityEditor.RView> r_children;
		public virtual RPropertyArray<RUnityEditor.RView> Rchildren
		{
			get
			{
				if(r_children == null)
				{
					r_children = new(this, "children", -1);
					r_children.SetBelong(this.instance);
				}
				return r_children;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected RProperty r_name;
		public virtual RProperty Rname
		{
			get
			{
				if(r_name == null)
				{
					r_name = new(this, "name", -1);
					r_name.SetBelong(this.instance);
				}
				return r_name;
			}
		}

		/// <summary>
		/// UnityEngine.HideFlags hideFlags
		/// </summary>
		protected RProperty r_hideFlags;
		public virtual RProperty RhideFlags
		{
			get
			{
				if(r_hideFlags == null)
				{
					r_hideFlags = new(this, "hideFlags", -1);
					r_hideFlags.SetBelong(this.instance);
				}
				return r_hideFlags;
			}
		}

		/// <summary>
		/// Void Reflow()
		/// </summary>
		protected RMethod r_RReflow;
		public virtual RMethod RReflow
		{
			get
			{
				if(r_RReflow == null)
				{
					r_RReflow = new(this, "Reflow", 0);
					r_RReflow.SetBelong(this.instance);
				}
				return r_RReflow;
			}
		}

		/// <summary>
		/// System.String DebugHierarchy(Int32)
		/// </summary>
		protected RMethod r_RDebugHierarchy_Int32;
		public virtual RMethod RDebugHierarchy_Int32
		{
			get
			{
				if(r_RDebugHierarchy_Int32 == null)
				{
					r_RDebugHierarchy_Int32 = new(this, "DebugHierarchy", 0, typeof(System.Int32));
					r_RDebugHierarchy_Int32.SetBelong(this.instance);
				}
				return r_RDebugHierarchy_Int32;
			}
		}

		/// <summary>
		/// Void Initialize(UnityEditor.ContainerWindow)
		/// </summary>
		protected RMethod r_RInitialize_ContainerWindow;
		public virtual RMethod RInitialize_ContainerWindow
		{
			get
			{
				if(r_RInitialize_ContainerWindow == null)
				{
					r_RInitialize_ContainerWindow = new(this, "Initialize", 0,  ReleactionUtils.GetType("UnityEditor.ContainerWindow"));
					r_RInitialize_ContainerWindow.SetBelong(this.instance);
				}
				return r_RInitialize_ContainerWindow;
			}
		}

		/// <summary>
		/// Void SetMinMaxSizes(UnityEngine.Vector2, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_RSetMinMaxSizes_Vector2_Vector2;
		public virtual RMethod RSetMinMaxSizes_Vector2_Vector2
		{
			get
			{
				if(r_RSetMinMaxSizes_Vector2_Vector2 == null)
				{
					r_RSetMinMaxSizes_Vector2_Vector2 = new(this, "SetMinMaxSizes", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2));
					r_RSetMinMaxSizes_Vector2_Vector2.SetBelong(this.instance);
				}
				return r_RSetMinMaxSizes_Vector2_Vector2;
			}
		}

		/// <summary>
		/// Void ChildrenMinMaxChanged()
		/// </summary>
		protected RMethod r_RChildrenMinMaxChanged;
		public virtual RMethod RChildrenMinMaxChanged
		{
			get
			{
				if(r_RChildrenMinMaxChanged == null)
				{
					r_RChildrenMinMaxChanged = new(this, "ChildrenMinMaxChanged", 0);
					r_RChildrenMinMaxChanged.SetBelong(this.instance);
				}
				return r_RChildrenMinMaxChanged;
			}
		}

		/// <summary>
		/// Void __internalAwake()
		/// </summary>
		protected RMethod r_R__internalAwake;
		public virtual RMethod R__internalAwake
		{
			get
			{
				if(r_R__internalAwake == null)
				{
					r_R__internalAwake = new(this, "__internalAwake", 0);
					r_R__internalAwake.SetBelong(this.instance);
				}
				return r_R__internalAwake;
			}
		}

		/// <summary>
		/// Void SetPosition(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_RSetPosition_Rect;
		public virtual RMethod RSetPosition_Rect
		{
			get
			{
				if(r_RSetPosition_Rect == null)
				{
					r_RSetPosition_Rect = new(this, "SetPosition", 0, typeof(UnityEngine.Rect));
					r_RSetPosition_Rect.SetBelong(this.instance);
				}
				return r_RSetPosition_Rect;
			}
		}

		/// <summary>
		/// Void SetPositionOnly(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_RSetPositionOnly_Rect;
		public virtual RMethod RSetPositionOnly_Rect
		{
			get
			{
				if(r_RSetPositionOnly_Rect == null)
				{
					r_RSetPositionOnly_Rect = new(this, "SetPositionOnly", 0, typeof(UnityEngine.Rect));
					r_RSetPositionOnly_Rect.SetBelong(this.instance);
				}
				return r_RSetPositionOnly_Rect;
			}
		}

		/// <summary>
		/// Int32 IndexOfChild(UnityEditor.View)
		/// </summary>
		protected RMethod r_RIndexOfChild_View;
		public virtual RMethod RIndexOfChild_View
		{
			get
			{
				if(r_RIndexOfChild_View == null)
				{
					r_RIndexOfChild_View = new(this, "IndexOfChild", 0,  ReleactionUtils.GetType("UnityEditor.View"));
					r_RIndexOfChild_View.SetBelong(this.instance);
				}
				return r_RIndexOfChild_View;
			}
		}

		/// <summary>
		/// Void OnDestroy()
		/// </summary>
		protected RMethod r_ROnDestroy;
		public virtual RMethod ROnDestroy
		{
			get
			{
				if(r_ROnDestroy == null)
				{
					r_ROnDestroy = new(this, "OnDestroy", 0);
					r_ROnDestroy.SetBelong(this.instance);
				}
				return r_ROnDestroy;
			}
		}

		/// <summary>
		/// Void AddChild(UnityEditor.View)
		/// </summary>
		protected RMethod r_RAddChild_View;
		public virtual RMethod RAddChild_View
		{
			get
			{
				if(r_RAddChild_View == null)
				{
					r_RAddChild_View = new(this, "AddChild", 0,  ReleactionUtils.GetType("UnityEditor.View"));
					r_RAddChild_View.SetBelong(this.instance);
				}
				return r_RAddChild_View;
			}
		}

		/// <summary>
		/// Void AddChild(UnityEditor.View, Int32)
		/// </summary>
		protected RMethod r_RAddChild_View_Int32;
		public virtual RMethod RAddChild_View_Int32
		{
			get
			{
				if(r_RAddChild_View_Int32 == null)
				{
					r_RAddChild_View_Int32 = new(this, "AddChild", 0,  ReleactionUtils.GetType("UnityEditor.View"), typeof(System.Int32));
					r_RAddChild_View_Int32.SetBelong(this.instance);
				}
				return r_RAddChild_View_Int32;
			}
		}

		/// <summary>
		/// Void RemoveChild(UnityEditor.View)
		/// </summary>
		protected RMethod r_RRemoveChild_View;
		public virtual RMethod RRemoveChild_View
		{
			get
			{
				if(r_RRemoveChild_View == null)
				{
					r_RRemoveChild_View = new(this, "RemoveChild", 0,  ReleactionUtils.GetType("UnityEditor.View"));
					r_RRemoveChild_View.SetBelong(this.instance);
				}
				return r_RRemoveChild_View;
			}
		}

		/// <summary>
		/// Void RemoveChild(Int32)
		/// </summary>
		protected RMethod r_RRemoveChild_Int32;
		public virtual RMethod RRemoveChild_Int32
		{
			get
			{
				if(r_RRemoveChild_Int32 == null)
				{
					r_RRemoveChild_Int32 = new(this, "RemoveChild", 0, typeof(System.Int32));
					r_RRemoveChild_Int32.SetBelong(this.instance);
				}
				return r_RRemoveChild_Int32;
			}
		}

		/// <summary>
		/// Void SetWindow(UnityEditor.ContainerWindow)
		/// </summary>
		protected RMethod r_RSetWindow_ContainerWindow;
		public virtual RMethod RSetWindow_ContainerWindow
		{
			get
			{
				if(r_RSetWindow_ContainerWindow == null)
				{
					r_RSetWindow_ContainerWindow = new(this, "SetWindow", 0,  ReleactionUtils.GetType("UnityEditor.ContainerWindow"));
					r_RSetWindow_ContainerWindow.SetBelong(this.instance);
				}
				return r_RSetWindow_ContainerWindow;
			}
		}

		/// <summary>
		/// Void SetWindowRecurse(UnityEditor.ContainerWindow)
		/// </summary>
		protected RMethod r_RSetWindowRecurse_ContainerWindow;
		public virtual RMethod RSetWindowRecurse_ContainerWindow
		{
			get
			{
				if(r_RSetWindowRecurse_ContainerWindow == null)
				{
					r_RSetWindowRecurse_ContainerWindow = new(this, "SetWindowRecurse", 0,  ReleactionUtils.GetType("UnityEditor.ContainerWindow"));
					r_RSetWindowRecurse_ContainerWindow.SetBelong(this.instance);
				}
				return r_RSetWindowRecurse_ContainerWindow;
			}
		}

		/// <summary>
		/// Boolean OnFocus()
		/// </summary>
		protected RMethod r_ROnFocus;
		public virtual RMethod ROnFocus
		{
			get
			{
				if(r_ROnFocus == null)
				{
					r_ROnFocus = new(this, "OnFocus", 0);
					r_ROnFocus.SetBelong(this.instance);
				}
				return r_ROnFocus;
			}
		}

		/// <summary>
		/// Void SetDirty()
		/// </summary>
		protected RMethod r_RSetDirty;
		public virtual RMethod RSetDirty
		{
			get
			{
				if(r_RSetDirty == null)
				{
					r_RSetDirty = new(this, "SetDirty", 0);
					r_RSetDirty.SetBelong(this.instance);
				}
				return r_RSetDirty;
			}
		}

		/// <summary>
		/// Int32 GetInstanceID()
		/// </summary>
		protected RMethod r_RGetInstanceID;
		public virtual RMethod RGetInstanceID
		{
			get
			{
				if(r_RGetInstanceID == null)
				{
					r_RGetInstanceID = new(this, "GetInstanceID", 0);
					r_RGetInstanceID.SetBelong(this.instance);
				}
				return r_RGetInstanceID;
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
            var ___result = RReflow.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String DebugHierarchy(System.Int32  @level)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@level};
            var ___result = RDebugHierarchy_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }



        public virtual void SetMinMaxSizes(UnityEngine.Vector2  @min, UnityEngine.Vector2  @max)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@min, @max};
            var ___result = RSetMinMaxSizes_Vector2_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ChildrenMinMaxChanged()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RChildrenMinMaxChanged.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __internalAwake()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__internalAwake.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPosition(UnityEngine.Rect  @newPos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newPos};
            var ___result = RSetPosition_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPositionOnly(UnityEngine.Rect  @newPos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newPos};
            var ___result = RSetPositionOnly_Rect.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void OnDestroy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnDestroy.Invoke(___genericsType, ___parameters);

            
        }





        public virtual void RemoveChild(System.Int32  @idx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idx};
            var ___result = RRemoveChild_Int32.Invoke(___genericsType, ___parameters);

            
        }




        public virtual System.Boolean OnFocus()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnFocus.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetDirty()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSetDirty.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetInstanceID()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetInstanceID.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
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


    }
}
