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

namespace Aliyun.Acs.Ecs.Model.V20160314
{
	public class InnerQueryNcInfoByInstanceIdResponse : AcsResponse
	{

		private string requestId;

		private InnerQueryNcInfoByInstanceId_EcsNcInfo ecsNcInfo;

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

		public InnerQueryNcInfoByInstanceId_EcsNcInfo EcsNcInfo
		{
			get
			{
				return ecsNcInfo;
			}
			set	
			{
				ecsNcInfo = value;
			}
		}

		public class InnerQueryNcInfoByInstanceId_EcsNcInfo
		{

			private string ncIp;

			private int? avaliableDisk;

			private int? totalCpu;

			private int? avaliableMem;

			private int? avaliableCpu;

			private int? totalDisk;

			private string zoneNo;

			private int? totalMem;

			private string rackId;

			private string ncId;

			public string NcIp
			{
				get
				{
					return ncIp;
				}
				set	
				{
					ncIp = value;
				}
			}

			public int? AvaliableDisk
			{
				get
				{
					return avaliableDisk;
				}
				set	
				{
					avaliableDisk = value;
				}
			}

			public int? TotalCpu
			{
				get
				{
					return totalCpu;
				}
				set	
				{
					totalCpu = value;
				}
			}

			public int? AvaliableMem
			{
				get
				{
					return avaliableMem;
				}
				set	
				{
					avaliableMem = value;
				}
			}

			public int? AvaliableCpu
			{
				get
				{
					return avaliableCpu;
				}
				set	
				{
					avaliableCpu = value;
				}
			}

			public int? TotalDisk
			{
				get
				{
					return totalDisk;
				}
				set	
				{
					totalDisk = value;
				}
			}

			public string ZoneNo
			{
				get
				{
					return zoneNo;
				}
				set	
				{
					zoneNo = value;
				}
			}

			public int? TotalMem
			{
				get
				{
					return totalMem;
				}
				set	
				{
					totalMem = value;
				}
			}

			public string RackId
			{
				get
				{
					return rackId;
				}
				set	
				{
					rackId = value;
				}
			}

			public string NcId
			{
				get
				{
					return ncId;
				}
				set	
				{
					ncId = value;
				}
			}
		}
	}
}
