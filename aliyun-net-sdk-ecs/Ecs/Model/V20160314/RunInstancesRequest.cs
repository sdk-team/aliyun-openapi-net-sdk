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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Ecs.Transform;
using Aliyun.Acs.Ecs.Transform.V20160314;

namespace Aliyun.Acs.Ecs.Model.V20160314
{
    public class RunInstancesRequest : RpcAcsRequest<RunInstancesResponse>
    {
        public RunInstancesRequest()
            : base("Ecs", "2016-03-14", "RunInstances", "ecs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string tag4Value;

		private string launchTemplateName;

		private long? resourceOwnerId;

		private string tag2Key;

		private string hpcClusterId;

		private string tag3Key;

		private string securityEnhancementStrategy;

		private string networkType;

		private string keyPairName;

		private int? minAmount;

		private float? spotPriceLimit;

		private string tag1Value;

		private string resourceGroupId;

		private string hostName;

		private string password;

		private string businessInfo;

		private string nodeControllerId;

		private bool? dryRun;

		private string tag5Key;

		private string fromApp;

		private string launchTemplateId;

		private int? maxAmount;

		private long? ownerId;

		private string capacityReservationPreference;

		private string vSwitchId;

		private string spotStrategy;

		private string recycleBinResourceId;

		private string instanceName;

		private string internetChargeType;

		private string zoneId;

		private string tag4Key;

		private int? internetMaxBandwidthIn;

		private string affinity;

		private string imageId;

		private string clientToken;

		private string spotInterruptionBehavior;

		private string ioOptimized;

		private int? internetMaxBandwidthOut;

		private string securityGroupId;

		private string description;

		private string systemDiskCategory;

		private string capacityReservationId;

		private string systemDiskPerformanceLevel;

		private string userData;

		private bool? passwordInherit;

		private string instanceType;

		private string tag3Value;

		private List<NetworkInterface> networkInterfaces = new List<NetworkInterface>(){ };

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string tenancy;

		private string systemDiskDiskName;

		private string autoReleaseTime;

		private string ramRoleName;

		private string relationOrderId;

		private string dedicatedHostId;

		private string clusterId;

		private string creditSpecification;

		private int? spotDuration;

		private List<DataDisk> dataDisks = new List<DataDisk>(){ };

		private string tag5Value;

		private long? launchTemplateVersion;

		private string tag1Key;

		private List<SecurityGroupRule> securityGroupRules = new List<SecurityGroupRule>(){ };

		private string systemDiskSize;

		private string tag2Value;

		private string defaultVpc;

		private string systemDiskDescription;

		public string Tag4Value
		{
			get
			{
				return tag4Value;
			}
			set	
			{
				tag4Value = value;
				DictionaryUtil.Add(QueryParameters, "Tag.4.Value", value);
			}
		}

		public string LaunchTemplateName
		{
			get
			{
				return launchTemplateName;
			}
			set	
			{
				launchTemplateName = value;
				DictionaryUtil.Add(QueryParameters, "LaunchTemplateName", value);
			}
		}

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string Tag2Key
		{
			get
			{
				return tag2Key;
			}
			set	
			{
				tag2Key = value;
				DictionaryUtil.Add(QueryParameters, "Tag.2.Key", value);
			}
		}

		public string HpcClusterId
		{
			get
			{
				return hpcClusterId;
			}
			set	
			{
				hpcClusterId = value;
				DictionaryUtil.Add(QueryParameters, "HpcClusterId", value);
			}
		}

		public string Tag3Key
		{
			get
			{
				return tag3Key;
			}
			set	
			{
				tag3Key = value;
				DictionaryUtil.Add(QueryParameters, "Tag.3.Key", value);
			}
		}

		public string SecurityEnhancementStrategy
		{
			get
			{
				return securityEnhancementStrategy;
			}
			set	
			{
				securityEnhancementStrategy = value;
				DictionaryUtil.Add(QueryParameters, "SecurityEnhancementStrategy", value);
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
				DictionaryUtil.Add(QueryParameters, "NetworkType", value);
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
				DictionaryUtil.Add(QueryParameters, "KeyPairName", value);
			}
		}

		public int? MinAmount
		{
			get
			{
				return minAmount;
			}
			set	
			{
				minAmount = value;
				DictionaryUtil.Add(QueryParameters, "MinAmount", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "SpotPriceLimit", value.ToString());
			}
		}

		public string Tag1Value
		{
			get
			{
				return tag1Value;
			}
			set	
			{
				tag1Value = value;
				DictionaryUtil.Add(QueryParameters, "Tag.1.Value", value);
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
				DictionaryUtil.Add(QueryParameters, "ResourceGroupId", value);
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
				DictionaryUtil.Add(QueryParameters, "HostName", value);
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
				DictionaryUtil.Add(QueryParameters, "Password", value);
			}
		}

		public string BusinessInfo
		{
			get
			{
				return businessInfo;
			}
			set	
			{
				businessInfo = value;
				DictionaryUtil.Add(QueryParameters, "BusinessInfo", value);
			}
		}

		public string NodeControllerId
		{
			get
			{
				return nodeControllerId;
			}
			set	
			{
				nodeControllerId = value;
				DictionaryUtil.Add(QueryParameters, "NodeControllerId", value);
			}
		}

		public bool? DryRun
		{
			get
			{
				return dryRun;
			}
			set	
			{
				dryRun = value;
				DictionaryUtil.Add(QueryParameters, "DryRun", value.ToString());
			}
		}

		public string Tag5Key
		{
			get
			{
				return tag5Key;
			}
			set	
			{
				tag5Key = value;
				DictionaryUtil.Add(QueryParameters, "Tag.5.Key", value);
			}
		}

		public string FromApp
		{
			get
			{
				return fromApp;
			}
			set	
			{
				fromApp = value;
				DictionaryUtil.Add(QueryParameters, "FromApp", value);
			}
		}

		public string LaunchTemplateId
		{
			get
			{
				return launchTemplateId;
			}
			set	
			{
				launchTemplateId = value;
				DictionaryUtil.Add(QueryParameters, "LaunchTemplateId", value);
			}
		}

		public int? MaxAmount
		{
			get
			{
				return maxAmount;
			}
			set	
			{
				maxAmount = value;
				DictionaryUtil.Add(QueryParameters, "MaxAmount", value.ToString());
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string CapacityReservationPreference
		{
			get
			{
				return capacityReservationPreference;
			}
			set	
			{
				capacityReservationPreference = value;
				DictionaryUtil.Add(QueryParameters, "CapacityReservationPreference", value);
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
				DictionaryUtil.Add(QueryParameters, "VSwitchId", value);
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
				DictionaryUtil.Add(QueryParameters, "SpotStrategy", value);
			}
		}

		public string RecycleBinResourceId
		{
			get
			{
				return recycleBinResourceId;
			}
			set	
			{
				recycleBinResourceId = value;
				DictionaryUtil.Add(QueryParameters, "RecycleBinResourceId", value);
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
				DictionaryUtil.Add(QueryParameters, "InstanceName", value);
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
				DictionaryUtil.Add(QueryParameters, "InternetChargeType", value);
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
				DictionaryUtil.Add(QueryParameters, "ZoneId", value);
			}
		}

		public string Tag4Key
		{
			get
			{
				return tag4Key;
			}
			set	
			{
				tag4Key = value;
				DictionaryUtil.Add(QueryParameters, "Tag.4.Key", value);
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
				DictionaryUtil.Add(QueryParameters, "InternetMaxBandwidthIn", value.ToString());
			}
		}

		public string Affinity
		{
			get
			{
				return affinity;
			}
			set	
			{
				affinity = value;
				DictionaryUtil.Add(QueryParameters, "Affinity", value);
			}
		}

		public string ImageId
		{
			get
			{
				return imageId;
			}
			set	
			{
				imageId = value;
				DictionaryUtil.Add(QueryParameters, "ImageId", value);
			}
		}

		public string ClientToken
		{
			get
			{
				return clientToken;
			}
			set	
			{
				clientToken = value;
				DictionaryUtil.Add(QueryParameters, "ClientToken", value);
			}
		}

		public string SpotInterruptionBehavior
		{
			get
			{
				return spotInterruptionBehavior;
			}
			set	
			{
				spotInterruptionBehavior = value;
				DictionaryUtil.Add(QueryParameters, "SpotInterruptionBehavior", value);
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
				DictionaryUtil.Add(QueryParameters, "IoOptimized", value);
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
				DictionaryUtil.Add(QueryParameters, "InternetMaxBandwidthOut", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "SecurityGroupId", value);
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
				DictionaryUtil.Add(QueryParameters, "Description", value);
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
				DictionaryUtil.Add(QueryParameters, "SystemDisk.Category", value);
			}
		}

		public string CapacityReservationId
		{
			get
			{
				return capacityReservationId;
			}
			set	
			{
				capacityReservationId = value;
				DictionaryUtil.Add(QueryParameters, "CapacityReservationId", value);
			}
		}

		public string SystemDiskPerformanceLevel
		{
			get
			{
				return systemDiskPerformanceLevel;
			}
			set	
			{
				systemDiskPerformanceLevel = value;
				DictionaryUtil.Add(QueryParameters, "SystemDisk.PerformanceLevel", value);
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
				DictionaryUtil.Add(QueryParameters, "UserData", value);
			}
		}

		public bool? PasswordInherit
		{
			get
			{
				return passwordInherit;
			}
			set	
			{
				passwordInherit = value;
				DictionaryUtil.Add(QueryParameters, "PasswordInherit", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "InstanceType", value);
			}
		}

		public string Tag3Value
		{
			get
			{
				return tag3Value;
			}
			set	
			{
				tag3Value = value;
				DictionaryUtil.Add(QueryParameters, "Tag.3.Value", value);
			}
		}

		public List<NetworkInterface> NetworkInterfaces
		{
			get
			{
				return networkInterfaces;
			}

			set
			{
				networkInterfaces = value;
				for (int i = 0; i < networkInterfaces.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"NetworkInterface." + (i + 1) + ".VSwitchId", networkInterfaces[i].VSwitchId);
					DictionaryUtil.Add(QueryParameters,"NetworkInterface." + (i + 1) + ".SecurityGroupId", networkInterfaces[i].SecurityGroupId);
					DictionaryUtil.Add(QueryParameters,"NetworkInterface." + (i + 1) + ".PrimaryIpAddress", networkInterfaces[i].PrimaryIpAddress);
					DictionaryUtil.Add(QueryParameters,"NetworkInterface." + (i + 1) + ".Description", networkInterfaces[i].Description);
					DictionaryUtil.Add(QueryParameters,"NetworkInterface." + (i + 1) + ".NetworkInterfaceName", networkInterfaces[i].NetworkInterfaceName);
				}
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public string OwnerAccount
		{
			get
			{
				return ownerAccount;
			}
			set	
			{
				ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
			}
		}

		public string Tenancy
		{
			get
			{
				return tenancy;
			}
			set	
			{
				tenancy = value;
				DictionaryUtil.Add(QueryParameters, "Tenancy", value);
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
				DictionaryUtil.Add(QueryParameters, "SystemDisk.DiskName", value);
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
				DictionaryUtil.Add(QueryParameters, "AutoReleaseTime", value);
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
				DictionaryUtil.Add(QueryParameters, "RamRoleName", value);
			}
		}

		public string RelationOrderId
		{
			get
			{
				return relationOrderId;
			}
			set	
			{
				relationOrderId = value;
				DictionaryUtil.Add(QueryParameters, "RelationOrderId", value);
			}
		}

		public string DedicatedHostId
		{
			get
			{
				return dedicatedHostId;
			}
			set	
			{
				dedicatedHostId = value;
				DictionaryUtil.Add(QueryParameters, "DedicatedHostId", value);
			}
		}

		public string ClusterId
		{
			get
			{
				return clusterId;
			}
			set	
			{
				clusterId = value;
				DictionaryUtil.Add(QueryParameters, "ClusterId", value);
			}
		}

		public string CreditSpecification
		{
			get
			{
				return creditSpecification;
			}
			set	
			{
				creditSpecification = value;
				DictionaryUtil.Add(QueryParameters, "CreditSpecification", value);
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
				DictionaryUtil.Add(QueryParameters, "SpotDuration", value.ToString());
			}
		}

		public List<DataDisk> DataDisks
		{
			get
			{
				return dataDisks;
			}

			set
			{
				dataDisks = value;
				for (int i = 0; i < dataDisks.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"DataDisk." + (i + 1) + ".DiskName", dataDisks[i].DiskName);
					DictionaryUtil.Add(QueryParameters,"DataDisk." + (i + 1) + ".SnapshotId", dataDisks[i].SnapshotId);
					DictionaryUtil.Add(QueryParameters,"DataDisk." + (i + 1) + ".Size", dataDisks[i].Size);
					DictionaryUtil.Add(QueryParameters,"DataDisk." + (i + 1) + ".Encrypted", dataDisks[i].Encrypted);
					DictionaryUtil.Add(QueryParameters,"DataDisk." + (i + 1) + ".PerformanceLevel", dataDisks[i].PerformanceLevel);
					DictionaryUtil.Add(QueryParameters,"DataDisk." + (i + 1) + ".Description", dataDisks[i].Description);
					DictionaryUtil.Add(QueryParameters,"DataDisk." + (i + 1) + ".Category", dataDisks[i].Category);
					DictionaryUtil.Add(QueryParameters,"DataDisk." + (i + 1) + ".Device", dataDisks[i].Device);
					DictionaryUtil.Add(QueryParameters,"DataDisk." + (i + 1) + ".DeleteWithInstance", dataDisks[i].DeleteWithInstance);
				}
			}
		}

		public string Tag5Value
		{
			get
			{
				return tag5Value;
			}
			set	
			{
				tag5Value = value;
				DictionaryUtil.Add(QueryParameters, "Tag.5.Value", value);
			}
		}

		public long? LaunchTemplateVersion
		{
			get
			{
				return launchTemplateVersion;
			}
			set	
			{
				launchTemplateVersion = value;
				DictionaryUtil.Add(QueryParameters, "LaunchTemplateVersion", value.ToString());
			}
		}

		public string Tag1Key
		{
			get
			{
				return tag1Key;
			}
			set	
			{
				tag1Key = value;
				DictionaryUtil.Add(QueryParameters, "Tag.1.Key", value);
			}
		}

		public List<SecurityGroupRule> SecurityGroupRules
		{
			get
			{
				return securityGroupRules;
			}

			set
			{
				securityGroupRules = value;
				for (int i = 0; i < securityGroupRules.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"SecurityGroupRule." + (i + 1) + ".NicType", securityGroupRules[i].NicType);
					DictionaryUtil.Add(QueryParameters,"SecurityGroupRule." + (i + 1) + ".PortRange", securityGroupRules[i].PortRange);
					DictionaryUtil.Add(QueryParameters,"SecurityGroupRule." + (i + 1) + ".IpProtocol", securityGroupRules[i].IpProtocol);
					DictionaryUtil.Add(QueryParameters,"SecurityGroupRule." + (i + 1) + ".Priority", securityGroupRules[i].Priority);
					DictionaryUtil.Add(QueryParameters,"SecurityGroupRule." + (i + 1) + ".Policy", securityGroupRules[i].Policy);
				}
			}
		}

		public string SystemDiskSize
		{
			get
			{
				return systemDiskSize;
			}
			set	
			{
				systemDiskSize = value;
				DictionaryUtil.Add(QueryParameters, "SystemDisk.Size", value);
			}
		}

		public string Tag2Value
		{
			get
			{
				return tag2Value;
			}
			set	
			{
				tag2Value = value;
				DictionaryUtil.Add(QueryParameters, "Tag.2.Value", value);
			}
		}

		public string DefaultVpc
		{
			get
			{
				return defaultVpc;
			}
			set	
			{
				defaultVpc = value;
				DictionaryUtil.Add(QueryParameters, "DefaultVpc", value);
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
				DictionaryUtil.Add(QueryParameters, "SystemDisk.Description", value);
			}
		}

		public class NetworkInterface
		{

			private string vSwitchId;

			private string securityGroupId;

			private string primaryIpAddress;

			private string description;

			private string networkInterfaceName;

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
		}

		public class DataDisk
		{

			private string diskName;

			private string snapshotId;

			private int? size;

			private string encrypted;

			private string performanceLevel;

			private string description;

			private string category;

			private string device;

			private bool? deleteWithInstance;

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

			public string PerformanceLevel
			{
				get
				{
					return performanceLevel;
				}
				set	
				{
					performanceLevel = value;
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

			public string Device
			{
				get
				{
					return device;
				}
				set	
				{
					device = value;
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

		public class SecurityGroupRule
		{

			private string nicType;

			private string portRange;

			private string ipProtocol;

			private string priority;

			private string policy;

			public string NicType
			{
				get
				{
					return nicType;
				}
				set	
				{
					nicType = value;
				}
			}

			public string PortRange
			{
				get
				{
					return portRange;
				}
				set	
				{
					portRange = value;
				}
			}

			public string IpProtocol
			{
				get
				{
					return ipProtocol;
				}
				set	
				{
					ipProtocol = value;
				}
			}

			public string Priority
			{
				get
				{
					return priority;
				}
				set	
				{
					priority = value;
				}
			}

			public string Policy
			{
				get
				{
					return policy;
				}
				set	
				{
					policy = value;
				}
			}
		}

        public override RunInstancesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return RunInstancesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
