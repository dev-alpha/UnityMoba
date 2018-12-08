﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class NTGResourceControllerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(NTGResourceController), typeof(UnityEngine.MonoBehaviour));
		L.RegFunction("GetDataPath", GetDataPath);
		L.RegFunction("LuaPath", LuaPath);
		L.RegFunction("WriteAllText", WriteAllText);
		L.RegFunction("ReadAllText", ReadAllText);
		L.RegFunction("GetFileMD5", GetFileMD5);
		L.RegFunction("InitBundleDependencies", InitBundleDependencies);
		L.RegFunction("UnloadAssetBundle", UnloadAssetBundle);
		L.RegFunction("BattlePreClearAssetBundle", BattlePreClearAssetBundle);
		L.RegFunction("BattlePostClearAssetBundle", BattlePostClearAssetBundle);
		L.RegFunction("LoadAsset", LoadAsset);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", Lua_ToString);
		L.RegVar("DebugLevel", get_DebugLevel, set_DebugLevel);
		L.RegVar("BattleLoadingBundles", get_BattleLoadingBundles, set_BattleLoadingBundles);
		L.RegVar("IsApplePlatform", get_IsApplePlatform, null);
		L.RegVar("DataPath", get_DataPath, null);
		L.RegVar("StreamingAssetsPath", get_StreamingAssetsPath, null);
		L.RegVar("Instance", get_Instance, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetDataPath(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			string o = NTGResourceController.GetDataPath(arg0);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LuaPath(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			string o = NTGResourceController.LuaPath(arg0);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int WriteAllText(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			string arg0 = ToLua.CheckString(L, 1);
			string arg1 = ToLua.CheckString(L, 2);
			NTGResourceController.WriteAllText(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReadAllText(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			string o = NTGResourceController.ReadAllText(arg0);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetFileMD5(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			string o = NTGResourceController.GetFileMD5(arg0);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int InitBundleDependencies(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			NTGResourceController obj = (NTGResourceController)ToLua.CheckObject(L, 1, typeof(NTGResourceController));
			obj.InitBundleDependencies();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnloadAssetBundle(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			NTGResourceController obj = (NTGResourceController)ToLua.CheckObject(L, 1, typeof(NTGResourceController));
			string arg0 = ToLua.CheckString(L, 2);
			bool arg1 = LuaDLL.luaL_checkboolean(L, 3);
			bool arg2 = LuaDLL.luaL_checkboolean(L, 4);
			bool o = obj.UnloadAssetBundle(arg0, arg1, arg2);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int BattlePreClearAssetBundle(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			NTGResourceController obj = (NTGResourceController)ToLua.CheckObject(L, 1, typeof(NTGResourceController));
			obj.BattlePreClearAssetBundle();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int BattlePostClearAssetBundle(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			NTGResourceController obj = (NTGResourceController)ToLua.CheckObject(L, 1, typeof(NTGResourceController));
			obj.BattlePostClearAssetBundle();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadAsset(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(NTGResourceController), typeof(string), typeof(string)))
			{
				NTGResourceController obj = (NTGResourceController)ToLua.ToObject(L, 1);
				string arg0 = ToLua.ToString(L, 2);
				string arg1 = ToLua.ToString(L, 3);
				UnityEngine.GameObject o = obj.LoadAsset(arg0, arg1);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 4 && TypeChecker.CheckTypes(L, 1, typeof(NTGResourceController), typeof(string), typeof(string), typeof(string)))
			{
				NTGResourceController obj = (NTGResourceController)ToLua.ToObject(L, 1);
				string arg0 = ToLua.ToString(L, 2);
				string arg1 = ToLua.ToString(L, 3);
				string arg2 = ToLua.ToString(L, 4);
				UnityEngine.Object o = obj.LoadAsset(arg0, arg1, arg2);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: NTGResourceController.LoadAsset");
			}
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
	static int get_DebugLevel(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, NTGResourceController.DebugLevel);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_BattleLoadingBundles(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGResourceController obj = (NTGResourceController)o;
			string[] ret = obj.BattleLoadingBundles;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index BattleLoadingBundles on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsApplePlatform(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, NTGResourceController.IsApplePlatform);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_DataPath(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, NTGResourceController.DataPath);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_StreamingAssetsPath(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, NTGResourceController.StreamingAssetsPath);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Instance(IntPtr L)
	{
		try
		{
			ToLua.Push(L, NTGResourceController.Instance);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_DebugLevel(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			NTGResourceController.DebugLevel = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_BattleLoadingBundles(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGResourceController obj = (NTGResourceController)o;
			string[] arg0 = ToLua.CheckStringArray(L, 2);
			obj.BattleLoadingBundles = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index BattleLoadingBundles on a nil value" : e.Message);
		}
	}
}

