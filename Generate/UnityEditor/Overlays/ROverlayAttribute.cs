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
		protected RSystem.RType r_Fm_EditorWindowType;
		public virtual RSystem.RType RFm_EditorWindowType
		{
			get
			{
				if(r_Fm_EditorWindowType == null)
				{
					r_Fm_EditorWindowType = new(this, "m_EditorWindowType");
					r_Fm_EditorWindowType.SetBelong(this.instance);
				}
				return r_Fm_EditorWindowType;
			}
		}

		/// <summary>
		/// System.String m_Id
		/// </summary>
		protected RSystem.RString r_Fm_Id;
		public virtual RSystem.RString RFm_Id
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
		/// System.String m_UssName
		/// </summary>
		protected RSystem.RString r_Fm_UssName;
		public virtual RSystem.RString RFm_UssName
		{
			get
			{
				if(r_Fm_UssName == null)
				{
					r_Fm_UssName = new(this, "m_UssName");
					r_Fm_UssName.SetBelong(this.instance);
				}
				return r_Fm_UssName;
			}
		}

		/// <summary>
		/// System.Boolean m_DefaultDisplay
		/// </summary>
		protected RSystem.RBoolean r_Fm_DefaultDisplay;
		public virtual RSystem.RBoolean RFm_DefaultDisplay
		{
			get
			{
				if(r_Fm_DefaultDisplay == null)
				{
					r_Fm_DefaultDisplay = new(this, "m_DefaultDisplay");
					r_Fm_DefaultDisplay.SetBelong(this.instance);
				}
				return r_Fm_DefaultDisplay;
			}
		}

		/// <summary>
		/// System.String m_DisplayName
		/// </summary>
		protected RSystem.RString r_Fm_DisplayName;
		public virtual RSystem.RString RFm_DisplayName
		{
			get
			{
				if(r_Fm_DisplayName == null)
				{
					r_Fm_DisplayName = new(this, "m_DisplayName");
					r_Fm_DisplayName.SetBelong(this.instance);
				}
				return r_Fm_DisplayName;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.DockZone m_DefaultDockZone
		/// </summary>
		protected RUnityEditor.ROverlays.RDockZone r_Fm_DefaultDockZone;
		public virtual RUnityEditor.ROverlays.RDockZone RFm_DefaultDockZone
		{
			get
			{
				if(r_Fm_DefaultDockZone == null)
				{
					r_Fm_DefaultDockZone = new(this, "m_DefaultDockZone");
					r_Fm_DefaultDockZone.SetBelong(this.instance);
				}
				return r_Fm_DefaultDockZone;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.DockPosition m_DefaultDockPosition
		/// </summary>
		protected RUnityEditor.ROverlays.RDockPosition r_Fm_DefaultDockPosition;
		public virtual RUnityEditor.ROverlays.RDockPosition RFm_DefaultDockPosition
		{
			get
			{
				if(r_Fm_DefaultDockPosition == null)
				{
					r_Fm_DefaultDockPosition = new(this, "m_DefaultDockPosition");
					r_Fm_DefaultDockPosition.SetBelong(this.instance);
				}
				return r_Fm_DefaultDockPosition;
			}
		}

		/// <summary>
		/// System.Int32 m_DefaultDockIndex
		/// </summary>
		protected RSystem.RInt32 r_Fm_DefaultDockIndex;
		public virtual RSystem.RInt32 RFm_DefaultDockIndex
		{
			get
			{
				if(r_Fm_DefaultDockIndex == null)
				{
					r_Fm_DefaultDockIndex = new(this, "m_DefaultDockIndex");
					r_Fm_DefaultDockIndex.SetBelong(this.instance);
				}
				return r_Fm_DefaultDockIndex;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.Layout m_DefaultLayout
		/// </summary>
		protected RUnityEditor.ROverlays.RLayout r_Fm_DefaultLayout;
		public virtual RUnityEditor.ROverlays.RLayout RFm_DefaultLayout
		{
			get
			{
				if(r_Fm_DefaultLayout == null)
				{
					r_Fm_DefaultLayout = new(this, "m_DefaultLayout");
					r_Fm_DefaultLayout.SetBelong(this.instance);
				}
				return r_Fm_DefaultLayout;
			}
		}

		/// <summary>
		/// System.Type editorWindowType
		/// </summary>
		protected RSystem.RType r_PeditorWindowType;
		public virtual RSystem.RType RPeditorWindowType
		{
			get
			{
				if(r_PeditorWindowType == null)
				{
					r_PeditorWindowType = new(this, "editorWindowType", -1);
					r_PeditorWindowType.SetBelong(this.instance);
				}
				return r_PeditorWindowType;
			}
		}

		/// <summary>
		/// System.String id
		/// </summary>
		protected RSystem.RString r_Pid;
		public virtual RSystem.RString RPid
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
		/// System.String displayName
		/// </summary>
		protected RSystem.RString r_PdisplayName;
		public virtual RSystem.RString RPdisplayName
		{
			get
			{
				if(r_PdisplayName == null)
				{
					r_PdisplayName = new(this, "displayName", -1);
					r_PdisplayName.SetBelong(this.instance);
				}
				return r_PdisplayName;
			}
		}

		/// <summary>
		/// System.String ussName
		/// </summary>
		protected RSystem.RString r_PussName;
		public virtual RSystem.RString RPussName
		{
			get
			{
				if(r_PussName == null)
				{
					r_PussName = new(this, "ussName", -1);
					r_PussName.SetBelong(this.instance);
				}
				return r_PussName;
			}
		}

		/// <summary>
		/// Boolean defaultDisplay
		/// </summary>
		protected RSystem.RBoolean r_PdefaultDisplay;
		public virtual RSystem.RBoolean RPdefaultDisplay
		{
			get
			{
				if(r_PdefaultDisplay == null)
				{
					r_PdefaultDisplay = new(this, "defaultDisplay", -1);
					r_PdefaultDisplay.SetBelong(this.instance);
				}
				return r_PdefaultDisplay;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.DockZone defaultDockZone
		/// </summary>
		protected RUnityEditor.ROverlays.RDockZone r_PdefaultDockZone;
		public virtual RUnityEditor.ROverlays.RDockZone RPdefaultDockZone
		{
			get
			{
				if(r_PdefaultDockZone == null)
				{
					r_PdefaultDockZone = new(this, "defaultDockZone", -1);
					r_PdefaultDockZone.SetBelong(this.instance);
				}
				return r_PdefaultDockZone;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.DockPosition defaultDockPosition
		/// </summary>
		protected RUnityEditor.ROverlays.RDockPosition r_PdefaultDockPosition;
		public virtual RUnityEditor.ROverlays.RDockPosition RPdefaultDockPosition
		{
			get
			{
				if(r_PdefaultDockPosition == null)
				{
					r_PdefaultDockPosition = new(this, "defaultDockPosition", -1);
					r_PdefaultDockPosition.SetBelong(this.instance);
				}
				return r_PdefaultDockPosition;
			}
		}

		/// <summary>
		/// Int32 defaultDockIndex
		/// </summary>
		protected RSystem.RInt32 r_PdefaultDockIndex;
		public virtual RSystem.RInt32 RPdefaultDockIndex
		{
			get
			{
				if(r_PdefaultDockIndex == null)
				{
					r_PdefaultDockIndex = new(this, "defaultDockIndex", -1);
					r_PdefaultDockIndex.SetBelong(this.instance);
				}
				return r_PdefaultDockIndex;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.Layout defaultLayout
		/// </summary>
		protected RUnityEditor.ROverlays.RLayout r_PdefaultLayout;
		public virtual RUnityEditor.ROverlays.RLayout RPdefaultLayout
		{
			get
			{
				if(r_PdefaultLayout == null)
				{
					r_PdefaultLayout = new(this, "defaultLayout", -1);
					r_PdefaultLayout.SetBelong(this.instance);
				}
				return r_PdefaultLayout;
			}
		}

		/// <summary>
		/// System.Object TypeId
		/// </summary>
		protected RSystem.RObject r_PTypeId;
		public virtual RSystem.RObject RPTypeId
		{
			get
			{
				if(r_PTypeId == null)
				{
					r_PTypeId = new(this, "TypeId", -1);
					r_PTypeId.SetBelong(this.instance);
				}
				return r_PTypeId;
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
		/// Boolean Match(System.Object)
		/// </summary>
		protected RMethod r_MMatch_Object;
		public virtual RMethod RMMatch_Object
		{
			get
			{
				if(r_MMatch_Object == null)
				{
					r_MMatch_Object = new(this, "Match", 0, typeof(System.Object));
					r_MMatch_Object.SetBelong(this.instance);
				}
				return r_MMatch_Object;
			}
		}

		/// <summary>
		/// Boolean IsDefaultAttribute()
		/// </summary>
		protected RMethod r_MIsDefaultAttribute;
		public virtual RMethod RMIsDefaultAttribute
		{
			get
			{
				if(r_MIsDefaultAttribute == null)
				{
					r_MIsDefaultAttribute = new(this, "IsDefaultAttribute", 0);
					r_MIsDefaultAttribute.SetBelong(this.instance);
				}
				return r_MIsDefaultAttribute;
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
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Match(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMMatch_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsDefaultAttribute()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsDefaultAttribute.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
