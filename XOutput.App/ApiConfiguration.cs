﻿using XOutput.Api.Serialization;
using XOutput.Core.DependencyInjection;

namespace XOutput.App
{
    public static class ApiConfiguration
    {
        [ResolverMethod]
        public static MessageReader GetMessageReader()
        {
            return new MessageReader();
        }

        [ResolverMethod]
        public static MessageWriter GetMessageWriter()
        {
            return new MessageWriter();
        }
    }
}
