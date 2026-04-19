
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.UIElements.HandleDragAndDropArgs
	/// </summary>
    public partial class RHandleDragAndDropArgs : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.HandleDragAndDropArgs");
            }
        }

        public RHandleDragAndDropArgs() : base("UnityEngine.UIElements.HandleDragAndDropArgs")
        {
        }

        public RHandleDragAndDropArgs(System.Object instance) : base("UnityEngine.UIElements.HandleDragAndDropArgs")
		{
            SetInstance(instance);
		}

        public RHandleDragAndDropArgs(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RHandleDragAndDropArgs(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// UnityEngine.UIElements.DragAndDropArgs m_DragAndDropArgs
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDragAndDropArgs r_Fm_DragAndDropArgs;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDragAndDropArgs RFm_DragAndDropArgs
		{
			get
			{
				if(r_Fm_DragAndDropArgs == null)
				{
					r_Fm_DragAndDropArgs = new(this, "m_DragAndDropArgs");
				}
				return r_Fm_DragAndDropArgs;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 <position>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_F__0__position__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RF__0__position__1__k__BackingField
		{
			get
			{
				if(r_F__0__position__1__k__BackingField == null)
				{
					r_F__0__position__1__k__BackingField = new(this, "<position>k__BackingField");
				}
				return r_F__0__position__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 position
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_Pposition;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RPposition
		{
			get
			{
				if(r_Pposition == null)
				{
					r_Pposition = new(this, "position", -1);
				}
				return r_Pposition;
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
		/// Int32 parentId
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PparentId;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPparentId
		{
			get
			{
				if(r_PparentId == null)
				{
					r_PparentId = new(this, "parentId", -1);
				}
				return r_PparentId;
			}
		}

		/// <summary>
		/// Int32 childIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PchildIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPchildIndex
		{
			get
			{
				if(r_PchildIndex == null)
				{
					r_PchildIndex = new(this, "childIndex", -1);
				}
				return r_PchildIndex;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.DragAndDropPosition dropPosition
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDragAndDropPosition r_PdropPosition;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDragAndDropPosition RPdropPosition
		{
			get
			{
				if(r_PdropPosition == null)
				{
					r_PdropPosition = new(this, "dropPosition", -1);
				}
				return r_PdropPosition;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.DragAndDropData dragAndDropData
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDragAndDropData r_PdragAndDropData;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDragAndDropData RPdragAndDropData
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
