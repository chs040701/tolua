﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class System_Reflection_ParameterInfoWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(System.Reflection.ParameterInfo), typeof(System.Object));
		L.RegFunction("IsDefined", IsDefined);
		L.RegFunction("GetCustomAttributesData", GetCustomAttributesData);
		L.RegFunction("GetCustomAttributes", GetCustomAttributes);
		L.RegFunction("GetOptionalCustomModifiers", GetOptionalCustomModifiers);
		L.RegFunction("GetRequiredCustomModifiers", GetRequiredCustomModifiers);
		L.RegFunction("GetRealObject", GetRealObject);
		L.RegFunction("ToString", ToString);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("Attributes", get_Attributes, null);
		L.RegVar("Member", get_Member, null);
		L.RegVar("Name", get_Name, null);
		L.RegVar("ParameterType", get_ParameterType, null);
		L.RegVar("Position", get_Position, null);
		L.RegVar("IsIn", get_IsIn, null);
		L.RegVar("IsLcid", get_IsLcid, null);
		L.RegVar("IsOptional", get_IsOptional, null);
		L.RegVar("IsOut", get_IsOut, null);
		L.RegVar("IsRetval", get_IsRetval, null);
		L.RegVar("DefaultValue", get_DefaultValue, null);
		L.RegVar("RawDefaultValue", get_RawDefaultValue, null);
		L.RegVar("HasDefaultValue", get_HasDefaultValue, null);
		L.RegVar("CustomAttributes", get_CustomAttributes, null);
		L.RegVar("MetadataToken", get_MetadataToken, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsDefined(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			System.Reflection.ParameterInfo obj = (System.Reflection.ParameterInfo)ToLua.CheckObject<System.Reflection.ParameterInfo>(L, 1);
			System.Type arg0 = ToLua.CheckMonoType(L, 2);
			bool arg1 = LuaDLL.luaL_checkboolean(L, 3);
			bool o = obj.IsDefined(arg0, arg1);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetCustomAttributesData(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			System.Reflection.ParameterInfo obj = (System.Reflection.ParameterInfo)ToLua.CheckObject<System.Reflection.ParameterInfo>(L, 1);
			System.Collections.Generic.IList<System.Reflection.CustomAttributeData> o = obj.GetCustomAttributesData();
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetCustomAttributes(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				System.Reflection.ParameterInfo obj = (System.Reflection.ParameterInfo)ToLua.CheckObject<System.Reflection.ParameterInfo>(L, 1);
				bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
				object[] o = obj.GetCustomAttributes(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 3)
			{
				System.Reflection.ParameterInfo obj = (System.Reflection.ParameterInfo)ToLua.CheckObject<System.Reflection.ParameterInfo>(L, 1);
				System.Type arg0 = ToLua.CheckMonoType(L, 2);
				bool arg1 = LuaDLL.luaL_checkboolean(L, 3);
				object[] o = obj.GetCustomAttributes(arg0, arg1);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: System.Reflection.ParameterInfo.GetCustomAttributes");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetOptionalCustomModifiers(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			System.Reflection.ParameterInfo obj = (System.Reflection.ParameterInfo)ToLua.CheckObject<System.Reflection.ParameterInfo>(L, 1);
			System.Type[] o = obj.GetOptionalCustomModifiers();
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRequiredCustomModifiers(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			System.Reflection.ParameterInfo obj = (System.Reflection.ParameterInfo)ToLua.CheckObject<System.Reflection.ParameterInfo>(L, 1);
			System.Type[] o = obj.GetRequiredCustomModifiers();
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRealObject(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			System.Reflection.ParameterInfo obj = (System.Reflection.ParameterInfo)ToLua.CheckObject<System.Reflection.ParameterInfo>(L, 1);
			System.Runtime.Serialization.StreamingContext arg0 = StackTraits<System.Runtime.Serialization.StreamingContext>.Check(L, 2);
			object o = obj.GetRealObject(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ToString(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			System.Reflection.ParameterInfo obj = (System.Reflection.ParameterInfo)ToLua.CheckObject<System.Reflection.ParameterInfo>(L, 1);
			string o = obj.ToString();
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Attributes(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Reflection.ParameterInfo obj = (System.Reflection.ParameterInfo)o;
			System.Reflection.ParameterAttributes ret = obj.Attributes;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Attributes on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Member(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Reflection.ParameterInfo obj = (System.Reflection.ParameterInfo)o;
			System.Reflection.MemberInfo ret = obj.Member;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Member on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Name(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Reflection.ParameterInfo obj = (System.Reflection.ParameterInfo)o;
			string ret = obj.Name;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Name on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ParameterType(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Reflection.ParameterInfo obj = (System.Reflection.ParameterInfo)o;
			System.Type ret = obj.ParameterType;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index ParameterType on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Position(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Reflection.ParameterInfo obj = (System.Reflection.ParameterInfo)o;
			int ret = obj.Position;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Position on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsIn(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Reflection.ParameterInfo obj = (System.Reflection.ParameterInfo)o;
			bool ret = obj.IsIn;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index IsIn on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsLcid(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Reflection.ParameterInfo obj = (System.Reflection.ParameterInfo)o;
			bool ret = obj.IsLcid;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index IsLcid on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsOptional(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Reflection.ParameterInfo obj = (System.Reflection.ParameterInfo)o;
			bool ret = obj.IsOptional;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index IsOptional on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsOut(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Reflection.ParameterInfo obj = (System.Reflection.ParameterInfo)o;
			bool ret = obj.IsOut;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index IsOut on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsRetval(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Reflection.ParameterInfo obj = (System.Reflection.ParameterInfo)o;
			bool ret = obj.IsRetval;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index IsRetval on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_DefaultValue(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Reflection.ParameterInfo obj = (System.Reflection.ParameterInfo)o;
			object ret = obj.DefaultValue;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index DefaultValue on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_RawDefaultValue(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Reflection.ParameterInfo obj = (System.Reflection.ParameterInfo)o;
			object ret = obj.RawDefaultValue;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index RawDefaultValue on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_HasDefaultValue(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Reflection.ParameterInfo obj = (System.Reflection.ParameterInfo)o;
			bool ret = obj.HasDefaultValue;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index HasDefaultValue on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_CustomAttributes(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Reflection.ParameterInfo obj = (System.Reflection.ParameterInfo)o;
			System.Collections.Generic.IEnumerable<System.Reflection.CustomAttributeData> ret = obj.CustomAttributes;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index CustomAttributes on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_MetadataToken(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Reflection.ParameterInfo obj = (System.Reflection.ParameterInfo)o;
			int ret = obj.MetadataToken;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index MetadataToken on a nil value");
		}
	}
}

