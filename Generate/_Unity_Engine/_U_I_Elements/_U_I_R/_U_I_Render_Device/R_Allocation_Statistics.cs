
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{public partial class RUIRenderDevice
{
	
	/// <summary>
	/// UnityEngine.UIElements.UIR.UIRenderDevice+AllocationStatistics
	/// </summary>
    public partial class RAllocationStatistics : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.UIR.UIRenderDevice+AllocationStatistics+PageStatistics[] pages
		/// </summary>
		protected SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RUIRenderDevice.RAllocationStatistics.RPageStatistics> r_Fpages;
		public virtual SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RUIRenderDevice.RAllocationStatistics.RPageStatistics> RFpages
		{
			get
			{
				if(r_Fpages == null)
				{
					r_Fpages = new(this, "pages");
					r_Fpages.SetBelong(this.instance);
				}
				return r_Fpages;
			}
		}

		/// <summary>
		/// System.Int32[] freesDeferred
		/// </summary>
		protected SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RInt32> r_FfreesDeferred;
		public virtual SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RInt32> RFfreesDeferred
		{
			get
			{
				if(r_FfreesDeferred == null)
				{
					r_FfreesDeferred = new(this, "freesDeferred");
					r_FfreesDeferred.SetBelong(this.instance);
				}
				return r_FfreesDeferred;
			}
		}

		/// <summary>
		/// System.Boolean completeInit
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_FcompleteInit;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RFcompleteInit
		{
			get
			{
				if(r_FcompleteInit == null)
				{
					r_FcompleteInit = new(this, "completeInit");
					r_FcompleteInit.SetBelong(this.instance);
				}
				return r_FcompleteInit;
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


        public RAllocationStatistics() : base("UnityEngine.UIElements.UIR.UIRenderDevice+AllocationStatistics")
        {
        }

        public RAllocationStatistics(System.Object instance) : base("UnityEngine.UIElements.UIR.UIRenderDevice+AllocationStatistics")
		{
            SetInstance(instance);
		}

        public RAllocationStatistics(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAllocationStatistics(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
}