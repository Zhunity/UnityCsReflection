using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{
	/// <summary>
	/// UnityEngine.UIElements.UIR.ConvertMeshJobData
	/// </summary>
    public partial class RConvertMeshJobData : RMember //
    {

		/// <summary>
		/// System.IntPtr vertSrc
		/// </summary>
		protected RSystem.RIntPtr r_FvertSrc;
		public virtual RSystem.RIntPtr RFvertSrc
		{
			get
			{
				if(r_FvertSrc == null)
				{
					r_FvertSrc = new(this, "vertSrc");
					r_FvertSrc.SetBelong(this.instance);
				}
				return r_FvertSrc;
			}
		}

		/// <summary>
		/// System.IntPtr vertDst
		/// </summary>
		protected RSystem.RIntPtr r_FvertDst;
		public virtual RSystem.RIntPtr RFvertDst
		{
			get
			{
				if(r_FvertDst == null)
				{
					r_FvertDst = new(this, "vertDst");
					r_FvertDst.SetBelong(this.instance);
				}
				return r_FvertDst;
			}
		}

		/// <summary>
		/// System.Int32 vertCount
		/// </summary>
		protected RSystem.RInt32 r_FvertCount;
		public virtual RSystem.RInt32 RFvertCount
		{
			get
			{
				if(r_FvertCount == null)
				{
					r_FvertCount = new(this, "vertCount");
					r_FvertCount.SetBelong(this.instance);
				}
				return r_FvertCount;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 transform
		/// </summary>
		protected RUnityEngine.RMatrix4x4 r_Ftransform;
		public virtual RUnityEngine.RMatrix4x4 RFtransform
		{
			get
			{
				if(r_Ftransform == null)
				{
					r_Ftransform = new(this, "transform");
					r_Ftransform.SetBelong(this.instance);
				}
				return r_Ftransform;
			}
		}

		/// <summary>
		/// System.Int32 transformUVs
		/// </summary>
		protected RSystem.RInt32 r_FtransformUVs;
		public virtual RSystem.RInt32 RFtransformUVs
		{
			get
			{
				if(r_FtransformUVs == null)
				{
					r_FtransformUVs = new(this, "transformUVs");
					r_FtransformUVs.SetBelong(this.instance);
				}
				return r_FtransformUVs;
			}
		}

		/// <summary>
		/// UnityEngine.Color32 xformClipPages
		/// </summary>
		protected RUnityEngine.RColor32 r_FxformClipPages;
		public virtual RUnityEngine.RColor32 RFxformClipPages
		{
			get
			{
				if(r_FxformClipPages == null)
				{
					r_FxformClipPages = new(this, "xformClipPages");
					r_FxformClipPages.SetBelong(this.instance);
				}
				return r_FxformClipPages;
			}
		}

		/// <summary>
		/// UnityEngine.Color32 ids
		/// </summary>
		protected RUnityEngine.RColor32 r_Fids;
		public virtual RUnityEngine.RColor32 RFids
		{
			get
			{
				if(r_Fids == null)
				{
					r_Fids = new(this, "ids");
					r_Fids.SetBelong(this.instance);
				}
				return r_Fids;
			}
		}

		/// <summary>
		/// UnityEngine.Color32 addFlags
		/// </summary>
		protected RUnityEngine.RColor32 r_FaddFlags;
		public virtual RUnityEngine.RColor32 RFaddFlags
		{
			get
			{
				if(r_FaddFlags == null)
				{
					r_FaddFlags = new(this, "addFlags");
					r_FaddFlags.SetBelong(this.instance);
				}
				return r_FaddFlags;
			}
		}

		/// <summary>
		/// UnityEngine.Color32 opacityPage
		/// </summary>
		protected RUnityEngine.RColor32 r_FopacityPage;
		public virtual RUnityEngine.RColor32 RFopacityPage
		{
			get
			{
				if(r_FopacityPage == null)
				{
					r_FopacityPage = new(this, "opacityPage");
					r_FopacityPage.SetBelong(this.instance);
				}
				return r_FopacityPage;
			}
		}

		/// <summary>
		/// UnityEngine.Color32 textCoreSettingsPage
		/// </summary>
		protected RUnityEngine.RColor32 r_FtextCoreSettingsPage;
		public virtual RUnityEngine.RColor32 RFtextCoreSettingsPage
		{
			get
			{
				if(r_FtextCoreSettingsPage == null)
				{
					r_FtextCoreSettingsPage = new(this, "textCoreSettingsPage");
					r_FtextCoreSettingsPage.SetBelong(this.instance);
				}
				return r_FtextCoreSettingsPage;
			}
		}

		/// <summary>
		/// System.Int32 isText
		/// </summary>
		protected RSystem.RInt32 r_FisText;
		public virtual RSystem.RInt32 RFisText
		{
			get
			{
				if(r_FisText == null)
				{
					r_FisText = new(this, "isText");
					r_FisText.SetBelong(this.instance);
				}
				return r_FisText;
			}
		}

		/// <summary>
		/// System.Single textureId
		/// </summary>
		protected RSystem.RSingle r_FtextureId;
		public virtual RSystem.RSingle RFtextureId
		{
			get
			{
				if(r_FtextureId == null)
				{
					r_FtextureId = new(this, "textureId");
					r_FtextureId.SetBelong(this.instance);
				}
				return r_FtextureId;
			}
		}

		/// <summary>
		/// System.IntPtr indexSrc
		/// </summary>
		protected RSystem.RIntPtr r_FindexSrc;
		public virtual RSystem.RIntPtr RFindexSrc
		{
			get
			{
				if(r_FindexSrc == null)
				{
					r_FindexSrc = new(this, "indexSrc");
					r_FindexSrc.SetBelong(this.instance);
				}
				return r_FindexSrc;
			}
		}

		/// <summary>
		/// System.IntPtr indexDst
		/// </summary>
		protected RSystem.RIntPtr r_FindexDst;
		public virtual RSystem.RIntPtr RFindexDst
		{
			get
			{
				if(r_FindexDst == null)
				{
					r_FindexDst = new(this, "indexDst");
					r_FindexDst.SetBelong(this.instance);
				}
				return r_FindexDst;
			}
		}

		/// <summary>
		/// System.Int32 indexCount
		/// </summary>
		protected RSystem.RInt32 r_FindexCount;
		public virtual RSystem.RInt32 RFindexCount
		{
			get
			{
				if(r_FindexCount == null)
				{
					r_FindexCount = new(this, "indexCount");
					r_FindexCount.SetBelong(this.instance);
				}
				return r_FindexCount;
			}
		}

		/// <summary>
		/// System.Int32 indexOffset
		/// </summary>
		protected RSystem.RInt32 r_FindexOffset;
		public virtual RSystem.RInt32 RFindexOffset
		{
			get
			{
				if(r_FindexOffset == null)
				{
					r_FindexOffset = new(this, "indexOffset");
					r_FindexOffset.SetBelong(this.instance);
				}
				return r_FindexOffset;
			}
		}

		/// <summary>
		/// System.Int32 flipIndices
		/// </summary>
		protected RSystem.RInt32 r_FflipIndices;
		public virtual RSystem.RInt32 RFflipIndices
		{
			get
			{
				if(r_FflipIndices == null)
				{
					r_FflipIndices = new(this, "flipIndices");
					r_FflipIndices.SetBelong(this.instance);
				}
				return r_FflipIndices;
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


        public RConvertMeshJobData() : base("UnityEngine.UIElements.UIR.ConvertMeshJobData")
        {
        }

        public RConvertMeshJobData(System.Object instance) : base("UnityEngine.UIElements.UIR.ConvertMeshJobData")
		{
            SetInstance(instance);
		}

        public RConvertMeshJobData(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RConvertMeshJobData(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
