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

import { exists, mapValues } from "../runtime";
/**
 *
 * @export
 * @interface OrderGridDto
 */
export interface OrderGridDto {
  /**
   *
   * @type {number}
   * @memberof OrderGridDto
   */
  orderId?: number;
  /**
   *
   * @type {Date}
   * @memberof OrderGridDto
   */
  startDate?: Date;
  /**
   *
   * @type {Date}
   * @memberof OrderGridDto
   */
  endDate?: Date;
  /**
   *
   * @type {string}
   * @memberof OrderGridDto
   */
  comment?: string | null;
  /**
   *
   * @type {number}
   * @memberof OrderGridDto
   */
  orderStatusName?: number;
}

export function OrderGridDtoFromJSON(json: any): OrderGridDto {
  return OrderGridDtoFromJSONTyped(json, false);
}

export function OrderGridDtoFromJSONTyped(json: any, ignoreDiscriminator: boolean): OrderGridDto {
  if (json === undefined || json === null) {
    return json;
  }
  return {
    orderId: !exists(json, "orderId") ? undefined : json["orderId"],
    startDate: !exists(json, "startDate") ? undefined : new Date(json["startDate"]),
    endDate: !exists(json, "endDate") ? undefined : new Date(json["endDate"]),
    comment: !exists(json, "comment") ? undefined : json["comment"],
    orderStatusName: !exists(json, "orderStatusName") ? undefined : json["orderStatusName"]
  };
}

export function OrderGridDtoToJSON(value?: OrderGridDto | null): any {
  if (value === undefined) {
    return undefined;
  }
  if (value === null) {
    return null;
  }
  return {
    orderId: value.orderId,
    startDate: value.startDate === undefined ? undefined : value.startDate.toISOString(),
    endDate: value.endDate === undefined ? undefined : value.endDate.toISOString(),
    comment: value.comment,
    orderStatusName: value.orderStatusName
  };
}
