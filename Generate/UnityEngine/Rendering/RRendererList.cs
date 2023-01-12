using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RRendering
{
	/// <summary>
	/// UnityEngine.Rendering.RendererList
	/// </summary>
    public partial class RRendererList : RMember //
    {

		/// <summary>
		/// System.UIntPtr context
		/// </summary>
		protected RSystem.RUIntPtr r_Fcontext;
		public virtual RSystem.RUIntPtr RFcontext
		{
			get
			{
				if(r_Fcontext == null)
				{
					r_Fcontext = new(this, "context");
					r_Fcontext.SetBelong(this.instance);
				}
				return r_Fcontext;
			}
		}

		/// <summary>
		/// System.UInt32 index
		/// </summary>
		protected RSystem.RUInt32 r_Findex;
		public virtual RSystem.RUInt32 RFindex
		{
			get
			{
				if(r_Findex == null)
				{
					r_Findex = new(this, "index");
					r_Findex.SetBelong(this.instance);
				}
				return r_Findex;
			}
		}

		/// <summary>
		/// System.UInt32 frame
		/// </summary>
		protected RSystem.RUInt32 r_Fframe;
		public virtual RSystem.RUInt32 RFframe
		{
			get
			{
				if(r_Fframe == null)
				{
					r_Fframe = new(this, "frame");
					r_Fframe.SetBelong(this.instance);
				}
				return r_Fframe;
			}
		}

		/// <summary>
		/// System.UInt32 type
		/// </summary>
		protected RSystem.RUInt32 r_Ftype;
		public virtual RSystem.RUInt32 RFtype
		{
			get
			{
				if(r_Ftype == null)
				{
					r_Ftype = new(this, "type");
					r_Ftype.SetBelong(this.instance);
				}
				return r_Ftype;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.RendererList nullRendererList
		/// </summary>
		protected static RUnityEngine.RRendering.RRendererList r_FnullRendererList;
		public static RUnityEngine.RRendering.RRendererList RFnullRendererList
		{
			get
			{
				if(r_FnullRendererList == null)
				{
					r_FnullRendererList = new(typeof(UnityEngine.Rendering.RendererList), "nullRendererList");
					r_FnullRendererList.SetBelong(null);
				}
				return r_FnullRendererList;
			}
		}

		/// <summary>
		/// Boolean isValid
		/// </summary>
		protected RSystem.RBoolean r_PisValid;
		public virtual RSystem.RBoolean RPisValid
		{
			get
			{
				if(r_PisValid == null)
				{
					r_PisValid = new(this, "isValid", -1);
					r_PisValid.SetBelong(this.instance);
				}
				return r_PisValid;
			}
		}

		/// <summary>
		/// Boolean get_isValid_Injected(UnityEngine.Rendering.RendererList ByRef)
		/// </summary>
		protected static RMethod r_Mget_isValid_Injected_Ref_RendererList;
		public static RMethod RMget_isValid_Injected_Ref_RendererList
		{
			get
			{
				if(r_Mget_isValid_Injected_Ref_RendererList == null)
				{
					r_Mget_isValid_Injected_Ref_RendererList = new(typeof(UnityEngine.Rendering.RendererList), "get_isValid_Injected", 0, typeof(UnityEngine.Rendering.RendererList).MakeByRefType());
					r_Mget_isValid_Injected_Ref_RendererList.SetBelong(null);
				}
				return r_Mget_isValid_Injected_Ref_RendererList;
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


        public RRendererList() : base("UnityEngine.Rendering.RendererList")
        {
        }

        public RRendererList(System.Object instance) : base("UnityEngine.Rendering.RendererList")
		{
            SetInstance(instance);
		}

        public RRendererList(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRendererList(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Boolean get_isValid_Injected(ref UnityEngine.Rendering.RendererList @_unity_self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_unity_self};
            var ___result = RMget_isValid_Injected_Ref_RendererList.Invoke(___genericsType, ___parameters);
			@_unity_self = (UnityEngine.Rendering.RendererList)___parameters[0];

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
