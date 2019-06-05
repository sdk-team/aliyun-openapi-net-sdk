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

namespace Aliyun.Acs.Vpc.Model.V20160428
{
	public class Describe95TrafficResponse : AcsResponse
	{

		private string requestId;

		private Describe95Traffic_Traffic95Summary traffic95Summary;

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

		public Describe95Traffic_Traffic95Summary Traffic95Summary
		{
			get
			{
				return traffic95Summary;
			}
			set	
			{
				traffic95Summary = value;
			}
		}

		public class Describe95Traffic_Traffic95Summary
		{

			private string instanceId;

			private long? bandwidth;

			private string minimumConsumeBandwidth;

			private string fifthPeakBandwidth;

			private string internetChargeType;

			private string fifthPeakBandwidth1;

			private List<Describe95Traffic_Traffic95Detail> traffic95DetailList;

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			public long? Bandwidth
			{
				get
				{
					return bandwidth;
				}
				set	
				{
					bandwidth = value;
				}
			}

			public string MinimumConsumeBandwidth
			{
				get
				{
					return minimumConsumeBandwidth;
				}
				set	
				{
					minimumConsumeBandwidth = value;
				}
			}

			public string FifthPeakBandwidth
			{
				get
				{
					return fifthPeakBandwidth;
				}
				set	
				{
					fifthPeakBandwidth = value;
				}
			}

			public string InternetChargeType
			{
				get
				{
					return internetChargeType;
				}
				set	
				{
					internetChargeType = value;
				}
			}

			public string FifthPeakBandwidth1
			{
				get
				{
					return fifthPeakBandwidth1;
				}
				set	
				{
					fifthPeakBandwidth1 = value;
				}
			}

			public List<Describe95Traffic_Traffic95Detail> Traffic95DetailList
			{
				get
				{
					return traffic95DetailList;
				}
				set	
				{
					traffic95DetailList = value;
				}
			}

			public class Describe95Traffic_Traffic95Detail
			{

				private string time;

				private string inBandwidth;

				private string outBandwidth;

				private string billBandwidth;

				public string Time
				{
					get
					{
						return time;
					}
					set	
					{
						time = value;
					}
				}

				public string InBandwidth
				{
					get
					{
						return inBandwidth;
					}
					set	
					{
						inBandwidth = value;
					}
				}

				public string OutBandwidth
				{
					get
					{
						return outBandwidth;
					}
					set	
					{
						outBandwidth = value;
					}
				}

				public string BillBandwidth
				{
					get
					{
						return billBandwidth;
					}
					set	
					{
						billBandwidth = value;
					}
				}
			}
		}
	}
}
