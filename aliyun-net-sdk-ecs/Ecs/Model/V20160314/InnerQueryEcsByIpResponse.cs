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
	public class InnerQueryEcsByIpResponse : AcsResponse
	{

		private string requestId;

		private int? pageNumber;

		private int? pageSize;

		private List<InnerQueryEcsByIp_EcsInstance> ecsInstances;

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

		public List<InnerQueryEcsByIp_EcsInstance> EcsInstances
		{
			get
			{
				return ecsInstances;
			}
			set	
			{
				ecsInstances = value;
			}
		}

		public class InnerQueryEcsByIp_EcsInstance
		{

			private bool? recoverable;

			private string eipInstanceId;

			private bool? isWin;

			private string gmtRelease;

			private string serialNumber;

			private string instanceTypeGeneration;

			private int? intranetRx;

			private string imageProductCode;

			private string ecsBusinessStatus;

			private string description;

			private string internetIp;

			private string imageNo;

			private int? internetRx;

			private string status;

			private string imageName;

			private string osType;

			private string hostname;

			private int? eipBandwidth;

			private string netWorkType;

			private string natIp;

			private string instanceType;

			private string recoverPolicy;

			private bool? ioOptimized;

			private string osName;

			private string intranetIp;

			private string eip;

			private string gmtModified;

			private int? iopsSize;

			private string systemDiskCategory;

			private int? intranetTx;

			private string gmtStarted;

			private string gmtSync;

			private int? cores;

			private long? aliUid;

			private long? imageId;

			private string gmtCreated;

			private string groupNo;

			private string vpcInstanceId;

			private string bid;

			private int? agentId;

			private string realHostname;

			private string instanceId;

			private string instanceTypeFamily;

			private bool? networkValidation;

			private long? zoneId;

			private int? memory;

			private int? internetTx;

			private string vswitchInstanceId;

			private string imageType;

			private long? izId;

			private int? diskSize;

			private InnerQueryEcsByIp_Region region;

			private InnerQueryEcsByIp_Iz iz;

			private InnerQueryEcsByIp_Zone zone;

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

			public string EipInstanceId
			{
				get
				{
					return eipInstanceId;
				}
				set	
				{
					eipInstanceId = value;
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

			public string SerialNumber
			{
				get
				{
					return serialNumber;
				}
				set	
				{
					serialNumber = value;
				}
			}

			public string InstanceTypeGeneration
			{
				get
				{
					return instanceTypeGeneration;
				}
				set	
				{
					instanceTypeGeneration = value;
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

			public string ImageProductCode
			{
				get
				{
					return imageProductCode;
				}
				set	
				{
					imageProductCode = value;
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

			public int? EipBandwidth
			{
				get
				{
					return eipBandwidth;
				}
				set	
				{
					eipBandwidth = value;
				}
			}

			public string NetWorkType
			{
				get
				{
					return netWorkType;
				}
				set	
				{
					netWorkType = value;
				}
			}

			public string NatIp
			{
				get
				{
					return natIp;
				}
				set	
				{
					natIp = value;
				}
			}

			public string InstanceType
			{
				get
				{
					return instanceType;
				}
				set	
				{
					instanceType = value;
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

			public string Eip
			{
				get
				{
					return eip;
				}
				set	
				{
					eip = value;
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

			public int? IopsSize
			{
				get
				{
					return iopsSize;
				}
				set	
				{
					iopsSize = value;
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

			public string VpcInstanceId
			{
				get
				{
					return vpcInstanceId;
				}
				set	
				{
					vpcInstanceId = value;
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

			public string RealHostname
			{
				get
				{
					return realHostname;
				}
				set	
				{
					realHostname = value;
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

			public string InstanceTypeFamily
			{
				get
				{
					return instanceTypeFamily;
				}
				set	
				{
					instanceTypeFamily = value;
				}
			}

			public bool? NetworkValidation
			{
				get
				{
					return networkValidation;
				}
				set	
				{
					networkValidation = value;
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

			public string VswitchInstanceId
			{
				get
				{
					return vswitchInstanceId;
				}
				set	
				{
					vswitchInstanceId = value;
				}
			}

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

			public InnerQueryEcsByIp_Region Region
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

			public InnerQueryEcsByIp_Iz Iz
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

			public InnerQueryEcsByIp_Zone Zone
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

			public class InnerQueryEcsByIp_Region
			{

				private long? id;

				private string isActive;

				private string regionEnName;

				private string regionNoAlias;

				private string regionName;

				private string regionMemo;

				private string regionNo;

				private InnerQueryEcsByIp_Attributes attributes;

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

				public string RegionEnName
				{
					get
					{
						return regionEnName;
					}
					set	
					{
						regionEnName = value;
					}
				}

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

				public InnerQueryEcsByIp_Attributes Attributes
				{
					get
					{
						return attributes;
					}
					set	
					{
						attributes = value;
					}
				}

				public class InnerQueryEcsByIp_Attributes
				{

					private string supportImageCopy;

					private string internalUse;

					private string akName;

					public string SupportImageCopy
					{
						get
						{
							return supportImageCopy;
						}
						set	
						{
							supportImageCopy = value;
						}
					}

					public string InternalUse
					{
						get
						{
							return internalUse;
						}
						set	
						{
							internalUse = value;
						}
					}

					public string AkName
					{
						get
						{
							return akName;
						}
						set	
						{
							akName = value;
						}
					}
				}
			}

			public class InnerQueryEcsByIp_Iz
			{

				private string regionNo;

				private string status;

				private string no;

				private string enName;

				private string cnName;

				private List<InnerQueryEcsByIp_IzResourceMode> izResourceModel;

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

				public List<InnerQueryEcsByIp_IzResourceMode> IzResourceModel
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

				public class InnerQueryEcsByIp_IzResourceMode
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

			public class InnerQueryEcsByIp_Zone
			{

				private string zoneMemo;

				private bool? isWritable;

				private string zoneName;

				private string zoneNoAlias;

				private string isActive;

				private long? id;

				private string zoneEnName;

				private string zoneNo;

				private string routeIpSegment;

				private long? regionId;

				private List<string> supportedDeviceCategories;

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

				public string ZoneEnName
				{
					get
					{
						return zoneEnName;
					}
					set	
					{
						zoneEnName = value;
					}
				}

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
			}
		}
	}
}
