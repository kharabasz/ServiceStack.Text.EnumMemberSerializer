﻿using System;

namespace ServiceStack.Text.EnumMemberSerializer
{
    internal interface IEnumSerializerInitializerProxy
    {
        void ConfigEnumSerializers(Type type);
    }
}