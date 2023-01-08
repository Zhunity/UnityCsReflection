using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.PropertyName
	/// </summary>
    public partial class RPropertyName : RMember //
    {

		/// <summary>
		/// System.Int32 id
		/// </summary>
		protected RField r_id;
		public virtual RField Rid
		{
			get
			{
				if(r_id == null)
				{
					r_id = new(this, "id");
					r_id.SetBelong(this.instance);
				}
				return r_id;
			}
		}

		/// <summary>
		/// System.Int32 conflictIndex
		/// </summary>
		protected RField r_conflictIndex;
		public virtual RField RconflictIndex
		{
			get
			{
				if(r_conflictIndex == null)
				{
					r_conflictIndex = new(this, "conflictIndex");
					r_conflictIndex.SetBelong(this.instance);
				}
				return r_conflictIndex;
			}
		}

		/// <summary>
		/// Boolean IsNullOrEmpty(UnityEngine.PropertyName)
		/// </summary>
		protected static RMethod r_IsNullOrEmpty_PropertyName;
		public static RMethod RIsNullOrEmpty_PropertyName
		{
			get
			{
				if(r_IsNullOrEmpty_PropertyName == null)
				{
					r_IsNullOrEmpty_PropertyName = new(typeof(UnityEngine.PropertyName), "IsNullOrEmpty", 0, typeof(UnityEngine.PropertyName));
					r_IsNullOrEmpty_PropertyName.SetBelong(null);
				}
				return r_IsNullOrEmpty_PropertyName;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.PropertyName, UnityEngine.PropertyName)
		/// </summary>
		protected static RMethod r_op_Equality_PropertyName_PropertyName;
		public static RMethod Rop_Equality_PropertyName_PropertyName
		{
			get
			{
				if(r_op_Equality_PropertyName_PropertyName == null)
				{
					r_op_Equality_PropertyName_PropertyName = new(typeof(UnityEngine.PropertyName), "op_Equality", 0, typeof(UnityEngine.PropertyName), typeof(UnityEngine.PropertyName));
					r_op_Equality_PropertyName_PropertyName.SetBelong(null);
				}
				return r_op_Equality_PropertyName_PropertyName;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.PropertyName, UnityEngine.PropertyName)
		/// </summary>
		protected static RMethod r_op_Inequality_PropertyName_PropertyName;
		public static RMethod Rop_Inequality_PropertyName_PropertyName
		{
			get
			{
				if(r_op_Inequality_PropertyName_PropertyName == null)
				{
					r_op_Inequality_PropertyName_PropertyName = new(typeof(UnityEngine.PropertyName), "op_Inequality", 0, typeof(UnityEngine.PropertyName), typeof(UnityEngine.PropertyName));
					r_op_Inequality_PropertyName_PropertyName.SetBelong(null);
				}
				return r_op_Inequality_PropertyName_PropertyName;
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
		/// Boolean Equals(UnityEngine.PropertyName)
		/// </summary>
		protected RMethod r_Equals_PropertyName;
		public virtual RMethod REquals_PropertyName
		{
			get
			{
				if(r_Equals_PropertyName == null)
				{
					r_Equals_PropertyName = new(this, "Equals", 0, typeof(UnityEngine.PropertyName));
					r_Equals_PropertyName.SetBelong(this.instance);
				}
				return r_Equals_PropertyName;
			}
		}

		/// <summary>
		/// UnityEngine.PropertyName op_Implicit(System.String)
		/// </summary>
		protected static RMethod r_op_Implicit_String;
		public static RMethod Rop_Implicit_String
		{
			get
			{
				if(r_op_Implicit_String == null)
				{
					r_op_Implicit_String = new(typeof(UnityEngine.PropertyName), "op_Implicit", 0, typeof(System.String));
					r_op_Implicit_String.SetBelong(null);
				}
				return r_op_Implicit_String;
			}
		}

		/// <summary>
		/// UnityEngine.PropertyName op_Implicit(Int32)
		/// </summary>
		protected static RMethod r_op_Implicit_Int32;
		public static RMethod Rop_Implicit_Int32
		{
			get
			{
				if(r_op_Implicit_Int32 == null)
				{
					r_op_Implicit_Int32 = new(typeof(UnityEngine.PropertyName), "op_Implicit", 0, typeof(System.Int32));
					r_op_Implicit_Int32.SetBelong(null);
				}
				return r_op_Implicit_Int32;
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


        public RPropertyName() : base("UnityEngine.PropertyName")
        {
        }

        public RPropertyName(System.Object instance) : base("UnityEngine.PropertyName")
		{
            SetInstance(instance);
		}

        public RPropertyName(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPropertyName(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Boolean IsNullOrEmpty(UnityEngine.PropertyName @prop)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prop};
            var ___result = RIsNullOrEmpty_PropertyName.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.PropertyName @lhs, UnityEngine.PropertyName @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Equality_PropertyName_PropertyName.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.PropertyName @lhs, UnityEngine.PropertyName @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Inequality_PropertyName_PropertyName.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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


        public virtual System.Boolean Equals(UnityEngine.PropertyName @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_PropertyName.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static UnityEngine.PropertyName op_Implicit(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = Rop_Implicit_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.PropertyName)___result;
        }


        public static UnityEngine.PropertyName op_Implicit(System.Int32 @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = Rop_Implicit_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.PropertyName)___result;
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
