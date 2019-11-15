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
	public class InnerEcsQueryNcInfoByInstanceIdResponse : AcsResponse
	{

		private string requestId;

		private InnerEcsQueryNcInfoByInstanceId_ErrorCode errorCode;

		private InnerEcsQueryNcInfoByInstanceId_Data data;

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

		public InnerEcsQueryNcInfoByInstanceId_ErrorCode ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
			}
		}

		public InnerEcsQueryNcInfoByInstanceId_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class InnerEcsQueryNcInfoByInstanceId_ErrorCode
		{

			private string code;

			private string message;

			private bool? isSuccess;

			public string Code
			{
				get
				{
					return code;
				}
				set	
				{
					code = value;
				}
			}

			public string Message
			{
				get
				{
					return message;
				}
				set	
				{
					message = value;
				}
			}

			public bool? IsSuccess
			{
				get
				{
					return isSuccess;
				}
				set	
				{
					isSuccess = value;
				}
			}
		}

		public class InnerEcsQueryNcInfoByInstanceId_Data
		{

			private string ncId;

			private string ncIp;

			private string rackId;

			private string zoneNo;

			private int? avaliableDisk;

			private int? totalDisk;

			private int? avaliableCpu;

			private int? totalCpu;

			private int? avaliableMem;

			private int? totalMem;

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
		}
	}
}
