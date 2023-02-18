
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RBuffers
{
	/// <summary>
	/// System.Buffers.IPinnable
	/// </summary>
    public partial class RIPinnable : RMember //
    {

		/// <summary>
		/// System.Buffers.MemoryHandle Pin(Int32)
		/// </summary>
		protected RMethod r_MPin_Int32;
		public virtual RMethod RMPin_Int32
		{
			get
			{
				if(r_MPin_Int32 == null)
				{
					r_MPin_Int32 = new(this, "Pin", 0, typeof(System.Int32));
				}
				return r_MPin_Int32;
			}
		}

		/// <summary>
		/// Void Unpin()
		/// </summary>
		protected RMethod r_MUnpin;
		public virtual RMethod RMUnpin
		{
			get
			{
				if(r_MUnpin == null)
				{
					r_MUnpin = new(this, "Unpin", 0);
				}
				return r_MUnpin;
			}
		}


        public RIPinnable() : base("System.Buffers.IPinnable")
        {
        }

        public RIPinnable(System.Object instance) : base("System.Buffers.IPinnable")
		{
            SetInstance(instance);
		}

        public RIPinnable(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIPinnable(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Buffers.MemoryHandle Pin(System.Int32 @elementIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@elementIndex};
            var ___result = RMPin_Int32.Invoke(___genericsType, ___parameters);

            return (System.Buffers.MemoryHandle)___result;
        }


        public virtual void Unpin()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUnpin.Invoke(___genericsType, ___parameters);

            
        }


    }
}
