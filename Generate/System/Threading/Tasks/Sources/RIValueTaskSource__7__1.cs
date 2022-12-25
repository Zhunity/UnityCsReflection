using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RThreading.RTasks.RSources
{
	/// <summary>
	/// System.Threading.Tasks.Sources.IValueTaskSource`1
	/// </summary>
    public partial class RIValueTaskSource<TResult> : RMember //
    {

		/// <summary>
		/// System.Threading.Tasks.Sources.ValueTaskSourceStatus GetStatus(Int16)
		/// </summary>
		protected RMethod r_RGetStatus_Int16;
		public virtual RMethod RGetStatus_Int16
		{
			get
			{
				if(r_RGetStatus_Int16 == null)
				{
					r_RGetStatus_Int16 = new(this, "GetStatus", 0, typeof(System.Int16));
					r_RGetStatus_Int16.SetBelong(this.instance);
				}
				return r_RGetStatus_Int16;
			}
		}

		/// <summary>
		/// Void OnCompleted(System.Action`1[System.Object], System.Object, Int16, System.Threading.Tasks.Sources.ValueTaskSourceOnCompletedFlags)
		/// </summary>
		protected RMethod r_ROnCompleted_Action_d_Object_p__Object_Int16_ValueTaskSourceOnCompletedFlags;
		public virtual RMethod ROnCompleted_Action_d_Object_p__Object_Int16_ValueTaskSourceOnCompletedFlags
		{
			get
			{
				if(r_ROnCompleted_Action_d_Object_p__Object_Int16_ValueTaskSourceOnCompletedFlags == null)
				{
					r_ROnCompleted_Action_d_Object_p__Object_Int16_ValueTaskSourceOnCompletedFlags = new(this, "OnCompleted", 0, typeof(System.Action<>).MakeGenericType(typeof(System.Object)), typeof(System.Object), typeof(System.Int16), typeof(System.Threading.Tasks.Sources.ValueTaskSourceOnCompletedFlags));
					r_ROnCompleted_Action_d_Object_p__Object_Int16_ValueTaskSourceOnCompletedFlags.SetBelong(this.instance);
				}
				return r_ROnCompleted_Action_d_Object_p__Object_Int16_ValueTaskSourceOnCompletedFlags;
			}
		}

		/// <summary>
		/// TResult GetResult(Int16)
		/// </summary>
		protected RMethod r_RGetResult_Int16;
		public virtual RMethod RGetResult_Int16
		{
			get
			{
				if(r_RGetResult_Int16 == null)
				{
					r_RGetResult_Int16 = new(this, "GetResult", 0, typeof(System.Int16));
					r_RGetResult_Int16.SetBelong(this.instance);
				}
				return r_RGetResult_Int16;
			}
		}


        public RIValueTaskSource() : base("System.Threading.Tasks.Sources.IValueTaskSource`1")
        {
        }

        public RIValueTaskSource(System.Object instance) : base("System.Threading.Tasks.Sources.IValueTaskSource`1")
		{
            SetInstance(instance);
		}

        public RIValueTaskSource(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIValueTaskSource(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Threading.Tasks.Sources.ValueTaskSourceStatus GetStatus(System.Int16  @token)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@token};
            var ___result = RGetStatus_Int16.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Sources.ValueTaskSourceStatus)___result;
        }


        public virtual void OnCompleted(System.Action<System.Object>  @continuation, System.Object  @state, System.Int16  @token, System.Threading.Tasks.Sources.ValueTaskSourceOnCompletedFlags  @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuation, @state, @token, @flags};
            var ___result = ROnCompleted_Action_d_Object_p__Object_Int16_ValueTaskSourceOnCompletedFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual TResult GetResult(System.Int16  @token)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@token};
            var ___result = RGetResult_Int16.Invoke(___genericsType, ___parameters);

            return (TResult)___result;
        }


    }
}
