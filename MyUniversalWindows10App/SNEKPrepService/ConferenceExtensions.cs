﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Rest;
using MyUniversalWindows10App;
using MyUniversalWindows10App.Models;

namespace MyUniversalWindows10App
{
    public static partial class ConferenceExtensions
    {
        /// <param name='operations'>
        /// Reference to the MyUniversalWindows10App.IConference.
        /// </param>
        public static int AvailableSeats(this IConference operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IConference)s).AvailableSeatsAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the MyUniversalWindows10App.IConference.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<int> AvailableSeatsAsync(this IConference operations, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<int> result = await operations.AvailableSeatsWithOperationResponseAsync(cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the MyUniversalWindows10App.IConference.
        /// </param>
        public static Speaker GetTopSpeaker(this IConference operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IConference)s).GetTopSpeakerAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the MyUniversalWindows10App.IConference.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<Speaker> GetTopSpeakerAsync(this IConference operations, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<MyUniversalWindows10App.Models.Speaker> result = await operations.GetTopSpeakerWithOperationResponseAsync(cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the MyUniversalWindows10App.IConference.
        /// </param>
        public static string GetTopSpeakerName(this IConference operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IConference)s).GetTopSpeakerNameAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the MyUniversalWindows10App.IConference.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<string> GetTopSpeakerNameAsync(this IConference operations, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<string> result = await operations.GetTopSpeakerNameWithOperationResponseAsync(cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the MyUniversalWindows10App.IConference.
        /// </param>
        public static SpeakerInfo GetTopSpeakers(this IConference operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IConference)s).GetTopSpeakersAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the MyUniversalWindows10App.IConference.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<SpeakerInfo> GetTopSpeakersAsync(this IConference operations, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<MyUniversalWindows10App.Models.SpeakerInfo> result = await operations.GetTopSpeakersWithOperationResponseAsync(cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
    }
}