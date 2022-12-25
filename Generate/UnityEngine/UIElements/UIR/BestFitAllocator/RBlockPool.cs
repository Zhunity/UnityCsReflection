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
		protected static RMethod r_RCreateBlock;
		public static RMethod RCreateBlock
		{
			get
			{
				if(r_RCreateBlock == null)
				{
					r_RCreateBlock = new( ReleactionUtils.GetType("UnityEngine.UIElements.UIR.BestFitAllocator+BlockPool"), "CreateBlock", 0);
					r_RCreateBlock.SetBelong(null);
				}
				return r_RCreateBlock;
			}
		}

		/// <summary>
		/// Void ResetBlock(Block)
		/// </summary>
		protected static RMethod r_RResetBlock_Block;
		public static RMethod RResetBlock_Block
		{
			get
			{
				if(r_RResetBlock_Block == null)
				{
					r_RResetBlock_Block = new( ReleactionUtils.GetType("UnityEngine.UIElements.UIR.BestFitAllocator+BlockPool"), "ResetBlock", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.UIR.BestFitAllocator+Block"));
					r_RResetBlock_Block.SetBelong(null);
				}
				return r_RResetBlock_Block;
			}
		}

		/// <summary>
		/// Void Clear()
		/// </summary>
		protected RMethod r_RClear;
		public virtual RMethod RClear
		{
			get
			{
				if(r_RClear == null)
				{
					r_RClear = new(this, "Clear", 0);
					r_RClear.SetBelong(this.instance);
				}
				return r_RClear;
			}
		}

		/// <summary>
		/// Block Get()
		/// </summary>
		protected RMethod r_RGet;
		public virtual RMethod RGet
		{
			get
			{
				if(r_RGet == null)
				{
					r_RGet = new(this, "Get", 0);
					r_RGet.SetBelong(this.instance);
				}
				return r_RGet;
			}
		}

		/// <summary>
		/// Void Return(Block)
		/// </summary>
		protected RMethod r_RReturn_Block;
		public virtual RMethod RReturn_Block
		{
			get
			{
				if(r_RReturn_Block == null)
				{
					r_RReturn_Block = new(this, "Return", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.UIR.BestFitAllocator+Block"));
					r_RReturn_Block.SetBelong(this.instance);
				}
				return r_RReturn_Block;
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