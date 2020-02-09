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
 * @interface AggregateResult
 */
export interface AggregateResult {
  /**
   *
   * @type {string}
   * @memberof AggregateResult
   */
  key?: string | null;
  /**
   *
   * @type {number}
   * @memberof AggregateResult
   */
  readonly value?: number | null;
}

export function AggregateResultFromJSON(json: any): AggregateResult {
  return AggregateResultFromJSONTyped(json, false);
}

export function AggregateResultFromJSONTyped(json: any, ignoreDiscriminator: boolean): AggregateResult {
  if (json === undefined || json === null) {
    return json;
  }
  return {
    key: !exists(json, "key") ? undefined : json["key"],
    value: !exists(json, "value") ? undefined : json["value"]
  };
}

export function AggregateResultToJSON(value?: AggregateResult | null): any {
  if (value === undefined) {
    return undefined;
  }
  if (value === null) {
    return null;
  }
  return {
    key: value.key
  };
}