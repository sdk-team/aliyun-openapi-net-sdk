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
using Aliyun.Acs.vod.Model.V20170314;

namespace Aliyun.Acs.vod.Transform.V20170314
{
    public class GetDomainListResponseUnmarshaller
    {
        public static GetDomainListResponse Unmarshall(UnmarshallerContext context)
        {
			GetDomainListResponse getDomainListResponse = new GetDomainListResponse();

			getDomainListResponse.HttpResponse = context.HttpResponse;
			getDomainListResponse.RequestId = context.StringValue("GetDomainList.RequestId");

			List<GetDomainListResponse.GetDomainList_DomainDTO> getDomainListResponse_domainDTOList = new List<GetDomainListResponse.GetDomainList_DomainDTO>();
			for (int i = 0; i < context.Length("GetDomainList.DomainDTOList.Length"); i++) {
				GetDomainListResponse.GetDomainList_DomainDTO domainDTO = new GetDomainListResponse.GetDomainList_DomainDTO();
				domainDTO.UserId = context.LongValue("GetDomainList.DomainDTOList["+ i +"].UserId");
				domainDTO.DomainName = context.StringValue("GetDomainList.DomainDTOList["+ i +"].DomainName");
				domainDTO.DomainType = context.StringValue("GetDomainList.DomainDTOList["+ i +"].DomainType");
				domainDTO.DomainCname = context.StringValue("GetDomainList.DomainDTOList["+ i +"].DomainCname");
				domainDTO.DomainStatus = context.StringValue("GetDomainList.DomainDTOList["+ i +"].DomainStatus");
				domainDTO.BucketName = context.StringValue("GetDomainList.DomainDTOList["+ i +"].BucketName");
				domainDTO.BucketEndpoint = context.StringValue("GetDomainList.DomainDTOList["+ i +"].BucketEndpoint");
				domainDTO.DefaultPlay = context.BooleanValue("GetDomainList.DomainDTOList["+ i +"].DefaultPlay");
				domainDTO.SourceLocation = context.StringValue("GetDomainList.DomainDTOList["+ i +"].SourceLocation");

				getDomainListResponse_domainDTOList.Add(domainDTO);
			}
			getDomainListResponse.DomainDTOList = getDomainListResponse_domainDTOList;
        
			return getDomainListResponse;
        }
    }
}
