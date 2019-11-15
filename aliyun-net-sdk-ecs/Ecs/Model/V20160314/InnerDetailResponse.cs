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
	public class InnerDetailResponse : AcsResponse
	{

		private string requestId;

		private InnerDetail_InstanceModel instanceModel;

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

		public InnerDetail_InstanceModel InstanceModel
		{
			get
			{
				return instanceModel;
			}
			set	
			{
				instanceModel = value;
			}
		}

		public class InnerDetail_InstanceModel
		{

			private string systemDeviceCategory;

			private string vncHost;

			private int? intensiveNet;

			private string safetyQuota;

			private int? vncPort;

			private string zoneNo;

			private string instanceName;

			private string regionNo;

			private string hostname;

			private bool? networkValidation;

			private int? internetTx;

			private int? internetRx;

			private string platform;

			private string vlanNo;

			private string status;

			private string creationTime;

			private int? mem;

			private int? intensiveIo;

			private string ncId;

			private int? bps;

			private string vncPassword;

			private string ecsName;

			private string innerIp;

			private string realZoneNo;

			private string serialNumber;

			private string izNo;

			private int? cores;

			private int? intranetTx;

			private int? intensiveCpu;

			private string imageProductCode;

			private int? intranetRx;

			private string securityControl;

			private string rackId;

			private int? disk;

			private List<InnerDetail_Group> groups;

			private InnerDetail_PublicIp publicIp;

			private InnerDetail_Img img;

			private InnerDetail_StatusNote statusNote;

			public string SystemDeviceCategory
			{
				get
				{
					return systemDeviceCategory;
				}
				set	
				{
					systemDeviceCategory = value;
				}
			}

			public string VncHost
			{
				get
				{
					return vncHost;
				}
				set	
				{
					vncHost = value;
				}
			}

			public int? IntensiveNet
			{
				get
				{
					return intensiveNet;
				}
				set	
				{
					intensiveNet = value;
				}
			}

			public string SafetyQuota
			{
				get
				{
					return safetyQuota;
				}
				set	
				{
					safetyQuota = value;
				}
			}

			public int? VncPort
			{
				get
				{
					return vncPort;
				}
				set	
				{
					vncPort = value;
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

			public string Platform
			{
				get
				{
					return platform;
				}
				set	
				{
					platform = value;
				}
			}

			public string VlanNo
			{
				get
				{
					return vlanNo;
				}
				set	
				{
					vlanNo = value;
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

			public int? Mem
			{
				get
				{
					return mem;
				}
				set	
				{
					mem = value;
				}
			}

			public int? IntensiveIo
			{
				get
				{
					return intensiveIo;
				}
				set	
				{
					intensiveIo = value;
				}
			}

			public string NcId
			{
				get
				{
					return ncId;
				}
				set	
				{
					ncId = value;
				}
			}

			public int? Bps
			{
				get
				{
					return bps;
				}
				set	
				{
					bps = value;
				}
			}

			public string VncPassword
			{
				get
				{
					return vncPassword;
				}
				set	
				{
					vncPassword = value;
				}
			}

			public string EcsName
			{
				get
				{
					return ecsName;
				}
				set	
				{
					ecsName = value;
				}
			}

			public string InnerIp
			{
				get
				{
					return innerIp;
				}
				set	
				{
					innerIp = value;
				}
			}

			public string RealZoneNo
			{
				get
				{
					return realZoneNo;
				}
				set	
				{
					realZoneNo = value;
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

			public string IzNo
			{
				get
				{
					return izNo;
				}
				set	
				{
					izNo = value;
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

			public int? IntensiveCpu
			{
				get
				{
					return intensiveCpu;
				}
				set	
				{
					intensiveCpu = value;
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

			public string SecurityControl
			{
				get
				{
					return securityControl;
				}
				set	
				{
					securityControl = value;
				}
			}

			public string RackId
			{
				get
				{
					return rackId;
				}
				set	
				{
					rackId = value;
				}
			}

			public int? Disk
			{
				get
				{
					return disk;
				}
				set	
				{
					disk = value;
				}
			}

			public List<InnerDetail_Group> Groups
			{
				get
				{
					return groups;
				}
				set	
				{
					groups = value;
				}
			}

			public InnerDetail_PublicIp PublicIp
			{
				get
				{
					return publicIp;
				}
				set	
				{
					publicIp = value;
				}
			}

			public InnerDetail_Img Img
			{
				get
				{
					return img;
				}
				set	
				{
					img = value;
				}
			}

			public InnerDetail_StatusNote StatusNote
			{
				get
				{
					return statusNote;
				}
				set	
				{
					statusNote = value;
				}
			}

			public class InnerDetail_Group
			{

				private string groupNo;

				private string groupName;

				private string groupDesc;

				private int? ecsCount;

				private string vpcInstanceId;

				private string gmtCreated;

				private string gmtModified;

				private List<InnerDetail_Tag> tags;

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

				public string GroupName
				{
					get
					{
						return groupName;
					}
					set	
					{
						groupName = value;
					}
				}

				public string GroupDesc
				{
					get
					{
						return groupDesc;
					}
					set	
					{
						groupDesc = value;
					}
				}

				public int? EcsCount
				{
					get
					{
						return ecsCount;
					}
					set	
					{
						ecsCount = value;
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

				public List<InnerDetail_Tag> Tags
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

				public class InnerDetail_Tag
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

			public class InnerDetail_PublicIp
			{

				private string bindIp;

				private string assignNatIp;

				private string assignIp;

				public string BindIp
				{
					get
					{
						return bindIp;
					}
					set	
					{
						bindIp = value;
					}
				}

				public string AssignNatIp
				{
					get
					{
						return assignNatIp;
					}
					set	
					{
						assignNatIp = value;
					}
				}

				public string AssignIp
				{
					get
					{
						return assignIp;
					}
					set	
					{
						assignIp = value;
					}
				}
			}

			public class InnerDetail_Img
			{

				private string name;

				private string imageId;

				private long? srcImageId;

				private string gmtCreated;

				private long? id;

				private string bid;

				private string visibility;

				private string remark;

				private bool? supportIoOptimizedInstance;

				private string importOSSObject;

				private string gmtModified;

				private string progress;

				private string version;

				private string imageProductCode;

				private long? aliUid;

				private string gmtRelease;

				private string imageCategory;

				private string displayName;

				private string owner;

				private string status;

				private string importOSSBucket;

				private string format;

				private string regionNo;

				private int? imageSize;

				private string snapshotNo;

				private List<InnerDetail_Tag2> tags1;

				private InnerDetail_OsTypeModel osTypeModel;

				private InnerDetail_QuoteType quoteType;

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

				public long? SrcImageId
				{
					get
					{
						return srcImageId;
					}
					set	
					{
						srcImageId = value;
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

				public string Visibility
				{
					get
					{
						return visibility;
					}
					set	
					{
						visibility = value;
					}
				}

				public string Remark
				{
					get
					{
						return remark;
					}
					set	
					{
						remark = value;
					}
				}

				public bool? SupportIoOptimizedInstance
				{
					get
					{
						return supportIoOptimizedInstance;
					}
					set	
					{
						supportIoOptimizedInstance = value;
					}
				}

				public string ImportOSSObject
				{
					get
					{
						return importOSSObject;
					}
					set	
					{
						importOSSObject = value;
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

				public string Progress
				{
					get
					{
						return progress;
					}
					set	
					{
						progress = value;
					}
				}

				public string Version
				{
					get
					{
						return version;
					}
					set	
					{
						version = value;
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

				public string ImageCategory
				{
					get
					{
						return imageCategory;
					}
					set	
					{
						imageCategory = value;
					}
				}

				public string DisplayName
				{
					get
					{
						return displayName;
					}
					set	
					{
						displayName = value;
					}
				}

				public string Owner
				{
					get
					{
						return owner;
					}
					set	
					{
						owner = value;
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

				public string ImportOSSBucket
				{
					get
					{
						return importOSSBucket;
					}
					set	
					{
						importOSSBucket = value;
					}
				}

				public string Format
				{
					get
					{
						return format;
					}
					set	
					{
						format = value;
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

				public int? ImageSize
				{
					get
					{
						return imageSize;
					}
					set	
					{
						imageSize = value;
					}
				}

				public string SnapshotNo
				{
					get
					{
						return snapshotNo;
					}
					set	
					{
						snapshotNo = value;
					}
				}

				public List<InnerDetail_Tag2> Tags1
				{
					get
					{
						return tags1;
					}
					set	
					{
						tags1 = value;
					}
				}

				public InnerDetail_OsTypeModel OsTypeModel
				{
					get
					{
						return osTypeModel;
					}
					set	
					{
						osTypeModel = value;
					}
				}

				public InnerDetail_QuoteType QuoteType
				{
					get
					{
						return quoteType;
					}
					set	
					{
						quoteType = value;
					}
				}

				public class InnerDetail_Tag2
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

				public class InnerDetail_OsTypeModel
				{

					private string platform;

					private long? id;

					private int? osBit;

					private int? minCpu;

					private int? minMemory;

					private int? maxCpu;

					private int? maxMemory;

					private string osName;

					private string osMemo;

					private string type;

					private InnerDetail_Kind kind;

					public string Platform
					{
						get
						{
							return platform;
						}
						set	
						{
							platform = value;
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

					public int? OsBit
					{
						get
						{
							return osBit;
						}
						set	
						{
							osBit = value;
						}
					}

					public int? MinCpu
					{
						get
						{
							return minCpu;
						}
						set	
						{
							minCpu = value;
						}
					}

					public int? MinMemory
					{
						get
						{
							return minMemory;
						}
						set	
						{
							minMemory = value;
						}
					}

					public int? MaxCpu
					{
						get
						{
							return maxCpu;
						}
						set	
						{
							maxCpu = value;
						}
					}

					public int? MaxMemory
					{
						get
						{
							return maxMemory;
						}
						set	
						{
							maxMemory = value;
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

					public string OsMemo
					{
						get
						{
							return osMemo;
						}
						set	
						{
							osMemo = value;
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

					public InnerDetail_Kind Kind
					{
						get
						{
							return kind;
						}
						set	
						{
							kind = value;
						}
					}

					public class InnerDetail_Kind
					{

						private string kind;

						public string Kind
						{
							get
							{
								return kind;
							}
							set	
							{
								kind = value;
							}
						}
					}
				}

				public class InnerDetail_QuoteType
				{

					private string quoteType;

					public string QuoteType
					{
						get
						{
							return quoteType;
						}
						set	
						{
							quoteType = value;
						}
					}
				}
			}

			public class InnerDetail_StatusNote
			{

				private string noteCode;

				private string noteInfo;

				public string NoteCode
				{
					get
					{
						return noteCode;
					}
					set	
					{
						noteCode = value;
					}
				}

				public string NoteInfo
				{
					get
					{
						return noteInfo;
					}
					set	
					{
						noteInfo = value;
					}
				}
			}
		}
	}
}
