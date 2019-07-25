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
using System.Collections.Generic;

using Aliyun.Acs.Core;

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeDBInstanceNetworkResponse : AcsResponse
	{

		private string requestId;

		private string dBInstanceId;

		private string startTime;

		private string endTime;

		private List<DescribeDBInstanceNetwork_TopologyItem> topology;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public string DBInstanceId
		{
			get
			{
				return dBInstanceId;
			}
			set	
			{
				dBInstanceId = value;
			}
		}

		public string StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
			}
		}

		public string EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
			}
		}

		public List<DescribeDBInstanceNetwork_TopologyItem> Topology
		{
			get
			{
				return topology;
			}
			set	
			{
				topology = value;
			}
		}

		public class DescribeDBInstanceNetwork_TopologyItem
		{

			private string startPoint;

			private string endPoint;

			private string networkTrafficIn;

			private string networkTrafficOut;

			private string networkLatency;

			private string backendLatency;

			private string networkErrors;

			public string StartPoint
			{
				get
				{
					return startPoint;
				}
				set	
				{
					startPoint = value;
				}
			}

			public string EndPoint
			{
				get
				{
					return endPoint;
				}
				set	
				{
					endPoint = value;
				}
			}

			public string NetworkTrafficIn
			{
				get
				{
					return networkTrafficIn;
				}
				set	
				{
					networkTrafficIn = value;
				}
			}

			public string NetworkTrafficOut
			{
				get
				{
					return networkTrafficOut;
				}
				set	
				{
					networkTrafficOut = value;
				}
			}

			public string NetworkLatency
			{
				get
				{
					return networkLatency;
				}
				set	
				{
					networkLatency = value;
				}
			}

			public string BackendLatency
			{
				get
				{
					return backendLatency;
				}
				set	
				{
					backendLatency = value;
				}
			}

			public string NetworkErrors
			{
				get
				{
					return networkErrors;
				}
				set	
				{
					networkErrors = value;
				}
			}
		}
	}
}
