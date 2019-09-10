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
using Aliyun.Acs.Iot.Transform;
using Aliyun.Acs.Iot.Transform.V20190730;

namespace Aliyun.Acs.Iot.Model.V20190730
{
    public class UpdateProductPropertyIdentifierForTmallGenieRequest : RpcAcsRequest<UpdateProductPropertyIdentifierForTmallGenieResponse>
    {
        public UpdateProductPropertyIdentifierForTmallGenieRequest()
            : base("Iot", "2019-07-30", "UpdateProductPropertyIdentifierForTmallGenie", "Iot", "openAPI")
        {
        }

		private string dataSpecs;

		private string description;

		private string dataSpecsList;

		private string dataType;

		private string iotInstanceId;

		private string identifier;

		private string productKey;

		private string rwType;

		private string name;

		public string DataSpecs
		{
			get
			{
				return dataSpecs;
			}
			set	
			{
				dataSpecs = value;
				DictionaryUtil.Add(BodyParameters, "DataSpecs", value);
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
				DictionaryUtil.Add(BodyParameters, "Description", value);
			}
		}

		public string DataSpecsList
		{
			get
			{
				return dataSpecsList;
			}
			set	
			{
				dataSpecsList = value;
				DictionaryUtil.Add(BodyParameters, "DataSpecsList", value);
			}
		}

		public string DataType
		{
			get
			{
				return dataType;
			}
			set	
			{
				dataType = value;
				DictionaryUtil.Add(BodyParameters, "DataType", value);
			}
		}

		public string IotInstanceId
		{
			get
			{
				return iotInstanceId;
			}
			set	
			{
				iotInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "IotInstanceId", value);
			}
		}

		public string Identifier
		{
			get
			{
				return identifier;
			}
			set	
			{
				identifier = value;
				DictionaryUtil.Add(QueryParameters, "Identifier", value);
			}
		}

		public string ProductKey
		{
			get
			{
				return productKey;
			}
			set	
			{
				productKey = value;
				DictionaryUtil.Add(QueryParameters, "ProductKey", value);
			}
		}

		public string RwType
		{
			get
			{
				return rwType;
			}
			set	
			{
				rwType = value;
				DictionaryUtil.Add(BodyParameters, "RwType", value);
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(BodyParameters, "Name", value);
			}
		}

        public override UpdateProductPropertyIdentifierForTmallGenieResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateProductPropertyIdentifierForTmallGenieResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
