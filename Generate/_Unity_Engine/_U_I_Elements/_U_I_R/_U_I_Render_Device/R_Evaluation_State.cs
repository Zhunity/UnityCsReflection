
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{public partial class RUIRenderDevice
{
	
	/// <summary>
	/// UnityEngine.UIElements.UIR.UIRenderDevice+EvaluationState
	/// </summary>
    public partial class REvaluationState : RMember //
    {

		/// <summary>
		/// UnityEngine.MaterialPropertyBlock stateMatProps
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RMaterialPropertyBlock r_FstateMatProps;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RMaterialPropertyBlock RFstateMatProps
		{
			get
			{
				if(r_FstateMatProps == null)
				{
					r_FstateMatProps = new(this, "stateMatProps");
					r_FstateMatProps.SetBelong(this.instance);
				}
				return r_FstateMatProps;
			}
		}

		/// <summary>
		/// UnityEngine.Material defaultMat
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RMaterial r_FdefaultMat;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RMaterial RFdefaultMat
		{
			get
			{
				if(r_FdefaultMat == null)
				{
					r_FdefaultMat = new(this, "defaultMat");
					r_FdefaultMat.SetBelong(this.instance);
				}
				return r_FdefaultMat;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.State curState
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RState r_FcurState;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RState RFcurState
		{
			get
			{
				if(r_FcurState == null)
				{
					r_FcurState = new(this, "curState");
					r_FcurState.SetBelong(this.instance);
				}
				return r_FcurState;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.Page curPage
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RPage r_FcurPage;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RPage RFcurPage
		{
			get
			{
				if(r_FcurPage == null)
				{
					r_FcurPage = new(this, "curPage");
					r_FcurPage.SetBelong(this.instance);
				}
				return r_FcurPage;
			}
		}

		/// <summary>
		/// System.Boolean mustApplyMaterial
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FmustApplyMaterial;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFmustApplyMaterial
		{
			get
			{
				if(r_FmustApplyMaterial == null)
				{
					r_FmustApplyMaterial = new(this, "mustApplyMaterial");
					r_FmustApplyMaterial.SetBelong(this.instance);
				}
				return r_FmustApplyMaterial;
			}
		}

		/// <summary>
		/// System.Boolean mustApplyCommonBlock
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FmustApplyCommonBlock;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFmustApplyCommonBlock
		{
			get
			{
				if(r_FmustApplyCommonBlock == null)
				{
					r_FmustApplyCommonBlock = new(this, "mustApplyCommonBlock");
					r_FmustApplyCommonBlock.SetBelong(this.instance);
				}
				return r_FmustApplyCommonBlock;
			}
		}

		/// <summary>
		/// System.Boolean mustApplyStateBlock
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FmustApplyStateBlock;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFmustApplyStateBlock
		{
			get
			{
				if(r_FmustApplyStateBlock == null)
				{
					r_FmustApplyStateBlock = new(this, "mustApplyStateBlock");
					r_FmustApplyStateBlock.SetBelong(this.instance);
				}
				return r_FmustApplyStateBlock;
			}
		}

		/// <summary>
		/// System.Boolean mustApplyStencil
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FmustApplyStencil;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFmustApplyStencil
		{
			get
			{
				if(r_FmustApplyStencil == null)
				{
					r_FmustApplyStencil = new(this, "mustApplyStencil");
					r_FmustApplyStencil.SetBelong(this.instance);
				}
				return r_FmustApplyStencil;
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


        public REvaluationState() : base("UnityEngine.UIElements.UIR.UIRenderDevice+EvaluationState")
        {
        }

        public REvaluationState(System.Object instance) : base("UnityEngine.UIElements.UIR.UIRenderDevice+EvaluationState")
		{
            SetInstance(instance);
		}

        public REvaluationState(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public REvaluationState(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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