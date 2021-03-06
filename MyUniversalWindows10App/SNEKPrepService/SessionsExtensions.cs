﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Rest;
using MyUniversalWindows10App;
using MyUniversalWindows10App.Models;

namespace MyUniversalWindows10App
{
    public static partial class SessionsExtensions
    {
        /// <param name='operations'>
        /// Reference to the MyUniversalWindows10App.ISessions.
        /// </param>
        /// <param name='search'>
        /// Required.
        /// </param>
        public static IList<Session> FindBySeachterm(this ISessions operations, string search)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ISessions)s).FindBySeachtermAsync(search);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the MyUniversalWindows10App.ISessions.
        /// </param>
        /// <param name='search'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<IList<Session>> FindBySeachtermAsync(this ISessions operations, string search, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<System.Collections.Generic.IList<MyUniversalWindows10App.Models.Session>> result = await operations.FindBySeachtermWithOperationResponseAsync(search, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the MyUniversalWindows10App.ISessions.
        /// </param>
        public static IList<Session> Get(this ISessions operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ISessions)s).GetAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the MyUniversalWindows10App.ISessions.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<IList<Session>> GetAsync(this ISessions operations, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<System.Collections.Generic.IList<MyUniversalWindows10App.Models.Session>> result = await operations.GetWithOperationResponseAsync(cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the MyUniversalWindows10App.ISessions.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        public static Session GetById(this ISessions operations, int id)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ISessions)s).GetByIdAsync(id);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the MyUniversalWindows10App.ISessions.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<Session> GetByIdAsync(this ISessions operations, int id, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<MyUniversalWindows10App.Models.Session> result = await operations.GetByIdWithOperationResponseAsync(id, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the MyUniversalWindows10App.ISessions.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        public static IList<Session> GetBySpeaker(this ISessions operations, int id)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ISessions)s).GetBySpeakerAsync(id);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the MyUniversalWindows10App.ISessions.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<IList<Session>> GetBySpeakerAsync(this ISessions operations, int id, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<System.Collections.Generic.IList<MyUniversalWindows10App.Models.Session>> result = await operations.GetBySpeakerWithOperationResponseAsync(id, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the MyUniversalWindows10App.ISessions.
        /// </param>
        /// <param name='track'>
        /// Required.
        /// </param>
        public static IList<Session> GetByTrack(this ISessions operations, int track)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ISessions)s).GetByTrackAsync(track);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the MyUniversalWindows10App.ISessions.
        /// </param>
        /// <param name='track'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<IList<Session>> GetByTrackAsync(this ISessions operations, int track, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<System.Collections.Generic.IList<MyUniversalWindows10App.Models.Session>> result = await operations.GetByTrackWithOperationResponseAsync(track, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
    }
}
