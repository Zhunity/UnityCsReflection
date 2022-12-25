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
		protected RField r_context;
		public virtual RField Rcontext
		{
			get
			{
				if(r_context == null)
				{
					r_context = new(this, "context");
					r_context.SetBelong(this.instance);
				}
				return r_context;
			}
		}

		/// <summary>
		/// System.UInt32 index
		/// </summary>
		protected RField r_index;
		public virtual RField Rindex
		{
			get
			{
				if(r_index == null)
				{
					r_index = new(this, "index");
					r_index.SetBelong(this.instance);
				}
				return r_index;
			}
		}

		/// <summary>
		/// System.UInt32 frame
		/// </summary>
		protected RField r_frame;
		public virtual RField Rframe
		{
			get
			{
				if(r_frame == null)
				{
					r_frame = new(this, "frame");
					r_frame.SetBelong(this.instance);
				}
				return r_frame;
			}
		}

		/// <summary>
		/// System.UInt32 type
		/// </summary>
		protected RField r_type;
		public virtual RField Rtype
		{
			get
			{
				if(r_type == null)
				{
					r_type = new(this, "type");
					r_type.SetBelong(this.instance);
				}
				return r_type;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.RendererList nullRendererList
		/// </summary>
		protected static RUnityEngine.RRendering.RRendererList r_nullRendererList;
		public static RUnityEngine.RRendering.RRendererList RnullRendererList
		{
			get
			{
				if(r_nullRendererList == null)
				{
					r_nullRendererList = new(typeof(UnityEngine.Rendering.RendererList), "nullRendererList");
					r_nullRendererList.SetBelong(null);
				}
				return r_nullRendererList;
			}
		}

		/// <summary>
		/// Boolean isValid
		/// </summary>
		protected RProperty r_isValid;
		public virtual RProperty RisValid
		{
			get
			{
				if(r_isValid == null)
				{
					r_isValid = new(this, "isValid", -1);
					r_isValid.SetBelong(this.instance);
				}
				return r_isValid;
			}
		}

		/// <summary>
		/// Boolean get_isValid_Injected(UnityEngine.Rendering.RendererList ByRef)
		/// </summary>
		protected static RMethod r_Rget_isValid_Injected_Ref_RendererList;
		public static RMethod Rget_isValid_Injected_Ref_RendererList
		{
			get
			{
				if(r_Rget_isValid_Injected_Ref_RendererList == null)
				{
					r_Rget_isValid_Injected_Ref_RendererList = new(typeof(UnityEngine.Rendering.RendererList), "get_isValid_Injected", 0, typeof(UnityEngine.Rendering.RendererList).MakeByRefType());
					r_Rget_isValid_Injected_Ref_RendererList.SetBelong(null);
				}
				return r_Rget_isValid_Injected_Ref_RendererList;
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

        public static System.Boolean get_isValid_Injected(ref UnityEngine.Rendering.RendererList  @_unity_self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_unity_self};
            var ___result = Rget_isValid_Injected_Ref_RendererList.Invoke(___genericsType, ___parameters);
			_unity_self = (UnityEngine.Rendering.RendererList)___parameters[0];

            return (System.Boolean)___result;
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
