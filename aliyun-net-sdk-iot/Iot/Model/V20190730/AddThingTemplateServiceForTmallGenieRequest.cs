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
    public class AddThingTemplateServiceForTmallGenieRequest : RpcAcsRequest<AddThingTemplateServiceForTmallGenieResponse>
    {
        public AddThingTemplateServiceForTmallGenieRequest()
            : base("Iot", "2019-07-30", "AddThingTemplateServiceForTmallGenie", "Iot", "openAPI")
        {
        }

		private string identifier;

		private List<InputParams> inputParamss;

		private long? tmallFunctionId;

		private string iotInstanceId;

		private string name;

		private string callType;

		private List<OutputParams> outputParamss;

		private List<Tags> tagss;

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

		public List<InputParams> InputParamss
		{
			get
			{
				return inputParamss;
			}

			set
			{
				inputParamss = value;
				for (int i = 0; i < inputParamss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"InputParams." + (i + 1) + ".Identifier", inputParamss[i].Identifier);
					DictionaryUtil.Add(QueryParameters,"InputParams." + (i + 1) + ".DataSpecs", inputParamss[i].DataSpecs);
					DictionaryUtil.Add(QueryParameters,"InputParams." + (i + 1) + ".DataType", inputParamss[i].DataType);
					DictionaryUtil.Add(QueryParameters,"InputParams." + (i + 1) + ".Name", inputParamss[i].Name);
					DictionaryUtil.Add(QueryParameters,"InputParams." + (i + 1) + ".DataSpecsList", inputParamss[i].DataSpecsList);
					DictionaryUtil.Add(QueryParameters,"InputParams." + (i + 1) + ".ParaOrder", inputParamss[i].ParaOrder);
					DictionaryUtil.Add(QueryParameters,"InputParams." + (i + 1) + ".Direction", inputParamss[i].Direction);
				}
			}
		}

		public long? TmallFunctionId
		{
			get
			{
				return tmallFunctionId;
			}
			set	
			{
				tmallFunctionId = value;
				DictionaryUtil.Add(QueryParameters, "TmallFunctionId", value.ToString());
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

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(QueryParameters, "Name", value);
			}
		}

		public string CallType
		{
			get
			{
				return callType;
			}
			set	
			{
				callType = value;
				DictionaryUtil.Add(QueryParameters, "CallType", value);
			}
		}

		public List<OutputParams> OutputParamss
		{
			get
			{
				return outputParamss;
			}

			set
			{
				outputParamss = value;
				for (int i = 0; i < outputParamss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"OutputParams." + (i + 1) + ".Identifier", outputParamss[i].Identifier);
					DictionaryUtil.Add(QueryParameters,"OutputParams." + (i + 1) + ".DataSpecs", outputParamss[i].DataSpecs);
					DictionaryUtil.Add(QueryParameters,"OutputParams." + (i + 1) + ".DataType", outputParamss[i].DataType);
					DictionaryUtil.Add(QueryParameters,"OutputParams." + (i + 1) + ".Name", outputParamss[i].Name);
					DictionaryUtil.Add(QueryParameters,"OutputParams." + (i + 1) + ".DataSpecsList", outputParamss[i].DataSpecsList);
					DictionaryUtil.Add(QueryParameters,"OutputParams." + (i + 1) + ".ParaOrder", outputParamss[i].ParaOrder);
					DictionaryUtil.Add(QueryParameters,"OutputParams." + (i + 1) + ".Direction", outputParamss[i].Direction);
				}
			}
		}

		public List<Tags> Tagss
		{
			get
			{
				return tagss;
			}

			set
			{
				tagss = value;
				for (int i = 0; i < tagss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Tags." + (i + 1) + ".TagValue", tagss[i].TagValue);
					DictionaryUtil.Add(QueryParameters,"Tags." + (i + 1) + ".TagKey", tagss[i].TagKey);
				}
			}
		}

		public class InputParams
		{

			private string identifier;

			private string dataSpecs;

			private string dataType;

			private string name;

			private string dataSpecsList;

			private int? paraOrder;

			private string direction;

			public string Identifier
			{
				get
				{
					return identifier;
				}
				set	
				{
					identifier = value;
				}
			}

			public string DataSpecs
			{
				get
				{
					return dataSpecs;
				}
				set	
				{
					dataSpecs = value;
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
				}
			}

			public int? ParaOrder
			{
				get
				{
					return paraOrder;
				}
				set	
				{
					paraOrder = value;
				}
			}

			public string Direction
			{
				get
				{
					return direction;
				}
				set	
				{
					direction = value;
				}
			}
		}

		public class OutputParams
		{

			private string identifier;

			private string dataSpecs;

			private string dataType;

			private string name;

			private string dataSpecsList;

			private int? paraOrder;

			private string direction;

			public string Identifier
			{
				get
				{
					return identifier;
				}
				set	
				{
					identifier = value;
				}
			}

			public string DataSpecs
			{
				get
				{
					return dataSpecs;
				}
				set	
				{
					dataSpecs = value;
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
				}
			}

			public int? ParaOrder
			{
				get
				{
					return paraOrder;
				}
				set	
				{
					paraOrder = value;
				}
			}

			public string Direction
			{
				get
				{
					return direction;
				}
				set	
				{
					direction = value;
				}
			}
		}

		public class Tags
		{

			private string tagValue;

			private string tagKey;

			public string TagValue
			{
				get
				{
					return tagValue;
				}
				set	
				{
					tagValue = value;
				}
			}

			public string TagKey
			{
				get
				{
					return tagKey;
				}
				set	
				{
					tagKey = value;
				}
			}
		}

        public override AddThingTemplateServiceForTmallGenieResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddThingTemplateServiceForTmallGenieResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
