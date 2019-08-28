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
	public class GetCDNStatisResponse : AcsResponse
	{

		private string requestId;

		private long? sumFlowDataValue;

		private long? maxBpsDataValue;

		private long? current95BpsDataValue;

		private List<GetCDNStatis_CDNMetric> cDNStatisList;

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

		public long? SumFlowDataValue
		{
			get
			{
				return sumFlowDataValue;
			}
			set	
			{
				sumFlowDataValue = value;
			}
		}

		public long? MaxBpsDataValue
		{
			get
			{
				return maxBpsDataValue;
			}
			set	
			{
				maxBpsDataValue = value;
			}
		}

		public long? Current95BpsDataValue
		{
			get
			{
				return current95BpsDataValue;
			}
			set	
			{
				current95BpsDataValue = value;
			}
		}

		public List<GetCDNStatis_CDNMetric> CDNStatisList
		{
			get
			{
				return cDNStatisList;
			}
			set	
			{
				cDNStatisList = value;
			}
		}

		public class GetCDNStatis_CDNMetric
		{

			private string cdnDomain;

			private string statTime;

			private long? flowDataDomesticValue;

			private long? flowDataOverseasValue;

			private long? flowDataValue;

			private long? bpsDataDomesticValue;

			private long? bpsDataOverseasValue;

			private long? bpsDataValue;

			public string CdnDomain
			{
				get
				{
					return cdnDomain;
				}
				set	
				{
					cdnDomain = value;
				}
			}

			public string StatTime
			{
				get
				{
					return statTime;
				}
				set	
				{
					statTime = value;
				}
			}

			public long? FlowDataDomesticValue
			{
				get
				{
					return flowDataDomesticValue;
				}
				set	
				{
					flowDataDomesticValue = value;
				}
			}

			public long? FlowDataOverseasValue
			{
				get
				{
					return flowDataOverseasValue;
				}
				set	
				{
					flowDataOverseasValue = value;
				}
			}

			public long? FlowDataValue
			{
				get
				{
					return flowDataValue;
				}
				set	
				{
					flowDataValue = value;
				}
			}

			public long? BpsDataDomesticValue
			{
				get
				{
					return bpsDataDomesticValue;
				}
				set	
				{
					bpsDataDomesticValue = value;
				}
			}

			public long? BpsDataOverseasValue
			{
				get
				{
					return bpsDataOverseasValue;
				}
				set	
				{
					bpsDataOverseasValue = value;
				}
			}

			public long? BpsDataValue
			{
				get
				{
					return bpsDataValue;
				}
				set	
				{
					bpsDataValue = value;
				}
			}
		}
	}
}
