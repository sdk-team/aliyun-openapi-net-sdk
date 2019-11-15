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
using Aliyun.Acs.Ecs.Model.V20160314;

namespace Aliyun.Acs.Ecs.Transform.V20160314
{
    public class DescribeDedicatedHostAutoRenewResponseUnmarshaller
    {
        public static DescribeDedicatedHostAutoRenewResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDedicatedHostAutoRenewResponse describeDedicatedHostAutoRenewResponse = new DescribeDedicatedHostAutoRenewResponse();

			describeDedicatedHostAutoRenewResponse.HttpResponse = context.HttpResponse;
			describeDedicatedHostAutoRenewResponse.RequestId = context.StringValue("DescribeDedicatedHostAutoRenew.RequestId");

			List<DescribeDedicatedHostAutoRenewResponse.DescribeDedicatedHostAutoRenew_InstanceRenewAttribute> describeDedicatedHostAutoRenewResponse_instanceRenewAttributes = new List<DescribeDedicatedHostAutoRenewResponse.DescribeDedicatedHostAutoRenew_InstanceRenewAttribute>();
			for (int i = 0; i < context.Length("DescribeDedicatedHostAutoRenew.InstanceRenewAttributes.Length"); i++) {
				DescribeDedicatedHostAutoRenewResponse.DescribeDedicatedHostAutoRenew_InstanceRenewAttribute instanceRenewAttribute = new DescribeDedicatedHostAutoRenewResponse.DescribeDedicatedHostAutoRenew_InstanceRenewAttribute();
				instanceRenewAttribute.InstanceId = context.StringValue("DescribeDedicatedHostAutoRenew.InstanceRenewAttributes["+ i +"].InstanceId");
				instanceRenewAttribute.AutoRenewEnabled = context.BooleanValue("DescribeDedicatedHostAutoRenew.InstanceRenewAttributes["+ i +"].AutoRenewEnabled");
				instanceRenewAttribute.Duration = context.IntegerValue("DescribeDedicatedHostAutoRenew.InstanceRenewAttributes["+ i +"].Duration");
				instanceRenewAttribute.PeriodUnit = context.StringValue("DescribeDedicatedHostAutoRenew.InstanceRenewAttributes["+ i +"].PeriodUnit");
				instanceRenewAttribute.RenewalStatus = context.StringValue("DescribeDedicatedHostAutoRenew.InstanceRenewAttributes["+ i +"].RenewalStatus");

				describeDedicatedHostAutoRenewResponse_instanceRenewAttributes.Add(instanceRenewAttribute);
			}
			describeDedicatedHostAutoRenewResponse.InstanceRenewAttributes = describeDedicatedHostAutoRenewResponse_instanceRenewAttributes;
        
			return describeDedicatedHostAutoRenewResponse;
        }
    }
}
