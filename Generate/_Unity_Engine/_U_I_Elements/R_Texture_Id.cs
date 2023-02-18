
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.TextureId
	/// </summary>
    public partial class RTextureId : RMember //
    {

		/// <summary>
		/// System.Int32 m_Index
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_Index;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_Index
		{
			get
			{
				if(r_Fm_Index == null)
				{
					r_Fm_Index = new(this, "m_Index");
				}
				return r_Fm_Index;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextureId invalid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextureId r_Finvalid;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextureId RFinvalid
		{
			get
			{
				if(r_Finvalid == null)
				{
					r_Finvalid = new( ReflectionUtils.GetType("UnityEngine.UIElements.TextureId"), "invalid");
				}
				return r_Finvalid;
			}
		}

		/// <summary>
		/// Int32 index
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Pindex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPindex
		{
			get
			{
				if(r_Pindex == null)
				{
					r_Pindex = new(this, "index", -1);
				}
				return r_Pindex;
			}
		}

		/// <summary>
		/// Boolean IsValid()
		/// </summary>
		protected RMethod r_MIsValid;
		public virtual RMethod RMIsValid
		{
			get
			{
				if(r_MIsValid == null)
				{
					r_MIsValid = new(this, "IsValid", 0);
				}
				return r_MIsValid;
			}
		}

		/// <summary>
		/// Single ConvertToGpu()
		/// </summary>
		protected RMethod r_MConvertToGpu;
		public virtual RMethod RMConvertToGpu
		{
			get
			{
				if(r_MConvertToGpu == null)
				{
					r_MConvertToGpu = new(this, "ConvertToGpu", 0);
				}
				return r_MConvertToGpu;
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
		/// Boolean Equals(UnityEngine.UIElements.TextureId)
		/// </summary>
		protected RMethod r_MEquals_TextureId;
		public virtual RMethod RMEquals_TextureId
		{
			get
			{
				if(r_MEquals_TextureId == null)
				{
					r_MEquals_TextureId = new(this, "Equals", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.TextureId"));
				}
				return r_MEquals_TextureId;
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
		/// Boolean op_Equality(UnityEngine.UIElements.TextureId, UnityEngine.UIElements.TextureId)
		/// </summary>
		protected static RMethod r_Mop_Equality_TextureId_TextureId;
		public static RMethod RMop_Equality_TextureId_TextureId
		{
			get
			{
				if(r_Mop_Equality_TextureId_TextureId == null)
				{
					r_Mop_Equality_TextureId_TextureId = new( ReflectionUtils.GetType("UnityEngine.UIElements.TextureId"), "op_Equality", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.TextureId"),  ReflectionUtils.GetType("UnityEngine.UIElements.TextureId"));
				}
				return r_Mop_Equality_TextureId_TextureId;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.TextureId, UnityEngine.UIElements.TextureId)
		/// </summary>
		protected static RMethod r_Mop_Inequality_TextureId_TextureId;
		public static RMethod RMop_Inequality_TextureId_TextureId
		{
			get
			{
				if(r_Mop_Inequality_TextureId_TextureId == null)
				{
					r_Mop_Inequality_TextureId_TextureId = new( ReflectionUtils.GetType("UnityEngine.UIElements.TextureId"), "op_Inequality", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.TextureId"),  ReflectionUtils.GetType("UnityEngine.UIElements.TextureId"));
				}
				return r_Mop_Inequality_TextureId_TextureId;
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


        public RTextureId() : base("UnityEngine.UIElements.TextureId")
        {
        }

        public RTextureId(System.Object instance) : base("UnityEngine.UIElements.TextureId")
		{
            SetInstance(instance);
		}

        public RTextureId(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTextureId(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean IsValid()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsValid.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Single ConvertToGpu()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMConvertToGpu.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextureId @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other.Value};
            var ___result = RMEquals_TextureId.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean op_Equality(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextureId @left, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextureId @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left.Value, @right.Value};
            var ___result = RMop_Equality_TextureId_TextureId.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextureId @left, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextureId @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left.Value, @right.Value};
            var ___result = RMop_Inequality_TextureId_TextureId.Invoke(___genericsType, ___parameters);

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
