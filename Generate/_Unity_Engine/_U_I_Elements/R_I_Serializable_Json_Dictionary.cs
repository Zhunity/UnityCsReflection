
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
		protected RMethod r_MSet_GT_String_T;
		public virtual RMethod RMSet_GT_String_T
		{
			get
			{
				if(r_MSet_GT_String_T == null)
				{
					r_MSet_GT_String_T = new(this, "Set", 1, typeof(System.String), Type.MakeGenericMethodParameter(0));
					r_MSet_GT_String_T.SetBelong(this.instance);
				}
				return r_MSet_GT_String_T;
			}
		}

		/// <summary>
		/// T Get[T](System.String)
		/// </summary>
		protected RMethod r_MGet_GT_String;
		public virtual RMethod RMGet_GT_String
		{
			get
			{
				if(r_MGet_GT_String == null)
				{
					r_MGet_GT_String = new(this, "Get", 1, typeof(System.String));
					r_MGet_GT_String.SetBelong(this.instance);
				}
				return r_MGet_GT_String;
			}
		}

		/// <summary>
		/// T GetScriptable[T](System.String)
		/// </summary>
		protected RMethod r_MGetScriptable_GT_String;
		public virtual RMethod RMGetScriptable_GT_String
		{
			get
			{
				if(r_MGetScriptable_GT_String == null)
				{
					r_MGetScriptable_GT_String = new(this, "GetScriptable", 1, typeof(System.String));
					r_MGetScriptable_GT_String.SetBelong(this.instance);
				}
				return r_MGetScriptable_GT_String;
			}
		}

		/// <summary>
		/// Void Overwrite(System.Object, System.String)
		/// </summary>
		protected RMethod r_MOverwrite_Object_String;
		public virtual RMethod RMOverwrite_Object_String
		{
			get
			{
				if(r_MOverwrite_Object_String == null)
				{
					r_MOverwrite_Object_String = new(this, "Overwrite", 0, typeof(System.Object), typeof(System.String));
					r_MOverwrite_Object_String.SetBelong(this.instance);
				}
				return r_MOverwrite_Object_String;
			}
		}

		/// <summary>
		/// Boolean ContainsKey(System.String)
		/// </summary>
		protected RMethod r_MContainsKey_String;
		public virtual RMethod RMContainsKey_String
		{
			get
			{
				if(r_MContainsKey_String == null)
				{
					r_MContainsKey_String = new(this, "ContainsKey", 0, typeof(System.String));
					r_MContainsKey_String.SetBelong(this.instance);
				}
				return r_MContainsKey_String;
			}
		}

		/// <summary>
		/// Void OnBeforeSerialize()
		/// </summary>
		protected RMethod r_MOnBeforeSerialize;
		public virtual RMethod RMOnBeforeSerialize
		{
			get
			{
				if(r_MOnBeforeSerialize == null)
				{
					r_MOnBeforeSerialize = new(this, "OnBeforeSerialize", 0);
					r_MOnBeforeSerialize.SetBelong(this.instance);
				}
				return r_MOnBeforeSerialize;
			}
		}

		/// <summary>
		/// Void OnAfterDeserialize()
		/// </summary>
		protected RMethod r_MOnAfterDeserialize;
		public virtual RMethod RMOnAfterDeserialize
		{
			get
			{
				if(r_MOnAfterDeserialize == null)
				{
					r_MOnAfterDeserialize = new(this, "OnAfterDeserialize", 0);
					r_MOnAfterDeserialize.SetBelong(this.instance);
				}
				return r_MOnAfterDeserialize;
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

        public virtual void Set<T>(System.String @key, T @value) where T : class
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@key, @value};
            var ___result = RMSet_GT_String_T.Invoke(___genericsType, ___parameters);

            
        }


        public virtual T Get<T>(System.String @key) where T : class
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@key};
            var ___result = RMGet_GT_String.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual T GetScriptable<T>(System.String @key) where T : UnityEngine.ScriptableObject
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@key};
            var ___result = RMGetScriptable_GT_String.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual void Overwrite(System.Object @obj, System.String @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @key};
            var ___result = RMOverwrite_Object_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ContainsKey(System.String @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RMContainsKey_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void OnBeforeSerialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnBeforeSerialize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnAfterDeserialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnAfterDeserialize.Invoke(___genericsType, ___parameters);

            
        }


    }
}
