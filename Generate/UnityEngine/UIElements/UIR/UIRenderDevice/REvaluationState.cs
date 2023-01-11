using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
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
		protected RUnityEngine.RMaterialPropertyBlock r_stateMatProps;
		public virtual RUnityEngine.RMaterialPropertyBlock RstateMatProps
		{
			get
			{
				if(r_stateMatProps == null)
				{
					r_stateMatProps = new(this, "stateMatProps");
					r_stateMatProps.SetBelong(this.instance);
				}
				return r_stateMatProps;
			}
		}

		/// <summary>
		/// UnityEngine.Material defaultMat
		/// </summary>
		protected RUnityEngine.RMaterial r_defaultMat;
		public virtual RUnityEngine.RMaterial RdefaultMat
		{
			get
			{
				if(r_defaultMat == null)
				{
					r_defaultMat = new(this, "defaultMat");
					r_defaultMat.SetBelong(this.instance);
				}
				return r_defaultMat;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.State curState
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RState r_curState;
		public virtual RUnityEngine.RUIElements.RUIR.RState RcurState
		{
			get
			{
				if(r_curState == null)
				{
					r_curState = new(this, "curState");
					r_curState.SetBelong(this.instance);
				}
				return r_curState;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.Page curPage
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RPage r_curPage;
		public virtual RUnityEngine.RUIElements.RUIR.RPage RcurPage
		{
			get
			{
				if(r_curPage == null)
				{
					r_curPage = new(this, "curPage");
					r_curPage.SetBelong(this.instance);
				}
				return r_curPage;
			}
		}

		/// <summary>
		/// System.Boolean mustApplyMaterial
		/// </summary>
		protected RSystem.RBoolean r_mustApplyMaterial;
		public virtual RSystem.RBoolean RmustApplyMaterial
		{
			get
			{
				if(r_mustApplyMaterial == null)
				{
					r_mustApplyMaterial = new(this, "mustApplyMaterial");
					r_mustApplyMaterial.SetBelong(this.instance);
				}
				return r_mustApplyMaterial;
			}
		}

		/// <summary>
		/// System.Boolean mustApplyCommonBlock
		/// </summary>
		protected RSystem.RBoolean r_mustApplyCommonBlock;
		public virtual RSystem.RBoolean RmustApplyCommonBlock
		{
			get
			{
				if(r_mustApplyCommonBlock == null)
				{
					r_mustApplyCommonBlock = new(this, "mustApplyCommonBlock");
					r_mustApplyCommonBlock.SetBelong(this.instance);
				}
				return r_mustApplyCommonBlock;
			}
		}

		/// <summary>
		/// System.Boolean mustApplyStateBlock
		/// </summary>
		protected RSystem.RBoolean r_mustApplyStateBlock;
		public virtual RSystem.RBoolean RmustApplyStateBlock
		{
			get
			{
				if(r_mustApplyStateBlock == null)
				{
					r_mustApplyStateBlock = new(this, "mustApplyStateBlock");
					r_mustApplyStateBlock.SetBelong(this.instance);
				}
				return r_mustApplyStateBlock;
			}
		}

		/// <summary>
		/// System.Boolean mustApplyStencil
		/// </summary>
		protected RSystem.RBoolean r_mustApplyStencil;
		public virtual RSystem.RBoolean RmustApplyStencil
		{
			get
			{
				if(r_mustApplyStencil == null)
				{
					r_mustApplyStencil = new(this, "mustApplyStencil");
					r_mustApplyStencil.SetBelong(this.instance);
				}
				return r_mustApplyStencil;
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