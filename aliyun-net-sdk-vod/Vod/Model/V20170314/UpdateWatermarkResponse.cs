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
	public class UpdateWatermarkResponse : AcsResponse
	{

		private string requestId;

		private UpdateWatermark_Watermark watermark;

		private UpdateWatermark_WatermarkInfo watermarkInfo;

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

		public UpdateWatermark_Watermark Watermark
		{
			get
			{
				return watermark;
			}
			set	
			{
				watermark = value;
			}
		}

		public UpdateWatermark_WatermarkInfo WatermarkInfo
		{
			get
			{
				return watermarkInfo;
			}
			set	
			{
				watermarkInfo = value;
			}
		}

		public class UpdateWatermark_Watermark
		{

			private int? createTime;

			private string horizontalOffset;

			private string isDefault;

			private string position;

			private string watermarkId;

			private string verticalOffset;

			private string width;

			private string height;

			private string url;

			private int? videoHeight;

			private int? videoWidth;

			private string screenMode;

			private string name;

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

			public string HorizontalOffset
			{
				get
				{
					return horizontalOffset;
				}
				set	
				{
					horizontalOffset = value;
				}
			}

			public string IsDefault
			{
				get
				{
					return isDefault;
				}
				set	
				{
					isDefault = value;
				}
			}

			public string Position
			{
				get
				{
					return position;
				}
				set	
				{
					position = value;
				}
			}

			public string WatermarkId
			{
				get
				{
					return watermarkId;
				}
				set	
				{
					watermarkId = value;
				}
			}

			public string VerticalOffset
			{
				get
				{
					return verticalOffset;
				}
				set	
				{
					verticalOffset = value;
				}
			}

			public string Width
			{
				get
				{
					return width;
				}
				set	
				{
					width = value;
				}
			}

			public string Height
			{
				get
				{
					return height;
				}
				set	
				{
					height = value;
				}
			}

			public string Url
			{
				get
				{
					return url;
				}
				set	
				{
					url = value;
				}
			}

			public int? VideoHeight
			{
				get
				{
					return videoHeight;
				}
				set	
				{
					videoHeight = value;
				}
			}

			public int? VideoWidth
			{
				get
				{
					return videoWidth;
				}
				set	
				{
					videoWidth = value;
				}
			}

			public string ScreenMode
			{
				get
				{
					return screenMode;
				}
				set	
				{
					screenMode = value;
				}
			}

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}
		}

		public class UpdateWatermark_WatermarkInfo
		{

			private string creationTime;

			private string type;

			private string isDefault;

			private string watermarkId;

			private int? screenWidth;

			private int? screenHeight;

			private string name;

			private string fileUrl;

			private string watermarkConfig;

			public string CreationTime
			{
				get
				{
					return creationTime;
				}
				set	
				{
					creationTime = value;
				}
			}

			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}

			public string IsDefault
			{
				get
				{
					return isDefault;
				}
				set	
				{
					isDefault = value;
				}
			}

			public string WatermarkId
			{
				get
				{
					return watermarkId;
				}
				set	
				{
					watermarkId = value;
				}
			}

			public int? ScreenWidth
			{
				get
				{
					return screenWidth;
				}
				set	
				{
					screenWidth = value;
				}
			}

			public int? ScreenHeight
			{
				get
				{
					return screenHeight;
				}
				set	
				{
					screenHeight = value;
				}
			}

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public string FileUrl
			{
				get
				{
					return fileUrl;
				}
				set	
				{
					fileUrl = value;
				}
			}

			public string WatermarkConfig
			{
				get
				{
					return watermarkConfig;
				}
				set	
				{
					watermarkConfig = value;
				}
			}
		}
	}
}
