
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
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_FfilterMode;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFfilterMode
		{
			get
			{
				if(r_FfilterMode == null)
				{
					r_FfilterMode = new(this, "filterMode");
					r_FfilterMode.SetBelong(this.instance);
				}
				return r_FfilterMode;
			}
		}

		/// <summary>
		/// System.UInt32 cullingMask
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RUInt32 r_FcullingMask;
		public virtual SMFrame.Editor.Refleaction.RSystem.RUInt32 RFcullingMask
		{
			get
			{
				if(r_FcullingMask == null)
				{
					r_FcullingMask = new(this, "cullingMask");
					r_FcullingMask.SetBelong(this.instance);
				}
				return r_FcullingMask;
			}
		}

		/// <summary>
		/// System.Int32 instanceID
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_FinstanceID;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFinstanceID
		{
			get
			{
				if(r_FinstanceID == null)
				{
					r_FinstanceID = new(this, "instanceID");
					r_FinstanceID.SetBelong(this.instance);
				}
				return r_FinstanceID;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.Rendering.CoreCameraValues)
		/// </summary>
		protected RMethod r_MEquals_CoreCameraValues;
		public virtual RMethod RMEquals_CoreCameraValues
		{
			get
			{
				if(r_MEquals_CoreCameraValues == null)
				{
					r_MEquals_CoreCameraValues = new(this, "Equals", 0,  ReflectionUtils.GetType("UnityEngine.Rendering.CoreCameraValues"));
					r_MEquals_CoreCameraValues.SetBelong(this.instance);
				}
				return r_MEquals_CoreCameraValues;
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
					r_MEquals_Object.SetBelong(this.instance);
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
					r_MGetHashCode.SetBelong(this.instance);
				}
				return r_MGetHashCode;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.Rendering.CoreCameraValues, UnityEngine.Rendering.CoreCameraValues)
		/// </summary>
		protected static RMethod r_Mop_Equality_CoreCameraValues_CoreCameraValues;
		public static RMethod RMop_Equality_CoreCameraValues_CoreCameraValues
		{
			get
			{
				if(r_Mop_Equality_CoreCameraValues_CoreCameraValues == null)
				{
					r_Mop_Equality_CoreCameraValues_CoreCameraValues = new( ReflectionUtils.GetType("UnityEngine.Rendering.CoreCameraValues"), "op_Equality", 0,  ReflectionUtils.GetType("UnityEngine.Rendering.CoreCameraValues"),  ReflectionUtils.GetType("UnityEngine.Rendering.CoreCameraValues"));
					r_Mop_Equality_CoreCameraValues_CoreCameraValues.SetBelong(null);
				}
				return r_Mop_Equality_CoreCameraValues_CoreCameraValues;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.Rendering.CoreCameraValues, UnityEngine.Rendering.CoreCameraValues)
		/// </summary>
		protected static RMethod r_Mop_Inequality_CoreCameraValues_CoreCameraValues;
		public static RMethod RMop_Inequality_CoreCameraValues_CoreCameraValues
		{
			get
			{
				if(r_Mop_Inequality_CoreCameraValues_CoreCameraValues == null)
				{
					r_Mop_Inequality_CoreCameraValues_CoreCameraValues = new( ReflectionUtils.GetType("UnityEngine.Rendering.CoreCameraValues"), "op_Inequality", 0,  ReflectionUtils.GetType("UnityEngine.Rendering.CoreCameraValues"),  ReflectionUtils.GetType("UnityEngine.Rendering.CoreCameraValues"));
					r_Mop_Inequality_CoreCameraValues_CoreCameraValues.SetBelong(null);
				}
				return r_Mop_Inequality_CoreCameraValues_CoreCameraValues;
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
					r_MToString.SetBelong(this.instance);
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
					r_MFinalize.SetBelong(this.instance);
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
					r_MGetType.SetBelong(this.instance);
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
					r_MMemberwiseClone.SetBelong(this.instance);
				}
				return r_MMemberwiseClone;
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

        public virtual System.Boolean Equals(SMFrame.Editor.Refleaction.RUnityEngine.RRendering.RCoreCameraValues @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other.Value};
            var ___result = RMEquals_CoreCameraValues.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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


        public static System.Boolean op_Equality(SMFrame.Editor.Refleaction.RUnityEngine.RRendering.RCoreCameraValues @left, SMFrame.Editor.Refleaction.RUnityEngine.RRendering.RCoreCameraValues @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left.Value, @right.Value};
            var ___result = RMop_Equality_CoreCameraValues_CoreCameraValues.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(SMFrame.Editor.Refleaction.RUnityEngine.RRendering.RCoreCameraValues @left, SMFrame.Editor.Refleaction.RUnityEngine.RRendering.RCoreCameraValues @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left.Value, @right.Value};
            var ___result = RMop_Inequality_CoreCameraValues_CoreCameraValues.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
