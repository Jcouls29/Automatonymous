﻿// Copyright 2007-2014 Chris Patterson, Dru Sellers, Travis Smith, et. al.
//  
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use
// this file except in compliance with the License. You may obtain a copy of the 
// License at 
// 
//     http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software distributed
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, either express or implied. See the License for the 
// specific language governing permissions and limitations under the License.
namespace Automatonymous
{
    public interface EventContext<out TInstance> :
        InstanceContext<TInstance>
    {
        Event Event { get; }
    }


    /// <summary>
    /// Encapsulates an event that was raised which includes data
    /// </summary>
    /// <typeparam name="TInstance">The state instance the event is targeting</typeparam>
    /// <typeparam name="TData">The event data type</typeparam>
    public interface EventContext<out TInstance, out TData> :
        EventContext<TInstance>
    {
        new Event<TData> Event { get; }

        /// <summary>
        /// The data from the event
        /// </summary>
        TData Data { get; }
    }
}