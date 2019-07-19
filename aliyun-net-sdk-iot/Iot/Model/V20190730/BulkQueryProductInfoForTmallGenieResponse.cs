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
	public class BulkQueryProductInfoForTmallGenieResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string errorMessage;

		private List<BulkQueryProductInfoForTmallGenie_ProductInfo> list;

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

		public List<BulkQueryProductInfoForTmallGenie_ProductInfo> List
		{
			get
			{
				return list;
			}
			set	
			{
				list = value;
			}
		}

		public class BulkQueryProductInfoForTmallGenie_ProductInfo
		{

			private string gmtCreate;

			private int? dataFormat;

			private string description;

			private int? deviceCount;

			private int? netType;

			private int? nodeType;

			private string productKey;

			private string productName;

			private string productModel;

			private string productSecret;

			private string productStatus;

			private long? scriptId;

			private string scriptDraftCode;

			public string GmtCreate
			{
				get
				{
					return gmtCreate;
				}
				set	
				{
					gmtCreate = value;
				}
			}

			public int? DataFormat
			{
				get
				{
					return dataFormat;
				}
				set	
				{
					dataFormat = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}

			public int? DeviceCount
			{
				get
				{
					return deviceCount;
				}
				set	
				{
					deviceCount = value;
				}
			}

			public int? NetType
			{
				get
				{
					return netType;
				}
				set	
				{
					netType = value;
				}
			}

			public int? NodeType
			{
				get
				{
					return nodeType;
				}
				set	
				{
					nodeType = value;
				}
			}

			public string ProductKey
			{
				get
				{
					return productKey;
				}
				set	
				{
					productKey = value;
				}
			}

			public string ProductName
			{
				get
				{
					return productName;
				}
				set	
				{
					productName = value;
				}
			}

			public string ProductModel
			{
				get
				{
					return productModel;
				}
				set	
				{
					productModel = value;
				}
			}

			public string ProductSecret
			{
				get
				{
					return productSecret;
				}
				set	
				{
					productSecret = value;
				}
			}

			public string ProductStatus
			{
				get
				{
					return productStatus;
				}
				set	
				{
					productStatus = value;
				}
			}

			public long? ScriptId
			{
				get
				{
					return scriptId;
				}
				set	
				{
					scriptId = value;
				}
			}

			public string ScriptDraftCode
			{
				get
				{
					return scriptDraftCode;
				}
				set	
				{
					scriptDraftCode = value;
				}
			}
		}
	}
}
