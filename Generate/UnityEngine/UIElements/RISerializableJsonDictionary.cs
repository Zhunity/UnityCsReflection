using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.ISerializableJsonDictionary
	/// </summary>
    public partial class RISerializableJsonDictionary : RMember //
    {

		/// <summary>
		/// Void Set[T](System.String, T)
		/// </summary>
		protected RMethod r_RSet_GT_String_T;
		public virtual RMethod RSet_GT_String_T
		{
			get
			{
				if(r_RSet_GT_String_T == null)
				{
					r_RSet_GT_String_T = new(this, "Set", 1, typeof(System.String), Type.MakeGenericMethodParameter(0));
					r_RSet_GT_String_T.SetBelong(this.instance);
				}
				return r_RSet_GT_String_T;
			}
		}

		/// <summary>
		/// T Get[T](System.String)
		/// </summary>
		protected RMethod r_RGet_GT_String;
		public virtual RMethod RGet_GT_String
		{
			get
			{
				if(r_RGet_GT_String == null)
				{
					r_RGet_GT_String = new(this, "Get", 1, typeof(System.String));
					r_RGet_GT_String.SetBelong(this.instance);
				}
				return r_RGet_GT_String;
			}
		}

		/// <summary>
		/// T GetScriptable[T](System.String)
		/// </summary>
		protected RMethod r_RGetScriptable_GT_String;
		public virtual RMethod RGetScriptable_GT_String
		{
			get
			{
				if(r_RGetScriptable_GT_String == null)
				{
					r_RGetScriptable_GT_String = new(this, "GetScriptable", 1, typeof(System.String));
					r_RGetScriptable_GT_String.SetBelong(this.instance);
				}
				return r_RGetScriptable_GT_String;
			}
		}

		/// <summary>
		/// Void Overwrite(System.Object, System.String)
		/// </summary>
		protected RMethod r_ROverwrite_Object_String;
		public virtual RMethod ROverwrite_Object_String
		{
			get
			{
				if(r_ROverwrite_Object_String == null)
				{
					r_ROverwrite_Object_String = new(this, "Overwrite", 0, typeof(System.Object), typeof(System.String));
					r_ROverwrite_Object_String.SetBelong(this.instance);
				}
				return r_ROverwrite_Object_String;
			}
		}

		/// <summary>
		/// Boolean ContainsKey(System.String)
		/// </summary>
		protected RMethod r_RContainsKey_String;
		public virtual RMethod RContainsKey_String
		{
			get
			{
				if(r_RContainsKey_String == null)
				{
					r_RContainsKey_String = new(this, "ContainsKey", 0, typeof(System.String));
					r_RContainsKey_String.SetBelong(this.instance);
				}
				return r_RContainsKey_String;
			}
		}

		/// <summary>
		/// Void OnBeforeSerialize()
		/// </summary>
		protected RMethod r_ROnBeforeSerialize;
		public virtual RMethod ROnBeforeSerialize
		{
			get
			{
				if(r_ROnBeforeSerialize == null)
				{
					r_ROnBeforeSerialize = new(this, "OnBeforeSerialize", 0);
					r_ROnBeforeSerialize.SetBelong(this.instance);
				}
				return r_ROnBeforeSerialize;
			}
		}

		/// <summary>
		/// Void OnAfterDeserialize()
		/// </summary>
		protected RMethod r_ROnAfterDeserialize;
		public virtual RMethod ROnAfterDeserialize
		{
			get
			{
				if(r_ROnAfterDeserialize == null)
				{
					r_ROnAfterDeserialize = new(this, "OnAfterDeserialize", 0);
					r_ROnAfterDeserialize.SetBelong(this.instance);
				}
				return r_ROnAfterDeserialize;
			}
		}


        public RISerializableJsonDictionary() : base("UnityEngine.UIElements.ISerializableJsonDictionary")
        {
        }

        public RISerializableJsonDictionary(System.Object instance) : base("UnityEngine.UIElements.ISerializableJsonDictionary")
		{
            SetInstance(instance);
		}

        public RISerializableJsonDictionary(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RISerializableJsonDictionary(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Set<T>(System.String  @key, T  @value) where T : class
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@key, @value};
            var ___result = RSet_GT_String_T.Invoke(___genericsType, ___parameters);

            
        }


        public virtual T Get<T>(System.String  @key) where T : class
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@key};
            var ___result = RGet_GT_String.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual T GetScriptable<T>(System.String  @key) where T : UnityEngine.ScriptableObject
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@key};
            var ___result = RGetScriptable_GT_String.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual void Overwrite(System.Object  @obj, System.String  @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @key};
            var ___result = ROverwrite_Object_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ContainsKey(System.String  @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RContainsKey_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void OnBeforeSerialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnBeforeSerialize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnAfterDeserialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnAfterDeserialize.Invoke(___genericsType, ___parameters);

            
        }


    }
}
