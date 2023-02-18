
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.BoneWeight
	/// </summary>
    public partial class RBoneWeight : RMember //
    {

		/// <summary>
		/// System.Single m_Weight0
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_Weight0;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_Weight0
		{
			get
			{
				if(r_Fm_Weight0 == null)
				{
					r_Fm_Weight0 = new(this, "m_Weight0");
					r_Fm_Weight0.SetBelong(this.GetValue());
				}
				return r_Fm_Weight0;
			}
		}

		/// <summary>
		/// System.Single m_Weight1
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_Weight1;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_Weight1
		{
			get
			{
				if(r_Fm_Weight1 == null)
				{
					r_Fm_Weight1 = new(this, "m_Weight1");
					r_Fm_Weight1.SetBelong(this.GetValue());
				}
				return r_Fm_Weight1;
			}
		}

		/// <summary>
		/// System.Single m_Weight2
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_Weight2;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_Weight2
		{
			get
			{
				if(r_Fm_Weight2 == null)
				{
					r_Fm_Weight2 = new(this, "m_Weight2");
					r_Fm_Weight2.SetBelong(this.GetValue());
				}
				return r_Fm_Weight2;
			}
		}

		/// <summary>
		/// System.Single m_Weight3
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_Weight3;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_Weight3
		{
			get
			{
				if(r_Fm_Weight3 == null)
				{
					r_Fm_Weight3 = new(this, "m_Weight3");
					r_Fm_Weight3.SetBelong(this.GetValue());
				}
				return r_Fm_Weight3;
			}
		}

		/// <summary>
		/// System.Int32 m_BoneIndex0
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_BoneIndex0;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_BoneIndex0
		{
			get
			{
				if(r_Fm_BoneIndex0 == null)
				{
					r_Fm_BoneIndex0 = new(this, "m_BoneIndex0");
					r_Fm_BoneIndex0.SetBelong(this.GetValue());
				}
				return r_Fm_BoneIndex0;
			}
		}

		/// <summary>
		/// System.Int32 m_BoneIndex1
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_BoneIndex1;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_BoneIndex1
		{
			get
			{
				if(r_Fm_BoneIndex1 == null)
				{
					r_Fm_BoneIndex1 = new(this, "m_BoneIndex1");
					r_Fm_BoneIndex1.SetBelong(this.GetValue());
				}
				return r_Fm_BoneIndex1;
			}
		}

		/// <summary>
		/// System.Int32 m_BoneIndex2
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_BoneIndex2;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_BoneIndex2
		{
			get
			{
				if(r_Fm_BoneIndex2 == null)
				{
					r_Fm_BoneIndex2 = new(this, "m_BoneIndex2");
					r_Fm_BoneIndex2.SetBelong(this.GetValue());
				}
				return r_Fm_BoneIndex2;
			}
		}

		/// <summary>
		/// System.Int32 m_BoneIndex3
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_BoneIndex3;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_BoneIndex3
		{
			get
			{
				if(r_Fm_BoneIndex3 == null)
				{
					r_Fm_BoneIndex3 = new(this, "m_BoneIndex3");
					r_Fm_BoneIndex3.SetBelong(this.GetValue());
				}
				return r_Fm_BoneIndex3;
			}
		}

		/// <summary>
		/// Single weight0
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Pweight0;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPweight0
		{
			get
			{
				if(r_Pweight0 == null)
				{
					r_Pweight0 = new(this, "weight0", -1);
					r_Pweight0.SetBelong(this.GetValue());
				}
				return r_Pweight0;
			}
		}

		/// <summary>
		/// Single weight1
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Pweight1;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPweight1
		{
			get
			{
				if(r_Pweight1 == null)
				{
					r_Pweight1 = new(this, "weight1", -1);
					r_Pweight1.SetBelong(this.GetValue());
				}
				return r_Pweight1;
			}
		}

		/// <summary>
		/// Single weight2
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Pweight2;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPweight2
		{
			get
			{
				if(r_Pweight2 == null)
				{
					r_Pweight2 = new(this, "weight2", -1);
					r_Pweight2.SetBelong(this.GetValue());
				}
				return r_Pweight2;
			}
		}

		/// <summary>
		/// Single weight3
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Pweight3;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPweight3
		{
			get
			{
				if(r_Pweight3 == null)
				{
					r_Pweight3 = new(this, "weight3", -1);
					r_Pweight3.SetBelong(this.GetValue());
				}
				return r_Pweight3;
			}
		}

		/// <summary>
		/// Int32 boneIndex0
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PboneIndex0;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPboneIndex0
		{
			get
			{
				if(r_PboneIndex0 == null)
				{
					r_PboneIndex0 = new(this, "boneIndex0", -1);
					r_PboneIndex0.SetBelong(this.GetValue());
				}
				return r_PboneIndex0;
			}
		}

		/// <summary>
		/// Int32 boneIndex1
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PboneIndex1;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPboneIndex1
		{
			get
			{
				if(r_PboneIndex1 == null)
				{
					r_PboneIndex1 = new(this, "boneIndex1", -1);
					r_PboneIndex1.SetBelong(this.GetValue());
				}
				return r_PboneIndex1;
			}
		}

		/// <summary>
		/// Int32 boneIndex2
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PboneIndex2;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPboneIndex2
		{
			get
			{
				if(r_PboneIndex2 == null)
				{
					r_PboneIndex2 = new(this, "boneIndex2", -1);
					r_PboneIndex2.SetBelong(this.GetValue());
				}
				return r_PboneIndex2;
			}
		}

		/// <summary>
		/// Int32 boneIndex3
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PboneIndex3;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPboneIndex3
		{
			get
			{
				if(r_PboneIndex3 == null)
				{
					r_PboneIndex3 = new(this, "boneIndex3", -1);
					r_PboneIndex3.SetBelong(this.GetValue());
				}
				return r_PboneIndex3;
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
					r_MGetHashCode.SetBelong(this.GetValue());
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
					r_MEquals_Object.SetBelong(this.GetValue());
				}
				return r_MEquals_Object;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.BoneWeight)
		/// </summary>
		protected RMethod r_MEquals_BoneWeight;
		public virtual RMethod RMEquals_BoneWeight
		{
			get
			{
				if(r_MEquals_BoneWeight == null)
				{
					r_MEquals_BoneWeight = new(this, "Equals", 0, typeof(UnityEngine.BoneWeight));
					r_MEquals_BoneWeight.SetBelong(this.GetValue());
				}
				return r_MEquals_BoneWeight;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.BoneWeight, UnityEngine.BoneWeight)
		/// </summary>
		protected static RMethod r_Mop_Equality_BoneWeight_BoneWeight;
		public static RMethod RMop_Equality_BoneWeight_BoneWeight
		{
			get
			{
				if(r_Mop_Equality_BoneWeight_BoneWeight == null)
				{
					r_Mop_Equality_BoneWeight_BoneWeight = new(typeof(UnityEngine.BoneWeight), "op_Equality", 0, typeof(UnityEngine.BoneWeight), typeof(UnityEngine.BoneWeight));
					r_Mop_Equality_BoneWeight_BoneWeight.SetBelong(null);
				}
				return r_Mop_Equality_BoneWeight_BoneWeight;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.BoneWeight, UnityEngine.BoneWeight)
		/// </summary>
		protected static RMethod r_Mop_Inequality_BoneWeight_BoneWeight;
		public static RMethod RMop_Inequality_BoneWeight_BoneWeight
		{
			get
			{
				if(r_Mop_Inequality_BoneWeight_BoneWeight == null)
				{
					r_Mop_Inequality_BoneWeight_BoneWeight = new(typeof(UnityEngine.BoneWeight), "op_Inequality", 0, typeof(UnityEngine.BoneWeight), typeof(UnityEngine.BoneWeight));
					r_Mop_Inequality_BoneWeight_BoneWeight.SetBelong(null);
				}
				return r_Mop_Inequality_BoneWeight_BoneWeight;
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
					r_MToString.SetBelong(this.GetValue());
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
					r_MFinalize.SetBelong(this.GetValue());
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
					r_MGetType.SetBelong(this.GetValue());
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
					r_MMemberwiseClone.SetBelong(this.GetValue());
				}
				return r_MMemberwiseClone;
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


        public virtual System.Boolean Equals(UnityEngine.BoneWeight @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_BoneWeight.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.BoneWeight @lhs, UnityEngine.BoneWeight @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Equality_BoneWeight_BoneWeight.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.BoneWeight @lhs, UnityEngine.BoneWeight @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Inequality_BoneWeight_BoneWeight.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
