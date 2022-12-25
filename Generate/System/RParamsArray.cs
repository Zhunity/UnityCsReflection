using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.ParamsArray
	/// </summary>
    public partial class RParamsArray : RMember //
    {

		/// <summary>
		/// System.Object[] s_oneArgArray
		/// </summary>
		protected static RFieldArray<RSystem.RObject> r_s_oneArgArray;
		public static RFieldArray<RSystem.RObject> Rs_oneArgArray
		{
			get
			{
				if(r_s_oneArgArray == null)
				{
					r_s_oneArgArray = new( ReleactionUtils.GetType("System.ParamsArray"), "s_oneArgArray");
					r_s_oneArgArray.SetBelong(null);
				}
				return r_s_oneArgArray;
			}
		}

		/// <summary>
		/// System.Object[] s_twoArgArray
		/// </summary>
		protected static RFieldArray<RSystem.RObject> r_s_twoArgArray;
		public static RFieldArray<RSystem.RObject> Rs_twoArgArray
		{
			get
			{
				if(r_s_twoArgArray == null)
				{
					r_s_twoArgArray = new( ReleactionUtils.GetType("System.ParamsArray"), "s_twoArgArray");
					r_s_twoArgArray.SetBelong(null);
				}
				return r_s_twoArgArray;
			}
		}

		/// <summary>
		/// System.Object[] s_threeArgArray
		/// </summary>
		protected static RFieldArray<RSystem.RObject> r_s_threeArgArray;
		public static RFieldArray<RSystem.RObject> Rs_threeArgArray
		{
			get
			{
				if(r_s_threeArgArray == null)
				{
					r_s_threeArgArray = new( ReleactionUtils.GetType("System.ParamsArray"), "s_threeArgArray");
					r_s_threeArgArray.SetBelong(null);
				}
				return r_s_threeArgArray;
			}
		}

		/// <summary>
		/// System.Object _arg0
		/// </summary>
		protected RSystem.RObject r__arg0;
		public virtual RSystem.RObject R_arg0
		{
			get
			{
				if(r__arg0 == null)
				{
					r__arg0 = new(this, "_arg0");
					r__arg0.SetBelong(this.instance);
				}
				return r__arg0;
			}
		}

		/// <summary>
		/// System.Object _arg1
		/// </summary>
		protected RSystem.RObject r__arg1;
		public virtual RSystem.RObject R_arg1
		{
			get
			{
				if(r__arg1 == null)
				{
					r__arg1 = new(this, "_arg1");
					r__arg1.SetBelong(this.instance);
				}
				return r__arg1;
			}
		}

		/// <summary>
		/// System.Object _arg2
		/// </summary>
		protected RSystem.RObject r__arg2;
		public virtual RSystem.RObject R_arg2
		{
			get
			{
				if(r__arg2 == null)
				{
					r__arg2 = new(this, "_arg2");
					r__arg2.SetBelong(this.instance);
				}
				return r__arg2;
			}
		}

		/// <summary>
		/// System.Object[] _args
		/// </summary>
		protected RFieldArray<RSystem.RObject> r__args;
		public virtual RFieldArray<RSystem.RObject> R_args
		{
			get
			{
				if(r__args == null)
				{
					r__args = new(this, "_args");
					r__args.SetBelong(this.instance);
				}
				return r__args;
			}
		}

		/// <summary>
		/// Int32 Length
		/// </summary>
		protected RProperty r_Length;
		public virtual RProperty RLength
		{
			get
			{
				if(r_Length == null)
				{
					r_Length = new(this, "Length", -1);
					r_Length.SetBelong(this.instance);
				}
				return r_Length;
			}
		}

		/// <summary>
		/// System.Object Item [Int32]
		/// </summary>
		protected RSystem.RObject r_Item_Int32;
		public virtual RSystem.RObject RItem_Int32
		{
			get
			{
				if(r_Item_Int32 == null)
				{
					r_Item_Int32 = new(this, "Item", -1, typeof(System.Int32));
					r_Item_Int32.SetBelong(this.instance);
				}
				return r_Item_Int32;
			}
		}

		/// <summary>
		/// System.Object GetAtSlow(Int32)
		/// </summary>
		protected RMethod r_RGetAtSlow_Int32;
		public virtual RMethod RGetAtSlow_Int32
		{
			get
			{
				if(r_RGetAtSlow_Int32 == null)
				{
					r_RGetAtSlow_Int32 = new(this, "GetAtSlow", 0, typeof(System.Int32));
					r_RGetAtSlow_Int32.SetBelong(this.instance);
				}
				return r_RGetAtSlow_Int32;
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

        public virtual System.Object GetAtSlow(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RGetAtSlow_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
