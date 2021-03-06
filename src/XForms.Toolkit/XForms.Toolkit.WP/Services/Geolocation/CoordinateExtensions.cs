﻿// ***********************************************************************
// Assembly         : XForms.Toolkit.WP
// Author           : Sami M. Kallio
// Created          : 06-16-2014
//
// Last Modified By : Sami M. Kallio
// Last Modified On : 06-16-2014
// ***********************************************************************
// <copyright file="CoordinateExtensions.cs" company="">
//     Copyright (c) 2014 . All rights reserved.
//
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//
//        http://www.apache.org/licenses/LICENSE-2.0
//
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Windows.Devices.Geolocation;

namespace XForms.Toolkit.Services.Geolocation
{
    /// <summary>
    /// The coordinate extensions for Windows Phone.
    /// </summary>
    public static class CoordinateExtensions
    {
        /// <summary>
        /// Converts <see cref="Geocoordinate"/> class into <see cref="Position"/>.
        /// </summary>
        /// <param name="geocoordinate">
        /// The Geocoordinate.
        /// </param>
        /// <returns>
        /// The <see cref="Position"/>.
        /// </returns>
        public static Position GetPosition(this Geocoordinate geocoordinate)
        {
            return new Position()
            {
                Accuracy = geocoordinate.Accuracy,
                Altitude = geocoordinate.Altitude,
                Heading = geocoordinate.Heading,
                Latitude = geocoordinate.Latitude,
                Longitude = geocoordinate.Longitude,
                Speed = geocoordinate.Speed,
                Timestamp = geocoordinate.Timestamp
            };
        }
    }
}
