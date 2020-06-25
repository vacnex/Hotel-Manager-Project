﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace HotelManager
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    /// <summary>
    /// Extension methods for Roombook.
    /// </summary>
    public static partial class RoombookExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<TblRoombook> VGettbl(this IRoombook operations)
            {
                return Task.Factory.StartNew(s => ((IRoombook)s).VGettblAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<TblRoombook>> VGettblAsync(this IRoombook operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.VGettblWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='tblRoombook'>
            /// </param>
            public static TblRoombook Posttbl(this IRoombook operations, TblRoombook tblRoombook)
            {
                return Task.Factory.StartNew(s => ((IRoombook)s).PosttblAsync(tblRoombook), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='tblRoombook'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TblRoombook> PosttblAsync(this IRoombook operations, TblRoombook tblRoombook, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PosttblWithHttpMessagesAsync(tblRoombook, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            public static TblRoombook Gettbl(this IRoombook operations, int id)
            {
                return Task.Factory.StartNew(s => ((IRoombook)s).GettblAsync(id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TblRoombook> GettblAsync(this IRoombook operations, int id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GettblWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='tblRoombook'>
            /// </param>
            public static void Puttbl(this IRoombook operations, int id, TblRoombook tblRoombook)
            {
                Task.Factory.StartNew(s => ((IRoombook)s).PuttblAsync(id, tblRoombook), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='tblRoombook'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PuttblAsync(this IRoombook operations, int id, TblRoombook tblRoombook, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.PuttblWithHttpMessagesAsync(id, tblRoombook, null, cancellationToken).ConfigureAwait(false);
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            public static TblRoombook Deletetbl(this IRoombook operations, int id)
            {
                return Task.Factory.StartNew(s => ((IRoombook)s).DeletetblAsync(id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TblRoombook> DeletetblAsync(this IRoombook operations, int id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeletetblWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
