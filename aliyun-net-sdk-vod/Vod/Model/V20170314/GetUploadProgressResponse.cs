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
	public class GetUploadProgressResponse : AcsResponse
	{

		private string requestId;

		private GetUploadProgress_UploadProgress uploadProgress;

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

		public GetUploadProgress_UploadProgress UploadProgress
		{
			get
			{
				return uploadProgress;
			}
			set	
			{
				uploadProgress = value;
			}
		}

		public class GetUploadProgress_UploadProgress
		{

			private List<GetUploadProgress_UploadProgressListItem> uploadProgressList;

			public List<GetUploadProgress_UploadProgressListItem> UploadProgressList
			{
				get
				{
					return uploadProgressList;
				}
				set	
				{
					uploadProgressList = value;
				}
			}

			public class GetUploadProgress_UploadProgressListItem
			{

				private string source;

				private string clientId;

				private string businessType;

				private string terminalType;

				private string deviceModel;

				private string appVersion;

				private string authTimestamp;

				private string authInfo;

				private string fileName;

				private long? fileSize;

				private string fileCreateTime;

				private string fileHash;

				private float? uploadSpeed;

				private float? uploadRatio;

				private string uploadId;

				private int? donePartsCount;

				private string totalPart;

				private long? partSize;

				private string uploadPoint;

				private string uploadAddress;

				private string videoId;

				public string Source
				{
					get
					{
						return source;
					}
					set	
					{
						source = value;
					}
				}

				public string ClientId
				{
					get
					{
						return clientId;
					}
					set	
					{
						clientId = value;
					}
				}

				public string BusinessType
				{
					get
					{
						return businessType;
					}
					set	
					{
						businessType = value;
					}
				}

				public string TerminalType
				{
					get
					{
						return terminalType;
					}
					set	
					{
						terminalType = value;
					}
				}

				public string DeviceModel
				{
					get
					{
						return deviceModel;
					}
					set	
					{
						deviceModel = value;
					}
				}

				public string AppVersion
				{
					get
					{
						return appVersion;
					}
					set	
					{
						appVersion = value;
					}
				}

				public string AuthTimestamp
				{
					get
					{
						return authTimestamp;
					}
					set	
					{
						authTimestamp = value;
					}
				}

				public string AuthInfo
				{
					get
					{
						return authInfo;
					}
					set	
					{
						authInfo = value;
					}
				}

				public string FileName
				{
					get
					{
						return fileName;
					}
					set	
					{
						fileName = value;
					}
				}

				public long? FileSize
				{
					get
					{
						return fileSize;
					}
					set	
					{
						fileSize = value;
					}
				}

				public string FileCreateTime
				{
					get
					{
						return fileCreateTime;
					}
					set	
					{
						fileCreateTime = value;
					}
				}

				public string FileHash
				{
					get
					{
						return fileHash;
					}
					set	
					{
						fileHash = value;
					}
				}

				public float? UploadSpeed
				{
					get
					{
						return uploadSpeed;
					}
					set	
					{
						uploadSpeed = value;
					}
				}

				public float? UploadRatio
				{
					get
					{
						return uploadRatio;
					}
					set	
					{
						uploadRatio = value;
					}
				}

				public string UploadId
				{
					get
					{
						return uploadId;
					}
					set	
					{
						uploadId = value;
					}
				}

				public int? DonePartsCount
				{
					get
					{
						return donePartsCount;
					}
					set	
					{
						donePartsCount = value;
					}
				}

				public string TotalPart
				{
					get
					{
						return totalPart;
					}
					set	
					{
						totalPart = value;
					}
				}

				public long? PartSize
				{
					get
					{
						return partSize;
					}
					set	
					{
						partSize = value;
					}
				}

				public string UploadPoint
				{
					get
					{
						return uploadPoint;
					}
					set	
					{
						uploadPoint = value;
					}
				}

				public string UploadAddress
				{
					get
					{
						return uploadAddress;
					}
					set	
					{
						uploadAddress = value;
					}
				}

				public string VideoId
				{
					get
					{
						return videoId;
					}
					set	
					{
						videoId = value;
					}
				}
			}
		}
	}
}
