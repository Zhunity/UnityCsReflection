
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.ROverlays
{
	/// <summary>
	/// UnityEditor.Overlays.OverlayAttribute
	/// </summary>
    public partial class ROverlayAttribute : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEditor.Overlays.OverlayAttribute);
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


		/// <summary>
		/// System.Type m_EditorWindowType
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RType r_Fm_EditorWindowType;
		public virtual Hvak.Editor.Refleaction.RSystem.RType RFm_EditorWindowType
		{
			get
			{
				if(r_Fm_EditorWindowType == null)
				{
					r_Fm_EditorWindowType = new(this, "m_EditorWindowType");
				}
				return r_Fm_EditorWindowType;
			}
		}

		/// <summary>
		/// System.String m_Id
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_Id;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_Id
		{
			get
			{
				if(r_Fm_Id == null)
				{
					r_Fm_Id = new(this, "m_Id");
				}
				return r_Fm_Id;
			}
		}

		/// <summary>
		/// System.String m_UssName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_UssName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_UssName
		{
			get
			{
				if(r_Fm_UssName == null)
				{
					r_Fm_UssName = new(this, "m_UssName");
				}
				return r_Fm_UssName;
			}
		}

		/// <summary>
		/// System.Boolean m_DefaultDisplay
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_DefaultDisplay;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_DefaultDisplay
		{
			get
			{
				if(r_Fm_DefaultDisplay == null)
				{
					r_Fm_DefaultDisplay = new(this, "m_DefaultDisplay");
				}
				return r_Fm_DefaultDisplay;
			}
		}

		/// <summary>
		/// System.String m_DisplayName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_DisplayName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_DisplayName
		{
			get
			{
				if(r_Fm_DisplayName == null)
				{
					r_Fm_DisplayName = new(this, "m_DisplayName");
				}
				return r_Fm_DisplayName;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.DockZone m_DefaultDockZone
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.ROverlays.RDockZone r_Fm_DefaultDockZone;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.ROverlays.RDockZone RFm_DefaultDockZone
		{
			get
			{
				if(r_Fm_DefaultDockZone == null)
				{
					r_Fm_DefaultDockZone = new(this, "m_DefaultDockZone");
				}
				return r_Fm_DefaultDockZone;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.DockPosition m_DefaultDockPosition
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.ROverlays.RDockPosition r_Fm_DefaultDockPosition;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.ROverlays.RDockPosition RFm_DefaultDockPosition
		{
			get
			{
				if(r_Fm_DefaultDockPosition == null)
				{
					r_Fm_DefaultDockPosition = new(this, "m_DefaultDockPosition");
				}
				return r_Fm_DefaultDockPosition;
			}
		}

		/// <summary>
		/// System.Int32 m_DefaultDockIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_DefaultDockIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_DefaultDockIndex
		{
			get
			{
				if(r_Fm_DefaultDockIndex == null)
				{
					r_Fm_DefaultDockIndex = new(this, "m_DefaultDockIndex");
				}
				return r_Fm_DefaultDockIndex;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.Layout m_DefaultLayout
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.ROverlays.RLayout r_Fm_DefaultLayout;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.ROverlays.RLayout RFm_DefaultLayout
		{
			get
			{
				if(r_Fm_DefaultLayout == null)
				{
					r_Fm_DefaultLayout = new(this, "m_DefaultLayout");
				}
				return r_Fm_DefaultLayout;
			}
		}

		/// <summary>
		/// System.Type editorWindowType
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RType r_PeditorWindowType;
		public virtual Hvak.Editor.Refleaction.RSystem.RType RPeditorWindowType
		{
			get
			{
				if(r_PeditorWindowType == null)
				{
					r_PeditorWindowType = new(this, "editorWindowType", -1);
				}
				return r_PeditorWindowType;
			}
		}

		/// <summary>
		/// System.String id
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Pid;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPid
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
		/// System.String displayName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PdisplayName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPdisplayName
		{
			get
			{
				if(r_PdisplayName == null)
				{
					r_PdisplayName = new(this, "displayName", -1);
				}
				return r_PdisplayName;
			}
		}

		/// <summary>
		/// System.String ussName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PussName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPussName
		{
			get
			{
				if(r_PussName == null)
				{
					r_PussName = new(this, "ussName", -1);
				}
				return r_PussName;
			}
		}

		/// <summary>
		/// Boolean defaultDisplay
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PdefaultDisplay;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPdefaultDisplay
		{
			get
			{
				if(r_PdefaultDisplay == null)
				{
					r_PdefaultDisplay = new(this, "defaultDisplay", -1);
				}
				return r_PdefaultDisplay;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.DockZone defaultDockZone
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.ROverlays.RDockZone r_PdefaultDockZone;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.ROverlays.RDockZone RPdefaultDockZone
		{
			get
			{
				if(r_PdefaultDockZone == null)
				{
					r_PdefaultDockZone = new(this, "defaultDockZone", -1);
				}
				return r_PdefaultDockZone;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.DockPosition defaultDockPosition
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.ROverlays.RDockPosition r_PdefaultDockPosition;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.ROverlays.RDockPosition RPdefaultDockPosition
		{
			get
			{
				if(r_PdefaultDockPosition == null)
				{
					r_PdefaultDockPosition = new(this, "defaultDockPosition", -1);
				}
				return r_PdefaultDockPosition;
			}
		}

		/// <summary>
		/// Int32 defaultDockIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PdefaultDockIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPdefaultDockIndex
		{
			get
			{
				if(r_PdefaultDockIndex == null)
				{
					r_PdefaultDockIndex = new(this, "defaultDockIndex", -1);
				}
				return r_PdefaultDockIndex;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.Layout defaultLayout
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.ROverlays.RLayout r_PdefaultLayout;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.ROverlays.RLayout RPdefaultLayout
		{
			get
			{
				if(r_PdefaultLayout == null)
				{
					r_PdefaultLayout = new(this, "defaultLayout", -1);
				}
				return r_PdefaultLayout;
			}
		}

		/// <summary>
		/// System.Object TypeId
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_PTypeId;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RPTypeId
		{
			get
			{
				if(r_PTypeId == null)
				{
					r_PTypeId = new(this, "TypeId", -1);
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
