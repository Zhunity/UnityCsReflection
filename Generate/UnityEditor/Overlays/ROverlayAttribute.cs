using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor.ROverlays
{
	/// <summary>
	/// UnityEditor.Overlays.OverlayAttribute
	/// </summary>
    public partial class ROverlayAttribute : RMember //
    {

		/// <summary>
		/// System.Type m_EditorWindowType
		/// </summary>
		protected RSystem.RType r_m_EditorWindowType;
		public virtual RSystem.RType Rm_EditorWindowType
		{
			get
			{
				if(r_m_EditorWindowType == null)
				{
					r_m_EditorWindowType = new(this, "m_EditorWindowType");
					r_m_EditorWindowType.SetBelong(this.instance);
				}
				return r_m_EditorWindowType;
			}
		}

		/// <summary>
		/// System.String m_Id
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
		/// System.String m_UssName
		/// </summary>
		protected RField r_m_UssName;
		public virtual RField Rm_UssName
		{
			get
			{
				if(r_m_UssName == null)
				{
					r_m_UssName = new(this, "m_UssName");
					r_m_UssName.SetBelong(this.instance);
				}
				return r_m_UssName;
			}
		}

		/// <summary>
		/// System.Boolean m_DefaultDisplay
		/// </summary>
		protected RField r_m_DefaultDisplay;
		public virtual RField Rm_DefaultDisplay
		{
			get
			{
				if(r_m_DefaultDisplay == null)
				{
					r_m_DefaultDisplay = new(this, "m_DefaultDisplay");
					r_m_DefaultDisplay.SetBelong(this.instance);
				}
				return r_m_DefaultDisplay;
			}
		}

		/// <summary>
		/// System.String m_DisplayName
		/// </summary>
		protected RField r_m_DisplayName;
		public virtual RField Rm_DisplayName
		{
			get
			{
				if(r_m_DisplayName == null)
				{
					r_m_DisplayName = new(this, "m_DisplayName");
					r_m_DisplayName.SetBelong(this.instance);
				}
				return r_m_DisplayName;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.DockZone m_DefaultDockZone
		/// </summary>
		protected RField r_m_DefaultDockZone;
		public virtual RField Rm_DefaultDockZone
		{
			get
			{
				if(r_m_DefaultDockZone == null)
				{
					r_m_DefaultDockZone = new(this, "m_DefaultDockZone");
					r_m_DefaultDockZone.SetBelong(this.instance);
				}
				return r_m_DefaultDockZone;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.DockPosition m_DefaultDockPosition
		/// </summary>
		protected RField r_m_DefaultDockPosition;
		public virtual RField Rm_DefaultDockPosition
		{
			get
			{
				if(r_m_DefaultDockPosition == null)
				{
					r_m_DefaultDockPosition = new(this, "m_DefaultDockPosition");
					r_m_DefaultDockPosition.SetBelong(this.instance);
				}
				return r_m_DefaultDockPosition;
			}
		}

		/// <summary>
		/// System.Int32 m_DefaultDockIndex
		/// </summary>
		protected RField r_m_DefaultDockIndex;
		public virtual RField Rm_DefaultDockIndex
		{
			get
			{
				if(r_m_DefaultDockIndex == null)
				{
					r_m_DefaultDockIndex = new(this, "m_DefaultDockIndex");
					r_m_DefaultDockIndex.SetBelong(this.instance);
				}
				return r_m_DefaultDockIndex;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.Layout m_DefaultLayout
		/// </summary>
		protected RField r_m_DefaultLayout;
		public virtual RField Rm_DefaultLayout
		{
			get
			{
				if(r_m_DefaultLayout == null)
				{
					r_m_DefaultLayout = new(this, "m_DefaultLayout");
					r_m_DefaultLayout.SetBelong(this.instance);
				}
				return r_m_DefaultLayout;
			}
		}

		/// <summary>
		/// System.Type editorWindowType
		/// </summary>
		protected RSystem.RType r_editorWindowType;
		public virtual RSystem.RType ReditorWindowType
		{
			get
			{
				if(r_editorWindowType == null)
				{
					r_editorWindowType = new(this, "editorWindowType", -1);
					r_editorWindowType.SetBelong(this.instance);
				}
				return r_editorWindowType;
			}
		}

		/// <summary>
		/// System.String id
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
		/// System.String displayName
		/// </summary>
		protected RProperty r_displayName;
		public virtual RProperty RdisplayName
		{
			get
			{
				if(r_displayName == null)
				{
					r_displayName = new(this, "displayName", -1);
					r_displayName.SetBelong(this.instance);
				}
				return r_displayName;
			}
		}

		/// <summary>
		/// System.String ussName
		/// </summary>
		protected RProperty r_ussName;
		public virtual RProperty RussName
		{
			get
			{
				if(r_ussName == null)
				{
					r_ussName = new(this, "ussName", -1);
					r_ussName.SetBelong(this.instance);
				}
				return r_ussName;
			}
		}

		/// <summary>
		/// Boolean defaultDisplay
		/// </summary>
		protected RProperty r_defaultDisplay;
		public virtual RProperty RdefaultDisplay
		{
			get
			{
				if(r_defaultDisplay == null)
				{
					r_defaultDisplay = new(this, "defaultDisplay", -1);
					r_defaultDisplay.SetBelong(this.instance);
				}
				return r_defaultDisplay;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.DockZone defaultDockZone
		/// </summary>
		protected RProperty r_defaultDockZone;
		public virtual RProperty RdefaultDockZone
		{
			get
			{
				if(r_defaultDockZone == null)
				{
					r_defaultDockZone = new(this, "defaultDockZone", -1);
					r_defaultDockZone.SetBelong(this.instance);
				}
				return r_defaultDockZone;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.DockPosition defaultDockPosition
		/// </summary>
		protected RProperty r_defaultDockPosition;
		public virtual RProperty RdefaultDockPosition
		{
			get
			{
				if(r_defaultDockPosition == null)
				{
					r_defaultDockPosition = new(this, "defaultDockPosition", -1);
					r_defaultDockPosition.SetBelong(this.instance);
				}
				return r_defaultDockPosition;
			}
		}

		/// <summary>
		/// Int32 defaultDockIndex
		/// </summary>
		protected RProperty r_defaultDockIndex;
		public virtual RProperty RdefaultDockIndex
		{
			get
			{
				if(r_defaultDockIndex == null)
				{
					r_defaultDockIndex = new(this, "defaultDockIndex", -1);
					r_defaultDockIndex.SetBelong(this.instance);
				}
				return r_defaultDockIndex;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.Layout defaultLayout
		/// </summary>
		protected RProperty r_defaultLayout;
		public virtual RProperty RdefaultLayout
		{
			get
			{
				if(r_defaultLayout == null)
				{
					r_defaultLayout = new(this, "defaultLayout", -1);
					r_defaultLayout.SetBelong(this.instance);
				}
				return r_defaultLayout;
			}
		}

		/// <summary>
		/// System.Object TypeId
		/// </summary>
		protected RSystem.RObject r_TypeId;
		public virtual RSystem.RObject RTypeId
		{
			get
			{
				if(r_TypeId == null)
				{
					r_TypeId = new(this, "TypeId", -1);
					r_TypeId.SetBelong(this.instance);
				}
				return r_TypeId;
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
		/// Boolean Match(System.Object)
		/// </summary>
		protected RMethod r_RMatch_Object;
		public virtual RMethod RMatch_Object
		{
			get
			{
				if(r_RMatch_Object == null)
				{
					r_RMatch_Object = new(this, "Match", 0, typeof(System.Object));
					r_RMatch_Object.SetBelong(this.instance);
				}
				return r_RMatch_Object;
			}
		}

		/// <summary>
		/// Boolean IsDefaultAttribute()
		/// </summary>
		protected RMethod r_RIsDefaultAttribute;
		public virtual RMethod RIsDefaultAttribute
		{
			get
			{
				if(r_RIsDefaultAttribute == null)
				{
					r_RIsDefaultAttribute = new(this, "IsDefaultAttribute", 0);
					r_RIsDefaultAttribute.SetBelong(this.instance);
				}
				return r_RIsDefaultAttribute;
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


        public ROverlayAttribute() : base("UnityEditor.Overlays.OverlayAttribute")
        {
        }

        public ROverlayAttribute(System.Object instance) : base("UnityEditor.Overlays.OverlayAttribute")
		{
            SetInstance(instance);
		}

        public ROverlayAttribute(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public ROverlayAttribute(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Match(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMatch_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsDefaultAttribute()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsDefaultAttribute.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}