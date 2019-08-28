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
	public class CreateUploadMediaFileResponse : AcsResponse
	{

		private string requestId;

		private CreateUploadMediaFile_MediaFileInfo mediaFileInfo;

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

		public CreateUploadMediaFile_MediaFileInfo MediaFileInfo
		{
			get
			{
				return mediaFileInfo;
			}
			set	
			{
				mediaFileInfo = value;
			}
		}

		public class CreateUploadMediaFile_MediaFileInfo
		{

			private string mediaFileId;

			private string mediaId;

			private string userData;

			private string mediaFilePath;

			private string mediaFileAuth;

			private string mediaFileURL;

			public string MediaFileId
			{
				get
				{
					return mediaFileId;
				}
				set	
				{
					mediaFileId = value;
				}
			}

			public string MediaId
			{
				get
				{
					return mediaId;
				}
				set	
				{
					mediaId = value;
				}
			}

			public string UserData
			{
				get
				{
					return userData;
				}
				set	
				{
					userData = value;
				}
			}

			public string MediaFilePath
			{
				get
				{
					return mediaFilePath;
				}
				set	
				{
					mediaFilePath = value;
				}
			}

			public string MediaFileAuth
			{
				get
				{
					return mediaFileAuth;
				}
				set	
				{
					mediaFileAuth = value;
				}
			}

			public string MediaFileURL
			{
				get
				{
					return mediaFileURL;
				}
				set	
				{
					mediaFileURL = value;
				}
			}
		}
	}
}
