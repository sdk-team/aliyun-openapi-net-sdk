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
    public class DescribeBandwidthPackageMonitorDataResponseUnmarshaller
    {
        public static DescribeBandwidthPackageMonitorDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeBandwidthPackageMonitorDataResponse describeBandwidthPackageMonitorDataResponse = new DescribeBandwidthPackageMonitorDataResponse();

			describeBandwidthPackageMonitorDataResponse.HttpResponse = context.HttpResponse;
			describeBandwidthPackageMonitorDataResponse.RequestId = context.StringValue("DescribeBandwidthPackageMonitorData.RequestId");

			List<DescribeBandwidthPackageMonitorDataResponse.DescribeBandwidthPackageMonitorData_MonitorData> describeBandwidthPackageMonitorDataResponse_monitorDatas = new List<DescribeBandwidthPackageMonitorDataResponse.DescribeBandwidthPackageMonitorData_MonitorData>();
			for (int i = 0; i < context.Length("DescribeBandwidthPackageMonitorData.MonitorDatas.Length"); i++) {
				DescribeBandwidthPackageMonitorDataResponse.DescribeBandwidthPackageMonitorData_MonitorData monitorData = new DescribeBandwidthPackageMonitorDataResponse.DescribeBandwidthPackageMonitorData_MonitorData();
				monitorData.RX = context.LongValue("DescribeBandwidthPackageMonitorData.MonitorDatas["+ i +"].RX");
				monitorData.TX = context.LongValue("DescribeBandwidthPackageMonitorData.MonitorDatas["+ i +"].TX");
				monitorData.ReceivedBandwidth = context.LongValue("DescribeBandwidthPackageMonitorData.MonitorDatas["+ i +"].ReceivedBandwidth");
				monitorData.TransportedBandwidth = context.LongValue("DescribeBandwidthPackageMonitorData.MonitorDatas["+ i +"].TransportedBandwidth");
				monitorData.Flow = context.LongValue("DescribeBandwidthPackageMonitorData.MonitorDatas["+ i +"].Flow");
				monitorData.Bandwidth = context.LongValue("DescribeBandwidthPackageMonitorData.MonitorDatas["+ i +"].Bandwidth");
				monitorData.Packets = context.LongValue("DescribeBandwidthPackageMonitorData.MonitorDatas["+ i +"].Packets");
				monitorData.TimeStamp = context.StringValue("DescribeBandwidthPackageMonitorData.MonitorDatas["+ i +"].TimeStamp");

				describeBandwidthPackageMonitorDataResponse_monitorDatas.Add(monitorData);
			}
			describeBandwidthPackageMonitorDataResponse.MonitorDatas = describeBandwidthPackageMonitorDataResponse_monitorDatas;
        
			return describeBandwidthPackageMonitorDataResponse;
        }
    }
}
