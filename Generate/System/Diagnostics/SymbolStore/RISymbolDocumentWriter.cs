using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RDiagnostics.RSymbolStore
{
	/// <summary>
	/// System.Diagnostics.SymbolStore.ISymbolDocumentWriter
	/// </summary>
    public partial class RISymbolDocumentWriter : RMember //
    {

		/// <summary>
		/// Void SetCheckSum(System.Guid, Byte[])
		/// </summary>
		protected RMethod r_RSetCheckSum_Guid_ByteArray;
		public virtual RMethod RSetCheckSum_Guid_ByteArray
		{
			get
			{
				if(r_RSetCheckSum_Guid_ByteArray == null)
				{
					r_RSetCheckSum_Guid_ByteArray = new(this, "SetCheckSum", 0, typeof(System.Guid), typeof(System.Byte).MakeArrayType());
					r_RSetCheckSum_Guid_ByteArray.SetBelong(this.instance);
				}
				return r_RSetCheckSum_Guid_ByteArray;
			}
		}

		/// <summary>
		/// Void SetSource(Byte[])
		/// </summary>
		protected RMethod r_RSetSource_ByteArray;
		public virtual RMethod RSetSource_ByteArray
		{
			get
			{
				if(r_RSetSource_ByteArray == null)
				{
					r_RSetSource_ByteArray = new(this, "SetSource", 0, typeof(System.Byte).MakeArrayType());
					r_RSetSource_ByteArray.SetBelong(this.instance);
				}
				return r_RSetSource_ByteArray;
			}
		}


        public RISymbolDocumentWriter() : base("System.Diagnostics.SymbolStore.ISymbolDocumentWriter")
        {
        }

        public RISymbolDocumentWriter(System.Object instance) : base("System.Diagnostics.SymbolStore.ISymbolDocumentWriter")
		{
            SetInstance(instance);
		}

        public RISymbolDocumentWriter(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RISymbolDocumentWriter(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void SetCheckSum(System.Guid  @algorithmId, System.Byte[]  @checkSum)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@algorithmId, @checkSum};
            var ___result = RSetCheckSum_Guid_ByteArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetSource(System.Byte[]  @source)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source};
            var ___result = RSetSource_ByteArray.Invoke(___genericsType, ___parameters);

            
        }


    }
}
