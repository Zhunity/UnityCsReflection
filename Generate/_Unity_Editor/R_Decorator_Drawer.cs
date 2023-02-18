
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor
{
	/// <summary>
	/// UnityEditor.DecoratorDrawer
	/// </summary>
    public partial class RDecoratorDrawer : RMember //
    {

		/// <summary>
		/// UnityEngine.PropertyAttribute m_Attribute
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RPropertyAttribute r_Fm_Attribute;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RPropertyAttribute RFm_Attribute
		{
			get
			{
				if(r_Fm_Attribute == null)
				{
					r_Fm_Attribute = new(this, "m_Attribute");
				}
				return r_Fm_Attribute;
			}
		}

		/// <summary>
		/// UnityEngine.PropertyAttribute attribute
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RPropertyAttribute r_Pattribute;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RPropertyAttribute RPattribute
		{
			get
			{
				if(r_Pattribute == null)
				{
					r_Pattribute = new(this, "attribute", -1);
				}
				return r_Pattribute;
			}
		}

		/// <summary>
		/// Void OnGUI(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_MOnGUI_Rect;
		public virtual RMethod RMOnGUI_Rect
		{
			get
			{
				if(r_MOnGUI_Rect == null)
				{
					r_MOnGUI_Rect = new(this, "OnGUI", 0, typeof(UnityEngine.Rect));
				}
				return r_MOnGUI_Rect;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement CreatePropertyGUI()
		/// </summary>
		protected RMethod r_MCreatePropertyGUI;
		public virtual RMethod RMCreatePropertyGUI
		{
			get
			{
				if(r_MCreatePropertyGUI == null)
				{
					r_MCreatePropertyGUI = new(this, "CreatePropertyGUI", 0);
				}
				return r_MCreatePropertyGUI;
			}
		}

		/// <summary>
		/// Single GetHeight()
		/// </summary>
		protected RMethod r_MGetHeight;
		public virtual RMethod RMGetHeight
		{
			get
			{
				if(r_MGetHeight == null)
				{
					r_MGetHeight = new(this, "GetHeight", 0);
				}
				return r_MGetHeight;
			}
		}

		/// <summary>
		/// Boolean CanCacheInspectorGUI()
		/// </summary>
		protected RMethod r_MCanCacheInspectorGUI;
		public virtual RMethod RMCanCacheInspectorGUI
		{
			get
			{
				if(r_MCanCacheInspectorGUI == null)
				{
					r_MCanCacheInspectorGUI = new(this, "CanCacheInspectorGUI", 0);
				}
				return r_MCanCacheInspectorGUI;
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
            var ___result = RMOnGUI_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.UIElements.VisualElement CreatePropertyGUI()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCreatePropertyGUI.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual System.Single GetHeight()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHeight.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Boolean CanCacheInspectorGUI()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCanCacheInspectorGUI.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
