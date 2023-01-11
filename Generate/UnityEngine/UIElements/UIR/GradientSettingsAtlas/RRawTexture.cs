using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{public partial class RGradientSettingsAtlas
{
	
	/// <summary>
	/// UnityEngine.UIElements.UIR.GradientSettingsAtlas+RawTexture
	/// </summary>
    public partial class RRawTexture : RMember //
    {

		/// <summary>
		/// UnityEngine.Color32[] rgba
		/// </summary>
		protected RFieldArray<RUnityEngine.RColor32> r_rgba;
		public virtual RFieldArray<RUnityEngine.RColor32> Rrgba
		{
			get
			{
				if(r_rgba == null)
				{
					r_rgba = new(this, "rgba");
					r_rgba.SetBelong(this.instance);
				}
				return r_rgba;
			}
		}

		/// <summary>
		/// System.Int32 width
		/// </summary>
		protected RSystem.RInt32 r_width;
		public virtual RSystem.RInt32 Rwidth
		{
			get
			{
				if(r_width == null)
				{
					r_width = new(this, "width");
					r_width.SetBelong(this.instance);
				}
				return r_width;
			}
		}

		/// <summary>
		/// System.Int32 height
		/// </summary>
		protected RSystem.RInt32 r_height;
		public virtual RSystem.RInt32 Rheight
		{
			get
			{
				if(r_height == null)
				{
					r_height = new(this, "height");
					r_height.SetBelong(this.instance);
				}
				return r_height;
			}
		}

		/// <summary>
		/// Void WriteRawInt2Packed(Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_WriteRawInt2Packed_Int32_Int32_Int32_Int32;
		public virtual RMethod RWriteRawInt2Packed_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_WriteRawInt2Packed_Int32_Int32_Int32_Int32 == null)
				{
					r_WriteRawInt2Packed_Int32_Int32_Int32_Int32 = new(this, "WriteRawInt2Packed", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_WriteRawInt2Packed_Int32_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_WriteRawInt2Packed_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void WriteRawFloat4Packed(Single, Single, Single, Single, Int32, Int32)
		/// </summary>
		protected RMethod r_WriteRawFloat4Packed_Single_Single_Single_Single_Int32_Int32;
		public virtual RMethod RWriteRawFloat4Packed_Single_Single_Single_Single_Int32_Int32
		{
			get
			{
				if(r_WriteRawFloat4Packed_Single_Single_Single_Single_Int32_Int32 == null)
				{
					r_WriteRawFloat4Packed_Single_Single_Single_Single_Int32_Int32 = new(this, "WriteRawFloat4Packed", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Int32), typeof(System.Int32));
					r_WriteRawFloat4Packed_Single_Single_Single_Single_Int32_Int32.SetBelong(this.instance);
				}
				return r_WriteRawFloat4Packed_Single_Single_Single_Single_Int32_Int32;
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

        public virtual void WriteRawInt2Packed(System.Int32 @v0, System.Int32 @v1, System.Int32 @destX, System.Int32 @destY)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v0, @v1, @destX, @destY};
            var ___result = RWriteRawInt2Packed_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteRawFloat4Packed(System.Single @f0, System.Single @f1, System.Single @f2, System.Single @f3, System.Int32 @destX, System.Int32 @destY)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@f0, @f1, @f2, @f3, @destX, @destY};
            var ___result = RWriteRawFloat4Packed_Single_Single_Single_Single_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
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
}