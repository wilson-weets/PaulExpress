import * as React from "react";
import useReactRouter from "use-react-router";
import { SandwichCard } from "./SandwichCard";
import styled from "styled-components";
import { Colors } from "@blueprintjs/core";

interface ISandwichListProps {}

export const SandwichList: React.FunctionComponent<ISandwichListProps> = props => {
  const Container = styled.div<{ isDark: boolean }>`
    display: flex;
    flex-direction: Row;
    border: solid black 1px;
    border-radius: 7px;
    padding: 0.5rem;
    background-color: ${p => (p.isDark ? Colors.DARK_GRAY4 : Colors.LIGHT_GRAY5)};
    min-width: 200px;
    flex-wrap: wrap;
  `;

  const { match } = useReactRouter<{ shopId: string }>();
  const shopId = React.useMemo(() => +match.params.shopId, [match.params.shopId]);
  return (
    <Container isDark={false}>
      <div style={{ padding: "0.5rem" }}>
        <SandwichCard
          sandwich={{ name: "HardCodedSandwich", ingredients: "patates patates", unitPrice: 120 }}
        ></SandwichCard>
      </div>
      <div style={{ padding: "0.5rem" }}>
        <SandwichCard
          sandwich={{ name: "HardCodedSandwich", ingredients: "patates patates", unitPrice: 120 }}
        ></SandwichCard>
      </div>
      <div style={{ padding: "0.5rem" }}>
        <SandwichCard
          sandwich={{ name: "HardCodedSandwich", ingredients: "patates patates", unitPrice: 120 }}
        ></SandwichCard>
      </div>
      <div style={{ padding: "0.5rem" }}>
        <SandwichCard
          sandwich={{ name: "HardCodedSandwich", ingredients: "patates patates", unitPrice: 120 }}
        ></SandwichCard>
      </div>
      <div style={{ padding: "0.5rem" }}>
        <SandwichCard
          sandwich={{ name: "HardCodedSandwich", ingredients: "patates patates", unitPrice: 120 }}
        ></SandwichCard>
      </div>
      <div style={{ padding: "0.5rem" }}>
        <SandwichCard
          sandwich={{ name: "HardCodedSandwich", ingredients: "patates patates", unitPrice: 120 }}
        ></SandwichCard>
      </div>
      <div style={{ padding: "0.5rem" }}>
        <SandwichCard
          sandwich={{ name: "HardCodedSandwich", ingredients: "patates patates", unitPrice: 120 }}
        ></SandwichCard>
      </div>

      <div style={{ padding: "0.5rem" }}>
        <SandwichCard
          sandwich={{ name: "HardCodedSandwich", ingredients: "patates patates", unitPrice: 120 }}
        ></SandwichCard>
      </div>

      <div style={{ padding: "0.5rem" }}>
        <SandwichCard
          sandwich={{ name: "HardCodedSandwich", ingredients: "patates patates", unitPrice: 120 }}
        ></SandwichCard>
      </div>

      <div style={{ padding: "0.5rem" }}>
        <SandwichCard
          sandwich={{ name: "HardCodedSandwich", ingredients: "patates patates", unitPrice: 120 }}
        ></SandwichCard>
      </div>
    </Container>
  );
};
