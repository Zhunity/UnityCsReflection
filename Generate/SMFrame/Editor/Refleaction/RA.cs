using SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric;
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSMFrame.REditor.RRefleaction
{
    public partial class RA : Member
    {
		public static Method RN_GT_Int32_Out_T_Ref_Single_In_Int64_BooleanArrayArrayArray; //Single N[T](Int32, T ByRef, Single ByRef, Int64 ByRef, Boolean[][][])
		public  Method RN; //Void N()
		public  Method RN_GT_TArray; //System.String N[T](T[])
		public  Method RN_Ref_StringArray; //Int32 N(System.String[] ByRef)
		public  Method RN_Ga_Gb_Gc_Gd_Ge_Gf_Gg_Dictionary_d_a_Int32_p__bArray_HashSet_d_Dictionary_d_e_cArray_p__p_; //Void N[a,b,c,d,e,f,g](System.Collections.Generic.Dictionary`2[a,System.Int32], b[], System.Collections.Generic.HashSet`1[System.Collections.Generic.Dictionary`2[e,c[]]])
		public  Method RN_GT_GU_T_U; //System.String N[T,U](T, U)
		public  Method RN_Out_Boolean; //System.String N(Boolean ByRef)
		public  Method RN_Ref_Int32; //System.String N(Int32 ByRef)
		public  Method RN_Boolean; //System.String N(Boolean)
		public  Method RN_BooleanArrayArrayArrayArray; //System.String N(Boolean[][][][])
		public  Method RN_In_Dictionary_d_Int32Array_List_d_StringArrayArray_p__p_ArrayArray; //System.String N(System.Collections.Generic.Dictionary`2[System.Int32[],System.Collections.Generic.List`1[System.String[][]]][][] ByRef)
		public  Method RN_GT_GU_GA_Gz_Dictionary_d_T_U_p__A_Single; //Int32 N[T,U,A,z](System.Collections.Generic.Dictionary`2[T,U], A, Single)
		public  Method RN_Ref_List_d_Int32_p_; //System.String N(System.Collections.Generic.List`1[System.Int32] ByRef)
		public  Method REquals_Object; //Boolean Equals(System.Object)
		public  Method RFinalize; //Void Finalize()
		public  Method RGetHashCode; //Int32 GetHashCode()
		public  Method RGetType; //System.Type GetType()
		public  Method RMemberwiseClone; //System.Object MemberwiseClone()
		public  Method RToString; //System.String ToString()


        public RA() : base("SMFrame.Editor.Refleaction.A")
        {
            NewMembers();
        }

        public RA(Member belongMember, string name) : base(belongMember, name)
	    {
            NewMembers();
	    }

        private void NewMembers()
        {
			RN_GT_Int32_Out_T_Ref_Single_In_Int64_BooleanArrayArrayArray = new Method(this, "N", 1, typeof(System.Int32), Type.MakeGenericMethodParameter(0).MakeByRefType(), typeof(System.Single).MakeByRefType(), typeof(System.Int64).MakeByRefType(), typeof(System.Boolean).MakeArrayType().MakeArrayType().MakeArrayType());
			RN = new Method(this, "N", 0);
			RN_GT_TArray = new Method(this, "N", 1, Type.MakeGenericMethodParameter(0).MakeArrayType());
			RN_Ref_StringArray = new Method(this, "N", 0, typeof(System.String).MakeArrayType().MakeByRefType());
			RN_Ga_Gb_Gc_Gd_Ge_Gf_Gg_Dictionary_d_a_Int32_p__bArray_HashSet_d_Dictionary_d_e_cArray_p__p_ = new Method(this, "N", 7, typeof(System.Collections.Generic.Dictionary<, >).MakeGenericType(Type.MakeGenericMethodParameter(0), typeof(System.Int32)), Type.MakeGenericMethodParameter(1).MakeArrayType(), typeof(System.Collections.Generic.HashSet<>).MakeGenericType(typeof(System.Collections.Generic.Dictionary<, >).MakeGenericType(Type.MakeGenericMethodParameter(4), Type.MakeGenericMethodParameter(2).MakeArrayType())));
			RN_GT_GU_T_U = new Method(this, "N", 2, Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1));
			RN_Out_Boolean = new Method(this, "N", 0, typeof(System.Boolean).MakeByRefType());
			RN_Ref_Int32 = new Method(this, "N", 0, typeof(System.Int32).MakeByRefType());
			RN_Boolean = new Method(this, "N", 0, typeof(System.Boolean));
			RN_BooleanArrayArrayArrayArray = new Method(this, "N", 0, typeof(System.Boolean).MakeArrayType().MakeArrayType().MakeArrayType().MakeArrayType());
			RN_In_Dictionary_d_Int32Array_List_d_StringArrayArray_p__p_ArrayArray = new Method(this, "N", 0, typeof(System.Collections.Generic.Dictionary<, >).MakeGenericType(typeof(System.Int32).MakeArrayType(), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.String).MakeArrayType().MakeArrayType())).MakeArrayType().MakeArrayType().MakeByRefType());
			RN_GT_GU_GA_Gz_Dictionary_d_T_U_p__A_Single = new Method(this, "N", 4, typeof(System.Collections.Generic.Dictionary<, >).MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1)), Type.MakeGenericMethodParameter(2), typeof(System.Single));
			RN_Ref_List_d_Int32_p_ = new Method(this, "N", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Int32)).MakeByRefType());
			REquals_Object = new Method(this, "Equals", 0, typeof(System.Object));
			RFinalize = new Method(this, "Finalize", 0);
			RGetHashCode = new Method(this, "GetHashCode", 0);
			RGetType = new Method(this, "GetType", 0);
			RMemberwiseClone = new Method(this, "MemberwiseClone", 0);
			RToString = new Method(this, "ToString", 0);

        }

        public static System.Single N<T>(System.Int32  @e, out T  @a, ref System.Single  @b, in System.Int64  @c, System.Boolean[][][]  @d)
        {
			a = default;

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@e, @a, @b, @c, @d};
            var ___result = RN_GT_Int32_Out_T_Ref_Single_In_Int64_BooleanArrayArrayArray.Invoke(___genericsType, ___parameters);
			a = (T)___parameters[1];
			b = (System.Single)___parameters[2];

            return (System.Single)___result;
        }

        public virtual void N()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RN.Invoke(___genericsType, ___parameters);

            
        }

        public virtual System.String N<T>(T[]  @a)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@a};
            var ___result = RN_GT_TArray.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }

        public virtual System.Int32 N(ref System.String[]  @s)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s};
            var ___result = RN_Ref_StringArray.Invoke(___genericsType, ___parameters);
			s = (System.String[])___parameters[0];

            return (System.Int32)___result;
        }

        public virtual void N<a, b, c, d, e, f, g>(System.Collections.Generic.Dictionary<a, System.Int32>  @s, b[]  @asdf, System.Collections.Generic.HashSet<System.Collections.Generic.Dictionary<e, c[]>>  @wer)
        {

            var ___genericsType = new Type[] {typeof(a), typeof(b), typeof(c), typeof(d), typeof(e), typeof(f), typeof(g)};
            var ___parameters = new object[]{@s, @asdf, @wer};
            var ___result = RN_Ga_Gb_Gc_Gd_Ge_Gf_Gg_Dictionary_d_a_Int32_p__bArray_HashSet_d_Dictionary_d_e_cArray_p__p_.Invoke(___genericsType, ___parameters);

            
        }

        public virtual System.String N<T, U>(T  @a, U  @b)
        {

            var ___genericsType = new Type[] {typeof(T), typeof(U)};
            var ___parameters = new object[]{@a, @b};
            var ___result = RN_GT_GU_T_U.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }

        public virtual System.String N(out System.Boolean  @a)
        {
			a = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a};
            var ___result = RN_Out_Boolean.Invoke(___genericsType, ___parameters);
			a = (System.Boolean)___parameters[0];

            return (System.String)___result;
        }

        public virtual System.String N(ref System.Int32  @a)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a};
            var ___result = RN_Ref_Int32.Invoke(___genericsType, ___parameters);
			a = (System.Int32)___parameters[0];

            return (System.String)___result;
        }

        public virtual System.String N(System.Boolean  @a)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a};
            var ___result = RN_Boolean.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }

        public virtual System.String N(System.Boolean[][][][]  @a)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a};
            var ___result = RN_BooleanArrayArrayArrayArray.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }

        public virtual System.String N(in System.Collections.Generic.Dictionary<System.Int32[], System.Collections.Generic.List<System.String[][]>>[][]  @a)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a};
            var ___result = RN_In_Dictionary_d_Int32Array_List_d_StringArrayArray_p__p_ArrayArray.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }

        public virtual System.Int32 N<T, U, A, z>(System.Collections.Generic.Dictionary<T, U>  @www, A  @fff, System.Single  @e)
        {

            var ___genericsType = new Type[] {typeof(T), typeof(U), typeof(A), typeof(z)};
            var ___parameters = new object[]{@www, @fff, @e};
            var ___result = RN_GT_GU_GA_Gz_Dictionary_d_T_U_p__A_Single.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }

        public virtual System.String N(ref System.Collections.Generic.List<System.Int32>  @a)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a};
            var ___result = RN_Ref_List_d_Int32_p_.Invoke(___genericsType, ___parameters);
			a = (System.Collections.Generic.List<System.Int32>)___parameters[0];

            return (System.String)___result;
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
