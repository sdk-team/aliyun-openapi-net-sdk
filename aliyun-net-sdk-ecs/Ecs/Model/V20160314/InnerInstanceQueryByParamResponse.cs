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

namespace Aliyun.Acs.Ecs.Model.V20160314
{
	public class InnerInstanceQueryByParamResponse : AcsResponse
	{

		private string requestId;

		private int? count;

		private int? pageNo;

		private int? pageSize;

		private List<InnerInstanceQueryByParam_Item> data;

		private InnerInstanceQueryByParam_ErrorCode errorCode;

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

		public int? Count
		{
			get
			{
				return count;
			}
			set	
			{
				count = value;
			}
		}

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

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public List<InnerInstanceQueryByParam_Item> Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public InnerInstanceQueryByParam_ErrorCode ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
			}
		}

		public class InnerInstanceQueryByParam_Item
		{

			private string imageType;

			private string recoverPolicy;

			private string businessStatus;

			private string intranetIp;

			private int? diskSize;

			private string osName;

			private long? izId;

			private bool? ioOptimized;

			private string status;

			private string imageName;

			private int? internetRx;

			private int? internetTx;

			private long? zoneId;

			private int? memory;

			private string hostname;

			private int? agentId;

			private string instanceId;

			private string osType;

			private string ecsBusinessStatus;

			private string groupNo;

			private long? id;

			private long? imageId;

			private string gmtCreated;

			private string internetIp;

			private string bid;

			private string imageNo;

			private string gmtModified;

			private bool? isWin;

			private bool? recoverable;

			private string imagePc;

			private int? intranetRx;

			private long? aliUid;

			private string gmtStarted;

			private int? intranetTx;

			private int? cores;

			private string gmtSync;

			private string systemDiskCategory;

			private string gmtRelease;

			private InnerInstanceQueryByParam_Zone zone;

			private InnerInstanceQueryByParam_Iz iz;

			private InnerInstanceQueryByParam_Region region;

			public string ImageType
			{
				get
				{
					return imageType;
				}
				set	
				{
					imageType = value;
				}
			}

			public string RecoverPolicy
			{
				get
				{
					return recoverPolicy;
				}
				set	
				{
					recoverPolicy = value;
				}
			}

			public string BusinessStatus
			{
				get
				{
					return businessStatus;
				}
				set	
				{
					businessStatus = value;
				}
			}

			public string IntranetIp
			{
				get
				{
					return intranetIp;
				}
				set	
				{
					intranetIp = value;
				}
			}

			public int? DiskSize
			{
				get
				{
					return diskSize;
				}
				set	
				{
					diskSize = value;
				}
			}

			public string OsName
			{
				get
				{
					return osName;
				}
				set	
				{
					osName = value;
				}
			}

			public long? IzId
			{
				get
				{
					return izId;
				}
				set	
				{
					izId = value;
				}
			}

			public bool? IoOptimized
			{
				get
				{
					return ioOptimized;
				}
				set	
				{
					ioOptimized = value;
				}
			}

			public string Status
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

			public string ImageName
			{
				get
				{
					return imageName;
				}
				set	
				{
					imageName = value;
				}
			}

			public int? InternetRx
			{
				get
				{
					return internetRx;
				}
				set	
				{
					internetRx = value;
				}
			}

			public int? InternetTx
			{
				get
				{
					return internetTx;
				}
				set	
				{
					internetTx = value;
				}
			}

			public long? ZoneId
			{
				get
				{
					return zoneId;
				}
				set	
				{
					zoneId = value;
				}
			}

			public int? Memory
			{
				get
				{
					return memory;
				}
				set	
				{
					memory = value;
				}
			}

			public string Hostname
			{
				get
				{
					return hostname;
				}
				set	
				{
					hostname = value;
				}
			}

			public int? AgentId
			{
				get
				{
					return agentId;
				}
				set	
				{
					agentId = value;
				}
			}

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

			public string OsType
			{
				get
				{
					return osType;
				}
				set	
				{
					osType = value;
				}
			}

			public string EcsBusinessStatus
			{
				get
				{
					return ecsBusinessStatus;
				}
				set	
				{
					ecsBusinessStatus = value;
				}
			}

			public string GroupNo
			{
				get
				{
					return groupNo;
				}
				set	
				{
					groupNo = value;
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

			public long? ImageId
			{
				get
				{
					return imageId;
				}
				set	
				{
					imageId = value;
				}
			}

			public string GmtCreated
			{
				get
				{
					return gmtCreated;
				}
				set	
				{
					gmtCreated = value;
				}
			}

			public string InternetIp
			{
				get
				{
					return internetIp;
				}
				set	
				{
					internetIp = value;
				}
			}

			public string Bid
			{
				get
				{
					return bid;
				}
				set	
				{
					bid = value;
				}
			}

			public string ImageNo
			{
				get
				{
					return imageNo;
				}
				set	
				{
					imageNo = value;
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

			public bool? IsWin
			{
				get
				{
					return isWin;
				}
				set	
				{
					isWin = value;
				}
			}

			public bool? Recoverable
			{
				get
				{
					return recoverable;
				}
				set	
				{
					recoverable = value;
				}
			}

			public string ImagePc
			{
				get
				{
					return imagePc;
				}
				set	
				{
					imagePc = value;
				}
			}

			public int? IntranetRx
			{
				get
				{
					return intranetRx;
				}
				set	
				{
					intranetRx = value;
				}
			}

			public long? AliUid
			{
				get
				{
					return aliUid;
				}
				set	
				{
					aliUid = value;
				}
			}

			public string GmtStarted
			{
				get
				{
					return gmtStarted;
				}
				set	
				{
					gmtStarted = value;
				}
			}

			public int? IntranetTx
			{
				get
				{
					return intranetTx;
				}
				set	
				{
					intranetTx = value;
				}
			}

			public int? Cores
			{
				get
				{
					return cores;
				}
				set	
				{
					cores = value;
				}
			}

			public string GmtSync
			{
				get
				{
					return gmtSync;
				}
				set	
				{
					gmtSync = value;
				}
			}

			public string SystemDiskCategory
			{
				get
				{
					return systemDiskCategory;
				}
				set	
				{
					systemDiskCategory = value;
				}
			}

			public string GmtRelease
			{
				get
				{
					return gmtRelease;
				}
				set	
				{
					gmtRelease = value;
				}
			}

			public InnerInstanceQueryByParam_Zone Zone
			{
				get
				{
					return zone;
				}
				set	
				{
					zone = value;
				}
			}

			public InnerInstanceQueryByParam_Iz Iz
			{
				get
				{
					return iz;
				}
				set	
				{
					iz = value;
				}
			}

			public InnerInstanceQueryByParam_Region Region
			{
				get
				{
					return region;
				}
				set	
				{
					region = value;
				}
			}

			public class InnerInstanceQueryByParam_Zone
			{

				private string zoneNo;

				private long? id;

				private string isActive;

				private string zoneNoAlias;

				private long? regionId;

				private string routeIpSegment;

				private string zoneMemo;

				private string zoneName;

				private bool? isWritable;

				private string availableZoneID;

				private List<string> supportedDeviceCategories;

				private List<string> networkType;

				private List<string> diskType;

				public string ZoneNo
				{
					get
					{
						return zoneNo;
					}
					set	
					{
						zoneNo = value;
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

				public string IsActive
				{
					get
					{
						return isActive;
					}
					set	
					{
						isActive = value;
					}
				}

				public string ZoneNoAlias
				{
					get
					{
						return zoneNoAlias;
					}
					set	
					{
						zoneNoAlias = value;
					}
				}

				public long? RegionId
				{
					get
					{
						return regionId;
					}
					set	
					{
						regionId = value;
					}
				}

				public string RouteIpSegment
				{
					get
					{
						return routeIpSegment;
					}
					set	
					{
						routeIpSegment = value;
					}
				}

				public string ZoneMemo
				{
					get
					{
						return zoneMemo;
					}
					set	
					{
						zoneMemo = value;
					}
				}

				public string ZoneName
				{
					get
					{
						return zoneName;
					}
					set	
					{
						zoneName = value;
					}
				}

				public bool? IsWritable
				{
					get
					{
						return isWritable;
					}
					set	
					{
						isWritable = value;
					}
				}

				public string AvailableZoneID
				{
					get
					{
						return availableZoneID;
					}
					set	
					{
						availableZoneID = value;
					}
				}

				public List<string> SupportedDeviceCategories
				{
					get
					{
						return supportedDeviceCategories;
					}
					set	
					{
						supportedDeviceCategories = value;
					}
				}

				public List<string> NetworkType
				{
					get
					{
						return networkType;
					}
					set	
					{
						networkType = value;
					}
				}

				public List<string> DiskType
				{
					get
					{
						return diskType;
					}
					set	
					{
						diskType = value;
					}
				}
			}

			public class InnerInstanceQueryByParam_Iz
			{

				private string regionNo;

				private string status;

				private string no;

				private string enName;

				private string cnName;

				private List<InnerInstanceQueryByParam_IzResourceModelItem> izResourceModel;

				private List<string> supportedInstanceGenerations;

				private List<string> supportedInstanceTypeFamilies;

				private List<string> supportedInstanceTypeNames;

				public string RegionNo
				{
					get
					{
						return regionNo;
					}
					set	
					{
						regionNo = value;
					}
				}

				public string Status
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

				public string No
				{
					get
					{
						return no;
					}
					set	
					{
						no = value;
					}
				}

				public string EnName
				{
					get
					{
						return enName;
					}
					set	
					{
						enName = value;
					}
				}

				public string CnName
				{
					get
					{
						return cnName;
					}
					set	
					{
						cnName = value;
					}
				}

				public List<InnerInstanceQueryByParam_IzResourceModelItem> IzResourceModel
				{
					get
					{
						return izResourceModel;
					}
					set	
					{
						izResourceModel = value;
					}
				}

				public List<string> SupportedInstanceGenerations
				{
					get
					{
						return supportedInstanceGenerations;
					}
					set	
					{
						supportedInstanceGenerations = value;
					}
				}

				public List<string> SupportedInstanceTypeFamilies
				{
					get
					{
						return supportedInstanceTypeFamilies;
					}
					set	
					{
						supportedInstanceTypeFamilies = value;
					}
				}

				public List<string> SupportedInstanceTypeNames
				{
					get
					{
						return supportedInstanceTypeNames;
					}
					set	
					{
						supportedInstanceTypeNames = value;
					}
				}

				public class InnerInstanceQueryByParam_IzResourceModelItem
				{

					private bool? supportIoOptimized;

					private List<string> allowedResourceCreation;

					private List<string> supportedDataDiskCategories;

					private List<string> supportedInstanceGenerations1;

					private List<string> supportedNetworkCategories;

					private List<string> supportedSystemDiskCategories;

					private List<string> supportedInstanceTypeFamilies2;

					private List<string> supportedInstanceTypes;

					public bool? SupportIoOptimized
					{
						get
						{
							return supportIoOptimized;
						}
						set	
						{
							supportIoOptimized = value;
						}
					}

					public List<string> AllowedResourceCreation
					{
						get
						{
							return allowedResourceCreation;
						}
						set	
						{
							allowedResourceCreation = value;
						}
					}

					public List<string> SupportedDataDiskCategories
					{
						get
						{
							return supportedDataDiskCategories;
						}
						set	
						{
							supportedDataDiskCategories = value;
						}
					}

					public List<string> SupportedInstanceGenerations1
					{
						get
						{
							return supportedInstanceGenerations1;
						}
						set	
						{
							supportedInstanceGenerations1 = value;
						}
					}

					public List<string> SupportedNetworkCategories
					{
						get
						{
							return supportedNetworkCategories;
						}
						set	
						{
							supportedNetworkCategories = value;
						}
					}

					public List<string> SupportedSystemDiskCategories
					{
						get
						{
							return supportedSystemDiskCategories;
						}
						set	
						{
							supportedSystemDiskCategories = value;
						}
					}

					public List<string> SupportedInstanceTypeFamilies2
					{
						get
						{
							return supportedInstanceTypeFamilies2;
						}
						set	
						{
							supportedInstanceTypeFamilies2 = value;
						}
					}

					public List<string> SupportedInstanceTypes
					{
						get
						{
							return supportedInstanceTypes;
						}
						set	
						{
							supportedInstanceTypes = value;
						}
					}
				}
			}

			public class InnerInstanceQueryByParam_Region
			{

				private string regionNoAlias;

				private string regionNo;

				private string regionName;

				private string regionMemo;

				private long? id;

				private string isActive;

				public string RegionNoAlias
				{
					get
					{
						return regionNoAlias;
					}
					set	
					{
						regionNoAlias = value;
					}
				}

				public string RegionNo
				{
					get
					{
						return regionNo;
					}
					set	
					{
						regionNo = value;
					}
				}

				public string RegionName
				{
					get
					{
						return regionName;
					}
					set	
					{
						regionName = value;
					}
				}

				public string RegionMemo
				{
					get
					{
						return regionMemo;
					}
					set	
					{
						regionMemo = value;
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

				public string IsActive
				{
					get
					{
						return isActive;
					}
					set	
					{
						isActive = value;
					}
				}
			}
		}

		public class InnerInstanceQueryByParam_ErrorCode
		{

			private string code;

			private string message;

			private bool? isSuccess;

			public string Code
			{
				get
				{
					return code;
				}
				set	
				{
					code = value;
				}
			}

			public string Message
			{
				get
				{
					return message;
				}
				set	
				{
					message = value;
				}
			}

			public bool? IsSuccess
			{
				get
				{
					return isSuccess;
				}
				set	
				{
					isSuccess = value;
				}
			}
		}
	}
}
