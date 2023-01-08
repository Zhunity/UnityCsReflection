using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RReflection.REmit
{
	/// <summary>
	/// System.Reflection.Emit.Label
	/// </summary>
    public partial class RLabel : RMember //
    {

		/// <summary>
		/// System.Int32 label
		/// </summary>
		protected RField r_label;
		public virtual RField Rlabel
		{
			get
			{
				if(r_label == null)
				{
					r_label = new(this, "label");
					r_label.SetBelong(this.instance);
				}
				return r_label;
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
		/// Boolean Equals(System.Reflection.Emit.Label)
		/// </summary>
		protected RMethod r_Equals_Label;
		public virtual RMethod REquals_Label
		{
			get
			{
				if(r_Equals_Label == null)
				{
					r_Equals_Label = new(this, "Equals", 0, typeof(System.Reflection.Emit.Label));
					r_Equals_Label.SetBelong(this.instance);
				}
				return r_Equals_Label;
			}
		}

		/// <summary>
		/// Boolean op_Equality(System.Reflection.Emit.Label, System.Reflection.Emit.Label)
		/// </summary>
		protected static RMethod r_op_Equality_Label_Label;
		public static RMethod Rop_Equality_Label_Label
		{
			get
			{
				if(r_op_Equality_Label_Label == null)
				{
					r_op_Equality_Label_Label = new(typeof(System.Reflection.Emit.Label), "op_Equality", 0, typeof(System.Reflection.Emit.Label), typeof(System.Reflection.Emit.Label));
					r_op_Equality_Label_Label.SetBelong(null);
				}
				return r_op_Equality_Label_Label;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Reflection.Emit.Label, System.Reflection.Emit.Label)
		/// </summary>
		protected static RMethod r_op_Inequality_Label_Label;
		public static RMethod Rop_Inequality_Label_Label
		{
			get
			{
				if(r_op_Inequality_Label_Label == null)
				{
					r_op_Inequality_Label_Label = new(typeof(System.Reflection.Emit.Label), "op_Inequality", 0, typeof(System.Reflection.Emit.Label), typeof(System.Reflection.Emit.Label));
					r_op_Inequality_Label_Label.SetBelong(null);
				}
				return r_op_Inequality_Label_Label;
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


        public RLabel() : base("System.Reflection.Emit.Label")
        {
        }

        public RLabel(System.Object instance) : base("System.Reflection.Emit.Label")
		{
            SetInstance(instance);
		}

        public RLabel(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RLabel(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Reflection.Emit.Label @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Label.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(System.Reflection.Emit.Label @a, System.Reflection.Emit.Label @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = Rop_Equality_Label_Label.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.Reflection.Emit.Label @a, System.Reflection.Emit.Label @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = Rop_Inequality_Label_Label.Invoke(___genericsType, ___parameters);

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
