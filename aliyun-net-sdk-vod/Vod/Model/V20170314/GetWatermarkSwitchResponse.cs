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

namespace Aliyun.Acs.vod.Model.V20170314
{
	public class GetWatermarkSwitchResponse : AcsResponse
	{

		private string requestId;

		private GetWatermarkSwitch_WaterMarkSwitch waterMarkSwitch;

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

		public GetWatermarkSwitch_WaterMarkSwitch WaterMarkSwitch
		{
			get
			{
				return waterMarkSwitch;
			}
			set	
			{
				waterMarkSwitch = value;
			}
		}

		public class GetWatermarkSwitch_WaterMarkSwitch
		{

			private int? createTime;

			private int? updateTime;

			private string active;

			private string customerId;

			public int? CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public int? UpdateTime
			{
				get
				{
					return updateTime;
				}
				set	
				{
					updateTime = value;
				}
			}

			public string Active
			{
				get
				{
					return active;
				}
				set	
				{
					active = value;
				}
			}

			public string CustomerId
			{
				get
				{
					return customerId;
				}
				set	
				{
					customerId = value;
				}
			}
		}
	}
}
