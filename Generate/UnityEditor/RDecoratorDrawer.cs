using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor
{
	/// <summary>
	/// UnityEditor.DecoratorDrawer
	/// </summary>
    public partial class RDecoratorDrawer : RMember //
    {

		/// <summary>
		/// UnityEngine.PropertyAttribute m_Attribute
		/// </summary>
		protected RUnityEngine.RPropertyAttribute r_m_Attribute;
		public virtual RUnityEngine.RPropertyAttribute Rm_Attribute
		{
			get
			{
				if(r_m_Attribute == null)
				{
					r_m_Attribute = new(this, "m_Attribute");
					r_m_Attribute.SetBelong(this.instance);
				}
				return r_m_Attribute;
			}
		}

		/// <summary>
		/// UnityEngine.PropertyAttribute attribute
		/// </summary>
		protected RUnityEngine.RPropertyAttribute r_attribute;
		public virtual RUnityEngine.RPropertyAttribute Rattribute
		{
			get
			{
				if(r_attribute == null)
				{
					r_attribute = new(this, "attribute", -1);
					r_attribute.SetBelong(this.instance);
				}
				return r_attribute;
			}
		}

		/// <summary>
		/// Void OnGUI(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_OnGUI_Rect;
		public virtual RMethod ROnGUI_Rect
		{
			get
			{
				if(r_OnGUI_Rect == null)
				{
					r_OnGUI_Rect = new(this, "OnGUI", 0, typeof(UnityEngine.Rect));
					r_OnGUI_Rect.SetBelong(this.instance);
				}
				return r_OnGUI_Rect;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement CreatePropertyGUI()
		/// </summary>
		protected RMethod r_CreatePropertyGUI;
		public virtual RMethod RCreatePropertyGUI
		{
			get
			{
				if(r_CreatePropertyGUI == null)
				{
					r_CreatePropertyGUI = new(this, "CreatePropertyGUI", 0);
					r_CreatePropertyGUI.SetBelong(this.instance);
				}
				return r_CreatePropertyGUI;
			}
		}

		/// <summary>
		/// Single GetHeight()
		/// </summary>
		protected RMethod r_GetHeight;
		public virtual RMethod RGetHeight
		{
			get
			{
				if(r_GetHeight == null)
				{
					r_GetHeight = new(this, "GetHeight", 0);
					r_GetHeight.SetBelong(this.instance);
				}
				return r_GetHeight;
			}
		}

		/// <summary>
		/// Boolean CanCacheInspectorGUI()
		/// </summary>
		protected RMethod r_CanCacheInspectorGUI;
		public virtual RMethod RCanCacheInspectorGUI
		{
			get
			{
				if(r_CanCacheInspectorGUI == null)
				{
					r_CanCacheInspectorGUI = new(this, "CanCacheInspectorGUI", 0);
					r_CanCacheInspectorGUI.SetBelong(this.instance);
				}
				return r_CanCacheInspectorGUI;
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


        public RDecoratorDrawer() : base("UnityEditor.DecoratorDrawer")
        {
        }

        public RDecoratorDrawer(System.Object instance) : base("UnityEditor.DecoratorDrawer")
		{
            SetInstance(instance);
		}

        public RDecoratorDrawer(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RDecoratorDrawer(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void OnGUI(UnityEngine.Rect @position)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position};
            var ___result = ROnGUI_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.UIElements.VisualElement CreatePropertyGUI()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCreatePropertyGUI.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual System.Single GetHeight()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHeight.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Boolean CanCacheInspectorGUI()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCanCacheInspectorGUI.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
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
