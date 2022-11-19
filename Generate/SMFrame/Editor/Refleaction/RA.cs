using SMFrame.Editor.Refleaction;
using System;

namespace SMFrame.Editor.Refleaction.SMFrame.Editor.Refleaction
{
    public partial class RA : Member
    {
		public Method RN_GT_TArray; //System.String N<T>(T[] a)
		public Method RN_Ref_StringArray; //System.Int32 N(System.String[] s)
		public Method RN_Ga_Gb_Gc_Gd_Ge_Gf_Gg_Dictionary_d_aInt32_p__bArray_HashSet_d_Dictionary_d_ecArray_p__p_; //System.Void N<a, b, c, d, e, f, g>(System.Collections.Generic.Dictionary<a, System.Int32> s, b[] asdf, System.Collections.Generic.HashSet<System.Collections.Generic.Dictionary<e, c[]>> wer)
		public Method RN_BooleanArrayArrayArrayArray; //System.String N(System.Boolean[][][][] a)
		public Method REquals_Object; //System.Boolean Equals(System.Object obj)
		public Method RFinalize; //System.Void Finalize()
		public Method RGetHashCode; //System.Int32 GetHashCode()
		public Method RGetType; //System.Type GetType()
		public Method RMemberwiseClone; //System.Object MemberwiseClone()
		public Method RToString; //System.String ToString()


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
			RN_GT_TArray = new Method(this, "N", 1, Type.MakeGenericMethodParameter(0).MakeArrayType());
			RN_Ref_StringArray = new Method(this, "N", 0, typeof(System.String).MakeArrayType().MakeByRefType());
			RN_Ga_Gb_Gc_Gd_Ge_Gf_Gg_Dictionary_d_aInt32_p__bArray_HashSet_d_Dictionary_d_ecArray_p__p_ = new Method(this, "N", 7, typeof(System.Collections.Generic.Dictionary<, >).MakeGenericType(Type.MakeGenericMethodParameter(0), typeof(System.Int32)), Type.MakeGenericMethodParameter(1).MakeArrayType(), typeof(System.Collections.Generic.HashSet<>).MakeGenericType(typeof(System.Collections.Generic.Dictionary<, >).MakeGenericType(Type.MakeGenericMethodParameter(4), Type.MakeGenericMethodParameter(2).MakeArrayType())));
			RN_BooleanArrayArrayArrayArray = new Method(this, "N", 0, typeof(System.Boolean).MakeArrayType().MakeArrayType().MakeArrayType().MakeArrayType());
			REquals_Object = new Method(this, "Equals", 0, typeof(System.Object));
			RFinalize = new Method(this, "Finalize", 0);
			RGetHashCode = new Method(this, "GetHashCode", 0);
			RGetType = new Method(this, "GetType", 0);
			RMemberwiseClone = new Method(this, "MemberwiseClone", 0);
			RToString = new Method(this, "ToString", 0);

        }

        public virtual System.String N<T>(T[] a)
        {

            var genericsType = new Type[] {typeof(T)};
            var parameters = new object[]{a};
            var result = RN_GT_TArray.Invoke(genericsType, parameters);

            return (System.String)result;
        }

        public virtual System.Int32 N(ref System.String[] s)
        {

            var genericsType = new Type[] {};
            var parameters = new object[]{s};
            var result = RN_Ref_StringArray.Invoke(genericsType, parameters);
			s = (System.String[])parameters[0];

            return (System.Int32)result;
        }

        public virtual void N<a, b, c, d, e, f, g>(System.Collections.Generic.Dictionary<a, System.Int32> s, b[] asdf, System.Collections.Generic.HashSet<System.Collections.Generic.Dictionary<e, c[]>> wer)
        {

            var genericsType = new Type[] {typeof(a), typeof(b), typeof(c), typeof(d), typeof(e), typeof(f), typeof(g)};
            var parameters = new object[]{s, asdf, wer};
            var result = RN_Ga_Gb_Gc_Gd_Ge_Gf_Gg_Dictionary_d_aInt32_p__bArray_HashSet_d_Dictionary_d_ecArray_p__p_.Invoke(genericsType, parameters);

            
        }

        public virtual System.String N(System.Boolean[][][][] a)
        {

            var genericsType = new Type[] {};
            var parameters = new object[]{a};
            var result = RN_BooleanArrayArrayArrayArray.Invoke(genericsType, parameters);

            return (System.String)result;
        }

        public virtual System.Boolean Equals(System.Object obj)
        {

            var genericsType = new Type[] {};
            var parameters = new object[]{obj};
            var result = REquals_Object.Invoke(genericsType, parameters);

            return (System.Boolean)result;
        }

        public virtual void Finalize()
        {

            var genericsType = new Type[] {};
            var parameters = new object[]{};
            var result = RFinalize.Invoke(genericsType, parameters);

            
        }

        public virtual System.Int32 GetHashCode()
        {

            var genericsType = new Type[] {};
            var parameters = new object[]{};
            var result = RGetHashCode.Invoke(genericsType, parameters);

            return (System.Int32)result;
        }

        public virtual System.Type GetType()
        {

            var genericsType = new Type[] {};
            var parameters = new object[]{};
            var result = RGetType.Invoke(genericsType, parameters);

            return (System.Type)result;
        }

        public virtual System.Object MemberwiseClone()
        {

            var genericsType = new Type[] {};
            var parameters = new object[]{};
            var result = RMemberwiseClone.Invoke(genericsType, parameters);

            return (System.Object)result;
        }

        public virtual System.String ToString()
        {

            var genericsType = new Type[] {};
            var parameters = new object[]{};
            var result = RToString.Invoke(genericsType, parameters);

            return (System.String)result;
        }

    }
}
