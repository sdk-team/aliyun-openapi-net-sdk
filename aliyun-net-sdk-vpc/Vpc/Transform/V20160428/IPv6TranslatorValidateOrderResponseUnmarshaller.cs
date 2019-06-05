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
    public class IPv6TranslatorValidateOrderResponseUnmarshaller
    {
        public static IPv6TranslatorValidateOrderResponse Unmarshall(UnmarshallerContext context)
        {
			IPv6TranslatorValidateOrderResponse iPv6TranslatorValidateOrderResponse = new IPv6TranslatorValidateOrderResponse();

			iPv6TranslatorValidateOrderResponse.HttpResponse = context.HttpResponse;
			iPv6TranslatorValidateOrderResponse.RequestId = context.StringValue("IPv6TranslatorValidateOrder.RequestId");
			iPv6TranslatorValidateOrderResponse.Data = context.StringValue("IPv6TranslatorValidateOrder.Data");
			iPv6TranslatorValidateOrderResponse.Code = context.StringValue("IPv6TranslatorValidateOrder.Code");
			iPv6TranslatorValidateOrderResponse.Success = context.BooleanValue("IPv6TranslatorValidateOrder.Success");
			iPv6TranslatorValidateOrderResponse.Message = context.StringValue("IPv6TranslatorValidateOrder.Message");
        
			return iPv6TranslatorValidateOrderResponse;
        }
    }
}
