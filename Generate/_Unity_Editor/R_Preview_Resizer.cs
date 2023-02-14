
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor
{
	/// <summary>
	/// UnityEditor.PreviewResizer
	/// </summary>
    public partial class RPreviewResizer : RMember //
    {

		/// <summary>
		/// System.Single s_DraggedPreviewSize
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSingle r_Fs_DraggedPreviewSize;
		public static Hvak.Editor.Refleaction.RSystem.RSingle RFs_DraggedPreviewSize
		{
			get
			{
				if(r_Fs_DraggedPreviewSize == null)
				{
					r_Fs_DraggedPreviewSize = new( ReflectionUtils.GetType("UnityEditor.PreviewResizer"), "s_DraggedPreviewSize");
					r_Fs_DraggedPreviewSize.SetBelong(null);
				}
				return r_Fs_DraggedPreviewSize;
			}
		}

		/// <summary>
		/// System.Single s_CachedPreviewSizeWhileDragging
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSingle r_Fs_CachedPreviewSizeWhileDragging;
		public static Hvak.Editor.Refleaction.RSystem.RSingle RFs_CachedPreviewSizeWhileDragging
		{
			get
			{
				if(r_Fs_CachedPreviewSizeWhileDragging == null)
				{
					r_Fs_CachedPreviewSizeWhileDragging = new( ReflectionUtils.GetType("UnityEditor.PreviewResizer"), "s_CachedPreviewSizeWhileDragging");
					r_Fs_CachedPreviewSizeWhileDragging.SetBelong(null);
				}
				return r_Fs_CachedPreviewSizeWhileDragging;
			}
		}

		/// <summary>
		/// System.Single s_MouseDownLocation
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSingle r_Fs_MouseDownLocation;
		public static Hvak.Editor.Refleaction.RSystem.RSingle RFs_MouseDownLocation
		{
			get
			{
				if(r_Fs_MouseDownLocation == null)
				{
					r_Fs_MouseDownLocation = new( ReflectionUtils.GetType("UnityEditor.PreviewResizer"), "s_MouseDownLocation");
					r_Fs_MouseDownLocation.SetBelong(null);
				}
				return r_Fs_MouseDownLocation;
			}
		}

		/// <summary>
		/// System.Single s_MouseDownValue
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RSingle r_Fs_MouseDownValue;
		public static Hvak.Editor.Refleaction.RSystem.RSingle RFs_MouseDownValue
		{
			get
			{
				if(r_Fs_MouseDownValue == null)
				{
					r_Fs_MouseDownValue = new( ReflectionUtils.GetType("UnityEditor.PreviewResizer"), "s_MouseDownValue");
					r_Fs_MouseDownValue.SetBelong(null);
				}
				return r_Fs_MouseDownValue;
			}
		}

		/// <summary>
		/// System.Boolean s_MouseDragged
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RBoolean r_Fs_MouseDragged;
		public static Hvak.Editor.Refleaction.RSystem.RBoolean RFs_MouseDragged
		{
			get
			{
				if(r_Fs_MouseDragged == null)
				{
					r_Fs_MouseDragged = new( ReflectionUtils.GetType("UnityEditor.PreviewResizer"), "s_MouseDragged");
					r_Fs_MouseDragged.SetBelong(null);
				}
				return r_Fs_MouseDragged;
			}
		}

		/// <summary>
		/// System.Single m_CachedPref
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_CachedPref;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_CachedPref
		{
			get
			{
				if(r_Fm_CachedPref == null)
				{
					r_Fm_CachedPref = new(this, "m_CachedPref");
					r_Fm_CachedPref.SetBelong(this.instance);
				}
				return r_Fm_CachedPref;
			}
		}

		/// <summary>
		/// System.Int32 m_ControlHash
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_ControlHash;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_ControlHash
		{
			get
			{
				if(r_Fm_ControlHash == null)
				{
					r_Fm_ControlHash = new(this, "m_ControlHash");
					r_Fm_ControlHash.SetBelong(this.instance);
				}
				return r_Fm_ControlHash;
			}
		}

		/// <summary>
		/// System.String m_PrefName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_PrefName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_PrefName
		{
			get
			{
				if(r_Fm_PrefName == null)
				{
					r_Fm_PrefName = new(this, "m_PrefName");
					r_Fm_PrefName.SetBelong(this.instance);
				}
				return r_Fm_PrefName;
			}
		}

		/// <summary>
		/// System.Int32 m_Id
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_Id;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_Id
		{
			get
			{
				if(r_Fm_Id == null)
				{
					r_Fm_Id = new(this, "m_Id");
					r_Fm_Id.SetBelong(this.instance);
				}
				return r_Fm_Id;
			}
		}

		/// <summary>
		/// System.Boolean <localFrame>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_F__0__localFrame__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RF__0__localFrame__1__k__BackingField
		{
			get
			{
				if(r_F__0__localFrame__1__k__BackingField == null)
				{
					r_F__0__localFrame__1__k__BackingField = new(this, "<localFrame>k__BackingField");
					r_F__0__localFrame__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__localFrame__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IMGUIContainer m_Container
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIMGUIContainer r_Fm_Container;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIMGUIContainer RFm_Container
		{
			get
			{
				if(r_Fm_Container == null)
				{
					r_Fm_Container = new(this, "m_Container");
					r_Fm_Container.SetBelong(this.instance);
				}
				return r_Fm_Container;
			}
		}

		/// <summary>
		/// System.Single containerMinimumHeightExpanded
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_FcontainerMinimumHeightExpanded;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFcontainerMinimumHeightExpanded
		{
			get
			{
				if(r_FcontainerMinimumHeightExpanded == null)
				{
					r_FcontainerMinimumHeightExpanded = new(this, "containerMinimumHeightExpanded");
					r_FcontainerMinimumHeightExpanded.SetBelong(this.instance);
				}
				return r_FcontainerMinimumHeightExpanded;
			}
		}

		/// <summary>
		/// System.Single m_ContainerMinimumHeightCollapsed
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_ContainerMinimumHeightCollapsed;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_ContainerMinimumHeightCollapsed
		{
			get
			{
				if(r_Fm_ContainerMinimumHeightCollapsed == null)
				{
					r_Fm_ContainerMinimumHeightCollapsed = new(this, "m_ContainerMinimumHeightCollapsed");
					r_Fm_ContainerMinimumHeightCollapsed.SetBelong(this.instance);
				}
				return r_Fm_ContainerMinimumHeightCollapsed;
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
					r_Pid.SetBelong(this.instance);
				}
				return r_Pid;
			}
		}

		/// <summary>
		/// Boolean localFrame
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PlocalFrame;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPlocalFrame
		{
			get
			{
				if(r_PlocalFrame == null)
				{
					r_PlocalFrame = new(this, "localFrame", -1);
					r_PlocalFrame.SetBelong(this.instance);
				}
				return r_PlocalFrame;
			}
		}

		/// <summary>
		/// Void Init(System.String)
		/// </summary>
		protected RMethod r_MInit_String;
		public virtual RMethod RMInit_String
		{
			get
			{
				if(r_MInit_String == null)
				{
					r_MInit_String = new(this, "Init", 0, typeof(System.String));
					r_MInit_String.SetBelong(this.instance);
				}
				return r_MInit_String;
			}
		}

		/// <summary>
		/// Single ResizeHandle(UnityEngine.Rect, Single, Single, Single)
		/// </summary>
		protected RMethod r_MResizeHandle_Rect_Single_Single_Single;
		public virtual RMethod RMResizeHandle_Rect_Single_Single_Single
		{
			get
			{
				if(r_MResizeHandle_Rect_Single_Single_Single == null)
				{
					r_MResizeHandle_Rect_Single_Single_Single = new(this, "ResizeHandle", 0, typeof(UnityEngine.Rect), typeof(System.Single), typeof(System.Single), typeof(System.Single));
					r_MResizeHandle_Rect_Single_Single_Single.SetBelong(this.instance);
				}
				return r_MResizeHandle_Rect_Single_Single_Single;
			}
		}

		/// <summary>
		/// Single ResizeHandle(UnityEngine.Rect, Single, Single, Single, UnityEngine.Rect)
		/// </summary>
		protected RMethod r_MResizeHandle_Rect_Single_Single_Single_Rect;
		public virtual RMethod RMResizeHandle_Rect_Single_Single_Single_Rect
		{
			get
			{
				if(r_MResizeHandle_Rect_Single_Single_Single_Rect == null)
				{
					r_MResizeHandle_Rect_Single_Single_Single_Rect = new(this, "ResizeHandle", 0, typeof(UnityEngine.Rect), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(UnityEngine.Rect));
					r_MResizeHandle_Rect_Single_Single_Single_Rect.SetBelong(this.instance);
				}
				return r_MResizeHandle_Rect_Single_Single_Single_Rect;
			}
		}

		/// <summary>
		/// Single SetExpanded(UnityEngine.Rect, Single, Single, Single, UnityEngine.Rect, Boolean)
		/// </summary>
		protected RMethod r_MSetExpanded_Rect_Single_Single_Single_Rect_Boolean;
		public virtual RMethod RMSetExpanded_Rect_Single_Single_Single_Rect_Boolean
		{
			get
			{
				if(r_MSetExpanded_Rect_Single_Single_Single_Rect_Boolean == null)
				{
					r_MSetExpanded_Rect_Single_Single_Single_Rect_Boolean = new(this, "SetExpanded", 0, typeof(UnityEngine.Rect), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(UnityEngine.Rect), typeof(System.Boolean));
					r_MSetExpanded_Rect_Single_Single_Single_Rect_Boolean.SetBelong(this.instance);
				}
				return r_MSetExpanded_Rect_Single_Single_Single_Rect_Boolean;
			}
		}

		/// <summary>
		/// Boolean GetExpanded()
		/// </summary>
		protected RMethod r_MGetExpanded;
		public virtual RMethod RMGetExpanded
		{
			get
			{
				if(r_MGetExpanded == null)
				{
					r_MGetExpanded = new(this, "GetExpanded", 0);
					r_MGetExpanded.SetBelong(this.instance);
				}
				return r_MGetExpanded;
			}
		}

		/// <summary>
		/// Single GetPreviewSize()
		/// </summary>
		protected RMethod r_MGetPreviewSize;
		public virtual RMethod RMGetPreviewSize
		{
			get
			{
				if(r_MGetPreviewSize == null)
				{
					r_MGetPreviewSize = new(this, "GetPreviewSize", 0);
					r_MGetPreviewSize.SetBelong(this.instance);
				}
				return r_MGetPreviewSize;
			}
		}

		/// <summary>
		/// Boolean GetExpandedBeforeDragging()
		/// </summary>
		protected RMethod r_MGetExpandedBeforeDragging;
		public virtual RMethod RMGetExpandedBeforeDragging
		{
			get
			{
				if(r_MGetExpandedBeforeDragging == null)
				{
					r_MGetExpandedBeforeDragging = new(this, "GetExpandedBeforeDragging", 0);
					r_MGetExpandedBeforeDragging.SetBelong(this.instance);
				}
				return r_MGetExpandedBeforeDragging;
			}
		}

		/// <summary>
		/// Void SetExpanded(Boolean)
		/// </summary>
		protected RMethod r_MSetExpanded_Boolean;
		public virtual RMethod RMSetExpanded_Boolean
		{
			get
			{
				if(r_MSetExpanded_Boolean == null)
				{
					r_MSetExpanded_Boolean = new(this, "SetExpanded", 0, typeof(System.Boolean));
					r_MSetExpanded_Boolean.SetBelong(this.instance);
				}
				return r_MSetExpanded_Boolean;
			}
		}

		/// <summary>
		/// Void ToggleExpanded()
		/// </summary>
		protected RMethod r_MToggleExpanded;
		public virtual RMethod RMToggleExpanded
		{
			get
			{
				if(r_MToggleExpanded == null)
				{
					r_MToggleExpanded = new(this, "ToggleExpanded", 0);
					r_MToggleExpanded.SetBelong(this.instance);
				}
				return r_MToggleExpanded;
			}
		}

		/// <summary>
		/// Single PixelPreciseCollapsibleSlider(Int32, UnityEngine.Rect, Single, Single, Single, Boolean ByRef)
		/// </summary>
		protected static RMethod r_MPixelPreciseCollapsibleSlider_Int32_Rect_Single_Single_Single_Ref_Boolean;
		public static RMethod RMPixelPreciseCollapsibleSlider_Int32_Rect_Single_Single_Single_Ref_Boolean
		{
			get
			{
				if(r_MPixelPreciseCollapsibleSlider_Int32_Rect_Single_Single_Single_Ref_Boolean == null)
				{
					r_MPixelPreciseCollapsibleSlider_Int32_Rect_Single_Single_Single_Ref_Boolean = new( ReflectionUtils.GetType("UnityEditor.PreviewResizer"), "PixelPreciseCollapsibleSlider", 0, typeof(System.Int32), typeof(UnityEngine.Rect), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Boolean).MakeByRefType());
					r_MPixelPreciseCollapsibleSlider_Int32_Rect_Single_Single_Single_Ref_Boolean.SetBelong(null);
				}
				return r_MPixelPreciseCollapsibleSlider_Int32_Rect_Single_Single_Single_Ref_Boolean;
			}
		}

		/// <summary>
		/// Single PixelPreciseCollapsibleSlider(Int32, UnityEngine.Rect, Single, Single, Single, Boolean ByRef, Boolean)
		/// </summary>
		protected static RMethod r_MPixelPreciseCollapsibleSlider_Int32_Rect_Single_Single_Single_Ref_Boolean_Boolean;
		public static RMethod RMPixelPreciseCollapsibleSlider_Int32_Rect_Single_Single_Single_Ref_Boolean_Boolean
		{
			get
			{
				if(r_MPixelPreciseCollapsibleSlider_Int32_Rect_Single_Single_Single_Ref_Boolean_Boolean == null)
				{
					r_MPixelPreciseCollapsibleSlider_Int32_Rect_Single_Single_Single_Ref_Boolean_Boolean = new( ReflectionUtils.GetType("UnityEditor.PreviewResizer"), "PixelPreciseCollapsibleSlider", 0, typeof(System.Int32), typeof(UnityEngine.Rect), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Boolean).MakeByRefType(), typeof(System.Boolean));
					r_MPixelPreciseCollapsibleSlider_Int32_Rect_Single_Single_Single_Ref_Boolean_Boolean.SetBelong(null);
				}
				return r_MPixelPreciseCollapsibleSlider_Int32_Rect_Single_Single_Single_Ref_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void SetContainer(UnityEngine.UIElements.IMGUIContainer, Single)
		/// </summary>
		protected RMethod r_MSetContainer_IMGUIContainer_Single;
		public virtual RMethod RMSetContainer_IMGUIContainer_Single
		{
			get
			{
				if(r_MSetContainer_IMGUIContainer_Single == null)
				{
					r_MSetContainer_IMGUIContainer_Single = new(this, "SetContainer", 0, typeof(UnityEngine.UIElements.IMGUIContainer), typeof(System.Single));
					r_MSetContainer_IMGUIContainer_Single.SetBelong(this.instance);
				}
				return r_MSetContainer_IMGUIContainer_Single;
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


        public RPreviewResizer() : base("UnityEditor.PreviewResizer")
        {
        }

        public RPreviewResizer(System.Object instance) : base("UnityEditor.PreviewResizer")
		{
            SetInstance(instance);
		}

        public RPreviewResizer(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPreviewResizer(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Init(System.String @prefName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prefName};
            var ___result = RMInit_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Single ResizeHandle(UnityEngine.Rect @windowPosition, System.Single @minSize, System.Single @minRemainingSize, System.Single @resizerHeight)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@windowPosition, @minSize, @minRemainingSize, @resizerHeight};
            var ___result = RMResizeHandle_Rect_Single_Single_Single.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Single ResizeHandle(UnityEngine.Rect @windowPosition, System.Single @minSize, System.Single @minRemainingSize, System.Single @resizerHeight, UnityEngine.Rect @dragRect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@windowPosition, @minSize, @minRemainingSize, @resizerHeight, @dragRect};
            var ___result = RMResizeHandle_Rect_Single_Single_Single_Rect.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Single SetExpanded(UnityEngine.Rect @windowPosition, System.Single @minSize, System.Single @minRemainingSize, System.Single @resizerHeight, UnityEngine.Rect @dragRect, System.Boolean @isExpanded)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@windowPosition, @minSize, @minRemainingSize, @resizerHeight, @dragRect, @isExpanded};
            var ___result = RMSetExpanded_Rect_Single_Single_Single_Rect_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Boolean GetExpanded()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetExpanded.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Single GetPreviewSize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetPreviewSize.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Boolean GetExpandedBeforeDragging()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetExpandedBeforeDragging.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetExpanded(System.Boolean @expanded)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@expanded};
            var ___result = RMSetExpanded_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ToggleExpanded()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToggleExpanded.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Single PixelPreciseCollapsibleSlider(System.Int32 @id, UnityEngine.Rect @position, System.Single @value, System.Single @min, System.Single @max, ref System.Boolean @expanded)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id, @position, @value, @min, @max, @expanded};
            var ___result = RMPixelPreciseCollapsibleSlider_Int32_Rect_Single_Single_Single_Ref_Boolean.Invoke(___genericsType, ___parameters);
			@expanded = (System.Boolean)___parameters[5];

            return (System.Single)___result;
        }


        public static System.Single PixelPreciseCollapsibleSlider(System.Int32 @id, UnityEngine.Rect @position, System.Single @value, System.Single @min, System.Single @max, ref System.Boolean @expanded, System.Boolean @localFrame)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id, @position, @value, @min, @max, @expanded, @localFrame};
            var ___result = RMPixelPreciseCollapsibleSlider_Int32_Rect_Single_Single_Single_Ref_Boolean_Boolean.Invoke(___genericsType, ___parameters);
			@expanded = (System.Boolean)___parameters[5];

            return (System.Single)___result;
        }


        public virtual void SetContainer(UnityEngine.UIElements.IMGUIContainer @container, System.Single @minimumHeightCollapsed)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@container, @minimumHeightCollapsed};
            var ___result = RMSetContainer_IMGUIContainer_Single.Invoke(___genericsType, ___parameters);

            
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
