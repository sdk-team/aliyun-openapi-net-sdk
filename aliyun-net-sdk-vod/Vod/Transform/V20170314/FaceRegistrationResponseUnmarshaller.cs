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
    public class FaceRegistrationResponseUnmarshaller
    {
        public static FaceRegistrationResponse Unmarshall(UnmarshallerContext context)
        {
			FaceRegistrationResponse faceRegistrationResponse = new FaceRegistrationResponse();

			faceRegistrationResponse.HttpResponse = context.HttpResponse;
			faceRegistrationResponse.RequestId = context.StringValue("FaceRegistration.RequestId");

			List<string> faceRegistrationResponse_nonExistImageIds = new List<string>();
			for (int i = 0; i < context.Length("FaceRegistration.NonExistImageIds.Length"); i++) {
				faceRegistrationResponse_nonExistImageIds.Add(context.StringValue("FaceRegistration.NonExistImageIds["+ i +"]"));
			}
			faceRegistrationResponse.NonExistImageIds = faceRegistrationResponse_nonExistImageIds;

			FaceRegistrationResponse.FaceRegistration_RegisteredPerson registeredPerson = new FaceRegistrationResponse.FaceRegistration_RegisteredPerson();
			registeredPerson.PersonId = context.StringValue("FaceRegistration.RegisteredPerson.PersonId");
			registeredPerson.PersonName = context.StringValue("FaceRegistration.RegisteredPerson.PersonName");

			List<FaceRegistrationResponse.FaceRegistration_RegisteredPerson.FaceRegistration_Face> registeredPerson_faces = new List<FaceRegistrationResponse.FaceRegistration_RegisteredPerson.FaceRegistration_Face>();
			for (int i = 0; i < context.Length("FaceRegistration.RegisteredPerson.Faces.Length"); i++) {
				FaceRegistrationResponse.FaceRegistration_RegisteredPerson.FaceRegistration_Face face = new FaceRegistrationResponse.FaceRegistration_RegisteredPerson.FaceRegistration_Face();
				face.ImageId = context.StringValue("FaceRegistration.RegisteredPerson.Faces["+ i +"].ImageId");
				face.Quality = context.StringValue("FaceRegistration.RegisteredPerson.Faces["+ i +"].Quality");
				face.Target = context.StringValue("FaceRegistration.RegisteredPerson.Faces["+ i +"].Target");

				registeredPerson_faces.Add(face);
			}
			registeredPerson.Faces = registeredPerson_faces;
			faceRegistrationResponse.RegisteredPerson = registeredPerson;
        
			return faceRegistrationResponse;
        }
    }
}
