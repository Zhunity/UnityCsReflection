
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RRendering
{
	/// <summary>
	/// UnityEngine.Rendering.VertexAttributeDescriptor
	/// </summary>
    public partial class RVertexAttributeDescriptor : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.Rendering.VertexAttributeDescriptor);
            }
        }

        public RVertexAttributeDescriptor() : base("UnityEngine.Rendering.VertexAttributeDescriptor")
        {
        }

        public RVertexAttributeDescriptor(System.Object instance) : base("UnityEngine.Rendering.VertexAttributeDescriptor")
		{
            SetInstance(instance);
		}

        public RVertexAttributeDescriptor(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RVertexAttributeDescriptor(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// UnityEngine.Rendering.VertexAttribute <attribute>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRendering.RVertexAttribute r_F__0__attribute__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRendering.RVertexAttribute RF__0__attribute__1__k__BackingField
		{
			get
			{
				if(r_F__0__attribute__1__k__BackingField == null)
				{
					r_F__0__attribute__1__k__BackingField = new(this, "<attribute>k__BackingField");
				}
				return r_F__0__attribute__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.VertexAttributeFormat <format>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRendering.RVertexAttributeFormat r_F__0__format__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRendering.RVertexAttributeFormat RF__0__format__1__k__BackingField
		{
			get
			{
				if(r_F__0__format__1__k__BackingField == null)
				{
					r_F__0__format__1__k__BackingField = new(this, "<format>k__BackingField");
				}
				return r_F__0__format__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int32 <dimension>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F__0__dimension__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF__0__dimension__1__k__BackingField
		{
			get
			{
				if(r_F__0__dimension__1__k__BackingField == null)
				{
					r_F__0__dimension__1__k__BackingField = new(this, "<dimension>k__BackingField");
				}
				return r_F__0__dimension__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int32 <stream>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F__0__stream__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF__0__stream__1__k__BackingField
		{
			get
			{
				if(r_F__0__stream__1__k__BackingField == null)
				{
					r_F__0__stream__1__k__BackingField = new(this, "<stream>k__BackingField");
				}
				return r_F__0__stream__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.VertexAttribute attribute
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRendering.RVertexAttribute r_Pattribute;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRendering.RVertexAttribute RPattribute
		{
			get
			{
				if(r_Pattribute == null)
				{
					r_Pattribute = new(this, "attribute", -1);
				}
				return r_Pattribute;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.VertexAttributeFormat format
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRendering.RVertexAttributeFormat r_Pformat;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRendering.RVertexAttributeFormat RPformat
		{
			get
			{
				if(r_Pformat == null)
				{
					r_Pformat = new(this, "format", -1);
				}
				return r_Pformat;
			}
		}

		/// <summary>
		/// Int32 dimension
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Pdimension;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPdimension
		{
			get
			{
				if(r_Pdimension == null)
				{
					r_Pdimension = new(this, "dimension", -1);
				}
				return r_Pdimension;
			}
		}

		/// <summary>
		/// Int32 stream
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Pstream;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPstream
		{
			get
			{
				if(r_Pstream == null)
				{
					r_Pstream = new(this, "stream", -1);
				}
				return r_Pstream;
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
		/// Boolean Equals(UnityEngine.Rendering.VertexAttributeDescriptor)
		/// </summary>
		protected RMethod r_MEquals_VertexAttributeDescriptor;
		public virtual RMethod RMEquals_VertexAttributeDescriptor
		{
			get
			{
				if(r_MEquals_VertexAttributeDescriptor == null)
				{
					r_MEquals_VertexAttributeDescriptor = new(this, "Equals", 0, typeof(UnityEngine.Rendering.VertexAttributeDescriptor));
				}
				return r_MEquals_VertexAttributeDescriptor;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.Rendering.VertexAttributeDescriptor, UnityEngine.Rendering.VertexAttributeDescriptor)
		/// </summary>
		protected static RMethod r_Mop_Equality_VertexAttributeDescriptor_VertexAttributeDescriptor;
		public static RMethod RMop_Equality_VertexAttributeDescriptor_VertexAttributeDescriptor
		{
			get
			{
				if(r_Mop_Equality_VertexAttributeDescriptor_VertexAttributeDescriptor == null)
				{
					r_Mop_Equality_VertexAttributeDescriptor_VertexAttributeDescriptor = new(typeof(UnityEngine.Rendering.VertexAttributeDescriptor), "op_Equality", 0, typeof(UnityEngine.Rendering.VertexAttributeDescriptor), typeof(UnityEngine.Rendering.VertexAttributeDescriptor));
				}
				return r_Mop_Equality_VertexAttributeDescriptor_VertexAttributeDescriptor;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.Rendering.VertexAttributeDescriptor, UnityEngine.Rendering.VertexAttributeDescriptor)
		/// </summary>
		protected static RMethod r_Mop_Inequality_VertexAttributeDescriptor_VertexAttributeDescriptor;
		public static RMethod RMop_Inequality_VertexAttributeDescriptor_VertexAttributeDescriptor
		{
			get
			{
				if(r_Mop_Inequality_VertexAttributeDescriptor_VertexAttributeDescriptor == null)
				{
					r_Mop_Inequality_VertexAttributeDescriptor_VertexAttributeDescriptor = new(typeof(UnityEngine.Rendering.VertexAttributeDescriptor), "op_Inequality", 0, typeof(UnityEngine.Rendering.VertexAttributeDescriptor), typeof(UnityEngine.Rendering.VertexAttributeDescriptor));
				}
				return r_Mop_Inequality_VertexAttributeDescriptor_VertexAttributeDescriptor;
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


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.Rendering.VertexAttributeDescriptor @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_VertexAttributeDescriptor.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.Rendering.VertexAttributeDescriptor @lhs, UnityEngine.Rendering.VertexAttributeDescriptor @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Equality_VertexAttributeDescriptor_VertexAttributeDescriptor.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.Rendering.VertexAttributeDescriptor @lhs, UnityEngine.Rendering.VertexAttributeDescriptor @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Inequality_VertexAttributeDescriptor_VertexAttributeDescriptor.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
