
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.UIElements.UIR.DrawBufferRange
	/// </summary>
    public partial class RDrawBufferRange : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.DrawBufferRange");
            }
        }

        public RDrawBufferRange() : base("UnityEngine.UIElements.UIR.DrawBufferRange")
        {
        }

        public RDrawBufferRange(System.Object instance) : base("UnityEngine.UIElements.UIR.DrawBufferRange")
		{
            SetInstance(instance);
		}

        public RDrawBufferRange(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RDrawBufferRange(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Int32 firstIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FfirstIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFfirstIndex
		{
			get
			{
				if(r_FfirstIndex == null)
				{
					r_FfirstIndex = new(this, "firstIndex");
				}
				return r_FfirstIndex;
			}
		}

		/// <summary>
		/// System.Int32 indexCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FindexCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFindexCount
		{
			get
			{
				if(r_FindexCount == null)
				{
					r_FindexCount = new(this, "indexCount");
				}
				return r_FindexCount;
			}
		}

		/// <summary>
		/// System.Int32 minIndexVal
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FminIndexVal;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFminIndexVal
		{
			get
			{
				if(r_FminIndexVal == null)
				{
					r_FminIndexVal = new(this, "minIndexVal");
				}
				return r_FminIndexVal;
			}
		}

		/// <summary>
		/// System.Int32 vertsReferenced
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FvertsReferenced;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFvertsReferenced
		{
			get
			{
				if(r_FvertsReferenced == null)
				{
					r_FvertsReferenced = new(this, "vertsReferenced");
				}
				return r_FvertsReferenced;
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
