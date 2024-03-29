
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RDiagnostics.RSymbolStore
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Diagnostics.SymbolStore.ISymbolDocumentWriter
	/// </summary>
    public partial class RISymbolDocumentWriter : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Diagnostics.SymbolStore.ISymbolDocumentWriter);
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


		/// <summary>
		/// Void SetCheckSum(System.Guid, Byte[])
		/// </summary>
		protected RMethod r_MSetCheckSum_Guid_ByteArray;
		public virtual RMethod RMSetCheckSum_Guid_ByteArray
		{
			get
			{
				if(r_MSetCheckSum_Guid_ByteArray == null)
				{
					r_MSetCheckSum_Guid_ByteArray = new(this, "SetCheckSum", 0, typeof(System.Guid), typeof(System.Byte).MakeArrayType());
				}
				return r_MSetCheckSum_Guid_ByteArray;
			}
		}

		/// <summary>
		/// Void SetSource(Byte[])
		/// </summary>
		protected RMethod r_MSetSource_ByteArray;
		public virtual RMethod RMSetSource_ByteArray
		{
			get
			{
				if(r_MSetSource_ByteArray == null)
				{
					r_MSetSource_ByteArray = new(this, "SetSource", 0, typeof(System.Byte).MakeArrayType());
				}
				return r_MSetSource_ByteArray;
			}
		}


        public virtual void SetCheckSum(System.Guid @algorithmId, System.Byte[] @checkSum)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@algorithmId, @checkSum};
            var ___result = RMSetCheckSum_Guid_ByteArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetSource(System.Byte[] @source)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source};
            var ___result = RMSetSource_ByteArray.Invoke(___genericsType, ___parameters);

            
        }


    }
}
