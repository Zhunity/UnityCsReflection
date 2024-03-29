
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnity.RProfiling
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// Unity.Profiling.ProfilerMarker
	/// </summary>
    public partial class RProfilerMarker : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(Unity.Profiling.ProfilerMarker);
            }
        }

        public RProfilerMarker() : base("Unity.Profiling.ProfilerMarker")
        {
        }

        public RProfilerMarker(System.Object instance) : base("Unity.Profiling.ProfilerMarker")
		{
            SetInstance(instance);
		}

        public RProfilerMarker(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RProfilerMarker(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.IntPtr m_Ptr
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIntPtr r_Fm_Ptr;
		public virtual Hvak.Editor.Refleaction.RSystem.RIntPtr RFm_Ptr
		{
			get
			{
				if(r_Fm_Ptr == null)
				{
					r_Fm_Ptr = new(this, "m_Ptr");
				}
				return r_Fm_Ptr;
			}
		}

		/// <summary>
		/// IntPtr Handle
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIntPtr r_PHandle;
		public virtual Hvak.Editor.Refleaction.RSystem.RIntPtr RPHandle
		{
			get
			{
				if(r_PHandle == null)
				{
					r_PHandle = new(this, "Handle", -1);
				}
				return r_PHandle;
			}
		}

		/// <summary>
		/// Void Begin()
		/// </summary>
		protected RMethod r_MBegin;
		public virtual RMethod RMBegin
		{
			get
			{
				if(r_MBegin == null)
				{
					r_MBegin = new(this, "Begin", 0);
				}
				return r_MBegin;
			}
		}

		/// <summary>
		/// Void Begin(UnityEngine.Object)
		/// </summary>
		protected RMethod r_MBegin_Object;
		public virtual RMethod RMBegin_Object
		{
			get
			{
				if(r_MBegin_Object == null)
				{
					r_MBegin_Object = new(this, "Begin", 0, typeof(UnityEngine.Object));
				}
				return r_MBegin_Object;
			}
		}

		/// <summary>
		/// Void End()
		/// </summary>
		protected RMethod r_MEnd;
		public virtual RMethod RMEnd
		{
			get
			{
				if(r_MEnd == null)
				{
					r_MEnd = new(this, "End", 0);
				}
				return r_MEnd;
			}
		}

		/// <summary>
		/// Void GetName(System.String ByRef)
		/// </summary>
		protected RMethod r_MGetName_Ref_String;
		public virtual RMethod RMGetName_Ref_String
		{
			get
			{
				if(r_MGetName_Ref_String == null)
				{
					r_MGetName_Ref_String = new(this, "GetName", 0, typeof(System.String).MakeByRefType());
				}
				return r_MGetName_Ref_String;
			}
		}

		/// <summary>
		/// AutoScope Auto()
		/// </summary>
		protected RMethod r_MAuto;
		public virtual RMethod RMAuto
		{
			get
			{
				if(r_MAuto == null)
				{
					r_MAuto = new(this, "Auto", 0);
				}
				return r_MAuto;
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


        public virtual void Begin()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMBegin.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Begin(UnityEngine.Object @contextUnityObject)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@contextUnityObject};
            var ___result = RMBegin_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void End()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMEnd.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetName(ref System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetName_Ref_String.Invoke(___genericsType, ___parameters);
			@name = ReflectionUtils.Convert<System.String>(___parameters[0]);

            
        }


        public virtual Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker.RAutoScope Auto()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAuto.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker.RAutoScope>(___result);
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
