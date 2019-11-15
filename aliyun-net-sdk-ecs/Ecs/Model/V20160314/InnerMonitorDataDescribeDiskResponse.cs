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
	public class InnerMonitorDataDescribeDiskResponse : AcsResponse
	{

		private string requestId;

		private int? count;

		private List<InnerMonitorDataDescribeDisk_Item> data;

		private InnerMonitorDataDescribeDisk_ErrorCode errorCode;

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

		public List<InnerMonitorDataDescribeDisk_Item> Data
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

		public InnerMonitorDataDescribeDisk_ErrorCode ErrorCode
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

		public class InnerMonitorDataDescribeDisk_Item
		{

			private string timeStamp;

			private string resourceStatus;

			private string resourceId;

			private InnerMonitorDataDescribeDisk_Item2Value item2Value;

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

			public InnerMonitorDataDescribeDisk_Item2Value Item2Value
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

			public class InnerMonitorDataDescribeDisk_Item2Value
			{

				private int? bPSRead;

				private int? bPSWrite;

				private int? iOPSRead;

				private int? iOPSWrite;

				private int? latencyRead;

				private int? latencyWrite;

				private int? iOBlockRead;

				private int? iOBlockWrite;

				private int? bPSTotal;

				private int? iOPSTotal;

				private int? iOBlockTotal;

				private int? readPercent;

				private int? writePercent;

				private int? latencyTotal;

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

				public int? LatencyRead
				{
					get
					{
						return latencyRead;
					}
					set	
					{
						latencyRead = value;
					}
				}

				public int? LatencyWrite
				{
					get
					{
						return latencyWrite;
					}
					set	
					{
						latencyWrite = value;
					}
				}

				public int? IOBlockRead
				{
					get
					{
						return iOBlockRead;
					}
					set	
					{
						iOBlockRead = value;
					}
				}

				public int? IOBlockWrite
				{
					get
					{
						return iOBlockWrite;
					}
					set	
					{
						iOBlockWrite = value;
					}
				}

				public int? BPSTotal
				{
					get
					{
						return bPSTotal;
					}
					set	
					{
						bPSTotal = value;
					}
				}

				public int? IOPSTotal
				{
					get
					{
						return iOPSTotal;
					}
					set	
					{
						iOPSTotal = value;
					}
				}

				public int? IOBlockTotal
				{
					get
					{
						return iOBlockTotal;
					}
					set	
					{
						iOBlockTotal = value;
					}
				}

				public int? ReadPercent
				{
					get
					{
						return readPercent;
					}
					set	
					{
						readPercent = value;
					}
				}

				public int? WritePercent
				{
					get
					{
						return writePercent;
					}
					set	
					{
						writePercent = value;
					}
				}

				public int? LatencyTotal
				{
					get
					{
						return latencyTotal;
					}
					set	
					{
						latencyTotal = value;
					}
				}
			}
		}

		public class InnerMonitorDataDescribeDisk_ErrorCode
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
