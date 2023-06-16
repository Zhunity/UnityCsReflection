
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RReflection
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Reflection.LocalVariableInfo
	/// </summary>
    public partial class RLocalVariableInfo : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Reflection.LocalVariableInfo);
            }
        }

        public RLocalVariableInfo() : base("System.Reflection.LocalVariableInfo")
        {
        }

        public RLocalVariableInfo(System.Object instance) : base("System.Reflection.LocalVariableInfo")
		{
            SetInstance(instance);
		}

        public RLocalVariableInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RLocalVariableInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Type type
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RType r_Ftype;
		public virtual Hvak.Editor.Refleaction.RSystem.RType RFtype
		{
			get
			{
				if(r_Ftype == null)
				{
					r_Ftype = new(this, "type");
				}
				return r_Ftype;
			}
		}

		/// <summary>
		/// System.Boolean is_pinned
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fis_pinned;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFis_pinned
		{
			get
			{
				if(r_Fis_pinned == null)
				{
					r_Fis_pinned = new(this, "is_pinned");
				}
				return r_Fis_pinned;
			}
		}

		/// <summary>
		/// System.UInt16 position
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt16 r_Fposition;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt16 RFposition
		{
			get
			{
				if(r_Fposition == null)
				{
					r_Fposition = new(this, "position");
				}
				return r_Fposition;
			}
		}

		/// <summary>
		/// Boolean IsPinned
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsPinned;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsPinned
		{
			get
			{
				if(r_PIsPinned == null)
				{
					r_PIsPinned = new(this, "IsPinned", -1);
				}
				return r_PIsPinned;
			}
		}

		/// <summary>
		/// Int32 LocalIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PLocalIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPLocalIndex
		{
			get
			{
				if(r_PLocalIndex == null)
				{
					r_PLocalIndex = new(this, "LocalIndex", -1);
				}
				return r_PLocalIndex;
			}
		}

		/// <summary>
		/// System.Type LocalType
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RType r_PLocalType;
		public virtual Hvak.Editor.Refleaction.RSystem.RType RPLocalType
		{
			get
			{
				if(r_PLocalType == null)
				{
					r_PLocalType = new(this, "LocalType", -1);
				}
				return r_PLocalType;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
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


    }
}
