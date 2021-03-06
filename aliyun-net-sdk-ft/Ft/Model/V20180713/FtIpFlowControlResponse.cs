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

namespace Aliyun.Acs.Ft.Model.V20180713
{
	public class FtIpFlowControlResponse : AcsResponse
	{

		private string requestId;

		private List<string> names;

		private List<string> names01;

		private List<string> integerList;

		private List<string> integerList1;

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

		public List<string> Names
		{
			get
			{
				return names;
			}
			set	
			{
				names = value;
			}
		}

		public List<string> Names01
		{
			get
			{
				return names01;
			}
			set	
			{
				names01 = value;
			}
		}

		public List<string> IntegerList
		{
			get
			{
				return integerList;
			}
			set	
			{
				integerList = value;
			}
		}

		public List<string> IntegerList1
		{
			get
			{
				return integerList1;
			}
			set	
			{
				integerList1 = value;
			}
		}
	}
}
