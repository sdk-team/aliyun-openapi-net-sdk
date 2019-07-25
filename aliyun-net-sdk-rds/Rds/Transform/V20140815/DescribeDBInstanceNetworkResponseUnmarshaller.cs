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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeDBInstanceNetworkResponseUnmarshaller
    {
        public static DescribeDBInstanceNetworkResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDBInstanceNetworkResponse describeDBInstanceNetworkResponse = new DescribeDBInstanceNetworkResponse();

			describeDBInstanceNetworkResponse.HttpResponse = context.HttpResponse;
			describeDBInstanceNetworkResponse.RequestId = context.StringValue("DescribeDBInstanceNetwork.RequestId");
			describeDBInstanceNetworkResponse.DBInstanceId = context.StringValue("DescribeDBInstanceNetwork.DBInstanceId");
			describeDBInstanceNetworkResponse.StartTime = context.StringValue("DescribeDBInstanceNetwork.StartTime");
			describeDBInstanceNetworkResponse.EndTime = context.StringValue("DescribeDBInstanceNetwork.EndTime");

			List<DescribeDBInstanceNetworkResponse.DescribeDBInstanceNetwork_TopologyItem> describeDBInstanceNetworkResponse_topology = new List<DescribeDBInstanceNetworkResponse.DescribeDBInstanceNetwork_TopologyItem>();
			for (int i = 0; i < context.Length("DescribeDBInstanceNetwork.Topology.Length"); i++) {
				DescribeDBInstanceNetworkResponse.DescribeDBInstanceNetwork_TopologyItem topologyItem = new DescribeDBInstanceNetworkResponse.DescribeDBInstanceNetwork_TopologyItem();
				topologyItem.StartPoint = context.StringValue("DescribeDBInstanceNetwork.Topology["+ i +"].StartPoint");
				topologyItem.EndPoint = context.StringValue("DescribeDBInstanceNetwork.Topology["+ i +"].EndPoint");
				topologyItem.NetworkTrafficIn = context.StringValue("DescribeDBInstanceNetwork.Topology["+ i +"].NetworkTrafficIn");
				topologyItem.NetworkTrafficOut = context.StringValue("DescribeDBInstanceNetwork.Topology["+ i +"].NetworkTrafficOut");
				topologyItem.NetworkLatency = context.StringValue("DescribeDBInstanceNetwork.Topology["+ i +"].NetworkLatency");
				topologyItem.BackendLatency = context.StringValue("DescribeDBInstanceNetwork.Topology["+ i +"].BackendLatency");
				topologyItem.NetworkErrors = context.StringValue("DescribeDBInstanceNetwork.Topology["+ i +"].NetworkErrors");

				describeDBInstanceNetworkResponse_topology.Add(topologyItem);
			}
			describeDBInstanceNetworkResponse.Topology = describeDBInstanceNetworkResponse_topology;
        
			return describeDBInstanceNetworkResponse;
        }
    }
}
