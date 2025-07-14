/*
Copyright (c) 2015-2017 topameng(topameng@qq.com)

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/
using System;
using System.Collections.Generic;
using System.Reflection;

namespace LuaInterface
{
    //代表一个反射函数
    public sealed class LuaMethod
    {        
        MethodInfo method = null;
        List<Type> list = new List<Type>();
        Type kclass = null;
        public MethodInfo Method => method;

        // [NoToLuaAttribute]
        public LuaMethod(MethodInfo md, Type t, Type[] types = null)
        {
            method = md;
            kclass = t;            

            if (types != null)
            {
                list.AddRange(types);
            }
            else
            {
                foreach(ParameterInfo paramInfo in md.GetParameters())
                {
                    list.Add(paramInfo.ParameterType);
                }
            }
        }

        public LuaMethod MakeGenericMethod(Type[] types)
        {
            MethodInfo mi = method.MakeGenericMethod(types);
            return new LuaMethod(mi, kclass);
        }
        
        public int Call(IntPtr L)
        {            
            object[] args = null;
            object obj = null;
            int offset = 1;

            if (!method.IsStatic)
            {
                offset += 1;
                obj = ToLua.CheckObject(L, 2, kclass);
            }

            ToLua.CheckArgsCount(L, list.Count + offset);

            if (list.Count > 0)
            {
                args = new object[list.Count];
                offset += 1;

                for (int i = 0; i < list.Count; i++)
                {
                    bool isRef = list[i].IsByRef;
                    Type t0 = isRef ? list[i].GetElementType() : list[i];
                    object o = ToLua.CheckVarObject(L, i + offset, t0);                    
                    args[i] = o;
                }
            }
            
            object ret = method.Invoke(obj, args);
            int count = 0;

            if (method.ReturnType != typeof(void))
            {
                ++count;
                ToLua.Push(L, ret);
            }

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].IsByRef)
                {
                    ++count;
                    ToLua.Push(L, args[i]);
                }
            }

            return count;
        }

        
        public int CallRaw(IntPtr L)
        {            
            object[] args = null;
            object obj = null;
            int offset = 1;

            if (!method.IsStatic)
            {
                offset += 1;
                obj = ToLua.CheckObject(L, 2, kclass);
            }

            ToLua.CheckArgsCount(L, list.Count + offset);

            if (list.Count > 0)
            {
                args = new object[list.Count];
                offset += 1;

                for (int i = 0; i < list.Count; i++)
                {
                    bool isRef = list[i].IsByRef;
                    Type t0 = isRef ? list[i].GetElementType() : list[i];
                    object o = ToLua.CheckObject(L, i + offset, t0);                    
                    args[i] = o;
                }
            }
            
            object ret = method.Invoke(obj, args);
            int count = 0;

            if (method.ReturnType != typeof(void))
            {
                ++count;
                ToLua.PushObject(L, ret);
            }

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].IsByRef)
                {
                    ++count;
                    ToLua.PushObject(L, args[i]);
                }
            }

            return count;
        }

        public void Destroy()
        {
            method = null;
            list.Clear();
        }
    }
}
