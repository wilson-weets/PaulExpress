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

/**
 *
 * @export
 * @enum {string}
 */
export enum EReferentialTypes {
  NUMBER_0 = 0,
  NUMBER_1 = 1
}

export function EReferentialTypesFromJSON(json: any): EReferentialTypes {
  return EReferentialTypesFromJSONTyped(json, false);
}

export function EReferentialTypesFromJSONTyped(json: any, ignoreDiscriminator: boolean): EReferentialTypes {
  return json as EReferentialTypes;
}

export function EReferentialTypesToJSON(value?: EReferentialTypes | null): any {
  return value as any;
}
