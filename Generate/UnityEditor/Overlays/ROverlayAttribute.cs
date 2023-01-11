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
		protected RSystem.RString r_m_Id;
		public virtual RSystem.RString Rm_Id
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
		protected RSystem.RString r_m_UssName;
		public virtual RSystem.RString Rm_UssName
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
		protected RSystem.RBoolean r_m_DefaultDisplay;
		public virtual RSystem.RBoolean Rm_DefaultDisplay
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
		protected RSystem.RString r_m_DisplayName;
		public virtual RSystem.RString Rm_DisplayName
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
		protected RSystem.RInt32 r_m_DefaultDockIndex;
		public virtual RSystem.RInt32 Rm_DefaultDockIndex
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
		protected RSystem.RString r_id;
		public virtual RSystem.RString Rid
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
		protected RSystem.RString r_displayName;
		public virtual RSystem.RString RdisplayName
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
		protected RSystem.RString r_ussName;
		public virtual RSystem.RString RussName
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
		protected RSystem.RBoolean r_defaultDisplay;
		public virtual RSystem.RBoolean RdefaultDisplay
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
		protected RSystem.RInt32 r_defaultDockIndex;
		public virtual RSystem.RInt32 RdefaultDockIndex
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
		/// Boolean Match(System.Object)
		/// </summary>
		protected RMethod r_Match_Object;
		public virtual RMethod RMatch_Object
		{
			get
			{
				if(r_Match_Object == null)
				{
					r_Match_Object = new(this, "Match", 0, typeof(System.Object));
					r_Match_Object.SetBelong(this.instance);
				}
				return r_Match_Object;
			}
		}

		/// <summary>
		/// Boolean IsDefaultAttribute()
		/// </summary>
		protected RMethod r_IsDefaultAttribute;
		public virtual RMethod RIsDefaultAttribute
		{
			get
			{
				if(r_IsDefaultAttribute == null)
				{
					r_IsDefaultAttribute = new(this, "IsDefaultAttribute", 0);
					r_IsDefaultAttribute.SetBelong(this.instance);
				}
				return r_IsDefaultAttribute;
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

        public virtual System.Boolean Equals(System.Object @obj)
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


        public virtual System.Boolean Match(System.Object @obj)
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
