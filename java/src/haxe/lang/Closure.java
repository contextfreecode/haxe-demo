// Generated by Haxe 4.1.2
package haxe.lang;

import haxe.root.*;

@SuppressWarnings(value={"rawtypes", "unchecked"})
public class Closure extends haxe.lang.VarArgsBase
{
	public Closure(java.lang.Object obj, java.lang.String field)
	{
		//line 62 "/home/tjpalmer/apps/haxe-4.1.2/std/java/internal/Function.hx"
		super(-1, -1);
		//line 63 "/home/tjpalmer/apps/haxe-4.1.2/std/java/internal/Function.hx"
		this.obj = obj;
		//line 64 "/home/tjpalmer/apps/haxe-4.1.2/std/java/internal/Function.hx"
		this.field = field;
	}
	
	
	public java.lang.Object obj;
	
	public java.lang.String field;
	
	@Override public java.lang.Object __hx_invokeDynamic(java.lang.Object[] dynArgs)
	{
		//line 68 "/home/tjpalmer/apps/haxe-4.1.2/std/java/internal/Function.hx"
		return haxe.lang.Runtime.callField(this.obj, this.field, dynArgs);
	}
	
	
	@Override public boolean equals(java.lang.Object obj)
	{
		//line 72 "/home/tjpalmer/apps/haxe-4.1.2/std/java/internal/Function.hx"
		if (( obj == null )) 
		{
			//line 73 "/home/tjpalmer/apps/haxe-4.1.2/std/java/internal/Function.hx"
			return false;
		}
		
		//line 75 "/home/tjpalmer/apps/haxe-4.1.2/std/java/internal/Function.hx"
		haxe.lang.Closure c = ((haxe.lang.Closure) (obj) );
		//line 76 "/home/tjpalmer/apps/haxe-4.1.2/std/java/internal/Function.hx"
		if (haxe.lang.Runtime.eq(c.obj, this.obj)) 
		{
			//line 76 "/home/tjpalmer/apps/haxe-4.1.2/std/java/internal/Function.hx"
			return haxe.lang.Runtime.valEq(c.field, this.field);
		}
		else
		{
			//line 76 "/home/tjpalmer/apps/haxe-4.1.2/std/java/internal/Function.hx"
			return false;
		}
		
	}
	
	
	@Override public int hashCode()
	{
		//line 80 "/home/tjpalmer/apps/haxe-4.1.2/std/java/internal/Function.hx"
		return ( ((int) (this.obj.hashCode()) ) ^ ((int) (this.field.hashCode()) ) );
	}
	
	
}


