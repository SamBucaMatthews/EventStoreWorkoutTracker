// <copyright file="IHandle.cs" company="Sam Matthews">
// Copyright (c) Sam Matthews. All rights reserved.
// </copyright>

namespace CommandHandlers
{
    using Commands;

    public interface IHandle<in T>
        where T : Command
    {
        public void Handle(T command);
    }
}
