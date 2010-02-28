
using System;
using System.IO;



public class A {

	public virtual void RenderToStream ()
	{
	}

	public virtual void Foo (TextWriter writer)
	{
	}
}


public class B : A {

	public override void RenderToStream ()
	{
		base.RenderToStream ();
	}

	public override void Foo (TextWriter writer)
	{
		writer.Write (ValueTypeToString ("foobar".Length));
	}

	private static string ValueTypeToString (System.ValueType val)
	{
		return val.ToString ();
	}
}

/*
        IL_000d:  ldstr "100"
	IL_0012:  call instance int32 string::get_Length()
	IL_0017:  box [mscorlib]System.Int32
	IL_001c:  call string class templates.page_numbers::ValueToString(class [mscorlib]System.ValueType)
	IL_0021:  callvirt instance void class [mscorlib]System.IO.TextWriter::Write(string)
*/
  
/*
        IL_0000:  ldarg.1 
	IL_0001:  ldstr "foobar"
	IL_0006:  callvirt instance int32 string::get_Length()
	IL_000b:  box [mscorlib]System.Int32
	IL_0010:  call string class B::ValueTypeToString(class [mscorlib]System.ValueType)
*/