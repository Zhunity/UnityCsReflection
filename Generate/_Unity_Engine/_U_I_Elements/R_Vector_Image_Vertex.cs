
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.VectorImageVertex
	/// </summary>
    public partial class RVectorImageVertex : RMember //
    {

		/// <summary>
		/// UnityEngine.Vector3 position
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RVector3 r_Fposition;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RVector3 RFposition
		{
			get
			{
				if(r_Fposition == null)
				{
					r_Fposition = new(this, "position");
					r_Fposition.SetBelong(this.instance);
				}
				return r_Fposition;
			}
		}

		/// <summary>
		/// UnityEngine.Color32 tint
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RColor32 r_Ftint;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RColor32 RFtint
		{
			get
			{
				if(r_Ftint == null)
				{
					r_Ftint = new(this, "tint");
					r_Ftint.SetBelong(this.instance);
				}
				return r_Ftint;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 uv
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RVector2 r_Fuv;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RVector2 RFuv
		{
			get
			{
				if(r_Fuv == null)
				{
					r_Fuv = new(this, "uv");
					r_Fuv.SetBelong(this.instance);
				}
				return r_Fuv;
			}
		}

		/// <summary>
		/// System.UInt32 settingIndex
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RUInt32 r_FsettingIndex;
		public virtual SMFrame.Editor.Refleaction.RSystem.RUInt32 RFsettingIndex
		{
			get
			{
				if(r_FsettingIndex == null)
				{
					r_FsettingIndex = new(this, "settingIndex");
					r_FsettingIndex.SetBelong(this.instance);
				}
				return r_FsettingIndex;
			}
		}

		/// <summary>
		/// UnityEngine.Color32 flags
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RColor32 r_Fflags;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RColor32 RFflags
		{
			get
			{
				if(r_Fflags == null)
				{
					r_Fflags = new(this, "flags");
					r_Fflags.SetBelong(this.instance);
				}
				return r_Fflags;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 circle
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RVector4 r_Fcircle;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RVector4 RFcircle
		{
			get
			{
				if(r_Fcircle == null)
				{
					r_Fcircle = new(this, "circle");
					r_Fcircle.SetBelong(this.instance);
				}
				return r_Fcircle;
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


        public RVectorImageVertex() : base("UnityEngine.UIElements.VectorImageVertex")
        {
        }

        public RVectorImageVertex(System.Object instance) : base("UnityEngine.UIElements.VectorImageVertex")
		{
            SetInstance(instance);
		}

        public RVectorImageVertex(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RVectorImageVertex(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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