using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{public partial class RBestFitAllocator
{
	
	/// <summary>
	/// UnityEngine.UIElements.UIR.BestFitAllocator+BlockPool
	/// </summary>
    public partial class RBlockPool : RMember //
    {

		/// <summary>
		/// Int32 Count
		/// </summary>
		protected RProperty r_Count;
		public virtual RProperty RCount
		{
			get
			{
				if(r_Count == null)
				{
					r_Count = new(this, "Count", -1);
					r_Count.SetBelong(this.instance);
				}
				return r_Count;
			}
		}

		/// <summary>
		/// Block CreateBlock()
		/// </summary>
		protected static RMethod r_CreateBlock;
		public static RMethod RCreateBlock
		{
			get
			{
				if(r_CreateBlock == null)
				{
					r_CreateBlock = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BestFitAllocator+BlockPool"), "CreateBlock", 0);
					r_CreateBlock.SetBelong(null);
				}
				return r_CreateBlock;
			}
		}

		/// <summary>
		/// Void ResetBlock(Block)
		/// </summary>
		protected static RMethod r_ResetBlock_Block;
		public static RMethod RResetBlock_Block
		{
			get
			{
				if(r_ResetBlock_Block == null)
				{
					r_ResetBlock_Block = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BestFitAllocator+BlockPool"), "ResetBlock", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BestFitAllocator+Block"));
					r_ResetBlock_Block.SetBelong(null);
				}
				return r_ResetBlock_Block;
			}
		}

		/// <summary>
		/// Void Clear()
		/// </summary>
		protected RMethod r_Clear;
		public virtual RMethod RClear
		{
			get
			{
				if(r_Clear == null)
				{
					r_Clear = new(this, "Clear", 0);
					r_Clear.SetBelong(this.instance);
				}
				return r_Clear;
			}
		}

		/// <summary>
		/// Block Get()
		/// </summary>
		protected RMethod r_Get;
		public virtual RMethod RGet
		{
			get
			{
				if(r_Get == null)
				{
					r_Get = new(this, "Get", 0);
					r_Get.SetBelong(this.instance);
				}
				return r_Get;
			}
		}

		/// <summary>
		/// Void Return(Block)
		/// </summary>
		protected RMethod r_Return_Block;
		public virtual RMethod RReturn_Block
		{
			get
			{
				if(r_Return_Block == null)
				{
					r_Return_Block = new(this, "Return", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BestFitAllocator+Block"));
					r_Return_Block.SetBelong(this.instance);
				}
				return r_Return_Block;
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


        public RBlockPool() : base("UnityEngine.UIElements.UIR.BestFitAllocator+BlockPool")
        {
        }

        public RBlockPool(System.Object instance) : base("UnityEngine.UIElements.UIR.BestFitAllocator+BlockPool")
		{
            SetInstance(instance);
		}

        public RBlockPool(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RBlockPool(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Object CreateBlock()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCreateBlock.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }



        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object Get()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGet.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }



        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
}