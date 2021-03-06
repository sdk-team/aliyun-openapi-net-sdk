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
	public class GetAccountKinShipInfoByPKResponse : AcsResponse
	{

		private string requestId;

		private string pK;

		private string parentPk;

		private string partnerPk;

		private string accountStructure;

		private string accountName;

		private bool? isSubAccount;

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

		public string ParentPk
		{
			get
			{
				return parentPk;
			}
			set	
			{
				parentPk = value;
			}
		}

		public string PartnerPk
		{
			get
			{
				return partnerPk;
			}
			set	
			{
				partnerPk = value;
			}
		}

		public string AccountStructure
		{
			get
			{
				return accountStructure;
			}
			set	
			{
				accountStructure = value;
			}
		}

		public string AccountName
		{
			get
			{
				return accountName;
			}
			set	
			{
				accountName = value;
			}
		}

		public bool? IsSubAccount
		{
			get
			{
				return isSubAccount;
			}
			set	
			{
				isSubAccount = value;
			}
		}
	}
}
