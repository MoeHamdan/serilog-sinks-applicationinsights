﻿// Copyright 2016 Serilog Contributors
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Serilog.Sinks.ApplicationInsights.Sinks.ApplicationInsights.TelemetryConverters;

namespace Serilog
{
    public static class TelemetryConverter
    {
        public static ITelemetryConverter Traces => new TraceTelemetryConverter();

        public static ITelemetryConverter Events => new EventTelemetryConverter();

        /// <summary>
        /// Similar to Events, however it allows logging LogLevel and Template
        /// </summary>
        public static ITelemetryConverter EventsDetailed => new EventDetailTelemetryConverter();
    }
}
