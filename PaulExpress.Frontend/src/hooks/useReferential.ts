import { IOptionProps } from "@blueprintjs/core";
import { useApiEffect } from "nsitools-react";
import * as React from "react";

import { useApiService } from ".";
import { ReferentialApi, ReferentialResultInfoDto } from "../api";

export const useReferential = (
  func: (api: ReferentialApi) => Promise<ReferentialResultInfoDto>,
  asInt?: boolean,
  dependencies?: any[],
  nullable: boolean = true
): [IOptionProps[], boolean] => {
  const api = useApiService(ReferentialApi);
  const [data, loading] = useApiEffect(() => func(api), dependencies);

  const newData = React.useMemo(() => {
    if (data) {
      return data.list?.map(p => {
        return { value: p.idValue ? (asInt ? +p.idValue : p.idValue) : null, label: p.displayValue };
      }) as IOptionProps[];
    }
  }, [asInt, data]);

  const finalData = React.useMemo(() => {
    // if (newData && nullable) {
    //   newData.unshift({ value: undefined, label: "" } as IOptionProps);
    // }
    return newData;
  }, [newData]);

  return [finalData, loading];
};
