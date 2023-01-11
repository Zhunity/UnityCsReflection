using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RRendering
{
	/// <summary>
	/// UnityEngine.Rendering.VertexAttributeDescriptor
	/// </summary>
    public partial class RVertexAttributeDescriptor : RMember //
    {

		/// <summary>
		/// UnityEngine.Rendering.VertexAttribute <attribute>k__BackingField
		/// </summary>
		protected RField r___0__attribute__1__k__BackingField;
		public virtual RField R__0__attribute__1__k__BackingField
		{
			get
			{
				if(r___0__attribute__1__k__BackingField == null)
				{
					r___0__attribute__1__k__BackingField = new(this, "<attribute>k__BackingField");
					r___0__attribute__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__attribute__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.VertexAttributeFormat <format>k__BackingField
		/// </summary>
		protected RField r___0__format__1__k__BackingField;
		public virtual RField R__0__format__1__k__BackingField
		{
			get
			{
				if(r___0__format__1__k__BackingField == null)
				{
					r___0__format__1__k__BackingField = new(this, "<format>k__BackingField");
					r___0__format__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__format__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int32 <dimension>k__BackingField
		/// </summary>
		protected RSystem.RInt32 r___0__dimension__1__k__BackingField;
		public virtual RSystem.RInt32 R__0__dimension__1__k__BackingField
		{
			get
			{
				if(r___0__dimension__1__k__BackingField == null)
				{
					r___0__dimension__1__k__BackingField = new(this, "<dimension>k__BackingField");
					r___0__dimension__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__dimension__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int32 <stream>k__BackingField
		/// </summary>
		protected RSystem.RInt32 r___0__stream__1__k__BackingField;
		public virtual RSystem.RInt32 R__0__stream__1__k__BackingField
		{
			get
			{
				if(r___0__stream__1__k__BackingField == null)
				{
					r___0__stream__1__k__BackingField = new(this, "<stream>k__BackingField");
					r___0__stream__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__stream__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.VertexAttribute attribute
		/// </summary>
		protected RProperty r_attribute;
		public virtual RProperty Rattribute
		{
			get
			{
				if(r_attribute == null)
				{
					r_attribute = new(this, "attribute", -1);
					r_attribute.SetBelong(this.instance);
				}
				return r_attribute;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.VertexAttributeFormat format
		/// </summary>
		protected RProperty r_format;
		public virtual RProperty Rformat
		{
			get
			{
				if(r_format == null)
				{
					r_format = new(this, "format", -1);
					r_format.SetBelong(this.instance);
				}
				return r_format;
			}
		}

		/// <summary>
		/// Int32 dimension
		/// </summary>
		protected RSystem.RInt32 r_dimension;
		public virtual RSystem.RInt32 Rdimension
		{
			get
			{
				if(r_dimension == null)
				{
					r_dimension = new(this, "dimension", -1);
					r_dimension.SetBelong(this.instance);
				}
				return r_dimension;
			}
		}

		/// <summary>
		/// Int32 stream
		/// </summary>
		protected RSystem.RInt32 r_stream;
		public virtual RSystem.RInt32 Rstream
		{
			get
			{
				if(r_stream == null)
				{
					r_stream = new(this, "stream", -1);
					r_stream.SetBelong(this.instance);
				}
				return r_stream;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_ToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_ToString == null)
				{
					r_ToString = new(this, "ToString", 0);
					r_ToString.SetBelong(this.instance);
				}
				return r_ToString;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_GetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_GetHashCode == null)
				{
					r_GetHashCode = new(this, "GetHashCode", 0);
					r_GetHashCode.SetBelong(this.instance);
				}
				return r_GetHashCode;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_Equals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_Equals_Object == null)
				{
					r_Equals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_Equals_Object.SetBelong(this.instance);
				}
				return r_Equals_Object;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.Rendering.VertexAttributeDescriptor)
		/// </summary>
		protected RMethod r_Equals_VertexAttributeDescriptor;
		public virtual RMethod REquals_VertexAttributeDescriptor
		{
			get
			{
				if(r_Equals_VertexAttributeDescriptor == null)
				{
					r_Equals_VertexAttributeDescriptor = new(this, "Equals", 0, typeof(UnityEngine.Rendering.VertexAttributeDescriptor));
					r_Equals_VertexAttributeDescriptor.SetBelong(this.instance);
				}
				return r_Equals_VertexAttributeDescriptor;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.Rendering.VertexAttributeDescriptor, UnityEngine.Rendering.VertexAttributeDescriptor)
		/// </summary>
		protected static RMethod r_op_Equality_VertexAttributeDescriptor_VertexAttributeDescriptor;
		public static RMethod Rop_Equality_VertexAttributeDescriptor_VertexAttributeDescriptor
		{
			get
			{
				if(r_op_Equality_VertexAttributeDescriptor_VertexAttributeDescriptor == null)
				{
					r_op_Equality_VertexAttributeDescriptor_VertexAttributeDescriptor = new(typeof(UnityEngine.Rendering.VertexAttributeDescriptor), "op_Equality", 0, typeof(UnityEngine.Rendering.VertexAttributeDescriptor), typeof(UnityEngine.Rendering.VertexAttributeDescriptor));
					r_op_Equality_VertexAttributeDescriptor_VertexAttributeDescriptor.SetBelong(null);
				}
				return r_op_Equality_VertexAttributeDescriptor_VertexAttributeDescriptor;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.Rendering.VertexAttributeDescriptor, UnityEngine.Rendering.VertexAttributeDescriptor)
		/// </summary>
		protected static RMethod r_op_Inequality_VertexAttributeDescriptor_VertexAttributeDescriptor;
		public static RMethod Rop_Inequality_VertexAttributeDescriptor_VertexAttributeDescriptor
		{
			get
			{
				if(r_op_Inequality_VertexAttributeDescriptor_VertexAttributeDescriptor == null)
				{
					r_op_Inequality_VertexAttributeDescriptor_VertexAttributeDescriptor = new(typeof(UnityEngine.Rendering.VertexAttributeDescriptor), "op_Inequality", 0, typeof(UnityEngine.Rendering.VertexAttributeDescriptor), typeof(UnityEngine.Rendering.VertexAttributeDescriptor));
					r_op_Inequality_VertexAttributeDescriptor_VertexAttributeDescriptor.SetBelong(null);
				}
				return r_op_Inequality_VertexAttributeDescriptor_VertexAttributeDescriptor;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_Finalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_Finalize == null)
				{
					r_Finalize = new(this, "Finalize", 0);
					r_Finalize.SetBelong(this.instance);
				}
				return r_Finalize;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_GetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_GetType == null)
				{
					r_GetType = new(this, "GetType", 0);
					r_GetType.SetBelong(this.instance);
				}
				return r_GetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_MemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_MemberwiseClone == null)
				{
					r_MemberwiseClone = new(this, "MemberwiseClone", 0);
					r_MemberwiseClone.SetBelong(this.instance);
				}
				return r_MemberwiseClone;
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

        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.Rendering.VertexAttributeDescriptor @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_VertexAttributeDescriptor.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.Rendering.VertexAttributeDescriptor @lhs, UnityEngine.Rendering.VertexAttributeDescriptor @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Equality_VertexAttributeDescriptor_VertexAttributeDescriptor.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.Rendering.VertexAttributeDescriptor @lhs, UnityEngine.Rendering.VertexAttributeDescriptor @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Inequality_VertexAttributeDescriptor_VertexAttributeDescriptor.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
