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
	public class InnerEcsInstanceQueryByParamResponse : AcsResponse
	{

		private string requestId;

		private int? count;

		private int? pageNo;

		private int? pageSize;

		private List<InnerEcsInstanceQueryByParam_Item> data;

		private InnerEcsInstanceQueryByParam_ErrorCode errorCode;

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

		public List<InnerEcsInstanceQueryByParam_Item> Data
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

		public InnerEcsInstanceQueryByParam_ErrorCode ErrorCode
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

		public class InnerEcsInstanceQueryByParam_Item
		{

			private int? internetTx;

			private string vswitchInstanceId;

			private string instanceTypeFamily;

			private bool? networkValidation;

			private string regionNo;

			private string instanceName;

			private string businessStatus;

			private string eip;

			private long? aliUid;

			private string houyiStatus;

			private int? intranetTx;

			private int? cores;

			private string innerIp;

			private string ecsName;

			private int? bps;

			private string vpcInstanceId;

			private long? id;

			private string bid;

			private int? mem;

			private string status;

			private int? internetRx;

			private string hostname;

			private int? eipBandwidth;

			private string zoneNo;

			private string natIp;

			private string instanceType;

			private string netWorkType;

			private bool? deviceAvailable;

			private bool? ioOptimized;

			private string systemDeviceCategory;

			private int? disk;

			private string securityControl;

			private string eipInstanceId;

			private int? intranetRx;

			private string izNo;

			private string serialNumber;

			private string realZoneNo;

			private string description;

			private string creationTime;

			private List<InnerEcsInstanceQueryByParam_Tag> tags;

			private List<InnerEcsInstanceQueryByParam_Group> groups;

			private InnerEcsInstanceQueryByParam_PublicIp publicIp;

			private InnerEcsInstanceQueryByParam_Img img;

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

			public string HouyiStatus
			{
				get
				{
					return houyiStatus;
				}
				set	
				{
					houyiStatus = value;
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

			public bool? DeviceAvailable
			{
				get
				{
					return deviceAvailable;
				}
				set	
				{
					deviceAvailable = value;
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

			public List<InnerEcsInstanceQueryByParam_Tag> Tags
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

			public List<InnerEcsInstanceQueryByParam_Group> Groups
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

			public InnerEcsInstanceQueryByParam_PublicIp PublicIp
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

			public InnerEcsInstanceQueryByParam_Img Img
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

			public class InnerEcsInstanceQueryByParam_Tag
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

			public class InnerEcsInstanceQueryByParam_Group
			{

				private string groupDesc;

				private string groupNo;

				private string groupName;

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
			}

			public class InnerEcsInstanceQueryByParam_PublicIp
			{

				private string assignIp;

				private string bindIp;

				private string assignNatIp;

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
			}

			public class InnerEcsInstanceQueryByParam_Img
			{

				private string name;

				private string imageNo;

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
			}
		}

		public class InnerEcsInstanceQueryByParam_ErrorCode
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
