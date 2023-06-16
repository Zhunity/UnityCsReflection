
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{public partial class RUIRenderDevice
{
	
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.UIElements.UIR.UIRenderDevice+AllocToUpdate
	/// </summary>
    public partial class RAllocToUpdate : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice+AllocToUpdate");
            }
        }

        public RAllocToUpdate() : base("UnityEngine.UIElements.UIR.UIRenderDevice+AllocToUpdate")
        {
        }

        public RAllocToUpdate(System.Object instance) : base("UnityEngine.UIElements.UIR.UIRenderDevice+AllocToUpdate")
		{
            SetInstance(instance);
		}

        public RAllocToUpdate(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAllocToUpdate(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.UInt32 id
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_Fid;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFid
		{
			get
			{
				if(r_Fid == null)
				{
					r_Fid = new(this, "id");
				}
				return r_Fid;
			}
		}

		/// <summary>
		/// System.UInt32 allocTime
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_FallocTime;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFallocTime
		{
			get
			{
				if(r_FallocTime == null)
				{
					r_FallocTime = new(this, "allocTime");
				}
				return r_FallocTime;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.MeshHandle meshHandle
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RMeshHandle r_FmeshHandle;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RMeshHandle RFmeshHandle
		{
			get
			{
				if(r_FmeshHandle == null)
				{
					r_FmeshHandle = new(this, "meshHandle");
				}
				return r_FmeshHandle;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.Alloc permAllocVerts
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RAlloc r_FpermAllocVerts;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RAlloc RFpermAllocVerts
		{
			get
			{
				if(r_FpermAllocVerts == null)
				{
					r_FpermAllocVerts = new(this, "permAllocVerts");
				}
				return r_FpermAllocVerts;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.Alloc permAllocIndices
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RAlloc r_FpermAllocIndices;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RAlloc RFpermAllocIndices
		{
			get
			{
				if(r_FpermAllocIndices == null)
				{
					r_FpermAllocIndices = new(this, "permAllocIndices");
				}
				return r_FpermAllocIndices;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.Page permPage
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RPage r_FpermPage;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RPage RFpermPage
		{
			get
			{
				if(r_FpermPage == null)
				{
					r_FpermPage = new(this, "permPage");
				}
				return r_FpermPage;
			}
		}

		/// <summary>
		/// System.Boolean copyBackIndices
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FcopyBackIndices;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFcopyBackIndices
		{
			get
			{
				if(r_FcopyBackIndices == null)
				{
					r_FcopyBackIndices = new(this, "copyBackIndices");
				}
				return r_FcopyBackIndices;
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
}