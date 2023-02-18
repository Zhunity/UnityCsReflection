
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{public partial class RListViewDragger
{
	
	/// <summary>
	/// UnityEngine.UIElements.ListViewDragger+DragPosition
	/// </summary>
    public partial class RDragPosition : RMember //
    {

		/// <summary>
		/// System.Int32 insertAtIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FinsertAtIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFinsertAtIndex
		{
			get
			{
				if(r_FinsertAtIndex == null)
				{
					r_FinsertAtIndex = new(this, "insertAtIndex");
				}
				return r_FinsertAtIndex;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ReusableCollectionItem recycledItem
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RReusableCollectionItem r_FrecycledItem;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RReusableCollectionItem RFrecycledItem
		{
			get
			{
				if(r_FrecycledItem == null)
				{
					r_FrecycledItem = new(this, "recycledItem");
				}
				return r_FrecycledItem;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.DragAndDropPosition dragAndDropPosition
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDragAndDropPosition r_FdragAndDropPosition;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDragAndDropPosition RFdragAndDropPosition
		{
			get
			{
				if(r_FdragAndDropPosition == null)
				{
					r_FdragAndDropPosition = new(this, "dragAndDropPosition");
				}
				return r_FdragAndDropPosition;
			}
		}

		/// <summary>
		/// Boolean Equals(DragPosition)
		/// </summary>
		protected RMethod r_MEquals_DragPosition;
		public virtual RMethod RMEquals_DragPosition
		{
			get
			{
				if(r_MEquals_DragPosition == null)
				{
					r_MEquals_DragPosition = new(this, "Equals", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.ListViewDragger+DragPosition"));
				}
				return r_MEquals_DragPosition;
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


        public RDragPosition() : base("UnityEngine.UIElements.ListViewDragger+DragPosition")
        {
        }

        public RDragPosition(System.Object instance) : base("UnityEngine.UIElements.ListViewDragger+DragPosition")
		{
            SetInstance(instance);
		}

        public RDragPosition(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RDragPosition(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Equals(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RListViewDragger.RDragPosition @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other.Value};
            var ___result = RMEquals_DragPosition.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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


    }
}
}