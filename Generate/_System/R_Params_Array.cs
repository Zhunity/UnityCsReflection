
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.ParamsArray
	/// </summary>
    public partial class RParamsArray : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("System.ParamsArray");
            }
        }

        public RParamsArray() : base("System.ParamsArray")
        {
        }

        public RParamsArray(System.Object instance) : base("System.ParamsArray")
		{
            SetInstance(instance);
		}

        public RParamsArray(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RParamsArray(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Object[] s_oneArgArray
		/// </summary>
		protected static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RObject> r_Fs_oneArgArray;
		public static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RObject> RFs_oneArgArray
		{
			get
			{
				if(r_Fs_oneArgArray == null)
				{
					r_Fs_oneArgArray = new( ReflectionUtils.GetType("System.ParamsArray"), "s_oneArgArray");
				}
				return r_Fs_oneArgArray;
			}
		}

		/// <summary>
		/// System.Object[] s_twoArgArray
		/// </summary>
		protected static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RObject> r_Fs_twoArgArray;
		public static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RObject> RFs_twoArgArray
		{
			get
			{
				if(r_Fs_twoArgArray == null)
				{
					r_Fs_twoArgArray = new( ReflectionUtils.GetType("System.ParamsArray"), "s_twoArgArray");
				}
				return r_Fs_twoArgArray;
			}
		}

		/// <summary>
		/// System.Object[] s_threeArgArray
		/// </summary>
		protected static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RObject> r_Fs_threeArgArray;
		public static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RObject> RFs_threeArgArray
		{
			get
			{
				if(r_Fs_threeArgArray == null)
				{
					r_Fs_threeArgArray = new( ReflectionUtils.GetType("System.ParamsArray"), "s_threeArgArray");
				}
				return r_Fs_threeArgArray;
			}
		}

		/// <summary>
		/// System.Object _arg0
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_F_arg0;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RF_arg0
		{
			get
			{
				if(r_F_arg0 == null)
				{
					r_F_arg0 = new(this, "_arg0");
				}
				return r_F_arg0;
			}
		}

		/// <summary>
		/// System.Object _arg1
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_F_arg1;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RF_arg1
		{
			get
			{
				if(r_F_arg1 == null)
				{
					r_F_arg1 = new(this, "_arg1");
				}
				return r_F_arg1;
			}
		}

		/// <summary>
		/// System.Object _arg2
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_F_arg2;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RF_arg2
		{
			get
			{
				if(r_F_arg2 == null)
				{
					r_F_arg2 = new(this, "_arg2");
				}
				return r_F_arg2;
			}
		}

		/// <summary>
		/// System.Object[] _args
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RObject> r_F_args;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RObject> RF_args
		{
			get
			{
				if(r_F_args == null)
				{
					r_F_args = new(this, "_args");
				}
				return r_F_args;
			}
		}

		/// <summary>
		/// Int32 Length
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PLength;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPLength
		{
			get
			{
				if(r_PLength == null)
				{
					r_PLength = new(this, "Length", -1);
				}
				return r_PLength;
			}
		}

		/// <summary>
		/// System.Object Item [Int32]
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_PItem_Int32;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RPItem_Int32
		{
			get
			{
				if(r_PItem_Int32 == null)
				{
					r_PItem_Int32 = new(this, "Item", -1, typeof(System.Int32));
				}
				return r_PItem_Int32;
			}
		}

		/// <summary>
		/// System.Object GetAtSlow(Int32)
		/// </summary>
		protected RMethod r_MGetAtSlow_Int32;
		public virtual RMethod RMGetAtSlow_Int32
		{
			get
			{
				if(r_MGetAtSlow_Int32 == null)
				{
					r_MGetAtSlow_Int32 = new(this, "GetAtSlow", 0, typeof(System.Int32));
				}
				return r_MGetAtSlow_Int32;
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


        public virtual System.Object GetAtSlow(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMGetAtSlow_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
