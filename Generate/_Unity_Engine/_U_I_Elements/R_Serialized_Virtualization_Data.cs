
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.UIElements.SerializedVirtualizationData
	/// </summary>
    public partial class RSerializedVirtualizationData : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.SerializedVirtualizationData");
            }
        }

        public RSerializedVirtualizationData() : base("UnityEngine.UIElements.SerializedVirtualizationData")
        {
        }

        public RSerializedVirtualizationData(System.Object instance) : base("UnityEngine.UIElements.SerializedVirtualizationData")
		{
            SetInstance(instance);
		}

        public RSerializedVirtualizationData(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSerializedVirtualizationData(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// UnityEngine.Vector2 scrollOffset
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_FscrollOffset;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RFscrollOffset
		{
			get
			{
				if(r_FscrollOffset == null)
				{
					r_FscrollOffset = new(this, "scrollOffset");
				}
				return r_FscrollOffset;
			}
		}

		/// <summary>
		/// System.Int32 firstVisibleIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FfirstVisibleIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFfirstVisibleIndex
		{
			get
			{
				if(r_FfirstVisibleIndex == null)
				{
					r_FfirstVisibleIndex = new(this, "firstVisibleIndex");
				}
				return r_FfirstVisibleIndex;
			}
		}

		/// <summary>
		/// System.Single contentPadding
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_FcontentPadding;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFcontentPadding
		{
			get
			{
				if(r_FcontentPadding == null)
				{
					r_FcontentPadding = new(this, "contentPadding");
				}
				return r_FcontentPadding;
			}
		}

		/// <summary>
		/// System.Single contentHeight
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_FcontentHeight;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFcontentHeight
		{
			get
			{
				if(r_FcontentHeight == null)
				{
					r_FcontentHeight = new(this, "contentHeight");
				}
				return r_FcontentHeight;
			}
		}

		/// <summary>
		/// System.Int32 anchoredItemIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FanchoredItemIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFanchoredItemIndex
		{
			get
			{
				if(r_FanchoredItemIndex == null)
				{
					r_FanchoredItemIndex = new(this, "anchoredItemIndex");
				}
				return r_FanchoredItemIndex;
			}
		}

		/// <summary>
		/// System.Single anchorOffset
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_FanchorOffset;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFanchorOffset
		{
			get
			{
				if(r_FanchorOffset == null)
				{
					r_FanchorOffset = new(this, "anchorOffset");
				}
				return r_FanchorOffset;
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


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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

            return ReflectionUtils.Convert<System.Int32>(___result);
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


    }
}
