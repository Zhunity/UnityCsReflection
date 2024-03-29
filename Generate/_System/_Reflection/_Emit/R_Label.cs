
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RReflection.REmit
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Reflection.Emit.Label
	/// </summary>
    public partial class RLabel : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Reflection.Emit.Label);
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


		/// <summary>
		/// System.Int32 label
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Flabel;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFlabel
		{
			get
			{
				if(r_Flabel == null)
				{
					r_Flabel = new(this, "label");
				}
				return r_Flabel;
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
		/// Boolean Equals(System.Reflection.Emit.Label)
		/// </summary>
		protected RMethod r_MEquals_Label;
		public virtual RMethod RMEquals_Label
		{
			get
			{
				if(r_MEquals_Label == null)
				{
					r_MEquals_Label = new(this, "Equals", 0, typeof(System.Reflection.Emit.Label));
				}
				return r_MEquals_Label;
			}
		}

		/// <summary>
		/// Boolean op_Equality(System.Reflection.Emit.Label, System.Reflection.Emit.Label)
		/// </summary>
		protected static RMethod r_Mop_Equality_Label_Label;
		public static RMethod RMop_Equality_Label_Label
		{
			get
			{
				if(r_Mop_Equality_Label_Label == null)
				{
					r_Mop_Equality_Label_Label = new(Type, "op_Equality", 0, typeof(System.Reflection.Emit.Label), typeof(System.Reflection.Emit.Label));
				}
				return r_Mop_Equality_Label_Label;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Reflection.Emit.Label, System.Reflection.Emit.Label)
		/// </summary>
		protected static RMethod r_Mop_Inequality_Label_Label;
		public static RMethod RMop_Inequality_Label_Label
		{
			get
			{
				if(r_Mop_Inequality_Label_Label == null)
				{
					r_Mop_Inequality_Label_Label = new(Type, "op_Inequality", 0, typeof(System.Reflection.Emit.Label), typeof(System.Reflection.Emit.Label));
				}
				return r_Mop_Inequality_Label_Label;
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


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean Equals(System.Reflection.Emit.Label @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Label.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean op_Equality(System.Reflection.Emit.Label @a, System.Reflection.Emit.Label @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMop_Equality_Label_Label.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean op_Inequality(System.Reflection.Emit.Label @a, System.Reflection.Emit.Label @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMop_Inequality_Label_Label.Invoke(___genericsType, ___parameters);

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
