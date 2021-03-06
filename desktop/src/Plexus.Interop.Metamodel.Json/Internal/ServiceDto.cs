/**
 * Copyright 2017-2020 Plexus Interop Deutsche Bank AG
 * SPDX-License-Identifier: Apache-2.0
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
namespace Plexus.Interop.Metamodel.Json.Internal
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    internal sealed class ServiceDto
    {
        private List<MethodDto> _methods = new List<MethodDto>();
        private List<OptionDto> _options = new List<OptionDto>();

        [DataMember(Name = "id")]
        public string Id { get; set; }
        
        [DataMember(Name = "methods")]
        public List<MethodDto> Methods
        {
            get => _methods = _methods ?? new List<MethodDto>();
            set => _methods = value ?? new List<MethodDto>();
        }

        [DataMember(Name = "options")]
        public List<OptionDto> Options
        {
            get => _options = _options ?? new List<OptionDto>();
            set => _options = value ?? new List<OptionDto>();
        }
    }
}