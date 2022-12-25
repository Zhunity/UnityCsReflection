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
		protected RMethod r_REquals_CoreCameraValues;
		public virtual RMethod REquals_CoreCameraValues
		{
			get
			{
				if(r_REquals_CoreCameraValues == null)
				{
					r_REquals_CoreCameraValues = new(this, "Equals", 0,  ReleactionUtils.GetType("UnityEngine.Rendering.CoreCameraValues"));
					r_REquals_CoreCameraValues.SetBelong(this.instance);
				}
				return r_REquals_CoreCameraValues;
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
		/// Boolean op_Equality(UnityEngine.Rendering.CoreCameraValues, UnityEngine.Rendering.CoreCameraValues)
		/// </summary>
		protected static RMethod r_Rop_Equality_CoreCameraValues_CoreCameraValues;
		public static RMethod Rop_Equality_CoreCameraValues_CoreCameraValues
		{
			get
			{
				if(r_Rop_Equality_CoreCameraValues_CoreCameraValues == null)
				{
					r_Rop_Equality_CoreCameraValues_CoreCameraValues = new( ReleactionUtils.GetType("UnityEngine.Rendering.CoreCameraValues"), "op_Equality", 0,  ReleactionUtils.GetType("UnityEngine.Rendering.CoreCameraValues"),  ReleactionUtils.GetType("UnityEngine.Rendering.CoreCameraValues"));
					r_Rop_Equality_CoreCameraValues_CoreCameraValues.SetBelong(null);
				}
				return r_Rop_Equality_CoreCameraValues_CoreCameraValues;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.Rendering.CoreCameraValues, UnityEngine.Rendering.CoreCameraValues)
		/// </summary>
		protected static RMethod r_Rop_Inequality_CoreCameraValues_CoreCameraValues;
		public static RMethod Rop_Inequality_CoreCameraValues_CoreCameraValues
		{
			get
			{
				if(r_Rop_Inequality_CoreCameraValues_CoreCameraValues == null)
				{
					r_Rop_Inequality_CoreCameraValues_CoreCameraValues = new( ReleactionUtils.GetType("UnityEngine.Rendering.CoreCameraValues"), "op_Inequality", 0,  ReleactionUtils.GetType("UnityEngine.Rendering.CoreCameraValues"),  ReleactionUtils.GetType("UnityEngine.Rendering.CoreCameraValues"));
					r_Rop_Inequality_CoreCameraValues_CoreCameraValues.SetBelong(null);
				}
				return r_Rop_Inequality_CoreCameraValues_CoreCameraValues;
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
