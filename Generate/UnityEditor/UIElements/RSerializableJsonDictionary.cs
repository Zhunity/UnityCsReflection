using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor.RUIElements
{
	/// <summary>
	/// UnityEditor.UIElements.SerializableJsonDictionary
	/// </summary>
    public partial class RSerializableJsonDictionary : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] m_Keys
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r_m_Keys;
		public virtual RSystem.RCollections.RGeneric.RList<RField> Rm_Keys
		{
			get
			{
				if(r_m_Keys == null)
				{
					r_m_Keys = new(this, "m_Keys");
					r_m_Keys.SetBelong(this.instance);
				}
				return r_m_Keys;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] m_Values
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r_m_Values;
		public virtual RSystem.RCollections.RGeneric.RList<RField> Rm_Values
		{
			get
			{
				if(r_m_Values == null)
				{
					r_m_Values = new(this, "m_Values");
					r_m_Values.SetBelong(this.instance);
				}
				return r_m_Values;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.Object] m_Dict
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RObject> r_m_Dict;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RObject> Rm_Dict
		{
			get
			{
				if(r_m_Dict == null)
				{
					r_m_Dict = new(this, "m_Dict");
					r_m_Dict.SetBelong(this.instance);
				}
				return r_m_Dict;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected RProperty r_name;
		public virtual RProperty Rname
		{
			get
			{
				if(r_name == null)
				{
					r_name = new(this, "name", -1);
					r_name.SetBelong(this.instance);
				}
				return r_name;
			}
		}

		/// <summary>
		/// UnityEngine.HideFlags hideFlags
		/// </summary>
		protected RProperty r_hideFlags;
		public virtual RProperty RhideFlags
		{
			get
			{
				if(r_hideFlags == null)
				{
					r_hideFlags = new(this, "hideFlags", -1);
					r_hideFlags.SetBelong(this.instance);
				}
				return r_hideFlags;
			}
		}

		/// <summary>
		/// Void Set[T](System.String, T)
		/// </summary>
		protected RMethod r_Set_GT_String_T;
		public virtual RMethod RSet_GT_String_T
		{
			get
			{
				if(r_Set_GT_String_T == null)
				{
					r_Set_GT_String_T = new(this, "Set", 1, typeof(System.String), Type.MakeGenericMethodParameter(0));
					r_Set_GT_String_T.SetBelong(this.instance);
				}
				return r_Set_GT_String_T;
			}
		}

		/// <summary>
		/// T Get[T](System.String)
		/// </summary>
		protected RMethod r_Get_GT_String;
		public virtual RMethod RGet_GT_String
		{
			get
			{
				if(r_Get_GT_String == null)
				{
					r_Get_GT_String = new(this, "Get", 1, typeof(System.String));
					r_Get_GT_String.SetBelong(this.instance);
				}
				return r_Get_GT_String;
			}
		}

		/// <summary>
		/// T GetScriptable[T](System.String)
		/// </summary>
		protected RMethod r_GetScriptable_GT_String;
		public virtual RMethod RGetScriptable_GT_String
		{
			get
			{
				if(r_GetScriptable_GT_String == null)
				{
					r_GetScriptable_GT_String = new(this, "GetScriptable", 1, typeof(System.String));
					r_GetScriptable_GT_String.SetBelong(this.instance);
				}
				return r_GetScriptable_GT_String;
			}
		}

		/// <summary>
		/// Void Overwrite(System.Object, System.String)
		/// </summary>
		protected RMethod r_Overwrite_Object_String;
		public virtual RMethod ROverwrite_Object_String
		{
			get
			{
				if(r_Overwrite_Object_String == null)
				{
					r_Overwrite_Object_String = new(this, "Overwrite", 0, typeof(System.Object), typeof(System.String));
					r_Overwrite_Object_String.SetBelong(this.instance);
				}
				return r_Overwrite_Object_String;
			}
		}

		/// <summary>
		/// Boolean ContainsKey(System.String)
		/// </summary>
		protected RMethod r_ContainsKey_String;
		public virtual RMethod RContainsKey_String
		{
			get
			{
				if(r_ContainsKey_String == null)
				{
					r_ContainsKey_String = new(this, "ContainsKey", 0, typeof(System.String));
					r_ContainsKey_String.SetBelong(this.instance);
				}
				return r_ContainsKey_String;
			}
		}

		/// <summary>
		/// Void OnBeforeSerialize()
		/// </summary>
		protected RMethod r_OnBeforeSerialize;
		public virtual RMethod ROnBeforeSerialize
		{
			get
			{
				if(r_OnBeforeSerialize == null)
				{
					r_OnBeforeSerialize = new(this, "OnBeforeSerialize", 0);
					r_OnBeforeSerialize.SetBelong(this.instance);
				}
				return r_OnBeforeSerialize;
			}
		}

		/// <summary>
		/// Void OnAfterDeserialize()
		/// </summary>
		protected RMethod r_OnAfterDeserialize;
		public virtual RMethod ROnAfterDeserialize
		{
			get
			{
				if(r_OnAfterDeserialize == null)
				{
					r_OnAfterDeserialize = new(this, "OnAfterDeserialize", 0);
					r_OnAfterDeserialize.SetBelong(this.instance);
				}
				return r_OnAfterDeserialize;
			}
		}

		/// <summary>
		/// System.String <OnAfterDeserialize>b__9_0(Int32)
		/// </summary>
		protected RMethod r___0__OnAfterDeserialize__1__b__9_0_Int32;
		public virtual RMethod R__0__OnAfterDeserialize__1__b__9_0_Int32
		{
			get
			{
				if(r___0__OnAfterDeserialize__1__b__9_0_Int32 == null)
				{
					r___0__OnAfterDeserialize__1__b__9_0_Int32 = new(this, "<OnAfterDeserialize>b__9_0", 0, typeof(System.Int32));
					r___0__OnAfterDeserialize__1__b__9_0_Int32.SetBelong(this.instance);
				}
				return r___0__OnAfterDeserialize__1__b__9_0_Int32;
			}
		}

		/// <summary>
		/// System.Object <OnAfterDeserialize>b__9_1(Int32)
		/// </summary>
		protected RMethod r___0__OnAfterDeserialize__1__b__9_1_Int32;
		public virtual RMethod R__0__OnAfterDeserialize__1__b__9_1_Int32
		{
			get
			{
				if(r___0__OnAfterDeserialize__1__b__9_1_Int32 == null)
				{
					r___0__OnAfterDeserialize__1__b__9_1_Int32 = new(this, "<OnAfterDeserialize>b__9_1", 0, typeof(System.Int32));
					r___0__OnAfterDeserialize__1__b__9_1_Int32.SetBelong(this.instance);
				}
				return r___0__OnAfterDeserialize__1__b__9_1_Int32;
			}
		}

		/// <summary>
		/// Void SetDirty()
		/// </summary>
		protected RMethod r_SetDirty;
		public virtual RMethod RSetDirty
		{
			get
			{
				if(r_SetDirty == null)
				{
					r_SetDirty = new(this, "SetDirty", 0);
					r_SetDirty.SetBelong(this.instance);
				}
				return r_SetDirty;
			}
		}

		/// <summary>
		/// Int32 GetInstanceID()
		/// </summary>
		protected RMethod r_GetInstanceID;
		public virtual RMethod RGetInstanceID
		{
			get
			{
				if(r_GetInstanceID == null)
				{
					r_GetInstanceID = new(this, "GetInstanceID", 0);
					r_GetInstanceID.SetBelong(this.instance);
				}
				return r_GetInstanceID;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_GetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_GetHashCode == null)
				{
					r_GetHashCode = new(this, "GetHashCode", 0);
					r_GetHashCode.SetBelong(this.instance);
				}
				return r_GetHashCode;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_Equals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_Equals_Object == null)
				{
					r_Equals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_Equals_Object.SetBelong(this.instance);
				}
				return r_Equals_Object;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_ToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_ToString == null)
				{
					r_ToString = new(this, "ToString", 0);
					r_ToString.SetBelong(this.instance);
				}
				return r_ToString;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_Finalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_Finalize == null)
				{
					r_Finalize = new(this, "Finalize", 0);
					r_Finalize.SetBelong(this.instance);
				}
				return r_Finalize;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_GetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_GetType == null)
				{
					r_GetType = new(this, "GetType", 0);
					r_GetType.SetBelong(this.instance);
				}
				return r_GetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_MemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_MemberwiseClone == null)
				{
					r_MemberwiseClone = new(this, "MemberwiseClone", 0);
					r_MemberwiseClone.SetBelong(this.instance);
				}
				return r_MemberwiseClone;
			}
		}


        public RSerializableJsonDictionary() : base("UnityEditor.UIElements.SerializableJsonDictionary")
        {
        }

        public RSerializableJsonDictionary(System.Object instance) : base("UnityEditor.UIElements.SerializableJsonDictionary")
		{
            SetInstance(instance);
		}

        public RSerializableJsonDictionary(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSerializableJsonDictionary(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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


        public virtual System.String __0__OnAfterDeserialize__1__b__9_0(System.Int32  @i)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@i};
            var ___result = R__0__OnAfterDeserialize__1__b__9_0_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Object __0__OnAfterDeserialize__1__b__9_1(System.Int32  @i)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@i};
            var ___result = R__0__OnAfterDeserialize__1__b__9_1_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void SetDirty()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSetDirty.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetInstanceID()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetInstanceID.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
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


    }
}
