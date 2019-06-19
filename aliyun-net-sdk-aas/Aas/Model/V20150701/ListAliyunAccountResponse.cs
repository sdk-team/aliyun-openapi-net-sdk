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

namespace Aliyun.Acs.Aas.Model.V20150701
{
	public class ListAliyunAccountResponse : AcsResponse
	{

		private string requestId;

		private bool? isTruncated;

		private string marker;

		private int? totalAccount;

		private bool? hasNext;

		private List<ListAliyunAccount_Account> accounts;

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

		public bool? IsTruncated
		{
			get
			{
				return isTruncated;
			}
			set	
			{
				isTruncated = value;
			}
		}

		public string Marker
		{
			get
			{
				return marker;
			}
			set	
			{
				marker = value;
			}
		}

		public int? TotalAccount
		{
			get
			{
				return totalAccount;
			}
			set	
			{
				totalAccount = value;
			}
		}

		public bool? HasNext
		{
			get
			{
				return hasNext;
			}
			set	
			{
				hasNext = value;
			}
		}

		public List<ListAliyunAccount_Account> Accounts
		{
			get
			{
				return accounts;
			}
			set	
			{
				accounts = value;
			}
		}

		public class ListAliyunAccount_Account
		{

			private string pK;

			private string lastLoginDate;

			private string accountStatus;

			private string aliyunId;

			public string PK
			{
				get
				{
					return pK;
				}
				set	
				{
					pK = value;
				}
			}

			public string LastLoginDate
			{
				get
				{
					return lastLoginDate;
				}
				set	
				{
					lastLoginDate = value;
				}
			}

			public string AccountStatus
			{
				get
				{
					return accountStatus;
				}
				set	
				{
					accountStatus = value;
				}
			}

			public string AliyunId
			{
				get
				{
					return aliyunId;
				}
				set	
				{
					aliyunId = value;
				}
			}
		}
	}
}
