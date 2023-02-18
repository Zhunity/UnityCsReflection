
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{
	/// <summary>
	/// UnityEngine.UIElements.UIR.DrawBufferRange
	/// </summary>
    public partial class RDrawBufferRange : RMember //
    {

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
					r_FfirstIndex.SetBelong(this.GetValue());
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
					r_FindexCount.SetBelong(this.GetValue());
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
					r_FminIndexVal.SetBelong(this.GetValue());
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
					r_FvertsReferenced.SetBelong(this.GetValue());
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
					r_MEquals_Object.SetBelong(this.GetValue());
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
					r_MGetHashCode.SetBelong(this.GetValue());
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
					r_MToString.SetBelong(this.GetValue());
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
					r_MFinalize.SetBelong(this.GetValue());
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
					r_MGetType.SetBelong(this.GetValue());
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
					r_MMemberwiseClone.SetBelong(this.GetValue());
				}
				return r_MMemberwiseClone;
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
