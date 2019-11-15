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
	public class InnerMonitorDataDescribeInstanceResponse : AcsResponse
	{

		private string requestId;

		private int? count;

		private List<InnerMonitorDataDescribeInstance_Item> data;

		private InnerMonitorDataDescribeInstance_ErrorCode errorCode;

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

		public int? Count
		{
			get
			{
				return count;
			}
			set	
			{
				count = value;
			}
		}

		public List<InnerMonitorDataDescribeInstance_Item> Data
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

		public InnerMonitorDataDescribeInstance_ErrorCode ErrorCode
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

		public class InnerMonitorDataDescribeInstance_Item
		{

			private string timeStamp;

			private string resourceStatus;

			private string resourceId;

			private InnerMonitorDataDescribeInstance_Item2Value item2Value;

			public string TimeStamp
			{
				get
				{
					return timeStamp;
				}
				set	
				{
					timeStamp = value;
				}
			}

			public string ResourceStatus
			{
				get
				{
					return resourceStatus;
				}
				set	
				{
					resourceStatus = value;
				}
			}

			public string ResourceId
			{
				get
				{
					return resourceId;
				}
				set	
				{
					resourceId = value;
				}
			}

			public InnerMonitorDataDescribeInstance_Item2Value Item2Value
			{
				get
				{
					return item2Value;
				}
				set	
				{
					item2Value = value;
				}
			}

			public class InnerMonitorDataDescribeInstance_Item2Value
			{

				private int? cPU;

				private int? intranetRX;

				private int? intranetTX;

				private int? intranetBandwidth;

				private int? internetRX;

				private int? internetTX;

				private int? internetBandwidth;

				private int? iOPSRead;

				private int? iOPSWrite;

				private int? bPSRead;

				private int? bPSWrite;

				public int? CPU
				{
					get
					{
						return cPU;
					}
					set	
					{
						cPU = value;
					}
				}

				public int? IntranetRX
				{
					get
					{
						return intranetRX;
					}
					set	
					{
						intranetRX = value;
					}
				}

				public int? IntranetTX
				{
					get
					{
						return intranetTX;
					}
					set	
					{
						intranetTX = value;
					}
				}

				public int? IntranetBandwidth
				{
					get
					{
						return intranetBandwidth;
					}
					set	
					{
						intranetBandwidth = value;
					}
				}

				public int? InternetRX
				{
					get
					{
						return internetRX;
					}
					set	
					{
						internetRX = value;
					}
				}

				public int? InternetTX
				{
					get
					{
						return internetTX;
					}
					set	
					{
						internetTX = value;
					}
				}

				public int? InternetBandwidth
				{
					get
					{
						return internetBandwidth;
					}
					set	
					{
						internetBandwidth = value;
					}
				}

				public int? IOPSRead
				{
					get
					{
						return iOPSRead;
					}
					set	
					{
						iOPSRead = value;
					}
				}

				public int? IOPSWrite
				{
					get
					{
						return iOPSWrite;
					}
					set	
					{
						iOPSWrite = value;
					}
				}

				public int? BPSRead
				{
					get
					{
						return bPSRead;
					}
					set	
					{
						bPSRead = value;
					}
				}

				public int? BPSWrite
				{
					get
					{
						return bPSWrite;
					}
					set	
					{
						bPSWrite = value;
					}
				}
			}
		}

		public class InnerMonitorDataDescribeInstance_ErrorCode
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
	}
}
