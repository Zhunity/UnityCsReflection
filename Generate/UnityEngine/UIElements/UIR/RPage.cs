using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{
	/// <summary>
	/// UnityEngine.UIElements.UIR.Page
	/// </summary>
    public partial class RPage : RMember //
    {

		/// <summary>
		/// System.Boolean <disposed>k__BackingField
		/// </summary>
		protected RSystem.RBoolean r_F__0__disposed__1__k__BackingField;
		public virtual RSystem.RBoolean RF__0__disposed__1__k__BackingField
		{
			get
			{
				if(r_F__0__disposed__1__k__BackingField == null)
				{
					r_F__0__disposed__1__k__BackingField = new(this, "<disposed>k__BackingField");
					r_F__0__disposed__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__disposed__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.Page+DataSet`1[UnityEngine.UIElements.Vertex] vertices
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RPage.RDataSet<RUnityEngine.RUIElements.RVertex> r_Fvertices;
		public virtual RUnityEngine.RUIElements.RUIR.RPage.RDataSet<RUnityEngine.RUIElements.RVertex> RFvertices
		{
			get
			{
				if(r_Fvertices == null)
				{
					r_Fvertices = new(this, "vertices");
					r_Fvertices.SetBelong(this.instance);
				}
				return r_Fvertices;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.Page+DataSet`1[System.UInt16] indices
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RPage.RDataSet<RSystem.RUInt16> r_Findices;
		public virtual RUnityEngine.RUIElements.RUIR.RPage.RDataSet<RSystem.RUInt16> RFindices
		{
			get
			{
				if(r_Findices == null)
				{
					r_Findices = new(this, "indices");
					r_Findices.SetBelong(this.instance);
				}
				return r_Findices;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.Page next
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RPage r_Fnext;
		public virtual RUnityEngine.RUIElements.RUIR.RPage RFnext
		{
			get
			{
				if(r_Fnext == null)
				{
					r_Fnext = new(this, "next");
					r_Fnext.SetBelong(this.instance);
				}
				return r_Fnext;
			}
		}

		/// <summary>
		/// System.Int32 framesEmpty
		/// </summary>
		protected RSystem.RInt32 r_FframesEmpty;
		public virtual RSystem.RInt32 RFframesEmpty
		{
			get
			{
				if(r_FframesEmpty == null)
				{
					r_FframesEmpty = new(this, "framesEmpty");
					r_FframesEmpty.SetBelong(this.instance);
				}
				return r_FframesEmpty;
			}
		}

		/// <summary>
		/// Boolean disposed
		/// </summary>
		protected RSystem.RBoolean r_Pdisposed;
		public virtual RSystem.RBoolean RPdisposed
		{
			get
			{
				if(r_Pdisposed == null)
				{
					r_Pdisposed = new(this, "disposed", -1);
					r_Pdisposed.SetBelong(this.instance);
				}
				return r_Pdisposed;
			}
		}

		/// <summary>
		/// Boolean isEmpty
		/// </summary>
		protected RSystem.RBoolean r_PisEmpty;
		public virtual RSystem.RBoolean RPisEmpty
		{
			get
			{
				if(r_PisEmpty == null)
				{
					r_PisEmpty = new(this, "isEmpty", -1);
					r_PisEmpty.SetBelong(this.instance);
				}
				return r_PisEmpty;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_MDispose;
		public virtual RMethod RMDispose
		{
			get
			{
				if(r_MDispose == null)
				{
					r_MDispose = new(this, "Dispose", 0);
					r_MDispose.SetBelong(this.instance);
				}
				return r_MDispose;
			}
		}

		/// <summary>
		/// Void Dispose(Boolean)
		/// </summary>
		protected RMethod r_MDispose_Boolean;
		public virtual RMethod RMDispose_Boolean
		{
			get
			{
				if(r_MDispose_Boolean == null)
				{
					r_MDispose_Boolean = new(this, "Dispose", 0, typeof(System.Boolean));
					r_MDispose_Boolean.SetBelong(this.instance);
				}
				return r_MDispose_Boolean;
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


        public RPage() : base("UnityEngine.UIElements.UIR.Page")
        {
        }

        public RPage(System.Object instance) : base("UnityEngine.UIElements.UIR.Page")
		{
            SetInstance(instance);
		}

        public RPage(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPage(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose(System.Boolean @disposing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@disposing};
            var ___result = RMDispose_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
