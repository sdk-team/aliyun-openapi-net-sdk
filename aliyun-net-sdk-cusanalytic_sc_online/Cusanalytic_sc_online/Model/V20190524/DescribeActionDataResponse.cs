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

namespace Aliyun.Acs.cusanalytic_sc_online.Model.V20190524
{
	public class DescribeActionDataResponse : AcsResponse
	{

		private int? pageNo;

		private long? tsStart;

		private int? pageLimit;

		private int? pageCount;

		private string storeId;

		private long? tsEnd;

		private List<DescribeActionData_ActionsMsgItem> actionsMsgItems;

		public int? PageNo
		{
			get
			{
				return pageNo;
			}
			set	
			{
				pageNo = value;
			}
		}

		public long? TsStart
		{
			get
			{
				return tsStart;
			}
			set	
			{
				tsStart = value;
			}
		}

		public int? PageLimit
		{
			get
			{
				return pageLimit;
			}
			set	
			{
				pageLimit = value;
			}
		}

		public int? PageCount
		{
			get
			{
				return pageCount;
			}
			set	
			{
				pageCount = value;
			}
		}

		public string StoreId
		{
			get
			{
				return storeId;
			}
			set	
			{
				storeId = value;
			}
		}

		public long? TsEnd
		{
			get
			{
				return tsEnd;
			}
			set	
			{
				tsEnd = value;
			}
		}

		public List<DescribeActionData_ActionsMsgItem> ActionsMsgItems
		{
			get
			{
				return actionsMsgItems;
			}
			set	
			{
				actionsMsgItems = value;
			}
		}

		public class DescribeActionData_ActionsMsgItem
		{

			private long? locationId;

			private long? ukId;

			private string gmtModified;

			private long? status;

			private string gmtCreate;

			private long? storeId;

			private string tag;

			private long? id;

			private string locationLayerType;

			private DescribeActionData_ActionInfosItem actionInfosItem;

			private DescribeActionData_AttributesMsgItem attributesMsgItem;

			public long? LocationId
			{
				get
				{
					return locationId;
				}
				set	
				{
					locationId = value;
				}
			}

			public long? UkId
			{
				get
				{
					return ukId;
				}
				set	
				{
					ukId = value;
				}
			}

			public string GmtModified
			{
				get
				{
					return gmtModified;
				}
				set	
				{
					gmtModified = value;
				}
			}

			public long? Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

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

			public long? StoreId
			{
				get
				{
					return storeId;
				}
				set	
				{
					storeId = value;
				}
			}

			public string Tag
			{
				get
				{
					return tag;
				}
				set	
				{
					tag = value;
				}
			}

			public long? Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

			public string LocationLayerType
			{
				get
				{
					return locationLayerType;
				}
				set	
				{
					locationLayerType = value;
				}
			}

			public DescribeActionData_ActionInfosItem ActionInfosItem
			{
				get
				{
					return actionInfosItem;
				}
				set	
				{
					actionInfosItem = value;
				}
			}

			public DescribeActionData_AttributesMsgItem AttributesMsgItem
			{
				get
				{
					return attributesMsgItem;
				}
				set	
				{
					attributesMsgItem = value;
				}
			}

			public class DescribeActionData_ActionInfosItem
			{

				private long? maxts;

				private long? stayValid;

				private long? stayPeriod;

				private long? rawId;

				private long? mints;

				private DescribeActionData_Point point;

				private DescribeActionData_SenseRectEntityItem senseRectEntityItem;

				public long? Maxts
				{
					get
					{
						return maxts;
					}
					set	
					{
						maxts = value;
					}
				}

				public long? StayValid
				{
					get
					{
						return stayValid;
					}
					set	
					{
						stayValid = value;
					}
				}

				public long? StayPeriod
				{
					get
					{
						return stayPeriod;
					}
					set	
					{
						stayPeriod = value;
					}
				}

				public long? RawId
				{
					get
					{
						return rawId;
					}
					set	
					{
						rawId = value;
					}
				}

				public long? Mints
				{
					get
					{
						return mints;
					}
					set	
					{
						mints = value;
					}
				}

				public DescribeActionData_Point Point
				{
					get
					{
						return point;
					}
					set	
					{
						point = value;
					}
				}

				public DescribeActionData_SenseRectEntityItem SenseRectEntityItem
				{
					get
					{
						return senseRectEntityItem;
					}
					set	
					{
						senseRectEntityItem = value;
					}
				}

				public class DescribeActionData_Point
				{

					private float? x;

					private float? y;

					public float? X
					{
						get
						{
							return x;
						}
						set	
						{
							x = value;
						}
					}

					public float? Y
					{
						get
						{
							return y;
						}
						set	
						{
							y = value;
						}
					}
				}

				public class DescribeActionData_SenseRectEntityItem
				{

					private float? bottom;

					private float? left;

					private float? top;

					private float? right;

					public float? Bottom
					{
						get
						{
							return bottom;
						}
						set	
						{
							bottom = value;
						}
					}

					public float? Left
					{
						get
						{
							return left;
						}
						set	
						{
							left = value;
						}
					}

					public float? Top
					{
						get
						{
							return top;
						}
						set	
						{
							top = value;
						}
					}

					public float? Right
					{
						get
						{
							return right;
						}
						set	
						{
							right = value;
						}
					}
				}
			}

			public class DescribeActionData_AttributesMsgItem
			{

				private string imgUrl;

				private long? score;

				private string gender;

				private long? isClerk;

				private int? ageNum;

				private string imgType;

				public string ImgUrl
				{
					get
					{
						return imgUrl;
					}
					set	
					{
						imgUrl = value;
					}
				}

				public long? Score
				{
					get
					{
						return score;
					}
					set	
					{
						score = value;
					}
				}

				public string Gender
				{
					get
					{
						return gender;
					}
					set	
					{
						gender = value;
					}
				}

				public long? IsClerk
				{
					get
					{
						return isClerk;
					}
					set	
					{
						isClerk = value;
					}
				}

				public int? AgeNum
				{
					get
					{
						return ageNum;
					}
					set	
					{
						ageNum = value;
					}
				}

				public string ImgType
				{
					get
					{
						return imgType;
					}
					set	
					{
						imgType = value;
					}
				}
			}
		}
	}
}
