
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{public partial class RGradientSettingsAtlas
{
	
	/// <summary>
	/// UnityEngine.UIElements.UIR.GradientSettingsAtlas+RawTexture
	/// </summary>
    public partial class RRawTexture : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.GradientSettingsAtlas+RawTexture");
            }
        }

        public RRawTexture() : base("UnityEngine.UIElements.UIR.GradientSettingsAtlas+RawTexture")
        {
        }

        public RRawTexture(System.Object instance) : base("UnityEngine.UIElements.UIR.GradientSettingsAtlas+RawTexture")
		{
            SetInstance(instance);
		}

        public RRawTexture(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRawTexture(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// UnityEngine.Color32[] rgba
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RColor32> r_Frgba;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RColor32> RFrgba
		{
			get
			{
				if(r_Frgba == null)
				{
					r_Frgba = new(this, "rgba");
				}
				return r_Frgba;
			}
		}

		/// <summary>
		/// System.Int32 width
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fwidth;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFwidth
		{
			get
			{
				if(r_Fwidth == null)
				{
					r_Fwidth = new(this, "width");
				}
				return r_Fwidth;
			}
		}

		/// <summary>
		/// System.Int32 height
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fheight;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFheight
		{
			get
			{
				if(r_Fheight == null)
				{
					r_Fheight = new(this, "height");
				}
				return r_Fheight;
			}
		}

		/// <summary>
		/// Void WriteRawInt2Packed(Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MWriteRawInt2Packed_Int32_Int32_Int32_Int32;
		public virtual RMethod RMWriteRawInt2Packed_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_MWriteRawInt2Packed_Int32_Int32_Int32_Int32 == null)
				{
					r_MWriteRawInt2Packed_Int32_Int32_Int32_Int32 = new(this, "WriteRawInt2Packed", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MWriteRawInt2Packed_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void WriteRawFloat4Packed(Single, Single, Single, Single, Int32, Int32)
		/// </summary>
		protected RMethod r_MWriteRawFloat4Packed_Single_Single_Single_Single_Int32_Int32;
		public virtual RMethod RMWriteRawFloat4Packed_Single_Single_Single_Single_Int32_Int32
		{
			get
			{
				if(r_MWriteRawFloat4Packed_Single_Single_Single_Single_Int32_Int32 == null)
				{
					r_MWriteRawFloat4Packed_Single_Single_Single_Single_Int32_Int32 = new(this, "WriteRawFloat4Packed", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MWriteRawFloat4Packed_Single_Single_Single_Single_Int32_Int32;
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


        public virtual void WriteRawInt2Packed(System.Int32 @v0, System.Int32 @v1, System.Int32 @destX, System.Int32 @destY)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v0, @v1, @destX, @destY};
            var ___result = RMWriteRawInt2Packed_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteRawFloat4Packed(System.Single @f0, System.Single @f1, System.Single @f2, System.Single @f3, System.Int32 @destX, System.Int32 @destY)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@f0, @f1, @f2, @f3, @destX, @destY};
            var ___result = RMWriteRawFloat4Packed_Single_Single_Single_Single_Int32_Int32.Invoke(___genericsType, ___parameters);

            
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
}