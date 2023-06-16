
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RRendering
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.Rendering.RendererList
	/// </summary>
    public partial class RRendererList : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.Rendering.RendererList);
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


		/// <summary>
		/// System.UIntPtr context
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUIntPtr r_Fcontext;
		public virtual Hvak.Editor.Refleaction.RSystem.RUIntPtr RFcontext
		{
			get
			{
				if(r_Fcontext == null)
				{
					r_Fcontext = new(this, "context");
				}
				return r_Fcontext;
			}
		}

		/// <summary>
		/// System.UInt32 index
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_Findex;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFindex
		{
			get
			{
				if(r_Findex == null)
				{
					r_Findex = new(this, "index");
				}
				return r_Findex;
			}
		}

		/// <summary>
		/// System.UInt32 frame
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_Fframe;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFframe
		{
			get
			{
				if(r_Fframe == null)
				{
					r_Fframe = new(this, "frame");
				}
				return r_Fframe;
			}
		}

		/// <summary>
		/// System.UInt32 type
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_Ftype;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFtype
		{
			get
			{
				if(r_Ftype == null)
				{
					r_Ftype = new(this, "type");
				}
				return r_Ftype;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.RendererList nullRendererList
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RRendererList r_FnullRendererList;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRendering.RRendererList RFnullRendererList
		{
			get
			{
				if(r_FnullRendererList == null)
				{
					r_FnullRendererList = new(Type, "nullRendererList");
				}
				return r_FnullRendererList;
			}
		}

		/// <summary>
		/// Boolean isValid
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisValid;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisValid
		{
			get
			{
				if(r_PisValid == null)
				{
					r_PisValid = new(this, "isValid", -1);
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
					r_Mget_isValid_Injected_Ref_RendererList = new(Type, "get_isValid_Injected", 0, typeof(UnityEngine.Rendering.RendererList).MakeByRefType());
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


        public static System.Boolean get_isValid_Injected(ref UnityEngine.Rendering.RendererList @_unity_self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_unity_self};
            var ___result = RMget_isValid_Injected_Ref_RendererList.Invoke(___genericsType, ___parameters);
			@_unity_self = ReflectionUtils.Convert<UnityEngine.Rendering.RendererList>(___parameters[0]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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
