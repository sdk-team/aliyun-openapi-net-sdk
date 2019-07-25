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
	public class DescribeAvailableRecoveryTimeResponse : AcsResponse
	{

		private string requestId;

		private string recoveryBeginTime;

		private string recoveryEndTime;

		private string dBInstanceId;

		private string regionId;

		private int? crossBackupId;

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

		public string RecoveryBeginTime
		{
			get
			{
				return recoveryBeginTime;
			}
			set	
			{
				recoveryBeginTime = value;
			}
		}

		public string RecoveryEndTime
		{
			get
			{
				return recoveryEndTime;
			}
			set	
			{
				recoveryEndTime = value;
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

		public string RegionId
		{
			get
			{
				return regionId;
			}
			set	
			{
				regionId = value;
			}
		}

		public int? CrossBackupId
		{
			get
			{
				return crossBackupId;
			}
			set	
			{
				crossBackupId = value;
			}
		}
	}
}
