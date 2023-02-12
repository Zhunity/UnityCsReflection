
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.BlendShapeBufferRange
	/// </summary>
    public partial class RBlendShapeBufferRange : RMember //
    {

		/// <summary>
		/// System.UInt32 m_StartIndex
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RUInt32 r_Fm_StartIndex;
		public virtual SMFrame.Editor.Refleaction.RSystem.RUInt32 RFm_StartIndex
		{
			get
			{
				if(r_Fm_StartIndex == null)
				{
					r_Fm_StartIndex = new(this, "m_StartIndex");
					r_Fm_StartIndex.SetBelong(this.instance);
				}
				return r_Fm_StartIndex;
			}
		}

		/// <summary>
		/// System.UInt32 m_EndIndex
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RUInt32 r_Fm_EndIndex;
		public virtual SMFrame.Editor.Refleaction.RSystem.RUInt32 RFm_EndIndex
		{
			get
			{
				if(r_Fm_EndIndex == null)
				{
					r_Fm_EndIndex = new(this, "m_EndIndex");
					r_Fm_EndIndex.SetBelong(this.instance);
				}
				return r_Fm_EndIndex;
			}
		}

		/// <summary>
		/// UInt32 startIndex
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RUInt32 r_PstartIndex;
		public virtual SMFrame.Editor.Refleaction.RSystem.RUInt32 RPstartIndex
		{
			get
			{
				if(r_PstartIndex == null)
				{
					r_PstartIndex = new(this, "startIndex", -1);
					r_PstartIndex.SetBelong(this.instance);
				}
				return r_PstartIndex;
			}
		}

		/// <summary>
		/// UInt32 endIndex
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RUInt32 r_PendIndex;
		public virtual SMFrame.Editor.Refleaction.RSystem.RUInt32 RPendIndex
		{
			get
			{
				if(r_PendIndex == null)
				{
					r_PendIndex = new(this, "endIndex", -1);
					r_PendIndex.SetBelong(this.instance);
				}
				return r_PendIndex;
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
					r_MEquals_Object.SetBelong(this.instance);
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
					r_MGetHashCode.SetBelong(this.instance);
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
					r_MToString.SetBelong(this.instance);
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
					r_MFinalize.SetBelong(this.instance);
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
					r_MGetType.SetBelong(this.instance);
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
					r_MMemberwiseClone.SetBelong(this.instance);
				}
				return r_MMemberwiseClone;
			}
		}


        public RBlendShapeBufferRange() : base("UnityEngine.BlendShapeBufferRange")
        {
        }

        public RBlendShapeBufferRange(System.Object instance) : base("UnityEngine.BlendShapeBufferRange")
		{
            SetInstance(instance);
		}

        public RBlendShapeBufferRange(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RBlendShapeBufferRange(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
