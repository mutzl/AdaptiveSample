﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Rest;
using MyUniversalWindows10App.Models;

namespace MyUniversalWindows10App
{
    public partial interface ISpeakers
    {
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> DeleteWithOperationResponseAsync(int id, CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<Speaker>>> GetWithOperationResponseAsync(CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        Task<HttpOperationResponse<Speaker>> GetByIdWithOperationResponseAsync(int id, CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        
        /// <param name='searchTerm'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<Speaker>>> GetBySearchTermWithOperationResponseAsync(string searchTerm, CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='speaker'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> PatchWithOperationResponseAsync(int id, Speaker speaker, CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        
        /// <param name='speaker'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> PostWithOperationResponseAsync(Speaker speaker, CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='speaker'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> PutWithOperationResponseAsync(int id, Speaker speaker, CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    }
}
