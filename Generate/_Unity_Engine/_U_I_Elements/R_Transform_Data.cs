
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.UIElements.TransformData
	/// </summary>
    public partial class RTransformData : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.TransformData");
            }
        }

        public RTransformData() : base("UnityEngine.UIElements.TransformData")
        {
        }

        public RTransformData(System.Object instance) : base("UnityEngine.UIElements.TransformData")
		{
            SetInstance(instance);
		}

        public RTransformData(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTransformData(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// UnityEngine.UIElements.Rotate rotate
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RRotate r_Frotate;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RRotate RFrotate
		{
			get
			{
				if(r_Frotate == null)
				{
					r_Frotate = new(this, "rotate");
				}
				return r_Frotate;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Scale scale
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RScale r_Fscale;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RScale RFscale
		{
			get
			{
				if(r_Fscale == null)
				{
					r_Fscale = new(this, "scale");
				}
				return r_Fscale;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TransformOrigin transformOrigin
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTransformOrigin r_FtransformOrigin;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTransformOrigin RFtransformOrigin
		{
			get
			{
				if(r_FtransformOrigin == null)
				{
					r_FtransformOrigin = new(this, "transformOrigin");
				}
				return r_FtransformOrigin;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Translate translate
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTranslate r_Ftranslate;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTranslate RFtranslate
		{
			get
			{
				if(r_Ftranslate == null)
				{
					r_Ftranslate = new(this, "translate");
				}
				return r_Ftranslate;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TransformData Copy()
		/// </summary>
		protected RMethod r_MCopy;
		public virtual RMethod RMCopy
		{
			get
			{
				if(r_MCopy == null)
				{
					r_MCopy = new(this, "Copy", 0);
				}
				return r_MCopy;
			}
		}

		/// <summary>
		/// Void CopyFrom(UnityEngine.UIElements.TransformData ByRef)
		/// </summary>
		protected RMethod r_MCopyFrom_Ref_TransformData;
		public virtual RMethod RMCopyFrom_Ref_TransformData
		{
			get
			{
				if(r_MCopyFrom_Ref_TransformData == null)
				{
					r_MCopyFrom_Ref_TransformData = new(this, "CopyFrom", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.TransformData").MakeByRefType());
				}
				return r_MCopyFrom_Ref_TransformData;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.UIElements.TransformData, UnityEngine.UIElements.TransformData)
		/// </summary>
		protected static RMethod r_Mop_Equality_TransformData_TransformData;
		public static RMethod RMop_Equality_TransformData_TransformData
		{
			get
			{
				if(r_Mop_Equality_TransformData_TransformData == null)
				{
					r_Mop_Equality_TransformData_TransformData = new(Type, "op_Equality", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.TransformData"),  ReflectionUtils.GetType("UnityEngine.UIElements.TransformData"));
				}
				return r_Mop_Equality_TransformData_TransformData;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.TransformData, UnityEngine.UIElements.TransformData)
		/// </summary>
		protected static RMethod r_Mop_Inequality_TransformData_TransformData;
		public static RMethod RMop_Inequality_TransformData_TransformData
		{
			get
			{
				if(r_Mop_Inequality_TransformData_TransformData == null)
				{
					r_Mop_Inequality_TransformData_TransformData = new(Type, "op_Inequality", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.TransformData"),  ReflectionUtils.GetType("UnityEngine.UIElements.TransformData"));
				}
				return r_Mop_Inequality_TransformData_TransformData;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.UIElements.TransformData)
		/// </summary>
		protected RMethod r_MEquals_TransformData;
		public virtual RMethod RMEquals_TransformData
		{
			get
			{
				if(r_MEquals_TransformData == null)
				{
					r_MEquals_TransformData = new(this, "Equals", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.TransformData"));
				}
				return r_MEquals_TransformData;
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


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTransformData Copy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCopy.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTransformData>(___result);
        }


        public virtual void CopyFrom(ref Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTransformData @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other.Value};
            var ___result = RMCopyFrom_Ref_TransformData.Invoke(___genericsType, ___parameters);
			@other = ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTransformData>(___parameters[0]);

            
        }


        public static System.Boolean op_Equality(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTransformData @lhs, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTransformData @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs.Value, @rhs.Value};
            var ___result = RMop_Equality_TransformData_TransformData.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean op_Inequality(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTransformData @lhs, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTransformData @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs.Value, @rhs.Value};
            var ___result = RMop_Inequality_TransformData_TransformData.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean Equals(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTransformData @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other.Value};
            var ___result = RMEquals_TransformData.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
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
