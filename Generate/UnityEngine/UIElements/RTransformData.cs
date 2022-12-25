using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.TransformData
	/// </summary>
    public partial class RTransformData : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.Rotate rotate
		/// </summary>
		protected RUnityEngine.RUIElements.RRotate r_rotate;
		public virtual RUnityEngine.RUIElements.RRotate Rrotate
		{
			get
			{
				if(r_rotate == null)
				{
					r_rotate = new(this, "rotate");
					r_rotate.SetBelong(this.instance);
				}
				return r_rotate;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Scale scale
		/// </summary>
		protected RUnityEngine.RUIElements.RScale r_scale;
		public virtual RUnityEngine.RUIElements.RScale Rscale
		{
			get
			{
				if(r_scale == null)
				{
					r_scale = new(this, "scale");
					r_scale.SetBelong(this.instance);
				}
				return r_scale;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TransformOrigin transformOrigin
		/// </summary>
		protected RUnityEngine.RUIElements.RTransformOrigin r_transformOrigin;
		public virtual RUnityEngine.RUIElements.RTransformOrigin RtransformOrigin
		{
			get
			{
				if(r_transformOrigin == null)
				{
					r_transformOrigin = new(this, "transformOrigin");
					r_transformOrigin.SetBelong(this.instance);
				}
				return r_transformOrigin;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Translate translate
		/// </summary>
		protected RUnityEngine.RUIElements.RTranslate r_translate;
		public virtual RUnityEngine.RUIElements.RTranslate Rtranslate
		{
			get
			{
				if(r_translate == null)
				{
					r_translate = new(this, "translate");
					r_translate.SetBelong(this.instance);
				}
				return r_translate;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TransformData Copy()
		/// </summary>
		protected RMethod r_RCopy;
		public virtual RMethod RCopy
		{
			get
			{
				if(r_RCopy == null)
				{
					r_RCopy = new(this, "Copy", 0);
					r_RCopy.SetBelong(this.instance);
				}
				return r_RCopy;
			}
		}

		/// <summary>
		/// Void CopyFrom(UnityEngine.UIElements.TransformData ByRef)
		/// </summary>
		protected RMethod r_RCopyFrom_Ref_TransformData;
		public virtual RMethod RCopyFrom_Ref_TransformData
		{
			get
			{
				if(r_RCopyFrom_Ref_TransformData == null)
				{
					r_RCopyFrom_Ref_TransformData = new(this, "CopyFrom", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.TransformData").MakeByRefType());
					r_RCopyFrom_Ref_TransformData.SetBelong(this.instance);
				}
				return r_RCopyFrom_Ref_TransformData;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.UIElements.TransformData, UnityEngine.UIElements.TransformData)
		/// </summary>
		protected static RMethod r_Rop_Equality_TransformData_TransformData;
		public static RMethod Rop_Equality_TransformData_TransformData
		{
			get
			{
				if(r_Rop_Equality_TransformData_TransformData == null)
				{
					r_Rop_Equality_TransformData_TransformData = new( ReleactionUtils.GetType("UnityEngine.UIElements.TransformData"), "op_Equality", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.TransformData"),  ReleactionUtils.GetType("UnityEngine.UIElements.TransformData"));
					r_Rop_Equality_TransformData_TransformData.SetBelong(null);
				}
				return r_Rop_Equality_TransformData_TransformData;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.TransformData, UnityEngine.UIElements.TransformData)
		/// </summary>
		protected static RMethod r_Rop_Inequality_TransformData_TransformData;
		public static RMethod Rop_Inequality_TransformData_TransformData
		{
			get
			{
				if(r_Rop_Inequality_TransformData_TransformData == null)
				{
					r_Rop_Inequality_TransformData_TransformData = new( ReleactionUtils.GetType("UnityEngine.UIElements.TransformData"), "op_Inequality", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.TransformData"),  ReleactionUtils.GetType("UnityEngine.UIElements.TransformData"));
					r_Rop_Inequality_TransformData_TransformData.SetBelong(null);
				}
				return r_Rop_Inequality_TransformData_TransformData;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.UIElements.TransformData)
		/// </summary>
		protected RMethod r_REquals_TransformData;
		public virtual RMethod REquals_TransformData
		{
			get
			{
				if(r_REquals_TransformData == null)
				{
					r_REquals_TransformData = new(this, "Equals", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.TransformData"));
					r_REquals_TransformData.SetBelong(this.instance);
				}
				return r_REquals_TransformData;
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

        public virtual System.Object Copy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCopy.Invoke(___genericsType, ___parameters);

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
