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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeFilesForSQLServerResponse : AcsResponse
	{

		private string requestId;

		private string dBInstanceId;

		private int? totalRecordCount;

		private int? pageNumber;

		private int? pageRecordCount;

		private List<DescribeFilesForSQLServer_SQLServerUploadFile> items;

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

		public string DBInstanceId
		{
			get
			{
				return dBInstanceId;
			}
			set	
			{
				dBInstanceId = value;
			}
		}

		public int? TotalRecordCount
		{
			get
			{
				return totalRecordCount;
			}
			set	
			{
				totalRecordCount = value;
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public int? PageRecordCount
		{
			get
			{
				return pageRecordCount;
			}
			set	
			{
				pageRecordCount = value;
			}
		}

		public List<DescribeFilesForSQLServer_SQLServerUploadFile> Items
		{
			get
			{
				return items;
			}
			set	
			{
				items = value;
			}
		}

		public class DescribeFilesForSQLServer_SQLServerUploadFile
		{

			private string dBName;

			private string fileName;

			private long? fileSize;

			private string internetFtpServer;

			private int? internetPort;

			private string intranetFtpserver;

			private int? intranetport;

			private string userName;

			private string password;

			private string fileStatus;

			private string description;

			private string creationTime;

			public string DBName
			{
				get
				{
					return dBName;
				}
				set	
				{
					dBName = value;
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

			public string InternetFtpServer
			{
				get
				{
					return internetFtpServer;
				}
				set	
				{
					internetFtpServer = value;
				}
			}

			public int? InternetPort
			{
				get
				{
					return internetPort;
				}
				set	
				{
					internetPort = value;
				}
			}

			public string IntranetFtpserver
			{
				get
				{
					return intranetFtpserver;
				}
				set	
				{
					intranetFtpserver = value;
				}
			}

			public int? Intranetport
			{
				get
				{
					return intranetport;
				}
				set	
				{
					intranetport = value;
				}
			}

			public string UserName
			{
				get
				{
					return userName;
				}
				set	
				{
					userName = value;
				}
			}

			public string Password
			{
				get
				{
					return password;
				}
				set	
				{
					password = value;
				}
			}

			public string FileStatus
			{
				get
				{
					return fileStatus;
				}
				set	
				{
					fileStatus = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}

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
		}
	}
}
