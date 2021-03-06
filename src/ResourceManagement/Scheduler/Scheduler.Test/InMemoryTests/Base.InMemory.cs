﻿// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// Code generated by Microsoft (R) AutoRest Code Generator {0}
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// 

using Microsoft.Azure;
using Microsoft.Azure.Management.Scheduler;
using Microsoft.Rest;
using Scheduler.Test.Helpers;
using System;

namespace Scheduler.Test.InMemoryTests
{
    public class Base
    {
        protected SchedulerManagementClient GetSchedulerManagementClient(RecordedDelegatingHandler handler)
        {
            var tokenCredential = new TokenCredentials(Guid.NewGuid().ToString(), "abc123");
            handler.IsPassThrough = false;
            var schedulerManagementClient = new SchedulerManagementClient(credentials: tokenCredential, handlers: handler);
            schedulerManagementClient.SubscriptionId = "12345";
            return schedulerManagementClient;
        }
    }
}
