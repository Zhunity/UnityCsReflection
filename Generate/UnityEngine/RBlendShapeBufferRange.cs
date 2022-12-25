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
		protected RField r_m_StartIndex;
		public virtual RField Rm_StartIndex
		{
			get
			{
				if(r_m_StartIndex == null)
				{
					r_m_StartIndex = new(this, "m_StartIndex");
					r_m_StartIndex.SetBelong(this.instance);
				}
				return r_m_StartIndex;
			}
		}

		/// <summary>
		/// System.UInt32 m_EndIndex
		/// </summary>
		protected RField r_m_EndIndex;
		public virtual RField Rm_EndIndex
		{
			get
			{
				if(r_m_EndIndex == null)
				{
					r_m_EndIndex = new(this, "m_EndIndex");
					r_m_EndIndex.SetBelong(this.instance);
				}
				return r_m_EndIndex;
			}
		}

		/// <summary>
		/// UInt32 startIndex
		/// </summary>
		protected RProperty r_startIndex;
		public virtual RProperty RstartIndex
		{
			get
			{
				if(r_startIndex == null)
				{
					r_startIndex = new(this, "startIndex", -1);
					r_startIndex.SetBelong(this.instance);
				}
				return r_startIndex;
			}
		}

		/// <summary>
		/// UInt32 endIndex
		/// </summary>
		protected RProperty r_endIndex;
		public virtual RProperty RendIndex
		{
			get
			{
				if(r_endIndex == null)
				{
					r_endIndex = new(this, "endIndex", -1);
					r_endIndex.SetBelong(this.instance);
				}
				return r_endIndex;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_REquals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_REquals_Object == null)
				{
					r_REquals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_REquals_Object.SetBelong(this.instance);
				}
				return r_REquals_Object;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_RGetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_RGetHashCode == null)
				{
					r_RGetHashCode = new(this, "GetHashCode", 0);
					r_RGetHashCode.SetBelong(this.instance);
				}
				return r_RGetHashCode;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_RToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_RToString == null)
				{
					r_RToString = new(this, "ToString", 0);
					r_RToString.SetBelong(this.instance);
				}
				return r_RToString;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_RFinalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_RFinalize == null)
				{
					r_RFinalize = new(this, "Finalize", 0);
					r_RFinalize.SetBelong(this.instance);
				}
				return r_RFinalize;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_RGetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_RGetType == null)
				{
					r_RGetType = new(this, "GetType", 0);
					r_RGetType.SetBelong(this.instance);
				}
				return r_RGetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_RMemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_RMemberwiseClone == null)
				{
					r_RMemberwiseClone = new(this, "MemberwiseClone", 0);
					r_RMemberwiseClone.SetBelong(this.instance);
				}
				return r_RMemberwiseClone;
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

        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMemberwiseClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


    }
}
