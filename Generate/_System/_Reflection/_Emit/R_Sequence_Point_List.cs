
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RReflection.REmit
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Reflection.Emit.SequencePointList
	/// </summary>
    public partial class RSequencePointList : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("System.Reflection.Emit.SequencePointList");
            }
        }

        public RSequencePointList() : base("System.Reflection.Emit.SequencePointList")
        {
        }

        public RSequencePointList(System.Object instance) : base("System.Reflection.Emit.SequencePointList")
		{
            SetInstance(instance);
		}

        public RSequencePointList(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSequencePointList(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Diagnostics.SymbolStore.ISymbolDocumentWriter doc
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RDiagnostics.RSymbolStore.RISymbolDocumentWriter r_Fdoc;
		public virtual Hvak.Editor.Refleaction.RSystem.RDiagnostics.RSymbolStore.RISymbolDocumentWriter RFdoc
		{
			get
			{
				if(r_Fdoc == null)
				{
					r_Fdoc = new(this, "doc");
				}
				return r_Fdoc;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.SequencePoint[] points
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RSequencePoint> r_Fpoints;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RSequencePoint> RFpoints
		{
			get
			{
				if(r_Fpoints == null)
				{
					r_Fpoints = new(this, "points");
				}
				return r_Fpoints;
			}
		}

		/// <summary>
		/// System.Int32 count
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fcount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFcount
		{
			get
			{
				if(r_Fcount == null)
				{
					r_Fcount = new(this, "count");
				}
				return r_Fcount;
			}
		}

		/// <summary>
		/// System.Int32 arrayGrow
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FarrayGrow;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFarrayGrow
		{
			get
			{
				if(r_FarrayGrow == null)
				{
					r_FarrayGrow = new(Type, "arrayGrow");
				}
				return r_FarrayGrow;
			}
		}

		/// <summary>
		/// System.Diagnostics.SymbolStore.ISymbolDocumentWriter Document
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RDiagnostics.RSymbolStore.RISymbolDocumentWriter r_PDocument;
		public virtual Hvak.Editor.Refleaction.RSystem.RDiagnostics.RSymbolStore.RISymbolDocumentWriter RPDocument
		{
			get
			{
				if(r_PDocument == null)
				{
					r_PDocument = new(this, "Document", -1);
				}
				return r_PDocument;
			}
		}

		/// <summary>
		/// Int32 StartLine
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PStartLine;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPStartLine
		{
			get
			{
				if(r_PStartLine == null)
				{
					r_PStartLine = new(this, "StartLine", -1);
				}
				return r_PStartLine;
			}
		}

		/// <summary>
		/// Int32 EndLine
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PEndLine;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPEndLine
		{
			get
			{
				if(r_PEndLine == null)
				{
					r_PEndLine = new(this, "EndLine", -1);
				}
				return r_PEndLine;
			}
		}

		/// <summary>
		/// Int32 StartColumn
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PStartColumn;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPStartColumn
		{
			get
			{
				if(r_PStartColumn == null)
				{
					r_PStartColumn = new(this, "StartColumn", -1);
				}
				return r_PStartColumn;
			}
		}

		/// <summary>
		/// Int32 EndColumn
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PEndColumn;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPEndColumn
		{
			get
			{
				if(r_PEndColumn == null)
				{
					r_PEndColumn = new(this, "EndColumn", -1);
				}
				return r_PEndColumn;
			}
		}

		/// <summary>
		/// Int32[] GetOffsets()
		/// </summary>
		protected RMethod r_MGetOffsets;
		public virtual RMethod RMGetOffsets
		{
			get
			{
				if(r_MGetOffsets == null)
				{
					r_MGetOffsets = new(this, "GetOffsets", 0);
				}
				return r_MGetOffsets;
			}
		}

		/// <summary>
		/// Int32[] GetLines()
		/// </summary>
		protected RMethod r_MGetLines;
		public virtual RMethod RMGetLines
		{
			get
			{
				if(r_MGetLines == null)
				{
					r_MGetLines = new(this, "GetLines", 0);
				}
				return r_MGetLines;
			}
		}

		/// <summary>
		/// Int32[] GetColumns()
		/// </summary>
		protected RMethod r_MGetColumns;
		public virtual RMethod RMGetColumns
		{
			get
			{
				if(r_MGetColumns == null)
				{
					r_MGetColumns = new(this, "GetColumns", 0);
				}
				return r_MGetColumns;
			}
		}

		/// <summary>
		/// Int32[] GetEndLines()
		/// </summary>
		protected RMethod r_MGetEndLines;
		public virtual RMethod RMGetEndLines
		{
			get
			{
				if(r_MGetEndLines == null)
				{
					r_MGetEndLines = new(this, "GetEndLines", 0);
				}
				return r_MGetEndLines;
			}
		}

		/// <summary>
		/// Int32[] GetEndColumns()
		/// </summary>
		protected RMethod r_MGetEndColumns;
		public virtual RMethod RMGetEndColumns
		{
			get
			{
				if(r_MGetEndColumns == null)
				{
					r_MGetEndColumns = new(this, "GetEndColumns", 0);
				}
				return r_MGetEndColumns;
			}
		}

		/// <summary>
		/// Void AddSequencePoint(Int32, Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MAddSequencePoint_Int32_Int32_Int32_Int32_Int32;
		public virtual RMethod RMAddSequencePoint_Int32_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_MAddSequencePoint_Int32_Int32_Int32_Int32_Int32 == null)
				{
					r_MAddSequencePoint_Int32_Int32_Int32_Int32_Int32 = new(this, "AddSequencePoint", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MAddSequencePoint_Int32_Int32_Int32_Int32_Int32;
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
				}
				return r_MToString;
			}
		}


        public virtual System.Int32[] GetOffsets()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetOffsets.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32[]>(___result);
        }


        public virtual System.Int32[] GetLines()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetLines.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32[]>(___result);
        }


        public virtual System.Int32[] GetColumns()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetColumns.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32[]>(___result);
        }


        public virtual System.Int32[] GetEndLines()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetEndLines.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32[]>(___result);
        }


        public virtual System.Int32[] GetEndColumns()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetEndColumns.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32[]>(___result);
        }


        public virtual void AddSequencePoint(System.Int32 @offset, System.Int32 @line, System.Int32 @col, System.Int32 @endLine, System.Int32 @endCol)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@offset, @line, @col, @endLine, @endCol};
            var ___result = RMAddSequencePoint_Int32_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


    }
}
