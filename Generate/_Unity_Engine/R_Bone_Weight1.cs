
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// UnityEngine.BoneWeight1
	/// </summary>
    public partial class RBoneWeight1 : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.BoneWeight1);
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


		/// <summary>
		/// System.Single m_Weight
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_Weight;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_Weight
		{
			get
			{
				if(r_Fm_Weight == null)
				{
					r_Fm_Weight = new(this, "m_Weight");
				}
				return r_Fm_Weight;
			}
		}

		/// <summary>
		/// System.Int32 m_BoneIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_BoneIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_BoneIndex
		{
			get
			{
				if(r_Fm_BoneIndex == null)
				{
					r_Fm_BoneIndex = new(this, "m_BoneIndex");
				}
				return r_Fm_BoneIndex;
			}
		}

		/// <summary>
		/// Single weight
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Pweight;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPweight
		{
			get
			{
				if(r_Pweight == null)
				{
					r_Pweight = new(this, "weight", -1);
				}
				return r_Pweight;
			}
		}

		/// <summary>
		/// Int32 boneIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PboneIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPboneIndex
		{
			get
			{
				if(r_PboneIndex == null)
				{
					r_PboneIndex = new(this, "boneIndex", -1);
				}
				return r_PboneIndex;
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
		/// Boolean Equals(UnityEngine.BoneWeight1)
		/// </summary>
		protected RMethod r_MEquals_BoneWeight1;
		public virtual RMethod RMEquals_BoneWeight1
		{
			get
			{
				if(r_MEquals_BoneWeight1 == null)
				{
					r_MEquals_BoneWeight1 = new(this, "Equals", 0, typeof(UnityEngine.BoneWeight1));
				}
				return r_MEquals_BoneWeight1;
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
		/// Boolean op_Equality(UnityEngine.BoneWeight1, UnityEngine.BoneWeight1)
		/// </summary>
		protected static RMethod r_Mop_Equality_BoneWeight1_BoneWeight1;
		public static RMethod RMop_Equality_BoneWeight1_BoneWeight1
		{
			get
			{
				if(r_Mop_Equality_BoneWeight1_BoneWeight1 == null)
				{
					r_Mop_Equality_BoneWeight1_BoneWeight1 = new(Type, "op_Equality", 0, typeof(UnityEngine.BoneWeight1), typeof(UnityEngine.BoneWeight1));
				}
				return r_Mop_Equality_BoneWeight1_BoneWeight1;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.BoneWeight1, UnityEngine.BoneWeight1)
		/// </summary>
		protected static RMethod r_Mop_Inequality_BoneWeight1_BoneWeight1;
		public static RMethod RMop_Inequality_BoneWeight1_BoneWeight1
		{
			get
			{
				if(r_Mop_Inequality_BoneWeight1_BoneWeight1 == null)
				{
					r_Mop_Inequality_BoneWeight1_BoneWeight1 = new(Type, "op_Inequality", 0, typeof(UnityEngine.BoneWeight1), typeof(UnityEngine.BoneWeight1));
				}
				return r_Mop_Inequality_BoneWeight1_BoneWeight1;
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


        public virtual System.Boolean Equals(System.Object @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean Equals(UnityEngine.BoneWeight1 @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_BoneWeight1.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public static System.Boolean op_Equality(UnityEngine.BoneWeight1 @lhs, UnityEngine.BoneWeight1 @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Equality_BoneWeight1_BoneWeight1.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean op_Inequality(UnityEngine.BoneWeight1 @lhs, UnityEngine.BoneWeight1 @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Inequality_BoneWeight1_BoneWeight1.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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
