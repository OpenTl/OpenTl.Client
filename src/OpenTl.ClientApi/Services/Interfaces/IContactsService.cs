﻿namespace OpenTl.ClientApi.Services.Interfaces
{
    using System.Threading;
    using System.Threading.Tasks;

    using OpenTl.Schema.Contacts;

    // <summary>Working with contacts</summary>
    public interface IContactsService
    {
        /// <summary>Returns the current user’s contact list</summary>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>Contacts</returns>
        Task<TContacts> GetContactsAsync(CancellationToken cancellationToken = default(CancellationToken));

        // /// <summary>
        // /// Returns the list of contact statuses.
        // /// </summary>
        // /// <param name="cancellationToken">Cancellation token</param>
        // /// <returns>Statuses</returns>
        // Task<IReadOnlyList<TContactStatus>> GetStatusesAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>Serch user or chat. By default the limit is 10.</summary>
        /// <param name="query">User or chat name</param>
        /// <param name="limit">Max result count</param>
        /// <param name="cancellationToken">A cancellation token</param>
        /// <returns>Found users</returns>
        Task<IFound> SearchUserAsync(string query, int limit = 10, CancellationToken cancellationToken = default(CancellationToken));
    }
}