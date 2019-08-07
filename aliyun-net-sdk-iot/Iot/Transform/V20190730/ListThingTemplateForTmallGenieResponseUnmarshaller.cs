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
    public class ListThingTemplateForTmallGenieResponseUnmarshaller
    {
        public static ListThingTemplateForTmallGenieResponse Unmarshall(UnmarshallerContext context)
        {
			ListThingTemplateForTmallGenieResponse listThingTemplateForTmallGenieResponse = new ListThingTemplateForTmallGenieResponse();

			listThingTemplateForTmallGenieResponse.HttpResponse = context.HttpResponse;
			listThingTemplateForTmallGenieResponse.RequestId = context.StringValue("ListThingTemplateForTmallGenie.RequestId");
			listThingTemplateForTmallGenieResponse.Success = context.BooleanValue("ListThingTemplateForTmallGenie.Success");
			listThingTemplateForTmallGenieResponse.ErrorMessage = context.StringValue("ListThingTemplateForTmallGenie.ErrorMessage");
			listThingTemplateForTmallGenieResponse.Code = context.StringValue("ListThingTemplateForTmallGenie.Code");
			listThingTemplateForTmallGenieResponse.Page = context.IntegerValue("ListThingTemplateForTmallGenie.Page");
			listThingTemplateForTmallGenieResponse.PageSize = context.IntegerValue("ListThingTemplateForTmallGenie.PageSize");
			listThingTemplateForTmallGenieResponse.Total = context.IntegerValue("ListThingTemplateForTmallGenie.Total");

			List<ListThingTemplateForTmallGenieResponse.ListThingTemplateForTmallGenie_ThingTemplate> listThingTemplateForTmallGenieResponse_data = new List<ListThingTemplateForTmallGenieResponse.ListThingTemplateForTmallGenie_ThingTemplate>();
			for (int i = 0; i < context.Length("ListThingTemplateForTmallGenie.Data.Length"); i++) {
				ListThingTemplateForTmallGenieResponse.ListThingTemplateForTmallGenie_ThingTemplate thingTemplate = new ListThingTemplateForTmallGenieResponse.ListThingTemplateForTmallGenie_ThingTemplate();
				thingTemplate.ThingTemplateKey = context.StringValue("ListThingTemplateForTmallGenie.Data["+ i +"].ThingTemplateKey");
				thingTemplate.ThingTemplateName = context.StringValue("ListThingTemplateForTmallGenie.Data["+ i +"].ThingTemplateName");
				thingTemplate.ThingTemplateId = context.StringValue("ListThingTemplateForTmallGenie.Data["+ i +"].ThingTemplateId");

				List<ListThingTemplateForTmallGenieResponse.ListThingTemplateForTmallGenie_ThingTemplate.ListThingTemplateForTmallGenie_Tag> thingTemplate_tags = new List<ListThingTemplateForTmallGenieResponse.ListThingTemplateForTmallGenie_ThingTemplate.ListThingTemplateForTmallGenie_Tag>();
				for (int j = 0; j < context.Length("ListThingTemplateForTmallGenie.Data["+ i +"].Tags.Length"); j++) {
					ListThingTemplateForTmallGenieResponse.ListThingTemplateForTmallGenie_ThingTemplate.ListThingTemplateForTmallGenie_Tag tag = new ListThingTemplateForTmallGenieResponse.ListThingTemplateForTmallGenie_ThingTemplate.ListThingTemplateForTmallGenie_Tag();
					tag.TagKey = context.StringValue("ListThingTemplateForTmallGenie.Data["+ i +"].Tags["+ j +"].TagKey");
					tag.TagValue = context.StringValue("ListThingTemplateForTmallGenie.Data["+ i +"].Tags["+ j +"].TagValue");

					thingTemplate_tags.Add(tag);
				}
				thingTemplate.Tags = thingTemplate_tags;

				listThingTemplateForTmallGenieResponse_data.Add(thingTemplate);
			}
			listThingTemplateForTmallGenieResponse.Data = listThingTemplateForTmallGenieResponse_data;
        
			return listThingTemplateForTmallGenieResponse;
        }
    }
}
