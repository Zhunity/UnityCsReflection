using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RRendering
{
	/// <summary>
	/// UnityEngine.Rendering.CoreCameraValues
	/// </summary>
    public partial class RCoreCameraValues : RMember //
    {

		/// <summary>
		/// System.Int32 filterMode
		/// </summary>
		protected RField r_filterMode;
		public virtual RField RfilterMode
		{
			get
			{
				if(r_filterMode == null)
				{
					r_filterMode = new(this, "filterMode");
					r_filterMode.SetBelong(this.instance);
				}
				return r_filterMode;
			}
		}

		/// <summary>
		/// System.UInt32 cullingMask
		/// </summary>
		protected RField r_cullingMask;
		public virtual RField RcullingMask
		{
			get
			{
				if(r_cullingMask == null)
				{
					r_cullingMask = new(this, "cullingMask");
					r_cullingMask.SetBelong(this.instance);
				}
				return r_cullingMask;
			}
		}

		/// <summary>
		/// System.Int32 instanceID
		/// </summary>
		protected RField r_instanceID;
		public virtual RField RinstanceID
		{
			get
			{
				if(r_instanceID == null)
				{
					r_instanceID = new(this, "instanceID");
					r_instanceID.SetBelong(this.instance);
				}
				return r_instanceID;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.Rendering.CoreCameraValues)
		/// </summary>
		protected RMethod r_Equals_CoreCameraValues;
		public virtual RMethod REquals_CoreCameraValues
		{
			get
			{
				if(r_Equals_CoreCameraValues == null)
				{
					r_Equals_CoreCameraValues = new(this, "Equals", 0,  ReleactionUtils.GetType("UnityEngine.Rendering.CoreCameraValues"));
					r_Equals_CoreCameraValues.SetBelong(this.instance);
				}
				return r_Equals_CoreCameraValues;
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
		/// Boolean op_Equality(UnityEngine.Rendering.CoreCameraValues, UnityEngine.Rendering.CoreCameraValues)
		/// </summary>
		protected static RMethod r_op_Equality_CoreCameraValues_CoreCameraValues;
		public static RMethod Rop_Equality_CoreCameraValues_CoreCameraValues
		{
			get
			{
				if(r_op_Equality_CoreCameraValues_CoreCameraValues == null)
				{
					r_op_Equality_CoreCameraValues_CoreCameraValues = new( ReleactionUtils.GetType("UnityEngine.Rendering.CoreCameraValues"), "op_Equality", 0,  ReleactionUtils.GetType("UnityEngine.Rendering.CoreCameraValues"),  ReleactionUtils.GetType("UnityEngine.Rendering.CoreCameraValues"));
					r_op_Equality_CoreCameraValues_CoreCameraValues.SetBelong(null);
				}
				return r_op_Equality_CoreCameraValues_CoreCameraValues;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.Rendering.CoreCameraValues, UnityEngine.Rendering.CoreCameraValues)
		/// </summary>
		protected static RMethod r_op_Inequality_CoreCameraValues_CoreCameraValues;
		public static RMethod Rop_Inequality_CoreCameraValues_CoreCameraValues
		{
			get
			{
				if(r_op_Inequality_CoreCameraValues_CoreCameraValues == null)
				{
					r_op_Inequality_CoreCameraValues_CoreCameraValues = new( ReleactionUtils.GetType("UnityEngine.Rendering.CoreCameraValues"), "op_Inequality", 0,  ReleactionUtils.GetType("UnityEngine.Rendering.CoreCameraValues"),  ReleactionUtils.GetType("UnityEngine.Rendering.CoreCameraValues"));
					r_op_Inequality_CoreCameraValues_CoreCameraValues.SetBelong(null);
				}
				return r_op_Inequality_CoreCameraValues_CoreCameraValues;
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


        public RCoreCameraValues() : base("UnityEngine.Rendering.CoreCameraValues")
        {
        }

        public RCoreCameraValues(System.Object instance) : base("UnityEngine.Rendering.CoreCameraValues")
		{
            SetInstance(instance);
		}

        public RCoreCameraValues(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCoreCameraValues(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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
