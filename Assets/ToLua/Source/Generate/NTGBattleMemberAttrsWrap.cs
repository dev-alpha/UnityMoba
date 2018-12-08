﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class NTGBattleMemberAttrsWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(NTGBattleMemberAttrs), typeof(System.Object));
		L.RegFunction("New", _CreateNTGBattleMemberAttrs);
		L.RegFunction("__tostring", Lua_ToString);
		L.RegVar("Hp", get_Hp, set_Hp);
		L.RegVar("Mp", get_Mp, set_Mp);
		L.RegVar("HpRecover", get_HpRecover, set_HpRecover);
		L.RegVar("MpRecover", get_MpRecover, set_MpRecover);
		L.RegVar("PAtk", get_PAtk, set_PAtk);
		L.RegVar("MAtk", get_MAtk, set_MAtk);
		L.RegVar("PDef", get_PDef, set_PDef);
		L.RegVar("MDef", get_MDef, set_MDef);
		L.RegVar("pAtkRate", get_pAtkRate, set_pAtkRate);
		L.RegVar("mAtkRate", get_mAtkRate, set_mAtkRate);
		L.RegVar("PPenetrate", get_PPenetrate, set_PPenetrate);
		L.RegVar("MPenetrate", get_MPenetrate, set_MPenetrate);
		L.RegVar("PPenetrateRate", get_PPenetrateRate, set_PPenetrateRate);
		L.RegVar("MPenetrateRate", get_MPenetrateRate, set_MPenetrateRate);
		L.RegVar("Crit", get_Crit, set_Crit);
		L.RegVar("CritEffect", get_CritEffect, set_CritEffect);
		L.RegVar("PHpSteal", get_PHpSteal, set_PHpSteal);
		L.RegVar("MHpSteal", get_MHpSteal, set_MHpSteal);
		L.RegVar("Tough", get_Tough, set_Tough);
		L.RegVar("AtkSpeed", get_AtkSpeed, set_AtkSpeed);
		L.RegVar("CdReduce", get_CdReduce, set_CdReduce);
		L.RegVar("MoveSpeed", get_MoveSpeed, set_MoveSpeed);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateNTGBattleMemberAttrs(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				NTGBattleMemberAttrs obj = new NTGBattleMemberAttrs();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: NTGBattleMemberAttrs.New");
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
	static int get_Hp(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleMemberAttrs obj = (NTGBattleMemberAttrs)o;
			float ret = obj.Hp;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index Hp on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Mp(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleMemberAttrs obj = (NTGBattleMemberAttrs)o;
			float ret = obj.Mp;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index Mp on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_HpRecover(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleMemberAttrs obj = (NTGBattleMemberAttrs)o;
			float ret = obj.HpRecover;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index HpRecover on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_MpRecover(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleMemberAttrs obj = (NTGBattleMemberAttrs)o;
			float ret = obj.MpRecover;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index MpRecover on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_PAtk(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleMemberAttrs obj = (NTGBattleMemberAttrs)o;
			float ret = obj.PAtk;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index PAtk on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_MAtk(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleMemberAttrs obj = (NTGBattleMemberAttrs)o;
			float ret = obj.MAtk;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index MAtk on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_PDef(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleMemberAttrs obj = (NTGBattleMemberAttrs)o;
			float ret = obj.PDef;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index PDef on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_MDef(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleMemberAttrs obj = (NTGBattleMemberAttrs)o;
			float ret = obj.MDef;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index MDef on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_pAtkRate(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleMemberAttrs obj = (NTGBattleMemberAttrs)o;
			float ret = obj.pAtkRate;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index pAtkRate on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_mAtkRate(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleMemberAttrs obj = (NTGBattleMemberAttrs)o;
			float ret = obj.mAtkRate;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mAtkRate on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_PPenetrate(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleMemberAttrs obj = (NTGBattleMemberAttrs)o;
			float ret = obj.PPenetrate;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index PPenetrate on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_MPenetrate(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleMemberAttrs obj = (NTGBattleMemberAttrs)o;
			float ret = obj.MPenetrate;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index MPenetrate on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_PPenetrateRate(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleMemberAttrs obj = (NTGBattleMemberAttrs)o;
			float ret = obj.PPenetrateRate;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index PPenetrateRate on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_MPenetrateRate(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleMemberAttrs obj = (NTGBattleMemberAttrs)o;
			float ret = obj.MPenetrateRate;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index MPenetrateRate on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Crit(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleMemberAttrs obj = (NTGBattleMemberAttrs)o;
			float ret = obj.Crit;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index Crit on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_CritEffect(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleMemberAttrs obj = (NTGBattleMemberAttrs)o;
			float ret = obj.CritEffect;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index CritEffect on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_PHpSteal(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleMemberAttrs obj = (NTGBattleMemberAttrs)o;
			float ret = obj.PHpSteal;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index PHpSteal on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_MHpSteal(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleMemberAttrs obj = (NTGBattleMemberAttrs)o;
			float ret = obj.MHpSteal;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index MHpSteal on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Tough(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleMemberAttrs obj = (NTGBattleMemberAttrs)o;
			float ret = obj.Tough;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index Tough on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_AtkSpeed(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleMemberAttrs obj = (NTGBattleMemberAttrs)o;
			float ret = obj.AtkSpeed;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index AtkSpeed on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_CdReduce(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleMemberAttrs obj = (NTGBattleMemberAttrs)o;
			float ret = obj.CdReduce;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index CdReduce on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_MoveSpeed(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleMemberAttrs obj = (NTGBattleMemberAttrs)o;
			float ret = obj.MoveSpeed;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index MoveSpeed on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Hp(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleMemberAttrs obj = (NTGBattleMemberAttrs)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.Hp = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index Hp on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Mp(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleMemberAttrs obj = (NTGBattleMemberAttrs)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.Mp = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index Mp on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_HpRecover(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleMemberAttrs obj = (NTGBattleMemberAttrs)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.HpRecover = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index HpRecover on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_MpRecover(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleMemberAttrs obj = (NTGBattleMemberAttrs)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.MpRecover = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index MpRecover on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_PAtk(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleMemberAttrs obj = (NTGBattleMemberAttrs)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.PAtk = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index PAtk on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_MAtk(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleMemberAttrs obj = (NTGBattleMemberAttrs)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.MAtk = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index MAtk on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_PDef(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleMemberAttrs obj = (NTGBattleMemberAttrs)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.PDef = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index PDef on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_MDef(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleMemberAttrs obj = (NTGBattleMemberAttrs)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.MDef = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index MDef on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_pAtkRate(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleMemberAttrs obj = (NTGBattleMemberAttrs)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.pAtkRate = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index pAtkRate on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_mAtkRate(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleMemberAttrs obj = (NTGBattleMemberAttrs)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.mAtkRate = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mAtkRate on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_PPenetrate(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleMemberAttrs obj = (NTGBattleMemberAttrs)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.PPenetrate = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index PPenetrate on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_MPenetrate(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleMemberAttrs obj = (NTGBattleMemberAttrs)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.MPenetrate = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index MPenetrate on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_PPenetrateRate(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleMemberAttrs obj = (NTGBattleMemberAttrs)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.PPenetrateRate = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index PPenetrateRate on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_MPenetrateRate(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleMemberAttrs obj = (NTGBattleMemberAttrs)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.MPenetrateRate = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index MPenetrateRate on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Crit(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleMemberAttrs obj = (NTGBattleMemberAttrs)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.Crit = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index Crit on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_CritEffect(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleMemberAttrs obj = (NTGBattleMemberAttrs)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.CritEffect = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index CritEffect on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_PHpSteal(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleMemberAttrs obj = (NTGBattleMemberAttrs)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.PHpSteal = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index PHpSteal on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_MHpSteal(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleMemberAttrs obj = (NTGBattleMemberAttrs)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.MHpSteal = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index MHpSteal on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Tough(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleMemberAttrs obj = (NTGBattleMemberAttrs)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.Tough = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index Tough on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_AtkSpeed(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleMemberAttrs obj = (NTGBattleMemberAttrs)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.AtkSpeed = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index AtkSpeed on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_CdReduce(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleMemberAttrs obj = (NTGBattleMemberAttrs)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.CdReduce = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index CdReduce on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_MoveSpeed(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGBattleMemberAttrs obj = (NTGBattleMemberAttrs)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.MoveSpeed = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index MoveSpeed on a nil value" : e.Message);
		}
	}
}

