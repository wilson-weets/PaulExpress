import * as React from "react";
import useReactRouter from "use-react-router";
import { SandwichCard } from "./SandwichCard";

interface ISandiwchListProps {}

export const SandiwchList: React.FunctionComponent<ISandiwchListProps> = props => {
  const { match } = useReactRouter<{ shopId: string }>();
  const shopId = React.useMemo(() => +match.params.shopId, [match.params.shopId]);
  return (
    <div>
      <SandwichCard sandwich={{}}></SandwichCard>SandiwchList works! (shopId = {shopId})
    </div>
  );
};
