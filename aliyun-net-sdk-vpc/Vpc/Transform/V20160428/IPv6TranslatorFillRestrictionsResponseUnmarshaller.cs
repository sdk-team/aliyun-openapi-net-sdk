/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Vpc.Model.V20160428;

namespace Aliyun.Acs.Vpc.Transform.V20160428
{
    public class IPv6TranslatorFillRestrictionsResponseUnmarshaller
    {
        public static IPv6TranslatorFillRestrictionsResponse Unmarshall(UnmarshallerContext context)
        {
			IPv6TranslatorFillRestrictionsResponse iPv6TranslatorFillRestrictionsResponse = new IPv6TranslatorFillRestrictionsResponse();

			iPv6TranslatorFillRestrictionsResponse.HttpResponse = context.HttpResponse;
			iPv6TranslatorFillRestrictionsResponse.RequestId = context.StringValue("IPv6TranslatorFillRestrictions.RequestId");
			iPv6TranslatorFillRestrictionsResponse.Data = context.StringValue("IPv6TranslatorFillRestrictions.Data");
			iPv6TranslatorFillRestrictionsResponse.Code = context.StringValue("IPv6TranslatorFillRestrictions.Code");
			iPv6TranslatorFillRestrictionsResponse.Success = context.BooleanValue("IPv6TranslatorFillRestrictions.Success");
			iPv6TranslatorFillRestrictionsResponse.Message = context.StringValue("IPv6TranslatorFillRestrictions.Message");
        
			return iPv6TranslatorFillRestrictionsResponse;
        }
    }
}
