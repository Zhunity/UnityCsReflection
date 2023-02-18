
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering
{
	/// <summary>
	/// UnityEngine.Experimental.Rendering.RayTracingInstanceMaterialConfig
	/// </summary>
    public partial class RRayTracingInstanceMaterialConfig : RMember //
    {

		/// <summary>
		/// System.Int32 renderQueueLowerBound
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FrenderQueueLowerBound;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFrenderQueueLowerBound
		{
			get
			{
				if(r_FrenderQueueLowerBound == null)
				{
					r_FrenderQueueLowerBound = new(this, "renderQueueLowerBound");
				}
				return r_FrenderQueueLowerBound;
			}
		}

		/// <summary>
		/// System.Int32 renderQueueUpperBound
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FrenderQueueUpperBound;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFrenderQueueUpperBound
		{
			get
			{
				if(r_FrenderQueueUpperBound == null)
				{
					r_FrenderQueueUpperBound = new(this, "renderQueueUpperBound");
				}
				return r_FrenderQueueUpperBound;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.RayTracingInstanceCullingShaderTagConfig[] optionalShaderTags
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RRayTracingInstanceCullingShaderTagConfig> r_FoptionalShaderTags;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RRayTracingInstanceCullingShaderTagConfig> RFoptionalShaderTags
		{
			get
			{
				if(r_FoptionalShaderTags == null)
				{
					r_FoptionalShaderTags = new(this, "optionalShaderTags");
				}
				return r_FoptionalShaderTags;
			}
		}

		/// <summary>
		/// System.String[] optionalShaderKeywords
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_FoptionalShaderKeywords;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFoptionalShaderKeywords
		{
			get
			{
				if(r_FoptionalShaderKeywords == null)
				{
					r_FoptionalShaderKeywords = new(this, "optionalShaderKeywords");
				}
				return r_FoptionalShaderKeywords;
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


        public RRayTracingInstanceMaterialConfig() : base("UnityEngine.Experimental.Rendering.RayTracingInstanceMaterialConfig")
        {
        }

        public RRayTracingInstanceMaterialConfig(System.Object instance) : base("UnityEngine.Experimental.Rendering.RayTracingInstanceMaterialConfig")
		{
            SetInstance(instance);
		}

        public RRayTracingInstanceMaterialConfig(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRayTracingInstanceMaterialConfig(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
