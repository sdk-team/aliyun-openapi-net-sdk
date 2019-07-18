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

namespace Aliyun.Acs.Iot.Model.V20190730
{
	public class QueryDeviceLocalLogContentResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string errorMessage;

		private QueryDeviceLocalLogContent_Data data;

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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

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

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
			}
		}

		public QueryDeviceLocalLogContent_Data Data
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

		public class QueryDeviceLocalLogContent_Data
		{

			private long? count;

			private int? totalPage;

			private int? currentPage;

			private int? pageSize;

			private List<QueryDeviceLocalLogContent_DeviceLocalLogContentInfo> logs;

			public long? Count
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

			public int? TotalPage
			{
				get
				{
					return totalPage;
				}
				set	
				{
					totalPage = value;
				}
			}

			public int? CurrentPage
			{
				get
				{
					return currentPage;
				}
				set	
				{
					currentPage = value;
				}
			}

			public int? PageSize
			{
				get
				{
					return pageSize;
				}
				set	
				{
					pageSize = value;
				}
			}

			public List<QueryDeviceLocalLogContent_DeviceLocalLogContentInfo> Logs
			{
				get
				{
					return logs;
				}
				set	
				{
					logs = value;
				}
			}

			public class QueryDeviceLocalLogContent_DeviceLocalLogContentInfo
			{

				private string logTime;

				private string content;

				public string LogTime
				{
					get
					{
						return logTime;
					}
					set	
					{
						logTime = value;
					}
				}

				public string Content
				{
					get
					{
						return content;
					}
					set	
					{
						content = value;
					}
				}
			}
		}
	}
}
