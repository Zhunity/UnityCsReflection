
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{public partial class RBestFitAllocator
{
	
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.UIElements.UIR.BestFitAllocator+BlockPool
	/// </summary>
    public partial class RBlockPool : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BestFitAllocator+BlockPool");
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


		/// <summary>
		/// Int32 Count
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPCount
		{
			get
			{
				if(r_PCount == null)
				{
					r_PCount = new(this, "Count", -1);
				}
				return r_PCount;
			}
		}

		/// <summary>
		/// Block CreateBlock()
		/// </summary>
		protected static RMethod r_MCreateBlock;
		public static RMethod RMCreateBlock
		{
			get
			{
				if(r_MCreateBlock == null)
				{
					r_MCreateBlock = new(Type, "CreateBlock", 0);
				}
				return r_MCreateBlock;
			}
		}

		/// <summary>
		/// Void ResetBlock(Block)
		/// </summary>
		protected static RMethod r_MResetBlock_Block;
		public static RMethod RMResetBlock_Block
		{
			get
			{
				if(r_MResetBlock_Block == null)
				{
					r_MResetBlock_Block = new(Type, "ResetBlock", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BestFitAllocator+Block"));
				}
				return r_MResetBlock_Block;
			}
		}

		/// <summary>
		/// Void Clear()
		/// </summary>
		protected RMethod r_MClear;
		public virtual RMethod RMClear
		{
			get
			{
				if(r_MClear == null)
				{
					r_MClear = new(this, "Clear", 0);
				}
				return r_MClear;
			}
		}

		/// <summary>
		/// Block Get()
		/// </summary>
		protected RMethod r_MGet;
		public virtual RMethod RMGet
		{
			get
			{
				if(r_MGet == null)
				{
					r_MGet = new(this, "Get", 0);
				}
				return r_MGet;
			}
		}

		/// <summary>
		/// Void Return(Block)
		/// </summary>
		protected RMethod r_MReturn_Block;
		public virtual RMethod RMReturn_Block
		{
			get
			{
				if(r_MReturn_Block == null)
				{
					r_MReturn_Block = new(this, "Return", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BestFitAllocator+Block"));
				}
				return r_MReturn_Block;
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


        public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBestFitAllocator.RBlock CreateBlock()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCreateBlock.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBestFitAllocator.RBlock>(___result);
        }


        public static void ResetBlock(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBestFitAllocator.RBlock @block)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@block.Value};
            var ___result = RMResetBlock_Block.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBestFitAllocator.RBlock Get()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGet.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBestFitAllocator.RBlock>(___result);
        }


        public virtual void Return(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBestFitAllocator.RBlock @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@item.Value};
            var ___result = RMReturn_Block.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


    }
}
}