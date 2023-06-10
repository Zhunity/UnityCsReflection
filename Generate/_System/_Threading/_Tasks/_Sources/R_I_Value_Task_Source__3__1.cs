
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RSources
{
	/// <summary>
	/// System.Threading.Tasks.Sources.IValueTaskSource`1
	/// </summary>
    public partial class RIValueTaskSource<TResult> : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Threading.Tasks.Sources.IValueTaskSource<>).MakeGenericType(ReflectionUtils.GetType(typeof(TResult)));
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


		/// <summary>
		/// System.Threading.Tasks.Sources.ValueTaskSourceStatus GetStatus(Int16)
		/// </summary>
		protected RMethod r_MGetStatus_Int16;
		public virtual RMethod RMGetStatus_Int16
		{
			get
			{
				if(r_MGetStatus_Int16 == null)
				{
					r_MGetStatus_Int16 = new(this, "GetStatus", 0, typeof(System.Int16));
				}
				return r_MGetStatus_Int16;
			}
		}

		/// <summary>
		/// Void OnCompleted(System.Action`1[System.Object], System.Object, Int16, System.Threading.Tasks.Sources.ValueTaskSourceOnCompletedFlags)
		/// </summary>
		protected RMethod r_MOnCompleted_Action_d_Object_p__Object_Int16_ValueTaskSourceOnCompletedFlags;
		public virtual RMethod RMOnCompleted_Action_d_Object_p__Object_Int16_ValueTaskSourceOnCompletedFlags
		{
			get
			{
				if(r_MOnCompleted_Action_d_Object_p__Object_Int16_ValueTaskSourceOnCompletedFlags == null)
				{
					r_MOnCompleted_Action_d_Object_p__Object_Int16_ValueTaskSourceOnCompletedFlags = new(this, "OnCompleted", 0, typeof(System.Action<>).MakeGenericType(typeof(System.Object)), typeof(System.Object), typeof(System.Int16), typeof(System.Threading.Tasks.Sources.ValueTaskSourceOnCompletedFlags));
				}
				return r_MOnCompleted_Action_d_Object_p__Object_Int16_ValueTaskSourceOnCompletedFlags;
			}
		}

		/// <summary>
		/// TResult GetResult(Int16)
		/// </summary>
		protected RMethod r_MGetResult_Int16;
		public virtual RMethod RMGetResult_Int16
		{
			get
			{
				if(r_MGetResult_Int16 == null)
				{
					r_MGetResult_Int16 = new(this, "GetResult", 0, typeof(System.Int16));
				}
				return r_MGetResult_Int16;
			}
		}


        public virtual System.Threading.Tasks.Sources.ValueTaskSourceStatus GetStatus(System.Int16 @token)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@token};
            var ___result = RMGetStatus_Int16.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Sources.ValueTaskSourceStatus)___result;
        }


        public virtual void OnCompleted(System.Action<System.Object> @continuation, System.Object @state, System.Int16 @token, System.Threading.Tasks.Sources.ValueTaskSourceOnCompletedFlags @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuation, @state, @token, @flags};
            var ___result = RMOnCompleted_Action_d_Object_p__Object_Int16_ValueTaskSourceOnCompletedFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual TResult GetResult(System.Int16 @token)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@token};
            var ___result = RMGetResult_Int16.Invoke(___genericsType, ___parameters);

            return (TResult)___result;
        }


    }
}
