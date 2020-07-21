using System;
using System.Runtime.InteropServices;

namespace CSAPI
{
    static class EntityAPI
    {
        [DllImport("CPPAPI.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "createEntity")]
        public extern static int CreateEntity();

        [DllImport("CPPAPI.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "p_createEntity")]
        public extern static IntPtr CreateEntityPointer();

        [DllImport("CPPAPI.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "getEntityValue")]
        public extern static int GetEntityValue(int entityId);

        [DllImport("CPPAPI.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "setEntityValue")]
        public extern static void SetEntityValue(int entityId, int value);

        [DllImport("CPPAPI.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "p_getEntityValue")]
        public extern static int GetEntityValueByPointer(IntPtr entity);

        [DllImport("CPPAPI.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "p_setEntityValue")]
        public extern static void SetEntityValueByPointer(IntPtr entity, int value);

        [DllImport("CPPAPI.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "deleteEntity")]
        public extern static void DeleteEntity(IntPtr entity);
    }
}
