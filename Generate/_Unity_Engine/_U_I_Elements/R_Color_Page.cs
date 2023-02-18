
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.ColorPage
	/// </summary>
    public partial class RColorPage : RMember //
    {

		/// <summary>
		/// System.Boolean isValid
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FisValid;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFisValid
		{
			get
			{
				if(r_FisValid == null)
				{
					r_FisValid = new(this, "isValid");
				}
				return r_FisValid;
			}
		}

		/// <summary>
		/// UnityEngine.Color32 pageAndID
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColor32 r_FpageAndID;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColor32 RFpageAndID
		{
			get
			{
				if(r_FpageAndID == null)
				{
					r_FpageAndID = new(this, "pageAndID");
				}
				return r_FpageAndID;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ColorPage Init(UnityEngine.UIElements.UIR.RenderChain, UnityEngine.UIElements.UIR.BMPAlloc)
		/// </summary>
		protected static RMethod r_MInit_RenderChain_BMPAlloc;
		public static RMethod RMInit_RenderChain_BMPAlloc
		{
			get
			{
				if(r_MInit_RenderChain_BMPAlloc == null)
				{
					r_MInit_RenderChain_BMPAlloc = new( ReflectionUtils.GetType("UnityEngine.UIElements.ColorPage"), "Init", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.RenderChain"),  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BMPAlloc"));
				}
				return r_MInit_RenderChain_BMPAlloc;
			}
		}

		/// <summary>
		/// NativeColorPage ToNativeColorPage()
		/// </summary>
		protected RMethod r_MToNativeColorPage;
		public virtual RMethod RMToNativeColorPage
		{
			get
			{
				if(r_MToNativeColorPage == null)
				{
					r_MToNativeColorPage = new(this, "ToNativeColorPage", 0);
				}
				return r_MToNativeColorPage;
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


        public RColorPage() : base("UnityEngine.UIElements.ColorPage")
        {
        }

        public RColorPage(System.Object instance) : base("UnityEngine.UIElements.ColorPage")
		{
            SetInstance(instance);
		}

        public RColorPage(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RColorPage(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RColorPage Init(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderChain @renderChain, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBMPAlloc @alloc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@renderChain.Value, @alloc.Value};
            var ___result = RMInit_RenderChain_BMPAlloc.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RColorPage(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RMeshBuilderNative.RNativeColorPage ToNativeColorPage()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToNativeColorPage.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RMeshBuilderNative.RNativeColorPage(___result);
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
