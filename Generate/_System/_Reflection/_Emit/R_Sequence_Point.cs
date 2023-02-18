
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RReflection.REmit
{
	/// <summary>
	/// System.Reflection.Emit.SequencePoint
	/// </summary>
    public partial class RSequencePoint : RMember //
    {

		/// <summary>
		/// System.Int32 Offset
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FOffset;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFOffset
		{
			get
			{
				if(r_FOffset == null)
				{
					r_FOffset = new(this, "Offset");
					r_FOffset.SetBelong(this.GetValue());
				}
				return r_FOffset;
			}
		}

		/// <summary>
		/// System.Int32 Line
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FLine;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFLine
		{
			get
			{
				if(r_FLine == null)
				{
					r_FLine = new(this, "Line");
					r_FLine.SetBelong(this.GetValue());
				}
				return r_FLine;
			}
		}

		/// <summary>
		/// System.Int32 Col
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FCol;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFCol
		{
			get
			{
				if(r_FCol == null)
				{
					r_FCol = new(this, "Col");
					r_FCol.SetBelong(this.GetValue());
				}
				return r_FCol;
			}
		}

		/// <summary>
		/// System.Int32 EndLine
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FEndLine;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFEndLine
		{
			get
			{
				if(r_FEndLine == null)
				{
					r_FEndLine = new(this, "EndLine");
					r_FEndLine.SetBelong(this.GetValue());
				}
				return r_FEndLine;
			}
		}

		/// <summary>
		/// System.Int32 EndCol
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FEndCol;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFEndCol
		{
			get
			{
				if(r_FEndCol == null)
				{
					r_FEndCol = new(this, "EndCol");
					r_FEndCol.SetBelong(this.GetValue());
				}
				return r_FEndCol;
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
					r_MEquals_Object.SetBelong(this.GetValue());
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
					r_MGetHashCode.SetBelong(this.GetValue());
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
					r_MToString.SetBelong(this.GetValue());
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
					r_MFinalize.SetBelong(this.GetValue());
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
					r_MGetType.SetBelong(this.GetValue());
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
					r_MMemberwiseClone.SetBelong(this.GetValue());
				}
				return r_MMemberwiseClone;
			}
		}


        public RSequencePoint() : base("System.Reflection.Emit.SequencePoint")
        {
        }

        public RSequencePoint(System.Object instance) : base("System.Reflection.Emit.SequencePoint")
		{
            SetInstance(instance);
		}

        public RSequencePoint(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSequencePoint(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
