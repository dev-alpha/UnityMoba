//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class TestExportWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(TestExport), typeof(System.Object));
		L.RegFunction("get_Item", get_Item);
		L.RegFunction("set_Item", set_Item);
		L.RegFunction("TestByteBuffer", TestByteBuffer);
		L.RegFunction("Test", Test);
		L.RegFunction("TestChar", TestChar);
		L.RegFunction("Test33", Test33);
		L.RegFunction("TestGeneric", TestGeneric);
		L.RegFunction("TestEnum", TestEnum);
		L.RegFunction("TestCheckParamNumber", TestCheckParamNumber);
		L.RegFunction("TestCheckParamString", TestCheckParamString);
		L.RegFunction("TestReflection", TestReflection);
		L.RegFunction("TestRefGameObject", TestRefGameObject);
		L.RegFunction("DoClick", DoClick);
		L.RegFunction("New", _CreateTestExport);
		L.RegVar("this", _this, null);
		L.RegFunction("__tostring", Lua_ToString);
		L.RegVar("field", get_field, set_field);
		L.RegVar("OnClick", get_OnClick, set_OnClick);
		L.RegVar("OnRefEvent", get_OnRefEvent, set_OnRefEvent);
		L.RegVar("buffer", get_buffer, set_buffer);
		L.RegVar("Number", get_Number, set_Number);
		L.RegFunction("TestBuffer", TestExport_TestBuffer);
		L.RegFunction("TestRefEvent", TestExport_TestRefEvent);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateTestExport(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				TestExport obj = new TestExport();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Vector3)))
			{
				UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 1);
				TestExport obj = new TestExport(arg0);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Vector3[])))
			{
				UnityEngine.Vector3[] arg0 = ToLua.CheckObjectArray<UnityEngine.Vector3>(L, 1);
				TestExport obj = new TestExport(arg0);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Vector3), typeof(string)))
			{
				UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 1);
				string arg1 = ToLua.CheckString(L, 2);
				TestExport obj = new TestExport(arg0, arg1);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: TestExport.New");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _get_this(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			TestExport obj = (TestExport)ToLua.CheckObject(L, 1, typeof(TestExport));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			int o = obj[arg0];
			LuaDLL.lua_pushinteger(L, o);
			return 1;

		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _set_this(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			TestExport obj = (TestExport)ToLua.CheckObject(L, 1, typeof(TestExport));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
			obj[arg0] = arg1;
			return 0;

		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _this(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushvalue(L, 1);
			LuaDLL.tolua_bindthis(L, _get_this, _set_this);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Item(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(double)))
			{
				double arg0 = (double)LuaDLL.lua_tonumber(L, 1);
				int o = TestExport.get_Item(arg0);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(string)))
			{
				string arg0 = ToLua.ToString(L, 1);
				int o = TestExport.get_Item(arg0);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(TestExport), typeof(int)))
			{
				TestExport obj = (TestExport)ToLua.ToObject(L, 1);
				int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
				int o = obj[arg0];
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: TestExport.get_Item");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Item(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(double)))
			{
				double arg0 = (double)LuaDLL.lua_tonumber(L, 1);
				int o = TestExport.set_Item(arg0);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(TestExport), typeof(int), typeof(int)))
			{
				TestExport obj = (TestExport)ToLua.ToObject(L, 1);
				int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
				int arg1 = (int)LuaDLL.lua_tonumber(L, 3);
				obj[arg0] = arg1;
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: TestExport.set_Item");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TestByteBuffer(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			TestExport obj = (TestExport)ToLua.CheckObject(L, 1, typeof(TestExport));
			TestExport.TestBuffer arg0 = null;
			LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

			if (funcType2 != LuaTypes.LUA_TFUNCTION)
			{
				 arg0 = (TestExport.TestBuffer)ToLua.CheckObject(L, 2, typeof(TestExport.TestBuffer));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 2);
				arg0 = DelegateFactory.CreateDelegate(typeof(TestExport.TestBuffer), func) as TestExport.TestBuffer;
			}

			obj.TestByteBuffer(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Test(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(TestExport), typeof(string)))
			{
				TestExport obj = (TestExport)ToLua.ToObject(L, 1);
				string arg0 = ToLua.ToString(L, 2);
				int o = obj.Test(arg0);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(string), typeof(string)))
			{
				string arg0 = ToLua.ToString(L, 1);
				string arg1 = ToLua.ToString(L, 2);
				int o = TestExport.Test(arg0, arg1);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(TestExport), typeof(TestExport.Space)))
			{
				TestExport obj = (TestExport)ToLua.ToObject(L, 1);
				TestExport.Space arg0 = (TestExport.Space)ToLua.ToObject(L, 2);
				int o = obj.Test(arg0);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(TestExport), typeof(LuaInterface.LuaOut<int>)))
			{
				TestExport obj = (TestExport)ToLua.ToObject(L, 1);
				int arg0;
				int o = obj.Test(out arg0);
				LuaDLL.lua_pushinteger(L, o);
				LuaDLL.lua_pushinteger(L, arg0);
				return 2;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(TestExport), typeof(bool)))
			{
				TestExport obj = (TestExport)ToLua.ToObject(L, 1);
				bool arg0 = LuaDLL.lua_toboolean(L, 2);
				int o = obj.Test(arg0);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(TestExport), typeof(double)))
			{
				TestExport obj = (TestExport)ToLua.ToObject(L, 1);
				double arg0 = (double)LuaDLL.lua_tonumber(L, 2);
				int o = obj.Test(arg0);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(TestExport), typeof(object)))
			{
				TestExport obj = (TestExport)ToLua.ToObject(L, 1);
				object arg0 = ToLua.ToVarObject(L, 2);
				int o = obj.Test(arg0);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(TestExport), typeof(int), typeof(int)))
			{
				TestExport obj = (TestExport)ToLua.ToObject(L, 1);
				int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
				int arg1 = (int)LuaDLL.lua_tonumber(L, 3);
				int o = obj.Test(arg0, arg1);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(TestExport), typeof(object), typeof(string)))
			{
				TestExport obj = (TestExport)ToLua.ToObject(L, 1);
				object arg0 = ToLua.ToVarObject(L, 2);
				string arg1 = ToLua.ToString(L, 3);
				int o = obj.Test(arg0, arg1);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (TypeChecker.CheckParamsType(L, typeof(string), 2, count - 1))
			{
				TestExport obj = (TestExport)ToLua.ToObject(L, 1);
				string[] arg0 = ToLua.ToParamsString(L, 2, count - 1);
				int o = obj.Test(arg0);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (TypeChecker.CheckParamsType(L, typeof(int), 2, count - 1))
			{
				TestExport obj = (TestExport)ToLua.ToObject(L, 1);
				int[] arg0 = ToLua.ToParamsNumber<int>(L, 2, count - 1);
				int o = obj.Test(arg0);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (TypeChecker.CheckParamsType(L, typeof(object), 2, count - 1))
			{
				TestExport obj = (TestExport)ToLua.ToObject(L, 1);
				object[] arg0 = ToLua.ToParamsObject(L, 2, count - 1);
				int o = obj.Test(arg0);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: TestExport.Test");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TestChar(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			TestExport obj = (TestExport)ToLua.CheckObject(L, 1, typeof(TestExport));
			char arg0 = (char)LuaDLL.luaL_checknumber(L, 2);
			int o = obj.Test(arg0);
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Test33(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			TestExport obj = (TestExport)ToLua.CheckObject(L, 1, typeof(TestExport));
			System.Action<int> arg0 = null;
			LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

			if (funcType2 != LuaTypes.LUA_TFUNCTION)
			{
				 arg0 = (System.Action<int>)ToLua.CheckObject(L, 2, typeof(System.Action<int>));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 2);
				arg0 = DelegateFactory.CreateDelegate(typeof(System.Action<int>), func) as System.Action<int>;
			}

			int o = obj.Test33(ref arg0);
			LuaDLL.lua_pushinteger(L, o);
			ToLua.Push(L, arg0);
			return 2;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TestGeneric(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			TestExport obj = (TestExport)ToLua.CheckObject(L, 1, typeof(TestExport));
			UnityEngine.Component arg0 = (UnityEngine.Component)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.Component));
			int o = obj.TestGeneric(arg0);
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TestEnum(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			TestExport obj = (TestExport)ToLua.CheckObject(L, 1, typeof(TestExport));
			TestExport.Space arg0 = (TestExport.Space)ToLua.CheckObject(L, 2, typeof(TestExport.Space));
			int o = obj.TestEnum(arg0);
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TestCheckParamNumber(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			TestExport obj = (TestExport)ToLua.CheckObject(L, 1, typeof(TestExport));
			int[] arg0 = ToLua.CheckParamsNumber<int>(L, 2, count - 1);
			int o = obj.TestCheckParamNumber(arg0);
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TestCheckParamString(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			TestExport obj = (TestExport)ToLua.CheckObject(L, 1, typeof(TestExport));
			string[] arg0 = ToLua.CheckParamsString(L, 2, count - 1);
			string o = obj.TestCheckParamString(arg0);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TestReflection(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			TestExport.TestReflection();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TestRefGameObject(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.GameObject));
			TestExport.TestRefGameObject(ref arg0);
			ToLua.Push(L, arg0);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DoClick(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			TestExport obj = (TestExport)ToLua.CheckObject(L, 1, typeof(TestExport));
			obj.DoClick();
			return 0;
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
	static int get_field(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TestExport obj = (TestExport)o;
			int ret = obj.field;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index field on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_OnClick(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TestExport obj = (TestExport)o;
			System.Action ret = obj.OnClick;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index OnClick on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_OnRefEvent(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TestExport obj = (TestExport)o;
			TestExport.TestRefEvent ret = obj.OnRefEvent;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index OnRefEvent on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_buffer(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TestExport obj = (TestExport)o;
			byte[] ret = obj.buffer;
			ToLua.Push(L, new LuaByteBuffer(ret));
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index buffer on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Number(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TestExport obj = (TestExport)o;
			int ret = obj.Number;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index Number on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_field(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TestExport obj = (TestExport)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.field = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index field on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_OnClick(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TestExport obj = (TestExport)o;
			System.Action arg0 = null;
			LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

			if (funcType2 != LuaTypes.LUA_TFUNCTION)
			{
				 arg0 = (System.Action)ToLua.CheckObject(L, 2, typeof(System.Action));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 2);
				arg0 = DelegateFactory.CreateDelegate(typeof(System.Action), func) as System.Action;
			}

			obj.OnClick = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index OnClick on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_OnRefEvent(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TestExport obj = (TestExport)o;
			TestExport.TestRefEvent arg0 = null;
			LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

			if (funcType2 != LuaTypes.LUA_TFUNCTION)
			{
				 arg0 = (TestExport.TestRefEvent)ToLua.CheckObject(L, 2, typeof(TestExport.TestRefEvent));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 2);
				arg0 = DelegateFactory.CreateDelegate(typeof(TestExport.TestRefEvent), func) as TestExport.TestRefEvent;
			}

			obj.OnRefEvent = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index OnRefEvent on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_buffer(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TestExport obj = (TestExport)o;
			byte[] arg0 = ToLua.CheckByteBuffer(L, 2);
			obj.buffer = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index buffer on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Number(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TestExport obj = (TestExport)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.Number = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index Number on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TestExport_TestBuffer(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(TestExport.TestBuffer), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TestExport_TestRefEvent(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(TestExport.TestRefEvent), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

