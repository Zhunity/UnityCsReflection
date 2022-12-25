using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RReflection.REmit
{
	/// <summary>
	/// System.Reflection.Emit.SequencePointList
	/// </summary>
    public partial class RSequencePointList : RMember //
    {

		/// <summary>
		/// System.Diagnostics.SymbolStore.ISymbolDocumentWriter doc
		/// </summary>
		protected RSystem.RDiagnostics.RSymbolStore.RISymbolDocumentWriter r_doc;
		public virtual RSystem.RDiagnostics.RSymbolStore.RISymbolDocumentWriter Rdoc
		{
			get
			{
				if(r_doc == null)
				{
					r_doc = new(this, "doc");
					r_doc.SetBelong(this.instance);
				}
				return r_doc;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.SequencePoint[] points
		/// </summary>
		protected RFieldArray<RSystem.RReflection.REmit.RSequencePoint> r_points;
		public virtual RFieldArray<RSystem.RReflection.REmit.RSequencePoint> Rpoints
		{
			get
			{
				if(r_points == null)
				{
					r_points = new(this, "points");
					r_points.SetBelong(this.instance);
				}
				return r_points;
			}
		}

		/// <summary>
		/// System.Int32 count
		/// </summary>
		protected RField r_count;
		public virtual RField Rcount
		{
			get
			{
				if(r_count == null)
				{
					r_count = new(this, "count");
					r_count.SetBelong(this.instance);
				}
				return r_count;
			}
		}

		/// <summary>
		/// System.Int32 arrayGrow
		/// </summary>
		protected static RField r_arrayGrow;
		public static RField RarrayGrow
		{
			get
			{
				if(r_arrayGrow == null)
				{
					r_arrayGrow = new( ReleactionUtils.GetType("System.Reflection.Emit.SequencePointList"), "arrayGrow");
					r_arrayGrow.SetBelong(null);
				}
				return r_arrayGrow;
			}
		}

		/// <summary>
		/// System.Diagnostics.SymbolStore.ISymbolDocumentWriter Document
		/// </summary>
		protected RSystem.RDiagnostics.RSymbolStore.RISymbolDocumentWriter r_Document;
		public virtual RSystem.RDiagnostics.RSymbolStore.RISymbolDocumentWriter RDocument
		{
			get
			{
				if(r_Document == null)
				{
					r_Document = new(this, "Document", -1);
					r_Document.SetBelong(this.instance);
				}
				return r_Document;
			}
		}

		/// <summary>
		/// Int32 StartLine
		/// </summary>
		protected RProperty r_StartLine;
		public virtual RProperty RStartLine
		{
			get
			{
				if(r_StartLine == null)
				{
					r_StartLine = new(this, "StartLine", -1);
					r_StartLine.SetBelong(this.instance);
				}
				return r_StartLine;
			}
		}

		/// <summary>
		/// Int32 EndLine
		/// </summary>
		protected RProperty r_EndLine;
		public virtual RProperty REndLine
		{
			get
			{
				if(r_EndLine == null)
				{
					r_EndLine = new(this, "EndLine", -1);
					r_EndLine.SetBelong(this.instance);
				}
				return r_EndLine;
			}
		}

		/// <summary>
		/// Int32 StartColumn
		/// </summary>
		protected RProperty r_StartColumn;
		public virtual RProperty RStartColumn
		{
			get
			{
				if(r_StartColumn == null)
				{
					r_StartColumn = new(this, "StartColumn", -1);
					r_StartColumn.SetBelong(this.instance);
				}
				return r_StartColumn;
			}
		}

		/// <summary>
		/// Int32 EndColumn
		/// </summary>
		protected RProperty r_EndColumn;
		public virtual RProperty REndColumn
		{
			get
			{
				if(r_EndColumn == null)
				{
					r_EndColumn = new(this, "EndColumn", -1);
					r_EndColumn.SetBelong(this.instance);
				}
				return r_EndColumn;
			}
		}

		/// <summary>
		/// Int32[] GetOffsets()
		/// </summary>
		protected RMethod r_RGetOffsets;
		public virtual RMethod RGetOffsets
		{
			get
			{
				if(r_RGetOffsets == null)
				{
					r_RGetOffsets = new(this, "GetOffsets", 0);
					r_RGetOffsets.SetBelong(this.instance);
				}
				return r_RGetOffsets;
			}
		}

		/// <summary>
		/// Int32[] GetLines()
		/// </summary>
		protected RMethod r_RGetLines;
		public virtual RMethod RGetLines
		{
			get
			{
				if(r_RGetLines == null)
				{
					r_RGetLines = new(this, "GetLines", 0);
					r_RGetLines.SetBelong(this.instance);
				}
				return r_RGetLines;
			}
		}

		/// <summary>
		/// Int32[] GetColumns()
		/// </summary>
		protected RMethod r_RGetColumns;
		public virtual RMethod RGetColumns
		{
			get
			{
				if(r_RGetColumns == null)
				{
					r_RGetColumns = new(this, "GetColumns", 0);
					r_RGetColumns.SetBelong(this.instance);
				}
				return r_RGetColumns;
			}
		}

		/// <summary>
		/// Int32[] GetEndLines()
		/// </summary>
		protected RMethod r_RGetEndLines;
		public virtual RMethod RGetEndLines
		{
			get
			{
				if(r_RGetEndLines == null)
				{
					r_RGetEndLines = new(this, "GetEndLines", 0);
					r_RGetEndLines.SetBelong(this.instance);
				}
				return r_RGetEndLines;
			}
		}

		/// <summary>
		/// Int32[] GetEndColumns()
		/// </summary>
		protected RMethod r_RGetEndColumns;
		public virtual RMethod RGetEndColumns
		{
			get
			{
				if(r_RGetEndColumns == null)
				{
					r_RGetEndColumns = new(this, "GetEndColumns", 0);
					r_RGetEndColumns.SetBelong(this.instance);
				}
				return r_RGetEndColumns;
			}
		}

		/// <summary>
		/// Void AddSequencePoint(Int32, Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_RAddSequencePoint_Int32_Int32_Int32_Int32_Int32;
		public virtual RMethod RAddSequencePoint_Int32_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_RAddSequencePoint_Int32_Int32_Int32_Int32_Int32 == null)
				{
					r_RAddSequencePoint_Int32_Int32_Int32_Int32_Int32 = new(this, "AddSequencePoint", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_RAddSequencePoint_Int32_Int32_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_RAddSequencePoint_Int32_Int32_Int32_Int32_Int32;
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

        public virtual System.Int32[] GetOffsets()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetOffsets.Invoke(___genericsType, ___parameters);

            return (System.Int32[])___result;
        }


        public virtual System.Int32[] GetLines()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetLines.Invoke(___genericsType, ___parameters);

            return (System.Int32[])___result;
        }


        public virtual System.Int32[] GetColumns()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetColumns.Invoke(___genericsType, ___parameters);

            return (System.Int32[])___result;
        }


        public virtual System.Int32[] GetEndLines()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEndLines.Invoke(___genericsType, ___parameters);

            return (System.Int32[])___result;
        }


        public virtual System.Int32[] GetEndColumns()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEndColumns.Invoke(___genericsType, ___parameters);

            return (System.Int32[])___result;
        }


        public virtual void AddSequencePoint(System.Int32  @offset, System.Int32  @line, System.Int32  @col, System.Int32  @endLine, System.Int32  @endCol)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@offset, @line, @col, @endLine, @endCol};
            var ___result = RAddSequencePoint_Int32_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
