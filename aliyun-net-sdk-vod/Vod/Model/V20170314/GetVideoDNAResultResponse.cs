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
	public class GetVideoDNAResultResponse : AcsResponse
	{

		private string requestId;

		private GetVideoDNAResult_AIVideoDNAResult aIVideoDNAResult;

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

		public GetVideoDNAResult_AIVideoDNAResult AIVideoDNAResult
		{
			get
			{
				return aIVideoDNAResult;
			}
			set	
			{
				aIVideoDNAResult = value;
			}
		}

		public class GetVideoDNAResult_AIVideoDNAResult
		{

			private List<GetVideoDNAResult_FpShotsItem> fpShots;

			public List<GetVideoDNAResult_FpShotsItem> FpShots
			{
				get
				{
					return fpShots;
				}
				set	
				{
					fpShots = value;
				}
			}

			public class GetVideoDNAResult_FpShotsItem
			{

				private string primaryKey;

				private string similarity;

				private List<GetVideoDNAResult_FpShotSlicesItem> fpShotSlices;

				public string PrimaryKey
				{
					get
					{
						return primaryKey;
					}
					set	
					{
						primaryKey = value;
					}
				}

				public string Similarity
				{
					get
					{
						return similarity;
					}
					set	
					{
						similarity = value;
					}
				}

				public List<GetVideoDNAResult_FpShotSlicesItem> FpShotSlices
				{
					get
					{
						return fpShotSlices;
					}
					set	
					{
						fpShotSlices = value;
					}
				}

				public class GetVideoDNAResult_FpShotSlicesItem
				{

					private GetVideoDNAResult_Input input;

					private GetVideoDNAResult_Duplication duplication;

					public GetVideoDNAResult_Input Input
					{
						get
						{
							return input;
						}
						set	
						{
							input = value;
						}
					}

					public GetVideoDNAResult_Duplication Duplication
					{
						get
						{
							return duplication;
						}
						set	
						{
							duplication = value;
						}
					}

					public class GetVideoDNAResult_Input
					{

						private string start;

						private string duration;

						public string Start
						{
							get
							{
								return start;
							}
							set	
							{
								start = value;
							}
						}

						public string Duration
						{
							get
							{
								return duration;
							}
							set	
							{
								duration = value;
							}
						}
					}

					public class GetVideoDNAResult_Duplication
					{

						private string start;

						private string duration;

						public string Start
						{
							get
							{
								return start;
							}
							set	
							{
								start = value;
							}
						}

						public string Duration
						{
							get
							{
								return duration;
							}
							set	
							{
								duration = value;
							}
						}
					}
				}
			}
		}
	}
}
