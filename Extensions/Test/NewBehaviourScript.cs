using System;
using System.Reflection;
using UnityEditor;
using UnityEngine;

// Define a sample interface to use as an interface constraint.
public interface ITest { }

// Define a base type to use as a base class constraint.
public class Base {
	protected virtual void haha<z>()
	{

	}
}

public struct SValue { }

// Define the generic type to examine. The first generic type parameter,
// T, derives from the class Base and implements ITest. This demonstrates
// a base class constraint and an interface constraint. The second generic 
// type parameter, U, must be a reference type (class) and must have a 
// default constructor (new()). This demonstrates special constraints.
//
public class Test<T, U, V, W, X, Y, z> : Base
	where T : Base, ITest
	where U : class, new()
	where V : struct, ITest
	where W : unmanaged
	where X : notnull
	//where Y : SValue
{
	protected override void haha<z>() where z : default
	{

	}
}

// Define a type that derives from Base and implements ITest. This type
// satisfies the constraints on T in class Test.
public class Derived : Base, ITest { 
	//void test<T, U, V, W, X, Y>(Test<T, U, V, W, X, Y> a)
	//{

	//}
}

public class Example
{
	[MenuItem("Tools/Test generic")]
	public static void Main()
	{
		// To get the generic type definition, omit the type
		// arguments but retain the comma to indicate the number
		// of type arguments. 
		//
		Type def = typeof(Test<,,,,,,>);
		Debug.LogFormat("\r\nExamining generic type {0}", def);

		// Get the type parameters of the generic type definition,
		// and display them.
		//
		Type[] defparams = def.GetGenericArguments();
		foreach (Type tp in defparams)
		{
			

			// List the base class and interface constraints. The
			// constraints are returned in no particular order. If 
			// there are no class or interface constraints, an empty
			// array is returned.
			//
			Type[] tpConstraints = tp.GetGenericParameterConstraints();

			GenericParameterAttributes gpa = tp.GenericParameterAttributes;
			GenericParameterAttributes constraints = gpa &
			GenericParameterAttributes.SpecialConstraintMask;
			if(tpConstraints.Length <= 0 && constraints == GenericParameterAttributes.None)
			{
				//continue;
			}


			var str = $"where {tp.Name} : ";
			if((constraints & GenericParameterAttributes.ReferenceTypeConstraint) != 0)
			{
				str += "class,";
			}

			if ((constraints & GenericParameterAttributes.NotNullableValueTypeConstraint) != 0)
			{
				str += "struct,";
			}


			foreach (Type tpc in tpConstraints)
			{
				if(tpc == typeof(ValueType))
				{
					continue;
				}
				str += tpc + ", ";
				//Debug.LogFormat("\t{0}", tpc);
			}

			if ((constraints & GenericParameterAttributes.DefaultConstructorConstraint) != 0 && (constraints & GenericParameterAttributes.NotNullableValueTypeConstraint) == 0)
			{
				str += "new()";
			}

			Debug.LogFormat("Type parameter: {0}\tcon : {1}\ttype :{2}", tp.Name,
				ListGenericParameterAttributes(tp), str);
		}
	}

	// List the variance and special constraint flags. 
	//
	private static string ListGenericParameterAttributes(Type t)
	{
		string retval;
		GenericParameterAttributes gpa = t.GenericParameterAttributes;
		GenericParameterAttributes variance = gpa &
			GenericParameterAttributes.VarianceMask;

		// Select the variance flags.
		if (variance == GenericParameterAttributes.None)
		{
			retval = "No variance flag;\t";
		}
		else
		{
			if ((variance & GenericParameterAttributes.Covariant) != 0)
				retval = "Covariant;\t";
			else
				retval = "Contravariant;\t";
		}

		// Select 
		GenericParameterAttributes constraints = gpa &
			GenericParameterAttributes.SpecialConstraintMask;

		if (constraints == GenericParameterAttributes.None)
		{
			retval += " No special constraints";
		}
		else
		{
			if ((constraints & GenericParameterAttributes.ReferenceTypeConstraint) != 0)
				retval += " ReferenceTypeConstraint";
			if ((constraints & GenericParameterAttributes.NotNullableValueTypeConstraint) != 0)
				retval += " NotNullableValueTypeConstraint";
			if ((constraints & GenericParameterAttributes.DefaultConstructorConstraint) != 0)
				retval += " DefaultConstructorConstraint";
		}

		return retval;
	}
}