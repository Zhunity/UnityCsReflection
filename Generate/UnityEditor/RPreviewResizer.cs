using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor
{
	/// <summary>
	/// UnityEditor.PreviewResizer
	/// </summary>
    public partial class RPreviewResizer : RMember //
    {

		/// <summary>
		/// System.Single s_DraggedPreviewSize
		/// </summary>
		protected static RField r_s_DraggedPreviewSize;
		public static RField Rs_DraggedPreviewSize
		{
			get
			{
				if(r_s_DraggedPreviewSize == null)
				{
					r_s_DraggedPreviewSize = new( ReleactionUtils.GetType("UnityEditor.PreviewResizer"), "s_DraggedPreviewSize");
					r_s_DraggedPreviewSize.SetBelong(null);
				}
				return r_s_DraggedPreviewSize;
			}
		}

		/// <summary>
		/// System.Single s_CachedPreviewSizeWhileDragging
		/// </summary>
		protected static RField r_s_CachedPreviewSizeWhileDragging;
		public static RField Rs_CachedPreviewSizeWhileDragging
		{
			get
			{
				if(r_s_CachedPreviewSizeWhileDragging == null)
				{
					r_s_CachedPreviewSizeWhileDragging = new( ReleactionUtils.GetType("UnityEditor.PreviewResizer"), "s_CachedPreviewSizeWhileDragging");
					r_s_CachedPreviewSizeWhileDragging.SetBelong(null);
				}
				return r_s_CachedPreviewSizeWhileDragging;
			}
		}

		/// <summary>
		/// System.Single s_MouseDownLocation
		/// </summary>
		protected static RField r_s_MouseDownLocation;
		public static RField Rs_MouseDownLocation
		{
			get
			{
				if(r_s_MouseDownLocation == null)
				{
					r_s_MouseDownLocation = new( ReleactionUtils.GetType("UnityEditor.PreviewResizer"), "s_MouseDownLocation");
					r_s_MouseDownLocation.SetBelong(null);
				}
				return r_s_MouseDownLocation;
			}
		}

		/// <summary>
		/// System.Single s_MouseDownValue
		/// </summary>
		protected static RField r_s_MouseDownValue;
		public static RField Rs_MouseDownValue
		{
			get
			{
				if(r_s_MouseDownValue == null)
				{
					r_s_MouseDownValue = new( ReleactionUtils.GetType("UnityEditor.PreviewResizer"), "s_MouseDownValue");
					r_s_MouseDownValue.SetBelong(null);
				}
				return r_s_MouseDownValue;
			}
		}

		/// <summary>
		/// System.Boolean s_MouseDragged
		/// </summary>
		protected static RField r_s_MouseDragged;
		public static RField Rs_MouseDragged
		{
			get
			{
				if(r_s_MouseDragged == null)
				{
					r_s_MouseDragged = new( ReleactionUtils.GetType("UnityEditor.PreviewResizer"), "s_MouseDragged");
					r_s_MouseDragged.SetBelong(null);
				}
				return r_s_MouseDragged;
			}
		}

		/// <summary>
		/// System.Single m_CachedPref
		/// </summary>
		protected RField r_m_CachedPref;
		public virtual RField Rm_CachedPref
		{
			get
			{
				if(r_m_CachedPref == null)
				{
					r_m_CachedPref = new(this, "m_CachedPref");
					r_m_CachedPref.SetBelong(this.instance);
				}
				return r_m_CachedPref;
			}
		}

		/// <summary>
		/// System.Int32 m_ControlHash
		/// </summary>
		protected RField r_m_ControlHash;
		public virtual RField Rm_ControlHash
		{
			get
			{
				if(r_m_ControlHash == null)
				{
					r_m_ControlHash = new(this, "m_ControlHash");
					r_m_ControlHash.SetBelong(this.instance);
				}
				return r_m_ControlHash;
			}
		}

		/// <summary>
		/// System.String m_PrefName
		/// </summary>
		protected RField r_m_PrefName;
		public virtual RField Rm_PrefName
		{
			get
			{
				if(r_m_PrefName == null)
				{
					r_m_PrefName = new(this, "m_PrefName");
					r_m_PrefName.SetBelong(this.instance);
				}
				return r_m_PrefName;
			}
		}

		/// <summary>
		/// System.Int32 m_Id
		/// </summary>
		protected RField r_m_Id;
		public virtual RField Rm_Id
		{
			get
			{
				if(r_m_Id == null)
				{
					r_m_Id = new(this, "m_Id");
					r_m_Id.SetBelong(this.instance);
				}
				return r_m_Id;
			}
		}

		/// <summary>
		/// System.Boolean <localFrame>k__BackingField
		/// </summary>
		protected RField r___1__localFrame__2__k__BackingField;
		public virtual RField R__1__localFrame__2__k__BackingField
		{
			get
			{
				if(r___1__localFrame__2__k__BackingField == null)
				{
					r___1__localFrame__2__k__BackingField = new(this, "<localFrame>k__BackingField");
					r___1__localFrame__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__localFrame__2__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IMGUIContainer m_Container
		/// </summary>
		protected RUnityEngine.RUIElements.RIMGUIContainer r_m_Container;
		public virtual RUnityEngine.RUIElements.RIMGUIContainer Rm_Container
		{
			get
			{
				if(r_m_Container == null)
				{
					r_m_Container = new(this, "m_Container");
					r_m_Container.SetBelong(this.instance);
				}
				return r_m_Container;
			}
		}

		/// <summary>
		/// System.Single containerMinimumHeightExpanded
		/// </summary>
		protected RField r_containerMinimumHeightExpanded;
		public virtual RField RcontainerMinimumHeightExpanded
		{
			get
			{
				if(r_containerMinimumHeightExpanded == null)
				{
					r_containerMinimumHeightExpanded = new(this, "containerMinimumHeightExpanded");
					r_containerMinimumHeightExpanded.SetBelong(this.instance);
				}
				return r_containerMinimumHeightExpanded;
			}
		}

		/// <summary>
		/// System.Single m_ContainerMinimumHeightCollapsed
		/// </summary>
		protected RField r_m_ContainerMinimumHeightCollapsed;
		public virtual RField Rm_ContainerMinimumHeightCollapsed
		{
			get
			{
				if(r_m_ContainerMinimumHeightCollapsed == null)
				{
					r_m_ContainerMinimumHeightCollapsed = new(this, "m_ContainerMinimumHeightCollapsed");
					r_m_ContainerMinimumHeightCollapsed.SetBelong(this.instance);
				}
				return r_m_ContainerMinimumHeightCollapsed;
			}
		}

		/// <summary>
		/// Int32 id
		/// </summary>
		protected RProperty r_id;
		public virtual RProperty Rid
		{
			get
			{
				if(r_id == null)
				{
					r_id = new(this, "id", -1);
					r_id.SetBelong(this.instance);
				}
				return r_id;
			}
		}

		/// <summary>
		/// Boolean localFrame
		/// </summary>
		protected RProperty r_localFrame;
		public virtual RProperty RlocalFrame
		{
			get
			{
				if(r_localFrame == null)
				{
					r_localFrame = new(this, "localFrame", -1);
					r_localFrame.SetBelong(this.instance);
				}
				return r_localFrame;
			}
		}

		/// <summary>
		/// Void Init(System.String)
		/// </summary>
		protected RMethod r_RInit_String;
		public virtual RMethod RInit_String
		{
			get
			{
				if(r_RInit_String == null)
				{
					r_RInit_String = new(this, "Init", 0, typeof(System.String));
					r_RInit_String.SetBelong(this.instance);
				}
				return r_RInit_String;
			}
		}

		/// <summary>
		/// Single ResizeHandle(UnityEngine.Rect, Single, Single, Single)
		/// </summary>
		protected RMethod r_RResizeHandle_Rect_Single_Single_Single;
		public virtual RMethod RResizeHandle_Rect_Single_Single_Single
		{
			get
			{
				if(r_RResizeHandle_Rect_Single_Single_Single == null)
				{
					r_RResizeHandle_Rect_Single_Single_Single = new(this, "ResizeHandle", 0, typeof(UnityEngine.Rect), typeof(System.Single), typeof(System.Single), typeof(System.Single));
					r_RResizeHandle_Rect_Single_Single_Single.SetBelong(this.instance);
				}
				return r_RResizeHandle_Rect_Single_Single_Single;
			}
		}

		/// <summary>
		/// Single ResizeHandle(UnityEngine.Rect, Single, Single, Single, UnityEngine.Rect)
		/// </summary>
		protected RMethod r_RResizeHandle_Rect_Single_Single_Single_Rect;
		public virtual RMethod RResizeHandle_Rect_Single_Single_Single_Rect
		{
			get
			{
				if(r_RResizeHandle_Rect_Single_Single_Single_Rect == null)
				{
					r_RResizeHandle_Rect_Single_Single_Single_Rect = new(this, "ResizeHandle", 0, typeof(UnityEngine.Rect), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(UnityEngine.Rect));
					r_RResizeHandle_Rect_Single_Single_Single_Rect.SetBelong(this.instance);
				}
				return r_RResizeHandle_Rect_Single_Single_Single_Rect;
			}
		}

		/// <summary>
		/// Single SetExpanded(UnityEngine.Rect, Single, Single, Single, UnityEngine.Rect, Boolean)
		/// </summary>
		protected RMethod r_RSetExpanded_Rect_Single_Single_Single_Rect_Boolean;
		public virtual RMethod RSetExpanded_Rect_Single_Single_Single_Rect_Boolean
		{
			get
			{
				if(r_RSetExpanded_Rect_Single_Single_Single_Rect_Boolean == null)
				{
					r_RSetExpanded_Rect_Single_Single_Single_Rect_Boolean = new(this, "SetExpanded", 0, typeof(UnityEngine.Rect), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(UnityEngine.Rect), typeof(System.Boolean));
					r_RSetExpanded_Rect_Single_Single_Single_Rect_Boolean.SetBelong(this.instance);
				}
				return r_RSetExpanded_Rect_Single_Single_Single_Rect_Boolean;
			}
		}

		/// <summary>
		/// Boolean GetExpanded()
		/// </summary>
		protected RMethod r_RGetExpanded;
		public virtual RMethod RGetExpanded
		{
			get
			{
				if(r_RGetExpanded == null)
				{
					r_RGetExpanded = new(this, "GetExpanded", 0);
					r_RGetExpanded.SetBelong(this.instance);
				}
				return r_RGetExpanded;
			}
		}

		/// <summary>
		/// Single GetPreviewSize()
		/// </summary>
		protected RMethod r_RGetPreviewSize;
		public virtual RMethod RGetPreviewSize
		{
			get
			{
				if(r_RGetPreviewSize == null)
				{
					r_RGetPreviewSize = new(this, "GetPreviewSize", 0);
					r_RGetPreviewSize.SetBelong(this.instance);
				}
				return r_RGetPreviewSize;
			}
		}

		/// <summary>
		/// Boolean GetExpandedBeforeDragging()
		/// </summary>
		protected RMethod r_RGetExpandedBeforeDragging;
		public virtual RMethod RGetExpandedBeforeDragging
		{
			get
			{
				if(r_RGetExpandedBeforeDragging == null)
				{
					r_RGetExpandedBeforeDragging = new(this, "GetExpandedBeforeDragging", 0);
					r_RGetExpandedBeforeDragging.SetBelong(this.instance);
				}
				return r_RGetExpandedBeforeDragging;
			}
		}

		/// <summary>
		/// Void SetExpanded(Boolean)
		/// </summary>
		protected RMethod r_RSetExpanded_Boolean;
		public virtual RMethod RSetExpanded_Boolean
		{
			get
			{
				if(r_RSetExpanded_Boolean == null)
				{
					r_RSetExpanded_Boolean = new(this, "SetExpanded", 0, typeof(System.Boolean));
					r_RSetExpanded_Boolean.SetBelong(this.instance);
				}
				return r_RSetExpanded_Boolean;
			}
		}

		/// <summary>
		/// Void ToggleExpanded()
		/// </summary>
		protected RMethod r_RToggleExpanded;
		public virtual RMethod RToggleExpanded
		{
			get
			{
				if(r_RToggleExpanded == null)
				{
					r_RToggleExpanded = new(this, "ToggleExpanded", 0);
					r_RToggleExpanded.SetBelong(this.instance);
				}
				return r_RToggleExpanded;
			}
		}

		/// <summary>
		/// Single PixelPreciseCollapsibleSlider(Int32, UnityEngine.Rect, Single, Single, Single, Boolean ByRef)
		/// </summary>
		protected static RMethod r_RPixelPreciseCollapsibleSlider_Int32_Rect_Single_Single_Single_Ref_Boolean;
		public static RMethod RPixelPreciseCollapsibleSlider_Int32_Rect_Single_Single_Single_Ref_Boolean
		{
			get
			{
				if(r_RPixelPreciseCollapsibleSlider_Int32_Rect_Single_Single_Single_Ref_Boolean == null)
				{
					r_RPixelPreciseCollapsibleSlider_Int32_Rect_Single_Single_Single_Ref_Boolean = new( ReleactionUtils.GetType("UnityEditor.PreviewResizer"), "PixelPreciseCollapsibleSlider", 0, typeof(System.Int32), typeof(UnityEngine.Rect), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Boolean).MakeByRefType());
					r_RPixelPreciseCollapsibleSlider_Int32_Rect_Single_Single_Single_Ref_Boolean.SetBelong(null);
				}
				return r_RPixelPreciseCollapsibleSlider_Int32_Rect_Single_Single_Single_Ref_Boolean;
			}
		}

		/// <summary>
		/// Single PixelPreciseCollapsibleSlider(Int32, UnityEngine.Rect, Single, Single, Single, Boolean ByRef, Boolean)
		/// </summary>
		protected static RMethod r_RPixelPreciseCollapsibleSlider_Int32_Rect_Single_Single_Single_Ref_Boolean_Boolean;
		public static RMethod RPixelPreciseCollapsibleSlider_Int32_Rect_Single_Single_Single_Ref_Boolean_Boolean
		{
			get
			{
				if(r_RPixelPreciseCollapsibleSlider_Int32_Rect_Single_Single_Single_Ref_Boolean_Boolean == null)
				{
					r_RPixelPreciseCollapsibleSlider_Int32_Rect_Single_Single_Single_Ref_Boolean_Boolean = new( ReleactionUtils.GetType("UnityEditor.PreviewResizer"), "PixelPreciseCollapsibleSlider", 0, typeof(System.Int32), typeof(UnityEngine.Rect), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Boolean).MakeByRefType(), typeof(System.Boolean));
					r_RPixelPreciseCollapsibleSlider_Int32_Rect_Single_Single_Single_Ref_Boolean_Boolean.SetBelong(null);
				}
				return r_RPixelPreciseCollapsibleSlider_Int32_Rect_Single_Single_Single_Ref_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void SetContainer(UnityEngine.UIElements.IMGUIContainer, Single)
		/// </summary>
		protected RMethod r_RSetContainer_IMGUIContainer_Single;
		public virtual RMethod RSetContainer_IMGUIContainer_Single
		{
			get
			{
				if(r_RSetContainer_IMGUIContainer_Single == null)
				{
					r_RSetContainer_IMGUIContainer_Single = new(this, "SetContainer", 0, typeof(UnityEngine.UIElements.IMGUIContainer), typeof(System.Single));
					r_RSetContainer_IMGUIContainer_Single.SetBelong(this.instance);
				}
				return r_RSetContainer_IMGUIContainer_Single;
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

        public virtual void Init(System.String  @prefName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prefName};
            var ___result = RInit_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Single ResizeHandle(UnityEngine.Rect  @windowPosition, System.Single  @minSize, System.Single  @minRemainingSize, System.Single  @resizerHeight)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@windowPosition, @minSize, @minRemainingSize, @resizerHeight};
            var ___result = RResizeHandle_Rect_Single_Single_Single.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Single ResizeHandle(UnityEngine.Rect  @windowPosition, System.Single  @minSize, System.Single  @minRemainingSize, System.Single  @resizerHeight, UnityEngine.Rect  @dragRect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@windowPosition, @minSize, @minRemainingSize, @resizerHeight, @dragRect};
            var ___result = RResizeHandle_Rect_Single_Single_Single_Rect.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Single SetExpanded(UnityEngine.Rect  @windowPosition, System.Single  @minSize, System.Single  @minRemainingSize, System.Single  @resizerHeight, UnityEngine.Rect  @dragRect, System.Boolean  @isExpanded)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@windowPosition, @minSize, @minRemainingSize, @resizerHeight, @dragRect, @isExpanded};
            var ___result = RSetExpanded_Rect_Single_Single_Single_Rect_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Boolean GetExpanded()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetExpanded.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Single GetPreviewSize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetPreviewSize.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Boolean GetExpandedBeforeDragging()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetExpandedBeforeDragging.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetExpanded(System.Boolean  @expanded)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@expanded};
            var ___result = RSetExpanded_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ToggleExpanded()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToggleExpanded.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Single PixelPreciseCollapsibleSlider(System.Int32  @id, UnityEngine.Rect  @position, System.Single  @value, System.Single  @min, System.Single  @max, ref System.Boolean  @expanded)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id, @position, @value, @min, @max, @expanded};
            var ___result = RPixelPreciseCollapsibleSlider_Int32_Rect_Single_Single_Single_Ref_Boolean.Invoke(___genericsType, ___parameters);
			expanded = (System.Boolean)___parameters[5];

            return (System.Single)___result;
        }


        public static System.Single PixelPreciseCollapsibleSlider(System.Int32  @id, UnityEngine.Rect  @position, System.Single  @value, System.Single  @min, System.Single  @max, ref System.Boolean  @expanded, System.Boolean  @localFrame)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id, @position, @value, @min, @max, @expanded, @localFrame};
            var ___result = RPixelPreciseCollapsibleSlider_Int32_Rect_Single_Single_Single_Ref_Boolean_Boolean.Invoke(___genericsType, ___parameters);
			expanded = (System.Boolean)___parameters[5];

            return (System.Single)___result;
        }


        public virtual void SetContainer(UnityEngine.UIElements.IMGUIContainer  @container, System.Single  @minimumHeightCollapsed)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@container, @minimumHeightCollapsed};
            var ___result = RSetContainer_IMGUIContainer_Single.Invoke(___genericsType, ___parameters);

            
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
