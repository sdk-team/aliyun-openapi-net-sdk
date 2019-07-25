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
	public class DescribeStorageListResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeStorageList_StorageList> items;

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

		public List<DescribeStorageList_StorageList> Items
		{
			get
			{
				return items;
			}
			set	
			{
				items = value;
			}
		}

		public class DescribeStorageList_StorageList
		{

			private string classGroup;

			private string classCode;

			private string cpu;

			private string maxConnections;

			private string maxIOPS;

			private string memoryClass;

			private string referencePrice;

			private string classTypeLevel;

			public string ClassGroup
			{
				get
				{
					return classGroup;
				}
				set	
				{
					classGroup = value;
				}
			}

			public string ClassCode
			{
				get
				{
					return classCode;
				}
				set	
				{
					classCode = value;
				}
			}

			public string Cpu
			{
				get
				{
					return cpu;
				}
				set	
				{
					cpu = value;
				}
			}

			public string MaxConnections
			{
				get
				{
					return maxConnections;
				}
				set	
				{
					maxConnections = value;
				}
			}

			public string MaxIOPS
			{
				get
				{
					return maxIOPS;
				}
				set	
				{
					maxIOPS = value;
				}
			}

			public string MemoryClass
			{
				get
				{
					return memoryClass;
				}
				set	
				{
					memoryClass = value;
				}
			}

			public string ReferencePrice
			{
				get
				{
					return referencePrice;
				}
				set	
				{
					referencePrice = value;
				}
			}

			public string ClassTypeLevel
			{
				get
				{
					return classTypeLevel;
				}
				set	
				{
					classTypeLevel = value;
				}
			}
		}
	}
}
