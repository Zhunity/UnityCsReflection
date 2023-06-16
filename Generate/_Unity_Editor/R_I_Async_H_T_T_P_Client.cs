
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// UnityEditor.IAsyncHTTPClient
	/// </summary>
    public partial class RIAsyncHTTPClient : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.IAsyncHTTPClient");
            }
        }

        public RIAsyncHTTPClient() : base("UnityEditor.IAsyncHTTPClient")
        {
        }

        public RIAsyncHTTPClient(System.Object instance) : base("UnityEditor.IAsyncHTTPClient")
		{
            SetInstance(instance);
		}

        public RIAsyncHTTPClient(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIAsyncHTTPClient(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.String text
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Ptext;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPtext
		{
			get
			{
				if(r_Ptext == null)
				{
					r_Ptext = new(this, "text", -1);
				}
				return r_Ptext;
			}
		}

		/// <summary>
		/// Byte[] bytes
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RByte> r_Pbytes;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RByte> RPbytes
		{
			get
			{
				if(r_Pbytes == null)
				{
					r_Pbytes = new(this, "bytes", -1);
				}
				return r_Pbytes;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D texture
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTexture2D r_Ptexture;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTexture2D RPtexture
		{
			get
			{
				if(r_Ptexture == null)
				{
					r_Ptexture = new(this, "texture", -1);
				}
				return r_Ptexture;
			}
		}

		/// <summary>
		/// State state
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RAsyncHTTPClient.RState r_Pstate;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RAsyncHTTPClient.RState RPstate
		{
			get
			{
				if(r_Pstate == null)
				{
					r_Pstate = new(this, "state", -1);
				}
				return r_Pstate;
			}
		}

		/// <summary>
		/// Int32 responseCode
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PresponseCode;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPresponseCode
		{
			get
			{
				if(r_PresponseCode == null)
				{
					r_PresponseCode = new(this, "responseCode", -1);
				}
				return r_PresponseCode;
			}
		}

		/// <summary>
		/// System.String tag
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Ptag;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPtag
		{
			get
			{
				if(r_Ptag == null)
				{
					r_Ptag = new(this, "tag", -1);
				}
				return r_Ptag;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.String] header
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RString> r_Pheader;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RString> RPheader
		{
			get
			{
				if(r_Pheader == null)
				{
					r_Pheader = new(this, "header", -1);
				}
				return r_Pheader;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.String] responseHeader
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RString> r_PresponseHeader;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RString> RPresponseHeader
		{
			get
			{
				if(r_PresponseHeader == null)
				{
					r_PresponseHeader = new(this, "responseHeader", -1);
				}
				return r_PresponseHeader;
			}
		}

		/// <summary>
		/// System.String postData
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PpostData;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPpostData
		{
			get
			{
				if(r_PpostData == null)
				{
					r_PpostData = new(this, "postData", -1);
				}
				return r_PpostData;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.String] postDictionary
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RString> r_PpostDictionary;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RString> RPpostDictionary
		{
			get
			{
				if(r_PpostDictionary == null)
				{
					r_PpostDictionary = new(this, "postDictionary", -1);
				}
				return r_PpostDictionary;
			}
		}

		/// <summary>
		/// DoneCallback doneCallback
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RAsyncHTTPClient.RDoneCallback r_PdoneCallback;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RAsyncHTTPClient.RDoneCallback RPdoneCallback
		{
			get
			{
				if(r_PdoneCallback == null)
				{
					r_PdoneCallback = new(this, "doneCallback", -1);
				}
				return r_PdoneCallback;
			}
		}

		/// <summary>
		/// System.String url
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Purl;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPurl
		{
			get
			{
				if(r_Purl == null)
				{
					r_Purl = new(this, "url", -1);
				}
				return r_Purl;
			}
		}

		/// <summary>
		/// Void Abort()
		/// </summary>
		protected RMethod r_MAbort;
		public virtual RMethod RMAbort
		{
			get
			{
				if(r_MAbort == null)
				{
					r_MAbort = new(this, "Abort", 0);
				}
				return r_MAbort;
			}
		}

		/// <summary>
		/// Boolean IsAborted()
		/// </summary>
		protected RMethod r_MIsAborted;
		public virtual RMethod RMIsAborted
		{
			get
			{
				if(r_MIsAborted == null)
				{
					r_MIsAborted = new(this, "IsAborted", 0);
				}
				return r_MIsAborted;
			}
		}

		/// <summary>
		/// Boolean IsDone()
		/// </summary>
		protected RMethod r_MIsDone;
		public virtual RMethod RMIsDone
		{
			get
			{
				if(r_MIsDone == null)
				{
					r_MIsDone = new(this, "IsDone", 0);
				}
				return r_MIsDone;
			}
		}

		/// <summary>
		/// Boolean IsSuccess()
		/// </summary>
		protected RMethod r_MIsSuccess;
		public virtual RMethod RMIsSuccess
		{
			get
			{
				if(r_MIsSuccess == null)
				{
					r_MIsSuccess = new(this, "IsSuccess", 0);
				}
				return r_MIsSuccess;
			}
		}

		/// <summary>
		/// Void Begin()
		/// </summary>
		protected RMethod r_MBegin;
		public virtual RMethod RMBegin
		{
			get
			{
				if(r_MBegin == null)
				{
					r_MBegin = new(this, "Begin", 0);
				}
				return r_MBegin;
			}
		}


        public virtual void Abort()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAbort.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsAborted()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsAborted.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean IsDone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsDone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean IsSuccess()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsSuccess.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void Begin()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMBegin.Invoke(___genericsType, ___parameters);

            
        }


    }
}
