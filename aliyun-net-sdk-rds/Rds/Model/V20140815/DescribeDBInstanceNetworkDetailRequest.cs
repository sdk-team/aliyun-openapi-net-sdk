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
using Aliyun.Acs.Rds;
using Aliyun.Acs.Rds.Transform;
using Aliyun.Acs.Rds.Transform.V20140815;

namespace Aliyun.Acs.Rds.Model.V20140815
{
    public class DescribeDBInstanceNetworkDetailRequest : RpcAcsRequest<DescribeDBInstanceNetworkDetailResponse>
    {
        public DescribeDBInstanceNetworkDetailRequest()
            : base("Rds", "2014-08-15", "DescribeDBInstanceNetworkDetail")
        {
        }

		private string endPoint;

		private string startPoint;

		private string endTime;

		private string dBInstanceId;

		private string startTime;

		public string EndPoint
		{
			get
			{
				return endPoint;
			}
			set	
			{
				endPoint = value;
				DictionaryUtil.Add(QueryParameters, "EndPoint", value);
			}
		}

		public string StartPoint
		{
			get
			{
				return startPoint;
			}
			set	
			{
				startPoint = value;
				DictionaryUtil.Add(QueryParameters, "StartPoint", value);
			}
		}

		public string EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
				DictionaryUtil.Add(QueryParameters, "EndTime", value);
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
				DictionaryUtil.Add(QueryParameters, "DBInstanceId", value);
			}
		}

		public string StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
				DictionaryUtil.Add(QueryParameters, "StartTime", value);
			}
		}

        public override DescribeDBInstanceNetworkDetailResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeDBInstanceNetworkDetailResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
