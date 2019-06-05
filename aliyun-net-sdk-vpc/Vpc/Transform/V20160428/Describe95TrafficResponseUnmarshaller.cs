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
    public class Describe95TrafficResponseUnmarshaller
    {
        public static Describe95TrafficResponse Unmarshall(UnmarshallerContext context)
        {
			Describe95TrafficResponse describe95TrafficResponse = new Describe95TrafficResponse();

			describe95TrafficResponse.HttpResponse = context.HttpResponse;
			describe95TrafficResponse.RequestId = context.StringValue("Describe95Traffic.RequestId");

			Describe95TrafficResponse.Describe95Traffic_Traffic95Summary traffic95Summary = new Describe95TrafficResponse.Describe95Traffic_Traffic95Summary();
			traffic95Summary.InstanceId = context.StringValue("Describe95Traffic.Traffic95Summary.InstanceId");
			traffic95Summary.Bandwidth = context.LongValue("Describe95Traffic.Traffic95Summary.Bandwidth");
			traffic95Summary.MinimumConsumeBandwidth = context.StringValue("Describe95Traffic.Traffic95Summary.MinimumConsumeBandwidth");
			traffic95Summary.FifthPeakBandwidth = context.StringValue("Describe95Traffic.Traffic95Summary.FifthPeakBandwidth");
			traffic95Summary.InternetChargeType = context.StringValue("Describe95Traffic.Traffic95Summary.InternetChargeType");
			traffic95Summary.FifthPeakBandwidth1 = context.StringValue("Describe95Traffic.Traffic95Summary.FifthPeakBandwidth");

			List<Describe95TrafficResponse.Describe95Traffic_Traffic95Summary.Describe95Traffic_Traffic95Detail> traffic95Summary_traffic95DetailList = new List<Describe95TrafficResponse.Describe95Traffic_Traffic95Summary.Describe95Traffic_Traffic95Detail>();
			for (int i = 0; i < context.Length("Describe95Traffic.Traffic95Summary.Traffic95DetailList.Length"); i++) {
				Describe95TrafficResponse.Describe95Traffic_Traffic95Summary.Describe95Traffic_Traffic95Detail traffic95Detail = new Describe95TrafficResponse.Describe95Traffic_Traffic95Summary.Describe95Traffic_Traffic95Detail();
				traffic95Detail.Time = context.StringValue("Describe95Traffic.Traffic95Summary.Traffic95DetailList["+ i +"].Time");
				traffic95Detail.InBandwidth = context.StringValue("Describe95Traffic.Traffic95Summary.Traffic95DetailList["+ i +"].InBandwidth");
				traffic95Detail.OutBandwidth = context.StringValue("Describe95Traffic.Traffic95Summary.Traffic95DetailList["+ i +"].OutBandwidth");
				traffic95Detail.BillBandwidth = context.StringValue("Describe95Traffic.Traffic95Summary.Traffic95DetailList["+ i +"].BillBandwidth");

				traffic95Summary_traffic95DetailList.Add(traffic95Detail);
			}
			traffic95Summary.Traffic95DetailList = traffic95Summary_traffic95DetailList;
			describe95TrafficResponse.Traffic95Summary = traffic95Summary;
        
			return describe95TrafficResponse;
        }
    }
}
