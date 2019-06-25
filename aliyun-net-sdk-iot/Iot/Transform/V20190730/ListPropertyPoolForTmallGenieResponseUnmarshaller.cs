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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Iot.Model.V20190730;

namespace Aliyun.Acs.Iot.Transform.V20190730
{
    public class ListPropertyPoolForTmallGenieResponseUnmarshaller
    {
        public static ListPropertyPoolForTmallGenieResponse Unmarshall(UnmarshallerContext context)
        {
			ListPropertyPoolForTmallGenieResponse listPropertyPoolForTmallGenieResponse = new ListPropertyPoolForTmallGenieResponse();

			listPropertyPoolForTmallGenieResponse.HttpResponse = context.HttpResponse;
			listPropertyPoolForTmallGenieResponse.RequestId = context.StringValue("ListPropertyPoolForTmallGenie.RequestId");
			listPropertyPoolForTmallGenieResponse.Success = context.BooleanValue("ListPropertyPoolForTmallGenie.Success");
			listPropertyPoolForTmallGenieResponse.Code = context.StringValue("ListPropertyPoolForTmallGenie.Code");
			listPropertyPoolForTmallGenieResponse.ErrorMessage = context.StringValue("ListPropertyPoolForTmallGenie.ErrorMessage");
			listPropertyPoolForTmallGenieResponse.Total = context.IntegerValue("ListPropertyPoolForTmallGenie.Total");
			listPropertyPoolForTmallGenieResponse.PageId = context.IntegerValue("ListPropertyPoolForTmallGenie.PageId");
			listPropertyPoolForTmallGenieResponse.PageSize = context.IntegerValue("ListPropertyPoolForTmallGenie.PageSize");

			List<ListPropertyPoolForTmallGenieResponse.ListPropertyPoolForTmallGenie_Property> listPropertyPoolForTmallGenieResponse_properties = new List<ListPropertyPoolForTmallGenieResponse.ListPropertyPoolForTmallGenie_Property>();
			for (int i = 0; i < context.Length("ListPropertyPoolForTmallGenie.Properties.Length"); i++) {
				ListPropertyPoolForTmallGenieResponse.ListPropertyPoolForTmallGenie_Property property = new ListPropertyPoolForTmallGenieResponse.ListPropertyPoolForTmallGenie_Property();
				property.TmallFunctionId = context.LongValue("ListPropertyPoolForTmallGenie.Properties["+ i +"].TmallFunctionId");
				property.ThingTemplateKey = context.StringValue("ListPropertyPoolForTmallGenie.Properties["+ i +"].ThingTemplateKey");
				property.DataType = context.StringValue("ListPropertyPoolForTmallGenie.Properties["+ i +"].DataType");
				property.RwType = context.StringValue("ListPropertyPoolForTmallGenie.Properties["+ i +"].RwType");
				property.Name = context.StringValue("ListPropertyPoolForTmallGenie.Properties["+ i +"].Name");
				property.DataSpecs = context.StringValue("ListPropertyPoolForTmallGenie.Properties["+ i +"].DataSpecs");
				property.DataSpecsList = context.StringValue("ListPropertyPoolForTmallGenie.Properties["+ i +"].DataSpecsList");

				List<ListPropertyPoolForTmallGenieResponse.ListPropertyPoolForTmallGenie_Property.ListPropertyPoolForTmallGenie_Tag> property_tags = new List<ListPropertyPoolForTmallGenieResponse.ListPropertyPoolForTmallGenie_Property.ListPropertyPoolForTmallGenie_Tag>();
				for (int j = 0; j < context.Length("ListPropertyPoolForTmallGenie.Properties["+ i +"].Tags.Length"); j++) {
					ListPropertyPoolForTmallGenieResponse.ListPropertyPoolForTmallGenie_Property.ListPropertyPoolForTmallGenie_Tag tag = new ListPropertyPoolForTmallGenieResponse.ListPropertyPoolForTmallGenie_Property.ListPropertyPoolForTmallGenie_Tag();
					tag.TagKey = context.StringValue("ListPropertyPoolForTmallGenie.Properties["+ i +"].Tags["+ j +"].TagKey");
					tag.TagValue = context.StringValue("ListPropertyPoolForTmallGenie.Properties["+ i +"].Tags["+ j +"].TagValue");

					property_tags.Add(tag);
				}
				property.Tags = property_tags;

				listPropertyPoolForTmallGenieResponse_properties.Add(property);
			}
			listPropertyPoolForTmallGenieResponse.Properties = listPropertyPoolForTmallGenieResponse_properties;
        
			return listPropertyPoolForTmallGenieResponse;
        }
    }
}
