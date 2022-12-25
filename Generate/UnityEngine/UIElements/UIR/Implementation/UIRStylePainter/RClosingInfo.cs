using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RImplementation
{public partial class RUIRStylePainter
{
	
	/// <summary>
	/// UnityEngine.UIElements.UIR.Implementation.UIRStylePainter+ClosingInfo
	/// </summary>
    public partial class RClosingInfo : RMember //
    {

		/// <summary>
		/// System.Boolean needsClosing
		/// </summary>
		protected RField r_needsClosing;
		public virtual RField RneedsClosing
		{
			get
			{
				if(r_needsClosing == null)
				{
					r_needsClosing = new(this, "needsClosing");
					r_needsClosing.SetBelong(this.instance);
				}
				return r_needsClosing;
			}
		}

		/// <summary>
		/// System.Boolean popViewMatrix
		/// </summary>
		protected RField r_popViewMatrix;
		public virtual RField RpopViewMatrix
		{
			get
			{
				if(r_popViewMatrix == null)
				{
					r_popViewMatrix = new(this, "popViewMatrix");
					r_popViewMatrix.SetBelong(this.instance);
				}
				return r_popViewMatrix;
			}
		}

		/// <summary>
		/// System.Boolean popScissorClip
		/// </summary>
		protected RField r_popScissorClip;
		public virtual RField RpopScissorClip
		{
			get
			{
				if(r_popScissorClip == null)
				{
					r_popScissorClip = new(this, "popScissorClip");
					r_popScissorClip.SetBelong(this.instance);
				}
				return r_popScissorClip;
			}
		}

		/// <summary>
		/// System.Boolean blitAndPopRenderTexture
		/// </summary>
		protected RField r_blitAndPopRenderTexture;
		public virtual RField RblitAndPopRenderTexture
		{
			get
			{
				if(r_blitAndPopRenderTexture == null)
				{
					r_blitAndPopRenderTexture = new(this, "blitAndPopRenderTexture");
					r_blitAndPopRenderTexture.SetBelong(this.instance);
				}
				return r_blitAndPopRenderTexture;
			}
		}

		/// <summary>
		/// System.Boolean PopDefaultMaterial
		/// </summary>
		protected RField r_PopDefaultMaterial;
		public virtual RField RPopDefaultMaterial
		{
			get
			{
				if(r_PopDefaultMaterial == null)
				{
					r_PopDefaultMaterial = new(this, "PopDefaultMaterial");
					r_PopDefaultMaterial.SetBelong(this.instance);
				}
				return r_PopDefaultMaterial;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.RenderChainCommand clipUnregisterDrawCommand
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RRenderChainCommand r_clipUnregisterDrawCommand;
		public virtual RUnityEngine.RUIElements.RUIR.RRenderChainCommand RclipUnregisterDrawCommand
		{
			get
			{
				if(r_clipUnregisterDrawCommand == null)
				{
					r_clipUnregisterDrawCommand = new(this, "clipUnregisterDrawCommand");
					r_clipUnregisterDrawCommand.SetBelong(this.instance);
				}
				return r_clipUnregisterDrawCommand;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeSlice`1[UnityEngine.UIElements.Vertex] clipperRegisterVertices
		/// </summary>
		protected RField r_clipperRegisterVertices;
		public virtual RField RclipperRegisterVertices
		{
			get
			{
				if(r_clipperRegisterVertices == null)
				{
					r_clipperRegisterVertices = new(this, "clipperRegisterVertices");
					r_clipperRegisterVertices.SetBelong(this.instance);
				}
				return r_clipperRegisterVertices;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeSlice`1[System.UInt16] clipperRegisterIndices
		/// </summary>
		protected RField r_clipperRegisterIndices;
		public virtual RField RclipperRegisterIndices
		{
			get
			{
				if(r_clipperRegisterIndices == null)
				{
					r_clipperRegisterIndices = new(this, "clipperRegisterIndices");
					r_clipperRegisterIndices.SetBelong(this.instance);
				}
				return r_clipperRegisterIndices;
			}
		}

		/// <summary>
		/// System.Int32 clipperRegisterIndexOffset
		/// </summary>
		protected RField r_clipperRegisterIndexOffset;
		public virtual RField RclipperRegisterIndexOffset
		{
			get
			{
				if(r_clipperRegisterIndexOffset == null)
				{
					r_clipperRegisterIndexOffset = new(this, "clipperRegisterIndexOffset");
					r_clipperRegisterIndexOffset.SetBelong(this.instance);
				}
				return r_clipperRegisterIndexOffset;
			}
		}

		/// <summary>
		/// System.Int32 maskStencilRef
		/// </summary>
		protected RField r_maskStencilRef;
		public virtual RField RmaskStencilRef
		{
			get
			{
				if(r_maskStencilRef == null)
				{
					r_maskStencilRef = new(this, "maskStencilRef");
					r_maskStencilRef.SetBelong(this.instance);
				}
				return r_maskStencilRef;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_REquals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_REquals_Object == null)
				{
					r_REquals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_REquals_Object.SetBelong(this.instance);
				}
				return r_REquals_Object;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_RGetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_RGetHashCode == null)
				{
					r_RGetHashCode = new(this, "GetHashCode", 0);
					r_RGetHashCode.SetBelong(this.instance);
				}
				return r_RGetHashCode;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_RToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_RToString == null)
				{
					r_RToString = new(this, "ToString", 0);
					r_RToString.SetBelong(this.instance);
				}
				return r_RToString;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_RFinalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_RFinalize == null)
				{
					r_RFinalize = new(this, "Finalize", 0);
					r_RFinalize.SetBelong(this.instance);
				}
				return r_RFinalize;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_RGetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_RGetType == null)
				{
					r_RGetType = new(this, "GetType", 0);
					r_RGetType.SetBelong(this.instance);
				}
				return r_RGetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_RMemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_RMemberwiseClone == null)
				{
					r_RMemberwiseClone = new(this, "MemberwiseClone", 0);
					r_RMemberwiseClone.SetBelong(this.instance);
				}
				return r_RMemberwiseClone;
			}
		}


        public RClosingInfo() : base("UnityEngine.UIElements.UIR.Implementation.UIRStylePainter+ClosingInfo")
        {
        }

        public RClosingInfo(System.Object instance) : base("UnityEngine.UIElements.UIR.Implementation.UIRStylePainter+ClosingInfo")
		{
            SetInstance(instance);
		}

        public RClosingInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RClosingInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Equals(System.Object  @obj)
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