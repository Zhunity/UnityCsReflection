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
		protected RMethod r_ROnGUI_Rect;
		public virtual RMethod ROnGUI_Rect
		{
			get
			{
				if(r_ROnGUI_Rect == null)
				{
					r_ROnGUI_Rect = new(this, "OnGUI", 0, typeof(UnityEngine.Rect));
					r_ROnGUI_Rect.SetBelong(this.instance);
				}
				return r_ROnGUI_Rect;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement CreatePropertyGUI()
		/// </summary>
		protected RMethod r_RCreatePropertyGUI;
		public virtual RMethod RCreatePropertyGUI
		{
			get
			{
				if(r_RCreatePropertyGUI == null)
				{
					r_RCreatePropertyGUI = new(this, "CreatePropertyGUI", 0);
					r_RCreatePropertyGUI.SetBelong(this.instance);
				}
				return r_RCreatePropertyGUI;
			}
		}

		/// <summary>
		/// Single GetHeight()
		/// </summary>
		protected RMethod r_RGetHeight;
		public virtual RMethod RGetHeight
		{
			get
			{
				if(r_RGetHeight == null)
				{
					r_RGetHeight = new(this, "GetHeight", 0);
					r_RGetHeight.SetBelong(this.instance);
				}
				return r_RGetHeight;
			}
		}

		/// <summary>
		/// Boolean CanCacheInspectorGUI()
		/// </summary>
		protected RMethod r_RCanCacheInspectorGUI;
		public virtual RMethod RCanCacheInspectorGUI
		{
			get
			{
				if(r_RCanCacheInspectorGUI == null)
				{
					r_RCanCacheInspectorGUI = new(this, "CanCacheInspectorGUI", 0);
					r_RCanCacheInspectorGUI.SetBelong(this.instance);
				}
				return r_RCanCacheInspectorGUI;
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

        public virtual void OnGUI(UnityEngine.Rect  @position)
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
