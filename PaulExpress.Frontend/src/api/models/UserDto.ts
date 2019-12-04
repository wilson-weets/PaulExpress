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
 * @interface UserDto
 */
export interface UserDto {
  /**
   *
   * @type {number}
   * @memberof UserDto
   */
  userId?: number;
  /**
   *
   * @type {string}
   * @memberof UserDto
   */
  trigram?: string | null;
  /**
   *
   * @type {string}
   * @memberof UserDto
   */
  email?: string | null;
  /**
   *
   * @type {string}
   * @memberof UserDto
   */
  token?: string | null;
  /**
   *
   * @type {string}
   * @memberof UserDto
   */
  createdBy?: string | null;
  /**
   *
   * @type {Date}
   * @memberof UserDto
   */
  createdOn?: Date;
  /**
   *
   * @type {string}
   * @memberof UserDto
   */
  updatedBy?: string | null;
  /**
   *
   * @type {Date}
   * @memberof UserDto
   */
  updatedOn?: Date;
}

export function UserDtoFromJSON(json: any): UserDto {
  return UserDtoFromJSONTyped(json, false);
}

export function UserDtoFromJSONTyped(json: any, ignoreDiscriminator: boolean): UserDto {
  if (json === undefined || json === null) {
    return json;
  }
  return {
    userId: !exists(json, "userId") ? undefined : json["userId"],
    trigram: !exists(json, "trigram") ? undefined : json["trigram"],
    email: !exists(json, "email") ? undefined : json["email"],
    token: !exists(json, "token") ? undefined : json["token"],
    createdBy: !exists(json, "createdBy") ? undefined : json["createdBy"],
    createdOn: !exists(json, "createdOn") ? undefined : new Date(json["createdOn"]),
    updatedBy: !exists(json, "updatedBy") ? undefined : json["updatedBy"],
    updatedOn: !exists(json, "updatedOn") ? undefined : new Date(json["updatedOn"])
  };
}

export function UserDtoToJSON(value?: UserDto | null): any {
  if (value === undefined) {
    return undefined;
  }
  if (value === null) {
    return null;
  }
  return {
    userId: value.userId,
    trigram: value.trigram,
    email: value.email,
    token: value.token,
    createdBy: value.createdBy,
    createdOn: value.createdOn === undefined ? undefined : value.createdOn.toISOString(),
    updatedBy: value.updatedBy,
    updatedOn: value.updatedOn === undefined ? undefined : value.updatedOn.toISOString()
  };
}