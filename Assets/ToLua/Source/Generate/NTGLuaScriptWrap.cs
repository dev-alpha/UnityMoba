//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class NTGLuaScriptWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(NTGLuaScript), typeof(UnityEngine.MonoBehaviour));
		L.RegFunction("GetType", GetType);
		L.RegFunction("InvokeDelegate", InvokeDelegate);
		L.RegFunction("Load", Load);
		L.RegFunction("LuaCall", LuaCall);
		L.RegFunction("OnDestroy", OnDestroy);
		L.RegFunction("OnDisable", OnDisable);
		L.RegFunction("OnEnable", OnEnable);
		L.RegFunction("OnTriggerEnter", OnTriggerEnter);
		L.RegFunction("OnTriggerExit", OnTriggerExit);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", Lua_ToString);
		L.RegVar("luaScript", get_luaScript, set_luaScript);
		L.RegVar("transforms", get_transforms, set_transforms);
		L.RegVar("strings", get_strings, set_strings);
		L.RegVar("floats", get_floats, set_floats);
		L.RegVar("ints", get_ints, set_ints);
		L.RegVar("eventOnTriggerEnter", get_eventOnTriggerEnter, set_eventOnTriggerEnter);
		L.RegVar("eventOnTriggerExit", get_eventOnTriggerExit, set_eventOnTriggerExit);
		L.RegVar("self", get_self, set_self);
		L.RegVar("module", get_module, set_module);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetType(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(NTGLuaScript)))
			{
				NTGLuaScript obj = (NTGLuaScript)ToLua.ToObject(L, 1);
				System.Type o = obj.GetType();
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(string)))
			{
				string arg0 = ToLua.ToString(L, 1);
				System.Type o = NTGLuaScript.GetType(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: NTGLuaScript.GetType");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int InvokeDelegate(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			NTGLuaScript obj = (NTGLuaScript)ToLua.CheckObject(L, 1, typeof(NTGLuaScript));
			System.Delegate arg0 = (System.Delegate)ToLua.CheckObject(L, 2, typeof(System.Delegate));
			object[] arg1 = ToLua.ToParamsObject(L, 3, count - 2);
			object o = obj.InvokeDelegate(arg0, arg1);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Load(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			NTGLuaScript obj = (NTGLuaScript)ToLua.CheckObject(L, 1, typeof(NTGLuaScript));
			string arg0 = ToLua.CheckString(L, 2);
			obj.Load(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LuaCall(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			NTGLuaScript obj = (NTGLuaScript)ToLua.CheckObject(L, 1, typeof(NTGLuaScript));
			string arg0 = ToLua.CheckString(L, 2);
			object[] arg1 = ToLua.ToParamsObject(L, 3, count - 2);
			obj.LuaCall(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnDestroy(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			NTGLuaScript obj = (NTGLuaScript)ToLua.CheckObject(L, 1, typeof(NTGLuaScript));
			obj.OnDestroy();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnDisable(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			NTGLuaScript obj = (NTGLuaScript)ToLua.CheckObject(L, 1, typeof(NTGLuaScript));
			obj.OnDisable();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnEnable(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			NTGLuaScript obj = (NTGLuaScript)ToLua.CheckObject(L, 1, typeof(NTGLuaScript));
			obj.OnEnable();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnTriggerEnter(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			NTGLuaScript obj = (NTGLuaScript)ToLua.CheckObject(L, 1, typeof(NTGLuaScript));
			UnityEngine.Collider arg0 = (UnityEngine.Collider)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.Collider));
			obj.OnTriggerEnter(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnTriggerExit(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			NTGLuaScript obj = (NTGLuaScript)ToLua.CheckObject(L, 1, typeof(NTGLuaScript));
			UnityEngine.Collider arg0 = (UnityEngine.Collider)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.Collider));
			obj.OnTriggerExit(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
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
	static int get_luaScript(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGLuaScript obj = (NTGLuaScript)o;
			string ret = obj.luaScript;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index luaScript on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_transforms(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGLuaScript obj = (NTGLuaScript)o;
			UnityEngine.Transform[] ret = obj.transforms;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index transforms on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_strings(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGLuaScript obj = (NTGLuaScript)o;
			string[] ret = obj.strings;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index strings on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_floats(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGLuaScript obj = (NTGLuaScript)o;
			float[] ret = obj.floats;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index floats on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ints(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGLuaScript obj = (NTGLuaScript)o;
			int[] ret = obj.ints;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index ints on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_eventOnTriggerEnter(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGLuaScript obj = (NTGLuaScript)o;
			bool ret = obj.eventOnTriggerEnter;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index eventOnTriggerEnter on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_eventOnTriggerExit(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGLuaScript obj = (NTGLuaScript)o;
			bool ret = obj.eventOnTriggerExit;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index eventOnTriggerExit on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_self(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGLuaScript obj = (NTGLuaScript)o;
			LuaInterface.LuaTable ret = obj.self;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index self on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_module(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGLuaScript obj = (NTGLuaScript)o;
			string ret = obj.module;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index module on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_luaScript(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGLuaScript obj = (NTGLuaScript)o;
			string arg0 = ToLua.CheckString(L, 2);
			obj.luaScript = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index luaScript on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_transforms(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGLuaScript obj = (NTGLuaScript)o;
			UnityEngine.Transform[] arg0 = ToLua.CheckObjectArray<UnityEngine.Transform>(L, 2);
			obj.transforms = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index transforms on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_strings(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGLuaScript obj = (NTGLuaScript)o;
			string[] arg0 = ToLua.CheckStringArray(L, 2);
			obj.strings = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index strings on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_floats(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGLuaScript obj = (NTGLuaScript)o;
			float[] arg0 = ToLua.CheckNumberArray<float>(L, 2);
			obj.floats = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index floats on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_ints(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGLuaScript obj = (NTGLuaScript)o;
			int[] arg0 = ToLua.CheckNumberArray<int>(L, 2);
			obj.ints = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index ints on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_eventOnTriggerEnter(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGLuaScript obj = (NTGLuaScript)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.eventOnTriggerEnter = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index eventOnTriggerEnter on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_eventOnTriggerExit(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGLuaScript obj = (NTGLuaScript)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.eventOnTriggerExit = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index eventOnTriggerExit on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_self(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGLuaScript obj = (NTGLuaScript)o;
			LuaTable arg0 = ToLua.CheckLuaTable(L, 2);
			obj.self = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index self on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_module(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGLuaScript obj = (NTGLuaScript)o;
			string arg0 = ToLua.CheckString(L, 2);
			obj.module = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index module on a nil value" : e.Message);
		}
	}
}

