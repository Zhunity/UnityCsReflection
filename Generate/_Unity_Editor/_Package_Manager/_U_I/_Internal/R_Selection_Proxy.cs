
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
	/// UnityEditor.PackageManager.UI.Internal.SelectionProxy
	/// </summary>
    public partial class RSelectionProxy : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.SelectionProxy");
            }
        }

        public RSelectionProxy() : base("UnityEditor.PackageManager.UI.Internal.SelectionProxy")
        {
        }

        public RSelectionProxy(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.SelectionProxy")
		{
            SetInstance(instance);
		}

        public RSelectionProxy(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSelectionProxy(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Action onSelectionChanged
		/// </summary>
		protected REvent r_EonSelectionChanged;
		public virtual REvent REonSelectionChanged
		{
			get
			{
				if(r_EonSelectionChanged == null)
				{
					r_EonSelectionChanged = new(this, "onSelectionChanged");
				}
				return r_EonSelectionChanged;
			}
		}

		/// <summary>
		/// System.Action onSelectionChanged
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction r_FonSelectionChanged;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction RFonSelectionChanged
		{
			get
			{
				if(r_FonSelectionChanged == null)
				{
					r_FonSelectionChanged = new(this, "onSelectionChanged");
				}
				return r_FonSelectionChanged;
			}
		}

		/// <summary>
		/// UnityEngine.Object[] objects
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RObject> r_Pobjects;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RObject> RPobjects
		{
			get
			{
				if(r_Pobjects == null)
				{
					r_Pobjects = new(this, "objects", -1);
				}
				return r_Pobjects;
			}
		}

		/// <summary>
		/// UnityEngine.Object activeObject
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RObject r_PactiveObject;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RObject RPactiveObject
		{
			get
			{
				if(r_PactiveObject == null)
				{
					r_PactiveObject = new(this, "activeObject", -1);
				}
				return r_PactiveObject;
			}
		}

		/// <summary>
		/// Void OnSelectionChanged()
		/// </summary>
		protected RMethod r_MOnSelectionChanged;
		public virtual RMethod RMOnSelectionChanged
		{
			get
			{
				if(r_MOnSelectionChanged == null)
				{
					r_MOnSelectionChanged = new(this, "OnSelectionChanged", 0);
				}
				return r_MOnSelectionChanged;
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


        public virtual void OnSelectionChanged()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnSelectionChanged.Invoke(___genericsType, ___parameters);

            
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
