namespace Commands
{
    using System;

    public abstract record Command(Guid UserId);
}
