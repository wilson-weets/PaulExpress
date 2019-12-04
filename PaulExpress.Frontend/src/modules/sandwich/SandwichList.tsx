import * as React from "react";
import useReactRouter from "use-react-router";
import { SandwichCard } from "./SandwichCard";

interface ISandwichListProps {}

export const SandwichList: React.FunctionComponent<ISandwichListProps> = props => {
  const { match } = useReactRouter<{ shopId: string }>();
  const shopId = React.useMemo(() => +match.params.shopId, [match.params.shopId]);
  return (
    <div>
      <SandwichCard sandwich={{}}></SandwichCard>SandwichList works! (shopId = {shopId})
    </div>
  );
};
