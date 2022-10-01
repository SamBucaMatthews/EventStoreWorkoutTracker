// <copyright file="IAggregateRepository.cs" company="Sam Matthews">
// Copyright (c) Sam Matthews. All rights reserved.
// </copyright>

namespace Repository
{
    using System;
    using System.Collections.Generic;
    using Events;

    public interface IAggregateRepository
    {
        public void SaveEvents(Guid aggregateId, IEnumerable<Event> events, int expectedVersion);

        public List<Event> GetEventsForAggregate(Guid aggregateId);
    }
}
