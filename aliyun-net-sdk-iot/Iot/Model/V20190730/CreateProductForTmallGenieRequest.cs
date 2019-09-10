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
    public class CreateProductForTmallGenieRequest : RpcAcsRequest<CreateProductForTmallGenieResponse>
    {
        public CreateProductForTmallGenieRequest()
            : base("Iot", "2019-07-30", "CreateProductForTmallGenie", "Iot", "openAPI")
        {
        }

		private int? nodeType;

		private string taoBaoId;

		private string description;

		private string productName;

		private string productBrand;

		private long? categoryId;

		private string productModel;

		private int? dataFormat;

		private string tmallGenieTraceId;

		private int? netType;

		private string apiProduct;

		private string apiRevision;

		public int? NodeType
		{
			get
			{
				return nodeType;
			}
			set	
			{
				nodeType = value;
				DictionaryUtil.Add(BodyParameters, "NodeType", value.ToString());
			}
		}

		public string TaoBaoId
		{
			get
			{
				return taoBaoId;
			}
			set	
			{
				taoBaoId = value;
				DictionaryUtil.Add(BodyParameters, "TaoBaoId", value);
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

		public string ProductName
		{
			get
			{
				return productName;
			}
			set	
			{
				productName = value;
				DictionaryUtil.Add(BodyParameters, "ProductName", value);
			}
		}

		public string ProductBrand
		{
			get
			{
				return productBrand;
			}
			set	
			{
				productBrand = value;
				DictionaryUtil.Add(BodyParameters, "ProductBrand", value);
			}
		}

		public long? CategoryId
		{
			get
			{
				return categoryId;
			}
			set	
			{
				categoryId = value;
				DictionaryUtil.Add(BodyParameters, "CategoryId", value.ToString());
			}
		}

		public string ProductModel
		{
			get
			{
				return productModel;
			}
			set	
			{
				productModel = value;
				DictionaryUtil.Add(BodyParameters, "ProductModel", value);
			}
		}

		public int? DataFormat
		{
			get
			{
				return dataFormat;
			}
			set	
			{
				dataFormat = value;
				DictionaryUtil.Add(BodyParameters, "DataFormat", value.ToString());
			}
		}

		public string TmallGenieTraceId
		{
			get
			{
				return tmallGenieTraceId;
			}
			set	
			{
				tmallGenieTraceId = value;
				DictionaryUtil.Add(QueryParameters, "TmallGenieTraceId", value);
			}
		}

		public int? NetType
		{
			get
			{
				return netType;
			}
			set	
			{
				netType = value;
				DictionaryUtil.Add(BodyParameters, "NetType", value.ToString());
			}
		}

		public string ApiProduct
		{
			get
			{
				return apiProduct;
			}
			set	
			{
				apiProduct = value;
				DictionaryUtil.Add(BodyParameters, "ApiProduct", value);
			}
		}

		public string ApiRevision
		{
			get
			{
				return apiRevision;
			}
			set	
			{
				apiRevision = value;
				DictionaryUtil.Add(BodyParameters, "ApiRevision", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateProductForTmallGenieResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateProductForTmallGenieResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
