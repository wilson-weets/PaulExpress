import * as React from "react";
import { useTl } from "../../hooks/useTl";
import { useHistory } from "react-router-dom";

interface ILockProps {}

export const Lock: React.FunctionComponent<ILockProps> = props => {
  const { t } = useTl();
  const history = useHistory();

  return <div>Lock works!</div>;
};
