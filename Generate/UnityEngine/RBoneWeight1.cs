using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.BoneWeight1
	/// </summary>
    public partial class RBoneWeight1 : RMember //
    {

		/// <summary>
		/// System.Single m_Weight
		/// </summary>
		protected RField r_m_Weight;
		public virtual RField Rm_Weight
		{
			get
			{
				if(r_m_Weight == null)
				{
					r_m_Weight = new(this, "m_Weight");
					r_m_Weight.SetBelong(this.instance);
				}
				return r_m_Weight;
			}
		}

		/// <summary>
		/// System.Int32 m_BoneIndex
		/// </summary>
		protected RField r_m_BoneIndex;
		public virtual RField Rm_BoneIndex
		{
			get
			{
				if(r_m_BoneIndex == null)
				{
					r_m_BoneIndex = new(this, "m_BoneIndex");
					r_m_BoneIndex.SetBelong(this.instance);
				}
				return r_m_BoneIndex;
			}
		}

		/// <summary>
		/// Single weight
		/// </summary>
		protected RProperty r_weight;
		public virtual RProperty Rweight
		{
			get
			{
				if(r_weight == null)
				{
					r_weight = new(this, "weight", -1);
					r_weight.SetBelong(this.instance);
				}
				return r_weight;
			}
		}

		/// <summary>
		/// Int32 boneIndex
		/// </summary>
		protected RProperty r_boneIndex;
		public virtual RProperty RboneIndex
		{
			get
			{
				if(r_boneIndex == null)
				{
					r_boneIndex = new(this, "boneIndex", -1);
					r_boneIndex.SetBelong(this.instance);
				}
				return r_boneIndex;
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
		/// Boolean Equals(UnityEngine.BoneWeight1)
		/// </summary>
		protected RMethod r_REquals_BoneWeight1;
		public virtual RMethod REquals_BoneWeight1
		{
			get
			{
				if(r_REquals_BoneWeight1 == null)
				{
					r_REquals_BoneWeight1 = new(this, "Equals", 0, typeof(UnityEngine.BoneWeight1));
					r_REquals_BoneWeight1.SetBelong(this.instance);
				}
				return r_REquals_BoneWeight1;
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
		/// Boolean op_Equality(UnityEngine.BoneWeight1, UnityEngine.BoneWeight1)
		/// </summary>
		protected static RMethod r_Rop_Equality_BoneWeight1_BoneWeight1;
		public static RMethod Rop_Equality_BoneWeight1_BoneWeight1
		{
			get
			{
				if(r_Rop_Equality_BoneWeight1_BoneWeight1 == null)
				{
					r_Rop_Equality_BoneWeight1_BoneWeight1 = new(typeof(UnityEngine.BoneWeight1), "op_Equality", 0, typeof(UnityEngine.BoneWeight1), typeof(UnityEngine.BoneWeight1));
					r_Rop_Equality_BoneWeight1_BoneWeight1.SetBelong(null);
				}
				return r_Rop_Equality_BoneWeight1_BoneWeight1;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.BoneWeight1, UnityEngine.BoneWeight1)
		/// </summary>
		protected static RMethod r_Rop_Inequality_BoneWeight1_BoneWeight1;
		public static RMethod Rop_Inequality_BoneWeight1_BoneWeight1
		{
			get
			{
				if(r_Rop_Inequality_BoneWeight1_BoneWeight1 == null)
				{
					r_Rop_Inequality_BoneWeight1_BoneWeight1 = new(typeof(UnityEngine.BoneWeight1), "op_Inequality", 0, typeof(UnityEngine.BoneWeight1), typeof(UnityEngine.BoneWeight1));
					r_Rop_Inequality_BoneWeight1_BoneWeight1.SetBelong(null);
				}
				return r_Rop_Inequality_BoneWeight1_BoneWeight1;
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


        public RBoneWeight1() : base("UnityEngine.BoneWeight1")
        {
        }

        public RBoneWeight1(System.Object instance) : base("UnityEngine.BoneWeight1")
		{
            SetInstance(instance);
		}

        public RBoneWeight1(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RBoneWeight1(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Equals(System.Object  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.BoneWeight1  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_BoneWeight1.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.BoneWeight1  @lhs, UnityEngine.BoneWeight1  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Equality_BoneWeight1_BoneWeight1.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.BoneWeight1  @lhs, UnityEngine.BoneWeight1  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Inequality_BoneWeight1_BoneWeight1.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
