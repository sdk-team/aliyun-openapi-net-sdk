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
    public class ListEventPoolForTmallGenieResponseUnmarshaller
    {
        public static ListEventPoolForTmallGenieResponse Unmarshall(UnmarshallerContext context)
        {
			ListEventPoolForTmallGenieResponse listEventPoolForTmallGenieResponse = new ListEventPoolForTmallGenieResponse();

			listEventPoolForTmallGenieResponse.HttpResponse = context.HttpResponse;
			listEventPoolForTmallGenieResponse.RequestId = context.StringValue("ListEventPoolForTmallGenie.RequestId");
			listEventPoolForTmallGenieResponse.Success = context.BooleanValue("ListEventPoolForTmallGenie.Success");
			listEventPoolForTmallGenieResponse.Code = context.StringValue("ListEventPoolForTmallGenie.Code");
			listEventPoolForTmallGenieResponse.ErrorMessage = context.StringValue("ListEventPoolForTmallGenie.ErrorMessage");
			listEventPoolForTmallGenieResponse.PageNo = context.IntegerValue("ListEventPoolForTmallGenie.PageNo");
			listEventPoolForTmallGenieResponse.Total = context.IntegerValue("ListEventPoolForTmallGenie.Total");
			listEventPoolForTmallGenieResponse.PageSize = context.IntegerValue("ListEventPoolForTmallGenie.PageSize");

			List<ListEventPoolForTmallGenieResponse.ListEventPoolForTmallGenie__Event> listEventPoolForTmallGenieResponse_events = new List<ListEventPoolForTmallGenieResponse.ListEventPoolForTmallGenie__Event>();
			for (int i = 0; i < context.Length("ListEventPoolForTmallGenie.Events.Length"); i++) {
				ListEventPoolForTmallGenieResponse.ListEventPoolForTmallGenie__Event _event = new ListEventPoolForTmallGenieResponse.ListEventPoolForTmallGenie__Event();
				_event.TmallFunctionId = context.LongValue("ListEventPoolForTmallGenie.Events["+ i +"].TmallFunctionId");
				_event.ThingTemplateKey = context.StringValue("ListEventPoolForTmallGenie.Events["+ i +"].ThingTemplateKey");
				_event.EventType = context.StringValue("ListEventPoolForTmallGenie.Events["+ i +"].EventType");
				_event.Name = context.StringValue("ListEventPoolForTmallGenie.Events["+ i +"].Name");
				_event.Identifier = context.StringValue("ListEventPoolForTmallGenie.Events["+ i +"].Identifier");

				List<ListEventPoolForTmallGenieResponse.ListEventPoolForTmallGenie__Event.ListEventPoolForTmallGenie_Argument> _event_outputData = new List<ListEventPoolForTmallGenieResponse.ListEventPoolForTmallGenie__Event.ListEventPoolForTmallGenie_Argument>();
				for (int j = 0; j < context.Length("ListEventPoolForTmallGenie.Events["+ i +"].OutputData.Length"); j++) {
					ListEventPoolForTmallGenieResponse.ListEventPoolForTmallGenie__Event.ListEventPoolForTmallGenie_Argument argument = new ListEventPoolForTmallGenieResponse.ListEventPoolForTmallGenie__Event.ListEventPoolForTmallGenie_Argument();
					argument.Id = context.LongValue("ListEventPoolForTmallGenie.Events["+ i +"].OutputData["+ j +"].Id");
					argument.DataType = context.StringValue("ListEventPoolForTmallGenie.Events["+ i +"].OutputData["+ j +"].DataType");
					argument.Identifier = context.StringValue("ListEventPoolForTmallGenie.Events["+ i +"].OutputData["+ j +"].Identifier");
					argument.Name = context.StringValue("ListEventPoolForTmallGenie.Events["+ i +"].OutputData["+ j +"].Name");
					argument.ParaOrder = context.IntegerValue("ListEventPoolForTmallGenie.Events["+ i +"].OutputData["+ j +"].ParaOrder");
					argument.DataSpecs = context.StringValue("ListEventPoolForTmallGenie.Events["+ i +"].OutputData["+ j +"].DataSpecs");
					argument.DataSpecsList = context.StringValue("ListEventPoolForTmallGenie.Events["+ i +"].OutputData["+ j +"].DataSpecsList");
					argument.TmallFunctionId = context.LongValue("ListEventPoolForTmallGenie.Events["+ i +"].OutputData["+ j +"].TmallFunctionId");

					_event_outputData.Add(argument);
				}
				_event.OutputData = _event_outputData;

				List<ListEventPoolForTmallGenieResponse.ListEventPoolForTmallGenie__Event.ListEventPoolForTmallGenie_Tag> _event_tags = new List<ListEventPoolForTmallGenieResponse.ListEventPoolForTmallGenie__Event.ListEventPoolForTmallGenie_Tag>();
				for (int j = 0; j < context.Length("ListEventPoolForTmallGenie.Events["+ i +"].Tags.Length"); j++) {
					ListEventPoolForTmallGenieResponse.ListEventPoolForTmallGenie__Event.ListEventPoolForTmallGenie_Tag tag = new ListEventPoolForTmallGenieResponse.ListEventPoolForTmallGenie__Event.ListEventPoolForTmallGenie_Tag();
					tag.TagKey = context.StringValue("ListEventPoolForTmallGenie.Events["+ i +"].Tags["+ j +"].TagKey");
					tag.TagValue = context.StringValue("ListEventPoolForTmallGenie.Events["+ i +"].Tags["+ j +"].TagValue");

					_event_tags.Add(tag);
				}
				_event.Tags = _event_tags;

				listEventPoolForTmallGenieResponse_events.Add(_event);
			}
			listEventPoolForTmallGenieResponse.Events = listEventPoolForTmallGenieResponse_events;
        
			return listEventPoolForTmallGenieResponse;
        }
    }
}
