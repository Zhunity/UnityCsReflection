
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RImplementation
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
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FneedsClosing;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFneedsClosing
		{
			get
			{
				if(r_FneedsClosing == null)
				{
					r_FneedsClosing = new(this, "needsClosing");
					r_FneedsClosing.SetBelong(this.instance);
				}
				return r_FneedsClosing;
			}
		}

		/// <summary>
		/// System.Boolean popViewMatrix
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FpopViewMatrix;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFpopViewMatrix
		{
			get
			{
				if(r_FpopViewMatrix == null)
				{
					r_FpopViewMatrix = new(this, "popViewMatrix");
					r_FpopViewMatrix.SetBelong(this.instance);
				}
				return r_FpopViewMatrix;
			}
		}

		/// <summary>
		/// System.Boolean popScissorClip
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FpopScissorClip;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFpopScissorClip
		{
			get
			{
				if(r_FpopScissorClip == null)
				{
					r_FpopScissorClip = new(this, "popScissorClip");
					r_FpopScissorClip.SetBelong(this.instance);
				}
				return r_FpopScissorClip;
			}
		}

		/// <summary>
		/// System.Boolean blitAndPopRenderTexture
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FblitAndPopRenderTexture;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFblitAndPopRenderTexture
		{
			get
			{
				if(r_FblitAndPopRenderTexture == null)
				{
					r_FblitAndPopRenderTexture = new(this, "blitAndPopRenderTexture");
					r_FblitAndPopRenderTexture.SetBelong(this.instance);
				}
				return r_FblitAndPopRenderTexture;
			}
		}

		/// <summary>
		/// System.Boolean PopDefaultMaterial
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FPopDefaultMaterial;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFPopDefaultMaterial
		{
			get
			{
				if(r_FPopDefaultMaterial == null)
				{
					r_FPopDefaultMaterial = new(this, "PopDefaultMaterial");
					r_FPopDefaultMaterial.SetBelong(this.instance);
				}
				return r_FPopDefaultMaterial;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.RenderChainCommand clipUnregisterDrawCommand
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderChainCommand r_FclipUnregisterDrawCommand;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderChainCommand RFclipUnregisterDrawCommand
		{
			get
			{
				if(r_FclipUnregisterDrawCommand == null)
				{
					r_FclipUnregisterDrawCommand = new(this, "clipUnregisterDrawCommand");
					r_FclipUnregisterDrawCommand.SetBelong(this.instance);
				}
				return r_FclipUnregisterDrawCommand;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeSlice`1[UnityEngine.UIElements.Vertex] clipperRegisterVertices
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVertex> r_FclipperRegisterVertices;
		public virtual Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVertex> RFclipperRegisterVertices
		{
			get
			{
				if(r_FclipperRegisterVertices == null)
				{
					r_FclipperRegisterVertices = new(this, "clipperRegisterVertices");
					r_FclipperRegisterVertices.SetBelong(this.instance);
				}
				return r_FclipperRegisterVertices;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeSlice`1[System.UInt16] clipperRegisterIndices
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RSystem.RUInt16> r_FclipperRegisterIndices;
		public virtual Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RSystem.RUInt16> RFclipperRegisterIndices
		{
			get
			{
				if(r_FclipperRegisterIndices == null)
				{
					r_FclipperRegisterIndices = new(this, "clipperRegisterIndices");
					r_FclipperRegisterIndices.SetBelong(this.instance);
				}
				return r_FclipperRegisterIndices;
			}
		}

		/// <summary>
		/// System.Int32 clipperRegisterIndexOffset
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FclipperRegisterIndexOffset;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFclipperRegisterIndexOffset
		{
			get
			{
				if(r_FclipperRegisterIndexOffset == null)
				{
					r_FclipperRegisterIndexOffset = new(this, "clipperRegisterIndexOffset");
					r_FclipperRegisterIndexOffset.SetBelong(this.instance);
				}
				return r_FclipperRegisterIndexOffset;
			}
		}

		/// <summary>
		/// System.Int32 maskStencilRef
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FmaskStencilRef;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFmaskStencilRef
		{
			get
			{
				if(r_FmaskStencilRef == null)
				{
					r_FmaskStencilRef = new(this, "maskStencilRef");
					r_FmaskStencilRef.SetBelong(this.instance);
				}
				return r_FmaskStencilRef;
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