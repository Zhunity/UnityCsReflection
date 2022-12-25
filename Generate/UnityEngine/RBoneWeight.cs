using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.BoneWeight
	/// </summary>
    public partial class RBoneWeight : RMember //
    {

		/// <summary>
		/// System.Single m_Weight0
		/// </summary>
		protected RField r_m_Weight0;
		public virtual RField Rm_Weight0
		{
			get
			{
				if(r_m_Weight0 == null)
				{
					r_m_Weight0 = new(this, "m_Weight0");
					r_m_Weight0.SetBelong(this.instance);
				}
				return r_m_Weight0;
			}
		}

		/// <summary>
		/// System.Single m_Weight1
		/// </summary>
		protected RField r_m_Weight1;
		public virtual RField Rm_Weight1
		{
			get
			{
				if(r_m_Weight1 == null)
				{
					r_m_Weight1 = new(this, "m_Weight1");
					r_m_Weight1.SetBelong(this.instance);
				}
				return r_m_Weight1;
			}
		}

		/// <summary>
		/// System.Single m_Weight2
		/// </summary>
		protected RField r_m_Weight2;
		public virtual RField Rm_Weight2
		{
			get
			{
				if(r_m_Weight2 == null)
				{
					r_m_Weight2 = new(this, "m_Weight2");
					r_m_Weight2.SetBelong(this.instance);
				}
				return r_m_Weight2;
			}
		}

		/// <summary>
		/// System.Single m_Weight3
		/// </summary>
		protected RField r_m_Weight3;
		public virtual RField Rm_Weight3
		{
			get
			{
				if(r_m_Weight3 == null)
				{
					r_m_Weight3 = new(this, "m_Weight3");
					r_m_Weight3.SetBelong(this.instance);
				}
				return r_m_Weight3;
			}
		}

		/// <summary>
		/// System.Int32 m_BoneIndex0
		/// </summary>
		protected RField r_m_BoneIndex0;
		public virtual RField Rm_BoneIndex0
		{
			get
			{
				if(r_m_BoneIndex0 == null)
				{
					r_m_BoneIndex0 = new(this, "m_BoneIndex0");
					r_m_BoneIndex0.SetBelong(this.instance);
				}
				return r_m_BoneIndex0;
			}
		}

		/// <summary>
		/// System.Int32 m_BoneIndex1
		/// </summary>
		protected RField r_m_BoneIndex1;
		public virtual RField Rm_BoneIndex1
		{
			get
			{
				if(r_m_BoneIndex1 == null)
				{
					r_m_BoneIndex1 = new(this, "m_BoneIndex1");
					r_m_BoneIndex1.SetBelong(this.instance);
				}
				return r_m_BoneIndex1;
			}
		}

		/// <summary>
		/// System.Int32 m_BoneIndex2
		/// </summary>
		protected RField r_m_BoneIndex2;
		public virtual RField Rm_BoneIndex2
		{
			get
			{
				if(r_m_BoneIndex2 == null)
				{
					r_m_BoneIndex2 = new(this, "m_BoneIndex2");
					r_m_BoneIndex2.SetBelong(this.instance);
				}
				return r_m_BoneIndex2;
			}
		}

		/// <summary>
		/// System.Int32 m_BoneIndex3
		/// </summary>
		protected RField r_m_BoneIndex3;
		public virtual RField Rm_BoneIndex3
		{
			get
			{
				if(r_m_BoneIndex3 == null)
				{
					r_m_BoneIndex3 = new(this, "m_BoneIndex3");
					r_m_BoneIndex3.SetBelong(this.instance);
				}
				return r_m_BoneIndex3;
			}
		}

		/// <summary>
		/// Single weight0
		/// </summary>
		protected RProperty r_weight0;
		public virtual RProperty Rweight0
		{
			get
			{
				if(r_weight0 == null)
				{
					r_weight0 = new(this, "weight0", -1);
					r_weight0.SetBelong(this.instance);
				}
				return r_weight0;
			}
		}

		/// <summary>
		/// Single weight1
		/// </summary>
		protected RProperty r_weight1;
		public virtual RProperty Rweight1
		{
			get
			{
				if(r_weight1 == null)
				{
					r_weight1 = new(this, "weight1", -1);
					r_weight1.SetBelong(this.instance);
				}
				return r_weight1;
			}
		}

		/// <summary>
		/// Single weight2
		/// </summary>
		protected RProperty r_weight2;
		public virtual RProperty Rweight2
		{
			get
			{
				if(r_weight2 == null)
				{
					r_weight2 = new(this, "weight2", -1);
					r_weight2.SetBelong(this.instance);
				}
				return r_weight2;
			}
		}

		/// <summary>
		/// Single weight3
		/// </summary>
		protected RProperty r_weight3;
		public virtual RProperty Rweight3
		{
			get
			{
				if(r_weight3 == null)
				{
					r_weight3 = new(this, "weight3", -1);
					r_weight3.SetBelong(this.instance);
				}
				return r_weight3;
			}
		}

		/// <summary>
		/// Int32 boneIndex0
		/// </summary>
		protected RProperty r_boneIndex0;
		public virtual RProperty RboneIndex0
		{
			get
			{
				if(r_boneIndex0 == null)
				{
					r_boneIndex0 = new(this, "boneIndex0", -1);
					r_boneIndex0.SetBelong(this.instance);
				}
				return r_boneIndex0;
			}
		}

		/// <summary>
		/// Int32 boneIndex1
		/// </summary>
		protected RProperty r_boneIndex1;
		public virtual RProperty RboneIndex1
		{
			get
			{
				if(r_boneIndex1 == null)
				{
					r_boneIndex1 = new(this, "boneIndex1", -1);
					r_boneIndex1.SetBelong(this.instance);
				}
				return r_boneIndex1;
			}
		}

		/// <summary>
		/// Int32 boneIndex2
		/// </summary>
		protected RProperty r_boneIndex2;
		public virtual RProperty RboneIndex2
		{
			get
			{
				if(r_boneIndex2 == null)
				{
					r_boneIndex2 = new(this, "boneIndex2", -1);
					r_boneIndex2.SetBelong(this.instance);
				}
				return r_boneIndex2;
			}
		}

		/// <summary>
		/// Int32 boneIndex3
		/// </summary>
		protected RProperty r_boneIndex3;
		public virtual RProperty RboneIndex3
		{
			get
			{
				if(r_boneIndex3 == null)
				{
					r_boneIndex3 = new(this, "boneIndex3", -1);
					r_boneIndex3.SetBelong(this.instance);
				}
				return r_boneIndex3;
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
		/// Boolean Equals(UnityEngine.BoneWeight)
		/// </summary>
		protected RMethod r_REquals_BoneWeight;
		public virtual RMethod REquals_BoneWeight
		{
			get
			{
				if(r_REquals_BoneWeight == null)
				{
					r_REquals_BoneWeight = new(this, "Equals", 0, typeof(UnityEngine.BoneWeight));
					r_REquals_BoneWeight.SetBelong(this.instance);
				}
				return r_REquals_BoneWeight;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.BoneWeight, UnityEngine.BoneWeight)
		/// </summary>
		protected static RMethod r_Rop_Equality_BoneWeight_BoneWeight;
		public static RMethod Rop_Equality_BoneWeight_BoneWeight
		{
			get
			{
				if(r_Rop_Equality_BoneWeight_BoneWeight == null)
				{
					r_Rop_Equality_BoneWeight_BoneWeight = new(typeof(UnityEngine.BoneWeight), "op_Equality", 0, typeof(UnityEngine.BoneWeight), typeof(UnityEngine.BoneWeight));
					r_Rop_Equality_BoneWeight_BoneWeight.SetBelong(null);
				}
				return r_Rop_Equality_BoneWeight_BoneWeight;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.BoneWeight, UnityEngine.BoneWeight)
		/// </summary>
		protected static RMethod r_Rop_Inequality_BoneWeight_BoneWeight;
		public static RMethod Rop_Inequality_BoneWeight_BoneWeight
		{
			get
			{
				if(r_Rop_Inequality_BoneWeight_BoneWeight == null)
				{
					r_Rop_Inequality_BoneWeight_BoneWeight = new(typeof(UnityEngine.BoneWeight), "op_Inequality", 0, typeof(UnityEngine.BoneWeight), typeof(UnityEngine.BoneWeight));
					r_Rop_Inequality_BoneWeight_BoneWeight.SetBelong(null);
				}
				return r_Rop_Inequality_BoneWeight_BoneWeight;
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


        public RBoneWeight() : base("UnityEngine.BoneWeight")
        {
        }

        public RBoneWeight(System.Object instance) : base("UnityEngine.BoneWeight")
		{
            SetInstance(instance);
		}

        public RBoneWeight(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RBoneWeight(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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


        public virtual System.Boolean Equals(UnityEngine.BoneWeight  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_BoneWeight.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.BoneWeight  @lhs, UnityEngine.BoneWeight  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Equality_BoneWeight_BoneWeight.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.BoneWeight  @lhs, UnityEngine.BoneWeight  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Inequality_BoneWeight_BoneWeight.Invoke(___genericsType, ___parameters);

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
