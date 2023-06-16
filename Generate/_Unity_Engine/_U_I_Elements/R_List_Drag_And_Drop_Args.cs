
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// UnityEngine.UIElements.ListDragAndDropArgs
	/// </summary>
    public partial class RListDragAndDropArgs : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.ListDragAndDropArgs");
            }
        }

        public RListDragAndDropArgs() : base("UnityEngine.UIElements.ListDragAndDropArgs")
        {
        }

        public RListDragAndDropArgs(System.Object instance) : base("UnityEngine.UIElements.ListDragAndDropArgs")
		{
            SetInstance(instance);
		}

        public RListDragAndDropArgs(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RListDragAndDropArgs(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Object <target>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_F__0__target__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RF__0__target__1__k__BackingField
		{
			get
			{
				if(r_F__0__target__1__k__BackingField == null)
				{
					r_F__0__target__1__k__BackingField = new(this, "<target>k__BackingField");
				}
				return r_F__0__target__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int32 <insertAtIndex>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F__0__insertAtIndex__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF__0__insertAtIndex__1__k__BackingField
		{
			get
			{
				if(r_F__0__insertAtIndex__1__k__BackingField == null)
				{
					r_F__0__insertAtIndex__1__k__BackingField = new(this, "<insertAtIndex>k__BackingField");
				}
				return r_F__0__insertAtIndex__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.DragAndDropPosition <dragAndDropPosition>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDragAndDropPosition r_F__0__dragAndDropPosition__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDragAndDropPosition RF__0__dragAndDropPosition__1__k__BackingField
		{
			get
			{
				if(r_F__0__dragAndDropPosition__1__k__BackingField == null)
				{
					r_F__0__dragAndDropPosition__1__k__BackingField = new(this, "<dragAndDropPosition>k__BackingField");
				}
				return r_F__0__dragAndDropPosition__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IDragAndDropData <dragAndDropData>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIDragAndDropData r_F__0__dragAndDropData__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIDragAndDropData RF__0__dragAndDropData__1__k__BackingField
		{
			get
			{
				if(r_F__0__dragAndDropData__1__k__BackingField == null)
				{
					r_F__0__dragAndDropData__1__k__BackingField = new(this, "<dragAndDropData>k__BackingField");
				}
				return r_F__0__dragAndDropData__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Object target
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_Ptarget;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RPtarget
		{
			get
			{
				if(r_Ptarget == null)
				{
					r_Ptarget = new(this, "target", -1);
				}
				return r_Ptarget;
			}
		}

		/// <summary>
		/// Int32 insertAtIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PinsertAtIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPinsertAtIndex
		{
			get
			{
				if(r_PinsertAtIndex == null)
				{
					r_PinsertAtIndex = new(this, "insertAtIndex", -1);
				}
				return r_PinsertAtIndex;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.DragAndDropPosition dragAndDropPosition
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDragAndDropPosition r_PdragAndDropPosition;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDragAndDropPosition RPdragAndDropPosition
		{
			get
			{
				if(r_PdragAndDropPosition == null)
				{
					r_PdragAndDropPosition = new(this, "dragAndDropPosition", -1);
				}
				return r_PdragAndDropPosition;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IDragAndDropData dragAndDropData
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIDragAndDropData r_PdragAndDropData;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIDragAndDropData RPdragAndDropData
		{
			get
			{
				if(r_PdragAndDropData == null)
				{
					r_PdragAndDropData = new(this, "dragAndDropData", -1);
				}
				return r_PdragAndDropData;
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


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
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

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


    }
}
