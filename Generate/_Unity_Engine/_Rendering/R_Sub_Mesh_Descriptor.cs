
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RRendering
{
	/// <summary>
	/// UnityEngine.Rendering.SubMeshDescriptor
	/// </summary>
    public partial class RSubMeshDescriptor : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.Rendering.SubMeshDescriptor);
            }
        }

        public RSubMeshDescriptor() : base("UnityEngine.Rendering.SubMeshDescriptor")
        {
        }

        public RSubMeshDescriptor(System.Object instance) : base("UnityEngine.Rendering.SubMeshDescriptor")
		{
            SetInstance(instance);
		}

        public RSubMeshDescriptor(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSubMeshDescriptor(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// UnityEngine.Bounds <bounds>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RBounds r_F__0__bounds__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RBounds RF__0__bounds__1__k__BackingField
		{
			get
			{
				if(r_F__0__bounds__1__k__BackingField == null)
				{
					r_F__0__bounds__1__k__BackingField = new(this, "<bounds>k__BackingField");
				}
				return r_F__0__bounds__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.MeshTopology <topology>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RMeshTopology r_F__0__topology__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RMeshTopology RF__0__topology__1__k__BackingField
		{
			get
			{
				if(r_F__0__topology__1__k__BackingField == null)
				{
					r_F__0__topology__1__k__BackingField = new(this, "<topology>k__BackingField");
				}
				return r_F__0__topology__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int32 <indexStart>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F__0__indexStart__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF__0__indexStart__1__k__BackingField
		{
			get
			{
				if(r_F__0__indexStart__1__k__BackingField == null)
				{
					r_F__0__indexStart__1__k__BackingField = new(this, "<indexStart>k__BackingField");
				}
				return r_F__0__indexStart__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int32 <indexCount>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F__0__indexCount__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF__0__indexCount__1__k__BackingField
		{
			get
			{
				if(r_F__0__indexCount__1__k__BackingField == null)
				{
					r_F__0__indexCount__1__k__BackingField = new(this, "<indexCount>k__BackingField");
				}
				return r_F__0__indexCount__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int32 <baseVertex>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F__0__baseVertex__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF__0__baseVertex__1__k__BackingField
		{
			get
			{
				if(r_F__0__baseVertex__1__k__BackingField == null)
				{
					r_F__0__baseVertex__1__k__BackingField = new(this, "<baseVertex>k__BackingField");
				}
				return r_F__0__baseVertex__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int32 <firstVertex>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F__0__firstVertex__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF__0__firstVertex__1__k__BackingField
		{
			get
			{
				if(r_F__0__firstVertex__1__k__BackingField == null)
				{
					r_F__0__firstVertex__1__k__BackingField = new(this, "<firstVertex>k__BackingField");
				}
				return r_F__0__firstVertex__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int32 <vertexCount>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F__0__vertexCount__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF__0__vertexCount__1__k__BackingField
		{
			get
			{
				if(r_F__0__vertexCount__1__k__BackingField == null)
				{
					r_F__0__vertexCount__1__k__BackingField = new(this, "<vertexCount>k__BackingField");
				}
				return r_F__0__vertexCount__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.Bounds bounds
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RBounds r_Pbounds;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RBounds RPbounds
		{
			get
			{
				if(r_Pbounds == null)
				{
					r_Pbounds = new(this, "bounds", -1);
				}
				return r_Pbounds;
			}
		}

		/// <summary>
		/// UnityEngine.MeshTopology topology
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RMeshTopology r_Ptopology;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RMeshTopology RPtopology
		{
			get
			{
				if(r_Ptopology == null)
				{
					r_Ptopology = new(this, "topology", -1);
				}
				return r_Ptopology;
			}
		}

		/// <summary>
		/// Int32 indexStart
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PindexStart;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPindexStart
		{
			get
			{
				if(r_PindexStart == null)
				{
					r_PindexStart = new(this, "indexStart", -1);
				}
				return r_PindexStart;
			}
		}

		/// <summary>
		/// Int32 indexCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PindexCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPindexCount
		{
			get
			{
				if(r_PindexCount == null)
				{
					r_PindexCount = new(this, "indexCount", -1);
				}
				return r_PindexCount;
			}
		}

		/// <summary>
		/// Int32 baseVertex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PbaseVertex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPbaseVertex
		{
			get
			{
				if(r_PbaseVertex == null)
				{
					r_PbaseVertex = new(this, "baseVertex", -1);
				}
				return r_PbaseVertex;
			}
		}

		/// <summary>
		/// Int32 firstVertex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PfirstVertex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPfirstVertex
		{
			get
			{
				if(r_PfirstVertex == null)
				{
					r_PfirstVertex = new(this, "firstVertex", -1);
				}
				return r_PfirstVertex;
			}
		}

		/// <summary>
		/// Int32 vertexCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PvertexCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPvertexCount
		{
			get
			{
				if(r_PvertexCount == null)
				{
					r_PvertexCount = new(this, "vertexCount", -1);
				}
				return r_PvertexCount;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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
