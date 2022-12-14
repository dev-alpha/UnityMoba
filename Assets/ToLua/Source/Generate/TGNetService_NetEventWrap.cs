//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class TGNetService_NetEventWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(TGNetService.NetEvent), typeof(System.Object));
		L.RegFunction("New", _CreateTGNetService_NetEvent);
		L.RegFunction("__tostring", Lua_ToString);
		L.RegVar("Type", get_Type, set_Type);
		L.RegVar("Content", get_Content, set_Content);
		L.RegVar("Data", get_Data, set_Data);
		L.RegVar("Param", get_Param, set_Param);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateTGNetService_NetEvent(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				TGNetService.NetEvent obj = new TGNetService.NetEvent();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: TGNetService.NetEvent.New");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Lua_ToString(IntPtr L)
	{
		object obj = ToLua.ToObject(L, 1);

		if (obj != null)
		{
			LuaDLL.lua_pushstring(L, obj.ToString());
		}
		else
		{
			LuaDLL.lua_pushnil(L);
		}

		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Type(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TGNetService.NetEvent obj = (TGNetService.NetEvent)o;
			string ret = obj.Type;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index Type on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Content(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TGNetService.NetEvent obj = (TGNetService.NetEvent)o;
			Newtonsoft.Json.Linq.JObject ret = obj.Content;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index Content on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Data(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TGNetService.NetEvent obj = (TGNetService.NetEvent)o;
			byte[] ret = obj.Data;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index Data on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Param(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TGNetService.NetEvent obj = (TGNetService.NetEvent)o;
			object ret = obj.Param;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index Param on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Type(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TGNetService.NetEvent obj = (TGNetService.NetEvent)o;
			string arg0 = ToLua.CheckString(L, 2);
			obj.Type = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index Type on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Content(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TGNetService.NetEvent obj = (TGNetService.NetEvent)o;
			Newtonsoft.Json.Linq.JObject arg0 = (Newtonsoft.Json.Linq.JObject)ToLua.CheckObject(L, 2, typeof(Newtonsoft.Json.Linq.JObject));
			obj.Content = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index Content on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Data(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TGNetService.NetEvent obj = (TGNetService.NetEvent)o;
			byte[] arg0 = ToLua.CheckByteBuffer(L, 2);
			obj.Data = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index Data on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Param(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TGNetService.NetEvent obj = (TGNetService.NetEvent)o;
			object arg0 = ToLua.ToVarObject(L, 2);
			obj.Param = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index Param on a nil value" : e.Message);
		}
	}
}

