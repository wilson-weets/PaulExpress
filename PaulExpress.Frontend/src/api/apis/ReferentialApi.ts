// tslint:disable
// eslint-disable
/**
 * PaulExpress API v1.0
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1.0
 *
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import * as runtime from "../runtime";
import {
  EReferentialTypes,
  EReferentialTypesFromJSON,
  EReferentialTypesToJSON,
  ReferentialResultInfoDto,
  ReferentialResultInfoDtoFromJSON,
  ReferentialResultInfoDtoToJSON
} from "../models";

export interface ReferentialApiApiReferentialReferentialTypeGetRequest {
  referentialType: EReferentialTypes;
  shopId?: number;
}

/**
 * no description
 */
export class ReferentialApi extends runtime.BaseAPI {
  /**
   */
  async apiReferentialReferentialTypeGetRaw(
    requestParameters: ReferentialApiApiReferentialReferentialTypeGetRequest
  ): Promise<runtime.ApiResponse<ReferentialResultInfoDto>> {
    if (requestParameters.referentialType === null || requestParameters.referentialType === undefined) {
      throw new runtime.RequiredError(
        "referentialType",
        "Required parameter requestParameters.referentialType was null or undefined when calling apiReferentialReferentialTypeGet."
      );
    }

    const queryParameters: runtime.HTTPQuery = {};

    if (requestParameters.shopId !== undefined) {
      queryParameters["shopId"] = requestParameters.shopId;
    }

    const headerParameters: runtime.HTTPHeaders = {};

    if (this.configuration && this.configuration.apiKey) {
      headerParameters["Authorization"] = this.configuration.apiKey("Authorization"); // Bearer authentication
    }

    const response = await this.request({
      path: `/api/Referential/{referentialType}`.replace(
        `{${"referentialType"}}`,
        encodeURIComponent(String(requestParameters.referentialType))
      ),
      method: "GET",
      headers: headerParameters,
      query: queryParameters
    });

    return new runtime.JSONApiResponse(response, jsonValue => ReferentialResultInfoDtoFromJSON(jsonValue));
  }

  /**
   */
  async apiReferentialReferentialTypeGet(
    requestParameters: ReferentialApiApiReferentialReferentialTypeGetRequest
  ): Promise<ReferentialResultInfoDto> {
    const response = await this.apiReferentialReferentialTypeGetRaw(requestParameters);
    return await response.value();
  }
}
