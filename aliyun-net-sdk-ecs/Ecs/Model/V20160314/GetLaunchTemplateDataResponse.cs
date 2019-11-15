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
	public class GetLaunchTemplateDataResponse : AcsResponse
	{

		private string requestId;

		private GetLaunchTemplateData_LaunchTemplateData launchTemplateData;

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

		public GetLaunchTemplateData_LaunchTemplateData LaunchTemplateData
		{
			get
			{
				return launchTemplateData;
			}
			set	
			{
				launchTemplateData = value;
			}
		}

		public class GetLaunchTemplateData_LaunchTemplateData
		{

			private string imageId;

			private string imageOwnerAlias;

			private string instanceType;

			private string securityGroupId;

			private string vpcId;

			private string vSwitchId;

			private string instanceName;

			private string description;

			private int? internetMaxBandwidthIn;

			private int? internetMaxBandwidthOut;

			private string hostName;

			private string zoneId;

			private int? systemDiskSize;

			private string systemDiskCategory;

			private string systemDiskDiskName;

			private string systemDiskDescription;

			private int? systemDiskIops;

			private string ioOptimized;

			private string instanceChargeType;

			private int? period;

			private string internetChargeType;

			private bool? enableVmOsConfig;

			private string networkType;

			private string userData;

			private string keyPairName;

			private string ramRoleName;

			private string autoReleaseTime;

			private string spotStrategy;

			private float? spotPriceLimit;

			private int? spotDuration;

			private string resourceGroupId;

			private bool? securityEnhancementStrategy;

			private List<GetLaunchTemplateData_DataDisk> dataDisks;

			private List<GetLaunchTemplateData_NetworkInterface> networkInterfaces;

			private List<GetLaunchTemplateData_InstanceTag> tags;

			public string ImageId
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

			public string ImageOwnerAlias
			{
				get
				{
					return imageOwnerAlias;
				}
				set	
				{
					imageOwnerAlias = value;
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

			public string SecurityGroupId
			{
				get
				{
					return securityGroupId;
				}
				set	
				{
					securityGroupId = value;
				}
			}

			public string VpcId
			{
				get
				{
					return vpcId;
				}
				set	
				{
					vpcId = value;
				}
			}

			public string VSwitchId
			{
				get
				{
					return vSwitchId;
				}
				set	
				{
					vSwitchId = value;
				}
			}

			public string InstanceName
			{
				get
				{
					return instanceName;
				}
				set	
				{
					instanceName = value;
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

			public int? InternetMaxBandwidthIn
			{
				get
				{
					return internetMaxBandwidthIn;
				}
				set	
				{
					internetMaxBandwidthIn = value;
				}
			}

			public int? InternetMaxBandwidthOut
			{
				get
				{
					return internetMaxBandwidthOut;
				}
				set	
				{
					internetMaxBandwidthOut = value;
				}
			}

			public string HostName
			{
				get
				{
					return hostName;
				}
				set	
				{
					hostName = value;
				}
			}

			public string ZoneId
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

			public int? SystemDiskSize
			{
				get
				{
					return systemDiskSize;
				}
				set	
				{
					systemDiskSize = value;
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

			public string SystemDiskDiskName
			{
				get
				{
					return systemDiskDiskName;
				}
				set	
				{
					systemDiskDiskName = value;
				}
			}

			public string SystemDiskDescription
			{
				get
				{
					return systemDiskDescription;
				}
				set	
				{
					systemDiskDescription = value;
				}
			}

			public int? SystemDiskIops
			{
				get
				{
					return systemDiskIops;
				}
				set	
				{
					systemDiskIops = value;
				}
			}

			public string IoOptimized
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

			public string InstanceChargeType
			{
				get
				{
					return instanceChargeType;
				}
				set	
				{
					instanceChargeType = value;
				}
			}

			public int? Period
			{
				get
				{
					return period;
				}
				set	
				{
					period = value;
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

			public bool? EnableVmOsConfig
			{
				get
				{
					return enableVmOsConfig;
				}
				set	
				{
					enableVmOsConfig = value;
				}
			}

			public string NetworkType
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

			public string KeyPairName
			{
				get
				{
					return keyPairName;
				}
				set	
				{
					keyPairName = value;
				}
			}

			public string RamRoleName
			{
				get
				{
					return ramRoleName;
				}
				set	
				{
					ramRoleName = value;
				}
			}

			public string AutoReleaseTime
			{
				get
				{
					return autoReleaseTime;
				}
				set	
				{
					autoReleaseTime = value;
				}
			}

			public string SpotStrategy
			{
				get
				{
					return spotStrategy;
				}
				set	
				{
					spotStrategy = value;
				}
			}

			public float? SpotPriceLimit
			{
				get
				{
					return spotPriceLimit;
				}
				set	
				{
					spotPriceLimit = value;
				}
			}

			public int? SpotDuration
			{
				get
				{
					return spotDuration;
				}
				set	
				{
					spotDuration = value;
				}
			}

			public string ResourceGroupId
			{
				get
				{
					return resourceGroupId;
				}
				set	
				{
					resourceGroupId = value;
				}
			}

			public bool? SecurityEnhancementStrategy
			{
				get
				{
					return securityEnhancementStrategy;
				}
				set	
				{
					securityEnhancementStrategy = value;
				}
			}

			public List<GetLaunchTemplateData_DataDisk> DataDisks
			{
				get
				{
					return dataDisks;
				}
				set	
				{
					dataDisks = value;
				}
			}

			public List<GetLaunchTemplateData_NetworkInterface> NetworkInterfaces
			{
				get
				{
					return networkInterfaces;
				}
				set	
				{
					networkInterfaces = value;
				}
			}

			public List<GetLaunchTemplateData_InstanceTag> Tags
			{
				get
				{
					return tags;
				}
				set	
				{
					tags = value;
				}
			}

			public class GetLaunchTemplateData_DataDisk
			{

				private int? size;

				private string snapshotId;

				private string category;

				private string encrypted;

				private string diskName;

				private string description;

				private bool? deleteWithInstance;

				public int? Size
				{
					get
					{
						return size;
					}
					set	
					{
						size = value;
					}
				}

				public string SnapshotId
				{
					get
					{
						return snapshotId;
					}
					set	
					{
						snapshotId = value;
					}
				}

				public string Category
				{
					get
					{
						return category;
					}
					set	
					{
						category = value;
					}
				}

				public string Encrypted
				{
					get
					{
						return encrypted;
					}
					set	
					{
						encrypted = value;
					}
				}

				public string DiskName
				{
					get
					{
						return diskName;
					}
					set	
					{
						diskName = value;
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

				public bool? DeleteWithInstance
				{
					get
					{
						return deleteWithInstance;
					}
					set	
					{
						deleteWithInstance = value;
					}
				}
			}

			public class GetLaunchTemplateData_NetworkInterface
			{

				private string primaryIpAddress;

				private string vSwitchId;

				private string securityGroupId;

				private string networkInterfaceName;

				private string description;

				public string PrimaryIpAddress
				{
					get
					{
						return primaryIpAddress;
					}
					set	
					{
						primaryIpAddress = value;
					}
				}

				public string VSwitchId
				{
					get
					{
						return vSwitchId;
					}
					set	
					{
						vSwitchId = value;
					}
				}

				public string SecurityGroupId
				{
					get
					{
						return securityGroupId;
					}
					set	
					{
						securityGroupId = value;
					}
				}

				public string NetworkInterfaceName
				{
					get
					{
						return networkInterfaceName;
					}
					set	
					{
						networkInterfaceName = value;
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
			}

			public class GetLaunchTemplateData_InstanceTag
			{

				private string key;

				private string _value;

				public string Key
				{
					get
					{
						return key;
					}
					set	
					{
						key = value;
					}
				}

				public string _Value
				{
					get
					{
						return _value;
					}
					set	
					{
						_value = value;
					}
				}
			}
		}
	}
}
