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
		protected RField r___1__attribute__2__k__BackingField;
		public virtual RField R__1__attribute__2__k__BackingField
		{
			get
			{
				if(r___1__attribute__2__k__BackingField == null)
				{
					r___1__attribute__2__k__BackingField = new(this, "<attribute>k__BackingField");
					r___1__attribute__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__attribute__2__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.VertexAttributeFormat <format>k__BackingField
		/// </summary>
		protected RField r___1__format__2__k__BackingField;
		public virtual RField R__1__format__2__k__BackingField
		{
			get
			{
				if(r___1__format__2__k__BackingField == null)
				{
					r___1__format__2__k__BackingField = new(this, "<format>k__BackingField");
					r___1__format__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__format__2__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int32 <dimension>k__BackingField
		/// </summary>
		protected RField r___1__dimension__2__k__BackingField;
		public virtual RField R__1__dimension__2__k__BackingField
		{
			get
			{
				if(r___1__dimension__2__k__BackingField == null)
				{
					r___1__dimension__2__k__BackingField = new(this, "<dimension>k__BackingField");
					r___1__dimension__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__dimension__2__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int32 <stream>k__BackingField
		/// </summary>
		protected RField r___1__stream__2__k__BackingField;
		public virtual RField R__1__stream__2__k__BackingField
		{
			get
			{
				if(r___1__stream__2__k__BackingField == null)
				{
					r___1__stream__2__k__BackingField = new(this, "<stream>k__BackingField");
					r___1__stream__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__stream__2__k__BackingField;
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
		protected RProperty r_dimension;
		public virtual RProperty Rdimension
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
		protected RProperty r_stream;
		public virtual RProperty Rstream
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
		/// Boolean Equals(UnityEngine.Rendering.VertexAttributeDescriptor)
		/// </summary>
		protected RMethod r_REquals_VertexAttributeDescriptor;
		public virtual RMethod REquals_VertexAttributeDescriptor
		{
			get
			{
				if(r_REquals_VertexAttributeDescriptor == null)
				{
					r_REquals_VertexAttributeDescriptor = new(this, "Equals", 0, typeof(UnityEngine.Rendering.VertexAttributeDescriptor));
					r_REquals_VertexAttributeDescriptor.SetBelong(this.instance);
				}
				return r_REquals_VertexAttributeDescriptor;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.Rendering.VertexAttributeDescriptor, UnityEngine.Rendering.VertexAttributeDescriptor)
		/// </summary>
		protected static RMethod r_Rop_Equality_VertexAttributeDescriptor_VertexAttributeDescriptor;
		public static RMethod Rop_Equality_VertexAttributeDescriptor_VertexAttributeDescriptor
		{
			get
			{
				if(r_Rop_Equality_VertexAttributeDescriptor_VertexAttributeDescriptor == null)
				{
					r_Rop_Equality_VertexAttributeDescriptor_VertexAttributeDescriptor = new(typeof(UnityEngine.Rendering.VertexAttributeDescriptor), "op_Equality", 0, typeof(UnityEngine.Rendering.VertexAttributeDescriptor), typeof(UnityEngine.Rendering.VertexAttributeDescriptor));
					r_Rop_Equality_VertexAttributeDescriptor_VertexAttributeDescriptor.SetBelong(null);
				}
				return r_Rop_Equality_VertexAttributeDescriptor_VertexAttributeDescriptor;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.Rendering.VertexAttributeDescriptor, UnityEngine.Rendering.VertexAttributeDescriptor)
		/// </summary>
		protected static RMethod r_Rop_Inequality_VertexAttributeDescriptor_VertexAttributeDescriptor;
		public static RMethod Rop_Inequality_VertexAttributeDescriptor_VertexAttributeDescriptor
		{
			get
			{
				if(r_Rop_Inequality_VertexAttributeDescriptor_VertexAttributeDescriptor == null)
				{
					r_Rop_Inequality_VertexAttributeDescriptor_VertexAttributeDescriptor = new(typeof(UnityEngine.Rendering.VertexAttributeDescriptor), "op_Inequality", 0, typeof(UnityEngine.Rendering.VertexAttributeDescriptor), typeof(UnityEngine.Rendering.VertexAttributeDescriptor));
					r_Rop_Inequality_VertexAttributeDescriptor_VertexAttributeDescriptor.SetBelong(null);
				}
				return r_Rop_Inequality_VertexAttributeDescriptor_VertexAttributeDescriptor;
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


        public virtual System.Boolean Equals(System.Object  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.Rendering.VertexAttributeDescriptor  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_VertexAttributeDescriptor.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.Rendering.VertexAttributeDescriptor  @lhs, UnityEngine.Rendering.VertexAttributeDescriptor  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Equality_VertexAttributeDescriptor_VertexAttributeDescriptor.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.Rendering.VertexAttributeDescriptor  @lhs, UnityEngine.Rendering.VertexAttributeDescriptor  @rhs)
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
