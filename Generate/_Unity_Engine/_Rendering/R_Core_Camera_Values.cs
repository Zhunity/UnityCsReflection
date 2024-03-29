
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RRendering
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.Rendering.CoreCameraValues
	/// </summary>
    public partial class RCoreCameraValues : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.Rendering.CoreCameraValues");
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


		/// <summary>
		/// System.Int32 filterMode
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FfilterMode;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFfilterMode
		{
			get
			{
				if(r_FfilterMode == null)
				{
					r_FfilterMode = new(this, "filterMode");
				}
				return r_FfilterMode;
			}
		}

		/// <summary>
		/// System.UInt32 cullingMask
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_FcullingMask;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFcullingMask
		{
			get
			{
				if(r_FcullingMask == null)
				{
					r_FcullingMask = new(this, "cullingMask");
				}
				return r_FcullingMask;
			}
		}

		/// <summary>
		/// System.Int32 instanceID
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FinstanceID;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFinstanceID
		{
			get
			{
				if(r_FinstanceID == null)
				{
					r_FinstanceID = new(this, "instanceID");
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
		/// Boolean op_Equality(UnityEngine.Rendering.CoreCameraValues, UnityEngine.Rendering.CoreCameraValues)
		/// </summary>
		protected static RMethod r_Mop_Equality_CoreCameraValues_CoreCameraValues;
		public static RMethod RMop_Equality_CoreCameraValues_CoreCameraValues
		{
			get
			{
				if(r_Mop_Equality_CoreCameraValues_CoreCameraValues == null)
				{
					r_Mop_Equality_CoreCameraValues_CoreCameraValues = new(Type, "op_Equality", 0,  ReflectionUtils.GetType("UnityEngine.Rendering.CoreCameraValues"),  ReflectionUtils.GetType("UnityEngine.Rendering.CoreCameraValues"));
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
					r_Mop_Inequality_CoreCameraValues_CoreCameraValues = new(Type, "op_Inequality", 0,  ReflectionUtils.GetType("UnityEngine.Rendering.CoreCameraValues"),  ReflectionUtils.GetType("UnityEngine.Rendering.CoreCameraValues"));
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


        public virtual System.Boolean Equals(Hvak.Editor.Refleaction.RUnityEngine.RRendering.RCoreCameraValues @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other.Value};
            var ___result = RMEquals_CoreCameraValues.Invoke(___genericsType, ___parameters);

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


        public static System.Boolean op_Equality(Hvak.Editor.Refleaction.RUnityEngine.RRendering.RCoreCameraValues @left, Hvak.Editor.Refleaction.RUnityEngine.RRendering.RCoreCameraValues @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left.Value, @right.Value};
            var ___result = RMop_Equality_CoreCameraValues_CoreCameraValues.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean op_Inequality(Hvak.Editor.Refleaction.RUnityEngine.RRendering.RCoreCameraValues @left, Hvak.Editor.Refleaction.RUnityEngine.RRendering.RCoreCameraValues @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left.Value, @right.Value};
            var ___result = RMop_Inequality_CoreCameraValues_CoreCameraValues.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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
